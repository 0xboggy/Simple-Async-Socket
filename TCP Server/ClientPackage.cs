using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;

namespace TCP_Server
{
    public class ClientPackage
    {
        Random random = new Random();
        private Socket clientSocket;
        private string userName;
        private Image contactPicture;
        private string clientIP;
        bool canHandlePackets;//This is to have a clear indication on whether my client form is being used or not

        public ClientPackage(Socket socket,string userName, Image contactPicture, bool canHandlePackets = false)
        {
            setClientSocket(socket);
            if(socket != null)
                clientIP = ((IPEndPoint)(socket.RemoteEndPoint)).Address.ToString();
            if(userName == "")
                this.userName = clientIP;
            else
                this.userName = userName;
            this.contactPicture = contactPicture;
            this.canHandlePackets = canHandlePackets;
        }

        public bool packetSupport() { return canHandlePackets; }

        private void setClientSocket(Socket socket) { clientSocket = socket; }

        public Socket getClientSocket() { return clientSocket; }
        public bool isConnected() { return clientSocket.Connected; }
        public string getUserName() { return userName; }
        public Image getContactPicture() { return contactPicture; }
        public string getClientIP() { return clientIP; }
    }
}
