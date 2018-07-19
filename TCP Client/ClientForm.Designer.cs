namespace TCP_Client
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentContact = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.contacts = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.convoPanel = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.msgBar = new System.Windows.Forms.Panel();
            this.msgPanel = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.emojiPanel = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.msgBox = new TCP_Client.MyFixedRichTextBox();
            this.contactPicture = new TCP_Client.RoundPictureBox();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.msgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emojiPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // currentContact
            // 
            this.currentContact.BackColor = System.Drawing.Color.White;
            this.currentContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentContact.Location = new System.Drawing.Point(0, 0);
            this.currentContact.Name = "currentContact";
            this.currentContact.Size = new System.Drawing.Size(797, 80);
            this.currentContact.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(797, 1);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTACTS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1087, 1);
            this.panel10.TabIndex = 19;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panel11.Controls.Add(this.contacts);
            this.panel11.Controls.Add(this.panel8);
            this.panel11.Controls.Add(this.panel6);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 1);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(288, 519);
            this.panel11.TabIndex = 20;
            // 
            // contacts
            // 
            this.contacts.AutoScroll = true;
            this.contacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contacts.Location = new System.Drawing.Point(0, 173);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(288, 346);
            this.contacts.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 127);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(288, 46);
            this.panel8.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.checkBox1);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.btnConnect);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(288, 127);
            this.panel6.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(288, 26);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Packet Support";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.contactPicture);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 26);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.panel9.Size = new System.Drawing.Size(288, 66);
            this.panel9.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.nameBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(62, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 14, 0, 0);
            this.panel3.Size = new System.Drawing.Size(226, 58);
            this.panel3.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(116)))), ((int)(((byte)(134)))));
            this.nameBox.Location = new System.Drawing.Point(5, 14);
            this.nameBox.Margin = new System.Windows.Forms.Padding(5);
            this.nameBox.MaxLength = 20;
            this.nameBox.Multiline = false;
            this.nameBox.Name = "nameBox";
            this.nameBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.nameBox.ShortcutsEnabled = false;
            this.nameBox.Size = new System.Drawing.Size(221, 44);
            this.nameBox.TabIndex = 11;
            this.nameBox.Text = "Client Name Here";
            this.nameBox.WordWrap = false;
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_KeyDown);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            this.nameBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nameBox_MouseDown);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(0, 92);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(288, 35);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(288, 1);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(2, 519);
            this.panel12.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.convoPanel);
            this.panel7.Controls.Add(this.panel16);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.msgBar);
            this.panel7.Controls.Add(this.msgPanel);
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.currentContact);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(290, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(797, 519);
            this.panel7.TabIndex = 22;
            // 
            // convoPanel
            // 
            this.convoPanel.AutoScroll = true;
            this.convoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convoPanel.Location = new System.Drawing.Point(15, 101);
            this.convoPanel.Name = "convoPanel";
            this.convoPanel.Size = new System.Drawing.Size(767, 329);
            this.convoPanel.TabIndex = 13;
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(15, 81);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(767, 20);
            this.panel16.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(15, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 20);
            this.panel2.TabIndex = 3;
            // 
            // msgBar
            // 
            this.msgBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.msgBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msgBar.Location = new System.Drawing.Point(15, 450);
            this.msgBar.Name = "msgBar";
            this.msgBar.Size = new System.Drawing.Size(767, 1);
            this.msgBar.TabIndex = 12;
            // 
            // msgPanel
            // 
            this.msgPanel.Controls.Add(this.btnSend);
            this.msgPanel.Controls.Add(this.emojiPanel);
            this.msgPanel.Controls.Add(this.msgBox);
            this.msgPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msgPanel.Location = new System.Drawing.Point(15, 451);
            this.msgPanel.Margin = new System.Windows.Forms.Padding(0);
            this.msgPanel.Name = "msgPanel";
            this.msgPanel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.msgPanel.Size = new System.Drawing.Size(767, 68);
            this.msgPanel.TabIndex = 11;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(185)))), ((int)(((byte)(225)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSend.Enabled = false;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(652, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(60, 30);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // emojiPanel
            // 
            this.emojiPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.emojiPanel.Image = global::TCP_Client.Properties.Resources.Emoji_Dark;
            this.emojiPanel.Location = new System.Drawing.Point(621, 22);
            this.emojiPanel.Name = "emojiPanel";
            this.emojiPanel.Size = new System.Drawing.Size(25, 25);
            this.emojiPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emojiPanel.TabIndex = 3;
            this.emojiPanel.TabStop = false;
            this.emojiPanel.Click += new System.EventHandler(this.pictureBox1_Click);
            this.emojiPanel.MouseEnter += new System.EventHandler(this.emojiPanel_MouseEnter);
            this.emojiPanel.MouseLeave += new System.EventHandler(this.emojiPanel_MouseLeave);
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(782, 81);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(15, 438);
            this.panel13.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 438);
            this.panel4.TabIndex = 7;
            // 
            // msgBox
            // 
            this.msgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.msgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.msgBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(116)))), ((int)(((byte)(134)))));
            this.msgBox.Location = new System.Drawing.Point(0, 20);
            this.msgBox.Margin = new System.Windows.Forms.Padding(0);
            this.msgBox.Name = "msgBox";
            this.msgBox.RightMargin = 616;
            this.msgBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.msgBox.Size = new System.Drawing.Size(767, 28);
            this.msgBox.TabIndex = 0;
            this.msgBox.Text = "Type a message here";
            this.msgBox.TextChanged += new System.EventHandler(this.msgBox_TextChanged);
            this.msgBox.Enter += new System.EventHandler(this.msgBox_Enter);
            this.msgBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msgBox_KeyDown);
            this.msgBox.Leave += new System.EventHandler(this.msgBox_Leave);
            this.msgBox.Resize += new System.EventHandler(this.msgBox_Resize);
            // 
            // contactPicture
            // 
            this.contactPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contactPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.contactPicture.Image = global::TCP_Client.Properties.Resources.user;
            this.contactPicture.Location = new System.Drawing.Point(4, 4);
            this.contactPicture.Name = "contactPicture";
            this.contactPicture.Size = new System.Drawing.Size(58, 58);
            this.contactPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contactPicture.TabIndex = 0;
            this.contactPicture.TabStop = false;
            this.contactPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 520);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ClientForm";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_Closing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel11.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.msgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emojiPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel currentContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel contacts;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox nameBox;
        private System.Windows.Forms.Panel msgPanel;
        private System.Windows.Forms.Panel msgBar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel convoPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel16;
        public MyFixedRichTextBox msgBox;
        public System.Windows.Forms.PictureBox emojiPanel;
        public System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel3;
        private RoundPictureBox contactPicture;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

