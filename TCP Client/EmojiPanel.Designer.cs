using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TCP_Client
{
    partial class EmojiPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmojiPanel));
            this.borderColor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel77 = new System.Windows.Forms.Panel();
            this.panel78 = new System.Windows.Forms.Panel();
            this.Ghost = new System.Windows.Forms.PictureBox();
            this.panel79 = new System.Windows.Forms.Panel();
            this.Alien = new System.Windows.Forms.PictureBox();
            this.panel80 = new System.Windows.Forms.Panel();
            this.Angry_Devil = new System.Windows.Forms.PictureBox();
            this.panel81 = new System.Windows.Forms.Panel();
            this.Smiling_Devil = new System.Windows.Forms.PictureBox();
            this.panel82 = new System.Windows.Forms.Panel();
            this.Poop = new System.Windows.Forms.PictureBox();
            this.panel83 = new System.Windows.Forms.Panel();
            this.Crying = new System.Windows.Forms.PictureBox();
            this.panel84 = new System.Windows.Forms.Panel();
            this.Disappointed_but_Relieved = new System.Windows.Forms.PictureBox();
            this.panel85 = new System.Windows.Forms.Panel();
            this.Loudly_Crying = new System.Windows.Forms.PictureBox();
            this.panel86 = new System.Windows.Forms.Panel();
            this.Sweat = new System.Windows.Forms.PictureBox();
            this.panel67 = new System.Windows.Forms.Panel();
            this.panel68 = new System.Windows.Forms.Panel();
            this.Disappointed = new System.Windows.Forms.PictureBox();
            this.panel69 = new System.Windows.Forms.Panel();
            this.Angry = new System.Windows.Forms.PictureBox();
            this.panel70 = new System.Windows.Forms.Panel();
            this.Very_Angry = new System.Windows.Forms.PictureBox();
            this.panel71 = new System.Windows.Forms.Panel();
            this.Recovering = new System.Windows.Forms.PictureBox();
            this.panel72 = new System.Windows.Forms.Panel();
            this.Fever = new System.Windows.Forms.PictureBox();
            this.panel73 = new System.Windows.Forms.Panel();
            this.Sick = new System.Windows.Forms.PictureBox();
            this.panel74 = new System.Windows.Forms.Panel();
            this.Lips_Sealed = new System.Windows.Forms.PictureBox();
            this.panel75 = new System.Windows.Forms.Panel();
            this.Dizzy = new System.Windows.Forms.PictureBox();
            this.panel76 = new System.Windows.Forms.Panel();
            this.Astonished = new System.Windows.Forms.PictureBox();
            this.panel57 = new System.Windows.Forms.Panel();
            this.panel58 = new System.Windows.Forms.Panel();
            this.Confounded_Face = new System.Windows.Forms.PictureBox();
            this.panel59 = new System.Windows.Forms.Panel();
            this.Persevering_Face = new System.Windows.Forms.PictureBox();
            this.panel60 = new System.Windows.Forms.Panel();
            this.Weary = new System.Windows.Forms.PictureBox();
            this.panel61 = new System.Windows.Forms.Panel();
            this.Tired = new System.Windows.Forms.PictureBox();
            this.panel62 = new System.Windows.Forms.Panel();
            this.Very_Mad = new System.Windows.Forms.PictureBox();
            this.panel63 = new System.Windows.Forms.Panel();
            this.Worried = new System.Windows.Forms.PictureBox();
            this.panel64 = new System.Windows.Forms.Panel();
            this.Confused = new System.Windows.Forms.PictureBox();
            this.panel65 = new System.Windows.Forms.Panel();
            this.Very_Sad = new System.Windows.Forms.PictureBox();
            this.panel66 = new System.Windows.Forms.Panel();
            this.Neutral = new System.Windows.Forms.PictureBox();
            this.panel47 = new System.Windows.Forms.Panel();
            this.panel48 = new System.Windows.Forms.Panel();
            this.Expressionless = new System.Windows.Forms.PictureBox();
            this.panel49 = new System.Windows.Forms.Panel();
            this.Sleeping = new System.Windows.Forms.PictureBox();
            this.panel50 = new System.Windows.Forms.Panel();
            this.Smiling_Angel = new System.Windows.Forms.PictureBox();
            this.panel51 = new System.Windows.Forms.Panel();
            this.Flushed_Face = new System.Windows.Forms.PictureBox();
            this.panel52 = new System.Windows.Forms.Panel();
            this.Blow_Kiss = new System.Windows.Forms.PictureBox();
            this.panel53 = new System.Windows.Forms.Panel();
            this.Heart_Eyes = new System.Windows.Forms.PictureBox();
            this.panel54 = new System.Windows.Forms.Panel();
            this.OMG_Face = new System.Windows.Forms.PictureBox();
            this.panel55 = new System.Windows.Forms.Panel();
            this.Cold_Sweat = new System.Windows.Forms.PictureBox();
            this.panel56 = new System.Windows.Forms.Panel();
            this.Fearful_Face = new System.Windows.Forms.PictureBox();
            this.panel37 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.Snoring = new System.Windows.Forms.PictureBox();
            this.panel39 = new System.Windows.Forms.Panel();
            this.Thinking = new System.Windows.Forms.PictureBox();
            this.panel40 = new System.Windows.Forms.Panel();
            this.Rolling_Eyes = new System.Windows.Forms.PictureBox();
            this.panel41 = new System.Windows.Forms.Panel();
            this.Anguished_Face = new System.Windows.Forms.PictureBox();
            this.panel42 = new System.Windows.Forms.Panel();
            this.Surprised = new System.Windows.Forms.PictureBox();
            this.panel43 = new System.Windows.Forms.Panel();
            this.Frowning_Face = new System.Windows.Forms.PictureBox();
            this.panel44 = new System.Windows.Forms.Panel();
            this.Hushed_Face = new System.Windows.Forms.PictureBox();
            this.panel45 = new System.Windows.Forms.Panel();
            this.Silence = new System.Windows.Forms.PictureBox();
            this.panel46 = new System.Windows.Forms.Panel();
            this.Wink = new System.Windows.Forms.PictureBox();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.Hungry_Face = new System.Windows.Forms.PictureBox();
            this.panel29 = new System.Windows.Forms.Panel();
            this.Grinmacing_Face = new System.Windows.Forms.PictureBox();
            this.panel30 = new System.Windows.Forms.Panel();
            this.Grinning = new System.Windows.Forms.PictureBox();
            this.panel31 = new System.Windows.Forms.Panel();
            this.Cool = new System.Windows.Forms.PictureBox();
            this.panel32 = new System.Windows.Forms.Panel();
            this.Nerdy = new System.Windows.Forms.PictureBox();
            this.panel33 = new System.Windows.Forms.Panel();
            this.Duck_Face = new System.Windows.Forms.PictureBox();
            this.panel34 = new System.Windows.Forms.Panel();
            this.Kissing_Face = new System.Windows.Forms.PictureBox();
            this.panel35 = new System.Windows.Forms.Panel();
            this.Nervous_Kiss = new System.Windows.Forms.PictureBox();
            this.panel123 = new System.Windows.Forms.Panel();
            this.Shyly_Smiling = new System.Windows.Forms.PictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.Blushing = new System.Windows.Forms.PictureBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.Hugging_Face = new System.Windows.Forms.PictureBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.Winking_Eye_Tongue_Out = new System.Windows.Forms.PictureBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.Closed_Eyes_Tongue_Out = new System.Windows.Forms.PictureBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.Tongue_Out = new System.Windows.Forms.PictureBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.Money = new System.Windows.Forms.PictureBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.Relieved = new System.Windows.Forms.PictureBox();
            this.panel25 = new System.Windows.Forms.Panel();
            this.Sad = new System.Windows.Forms.PictureBox();
            this.panel26 = new System.Windows.Forms.Panel();
            this.Unamused = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.Smirk = new System.Windows.Forms.PictureBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.Tears_of_Joy = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.Sweat_Smiling = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.Eyes_Closed_Smiling = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.Happy_Eyes_Smiling = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.Eyes_Opened_Smiling = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Smiling = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Upside_Down = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Slightly_Smiling = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emojiCode = new System.Windows.Forms.Label();
            this.emojiName = new System.Windows.Forms.Label();
            this.currentEmoji = new System.Windows.Forms.PictureBox();
            this.borderColor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel77.SuspendLayout();
            this.panel78.SuspendLayout();
            // 
            // borderColor
            // 
            this.borderColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(125)))), ((int)(((byte)(180)))));
            this.borderColor.Controls.Add(this.panel1);
            this.borderColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderColor.ForeColor = System.Drawing.Color.Black;
            this.borderColor.Location = new System.Drawing.Point(0, 0);
            this.borderColor.Name = "borderColor";
            this.borderColor.Padding = new System.Windows.Forms.Padding(1);
            this.borderColor.Size = new System.Drawing.Size(358, 576);
            this.borderColor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 574);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 284);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel77);
            this.panel4.Controls.Add(this.panel67);
            this.panel4.Controls.Add(this.panel57);
            this.panel4.Controls.Add(this.panel47);
            this.panel4.Controls.Add(this.panel37);
            this.panel4.Controls.Add(this.panel27);
            this.panel4.Controls.Add(this.panel17);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 8, 10, 0);
            this.panel4.Size = new System.Drawing.Size(335, 366);
            this.panel4.TabIndex = 0;
            // 
            // panel77
            // 
            this.panel77.Controls.Add(this.panel78);
            this.panel77.Controls.Add(this.panel79);
            this.panel77.Controls.Add(this.panel80);
            this.panel77.Controls.Add(this.panel81);
            this.panel77.Controls.Add(this.panel82);
            this.panel77.Controls.Add(this.panel83);
            this.panel77.Controls.Add(this.panel84);
            this.panel77.Controls.Add(this.panel85);
            this.panel77.Controls.Add(this.panel86);
            this.panel77.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel77.Location = new System.Drawing.Point(10, 319);
            this.panel77.Name = "panel77";
            this.panel77.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel77.Size = new System.Drawing.Size(315, 40);
            this.panel77.TabIndex = 10;
            // 
            // panel78
            // 
            this.panel78.Controls.Add(this.Ghost);
            this.panel78.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel78.Location = new System.Drawing.Point(280, 5);
            this.panel78.Name = "panel78";
            this.panel78.Padding = new System.Windows.Forms.Padding(3);
            this.panel78.Size = new System.Drawing.Size(35, 35);
            this.panel78.TabIndex = 8;
            this.panel78.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Ghost
            // 
            this.Ghost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ghost.Image = createBmp(Ghost, global::TCP_Client.Properties.Resources.Ghost);
            this.Ghost.Location = new System.Drawing.Point(3, 3);
            this.Ghost.Name = "Ghost";
            this.Ghost.Size = new System.Drawing.Size(29, 29);
            this.Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ghost.TabIndex = 0;
            this.Ghost.TabStop = false;
            // 
            // panel79
            // 
            this.panel79.Controls.Add(this.Alien);
            this.panel79.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel79.Location = new System.Drawing.Point(245, 5);
            this.panel79.Name = "panel79";
            this.panel79.Padding = new System.Windows.Forms.Padding(3);
            this.panel79.Size = new System.Drawing.Size(35, 35);
            this.panel79.TabIndex = 7;
            this.panel79.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Alien
            // 
            this.Alien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Alien.Image = createBmp(Alien, global::TCP_Client.Properties.Resources.Alien);
            this.Alien.Location = new System.Drawing.Point(3, 3);
            this.Alien.Name = "Alien";
            this.Alien.Size = new System.Drawing.Size(29, 29);
            this.Alien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Alien.TabIndex = 0;
            this.Alien.TabStop = false;
            // 
            // panel80
            // 
            this.panel80.Controls.Add(this.Angry_Devil);
            this.panel80.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel80.Location = new System.Drawing.Point(210, 5);
            this.panel80.Name = "panel80";
            this.panel80.Padding = new System.Windows.Forms.Padding(3);
            this.panel80.Size = new System.Drawing.Size(35, 35);
            this.panel80.TabIndex = 6;
            this.panel80.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Angry_Devil
            // 
            this.Angry_Devil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Angry_Devil.Image = createBmp(Angry_Devil, global::TCP_Client.Properties.Resources.Angry_Devil);
            this.Angry_Devil.Location = new System.Drawing.Point(3, 3);
            this.Angry_Devil.Name = "Angry_Devil";
            this.Angry_Devil.Size = new System.Drawing.Size(29, 29);
            this.Angry_Devil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Angry_Devil.TabIndex = 0;
            this.Angry_Devil.TabStop = false;
            // 
            // panel81
            // 
            this.panel81.Controls.Add(this.Smiling_Devil);
            this.panel81.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel81.Location = new System.Drawing.Point(175, 5);
            this.panel81.Name = "panel81";
            this.panel81.Padding = new System.Windows.Forms.Padding(3);
            this.panel81.Size = new System.Drawing.Size(35, 35);
            this.panel81.TabIndex = 5;
            this.panel81.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Smiling_Devil
            // 
            this.Smiling_Devil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Smiling_Devil.Image = createBmp(Smiling_Devil, global::TCP_Client.Properties.Resources.Smiling_Devil);
            this.Smiling_Devil.Location = new System.Drawing.Point(3, 3);
            this.Smiling_Devil.Name = "Smiling_Devil";
            this.Smiling_Devil.Size = new System.Drawing.Size(29, 29);
            this.Smiling_Devil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Smiling_Devil.TabIndex = 0;
            this.Smiling_Devil.TabStop = false;
            // 
            // panel82
            // 
            this.panel82.Controls.Add(this.Poop);
            this.panel82.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel82.Location = new System.Drawing.Point(140, 5);
            this.panel82.Name = "panel82";
            this.panel82.Padding = new System.Windows.Forms.Padding(3);
            this.panel82.Size = new System.Drawing.Size(35, 35);
            this.panel82.TabIndex = 4;
            this.panel82.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Poop
            // 
            this.Poop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Poop.Image = createBmp(Poop, global::TCP_Client.Properties.Resources.Poop);
            this.Poop.Location = new System.Drawing.Point(3, 3);
            this.Poop.Name = "Poop";
            this.Poop.Size = new System.Drawing.Size(29, 29);
            this.Poop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Poop.TabIndex = 0;
            this.Poop.TabStop = false;
            // 
            // panel83
            // 
            this.panel83.Controls.Add(this.Crying);
            this.panel83.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel83.Location = new System.Drawing.Point(105, 5);
            this.panel83.Name = "panel83";
            this.panel83.Padding = new System.Windows.Forms.Padding(3);
            this.panel83.Size = new System.Drawing.Size(35, 35);
            this.panel83.TabIndex = 3;
            this.panel83.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Crying
            // 
            this.Crying.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crying.Image = createBmp(Crying, global::TCP_Client.Properties.Resources.Crying);
            this.Crying.Location = new System.Drawing.Point(3, 3);
            this.Crying.Name = "Crying";
            this.Crying.Size = new System.Drawing.Size(29, 29);
            this.Crying.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Crying.TabIndex = 0;
            this.Crying.TabStop = false;
            // 
            // panel84
            // 
            this.panel84.Controls.Add(this.Disappointed_but_Relieved);
            this.panel84.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel84.Location = new System.Drawing.Point(70, 5);
            this.panel84.Name = "panel84";
            this.panel84.Padding = new System.Windows.Forms.Padding(3);
            this.panel84.Size = new System.Drawing.Size(35, 35);
            this.panel84.TabIndex = 2;
            this.panel84.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Disappointed_but_Relieved
            // 
            this.Disappointed_but_Relieved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Disappointed_but_Relieved.Image = createBmp(Disappointed_but_Relieved, global::TCP_Client.Properties.Resources.Disappointed_but_Relieved);
            this.Disappointed_but_Relieved.Location = new System.Drawing.Point(3, 3);
            this.Disappointed_but_Relieved.Name = "Disappointed_but_Relieved";
            this.Disappointed_but_Relieved.Size = new System.Drawing.Size(29, 29);
            this.Disappointed_but_Relieved.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Disappointed_but_Relieved.TabIndex = 0;
            this.Disappointed_but_Relieved.TabStop = false;
            // 
            // panel85
            // 
            this.panel85.Controls.Add(this.Loudly_Crying);
            this.panel85.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel85.Location = new System.Drawing.Point(35, 5);
            this.panel85.Name = "panel85";
            this.panel85.Padding = new System.Windows.Forms.Padding(3);
            this.panel85.Size = new System.Drawing.Size(35, 35);
            this.panel85.TabIndex = 1;
            this.panel85.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Loudly_Crying
            // 
            this.Loudly_Crying.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loudly_Crying.Image = createBmp(Loudly_Crying, global::TCP_Client.Properties.Resources.Loudly_Crying);
            this.Loudly_Crying.Location = new System.Drawing.Point(3, 3);
            this.Loudly_Crying.Name = "Loudly_Crying";
            this.Loudly_Crying.Size = new System.Drawing.Size(29, 29);
            this.Loudly_Crying.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Loudly_Crying.TabIndex = 0;
            this.Loudly_Crying.TabStop = false;
            // 
            // panel86
            // 
            this.panel86.Controls.Add(this.Sweat);
            this.panel86.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel86.Location = new System.Drawing.Point(0, 5);
            this.panel86.Margin = new System.Windows.Forms.Padding(0);
            this.panel86.Name = "panel86";
            this.panel86.Padding = new System.Windows.Forms.Padding(3);
            this.panel86.Size = new System.Drawing.Size(35, 35);
            this.panel86.TabIndex = 0;
            this.panel86.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Sweat
            // 
            this.Sweat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sweat.Image = createBmp(Sweat, global::TCP_Client.Properties.Resources.Sweat);
            this.Sweat.Location = new System.Drawing.Point(3, 3);
            this.Sweat.Name = "Sweat";
            this.Sweat.Size = new System.Drawing.Size(29, 29);
            this.Sweat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sweat.TabIndex = 0;
            this.Sweat.TabStop = false;
            // 
            // panel67
            // 
            this.panel67.Controls.Add(this.panel68);
            this.panel67.Controls.Add(this.panel69);
            this.panel67.Controls.Add(this.panel70);
            this.panel67.Controls.Add(this.panel71);
            this.panel67.Controls.Add(this.panel72);
            this.panel67.Controls.Add(this.panel73);
            this.panel67.Controls.Add(this.panel74);
            this.panel67.Controls.Add(this.panel75);
            this.panel67.Controls.Add(this.panel76);
            this.panel67.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel67.Location = new System.Drawing.Point(10, 279);
            this.panel67.Name = "panel67";
            this.panel67.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel67.Size = new System.Drawing.Size(315, 40);
            this.panel67.TabIndex = 9;
            // 
            // panel68
            // 
            this.panel68.Controls.Add(this.Disappointed);
            this.panel68.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel68.Location = new System.Drawing.Point(280, 5);
            this.panel68.Name = "panel68";
            this.panel68.Padding = new System.Windows.Forms.Padding(3);
            this.panel68.Size = new System.Drawing.Size(35, 35);
            this.panel68.TabIndex = 8;
            this.panel68.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Disappointed
            // 
            this.Disappointed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Disappointed.Image = createBmp(Disappointed, global::TCP_Client.Properties.Resources.Disappointed);
            this.Disappointed.Location = new System.Drawing.Point(3, 3);
            this.Disappointed.Name = "Disappointed";
            this.Disappointed.Size = new System.Drawing.Size(29, 29);
            this.Disappointed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Disappointed.TabIndex = 0;
            this.Disappointed.TabStop = false;
            // 
            // panel69
            // 
            this.panel69.Controls.Add(this.Angry);
            this.panel69.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel69.Location = new System.Drawing.Point(245, 5);
            this.panel69.Name = "panel69";
            this.panel69.Padding = new System.Windows.Forms.Padding(3);
            this.panel69.Size = new System.Drawing.Size(35, 35);
            this.panel69.TabIndex = 7;
            this.panel69.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Angry
            // 
            this.Angry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Angry.Image = createBmp(Angry, global::TCP_Client.Properties.Resources.Angry);
            this.Angry.Location = new System.Drawing.Point(3, 3);
            this.Angry.Name = "Angry";
            this.Angry.Size = new System.Drawing.Size(29, 29);
            this.Angry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Angry.TabIndex = 0;
            this.Angry.TabStop = false;
            // 
            // panel70
            // 
            this.panel70.Controls.Add(this.Very_Angry);
            this.panel70.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel70.Location = new System.Drawing.Point(210, 5);
            this.panel70.Name = "panel70";
            this.panel70.Padding = new System.Windows.Forms.Padding(3);
            this.panel70.Size = new System.Drawing.Size(35, 35);
            this.panel70.TabIndex = 6;
            this.panel70.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Very_Angry
            // 
            this.Very_Angry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Very_Angry.Image = createBmp(Very_Angry, global::TCP_Client.Properties.Resources.Very_Angry);
            this.Very_Angry.Location = new System.Drawing.Point(3, 3);
            this.Very_Angry.Name = "Very_Angry";
            this.Very_Angry.Size = new System.Drawing.Size(29, 29);
            this.Very_Angry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Very_Angry.TabIndex = 0;
            this.Very_Angry.TabStop = false;
            // 
            // panel71
            // 
            this.panel71.Controls.Add(this.Recovering);
            this.panel71.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel71.Location = new System.Drawing.Point(175, 5);
            this.panel71.Name = "panel71";
            this.panel71.Padding = new System.Windows.Forms.Padding(3);
            this.panel71.Size = new System.Drawing.Size(35, 35);
            this.panel71.TabIndex = 5;
            this.panel71.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Recovering
            // 
            this.Recovering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Recovering.Image = createBmp(Recovering, global::TCP_Client.Properties.Resources.Recovering);
            this.Recovering.Location = new System.Drawing.Point(3, 3);
            this.Recovering.Name = "Recovering";
            this.Recovering.Size = new System.Drawing.Size(29, 29);
            this.Recovering.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Recovering.TabIndex = 0;
            this.Recovering.TabStop = false;
            // 
            // panel72
            // 
            this.panel72.Controls.Add(this.Fever);
            this.panel72.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel72.Location = new System.Drawing.Point(140, 5);
            this.panel72.Name = "panel72";
            this.panel72.Padding = new System.Windows.Forms.Padding(3);
            this.panel72.Size = new System.Drawing.Size(35, 35);
            this.panel72.TabIndex = 4;
            this.panel72.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Fever
            // 
            this.Fever.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fever.Image = createBmp(Fever, global::TCP_Client.Properties.Resources.Fever);
            this.Fever.Location = new System.Drawing.Point(3, 3);
            this.Fever.Name = "Fever";
            this.Fever.Size = new System.Drawing.Size(29, 29);
            this.Fever.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fever.TabIndex = 0;
            this.Fever.TabStop = false;
            // 
            // panel73
            // 
            this.panel73.Controls.Add(this.Sick);
            this.panel73.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel73.Location = new System.Drawing.Point(105, 5);
            this.panel73.Name = "panel73";
            this.panel73.Padding = new System.Windows.Forms.Padding(3);
            this.panel73.Size = new System.Drawing.Size(35, 35);
            this.panel73.TabIndex = 3;
            this.panel73.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Sick
            // 
            this.Sick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sick.Image = createBmp(Sick, global::TCP_Client.Properties.Resources.Sick);
            this.Sick.Location = new System.Drawing.Point(3, 3);
            this.Sick.Name = "Sick";
            this.Sick.Size = new System.Drawing.Size(29, 29);
            this.Sick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sick.TabIndex = 0;
            this.Sick.TabStop = false;
            // 
            // panel74
            // 
            this.panel74.Controls.Add(this.Lips_Sealed);
            this.panel74.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel74.Location = new System.Drawing.Point(70, 5);
            this.panel74.Name = "panel74";
            this.panel74.Padding = new System.Windows.Forms.Padding(3);
            this.panel74.Size = new System.Drawing.Size(35, 35);
            this.panel74.TabIndex = 2;
            this.panel74.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Lips_Sealed
            // 
            this.Lips_Sealed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lips_Sealed.Image = createBmp(Lips_Sealed, global::TCP_Client.Properties.Resources.Lips_Sealed);
            this.Lips_Sealed.Location = new System.Drawing.Point(3, 3);
            this.Lips_Sealed.Name = "Lips_Sealed";
            this.Lips_Sealed.Size = new System.Drawing.Size(29, 29);
            this.Lips_Sealed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lips_Sealed.TabIndex = 0;
            this.Lips_Sealed.TabStop = false;
            // 
            // panel75
            // 
            this.panel75.Controls.Add(this.Dizzy);
            this.panel75.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel75.Location = new System.Drawing.Point(35, 5);
            this.panel75.Name = "panel75";
            this.panel75.Padding = new System.Windows.Forms.Padding(3);
            this.panel75.Size = new System.Drawing.Size(35, 35);
            this.panel75.TabIndex = 1;
            this.panel75.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Dizzy
            // 
            this.Dizzy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dizzy.Image = createBmp(Dizzy, global::TCP_Client.Properties.Resources.Dizzy);
            this.Dizzy.Location = new System.Drawing.Point(3, 3);
            this.Dizzy.Name = "Dizzy";
            this.Dizzy.Size = new System.Drawing.Size(29, 29);
            this.Dizzy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dizzy.TabIndex = 0;
            this.Dizzy.TabStop = false;
            // 
            // panel76
            // 
            this.panel76.Controls.Add(this.Astonished);
            this.panel76.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel76.Location = new System.Drawing.Point(0, 5);
            this.panel76.Margin = new System.Windows.Forms.Padding(0);
            this.panel76.Name = "panel76";
            this.panel76.Padding = new System.Windows.Forms.Padding(3);
            this.panel76.Size = new System.Drawing.Size(35, 35);
            this.panel76.TabIndex = 0;
            this.panel76.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Astonished
            // 
            this.Astonished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Astonished.Image = createBmp(Astonished, global::TCP_Client.Properties.Resources.Astonished);
            this.Astonished.Location = new System.Drawing.Point(3, 3);
            this.Astonished.Name = "Astonished";
            this.Astonished.Size = new System.Drawing.Size(29, 29);
            this.Astonished.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Astonished.TabIndex = 0;
            this.Astonished.TabStop = false;
            // 
            // panel57
            // 
            this.panel57.Controls.Add(this.panel58);
            this.panel57.Controls.Add(this.panel59);
            this.panel57.Controls.Add(this.panel60);
            this.panel57.Controls.Add(this.panel61);
            this.panel57.Controls.Add(this.panel62);
            this.panel57.Controls.Add(this.panel63);
            this.panel57.Controls.Add(this.panel64);
            this.panel57.Controls.Add(this.panel65);
            this.panel57.Controls.Add(this.panel66);
            this.panel57.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel57.Location = new System.Drawing.Point(10, 239);
            this.panel57.Name = "panel57";
            this.panel57.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel57.Size = new System.Drawing.Size(315, 40);
            this.panel57.TabIndex = 8;
            // 
            // panel58
            // 
            this.panel58.Controls.Add(this.Confounded_Face);
            this.panel58.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel58.Location = new System.Drawing.Point(280, 5);
            this.panel58.Name = "panel58";
            this.panel58.Padding = new System.Windows.Forms.Padding(3);
            this.panel58.Size = new System.Drawing.Size(35, 35);
            this.panel58.TabIndex = 8;
            this.panel58.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Confounded_Face
            // 
            this.Confounded_Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Confounded_Face.Image = createBmp(Confounded_Face, global::TCP_Client.Properties.Resources.Confounded_Face);
            this.Confounded_Face.Location = new System.Drawing.Point(3, 3);
            this.Confounded_Face.Name = "Confounded_Face";
            this.Confounded_Face.Size = new System.Drawing.Size(29, 29);
            this.Confounded_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Confounded_Face.TabIndex = 0;
            this.Confounded_Face.TabStop = false;
            // 
            // panel59
            // 
            this.panel59.Controls.Add(this.Persevering_Face);
            this.panel59.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel59.Location = new System.Drawing.Point(245, 5);
            this.panel59.Name = "panel59";
            this.panel59.Padding = new System.Windows.Forms.Padding(3);
            this.panel59.Size = new System.Drawing.Size(35, 35);
            this.panel59.TabIndex = 7;
            this.panel59.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Persevering_Face
            // 
            this.Persevering_Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Persevering_Face.Image = createBmp(Persevering_Face, global::TCP_Client.Properties.Resources.Persevering_Face);
            this.Persevering_Face.Location = new System.Drawing.Point(3, 3);
            this.Persevering_Face.Name = "Persevering_Face";
            this.Persevering_Face.Size = new System.Drawing.Size(29, 29);
            this.Persevering_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Persevering_Face.TabIndex = 0;
            this.Persevering_Face.TabStop = false;
            // 
            // panel60
            // 
            this.panel60.Controls.Add(this.Weary);
            this.panel60.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel60.Location = new System.Drawing.Point(210, 5);
            this.panel60.Name = "panel60";
            this.panel60.Padding = new System.Windows.Forms.Padding(3);
            this.panel60.Size = new System.Drawing.Size(35, 35);
            this.panel60.TabIndex = 6;
            this.panel60.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Weary
            // 
            this.Weary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Weary.Image = createBmp(Weary, global::TCP_Client.Properties.Resources.Weary);
            this.Weary.Location = new System.Drawing.Point(3, 3);
            this.Weary.Name = "Weary";
            this.Weary.Size = new System.Drawing.Size(29, 29);
            this.Weary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Weary.TabIndex = 0;
            this.Weary.TabStop = false;
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.Tired);
            this.panel61.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel61.Location = new System.Drawing.Point(175, 5);
            this.panel61.Name = "panel61";
            this.panel61.Padding = new System.Windows.Forms.Padding(3);
            this.panel61.Size = new System.Drawing.Size(35, 35);
            this.panel61.TabIndex = 5;
            this.panel61.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Tired
            // 
            this.Tired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tired.Image = createBmp(Tired, global::TCP_Client.Properties.Resources.Tired);
            this.Tired.Location = new System.Drawing.Point(3, 3);
            this.Tired.Name = "Tired";
            this.Tired.Size = new System.Drawing.Size(29, 29);
            this.Tired.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tired.TabIndex = 0;
            this.Tired.TabStop = false;
            // 
            // panel62
            // 
            this.panel62.Controls.Add(this.Very_Mad);
            this.panel62.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel62.Location = new System.Drawing.Point(140, 5);
            this.panel62.Name = "panel62";
            this.panel62.Padding = new System.Windows.Forms.Padding(3);
            this.panel62.Size = new System.Drawing.Size(35, 35);
            this.panel62.TabIndex = 4;
            this.panel62.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Very_Mad
            // 
            this.Very_Mad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Very_Mad.Image = createBmp(Very_Mad, global::TCP_Client.Properties.Resources.Very_Mad);
            this.Very_Mad.Location = new System.Drawing.Point(3, 3);
            this.Very_Mad.Name = "Very_Mad";
            this.Very_Mad.Size = new System.Drawing.Size(29, 29);
            this.Very_Mad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Very_Mad.TabIndex = 0;
            this.Very_Mad.TabStop = false;
            // 
            // panel63
            // 
            this.panel63.Controls.Add(this.Worried);
            this.panel63.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel63.Location = new System.Drawing.Point(105, 5);
            this.panel63.Name = "panel63";
            this.panel63.Padding = new System.Windows.Forms.Padding(3);
            this.panel63.Size = new System.Drawing.Size(35, 35);
            this.panel63.TabIndex = 3;
            this.panel63.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Worried
            // 
            this.Worried.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Worried.Image = createBmp(Worried, global::TCP_Client.Properties.Resources.Worried);
            this.Worried.Location = new System.Drawing.Point(3, 3);
            this.Worried.Name = "Worried";
            this.Worried.Size = new System.Drawing.Size(29, 29);
            this.Worried.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Worried.TabIndex = 0;
            this.Worried.TabStop = false;
            // 
            // panel64
            // 
            this.panel64.Controls.Add(this.Confused);
            this.panel64.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel64.Location = new System.Drawing.Point(70, 5);
            this.panel64.Name = "panel64";
            this.panel64.Padding = new System.Windows.Forms.Padding(3);
            this.panel64.Size = new System.Drawing.Size(35, 35);
            this.panel64.TabIndex = 2;
            this.panel64.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Confused
            // 
            this.Confused.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Confused.Image = createBmp(Confused, global::TCP_Client.Properties.Resources.Confused);
            this.Confused.Location = new System.Drawing.Point(3, 3);
            this.Confused.Name = "Confused";
            this.Confused.Size = new System.Drawing.Size(29, 29);
            this.Confused.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Confused.TabIndex = 0;
            this.Confused.TabStop = false;
            // 
            // panel65
            // 
            this.panel65.Controls.Add(this.Very_Sad);
            this.panel65.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel65.Location = new System.Drawing.Point(35, 5);
            this.panel65.Name = "panel65";
            this.panel65.Padding = new System.Windows.Forms.Padding(3);
            this.panel65.Size = new System.Drawing.Size(35, 35);
            this.panel65.TabIndex = 1;
            this.panel65.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Very_Sad
            // 
            this.Very_Sad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Very_Sad.Image = createBmp(Very_Sad, global::TCP_Client.Properties.Resources.Very_Sad);
            this.Very_Sad.Location = new System.Drawing.Point(3, 3);
            this.Very_Sad.Name = "Very_Sad";
            this.Very_Sad.Size = new System.Drawing.Size(29, 29);
            this.Very_Sad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Very_Sad.TabIndex = 0;
            this.Very_Sad.TabStop = false;
            // 
            // panel66
            // 
            this.panel66.Controls.Add(this.Neutral);
            this.panel66.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel66.Location = new System.Drawing.Point(0, 5);
            this.panel66.Margin = new System.Windows.Forms.Padding(0);
            this.panel66.Name = "panel66";
            this.panel66.Padding = new System.Windows.Forms.Padding(3);
            this.panel66.Size = new System.Drawing.Size(35, 35);
            this.panel66.TabIndex = 0;
            this.panel66.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Neutral
            // 
            this.Neutral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Neutral.Image = createBmp(Neutral, global::TCP_Client.Properties.Resources.Neutral);
            this.Neutral.Location = new System.Drawing.Point(3, 3);
            this.Neutral.Name = "Neutral";
            this.Neutral.Size = new System.Drawing.Size(29, 29);
            this.Neutral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Neutral.TabIndex = 0;
            this.Neutral.TabStop = false;
            // 
            // panel47
            // 
            this.panel47.Controls.Add(this.panel48);
            this.panel47.Controls.Add(this.panel49);
            this.panel47.Controls.Add(this.panel50);
            this.panel47.Controls.Add(this.panel51);
            this.panel47.Controls.Add(this.panel52);
            this.panel47.Controls.Add(this.panel53);
            this.panel47.Controls.Add(this.panel54);
            this.panel47.Controls.Add(this.panel55);
            this.panel47.Controls.Add(this.panel56);
            this.panel47.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel47.Location = new System.Drawing.Point(10, 199);
            this.panel47.Name = "panel47";
            this.panel47.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel47.Size = new System.Drawing.Size(315, 40);
            this.panel47.TabIndex = 7;
            // 
            // panel48
            // 
            this.panel48.Controls.Add(this.Expressionless);
            this.panel48.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel48.Location = new System.Drawing.Point(280, 5);
            this.panel48.Name = "panel48";
            this.panel48.Padding = new System.Windows.Forms.Padding(3);
            this.panel48.Size = new System.Drawing.Size(35, 35);
            this.panel48.TabIndex = 8;
            this.panel48.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Expressionless
            // 
            this.Expressionless.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Expressionless.Image = createBmp(Expressionless, global::TCP_Client.Properties.Resources.Expressionless);
            this.Expressionless.Location = new System.Drawing.Point(3, 3);
            this.Expressionless.Name = "Expressionless";
            this.Expressionless.Size = new System.Drawing.Size(29, 29);
            this.Expressionless.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Expressionless.TabIndex = 0;
            this.Expressionless.TabStop = false;
            // 
            // panel49
            // 
            this.panel49.Controls.Add(this.Sleeping);
            this.panel49.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel49.Location = new System.Drawing.Point(245, 5);
            this.panel49.Name = "panel49";
            this.panel49.Padding = new System.Windows.Forms.Padding(3);
            this.panel49.Size = new System.Drawing.Size(35, 35);
            this.panel49.TabIndex = 7;
            this.panel49.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Sleeping
            // 
            this.Sleeping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sleeping.Image = createBmp(Sleeping, global::TCP_Client.Properties.Resources.Sleeping);
            this.Sleeping.Location = new System.Drawing.Point(3, 3);
            this.Sleeping.Name = "Sleeping";
            this.Sleeping.Size = new System.Drawing.Size(29, 29);
            this.Sleeping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sleeping.TabIndex = 0;
            this.Sleeping.TabStop = false;
            // 
            // panel50
            // 
            this.panel50.Controls.Add(this.Smiling_Angel);
            this.panel50.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel50.Location = new System.Drawing.Point(210, 5);
            this.panel50.Name = "panel50";
            this.panel50.Padding = new System.Windows.Forms.Padding(3);
            this.panel50.Size = new System.Drawing.Size(35, 35);
            this.panel50.TabIndex = 6;
            this.panel50.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Smiling_Angel
            // 
            this.Smiling_Angel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Smiling_Angel.Image = createBmp(Smiling_Angel, global::TCP_Client.Properties.Resources.Smiling_Angel);
            this.Smiling_Angel.Location = new System.Drawing.Point(3, 3);
            this.Smiling_Angel.Name = "Smiling_Angel";
            this.Smiling_Angel.Size = new System.Drawing.Size(29, 29);
            this.Smiling_Angel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Smiling_Angel.TabIndex = 0;
            this.Smiling_Angel.TabStop = false;
            // 
            // panel51
            // 
            this.panel51.Controls.Add(this.Flushed_Face);
            this.panel51.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel51.Location = new System.Drawing.Point(175, 5);
            this.panel51.Name = "panel51";
            this.panel51.Padding = new System.Windows.Forms.Padding(3);
            this.panel51.Size = new System.Drawing.Size(35, 35);
            this.panel51.TabIndex = 5;
            this.panel51.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Flushed_Face
            // 
            this.Flushed_Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flushed_Face.Image = createBmp(Flushed_Face, global::TCP_Client.Properties.Resources.Flushed_Face);
            this.Flushed_Face.Location = new System.Drawing.Point(3, 3);
            this.Flushed_Face.Name = "Flushed_Face";
            this.Flushed_Face.Size = new System.Drawing.Size(29, 29);
            this.Flushed_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flushed_Face.TabIndex = 0;
            this.Flushed_Face.TabStop = false;
            // 
            // panel52
            // 
            this.panel52.Controls.Add(this.Blow_Kiss);
            this.panel52.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel52.Location = new System.Drawing.Point(140, 5);
            this.panel52.Name = "panel52";
            this.panel52.Padding = new System.Windows.Forms.Padding(3);
            this.panel52.Size = new System.Drawing.Size(35, 35);
            this.panel52.TabIndex = 4;
            this.panel52.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Blow_Kiss
            // 
            this.Blow_Kiss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Blow_Kiss.Image = createBmp(Blow_Kiss, global::TCP_Client.Properties.Resources.Blow_Kiss);
            this.Blow_Kiss.Location = new System.Drawing.Point(3, 3);
            this.Blow_Kiss.Name = "Blow_Kiss";
            this.Blow_Kiss.Size = new System.Drawing.Size(29, 29);
            this.Blow_Kiss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Blow_Kiss.TabIndex = 0;
            this.Blow_Kiss.TabStop = false;
            // 
            // panel53
            // 
            this.panel53.Controls.Add(this.Heart_Eyes);
            this.panel53.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel53.Location = new System.Drawing.Point(105, 5);
            this.panel53.Name = "panel53";
            this.panel53.Padding = new System.Windows.Forms.Padding(3);
            this.panel53.Size = new System.Drawing.Size(35, 35);
            this.panel53.TabIndex = 3;
            this.panel53.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Heart_Eyes
            // 
            this.Heart_Eyes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Heart_Eyes.Image = createBmp(Heart_Eyes, global::TCP_Client.Properties.Resources.Heart_Eyes);
            this.Heart_Eyes.Location = new System.Drawing.Point(3, 3);
            this.Heart_Eyes.Name = "Heart_Eyes";
            this.Heart_Eyes.Size = new System.Drawing.Size(29, 29);
            this.Heart_Eyes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Heart_Eyes.TabIndex = 0;
            this.Heart_Eyes.TabStop = false;
            // 
            // panel54
            // 
            this.panel54.Controls.Add(this.OMG_Face);
            this.panel54.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel54.Location = new System.Drawing.Point(70, 5);
            this.panel54.Name = "panel54";
            this.panel54.Padding = new System.Windows.Forms.Padding(3);
            this.panel54.Size = new System.Drawing.Size(35, 35);
            this.panel54.TabIndex = 2;
            this.panel54.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // OMG_Face
            // 
            this.OMG_Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OMG_Face.Image = createBmp(OMG_Face, global::TCP_Client.Properties.Resources.OMG_Face);
            this.OMG_Face.Location = new System.Drawing.Point(3, 3);
            this.OMG_Face.Name = "OMG_Face";
            this.OMG_Face.Size = new System.Drawing.Size(29, 29);
            this.OMG_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OMG_Face.TabIndex = 0;
            this.OMG_Face.TabStop = false;
            // 
            // panel55
            // 
            this.panel55.Controls.Add(this.Cold_Sweat);
            this.panel55.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel55.Location = new System.Drawing.Point(35, 5);
            this.panel55.Name = "panel55";
            this.panel55.Padding = new System.Windows.Forms.Padding(3);
            this.panel55.Size = new System.Drawing.Size(35, 35);
            this.panel55.TabIndex = 1;
            this.panel55.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Cold_Sweat
            // 
            this.Cold_Sweat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cold_Sweat.Image = createBmp(Cold_Sweat, global::TCP_Client.Properties.Resources.Cold_Sweat);
            this.Cold_Sweat.Location = new System.Drawing.Point(3, 3);
            this.Cold_Sweat.Name = "Cold_Sweat";
            this.Cold_Sweat.Size = new System.Drawing.Size(29, 29);
            this.Cold_Sweat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cold_Sweat.TabIndex = 0;
            this.Cold_Sweat.TabStop = false;
            // 
            // panel56
            // 
            this.panel56.Controls.Add(this.Fearful_Face);
            this.panel56.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel56.Location = new System.Drawing.Point(0, 5);
            this.panel56.Margin = new System.Windows.Forms.Padding(0);
            this.panel56.Name = "panel56";
            this.panel56.Padding = new System.Windows.Forms.Padding(3);
            this.panel56.Size = new System.Drawing.Size(35, 35);
            this.panel56.TabIndex = 0;
            this.panel56.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Fearful_Face
            // 
            this.Fearful_Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fearful_Face.Image = createBmp(Fearful_Face, global::TCP_Client.Properties.Resources.Fearful_Face);
            this.Fearful_Face.Location = new System.Drawing.Point(3, 3);
            this.Fearful_Face.Name = "Fearful_Face";
            this.Fearful_Face.Size = new System.Drawing.Size(29, 29);
            this.Fearful_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fearful_Face.TabIndex = 0;
            this.Fearful_Face.TabStop = false;
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.panel38);
            this.panel37.Controls.Add(this.panel39);
            this.panel37.Controls.Add(this.panel40);
            this.panel37.Controls.Add(this.panel41);
            this.panel37.Controls.Add(this.panel42);
            this.panel37.Controls.Add(this.panel43);
            this.panel37.Controls.Add(this.panel44);
            this.panel37.Controls.Add(this.panel45);
            this.panel37.Controls.Add(this.panel46);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel37.Location = new System.Drawing.Point(10, 159);
            this.panel37.Name = "panel37";
            this.panel37.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel37.Size = new System.Drawing.Size(315, 40);
            this.panel37.TabIndex = 6;
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.Snoring);
            this.panel38.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel38.Location = new System.Drawing.Point(280, 5);
            this.panel38.Name = "panel38";
            this.panel38.Padding = new System.Windows.Forms.Padding(3);
            this.panel38.Size = new System.Drawing.Size(35, 35);
            this.panel38.TabIndex = 8;
            this.panel38.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Snoring
            // 
            this.Snoring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Snoring.Image = createBmp(Snoring, global::TCP_Client.Properties.Resources.Snoring);
            this.Snoring.Location = new System.Drawing.Point(3, 3);
            this.Snoring.Name = "Snoring";
            this.Snoring.Size = new System.Drawing.Size(29, 29);
            this.Snoring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Snoring.TabIndex = 0;
            this.Snoring.TabStop = false;
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.Thinking);
            this.panel39.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel39.Location = new System.Drawing.Point(245, 5);
            this.panel39.Name = "panel39";
            this.panel39.Padding = new System.Windows.Forms.Padding(3);
            this.panel39.Size = new System.Drawing.Size(35, 35);
            this.panel39.TabIndex = 7;
            this.panel39.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Thinking
            // 
            this.Thinking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Thinking.Image = createBmp(Thinking, global::TCP_Client.Properties.Resources.Thinking);
            this.Thinking.Location = new System.Drawing.Point(3, 3);
            this.Thinking.Name = "Thinking";
            this.Thinking.Size = new System.Drawing.Size(29, 29);
            this.Thinking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Thinking.TabIndex = 0;
            this.Thinking.TabStop = false;
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.Rolling_Eyes);
            this.panel40.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel40.Location = new System.Drawing.Point(210, 5);
            this.panel40.Name = "panel40";
            this.panel40.Padding = new System.Windows.Forms.Padding(3);
            this.panel40.Size = new System.Drawing.Size(35, 35);
            this.panel40.TabIndex = 6;
            this.panel40.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Rolling_Eyes
            // 
            this.Rolling_Eyes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rolling_Eyes.Image = createBmp(Rolling_Eyes, global::TCP_Client.Properties.Resources.Rolling_Eyes);
            this.Rolling_Eyes.Location = new System.Drawing.Point(3, 3);
            this.Rolling_Eyes.Name = "Rolling_Eyes";
            this.Rolling_Eyes.Size = new System.Drawing.Size(29, 29);
            this.Rolling_Eyes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rolling_Eyes.TabIndex = 0;
            this.Rolling_Eyes.TabStop = false;
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.Anguished_Face);
            this.panel41.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel41.Location = new System.Drawing.Point(175, 5);
            this.panel41.Name = "panel41";
            this.panel41.Padding = new System.Windows.Forms.Padding(3);
            this.panel41.Size = new System.Drawing.Size(35, 35);
            this.panel41.TabIndex = 5;
            this.panel41.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Anguished_Face
            // 
            this.Anguished_Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Anguished_Face.Image = createBmp(Anguished_Face, global::TCP_Client.Properties.Resources.Anguished_Face);
            this.Anguished_Face.Location = new System.Drawing.Point(3, 3);
            this.Anguished_Face.Name = "Anguished_Face";
            this.Anguished_Face.Size = new System.Drawing.Size(29, 29);
            this.Anguished_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Anguished_Face.TabIndex = 0;
            this.Anguished_Face.TabStop = false;
            // 
            // panel42
            // 
            this.panel42.Controls.Add(this.Surprised);
            this.panel42.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel42.Location = new System.Drawing.Point(140, 5);
            this.panel42.Name = "panel42";
            this.panel42.Padding = new System.Windows.Forms.Padding(3);
            this.panel42.Size = new System.Drawing.Size(35, 35);
            this.panel42.TabIndex = 4;
            this.panel42.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Surprised
            // 
            this.Surprised.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Surprised.Image = createBmp(Surprised, global::TCP_Client.Properties.Resources.Surprised);
            this.Surprised.Location = new System.Drawing.Point(3, 3);
            this.Surprised.Name = "Surprised";
            this.Surprised.Size = new System.Drawing.Size(29, 29);
            this.Surprised.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Surprised.TabIndex = 0;
            this.Surprised.TabStop = false;
            // 
            // panel43
            // 
            this.panel43.Controls.Add(this.Frowning_Face);
            this.panel43.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel43.Location = new System.Drawing.Point(105, 5);
            this.panel43.Name = "panel43";
            this.panel43.Padding = new System.Windows.Forms.Padding(3);
            this.panel43.Size = new System.Drawing.Size(35, 35);
            this.panel43.TabIndex = 3;
            this.panel43.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Frowning_Face
            // 
            this.Frowning_Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Frowning_Face.Image = createBmp(Frowning_Face, global::TCP_Client.Properties.Resources.Frowning_Face);
            this.Frowning_Face.Location = new System.Drawing.Point(3, 3);
            this.Frowning_Face.Name = "Frowning_Face";
            this.Frowning_Face.Size = new System.Drawing.Size(29, 29);
            this.Frowning_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Frowning_Face.TabIndex = 0;
            this.Frowning_Face.TabStop = false;
            // 
            // panel44
            // 
            this.panel44.Controls.Add(this.Hushed_Face);
            this.panel44.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel44.Location = new System.Drawing.Point(70, 5);
            this.panel44.Name = "panel44";
            this.panel44.Padding = new System.Windows.Forms.Padding(3);
            this.panel44.Size = new System.Drawing.Size(35, 35);
            this.panel44.TabIndex = 2;
            this.panel44.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Hushed_Face
            // 
            this.Hushed_Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hushed_Face.Image = createBmp(Hushed_Face, global::TCP_Client.Properties.Resources.Hushed_Face);
            this.Hushed_Face.Location = new System.Drawing.Point(3, 3);
            this.Hushed_Face.Name = "Hushed_Face";
            this.Hushed_Face.Size = new System.Drawing.Size(29, 29);
            this.Hushed_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hushed_Face.TabIndex = 0;
            this.Hushed_Face.TabStop = false;
            // 
            // panel45
            // 
            this.panel45.Controls.Add(this.Silence);
            this.panel45.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel45.Location = new System.Drawing.Point(35, 5);
            this.panel45.Name = "panel45";
            this.panel45.Padding = new System.Windows.Forms.Padding(3);
            this.panel45.Size = new System.Drawing.Size(35, 35);
            this.panel45.TabIndex = 1;
            this.panel45.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Silence
            // 
            this.Silence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Silence.Image = createBmp(Silence, global::TCP_Client.Properties.Resources.Silence);
            this.Silence.Location = new System.Drawing.Point(3, 3);
            this.Silence.Name = "Silence";
            this.Silence.Size = new System.Drawing.Size(29, 29);
            this.Silence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Silence.TabIndex = 0;
            this.Silence.TabStop = false;
            // 
            // panel46
            // 
            this.panel46.Controls.Add(this.Wink);
            this.panel46.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel46.Location = new System.Drawing.Point(0, 5);
            this.panel46.Margin = new System.Windows.Forms.Padding(0);
            this.panel46.Name = "panel46";
            this.panel46.Padding = new System.Windows.Forms.Padding(3);
            this.panel46.Size = new System.Drawing.Size(35, 35);
            this.panel46.TabIndex = 0;
            this.panel46.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Wink
            // 
            this.Wink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wink.Image = createBmp(Wink, global::TCP_Client.Properties.Resources.Wink);
            this.Wink.Location = new System.Drawing.Point(3, 3);
            this.Wink.Name = "Wink";
            this.Wink.Size = new System.Drawing.Size(29, 29);
            this.Wink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Wink.TabIndex = 0;
            this.Wink.TabStop = false;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.panel28);
            this.panel27.Controls.Add(this.panel29);
            this.panel27.Controls.Add(this.panel30);
            this.panel27.Controls.Add(this.panel31);
            this.panel27.Controls.Add(this.panel32);
            this.panel27.Controls.Add(this.panel33);
            this.panel27.Controls.Add(this.panel34);
            this.panel27.Controls.Add(this.panel35);
            this.panel27.Controls.Add(this.panel123);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel27.Location = new System.Drawing.Point(10, 119);
            this.panel27.Name = "panel27";
            this.panel27.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel27.Size = new System.Drawing.Size(315, 40);
            this.panel27.TabIndex = 5;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.Hungry_Face);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel28.Location = new System.Drawing.Point(280, 5);
            this.panel28.Name = "panel28";
            this.panel28.Padding = new System.Windows.Forms.Padding(3);
            this.panel28.Size = new System.Drawing.Size(35, 35);
            this.panel28.TabIndex = 8;
            this.panel28.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Hungry_Face
            // 
            this.Hungry_Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hungry_Face.Image = createBmp(Hungry_Face, global::TCP_Client.Properties.Resources.Hungry_Face);
            this.Hungry_Face.Location = new System.Drawing.Point(3, 3);
            this.Hungry_Face.Name = "Hungry_Face";
            this.Hungry_Face.Size = new System.Drawing.Size(29, 29);
            this.Hungry_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hungry_Face.TabIndex = 0;
            this.Hungry_Face.TabStop = false;
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.Grinmacing_Face);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel29.Location = new System.Drawing.Point(245, 5);
            this.panel29.Name = "panel29";
            this.panel29.Padding = new System.Windows.Forms.Padding(3);
            this.panel29.Size = new System.Drawing.Size(35, 35);
            this.panel29.TabIndex = 7;
            this.panel29.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Grinmacing_Face
            // 
            this.Grinmacing_Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grinmacing_Face.Image = createBmp(Grinmacing_Face, global::TCP_Client.Properties.Resources.Grinmacing_Face);
            this.Grinmacing_Face.Location = new System.Drawing.Point(3, 3);
            this.Grinmacing_Face.Name = "Grinmacing_Face";
            this.Grinmacing_Face.Size = new System.Drawing.Size(29, 29);
            this.Grinmacing_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Grinmacing_Face.TabIndex = 0;
            this.Grinmacing_Face.TabStop = false;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.Grinning);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel30.Location = new System.Drawing.Point(210, 5);
            this.panel30.Name = "panel30";
            this.panel30.Padding = new System.Windows.Forms.Padding(3);
            this.panel30.Size = new System.Drawing.Size(35, 35);
            this.panel30.TabIndex = 6;
            this.panel30.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Grinning
            // 
            this.Grinning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grinning.Image = createBmp(Grinning, global::TCP_Client.Properties.Resources.Grinning);
            this.Grinning.Location = new System.Drawing.Point(3, 3);
            this.Grinning.Name = "Grinning";
            this.Grinning.Size = new System.Drawing.Size(29, 29);
            this.Grinning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Grinning.TabIndex = 0;
            this.Grinning.TabStop = false;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.Cool);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel31.Location = new System.Drawing.Point(175, 5);
            this.panel31.Name = "panel31";
            this.panel31.Padding = new System.Windows.Forms.Padding(3);
            this.panel31.Size = new System.Drawing.Size(35, 35);
            this.panel31.TabIndex = 5;
            this.panel31.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Cool
            // 
            this.Cool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cool.Image = createBmp(Cool, global::TCP_Client.Properties.Resources.Cool);
            this.Cool.Location = new System.Drawing.Point(3, 3);
            this.Cool.Name = "Cool";
            this.Cool.Size = new System.Drawing.Size(29, 29);
            this.Cool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cool.TabIndex = 0;
            this.Cool.TabStop = false;
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.Nerdy);
            this.panel32.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel32.Location = new System.Drawing.Point(140, 5);
            this.panel32.Name = "panel32";
            this.panel32.Padding = new System.Windows.Forms.Padding(3);
            this.panel32.Size = new System.Drawing.Size(35, 35);
            this.panel32.TabIndex = 4;
            this.panel32.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Nerdy
            // 
            this.Nerdy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nerdy.Image = createBmp(Nerdy, global::TCP_Client.Properties.Resources.Nerdy);
            this.Nerdy.Location = new System.Drawing.Point(3, 3);
            this.Nerdy.Name = "Nerdy";
            this.Nerdy.Size = new System.Drawing.Size(29, 29);
            this.Nerdy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nerdy.TabIndex = 0;
            this.Nerdy.TabStop = false;
            // 
            // panel33
            // 
            this.panel33.Controls.Add(this.Duck_Face);
            this.panel33.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel33.Location = new System.Drawing.Point(105, 5);
            this.panel33.Name = "panel33";
            this.panel33.Padding = new System.Windows.Forms.Padding(3);
            this.panel33.Size = new System.Drawing.Size(35, 35);
            this.panel33.TabIndex = 3;
            this.panel33.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Duck_Face
            // 
            this.Duck_Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Duck_Face.Image = createBmp(Nerdy, global::TCP_Client.Properties.Resources.Duck_Face);
            this.Duck_Face.Location = new System.Drawing.Point(3, 3);
            this.Duck_Face.Name = "Duck_Face";
            this.Duck_Face.Size = new System.Drawing.Size(29, 29);
            this.Duck_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Duck_Face.TabIndex = 0;
            this.Duck_Face.TabStop = false;
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.Kissing_Face);
            this.panel34.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel34.Location = new System.Drawing.Point(70, 5);
            this.panel34.Name = "panel34";
            this.panel34.Padding = new System.Windows.Forms.Padding(3);
            this.panel34.Size = new System.Drawing.Size(35, 35);
            this.panel34.TabIndex = 2;
            this.panel34.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Kissing_Face
            // 
            this.Kissing_Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Kissing_Face.Image = createBmp(Kissing_Face, global::TCP_Client.Properties.Resources.Kissing_Face);
            this.Kissing_Face.Location = new System.Drawing.Point(3, 3);
            this.Kissing_Face.Name = "Kissing_Face";
            this.Kissing_Face.Size = new System.Drawing.Size(29, 29);
            this.Kissing_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kissing_Face.TabIndex = 0;
            this.Kissing_Face.TabStop = false;
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.Nervous_Kiss);
            this.panel35.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel35.Location = new System.Drawing.Point(35, 5);
            this.panel35.Name = "panel35";
            this.panel35.Padding = new System.Windows.Forms.Padding(3);
            this.panel35.Size = new System.Drawing.Size(35, 35);
            this.panel35.TabIndex = 1;
            this.panel35.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Nervous_Kiss
            // 
            this.Nervous_Kiss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nervous_Kiss.Image = createBmp(Nervous_Kiss, global::TCP_Client.Properties.Resources.Nervous_Kiss);
            this.Nervous_Kiss.Location = new System.Drawing.Point(3, 3);
            this.Nervous_Kiss.Name = "Nervous_Kiss";
            this.Nervous_Kiss.Size = new System.Drawing.Size(29, 29);
            this.Nervous_Kiss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nervous_Kiss.TabIndex = 0;
            this.Nervous_Kiss.TabStop = false;
            // 
            // panel123
            // 
            this.panel123.Controls.Add(this.Shyly_Smiling);
            this.panel123.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel123.Location = new System.Drawing.Point(0, 5);
            this.panel123.Margin = new System.Windows.Forms.Padding(0);
            this.panel123.Name = "panel123";
            this.panel123.Padding = new System.Windows.Forms.Padding(3);
            this.panel123.Size = new System.Drawing.Size(35, 35);
            this.panel123.TabIndex = 0;
            this.panel123.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Shyly_Smiling
            // 
            this.Shyly_Smiling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Shyly_Smiling.Image = createBmp(Shyly_Smiling, global::TCP_Client.Properties.Resources.Shyly_Smiling);
            this.Shyly_Smiling.Location = new System.Drawing.Point(3, 3);
            this.Shyly_Smiling.Name = "Shyly_Smiling";
            this.Shyly_Smiling.Size = new System.Drawing.Size(29, 29);
            this.Shyly_Smiling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shyly_Smiling.TabIndex = 0;
            this.Shyly_Smiling.TabStop = false;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Controls.Add(this.panel19);
            this.panel17.Controls.Add(this.panel20);
            this.panel17.Controls.Add(this.panel21);
            this.panel17.Controls.Add(this.panel22);
            this.panel17.Controls.Add(this.panel23);
            this.panel17.Controls.Add(this.panel24);
            this.panel17.Controls.Add(this.panel25);
            this.panel17.Controls.Add(this.panel26);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(10, 79);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel17.Size = new System.Drawing.Size(315, 40);
            this.panel17.TabIndex = 4;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.Blushing);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel18.Location = new System.Drawing.Point(280, 5);
            this.panel18.Name = "panel18";
            this.panel18.Padding = new System.Windows.Forms.Padding(3);
            this.panel18.Size = new System.Drawing.Size(35, 35);
            this.panel18.TabIndex = 8;
            this.panel18.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Blushing
            // 
            this.Blushing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Blushing.Image = createBmp(Blushing, global::TCP_Client.Properties.Resources.Blushing);
            this.Blushing.Location = new System.Drawing.Point(3, 3);
            this.Blushing.Name = "Blushing";
            this.Blushing.Size = new System.Drawing.Size(29, 29);
            this.Blushing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Blushing.TabIndex = 0;
            this.Blushing.TabStop = false;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.Hugging_Face);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel19.Location = new System.Drawing.Point(245, 5);
            this.panel19.Name = "panel19";
            this.panel19.Padding = new System.Windows.Forms.Padding(3);
            this.panel19.Size = new System.Drawing.Size(35, 35);
            this.panel19.TabIndex = 7;
            this.panel19.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Hugging_Face
            // 
            this.Hugging_Face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hugging_Face.Image = createBmp(Hugging_Face, global::TCP_Client.Properties.Resources.Hugging_Face);
            this.Hugging_Face.Location = new System.Drawing.Point(3, 3);
            this.Hugging_Face.Name = "Hugging_Face";
            this.Hugging_Face.Size = new System.Drawing.Size(29, 29);
            this.Hugging_Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hugging_Face.TabIndex = 0;
            this.Hugging_Face.TabStop = false;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.Winking_Eye_Tongue_Out);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel20.Location = new System.Drawing.Point(210, 5);
            this.panel20.Name = "panel20";
            this.panel20.Padding = new System.Windows.Forms.Padding(3);
            this.panel20.Size = new System.Drawing.Size(35, 35);
            this.panel20.TabIndex = 6;
            this.panel20.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Winking_Eye_Tongue_Out
            // 
            this.Winking_Eye_Tongue_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Winking_Eye_Tongue_Out.Image = createBmp(Winking_Eye_Tongue_Out, global::TCP_Client.Properties.Resources.Winking_Eye_Tongue_Out);
            this.Winking_Eye_Tongue_Out.Location = new System.Drawing.Point(3, 3);
            this.Winking_Eye_Tongue_Out.Name = "Winking_Eye_Tongue_Out";
            this.Winking_Eye_Tongue_Out.Size = new System.Drawing.Size(29, 29);
            this.Winking_Eye_Tongue_Out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Winking_Eye_Tongue_Out.TabIndex = 0;
            this.Winking_Eye_Tongue_Out.TabStop = false;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.Closed_Eyes_Tongue_Out);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel21.Location = new System.Drawing.Point(175, 5);
            this.panel21.Name = "panel21";
            this.panel21.Padding = new System.Windows.Forms.Padding(3);
            this.panel21.Size = new System.Drawing.Size(35, 35);
            this.panel21.TabIndex = 5;
            this.panel21.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Closed_Eyes_Tongue_Out
            // 
            this.Closed_Eyes_Tongue_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Closed_Eyes_Tongue_Out.Image = createBmp(Closed_Eyes_Tongue_Out, global::TCP_Client.Properties.Resources.Closed_Eyes_Tongue_Out);
            this.Closed_Eyes_Tongue_Out.Location = new System.Drawing.Point(3, 3);
            this.Closed_Eyes_Tongue_Out.Name = "Closed_Eyes_Tongue_Out";
            this.Closed_Eyes_Tongue_Out.Size = new System.Drawing.Size(29, 29);
            this.Closed_Eyes_Tongue_Out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Closed_Eyes_Tongue_Out.TabIndex = 0;
            this.Closed_Eyes_Tongue_Out.TabStop = false;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.Tongue_Out);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel22.Location = new System.Drawing.Point(140, 5);
            this.panel22.Name = "panel22";
            this.panel22.Padding = new System.Windows.Forms.Padding(3);
            this.panel22.Size = new System.Drawing.Size(35, 35);
            this.panel22.TabIndex = 4;
            this.panel22.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Tongue_Out
            // 
            this.Tongue_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tongue_Out.Image = createBmp(Tongue_Out, global::TCP_Client.Properties.Resources.Tongue_Out);
            this.Tongue_Out.Location = new System.Drawing.Point(3, 3);
            this.Tongue_Out.Name = "Tongue_Out";
            this.Tongue_Out.Size = new System.Drawing.Size(29, 29);
            this.Tongue_Out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tongue_Out.TabIndex = 0;
            this.Tongue_Out.TabStop = false;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.Money);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel23.Location = new System.Drawing.Point(105, 5);
            this.panel23.Name = "panel23";
            this.panel23.Padding = new System.Windows.Forms.Padding(3);
            this.panel23.Size = new System.Drawing.Size(35, 35);
            this.panel23.TabIndex = 3;
            this.panel23.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Money
            // 
            this.Money.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Money.Image = createBmp(Money, global::TCP_Client.Properties.Resources.Money);
            this.Money.Location = new System.Drawing.Point(3, 3);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(29, 29);
            this.Money.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Money.TabIndex = 0;
            this.Money.TabStop = false;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.Relieved);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel24.Location = new System.Drawing.Point(70, 5);
            this.panel24.Name = "panel24";
            this.panel24.Padding = new System.Windows.Forms.Padding(3);
            this.panel24.Size = new System.Drawing.Size(35, 35);
            this.panel24.TabIndex = 2;
            this.panel24.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Relieved
            // 
            this.Relieved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Relieved.Image = createBmp(Relieved, global::TCP_Client.Properties.Resources.Relieved);
            this.Relieved.Location = new System.Drawing.Point(3, 3);
            this.Relieved.Name = "Relieved";
            this.Relieved.Size = new System.Drawing.Size(29, 29);
            this.Relieved.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Relieved.TabIndex = 0;
            this.Relieved.TabStop = false;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.Sad);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel25.Location = new System.Drawing.Point(35, 5);
            this.panel25.Name = "panel25";
            this.panel25.Padding = new System.Windows.Forms.Padding(3);
            this.panel25.Size = new System.Drawing.Size(35, 35);
            this.panel25.TabIndex = 1;
            this.panel25.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Sad
            // 
            this.Sad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sad.Image = createBmp(Sad, global::TCP_Client.Properties.Resources.Sad);
            this.Sad.Location = new System.Drawing.Point(3, 3);
            this.Sad.Name = "Sad";
            this.Sad.Size = new System.Drawing.Size(29, 29);
            this.Sad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sad.TabIndex = 0;
            this.Sad.TabStop = false;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.Unamused);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel26.Location = new System.Drawing.Point(0, 5);
            this.panel26.Margin = new System.Windows.Forms.Padding(0);
            this.panel26.Name = "panel26";
            this.panel26.Padding = new System.Windows.Forms.Padding(3);
            this.panel26.Size = new System.Drawing.Size(35, 35);
            this.panel26.TabIndex = 0;
            this.panel26.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Unamused
            // 
            this.Unamused.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Unamused.Image = createBmp(Unamused, global::TCP_Client.Properties.Resources.Unamused);
            this.Unamused.Location = new System.Drawing.Point(3, 3);
            this.Unamused.Name = "Unamused";
            this.Unamused.Size = new System.Drawing.Size(29, 29);
            this.Unamused.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Unamused.TabIndex = 0;
            this.Unamused.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel16);
            this.panel7.Controls.Add(this.panel15);
            this.panel7.Controls.Add(this.panel14);
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(10, 39);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel7.Size = new System.Drawing.Size(315, 40);
            this.panel7.TabIndex = 3;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.Smirk);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(280, 5);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(3);
            this.panel16.Size = new System.Drawing.Size(35, 35);
            this.panel16.TabIndex = 8;
            this.panel16.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Smirk
            // 
            this.Smirk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Smirk.Image = createBmp(Smirk, global::TCP_Client.Properties.Resources.Smirk);
            this.Smirk.Location = new System.Drawing.Point(3, 3);
            this.Smirk.Name = "Smirk";
            this.Smirk.Size = new System.Drawing.Size(29, 29);
            this.Smirk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Smirk.TabIndex = 0;
            this.Smirk.TabStop = false;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.Tears_of_Joy);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(245, 5);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(3);
            this.panel15.Size = new System.Drawing.Size(35, 35);
            this.panel15.TabIndex = 7;
            this.panel15.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Tears_of_Joy
            // 
            this.Tears_of_Joy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tears_of_Joy.Image = createBmp(Tears_of_Joy, global::TCP_Client.Properties.Resources.Tears_of_Joy);
            this.Tears_of_Joy.Location = new System.Drawing.Point(3, 3);
            this.Tears_of_Joy.Name = "Tears_of_Joy";
            this.Tears_of_Joy.Size = new System.Drawing.Size(29, 29);
            this.Tears_of_Joy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tears_of_Joy.TabIndex = 0;
            this.Tears_of_Joy.TabStop = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.Sweat_Smiling);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(210, 5);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(3);
            this.panel14.Size = new System.Drawing.Size(35, 35);
            this.panel14.TabIndex = 6;
            this.panel14.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Sweat_Smiling
            // 
            this.Sweat_Smiling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sweat_Smiling.Image = createBmp(Sweat_Smiling, global::TCP_Client.Properties.Resources.Sweat_Smiling);
            this.Sweat_Smiling.Location = new System.Drawing.Point(3, 3);
            this.Sweat_Smiling.Name = "Sweat_Smiling";
            this.Sweat_Smiling.Size = new System.Drawing.Size(29, 29);
            this.Sweat_Smiling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sweat_Smiling.TabIndex = 0;
            this.Sweat_Smiling.TabStop = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.Eyes_Closed_Smiling);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(175, 5);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(3);
            this.panel13.Size = new System.Drawing.Size(35, 35);
            this.panel13.TabIndex = 5;
            this.panel13.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Eyes_Closed_Smiling
            // 
            this.Eyes_Closed_Smiling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Eyes_Closed_Smiling.Image = createBmp(Eyes_Closed_Smiling, global::TCP_Client.Properties.Resources.Eyes_Closed_Smiling);
            this.Eyes_Closed_Smiling.Location = new System.Drawing.Point(3, 3);
            this.Eyes_Closed_Smiling.Name = "Eyes_Closed_Smiling";
            this.Eyes_Closed_Smiling.Size = new System.Drawing.Size(29, 29);
            this.Eyes_Closed_Smiling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Eyes_Closed_Smiling.TabIndex = 0;
            this.Eyes_Closed_Smiling.TabStop = false;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.Happy_Eyes_Smiling);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(140, 5);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(3);
            this.panel12.Size = new System.Drawing.Size(35, 35);
            this.panel12.TabIndex = 4;
            this.panel12.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Happy_Eyes_Smiling
            // 
            this.Happy_Eyes_Smiling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Happy_Eyes_Smiling.Image = createBmp(Happy_Eyes_Smiling, global::TCP_Client.Properties.Resources.Happy_Eyes_Smiling);
            this.Happy_Eyes_Smiling.Location = new System.Drawing.Point(3, 3);
            this.Happy_Eyes_Smiling.Name = "Happy_Eyes_Smiling";
            this.Happy_Eyes_Smiling.Size = new System.Drawing.Size(29, 29);
            this.Happy_Eyes_Smiling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Happy_Eyes_Smiling.TabIndex = 0;
            this.Happy_Eyes_Smiling.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.Eyes_Opened_Smiling);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(105, 5);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(3);
            this.panel11.Size = new System.Drawing.Size(35, 35);
            this.panel11.TabIndex = 3;
            this.panel11.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Eyes_Opened_Smiling
            // 
            this.Eyes_Opened_Smiling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Eyes_Opened_Smiling.Image = createBmp(Eyes_Opened_Smiling, global::TCP_Client.Properties.Resources.Eyes_Opened_Smiling);
            this.Eyes_Opened_Smiling.Location = new System.Drawing.Point(3, 3);
            this.Eyes_Opened_Smiling.Name = "Eyes_Opened_Smiling";
            this.Eyes_Opened_Smiling.Size = new System.Drawing.Size(29, 29);
            this.Eyes_Opened_Smiling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Eyes_Opened_Smiling.TabIndex = 0;
            this.Eyes_Opened_Smiling.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.Smiling);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(70, 5);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(3);
            this.panel10.Size = new System.Drawing.Size(35, 35);
            this.panel10.TabIndex = 2;
            this.panel10.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Smiling
            // 
            this.Smiling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Smiling.Image = createBmp(Smiling, global::TCP_Client.Properties.Resources.Smiling);
            this.Smiling.Location = new System.Drawing.Point(3, 3);
            this.Smiling.Name = "Smiling";
            this.Smiling.Size = new System.Drawing.Size(29, 29);
            this.Smiling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Smiling.TabIndex = 0;
            this.Smiling.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.Upside_Down);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(35, 5);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(3);
            this.panel9.Size = new System.Drawing.Size(35, 35);
            this.panel9.TabIndex = 1;
            this.panel9.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Upside_Down
            // 
            this.Upside_Down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Upside_Down.Image = createBmp(Upside_Down, global::TCP_Client.Properties.Resources.Upside_Down);
            this.Upside_Down.Location = new System.Drawing.Point(3, 3);
            this.Upside_Down.Name = "Upside_Down";
            this.Upside_Down.Size = new System.Drawing.Size(29, 29);
            this.Upside_Down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Upside_Down.TabIndex = 0;
            this.Upside_Down.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.Slightly_Smiling);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 5);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(3);
            this.panel8.Size = new System.Drawing.Size(35, 35);
            this.panel8.TabIndex = 0;
            this.panel8.VisibleChanged += new System.EventHandler(this.emoji_Paint);
            // 
            // Slightly_Smiling
            // 
            this.Slightly_Smiling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Slightly_Smiling.Image = createBmp(Slightly_Smiling, global::TCP_Client.Properties.Resources.Slightly_Smiling);
            this.Slightly_Smiling.Location = new System.Drawing.Point(3, 3);
            this.Slightly_Smiling.Name = "Slightly_Smiling";
            this.Slightly_Smiling.Size = new System.Drawing.Size(27, 27);
            this.Slightly_Smiling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Slightly_Smiling.TabIndex = 0;
            this.Slightly_Smiling.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(315, 1);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(315, 10);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(116)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emoji Faces";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.emojiCode);
            this.panel2.Controls.Add(this.emojiName);
            this.panel2.Controls.Add(this.currentEmoji);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(83, 50, 83, 50);
            this.panel2.Size = new System.Drawing.Size(356, 290);
            this.panel2.TabIndex = 0;
            // 
            // emojiCode
            // 
            this.emojiCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.emojiCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojiCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(116)))), ((int)(((byte)(134)))));
            this.emojiCode.Location = new System.Drawing.Point(185, 264);
            this.emojiCode.Name = "emojiCode";
            this.emojiCode.Size = new System.Drawing.Size(140, 23);
            this.emojiCode.TabIndex = 2;
            this.emojiCode.Text = ":)";
            this.emojiCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emojiName
            // 
            this.emojiName.AutoSize = true;
            this.emojiName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojiName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.emojiName.Location = new System.Drawing.Point(11, 267);
            this.emojiName.Name = "emojiName";
            this.emojiName.Size = new System.Drawing.Size(46, 20);
            this.emojiName.TabIndex = 1;
            this.emojiName.Text = "Smile";
            this.emojiName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentEmoji
            // 
            this.currentEmoji.BackColor = System.Drawing.Color.White;
            this.currentEmoji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.currentEmoji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentEmoji.ErrorImage = null;
            this.currentEmoji.Image = global::TCP_Client.Properties.Resources.Slightly_Smiling;
            this.currentEmoji.InitialImage = null;
            this.currentEmoji.Location = new System.Drawing.Point(83, 50);
            this.currentEmoji.Name = "currentEmoji";
            this.currentEmoji.Size = new System.Drawing.Size(190, 190);
            this.currentEmoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentEmoji.TabIndex = 0;
            this.currentEmoji.TabStop = false;
            // 
            // EmojiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 576);
            this.Controls.Add(this.borderColor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmojiPanel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EmojiPanel";
            this.LostFocus += new System.EventHandler(this.EmojiPanel_LostFocus);
            this.borderColor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel77.ResumeLayout(false);
            this.panel78.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).EndInit();
            this.panel79.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Alien)).EndInit();
            this.panel80.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Angry_Devil)).EndInit();
            this.panel81.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Smiling_Devil)).EndInit();
            this.panel82.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Poop)).EndInit();
            this.panel83.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Crying)).EndInit();
            this.panel84.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Disappointed_but_Relieved)).EndInit();
            this.panel85.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Loudly_Crying)).EndInit();
            this.panel86.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sweat)).EndInit();
            this.panel67.ResumeLayout(false);
            this.panel68.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Disappointed)).EndInit();
            this.panel69.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Angry)).EndInit();
            this.panel70.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Very_Angry)).EndInit();
            this.panel71.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Recovering)).EndInit();
            this.panel72.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Fever)).EndInit();
            this.panel73.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sick)).EndInit();
            this.panel74.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lips_Sealed)).EndInit();
            this.panel75.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dizzy)).EndInit();
            this.panel76.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Astonished)).EndInit();
            this.panel57.ResumeLayout(false);
            this.panel58.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Confounded_Face)).EndInit();
            this.panel59.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Persevering_Face)).EndInit();
            this.panel60.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Weary)).EndInit();
            this.panel61.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tired)).EndInit();
            this.panel62.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Very_Mad)).EndInit();
            this.panel63.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Worried)).EndInit();
            this.panel64.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Confused)).EndInit();
            this.panel65.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Very_Sad)).EndInit();
            this.panel66.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Neutral)).EndInit();
            this.panel47.ResumeLayout(false);
            this.panel48.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Expressionless)).EndInit();
            this.panel49.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sleeping)).EndInit();
            this.panel50.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Smiling_Angel)).EndInit();
            this.panel51.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Flushed_Face)).EndInit();
            this.panel52.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Blow_Kiss)).EndInit();
            this.panel53.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Heart_Eyes)).EndInit();
            this.panel54.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OMG_Face)).EndInit();
            this.panel55.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cold_Sweat)).EndInit();
            this.panel56.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Fearful_Face)).EndInit();
            this.panel37.ResumeLayout(false);
            this.panel38.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Snoring)).EndInit();
            this.panel39.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Thinking)).EndInit();
            this.panel40.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Rolling_Eyes)).EndInit();
            this.panel41.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Anguished_Face)).EndInit();
            this.panel42.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Surprised)).EndInit();
            this.panel43.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Frowning_Face)).EndInit();
            this.panel44.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hushed_Face)).EndInit();
            this.panel45.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Silence)).EndInit();
            this.panel46.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Wink)).EndInit();
            this.panel27.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hungry_Face)).EndInit();
            this.panel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grinmacing_Face)).EndInit();
            this.panel30.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grinning)).EndInit();
            this.panel31.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cool)).EndInit();
            this.panel32.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Nerdy)).EndInit();
            this.panel33.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Duck_Face)).EndInit();
            this.panel34.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Kissing_Face)).EndInit();
            this.panel35.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Nervous_Kiss)).EndInit();
            this.panel123.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Shyly_Smiling)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Blushing)).EndInit();
            this.panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hugging_Face)).EndInit();
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Winking_Eye_Tongue_Out)).EndInit();
            this.panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Closed_Eyes_Tongue_Out)).EndInit();
            this.panel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tongue_Out)).EndInit();
            this.panel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Money)).EndInit();
            this.panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Relieved)).EndInit();
            this.panel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sad)).EndInit();
            this.panel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Unamused)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Smirk)).EndInit();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tears_of_Joy)).EndInit();
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sweat_Smiling)).EndInit();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Eyes_Closed_Smiling)).EndInit();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Happy_Eyes_Smiling)).EndInit();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Eyes_Opened_Smiling)).EndInit();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Smiling)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Upside_Down)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Slightly_Smiling)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentEmoji)).EndInit();
            this.ResumeLayout(false);
        }

        public Bitmap createBmp(PictureBox pb, Image emoji)
        {
            //Lower Quality for the large collection of images
            Bitmap newImage = new Bitmap(emoji,pb.Width,pb.Height);
            /*using (Graphics gr = Graphics.FromImage(newImage))
            {
                //gr.SmoothingMode = SmoothingMode.HighSpeed;
                //gr.InterpolationMode = InterpolationMode.
                //gr.PixelOffsetMode = PixelOffsetMode.Half;
            }*/
            return newImage;
        }

        #endregion

        public System.Windows.Forms.Panel borderColor;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.PictureBox Upside_Down;
        public System.Windows.Forms.Panel panel10;
        public System.Windows.Forms.PictureBox Smiling;
        public System.Windows.Forms.PictureBox Slightly_Smiling;
        public System.Windows.Forms.PictureBox currentEmoji;
        public System.Windows.Forms.Panel panel11;
        public System.Windows.Forms.PictureBox Eyes_Opened_Smiling;
        public System.Windows.Forms.Panel panel14;
        public System.Windows.Forms.PictureBox Sweat_Smiling;
        public System.Windows.Forms.Panel panel13;
        public System.Windows.Forms.PictureBox Eyes_Closed_Smiling;
        public System.Windows.Forms.Panel panel12;
        public System.Windows.Forms.PictureBox Happy_Eyes_Smiling;
        public System.Windows.Forms.Panel panel16;
        public System.Windows.Forms.PictureBox Smirk;
        public System.Windows.Forms.Panel panel15;
        public System.Windows.Forms.PictureBox Tears_of_Joy;
        public System.Windows.Forms.Panel panel17;
        public System.Windows.Forms.Panel panel18;
        public System.Windows.Forms.PictureBox Blushing;
        public System.Windows.Forms.Panel panel19;
        public System.Windows.Forms.PictureBox Hugging_Face;
        public System.Windows.Forms.Panel panel20;
        public System.Windows.Forms.PictureBox Winking_Eye_Tongue_Out;
        public System.Windows.Forms.Panel panel21;
        public System.Windows.Forms.PictureBox Closed_Eyes_Tongue_Out;
        public System.Windows.Forms.Panel panel22;
        public System.Windows.Forms.PictureBox Tongue_Out;
        public System.Windows.Forms.Panel panel23;
        public System.Windows.Forms.PictureBox Money;
        public System.Windows.Forms.Panel panel24;
        public System.Windows.Forms.PictureBox Relieved;
        public System.Windows.Forms.Panel panel25;
        public System.Windows.Forms.PictureBox Sad;
        public System.Windows.Forms.Panel panel26;
        public System.Windows.Forms.PictureBox Unamused;
        public System.Windows.Forms.Panel panel47;
        public System.Windows.Forms.Panel panel48;
        public System.Windows.Forms.PictureBox Expressionless;
        public System.Windows.Forms.Panel panel49;
        public System.Windows.Forms.PictureBox Sleeping;
        public System.Windows.Forms.Panel panel50;
        public System.Windows.Forms.PictureBox Smiling_Angel;
        public System.Windows.Forms.Panel panel51;
        public System.Windows.Forms.PictureBox Flushed_Face;
        public System.Windows.Forms.Panel panel52;
        public System.Windows.Forms.PictureBox Blow_Kiss;
        public System.Windows.Forms.Panel panel53;
        public System.Windows.Forms.PictureBox Heart_Eyes;
        public System.Windows.Forms.Panel panel54;
        public System.Windows.Forms.PictureBox OMG_Face;
        public System.Windows.Forms.Panel panel55;
        public System.Windows.Forms.PictureBox Cold_Sweat;
        public System.Windows.Forms.Panel panel56;
        public System.Windows.Forms.PictureBox Fearful_Face;
        public System.Windows.Forms.Panel panel37;
        public System.Windows.Forms.Panel panel38;
        public System.Windows.Forms.PictureBox Snoring;
        public System.Windows.Forms.Panel panel39;
        public System.Windows.Forms.PictureBox Thinking;
        public System.Windows.Forms.Panel panel40;
        public System.Windows.Forms.PictureBox Rolling_Eyes;
        public System.Windows.Forms.Panel panel41;
        public System.Windows.Forms.PictureBox Anguished_Face;
        public System.Windows.Forms.Panel panel42;
        public System.Windows.Forms.PictureBox Surprised;
        public System.Windows.Forms.Panel panel43;
        public System.Windows.Forms.PictureBox Frowning_Face;
        public System.Windows.Forms.Panel panel44;
        public System.Windows.Forms.PictureBox Hushed_Face;
        public System.Windows.Forms.Panel panel45;
        public System.Windows.Forms.PictureBox Silence;
        public System.Windows.Forms.Panel panel46;
        public System.Windows.Forms.PictureBox Wink;
        public System.Windows.Forms.Panel panel27;
        public System.Windows.Forms.Panel panel28;
        public System.Windows.Forms.PictureBox Hungry_Face;
        public System.Windows.Forms.Panel panel29;
        public System.Windows.Forms.PictureBox Grinmacing_Face;
        public System.Windows.Forms.Panel panel30;
        public System.Windows.Forms.PictureBox Grinning;
        public System.Windows.Forms.Panel panel31;
        public System.Windows.Forms.PictureBox Cool;
        public System.Windows.Forms.Panel panel32;
        public System.Windows.Forms.PictureBox Nerdy;
        public System.Windows.Forms.Panel panel33;
        public System.Windows.Forms.PictureBox Duck_Face;
        public System.Windows.Forms.Panel panel34;
        public System.Windows.Forms.PictureBox Kissing_Face;
        public System.Windows.Forms.Panel panel35;
        public System.Windows.Forms.PictureBox Nervous_Kiss;
        public System.Windows.Forms.Panel panel123;
        public System.Windows.Forms.PictureBox Shyly_Smiling;
        public System.Windows.Forms.Panel panel57;
        public System.Windows.Forms.Panel panel58;
        public System.Windows.Forms.PictureBox Confounded_Face;
        public System.Windows.Forms.Panel panel59;
        public System.Windows.Forms.PictureBox Persevering_Face;
        public System.Windows.Forms.Panel panel60;
        public System.Windows.Forms.PictureBox Weary;
        public System.Windows.Forms.Panel panel61;
        public System.Windows.Forms.PictureBox Tired;
        public System.Windows.Forms.Panel panel62;
        public System.Windows.Forms.PictureBox Very_Mad;
        public System.Windows.Forms.Panel panel63;
        public System.Windows.Forms.PictureBox Worried;
        public System.Windows.Forms.Panel panel64;
        public System.Windows.Forms.PictureBox Confused;
        public System.Windows.Forms.Panel panel65;
        public System.Windows.Forms.PictureBox Very_Sad;
        public System.Windows.Forms.Panel panel66;
        public System.Windows.Forms.PictureBox Neutral;
        public System.Windows.Forms.Panel panel67;
        public System.Windows.Forms.Panel panel68;
        public System.Windows.Forms.PictureBox Disappointed;
        public System.Windows.Forms.Panel panel69;
        public System.Windows.Forms.PictureBox Angry;
        public System.Windows.Forms.Panel panel70;
        public System.Windows.Forms.PictureBox Very_Angry;
        public System.Windows.Forms.Panel panel71;
        public System.Windows.Forms.PictureBox Recovering;
        public System.Windows.Forms.Panel panel72;
        public System.Windows.Forms.PictureBox Fever;
        public System.Windows.Forms.Panel panel73;
        public System.Windows.Forms.PictureBox Sick;
        public System.Windows.Forms.Panel panel74;
        public System.Windows.Forms.PictureBox Lips_Sealed;
        public System.Windows.Forms.Panel panel75;
        public System.Windows.Forms.PictureBox Dizzy;
        public System.Windows.Forms.Panel panel76;
        public System.Windows.Forms.PictureBox Astonished;
        public System.Windows.Forms.Panel panel77;
        public System.Windows.Forms.Panel panel78;
        public System.Windows.Forms.PictureBox Ghost;
        public System.Windows.Forms.Panel panel79;
        public System.Windows.Forms.PictureBox Alien;
        public System.Windows.Forms.Panel panel80;
        public System.Windows.Forms.PictureBox Angry_Devil;
        public System.Windows.Forms.Panel panel81;
        public System.Windows.Forms.PictureBox Smiling_Devil;
        public System.Windows.Forms.Panel panel82;
        public System.Windows.Forms.PictureBox Poop;
        public System.Windows.Forms.Panel panel83;
        public System.Windows.Forms.PictureBox Crying;
        public System.Windows.Forms.Panel panel84;
        public System.Windows.Forms.PictureBox Disappointed_but_Relieved;
        public System.Windows.Forms.Panel panel85;
        public System.Windows.Forms.PictureBox Loudly_Crying;
        public System.Windows.Forms.Panel panel86;
        public System.Windows.Forms.PictureBox Sweat;
        public System.Windows.Forms.Label emojiName;
        public System.Windows.Forms.Label emojiCode;
    }
}