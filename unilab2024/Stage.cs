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

namespace unilab2024
{
    public partial class Stage : Form
    {
        public Stage()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(ListBox_DragDrop);          //Form全体にDrop可能にする
            this.DragEnter += new DragEventHandler(ListBox_DragEnter);

            //pictureBoxの設定
            pictureBox2.Parent = pictureBox1;
            //pictureBox1.Location = new Point(600, 50);
            pictureBox2.Location = new Point(0, 0);
            pictureBox1.ClientSize = new Size(684, 684);
            pictureBox2.ClientSize = new Size(684, 684);
            pictureBox2.BackColor = Color.Transparent;

            bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmp2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            bmp3 = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            //bmp4 = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            pictureBox1.Image = bmp1;
            pictureBox2.Image = bmp2;
            pictureBox3.Image = bmp3;
            //pictureBox4.Image = bmp4;
            this.Load += Stage_Load;

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

        //ここに必要なBitmapやImageを作っていく
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
            public static int limit_LB1;
            public static int limit_LB3;
            public static int limit_LB4;

            public static string hint;
            public static string hint_character;
            public static string hint_name;

            public static List<Conversation> Conversations = new List<Conversation>();  //会話文を入れるリスト
        }

        public class Conversation    //会話型のclass(structにするかも)
        {
            public string character = "";
            public string dialogue = "";
            public string img = "";
        }

    }
}
