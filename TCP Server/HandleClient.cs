using System;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCP_Server
{
    class HandleClient
    {
        private ClientPackage clientPackage;
        private ServerForm serverForm;
        private Socket client;

        public void watchClient(ClientPackage clientPackage, ServerForm serverForm)
        {
            this.clientPackage = clientPackage;
            this.serverForm = serverForm;
            client = clientPackage.getClientSocket();
            Thread disconnect = new Thread(watchForDisconnect);
            disconnect.Start();
        }

        private void watchForDisconnect()
        {
            handleData();
            if(serverForm.isServerConnected())
                serverForm.sendClientDisconnect(clientPackage);
        }

        private void handleData()
        {
            NetworkStream networkStream = new NetworkStream(client);
            IFormatter formatter = new BinaryFormatter();
            while(true)
            {
                try
                {
                    if(clientPackage.packetSupport())
                    {
                        ClientPacket clientPacket = (ClientPacket)formatter.Deserialize(networkStream);
                        serverForm.handlePacket(clientPacket, client);
                    }
                    else
                    {
                        byte[] buffer = new byte[200000];
                        if(client.Receive(buffer) <= 0) return;
                        
                        //string[] data = Encoding.ASCII.GetString(buffer).Split('|');
                        //if(data.Length >= 3)
                        //    serverForm.handlePacket(new ClientPacket(clientPackage.getUserName(), clientPackage.getClientIP(), data[2].TrimEnd('\0'), data[0], data[1]), client);

                        try
                        {
                            string[] data = Encoding.ASCII.GetString(buffer).Split(':');
                            string number = new String(data[0].Where(Char.IsDigit).ToArray());
                            int index = Convert.ToInt32(number);
                            ClientPackage pack = serverForm.getClientPackages()[index];  
                            if(data[0].Contains("d") && pack == clientPackage)
                                return;
                            serverForm.handlePacket(new ClientPacket(clientPackage.getUserName(), clientPackage.getClientIP(), data[1].TrimEnd('\0'), pack.getUserName(), pack.getClientIP()), client);
                        }
                        catch(Exception){}
                    }
                }
                catch (Exception) { return; }
            }
        }
    }
}
            /*NetworkStream networkStream = new NetworkStream(client);
            StreamReader sr = new StreamReader(networkStream);
            while(true)
            {
                try
                {
                    int received = networkStream.Read(buffer, 0, BUFFER_SIZE);
                    if (received == 0) throw new Exception();

                    byte[] recBuf = new byte[received];
                    Array.Copy(buffer, recBuf, received);
                    string text = Encoding.ASCII.GetString(recBuf);

                     //Telnet support
                     if (text.Length <= 1)
                         text += sr.ReadLine();
                    string[] data = text.Split('|');
                    if (text != null)
                    {
                        for (int a = 0; a < data.Length; a++)
                            if (data[a].Length > 0)
                                serverForm.handleCommand(clientPackage, data[a]);
                    }
                }
                catch(Exception)
                {
                    break;
                }
            }
            networkStream.Dispose();
            if (clientPackage.isConnected())
                serverForm.handleCommand(clientPackage, "exit");
        }
    }
}*/
