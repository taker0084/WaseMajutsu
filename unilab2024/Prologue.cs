using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static unilab2024.Stage;

namespace unilab2024
{
    public partial class Prologue : Form
    {

        #region メンバ変数の定義など
        Bitmap bmpPB1, bmp_CharaImage, bmp_CharaName, bmp_Dialogue;
        List<Conversation> StartConv;
        List<Conversation> EndConv;
        bool isStartConv;
        int convIndex;

        public Prologue()
        {
            InitializeComponent();

            bmpPB1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmp_CharaImage = new Bitmap(pictureBox_CharaImage.Width, pictureBox_CharaImage.Height);
            bmp_CharaName = new Bitmap(pictureBox_CharaName.Width, pictureBox_CharaName.Height);
            bmp_Dialogue = new Bitmap(pictureBox_Dialogue.Width, pictureBox_Dialogue.Height);
            pictureBox1.Image = bmpPB1;

            this.KeyDown += new KeyEventHandler(Prologue_KeyDown);
            this.KeyPreview = true;
        }
        #endregion

        #region 読み込み時
        private void Prologue_Load(object sender, EventArgs e)
        {
            Graphics g1 = Graphics.FromImage(bmpPB1);

            string convFileName = "Story_Chapter0.csv";
            (StartConv, EndConv) = Func.LoadStories(convFileName, "Select"); //会話読み込み
            isStartConv = true;
            StartConversations();
        }
        #endregion

        #region 会話の表示（Form依存なのでこの位置）

        private void drawConversations(bool isStart)
        {
            Graphics g_CharaImage = Graphics.FromImage(bmp_CharaImage);
            Graphics g_CharaName = Graphics.FromImage(bmp_CharaName);
            Graphics g_Dialogue = Graphics.FromImage(bmp_Dialogue);

            //Pen pen = new Pen(Color.FromArgb(100, 255, 100), 2);
            Font fnt_name = new Font("游ゴシック", 33, FontStyle.Bold);
            Font fnt_dia = new Font("游ゴシック", 33);
            Brush Color_BackConv = new SolidBrush(ColorTranslator.FromHtml("#f8e58c"));
            Brush Color_BackName = new SolidBrush(ColorTranslator.FromHtml("#856859"));
            int sp = 5;

            int face = 300;
            int name_x = 300;
            int name_y = 60;

            int dia_x = 1500;
            int dia_y = 200;

            int lineHeight = fnt_dia.Height;

            g_CharaName.FillRectangle(Color_BackName, 0, 0, name_x, name_y);
            //g1.DrawRectangle(pen, 15, adjust_y + face, name_x, name_y);

            g_Dialogue.FillRectangle(Color_BackConv, 0, 0, dia_x, dia_y);
            //g1.DrawRectangle(pen, 15, adjust_y + face + name_y, dia_x, dia_y);

            List<Conversation> Conversations = new List<Conversation>();
            if (isStart)
            {
                Conversations = StartConv;
            }
            else
            {
                Conversations = EndConv;
            }

            if (convIndex >= Conversations.Count)
            {
                if (!isStart)
                {
                    Func.CreateStage(this, "1年生", 1, 1);
                    return;
                }
            }

            string charaName = Conversations[convIndex].Character;
            if (charaName == "主人公")
            {
                if (MainCharacter.isBoy)
                {
                    charaName = "タロウ";
                }
                else
                {
                    charaName = "ハナコ";
                }
            }

            g_CharaName.DrawString(charaName, fnt_name, Brushes.White, sp, sp);

            //改行の処理はこう書かないとうまくいかない
            char[] lineBreak = new char[] { '\\' };
            string[] DialogueLines = Conversations[convIndex].Dialogue.Replace("\\n", "\\").Split(lineBreak);
            for (int i = 0; i < DialogueLines.Length; i++)
            {
                g_Dialogue.DrawString(DialogueLines[i], fnt_dia, Brushes.Black, sp, sp + i * lineHeight);
            }

            Image charaImage = null;
            if (Conversations[convIndex].Img == "Main")
            {
                if (MainCharacter.isBoy)
                {
                    charaImage = Dictionaries.Img_Character["Boy"];
                }
                else
                {
                    charaImage = Dictionaries.Img_Character["Girl"];
                }
            }
            else
            {
                charaImage = Dictionaries.Img_Character[Conversations[convIndex].Img];
            }

            g_CharaImage.Clear(Color.Transparent);
            g_CharaImage.DrawImage(charaImage, 0, 0, face, face);

            pictureBox_CharaImage.Image = bmp_CharaImage;
            g_CharaImage.Dispose();
            pictureBox_CharaName.Image = bmp_CharaName;
            g_CharaName.Dispose();
            pictureBox_Dialogue.Image = bmp_Dialogue;
            g_Dialogue.Dispose();

            if (convIndex < Conversations.Count)
            {
                convIndex++;
            }
            if (isStart && convIndex == Conversations.Count)
            {
                ChangeControlEnable(false);
                isStartConv = false;
                button_Boy.Visible = true;
                button_Boy.Enabled = true;
                button_Girl.Visible = true;
                button_Girl.Enabled = true;
                button_Boy.ForeImage = Dictionaries.Img_Character["Boy"];
                button_Girl.ForeImage = Dictionaries.Img_Character["Girl"];
                button_Boy.Cursor = Cursors.Hand;
                button_Girl.Cursor = Cursors.Hand;
                return;
            }

        }

        private void ChangeControlEnable(bool isStart)//会話用
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = !isStart;
            }
            button_Boy.Visible = !isStart;
            button_Girl.Visible = !isStart;

            pictureBox_CharaImage.Enabled = isStart;
            pictureBox_CharaName.Enabled = isStart;
            pictureBox_Dialogue.Enabled = isStart;

            if (isStart)
            {
                pictureBox_Dialogue.Cursor = Cursors.Hand;
            }
            else
            {
                pictureBox_Dialogue.Cursor = Cursors.Default;
            }
        }

        private void StartConversations()
        {
            ChangeControlEnable(true);
            convIndex = 0;
            drawConversations(isStartConv);
        }
        #endregion

        #region 諸々クリックの処理
        private void pictureBox_Dialogue_Click(object sender, EventArgs e)
        {
            drawConversations(isStartConv);
        }

        private void button_CharaSelect_Click(object sender, EventArgs e)
        {
            CustomButton button = sender as CustomButton;
            if (button != null)
            {
                string NameWithoutButton = button.Name.Replace("button_", "");
                if (NameWithoutButton == "Boy")
                {
                    MainCharacter.isBoy = true;
                }
                else if (NameWithoutButton == "Girl")
                {
                    MainCharacter.isBoy = false;
                }
            }

            Func.LoadImg_DotPic();
            StartConversations();
        }
        #endregion

        #region ストーリースキップ用
        //public Prologue関数内に以下を追記
        //this.KeyDown += new KeyEventHandler(Prologue_KeyDown);
        //this.KeyPreview = true;
        private void Prologue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                Func.LoadImg_DotPic();
                Func.CreateStage(this, "1年生", 1, 1);
            }
        }
        #endregion
    }
}
