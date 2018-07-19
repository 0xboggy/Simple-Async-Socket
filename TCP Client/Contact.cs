using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TCP_Client
{
    public class Contact
    {
        private List<Control> conversationUI;
        private List<UnreadMessage> unreadMessages = new List<UnreadMessage>();
        private string currentMessge = "";//Your message in the textbox before you send it
        private ClientPacket contactPacket;
        private ContactUI contactUI;

        public Contact(ClientPacket packet)
        {
            conversationUI = new List<Control>();
            contactPacket = packet;
            contactUI = new ContactUI(packet.getUsername(),packet.getContactPicture(), true);
        }

        public void updateContactName(string name) { contactUI.getContactUIName().Text = name; }
        public void updateContactPicture(Image picture) { contactUI.getContactUIPicture().Image = picture; }
        public void updateConversation(int index, Control control) { conversationUI[index] = control; }
        public void updateConversation(Control control) { conversationUI.Add(control); }

        public void saveCurrentMessage(string message) { currentMessge = message; }
        public Panel getContactTab() { return contactUI.getContactUITab(); }
        public Label getContactName() { return contactUI.getContactUIName(); }
        public PictureBox getContactPicture() { return contactUI.getContactUIPicture(); }
        public List<Control> getConversationUI() { return conversationUI; }
        public string getCurrentMessage() { return currentMessge; }
        public ClientPacket getPacket() { return contactPacket; }

        //Unread message functions below
        public void newUnreadMessage(string message, string date) { unreadMessages.Add(new UnreadMessage(message, date)); }
        public void clearUnreadMessages() { unreadMessages.Clear(); }
        public int getUnreadMessageCount() { return unreadMessages.Count; }
        public List<UnreadMessage> getUnreadMessageList() { return unreadMessages; }
    }
}
