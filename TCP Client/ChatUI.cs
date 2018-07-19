using System;
using System.Drawing;
using System.Windows.Forms;

namespace TCP_Client
{
    public class ChatUI
    {
        private Panel messageTab;
        private MyFixedRichTextBox messageBox;
        //Sent UI
        public ChatUI(string message,int buffer,EmojiPanel emoji)
        {
            messageTab = new Panel();
            Panel messageBoxPanel = new Panel();
            messageBox = new MyFixedRichTextBox(true);
            messageBox.setEmojiRef(emoji);//Update richtextbox to have a reference to the emojiPanel
            Label time = new Label();

            messageTab.BackColor = Color.White;
            messageTab.Controls.Add(messageBoxPanel);
            messageTab.Controls.Add(time);
            messageTab.Dock = DockStyle.Top;
            messageTab.Padding = new Padding(102, buffer, 0, 0);
            messageTab.Size = new Size(808, 42+buffer);

            messageBoxPanel.BackColor = Color.FromArgb(199, 237, 252);
            messageBoxPanel.Controls.Add(messageBox);
            messageBoxPanel.Dock = DockStyle.Fill;
            messageBoxPanel.Padding = new Padding(14, 8, 50, 6);
            
            messageBox.BackColor = Color.FromArgb(199, 237, 252);
            messageBox.ForeColor = Color.FromArgb(43, 43, 48);
            messageBox.BorderStyle = BorderStyle.None;
            messageBox.Font = new Font("Segoe UI", 11F);
            messageBox.ReadOnly = true;
            messageBox.WordWrap = true;
            messageBox.Multiline = true;
            messageBox.ScrollBars = RichTextBoxScrollBars.None;
            messageBox.Text = message;
            messageBox.Dock = DockStyle.Fill;
            messageBox.GotFocus += new EventHandler(messageBox_GotFocus);
            messageBox.TextChanged += (sender, e) => messageBox_SizeChanged(messageBox, buffer, messageTab, messageBoxPanel);
            messageBox.Resize += (sender, e) => messageBox_SizeChanged(messageBox, buffer, messageTab, messageBoxPanel);

            time.ForeColor = Color.FromArgb(102, 116, 134);
            time.Dock = DockStyle.Right;
            time.Font = new Font("Segoe UI", 8F);
            time.Padding = new Padding(0, 11, 0, 0);
            time.Size = new Size(126, 42);
            time.Text = DateTime.Now.ToString("h:mm tt");
            time.TextAlign = ContentAlignment.TopCenter;
        }

        //Received UI
        public ChatUI(string message,string date,Image contactPicture,int buffer,EmojiPanel emoji)
        {
            messageTab = new Panel();
            Panel picturePanel = new Panel();
            RoundPictureBox picture = new RoundPictureBox();
            Panel messageBoxPanel = new Panel();
            messageBox = new MyFixedRichTextBox(true);
            messageBox.setEmojiRef(emoji);//Update richtextbox to have a reference to the emojiPanel
            Label time = new Label();

            messageTab.Controls.Add(messageBoxPanel);
            messageTab.Controls.Add(time);
            messageTab.Controls.Add(picturePanel);
            messageTab.Dock = DockStyle.Top;
            messageTab.Padding = new Padding(0, buffer, 0, 0);
            messageTab.Size = new Size(767, 42+buffer);

            picturePanel.BackColor = Color.White;
            picturePanel.Controls.Add(picture);
            picturePanel.Dock = DockStyle.Left;
            picturePanel.Padding = new Padding(0, 0, 10, 0);
            picturePanel.Size = new Size(52, 42);

            picture.BackColor = Color.Transparent;
            picture.BackgroundImageLayout = ImageLayout.None;
            picture.Dock = DockStyle.Top;
            picture.Image = contactPicture;//Properties.Resources.user;
            picture.Size = new Size(42, 42);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            
            messageBoxPanel.Controls.Add(messageBox);
            messageBoxPanel.BackColor = Color.FromArgb(240, 244, 248);
            messageBoxPanel.ForeColor = Color.FromArgb(43, 43, 48);
            messageBoxPanel.Dock = DockStyle.Fill;
            messageBoxPanel.Padding = new Padding(14, 8, 50, 6);

            messageBox.BackColor = Color.FromArgb(240, 244, 248);
            messageBox.ForeColor = Color.FromArgb(43, 43, 48);
            messageBox.BorderStyle = BorderStyle.None;
            messageBox.Dock = DockStyle.Fill;
            messageBox.Font = new Font("Segoe UI", 11F);
            messageBox.ReadOnly = true;
            messageBox.WordWrap = true;
            messageBox.Multiline = true;
            messageBox.ScrollBars = RichTextBoxScrollBars.None;
            messageBox.Text = message;
            messageBox.GotFocus += new EventHandler(messageBox_GotFocus);
            messageBox.TextChanged += (sender, e) => messageBox_SizeChanged(messageBox, buffer, messageTab, messageBoxPanel);
            messageBox.Resize += (sender, e) => messageBox_SizeChanged(messageBox, buffer, messageTab, messageBoxPanel);

            time.ForeColor = Color.FromArgb(102, 116, 134);
            time.Dock = DockStyle.Right;
            time.Font = new Font("Segoe UI", 8F);
            time.ImageAlign = ContentAlignment.TopCenter;
            time.Padding = new Padding(50, 11, 0, 0);
            time.Size = new Size(176, 42);
            time.Text = date;// DateTime.Now.ToString("h:mm tt");
            time.TextAlign = ContentAlignment.TopCenter;
        }

        public static Panel getPanelBuffer(int height)
        {
            Panel buffer = new Panel();
            buffer.Dock = DockStyle.Top;
            buffer.Size = new Size(808, height);
            return buffer;
        }

        public Panel getMessageTab() { return messageTab; }
        public MyFixedRichTextBox getMessageBox() { return messageBox; }

        private void messageBox_GotFocus(object sender, EventArgs e)
        {
            MyFixedRichTextBox box = (MyFixedRichTextBox)sender;
        }

        private void messageBox_SizeChanged(object sender, int buffer, Panel messageTab, Panel messageBoxPanel)
        {
            MyFixedRichTextBox box = (MyFixedRichTextBox)sender;
            int line = box.GetLineFromCharIndex(box.Text.Length - 1);
            if(messageTab.Height != 42+buffer+(25*line)) messageTab.Height = 42+buffer+(25*line);
            if(messageBoxPanel.Height != 42+(25*line)) messageBoxPanel.Height = 42+(25* line);
            if(box.Height != 28+(25*line)) box.Height = 28+(25*line);
        }
    }
}