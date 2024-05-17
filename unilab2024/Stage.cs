using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Emit;

namespace unilab2024
{
    public partial class Stage : Form
    {
        public Stage()
        {
            InitializeComponent();
            //this.AllowDrop = true;
            //this.DragDrop += new DragEventHandler(ListBox_DragDrop);          //Form全体にDrop可能にする
            //this.DragEnter += new DragEventHandler(ListBox_DragEnter);

            ////pictureBoxの設定
            //pictureBox2.Parent = pictureBox1;
            ////pictureBox1.Location = new Point(600, 50);
            //pictureBox2.Location = new Point(0, 0);
            //pictureBox1.ClientSize = new Size(684, 684);
            //pictureBox2.ClientSize = new Size(684, 684);
            //pictureBox2.BackColor = Color.Transparent;

            //bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //bmp2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            //bmp3 = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            ////bmp4 = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            //pictureBox1.Image = bmp1;
            //pictureBox2.Image = bmp2;
            //pictureBox3.Image = bmp3;
            ////pictureBox4.Image = bmp4;
            //this.Load += Stage_Load;

        }

        #region メンバー変数定義
        private string _stageName;
        public string StageName     //StageSelectからの呼び出し用
        {
            get { return _stageName; }
            set { _stageName = value; }
            //別フォームからのアクセス例
            //Stage form = new Stage();
            //form.StageName = "ステージ名";
        }
        #endregion

        #region グローバル変数定義
        //ここに必要なBitmapやImageを作っていく
        Bitmap bmp1, bmp2, bmp3, bmp4;

        Brush goalBackgroundColor = new SolidBrush(Color.Yellow);
        Brush startBackgroundColor = new SolidBrush(Color.Blue);

        //Image[] img_otomo = new Image[4] {
        //    Image.FromFile("キャラ_たぬき.png"),
        //    Image.FromFile("キャラ_きつね.png"),
        //    Image.FromFile("キャラ_あざらし.png"),
        //    Image.FromFile("キャラ_ふくろう.png")
        //};

        //Image character_me = Image.FromFile("忍者_正面.png");
        //Image[] character_enemy = new Image[6] {
        //    Image.FromFile("キャラ_一つ目小僧.png"),
        //    Image.FromFile("キャラ_唐傘一反.png"),
        //    Image.FromFile("キャラ_カッパ.png"),
        //    Image.FromFile("キャラ_てんぐ.png"),
        //    Image.FromFile("キャラ_赤鬼.png"),
        //    Image.FromFile("キャラ_ヤマタノオロチ.png")
        //};

        //Image img_maki = Image.FromFile("マップ_巻物.png");
        //Image img_way = Image.FromFile("マップ_草原.png");
        //Image img_noway = Image.FromFile("マップ_岩場.png");
        //Image img_ice = Image.FromFile("マップ_氷.png");
        //Image img_tree = Image.FromFile("マップ_木.png");
        //Image img_jump = Image.FromFile("マップ_ジャンプ1.png");
        //Image animatedImage_up = Image.FromFile("マップ_動く床_上.gif");
        //Image animatedImage_right = Image.FromFile("マップ_動く床_右.gif");
        //Image animatedImage_down = Image.FromFile("マップ_動く床_下.gif");
        //Image animatedImage_left = Image.FromFile("マップ_動く床_左.gif");
        //Image cloud_ul = Image.FromFile("マップ_雲_左上.png");
        //Image cloud_left = Image.FromFile("マップ_雲_左.png");
        //Image cloud_bl = Image.FromFile("マップ_雲_左下.png");
        //Image cloud_bottom = Image.FromFile("マップ_雲_下.png");
        //Image cloud_br = Image.FromFile("マップ_雲_右下.png");
        //Image cloud_right = Image.FromFile("マップ_雲_右.png");
        //Image cloud_ur = Image.FromFile("マップ_雲_右上.png");
        //Image cloud_upside = Image.FromFile("マップ_雲_上.png");
        public class Global    //グローバル変数
        {
            public static int[,] map = new int[12, 12]; //map情報
            public static int x_start; //スタート位置ｘ
            public static int y_start; //スタート位置ｙ
            public static int x_goal; //ゴール位置ｘ
            public static int y_goal; //ゴール位置ｙ
            public static int x_now; //現在位置ｘ
            public static int y_now; //現在位置 y

            public static int count = 0; //試行回数カウント
            public static int miss_count = 0; //ミスカウント

            public static int count_walk = 0; //歩数カウント

            public static List<int[]> move;  //プレイヤーの移動指示を入れるリスト

            //listBoxに入れられる行数の制限
            public static int limit_LB_Input;
            public static int limit_LB_A;
            public static int limit_LB_B;

            public static string hint;
            public static string hint_character;
            public static string hint_name;

            public static List<Conversation> Conversations = new List<Conversation>();  //会話文を入れるリスト
        }
        #endregion

        public class Conversation    //会話型のclass(structにするかも)
        {
            public string character = "";
            public string dialogue = "";
            public string img = "";
        }


        public void Stage_Load(object sender, EventArgs e)
        {
            //    //button5.Visible = false;
            //    //_stageName = "stage2-3";
            //    Global.map = CreateStage(stageName); //ステージ作成

            //    string str_num = Regex.Replace(stageName, @"[^0-9]", "");
            //    int num = int.Parse(str_num) / 10;

            //    string file_name = "わせマジ" + num.ToString() + "章.csv";

            //    Global.Conversations = LoadConversation(file_name); //会話読み込み

            #region リストボックス・ボタンの設定
            // 1行文の高さ
            int ItemHeight = 20;
            listBox_Input.ItemHeight = ItemHeight;
            listBox_options.ItemHeight = ItemHeight;
            listBox_A.ItemHeight = ItemHeight;
            listBox_B.ItemHeight = ItemHeight;
            listBox_SelectAB.ItemHeight = ItemHeight;

            int element_height = listBox_Input.ItemHeight;

            // それぞれの枠の高さ
            int height_LB_Input = 0;
            int height_LB_A = 0;
            int height_LB_B = 0;

            //using (StreamReader sr = new StreamReader($"stage_frame.csv"))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        string[] values = line.Split(',');


            //        if (values[0] == _stageName)
            //        {
            //            Global.limit_LB_Input = int.Parse(values[1]);
            //            Global.limit_LB_A = int.Parse(values[2]);
            //            Global.limit_LB_B = int.Parse(values[3]);
            //            break;
            //        }
            //    }
            //}

            height_LB_Input = Global.limit_LB_Input + 1;
            height_LB_A = Global.limit_LB_A + 1;
            height_LB_B = Global.limit_LB_B + 1;

            if (height_LB_Input == 1)
            {
                listBox_Input.Visible = false;
                label_Intro.Visible = false;
                listBox_SelectAB.Items.Remove("A");
                button_ResetInput.Visible = false;
                button_ResetInput.Enabled = false;

            }

            if (height_LB_A == 1)
            {
                listBox_A.Visible = false;
                label_B.Visible = false;
                listBox_B.Items.Remove("B");
                button_ResetInput.Visible = false;
                button_ResetInput.Enabled = false;
            }

            if (height_LB_Input == 1 && height_LB_A == 1)
            {
                listBox_SelectAB.Visible = false;
            }

            Global.hint = null;
            Global.hint_character = null;
            Global.hint_name = null;

            // CSVから読み込んだテキストを設定します。
            //using (StreamReader sr = new StreamReader($"hint.csv"))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        string[] values = line.Split(',');


            //        if (values[0] == _stageName)
            //        {
            //            Global.hint_character = values[1];
            //            Global.hint = values[2];
            //            Global.hint_name = values[3];
            //            break;
            //        }
            //    }
            //}

            if (Global.hint == null)
            {
                button_Hint.Visible = false;
            }
            else
            {
                button_Hint.Visible = true;
            }

            listBox_Input.Height = element_height * height_LB_Input;
            listBox_A.Height = element_height * height_LB_A;
            listBox_B.Height = element_height * height_LB_B;

            ////ListBox1のイベントハンドラを追加
            //listBox_Input.SelectionMode = SelectionMode.One;
            //listBox_Input.DragEnter += new DragEventHandler(ListBox_DragEnter);
            //listBox_Input.DragDrop += new DragEventHandler(ListBox_DragDrop);
            //listBox_options.MouseDown += new MouseEventHandler(ListBox_MouseDown);
            //listBox_A.SelectionMode = SelectionMode.One;
            //listBox_A.DragEnter += new DragEventHandler(ListBox_DragEnter);
            //listBox_A.DragDrop += new DragEventHandler(ListBox_DragDrop);
            //listBox_B.SelectionMode = SelectionMode.One;
            //listBox_B.DragEnter += new DragEventHandler(ListBox_DragEnter);
            //listBox_B.DragDrop += new DragEventHandler(ListBox_DragDrop);
            //listBox_SelectAB.MouseDown += new MouseEventHandler(ListBox_MouseDown);

            //    //ヒントを教えるキャラのアイコンを表示
            //    Graphics g3 = Graphics.FromImage(bmp3);
            //    Bitmap bmp = new Bitmap(1, 1);
            //    bmp.SetPixel(0, 0, Color.White);
            //    g3.DrawImage(bmp, 0, 0, bmp3.Height - 1, bmp3.Height - 1);
            //    g3.DrawRectangle(Pens.Black, 0, 0, bmp3.Height - 1, bmp3.Height - 1);
            //    g3.Dispose();

            //    //チュートリアルステージでは、マップに戻るボタンを消す。ゴールしたら見える
            //    if (stageName == "stage1-1")
            //    {
            //        button5.Visible = false;
            //    }
            //    //for文をステージ1-1,1-2で消す
            //    if (stageName == "stage1-1" || stageName == "stage1-2")
            //    {
            //        listBox2.Items.Remove("連チャンの術 (1)");
            //        listBox2.Items.Remove("連チャンの術おわり");
            //    }

            //    //ストーリー強制視聴
            //    listBox2.Enabled = false;
            //    listBox5.Enabled = false;
            //    button1.Enabled = false;
            //    button6.Enabled = false;
            //    button8.Enabled = false;
            //    drawConversation();
            #endregion
        }

        private void button_ResetInput_Click(object sender, EventArgs e)
        {
            Func.ResetListBox(listBox_Input, listBox_Input);
        }

        private void button_ResetA_Click(object sender, EventArgs e)
        {
           Func.ResetListBox(listBox_Input, listBox_A);
        }

        private void button_ResetB_Click(object sender, EventArgs e)
        {
            Func.ResetListBox(listBox_Input, listBox_B);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
           
        }
    }
}
