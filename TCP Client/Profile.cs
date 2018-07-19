using System.Drawing;
using System.Net;
using System.Net.Sockets;

namespace TCP_Client
{
    class Profile
    {
        private string username;
        private Image contactPicture;
        private string IP;
        public Profile(string userName, Image contactPicture, Socket socket)
        {
            this.username = userName;
            this.contactPicture = contactPicture;
            IP = ((IPEndPoint)(socket.RemoteEndPoint)).Address.ToString();
        }

        public string getUsername() { return username; }
        public Image getContactPicture() { return contactPicture; }
        public string getIP() { return IP; }

        public void updateIP(string IP) { this.IP = IP; }
        public void updateUsername(string username) { this.username = username; }
    }
}
