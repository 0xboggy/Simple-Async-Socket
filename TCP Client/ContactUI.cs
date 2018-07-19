using System.Drawing;
using System.Windows.Forms;

namespace TCP_Client
{
    public class ContactUI
    {
        private Panel contactTab;
        private RoundPictureBox contactPicture;
        private Label contactName;
        //private Label mood;//Might Add Later
        public ContactUI(string username,Image contactPic, bool contact)
        {
            contactTab = tab(contact);
            contactPicture = picture(contactPic, contact);
            contactName = name(username, contactTab, contact);
            contactTab.Controls.Add(contactName);
            contactTab.Controls.Add(contactPicture);
        }

        private Panel tab(bool contact)
        {
            Panel panel = new Panel();
            panel.BackColor = Color.FromArgb(240, 244, 248);
            if (contact)
            {
                panel.Dock = DockStyle.Top;
                panel.Size = new Size(273, 52);
            }
            else
            {
                panel.Dock = DockStyle.Fill;
            }
            panel.Padding = new Padding(5, 5, 5, 5);
            return panel;
        }

        private RoundPictureBox picture(Image contactPic, bool contact)
        {
            RoundPictureBox pic = new RoundPictureBox();
            pic.BackColor = Color.Transparent;
            pic.BackgroundImageLayout = ImageLayout.None;
            pic.Dock = DockStyle.Left;
            pic.Image = contactPic;
            if(contact)
                pic.Size = new Size(42, 52);
            else
                pic.Size = new Size(70, 80);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            return pic;
        }

        private Label name(string username, Panel tab, bool contact)
        {
            Label name = new Label();
            name.BackColor = Color.Transparent;
            name.Dock = DockStyle.Fill;
            name.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            if (contact)
                name.Size = new Size(tab.Width, 52);
            else
                name.Size = new Size(tab.Width, 80);
            name.Text = username;
            name.TextAlign = ContentAlignment.MiddleLeft;
            return name;
        }

        public Panel getContactUITab() { return contactTab; }
        public Label getContactUIName() { return contactName; }
        public PictureBox getContactUIPicture() { return contactPicture; }
    }
}
