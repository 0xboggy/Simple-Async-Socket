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

namespace TCP_Client
{
    public partial class ClientForm : Form
    {
        private Socket clientSocket;
        private const int PORT = 5000;
        public List<Contact> contactList = new List<Contact>();

        private bool clientNameReady;//Used for name box UI
        private bool applicationClosed = false;
        public int contactIndex = -1;//Which friend are you really clicked on
        ContactUI currentContactUI;
        private Profile profile;
        private EmojiPanel emoji;
        public bool packetHandling = true;//box is checked

        public enum packetTypes
        {
            Connected,
            Disconnect,
            FriendRequest,
            Message,
        }

        public bool packetSupport()
        {
            return packetHandling;
        }

        //Rich Text Box UI Bug Fix...Flickering Cursor Image Fix
        protected override void WndProc(ref Message m)
        {
            const int WM_SETCURSOR = 0x20;
            base.WndProc(ref m);
            if(m.Msg == WM_SETCURSOR)
                m.Result = (IntPtr)1;
        }

        public ClientForm()
        {
            InitializeComponent();
            emoji = new EmojiPanel(this);
            msgBox.setEmojiRef(emoji);//Update richtextbox to have a reference to the emojiPanel
        }

        //TESTING
        private void ClientForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ClientForm_Closing(object sender, EventArgs e)
        {
            clientDisconnect();
            applicationClosed = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(clientDisconnect()) return;
            updateConnectButton("Connecting...", false);

            //Only threaded because this method call needs to end for the button attributes to update. i.e.) .Enabled
            string username = nameBox.Text;
            if (!clientNameReady)
                username = "";
            Thread connect = new Thread(attempConnection);
            connect.Start(username);
        }

        //BUG:: Will hang if you close the form before establishing a connection...fix later
        private void attempConnection(Object obj)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            while(!clientSocket.Connected)
            {
                try
                {
                    //192.168.1.4     127.0.0.1       24.158.165.87  24.158.165.87   97.81.178.151
                    clientSocket.Connect(IPAddress.Parse("127.0.0.1"),PORT);
                }
                catch(Exception)
                {
                    MessageBox.Show("Could not establish a connection with the server!","Connection Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    updateConnectButton("Connect");
                    return;
                }
            }
            //Begin Listening For Server Packets
            HandleServer server = new HandleServer();
            server.watchServer(clientSocket,this);

            updateConnectButton("Disconnect");
            profile = new Profile((string)obj,contactPicture.Image,clientSocket);

            //Talk With Server
            Contact contact = new Contact(new ClientPacket("Server", Properties.Resources.Nerdy, (int)packetTypes.FriendRequest, profile.getIP()));
            updateContacts(contact);
            contactList.Insert(0, contact);

            //SERVER PACKET SUPPORT ONLY BELOW
            //Connected Here (send the first client packet to the server)
            if(packetSupport())
            {
                ClientPacket packet = new ClientPacket(profile.getUsername(), profile.getContactPicture(), 0);
                IFormatter formatter = new BinaryFormatter();//the formatter that will serialize my object on my stream
                NetworkStream networkStream = new NetworkStream(clientSocket);
                formatter.Serialize(networkStream, packet);//the serialization process
                networkStream.Close();
            }
        }

        private bool clientDisconnect()
        {
            if(clientSocket != null && clientSocket.Connected)
            {
                clientSocket.Close();
                return true;
            }
            return false;
        }

        public void handleClientDisconnection()
        {
            if(applicationClosed) return;//In case you close the form while connected
            updateConnectButton("Connect");
            updateContacts();
            contactList.Clear();
            clientSocket = null;
        }

        public void handlePacket(Object obj)
        {
            ClientPacket packet = (ClientPacket)obj;
            switch (packet.getPacketType())
            {
                case (int)packetTypes.Connected://Update profile information, I.E. IP address
                    profile.updateIP(packet.getClientIP());
                    profile.updateUsername(packet.getUsername());

                    //Talk With Server
                    //Contact contact = new Contact(new ClientPacket("Server", Properties.Resources.Nerdy, (int)packetTypes.FriendRequest, profile.getIP()));
                    //updateContacts(contact);
                    //contactList.Insert(0,contact);

                    break;
                case (int)packetTypes.Disconnect://Delete Friend
                    int index = contactList.FindIndex(x => x.getPacket().getUsername() == packet.getUsername() && x.getPacket().getClientIP() == packet.getClientIP());
                    if(index >= 0)
                    {
                        updateContacts(index);
                        contactList.RemoveAt(index);
                    }
                    break;
                case (int)packetTypes.FriendRequest://Add Contact (Check if list is sent)
                    if(packet.getFriendsList() != null)
                    {
                        updateConnectButton("Connected", false);
                        Thread.Sleep(50);
                        List<ClientPacket> packetList = packet.getFriendsList();
                        for (int a = 0; a < packetList.Count; a++)
                            handlePacket(packetList[a]);
                        Thread.Sleep(400);//Dont want to spam connect/disconnct button
                        updateConnectButton("Disconnect");
                    }
                    else
                    {
                        Contact contact = new Contact(packet);
                        contactList.Insert(0,contact);
                        updateContacts(contact);
                        //MessageBox.Show("here rrrr");
                    }
                    break;
                case (int)packetTypes.Message:
                    index = contactList.FindIndex(x => x.getPacket().getUsername() == packet.getUsername() && x.getPacket().getClientIP() == packet.getClientIP());
                    if (index >= 0)
                        receiveMessage(index,packet.getMessage());
                    break;
            }
        }

        //Cross thread safe
        private void updateContacts(Object obj = null)
        {
            contacts.Invoke(new MethodInvoker(delegate
            {
                if (obj == null)//delete all info
                {
                    //convoBox.Clear();
                    convoPanel.Controls.Clear();
                    msgBox.Clear();
                    contacts.Controls.Clear();
                    contactIndex = -1;
                    currentContact.Controls.Clear();
                    currentContactUI = null;
                    //friendsList.Items.Clear();
                }
                else if (obj is Contact)
                {
                    Contact contact = (Contact)obj;
                    Panel tab = contact.getContactTab();
                    Label name = contact.getContactName();
                    PictureBox pic = contact.getContactPicture();
                    contacts.Controls.Add(tab);
                    contacts.Controls.SetChildIndex(tab, 0);
                    if (contactIndex >= 0)
                        contactIndex++;

                    tab.MouseEnter += (sender, e) => tab_MouseEnter(tab, e);
                    name.MouseEnter += (sender, e) => tab_MouseEnter(tab, e);
                    pic.MouseEnter += (sender, e) => tab_MouseEnter(tab, e);

                    tab.MouseLeave += (sender, e) => tab_MouseLeave(tab, e);
                    name.MouseLeave += (sender, e) => tab_MouseLeave(tab, e);
                    pic.MouseLeave += (sender, e) => tab_MouseLeave(tab, e);

                    tab.MouseDown += (sender, e) => tab_MouseClick(tab, e);
                    name.MouseDown += (sender, e) => tab_MouseClick(tab, e);
                    pic.MouseDown += (sender, e) => tab_MouseClick(tab, e);

                    tab.MouseClick += (sender, e) => tab_MouseClicked(tab, e);
                    name.MouseClick += (sender, e) => tab_MouseClicked(tab, e);
                    pic.MouseClick += (sender, e) => tab_MouseClicked(tab, e);

                    //Contact friend = new Contact((string)obj);
                    //Panel tab = friendTab((string)obj);
                    //friendsList.Items.Add(obj);
                }
                else if (obj is int)//delete one friend
                {
                    contacts.Controls.RemoveAt((int)obj);
                    if (contactIndex == (int)obj)
                    {
                        //convoBox.Clear();
                        convoPanel.Controls.Clear();
                        msgBox.Clear();
                        contactIndex = -1;
                        currentContact.Controls.Clear();
                        currentContactUI = null;
                    }
                    else if ((int)obj < contactIndex)
                        contactIndex--;
                    //friendsList.Items.RemoveAt((int)obj);
                }
            }));
        }

        private void updateConnectButton(string text, bool enable = true)
        {
            btnConnect.Invoke(new MethodInvoker(delegate
            {
                btnConnect.Text = text;
                btnConnect.Enabled = enable;
            }));
        }

        private void receiveMessage(int index,string message)
        {
            contacts.Invoke(new MethodInvoker(delegate
            {
                Contact contact = contactList[index];
                //Notify you that you got a message
                //contactList[index].updateConversation(message);
                if(contactIndex != index)
                {
                    //Reset Friend Name
                    contact.getContactName().Text = contact.getPacket().getUsername();
                    contact.newUnreadMessage(message,DateTime.Now.ToString("h:mm tt"));
                    contact.getContactName().Text += " ("+ contact.getUnreadMessageCount().ToString()+")";
                }
                else
                {
                    convoPanel.Invoke(new MethodInvoker(delegate
                    {
                        int buffer = 4;
                        List<Control> currentConversation = contact.getConversationUI();
                        if(convoPanel.Controls.Count > 0)
                        {
                            //Check if last message was not yours
                            if(convoPanel.Controls[0].Controls[0].BackColor == Color.FromArgb(240, 244, 248))
                            {
                                //Check if your within time frame to merge received messages
                                if (convoPanel.Controls[0].Controls[1].Text == DateTime.Now.ToString("h:mm tt"))
                                {
                                    MyFixedRichTextBox.AppendText((MyFixedRichTextBox)convoPanel.Controls[0].Controls[0].Controls[0], "\r\n" + message, emoji);
                                    convoPanel.AutoScrollPosition = new Point(0, convoPanel.VerticalScroll.Maximum);
                                    //Update new message to the conversationUI
                                    contact.updateConversation(currentConversation.Count - 1, convoPanel.Controls[0]);
                                    return;
                                }
                                else
                                {
                                    //not within time frame so go ahead and buffer new space
                                    /*Panel buffer = ChatUI.getPanelBuffer(4);
                                    contact.updateConversation(buffer);
                                    convoPanel.Controls.Add(buffer);
                                    convoPanel.Controls.SetChildIndex(buffer, 0);*/
                                }
                            }
                            else
                            {
                                //Message was yours, so append space
                                buffer = 14;
                                /*Panel buffer = ChatUI.getPanelBuffer(14);
                                contact.updateConversation(buffer);
                                convoPanel.Controls.Add(buffer);
                                convoPanel.Controls.SetChildIndex(buffer, 0);*/
                            }
                        }

                        //Append new message to your convoBox
                        ChatUI msg = new ChatUI(message, DateTime.Now.ToString("h:mm tt"), contact.getContactPicture().Image,buffer,emoji);
                        Panel messageTab = msg.getMessageTab();
                        MyFixedRichTextBox messageBox = msg.getMessageBox();
                        emoji.insertEmoji(messageBox);
                        contact.updateConversation(messageTab);
                        convoPanel.Controls.Add(messageTab);
                        convoPanel.Controls.SetChildIndex(messageTab, 0);
                        convoPanel.AutoScrollPosition = new Point(0, convoPanel.VerticalScroll.Maximum);

                        //convoBox.Text = contactList[index].getConversation();
                        //convoBox.SelectionStart = convoBox.TextLength;
                        //convoBox.ScrollToCaret();
                    }));
                }
            }));
        }


        /*if (clientSocket != null && clientSocket.Connected)
        {
            disconnect();
            return;
        }

        int attempts = 0;
        clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        while (!clientSocket.Connected)
        {
            try
            {
                attempts++;
                if (attempts > 3)
                {
                    appendToOutput("Connection Failed.");
                    return;
                }
                appendToOutput("Connection attempt " + attempts);
                //Change IPAddress.Loopback to a remote IP to connect to a remote host.
                clientSocket.Connect(IPAddress.Parse("192.168.1.4"), PORT);
            }
            catch (SocketException)
            {
                //Console.Clear();
            }
        }

        HandleServer server = new HandleServer();
        server.watchServer(ref clientSocket,this);

        //server.watchClient(clientPackages[clientPackages.Count - 1], this);
        updateControlStates(true);
        appendToOutput("Connected");*/

        private void disconnect()
        {
            sendString("exit");//Tell the server we are exiting
            updateControlStates(false);
            clientSocket.Close();
        }

        /// <summary>
        /// A thread safe way to enable the send button
        /// </summary>
        /// <param name="toggle"></param>
        private void updateControlStates(bool toggle)
        {
            btnSend.Invoke(new MethodInvoker(delegate
            {
                btnSend.Enabled = toggle;
                //btnConnect.Enabled = !toggle;
                if(toggle)
                    btnConnect.Text = "Disconnect";
                else
                    btnConnect.Text = "Connect";
            }));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //We have a name selected
            if(contactIndex >= 0)
            {
                string message = decode(msgBox.Text);

                Contact contact = contactList[contactIndex];
                contact.saveCurrentMessage("");
                msgBox.Focus();//FOCUS NEEDS TO HAPPEN FIRST
                msgBox.Clear();

                if(packetSupport())
                {
                    //Send a Message Packet To Server, need to update friends convoBox and conversation string
                    ClientPacket packet = new ClientPacket(profile.getUsername(), profile.getIP(), message, contact.getPacket().getUsername(), contact.getPacket().getClientIP());
                    IFormatter formatter = new BinaryFormatter();//the formatter that will serialize my object on my stream
                    NetworkStream networkStream = new NetworkStream(clientSocket);
                    formatter.Serialize(networkStream, packet);//the serialization process
                    networkStream.Close();
                }
                else
                {
                    clientSocket.Send(Encoding.ASCII.GetBytes(message));
                }

                //Append new message to our convoBox
                //appendToConvoBox("You: " + message);

                //Save our msg to our conversation string
                //contact.setConversation(convoBox.Text);

                int buffer = 4;
                List<Control> currentConversation = contact.getConversationUI();
                if(convoPanel.Controls.Count > 0)
                {
                    //Check if last message was yours
                    if(convoPanel.Controls[0].Controls[0].BackColor == Color.FromArgb(199, 237, 252))
                    {
                        //Check if your within time frame to merge messages
                        if(convoPanel.Controls[0].Controls[1].Text == DateTime.Now.ToString("h:mm tt"))
                        {
                            MyFixedRichTextBox.AppendText((MyFixedRichTextBox)convoPanel.Controls[0].Controls[0].Controls[0], "\r\n" + message,emoji);
                            convoPanel.AutoScrollPosition = new Point(0, convoPanel.VerticalScroll.Maximum);
                            //Update new message to the conversationUI
                            contact.updateConversation(currentConversation.Count-1,convoPanel.Controls[0]);
                            return;
                        }
                        else
                        {
                            //convoPanel.Visible = false;
                            //not within time frame so go ahead and buffer new space
                           /* Panel buffer = ChatUI.getPanelBuffer(4);
                            convoPanel.Controls.Add(buffer);
                            convoPanel.Controls.SetChildIndex(buffer, 0);
                            contact.updateConversation(buffer);*/ 
                        }
                    }
                    else
                    {
                        buffer = 14;
                        //convoPanel.Visible = false;
                        //Message was not yours, so append space
                        /*Panel buffer = ChatUI.getPanelBuffer(14);
                        convoPanel.Controls.Add(buffer);
                        convoPanel.Controls.SetChildIndex(buffer, 0);
                        contact.updateConversation(buffer);*/
                    }
                }

                //Append new message to our convoBox
                ChatUI msg = new ChatUI(message,buffer,emoji);
                Panel messageTab = msg.getMessageTab();
                MyFixedRichTextBox messageBox = msg.getMessageBox();
                emoji.insertEmoji(messageBox);
                contact.updateConversation(messageTab);
                convoPanel.Controls.Add(messageTab);
                convoPanel.Controls.SetChildIndex(messageTab, 0);
                convoPanel.AutoScrollPosition = new Point(0, convoPanel.VerticalScroll.Maximum);
                //convoPanel.Visible = true;
            }
        }

        //convert any/all emoji to there represented codes
        private string decode(string message)
        {
            return msgBox.DecodeEmoji(emoji.getEmojiCodes(), message);
        }

        private void sendString(string text)
        {
            text += "|";//This is used as a seperator for tokenizing multiple data sent at once
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            try
            {
                clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
            }
            catch(Exception)//Server Has Disconnected or Client lost connection
            {
                updateControlStates(false);
                return;
            }
        }

        private void receiveResponse()
        {
            byte[] buffer = new byte[200000000];
            int received = 0;

            try
            {
                clientSocket.ReceiveTimeout = 10;
                received = clientSocket.Receive(buffer, 0, buffer.Length, SocketFlags.None);
            }
            catch (SocketException){}

            if(received == 0) return;
            byte[] data = new byte[received];
            Array.Copy(buffer, data, received);
            string text = Encoding.ASCII.GetString(data);
        }

        //Change convoBox to new conversation when new client is clicked
        private void friendsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*//This statement isnt needed...just insurance
            if(friendsList.SelectedIndex < 0)
            {
                convoBox.Clear();
                return;
            }

            int index = friendsList.SelectedIndex;
            friendsList.Items.RemoveAt(index);
            friendsList.Items.Insert(index,friendData[index].getPacket().getUsername());
            friendsList.SelectedIndex = index;

            //int index = friendsList.SelectedIndex;
            //string name = friendData[index].getPacket().getUsername();
            //friendsList.Items[index] = (Object)name;

            int index = friendsList.SelectedIndex;
            convoBox.Text = contactList[index].getConversation();
            convoBox.SelectionStart = convoBox.TextLength;
            convoBox.ScrollToCaret();
            string name = contactList[index].getPacket().getUsername();
            if (friendsList.Items[index] != (Object)name)
                friendsList.Items[index] = (Object)name;*/
        }

        //UI LOGIC BELOW
        private void tab_MouseEnter(object sender, EventArgs e)
        {
            Panel pan = (Panel)sender;
            if(contactIndex != contacts.Controls.IndexOf(pan))
                pan.BackColor = Color.FromArgb(230, 244, 248);
        }

        private void tab_MouseLeave(object sender, EventArgs e)
        {
            Panel pan = (Panel)sender;
            if (contactIndex != contacts.Controls.IndexOf(pan))
            {
                pan.BackColor = Color.FromArgb(240, 244, 248);
                if(contactIndex >= 0)
                {
                    Panel controller = (Panel)contacts.Controls[contactIndex];
                    controller.BackColor = Color.FromArgb(199, 237, 252);
                }
            }
        }

        //Mouse Click
        private void tab_MouseClick(object sender, EventArgs e)
        {
            Panel pan = (Panel)sender;
            if (contactIndex != contacts.Controls.IndexOf(pan))
            {
                pan.BackColor = Color.FromArgb(199, 237, 252);
                if (contactIndex >= 0)
                {
                    Panel controller = (Panel)contacts.Controls[contactIndex];
                    controller.BackColor = Color.FromArgb(240, 244, 248);
                }
            }
        }

        //Mouse Clicked
        private void tab_MouseClicked(object sender, EventArgs e)
        {
            Panel pan = (Panel)sender;
            if(contactIndex != contacts.Controls.IndexOf(pan))
            {
                if (contactIndex >= 0)
                {
                    Panel controller = (Panel)contacts.Controls[contactIndex];
                    controller.BackColor = Color.FromArgb(240, 244, 248);
                }

                convoPanel.Visible = false;
                msgBox.Enabled = false;
                msgBox.Enabled = true;
                contactIndex = contacts.Controls.IndexOf(pan);
                Contact contact = contactList[contactIndex];

                List<UnreadMessage> unreadMessages = contact.getUnreadMessageList();
                List<Control> conversationUI = contact.getConversationUI();
                //Check and update all unread messages && Recreate new conversation
                for(int a=0;a<contact.getUnreadMessageCount();a++)
                {
                    string message = unreadMessages[a].getMessage();
                    string date = unreadMessages[a].getDate();
                    if(conversationUI.Count > 0 && conversationUI[conversationUI.Count-1].Controls[1].Text == date)//Merger
                    {
                        //Convert any emoji codes that might be inside the message
                        MyFixedRichTextBox.AppendText((MyFixedRichTextBox)conversationUI[conversationUI.Count - 1].Controls[0].Controls[0], "\r\n" + message, emoji);
                        contact.updateConversation(conversationUI.Count-1,conversationUI[conversationUI.Count-1]);
                    }
                    else
                    {
                        //New Message, so create the buffer first
                        //contact.updateConversation(ChatUI.getPanelBuffer(4));
                        Panel newMessage = new ChatUI("", date, contact.getContactPicture().Image,4,emoji).getMessageTab();
                        MyFixedRichTextBox.AppendText((MyFixedRichTextBox)newMessage.Controls[0].Controls[0], message, emoji);
                        contact.updateConversation(newMessage);
                    }
                }
                contact.clearUnreadMessages();

                convoPanel.Controls.Clear();
                conversationUI = contact.getConversationUI();
                for (int a = 0; a < conversationUI.Count; a++)
                {
                    convoPanel.Controls.Add(conversationUI[a]);
                    convoPanel.Controls.SetChildIndex(conversationUI[a], 0);
                }
                convoPanel.AutoScrollPosition = new Point(0, convoPanel.VerticalScroll.Maximum);

                //convoBox.Text = contactList[contactIndex].getConversation();
                //convoBox.SelectionStart = convoBox.TextLength;
                //convoBox.ScrollToCaret();
                string name = contact.getPacket().getUsername();
                if (contact.getContactName().Text != name)
                    contact.getContactName().Text = name;

                //Add the new contact to the current contact panel
                if (currentContact.Controls.Count == 0)
                {
                    currentContactUI = new ContactUI(contact.getPacket().getUsername(), contact.getPacket().getContactPicture(), false);
                    currentContact.Controls.Add(currentContactUI.getContactUITab());
                    currentContact.Controls.SetChildIndex(currentContactUI.getContactUITab(), 0);
                    //Might add user controls below for when you click the current contact tab
                }
                else
                {
                    //Update the picture and name for the current contact tab
                    currentContactUI.getContactUIName().Text = contact.getPacket().getUsername();
                    currentContactUI.getContactUIPicture().Image = contact.getContactPicture().Image;
                }

                //Handle msgBox text -- might have a message previously typed but not sent?
                if(contact.getCurrentMessage() == "")
                {
                    msgBox.ForeColor = Color.FromArgb(102, 116, 134);
                    msgBox.Font = new Font("Segoe UI", 9.5F);
                    msgBox.Text = "Type a message here";
                }
                else
                {
                    msgBox.ForeColor = Color.FromArgb(43, 43, 48);
                    msgBox.Font = new Font("Segoe UI", 10.15F);
                    msgBox.Text = contact.getCurrentMessage();
                    emoji.insertEmoji(msgBox);
                }
                convoPanel.Visible = true;
            }
        }

        private void msgBox_TextChanged(object sender, EventArgs e)
        {
            if(contactIndex >= 0)
            {
                if(msgBox.Text == "" && msgBox.GetObjectCount(msgBox) == 0 || msgBox.ForeColor == Color.FromArgb(102, 116, 134))//msgBox.Text != "" && !msgBox.Focused)
                    btnSend.Enabled = false;
                else
                    btnSend.Enabled = true;
            }
            int line = msgBox.GetLineFromCharIndex(msgBox.Text.Length - 1);
            if(line < 5)
            {
                msgPanel.Height = 68 + (22 * line);
                msgBox.Height = 28 + (22 * line);
            }
        }

        private void msgBox_Resize(object sender, EventArgs e)
        {
            if(btnSend.Location.X > 25)
                msgBox.RightMargin = btnSend.Location.X - 25;
            int line = msgBox.GetLineFromCharIndex(msgBox.Text.Length - 1);
            if(line < 5)
            {
                msgPanel.Height = 68 + (22 * line);
                msgBox.Height = 28 + (22 * line);
            }
        }

        //On Focus
        private void msgBox_Enter(object sender, EventArgs e)
        {
            //Only run if you are clicked on a contact
            /*if (contactIndex >= 0)
                if (contactList[contactIndex].getCurrentMessage() == "")
                {
                    if (msgBox.GetObjectCount(msgBox) == 0)
                        msgBox.Clear();//Delete user friendly default text
                    msgBox.ForeColor = Color.FromArgb(43, 43, 48);
                    msgBox.Font = new Font("Segoe UI", 10.15F);
                }
                else btnSend.Enabled = true;*/
            invokeMessageBox();
            msgBar.BackColor = Color.FromArgb(7,125,180);
            msgBox.Cursor = Cursors.IBeam;
        }

        private void msgBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                e.SuppressKeyPress = true;
                btnSend.PerformClick();
                msgBox.Clear();
                msgBox.SelectionStart = 0;
            }
        }

        //Lost Focus
        private void msgBox_Leave(object sender, EventArgs e)
        {
            saveCurrentMessage();
            //Only run if you are clicked on a contact
            /*if(contactIndex >= 0)
                if(msgBox.Text == "" && msgBox.GetObjectCount(msgBox) == 0)
                {
                    msgBox.ForeColor = Color.FromArgb(102, 116, 134);
                    msgBox.Font = new Font("Segoe UI", 9.5F);
                    msgBox.Text = "Type a message here";
                }*/
            invokeMessageBox();
            msgBar.BackColor = Color.FromArgb(216,229,239);
            msgBox.Cursor = Cursors.Default;
        }

        //Will either activate or dactivate the box
        public void invokeMessageBox(bool ignore = false)
        {
            if(msgBox.Text == "" && msgBox.GetObjectCount(msgBox) == 0 && msgBox.ForeColor != Color.FromArgb(102, 116, 134) && !ignore)
            {
                msgBox.ForeColor = Color.FromArgb(102, 116, 134);
                msgBox.Font = new Font("Segoe UI", 9.5F);
                msgBox.Text = "Type a message here";
                if(contactIndex >= 0) btnSend.Enabled = false;
                return;
            }
            else if((msgBox.Text != "" || msgBox.GetObjectCount(msgBox) > 0) && contactIndex >= 0) btnSend.Enabled = true;

            if (msgBox.ForeColor != Color.FromArgb(43, 43, 48))
            {
                msgBox.Clear();
                msgBox.ForeColor = Color.FromArgb(43, 43, 48);
                msgBox.Font = new Font("Segoe UI", 10.15F);
            }
        }

        public void saveCurrentMessage()
        {
            if(contactIndex >= 0)
                contactList[contactIndex].saveCurrentMessage(decode(msgBox.Text));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            emoji.Visible = true;
            Point controlPoint = emojiPanel.PointToScreen(Point.Empty);
            emoji.Location = new Point(controlPoint.X + emojiPanel.Width - emoji.Width, controlPoint.Y - emoji.Height);
            //saveCurrentMessage();
        }

        private void emojiPanel_MouseEnter(object sender, EventArgs e)
        {
            emojiPanel.Image = global::TCP_Client.Properties.Resources.Emoji;
        }

        private void emojiPanel_MouseLeave(object sender, EventArgs e)
        {
            if(!emoji.Visible)
                emojiPanel.Image = global::TCP_Client.Properties.Resources.Emoji_Dark;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Change Picture");
            OpenFileDialog pic = new OpenFileDialog();
            pic.Title = "Get Image";
            pic.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|BMP Files: (*.BMP; *.DIB; *.RLE)|*.BMP;*.DIB;*.RLE|JPEG Files: (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF|GIF Files: (*.GIF)|*.GIF|PNG Files: (*.PNG)|*.PNG";

            if (pic.ShowDialog() == DialogResult.OK)
            {
                contactPicture.Image = Image.FromFile(pic.FileName);
            }
        }

        private void nameBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(!clientNameReady)
            {
                nameBox.Clear();
                nameBox.ForeColor = Color.FromArgb(43, 43, 48);
                clientNameReady = true;
            }
        }

        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(!clientNameReady)
            {
                nameBox.Clear();
                nameBox.ForeColor = Color.FromArgb(43, 43, 48);
                clientNameReady = true;
            }
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if(clientNameReady && nameBox.Text == "")
            {
                nameBox.ForeColor = Color.FromArgb(102, 116, 134);
                clientNameReady = false;
                nameBox.Text = "Client Name Here";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            packetHandling = checkBox1.Checked;
        }
    }
}