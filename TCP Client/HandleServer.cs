using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCP_Client
{
    class HandleServer
    {
        private Socket client;
        private ClientForm clientForm;
        private const int BUFFER_SIZE = 200000000;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];
        public void watchServer(Socket client, ClientForm clientForm)
        {
            this.client = client;
            this.clientForm = clientForm;
            Thread disconnect = new Thread(watchForDisconnect);
            disconnect.Start();
        }

        private void watchForDisconnect()
        {
            handleData();
            clientForm.handleClientDisconnection();
        }

        private void handleData()
        {
            NetworkStream networkStream = new NetworkStream(client);
            IFormatter formatter = new BinaryFormatter();
            while(true)
            {
                try
                {
                    if(clientForm.packetSupport())
                    {
                        ClientPacket clientPacket = (ClientPacket)formatter.Deserialize(networkStream);
                        //Object clientPacket = (Object)formatter.Deserialize(networkStream);
                        Thread handleClientPacket = new Thread(clientForm.handlePacket);
                        handleClientPacket.Start((Object)clientPacket);
                    }
                    else
                    {
                        byte[] buffer = new byte[200000];
                        if (client.Receive(buffer) <= 0) return;
                        string data = Encoding.ASCII.GetString(buffer);
                        if (data.Length > 0)
                            clientForm.handlePacket(new ClientPacket("Server", ((IPEndPoint)(client.RemoteEndPoint)).Address.ToString(), data, "", ""));
                    }
                    //clientForm.handlePacket(clientPacket);
                }
                catch(Exception) { return; }
            }
        }
    }
}
/*
            NetworkStream networkStream = new NetworkStream(client);
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
                                clientForm.appendToOutput(data[a]);
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }
        }
    }
}*/