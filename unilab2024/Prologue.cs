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
        Dictionary<string, PictureBox> PictureBoxes;
        Dictionary<string, Bitmap> Bitmaps;
        List<Conversation> StartConv;
        List<Conversation> EndConv;
        bool isStartConv;

        public Prologue()
        {
            InitializeComponent();
            (PictureBoxes, Bitmaps) = Func.CreateConvPictureBox(this);
            PictureBoxes["Dialogue"].Click += new EventHandler(pictureBox_Dialogue_Click);

            this.KeyDown += new KeyEventHandler(Prologue_KeyDown);
            this.KeyPreview = true;
        }
        #endregion

        #region 読み込み時
        private void Prologue_Load(object sender, EventArgs e)
        {
            pictureBox_Background.BackgroundImage = Dictionaries.Img_Background["Prologue"];
            string convFileName = "Story_Chapter0.csv";
            (StartConv, EndConv) = Func.LoadStories(convFileName, "Select"); //会話読み込み
            isStartConv = true;
            //StartConversations();
            button_Boy.Visible = false;
            button_Girl.Visible = false;
            Func.StartConversations(this,PictureBoxes, Bitmaps,StartConv);
        }
        #endregion

        #region 会話用
        private void ChangeControlEnable()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
            button_Boy.Visible = true;
            button_Girl.Visible = true;
            button_Boy.BringToFront();
            button_Girl.BringToFront();

            PictureBoxes["CharaImage"].Enabled = false;
            PictureBoxes["CharaName"].Enabled = false;
            PictureBoxes["Dialogue"].Enabled = false;
            PictureBoxes["Dialogue"].Cursor = Cursors.Default;
            
        }
        #endregion

        #region 諸々クリックの処理
        private void pictureBox_Dialogue_Click(object sender, EventArgs e)
        {
            //drawConversations(isStartConv);
            if (isStartConv)
            {
                Func.DrawConversations(this, PictureBoxes, Bitmaps, StartConv);
                if (Func.convIndex == StartConv.Count)
                {
                    ChangeControlEnable();
                    isStartConv = false;
                    button_Boy.ForeImage = Dictionaries.Img_Character["Boy"];
                    button_Girl.ForeImage = Dictionaries.Img_Character["Girl"];
                    button_Boy.Cursor = Cursors.Hand;
                    button_Girl.Cursor = Cursors.Hand;
                    return;
                }
            }
            else
            {
                if (Func.convIndex == EndConv.Count)
                {
                    Func.CreateStage(this, "1年生", 1, 1);
                    return;
                }
                Func.DrawConversations(this, PictureBoxes, Bitmaps, EndConv);
            }
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
            button_Boy.Visible = false;
            button_Girl.Visible = false;
            Func.StartConversations(this, PictureBoxes, Bitmaps, EndConv);
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
