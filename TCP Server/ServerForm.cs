using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCP_Server
{
    public partial class ServerForm : Form
    {
        private Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private List<ClientPackage> clientPackages = new List<ClientPackage>();
        private const int PORT = 5000;
        private Object writeReady = new Object();

        public enum packetTypes
        {
            Connect,
            Disconnect,
            FriendRequest,
            Message,
        }

        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Shown(object sender, EventArgs e)
        {
            setupServer();
        }

        private void ServerForm_Closing(object sender, EventArgs e)
        {
            serverSocket.Close();
            //serverSocket.Dispose();
            int clients = clientPackages.Count;
            for (int a = 0; a < clients-1; a++)
                disconnectClient(clientPackages[1]);
        }

        //Responsible for binding our socket, and listening for connections
        private void setupServer()
        {
            try
            {
                appendToTextBox("Setting up server...");//24.158.165.87  192.168.56.1 IPAddress.Parse("0.0.0.0") IPAddress.Any
                serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
                serverSocket.Listen(10);
                serverSocket.BeginAccept(acceptCallBack, null);
                appendToTextBox("Server setup complete.");
                clientPackages.Add(new ClientPackage(null, "Server", null, true));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void acceptCallBack(IAsyncResult AR)
        {
            Socket client;
            try
            {
                client = serverSocket.EndAccept(AR);
            }
            catch(Exception)//I cannot seem to avoid this (on exit when properly closing sockets)
            {
                return;
            }
            //For A Faster Connection Listener
            Thread connect = new Thread(clientConnecting);
            connect.Start(client);
            serverSocket.BeginAccept(acceptCallBack, null);
        }

        private void clientConnecting(Object obj)
        {
            Socket client = (Socket)obj;
            NetworkStream networkStream = new NetworkStream(client);
            IFormatter formatter = new BinaryFormatter();
            
            ClientPacket clientPacket = null;
            try
            {
                //Try 3 time to connect via packets
                for(int a = 0; a < 3; a++)
                {
                    Thread.Sleep(50);
                    if (networkStream.DataAvailable)
                    {
                        clientPacket = (ClientPacket)formatter.Deserialize(networkStream);
                        break;
                    }
                }
                if(clientPacket == null)
                    throw new Exception();
            }
            catch(Exception)
            {
                clientPacket = new ClientPacket(new ClientPackage(client, "", Properties.Resources.user), 0);
                clientPacket.setPacketSupport(false);
                //byte[] buffer = new byte[100];
                //client.Receive(buffer);
                //MessageBox.Show(Encoding.ASCII.GetString(buffer));
            }
            handlePacket(clientPacket, client);
            networkStream.Close();
            HandleClient handleClient = new HandleClient();
            handleClient.watchClient(clientPackages[clientPackages.Count - 1], this);
        }

        public void handlePacket(ClientPacket packet, Socket client)
        {
            switch(packet.getPacketType())
            {
                case (int)packetTypes.Connect:
                    ClientPackage clientPackage = new ClientPackage(client,packet.getUsername(),packet.getContactPicture(),packet.packetSupport());
                    clientPackages.Add(clientPackage);
                    updateServerList(clientPackage.getUserName(),clientPackage.getClientIP());
                    appendToTextBox(clientPackage.getUserName() + " has Connected");
                    sendClientFriendRequests(client);//This is so that each client can update there friend list with the new connected person
                    break;
                case (int)packetTypes.Disconnect:
                    break;
                case (int)packetTypes.Message:
                    if(packet.getReceiverUserName() == "Server")
                    {
                        messages.Invoke(new MethodInvoker(delegate
                        {
                            messages.AppendText(packet.getUsername() + ": " + packet.getMessage() + "\n");
                        }));
                        //sendClientMessage(new ClientPacket("Server", packet.getClientIP(), packet.getUsername() + ", I'm busy so stop messaging me! (pissed)"), client);
                    }
                    else
                        sendClientMessage(packet);
                    break;
            }
        }

        private void sendClientMessage(ClientPacket packet)
        {
            //Find the Connection This Message Is For'
            //ClientPackage package = clientPackages.Find(x => x.getClientIP() == packet.getReceiverIP() && x.getUserName() == packet.getReceiverUserName());
            ClientPackage package = clientPackages.Find(x => x.getClientIP() == packet.getReceiverIP() && x.getUserName() == packet.getReceiverUserName());
            if (package == null) return;

            Socket client = package.getClientSocket();
            if(package.packetSupport())
            {
                IFormatter formatter = new BinaryFormatter();//the formatter that will serialize my object on my stream
                NetworkStream networkStream = new NetworkStream(client);
                formatter.Serialize(networkStream, packet);//the serialization process
                networkStream.Close();
            }
            else
            {
                client.Send(Encoding.ASCII.GetBytes(packet.getUsername() + "|" + packet.getClientIP() + "|  ->  " + packet.getMessage()));
            }
        }

        private void sendClientFriendRequests(Socket client)
        {
            IFormatter formatter = new BinaryFormatter();
            int friendCount = clientPackages.Count;

            //Update other Connected Clients Friend List
            for (int a = 1; a < friendCount - 1; a++)
            {
                if(clientPackages[a].isConnected() && clientPackages[a].packetSupport())
                {
                    if(clientPackages[a].packetSupport())
                    {
                        //Send a Friend Request packet to all the other clients
                        sendPacket(new ClientPacket(clientPackages[friendCount - 1], (int)packetTypes.FriendRequest), new NetworkStream(clientPackages[a].getClientSocket()), formatter);
                    }
                }
            }

            if(clientPackages[friendCount - 1].packetSupport())
            {
                //Send an update connection packet to the newly connected client
                sendPacket(new ClientPacket(clientPackages[friendCount - 1], (int)packetTypes.Connect), new NetworkStream(clientPackages[friendCount - 1].getClientSocket()), formatter);

                //Send all Friend Request Packets to the newly connected client
                List<ClientPacket> friendsList = new List<ClientPacket>();
                for (int a = 1; a < friendCount - 1; a++)
                    if (clientPackages[a].isConnected())
                        friendsList.Add(new ClientPacket(clientPackages[a], (int)packetTypes.FriendRequest));
                sendPacket(new ClientPacket(friendsList), new NetworkStream(client), formatter);
            }

            //Need to send all connected client information (not in packet form)
            //this is because another clinet is connected that is not packet supported.
            //I.E. Not running my client program.
            for(int a=1;a<friendCount;a++)//Loop through all to find all that dont support packets
            {
                if(!clientPackages[a].packetSupport())//Dont support packets... (NOT MINE)
                {
                    clientPackages[a].getClientSocket().Send(Encoding.ASCII.GetBytes("::Full Connected Friends List::"));
                    clientPackages[a].getClientSocket().Send(Encoding.ASCII.GetBytes("\r\nServer|" + clientPackages[a].getClientIP() + "| <--- User: 0"));
                    for (int b=1;b<friendCount;b++)
                        if(b != a)
                            clientPackages[a].getClientSocket().Send(Encoding.ASCII.GetBytes("\r\n" + clientPackages[b].getUserName() + " | " + clientPackages[b].getClientIP() + "| <--- User: " + b));
                        else
                            clientPackages[a].getClientSocket().Send(Encoding.ASCII.GetBytes("\r\n" + clientPackages[b].getUserName() + " | " + clientPackages[b].getClientIP() + "| <--- THIS IS YOU: " + b));
                    //clientPackages[a].getClientSocket().Send(Encoding.ASCII.GetBytes("\r\n"));
                }
            }
        }

        public void sendPacket(ClientPacket packet, NetworkStream stream, IFormatter formatter)
        {
            formatter.Serialize(stream, packet);
            stream.Close();
        }

        public void sendClientDisconnect(ClientPackage clientPackage)
        {
            IFormatter formatter = new BinaryFormatter();
            int index = clientPackages.IndexOf(clientPackage);
            updateServerList(index-1);
            disconnectClient(clientPackage);
            int clientCount = clientPackages.Count;
            for (int a = 1; a < clientCount; a++)
            {
                if(clientPackages[a].packetSupport())
                {
                    ClientPacket packet = new ClientPacket(clientPackage, (int)packetTypes.Disconnect);
                    NetworkStream networkStream = new NetworkStream(clientPackages[a].getClientSocket());
                    formatter.Serialize(networkStream, packet);
                    networkStream.Close();
                }
            }
        }

        private void disconnectClient(ClientPackage clientPackage)
        {
            clientPackage.getClientSocket().Close();
            clientPackage.getClientSocket().Dispose();
            clientPackages.Remove(clientPackage);
            appendToTextBox(clientPackage.getUserName() + " has Disconnected");
            //clientPackages.Remove(clientPackage);
            //appendToTextBox("Client disconnected");
        }

        public List<ClientPackage> getClientPackages()
        {
            return clientPackages;
        }

        //Cross thread safe
        private void updateServerList(string userName,string IP)
        {
            userList.Invoke(new MethodInvoker(delegate
            {
                userList.Items.Add((Object)userName);
                ipList.Items.Add((Object)IP);
            }));
        }

        private void updateServerList(int index)
        {
            userList.Invoke(new MethodInvoker(delegate
            {
                userList.Items.RemoveAt(index);
                ipList.Items.RemoveAt(index);
            }));
        }

        //Simple test to determine if server is still connected
        public bool isServerConnected()
        {
            try
            {
                return !(serverSocket.Poll(1, SelectMode.SelectRead) && serverSocket.Available == 0);
            }
            catch (Exception) { return false; }
        }

        //Cross-thread safe
        private void appendToTextBox(string text)
        {
            textBox1.Invoke(new MethodInvoker(delegate
            {
                textBox1.AppendText(text + "\r\n");
                textBox1.ScrollToCaret();
            }));
        }

        private void ipList_SelectedIndexChanged(object sender, EventArgs e)
        {
            userList.SelectedIndex = ipList.SelectedIndex;
        }
        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ipList.SelectedIndex = userList.SelectedIndex;
        }
        private void ipList_MouseDown(object sender, MouseEventArgs e)
        {
            userList.SelectedIndex = ipList.SelectedIndex;
        }
        private void userList_MouseDown(object sender, MouseEventArgs e)
        {
            ipList.SelectedIndex = userList.SelectedIndex;
        }

        //For sending data to a client From Server
        private void button1_Click(object sender, EventArgs e)
        {
            //clientPackages.Find(x => x.getClientIP() == ipList.Text && x.getUserName() == userList.Text)
            if (msgBox.Text != "" && ipList.SelectedIndex >= 0)
                sendClientMessage(new ClientPacket("Server",ipList.Text,msgBox.Text,userList.Text,ipList.Text));
            msgBox.Focus();
            msgBox.Clear();
            msgBox.SelectionStart = 0;
        }

        private void msgBox_TextChanged(object sender, EventArgs e)
        {
            if(ipList.SelectedIndex >= 0)
            {
                if (msgBox.Text == "" || msgBox.ForeColor == Color.FromArgb(102, 116, 134))
                    btnSend.Enabled = false;
                else
                    btnSend.Enabled = true;
            }
            int line = msgBox.GetLineFromCharIndex(msgBox.Text.Length - 1);
            if (line < 5)
            {
                msgPanel.Height = 68 + (22 * line);
                msgBox.Height = 28 + (22 * line);
            }
        }

        private void msgBox_Resize(object sender, EventArgs e)
        {
            int line = msgBox.GetLineFromCharIndex(msgBox.Text.Length - 1);
            if (line < 5)
            {
                msgPanel.Height = 68 + (22 * line);
                msgBox.Height = 28 + (22 * line);
            }
        }

        private void msgBox_Enter(object sender, EventArgs e)
        {
            invokeMessageBox();
            //msgBar.BackColor = Color.FromArgb(7, 125, 180);
            msgBox.Cursor = Cursors.IBeam;
        }

        private void msgBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(Keys.Enter == e.KeyCode)
            {
                e.SuppressKeyPress = true;
                btnSend.PerformClick();
            }
        }

        private void msgBox_Leave(object sender, EventArgs e)
        {
            invokeMessageBox();
            //msgBar.BackColor = Color.FromArgb(216, 229, 239);
            msgBox.Cursor = Cursors.Default;
        }

        //Will either activate or dactivate the box
        public void invokeMessageBox(bool ignore = false)
        {
            if (msgBox.Text == "" && msgBox.ForeColor != Color.FromArgb(102, 116, 134) && !ignore)
            {
                msgBox.ForeColor = Color.FromArgb(102, 116, 134);
                msgBox.Font = new Font("Segoe UI", 9.5F);
                msgBox.Text = "Type a message here";
                if(ipList.SelectedIndex >= 0) btnSend.Enabled = false;
                return;
            }
            else if (msgBox.Text != "" && ipList.SelectedIndex >= 0) btnSend.Enabled = true;

            if (msgBox.ForeColor != Color.FromArgb(43, 43, 48))
            {
                msgBox.Clear();
                msgBox.ForeColor = Color.FromArgb(43, 43, 48);
                msgBox.Font = new Font("Segoe UI", 10.15F);
            }
        }
    }
}