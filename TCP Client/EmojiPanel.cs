using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TCP_Client
{
    public partial class EmojiPanel : Form
    {
        private Panel currentPicture;
        private ClientForm parent;
        private bool painted = false;

        private List<String> eCodes = EmojiCodes.getEmojiCodes();
        private List<PictureBox> ePics = new List<PictureBox>();

        public EmojiPanel(ClientForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            currentPicture = panel8;
            fillEmojiCodes();
        }

        //Fixes black flickering on creation
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void EmojiPanel_LostFocus(object sender, EventArgs e)
        {
            this.Visible = false;
            painted = true;//Only paint the emoji panel once
            parent.emojiPanel.Image = global::TCP_Client.Properties.Resources.Emoji_Dark;

            //Only if emojis where added to the control
           // if(parent.msgBox.GetObjectCount(parent.msgBox) > 0 && parent.contactIndex >= 0)
           //     parent.btnSend.Enabled = true;
        }

        private void emoji_Paint(object sender, EventArgs e)
        {
            if(painted) return;
            Panel picturePanel = (Panel)sender;
            PictureBox emoji = (PictureBox)picturePanel.Controls[0];
            Timer time = new Timer();
            time.Interval = 1;
            time.Tick += (send, f) => Time_Tick(picturePanel, e, time);
            time.Start();

            picturePanel.MouseClick += (send, f) => emoji_Clicked(emoji, e);
            emoji.MouseClick += (send, f) => emoji_Clicked(emoji, e);
        }

        private void Time_Tick(Panel picture, EventArgs e, Timer timer)
        {
            if(currentPicture != picture && picture.ClientRectangle.Contains(picture.PointToClient(Cursor.Position)) && this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                if (currentPicture != null)
                    currentPicture.BorderStyle = BorderStyle.None;
                PictureBox emoji = (PictureBox)picture.Controls[0];
                picture.BorderStyle = BorderStyle.FixedSingle;

                currentEmoji.Image = (Image)Properties.Resources.ResourceManager.GetObject(emoji.Name);
                currentPicture = picture;
                emojiName.Text = emoji.Name.Replace('_', ' ');
                emojiCode.Text = eCodes[ePics.FindIndex(x => x.Name.Equals(emoji.Name))];
            }
        }

        private void emoji_Clicked(PictureBox emoji, EventArgs e)
        {
           // if (parent.contactIndex >= 0)
           //     if (parent.contactList[parent.contactIndex].getCurrentMessage() == "" && parent.msgBox.GetObjectCount(parent.msgBox) == 0)
           //         parent.msgBox.Clear();
            parent.invokeMessageBox(true);

            parent.msgBox.InsertControl(getEmoji(emoji.Image,Color.White,24), ePics.FindIndex(x => x.Name.Equals(emoji.Name)));
            parent.saveCurrentMessage();
        }

        public Panel getEmoji(Image emoji,Color color,int size)
        {
            Panel emojiPanel = new Panel();
            emojiPanel.BackColor = color;
            emojiPanel.Padding = new Padding(3, 0, 3, 0);
            emojiPanel.Dock = DockStyle.Left;
            emojiPanel.Size = new Size(size+6, size);

            PictureBox newEmoji = new PictureBox();
            newEmoji.BackColor = Color.Transparent;
            newEmoji.Dock = DockStyle.Fill;
            newEmoji.Size = new Size(size,size);
            newEmoji.Image = createBmp(newEmoji,emoji);
            newEmoji.SizeMode = PictureBoxSizeMode.StretchImage;

            emojiPanel.Controls.Add(newEmoji);
            return emojiPanel;
        }

        //This funciton is really slow atm, need to decode in order
        public void insertEmoji(MyFixedRichTextBox messageBox)
        {
            List<int> codeIndex = new List<int>();
            List<Image> emojiImage = new List<Image>();
            List<string> codes = getEmojiCodes();
            List<int> usedIndex = new List<int>();

            for (int a = 0; a < codes.Count; a++)
                if (messageBox.Text.Contains(codes[a]))
                    usedIndex.Add(a);

            if(usedIndex.Count > 0)
                for (int a = 0; a < messageBox.Text.Length; a++)
                {
                    for (int b = 0; b < usedIndex.Count; b++)
                    {
                        if (messageBox.Text.Length > a + codes[usedIndex[b]].Length - 1)
                            if(messageBox.Text.Substring(a, codes[usedIndex[b]].Length) == codes[usedIndex[b]])
                            {
                                messageBox.Text = messageBox.Text.Remove(a, codes[usedIndex[b]].Length);
                                codeIndex.Add(a);
                                emojiImage.Add(getEmojiPics()[usedIndex[b]].Image);
                                a--;
                                break;
                            }
                    }
                }
            //for(int a = codeIndex.Count - 1; a > -1; a--)
            for (int a = codeIndex.Count - 1; a > -1; a--)
            {
                messageBox.SelectionStart = codeIndex[a];
                messageBox.InsertControl(getEmoji(emojiImage[a], messageBox.BackColor, 25), getEmojiPics().FindIndex(x => x.Image.Equals(emojiImage[a])));
            }
        }

        public void fillEmojiCodes()
        {
            //First Row
            ePics.Add(Slightly_Smiling);
            ePics.Add(Upside_Down);
            ePics.Add(Smiling);
            ePics.Add(Eyes_Opened_Smiling);
            ePics.Add(Happy_Eyes_Smiling);
            ePics.Add(Eyes_Closed_Smiling);
            ePics.Add(Sweat_Smiling);
            ePics.Add(Tears_of_Joy);
            ePics.Add(Smirk);

            //Second Row
            ePics.Add(Unamused);
            ePics.Add(Sad);
            ePics.Add(Relieved);
            ePics.Add(Money);
            ePics.Add(Tongue_Out);
            ePics.Add(Closed_Eyes_Tongue_Out);
            ePics.Add(Winking_Eye_Tongue_Out);
            ePics.Add(Hugging_Face);
            ePics.Add(Blushing);

            //Third Row
            ePics.Add(Shyly_Smiling);
            ePics.Add(Nervous_Kiss);
            ePics.Add(Kissing_Face);
            ePics.Add(Duck_Face);
            ePics.Add(Nerdy);
            ePics.Add(Cool);
            ePics.Add(Grinning);
            ePics.Add(Grinmacing_Face);
            ePics.Add(Hungry_Face);

            //Fourth Row
            ePics.Add(Wink);
            ePics.Add(Silence);
            ePics.Add(Hushed_Face);
            ePics.Add(Frowning_Face);
            ePics.Add(Surprised);
            ePics.Add(Anguished_Face);
            ePics.Add(Rolling_Eyes);
            ePics.Add(Thinking);
            ePics.Add(Snoring);

            //Fifth Row
            ePics.Add(Fearful_Face);
            ePics.Add(Cold_Sweat);
            ePics.Add(OMG_Face);
            ePics.Add(Heart_Eyes);
            ePics.Add(Blow_Kiss);
            ePics.Add(Flushed_Face);
            ePics.Add(Smiling_Angel);
            ePics.Add(Sleeping);
            ePics.Add(Expressionless);

            //Sixth Row
            ePics.Add(Neutral);
            ePics.Add(Very_Sad);
            ePics.Add(Confused);
            ePics.Add(Worried);
            ePics.Add(Very_Mad);
            ePics.Add(Tired);
            ePics.Add(Weary);
            ePics.Add(Persevering_Face);
            ePics.Add(Confounded_Face);

            //Seventh row
            ePics.Add(Astonished);
            ePics.Add(Dizzy);
            ePics.Add(Lips_Sealed);
            ePics.Add(Sick);
            ePics.Add(Fever);
            ePics.Add(Recovering);
            ePics.Add(Very_Angry);
            ePics.Add(Angry);
            ePics.Add(Disappointed);

            //Eigth Row
            ePics.Add(Sweat);
            ePics.Add(Loudly_Crying);
            ePics.Add(Disappointed_but_Relieved);
            ePics.Add(Crying);
            ePics.Add(Poop);
            ePics.Add(Smiling_Devil);
            ePics.Add(Angry_Devil);
            ePics.Add(Alien);
            ePics.Add(Ghost);
        }
        public List<PictureBox> getEmojiPics() { return ePics; }
        public List<string> getEmojiCodes() { return eCodes; }
    }

    public class EmojiCodes
    {
        public static List<string> getEmojiCodes()
        {
            List<string> eCodes = new List<string>();
            //First Row
            eCodes.Add(":)");
            eCodes.Add("(:");
            eCodes.Add("(smile)");
            eCodes.Add(":D");
            eCodes.Add("(he smile)");
            eCodes.Add("(ec smile)");
            eCodes.Add("(s smile)");
            eCodes.Add("(tof)");
            eCodes.Add("(smirk)");

            //Second Row
            eCodes.Add("(unamused)");
            eCodes.Add("(sad)");
            eCodes.Add("(relieved)");
            eCodes.Add(":$");
            eCodes.Add("(to)");
            eCodes.Add("(ecto)");
            eCodes.Add("(wink to)");
            eCodes.Add("(hug)");
            eCodes.Add("(blush)");

            //Third Row
            eCodes.Add("(shy)");
            eCodes.Add("(n kiss)");
            eCodes.Add(":x");
            eCodes.Add("(duck)");
            eCodes.Add("(nerd)");
            eCodes.Add("(cool)");
            eCodes.Add("(grin)");
            eCodes.Add("(grinmacing)");
            eCodes.Add("(hungry)");

            //Fourth Row
            eCodes.Add(";)");
            eCodes.Add("(silence)");
            eCodes.Add("(hush)");
            eCodes.Add("(frown)");
            eCodes.Add(":O");
            eCodes.Add("(anguish)");
            eCodes.Add("(roll)");
            eCodes.Add("(think)");
            eCodes.Add("(snore)");

            //Fifth Row
            eCodes.Add("(fear)");
            eCodes.Add("(cold)");
            eCodes.Add("(omg)");
            eCodes.Add("(heart)");
            eCodes.Add("(b kiss)");
            eCodes.Add("(flushed)");
            eCodes.Add("(angel)");
            eCodes.Add("(sleeping)");
            eCodes.Add("(dull)");

            //Sixth Row
            eCodes.Add("(neutral)");
            eCodes.Add(":(");
            eCodes.Add("(confused)");
            eCodes.Add("(worry)");
            eCodes.Add("(fuious)");
            eCodes.Add("(tired)");
            eCodes.Add("(weary)");
            eCodes.Add("(perservering)");
            eCodes.Add("(confounded)");

            //Seventh row
            eCodes.Add("(amazed)");
            eCodes.Add("(dizzy)");
            eCodes.Add("(ls)");
            eCodes.Add("(sick)");
            eCodes.Add("(fever)");
            eCodes.Add("(recover)");
            eCodes.Add("(pissed)");
            eCodes.Add("(mad)");
            eCodes.Add("(disappinted)");

            //Eigth Row
            eCodes.Add("(sweat)");
            eCodes.Add("(loud cry)");
            eCodes.Add("(dbr)");
            eCodes.Add("(cry)");
            eCodes.Add("(poop)");
            eCodes.Add("(happy d)");
            eCodes.Add("(angry d)");
            eCodes.Add("(alien)");
            eCodes.Add("(ghost)");
            return eCodes;
        }
    }
}