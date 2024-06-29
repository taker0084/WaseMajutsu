using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace unilab2024
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Func.LoadImg_Character();
            Func.LoadImg_DotPic();
            Func.LoadImg_Object();
            Func.LoadImg_Button();
            //Func.LoadImg_Background();//これ入れたらメモリが足りなくて動かなかった
            Func.InitializeClearCheck();

            Application.Run(new Title());
        }
    }

    #region フォーム呼び出し
    public static partial class Func
    {
        
        public static void CreatePrologue ()
        {
            Prologue form = new Prologue();
            form.Show();
        }
        
        public static void CreateWorldMap(Form currentForm) //呼び出し方: Func.CreateWorldMap(this);
        {
            WorldMap form = new WorldMap();
            form.Show();
            currentForm.Dispose();
        }

        public static void CreateAnotherWorld(Form currentForm) 
        {
            AnotherWorld form = new AnotherWorld();
            form.Show();
            currentForm.Dispose();
        }

        public static void CreateStageSelect(Form currentForm,string worldName, int worldNumber) //呼び出し方: Func.CreateStageSelect(this,"1年生",1);
        {
            StageSelect form = new StageSelect();
            form.WorldName = worldName;
            form.WorldNumber = worldNumber;
            form.Show();
            currentForm.Dispose();
        }

        public static void CreateStage(Form currentForm, string worldName,int worldNumber, int level) //呼び出し方: Func.CreateStageSelect(this,"1");  各ステージどう名付けるか決めたい
        {
            Stage form = new Stage();
            form.WorldName = worldName;
            form.WorldNumber = worldNumber;
            form.Level = level;
            form.Show();
            currentForm.Dispose();
        }
        
    }
    #endregion

    #region 会話
    public static partial class Func
    {
        public static List<Conversation> LoadConversations(string ConvFileName)  //引数はConversationファイルの名前
        {
            List<Conversation> Conversations = new List<Conversation>();

            using (StreamReader sr = new StreamReader($"{ConvFileName}"))
            {
                bool isFirstRow = true;

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(',');

                    if (isFirstRow) //escape 1st row
                    {
                        isFirstRow = false;
                        continue;
                    }

                    Conversations.Add(new Conversation(values[0], values[1], values[2]));
                }
            }

            return Conversations;
        }
    } 
    public struct Conversation
    {
        public string Character;
        public string Dialogue;
        public string Img;

        public Conversation(string character, string dialogue, string img)
        {
            Character = character;
            Dialogue = dialogue;
            Img = img;
        }
    }
    #endregion

    #region 各データのDictionaryと読み込み関数
    public partial class Dictionaries
    {
        //g1.DrawImage()の第1引数にDictionaries.Img_Character["画像名"]と入れて使う
        //使い方の例（in Prologue.cs）
        //g1.DrawImage(Dictionaries.Img_Character[Conversations[convIndex].Img], 15, adjust_y, face, face);
        //ここでのConversations[convIndex].Imgは"Teacher".
        public static Dictionary<string, Image> Img_Character = new Dictionary<string, Image>();
        public static Dictionary<string, Image> Img_DotPic = new Dictionary<string, Image>();
        public static List<Image> Img_Object = new List<Image>();
        public static Dictionary <string, Image> Img_Button = new Dictionary<string, Image>();
        public static Dictionary <string, Image> Img_Background = new Dictionary<string, Image>();
    }

    public partial class Func
    {
        //読み込みはProgram.csのMain関数内で行っている。以下の関数は他のFormで呼び出す必要はない。
        public static void LoadImg_Character()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "Img_Character_*.png");
            foreach (string file in files)
            {
                string key = Path.GetFileNameWithoutExtension(file).Replace("Img_Character_","");
                Dictionaries.Img_Character[key] = Image.FromFile(file);
            }
        }

        public static void LoadImg_DotPic()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "Img_DotPic_*.png");
            foreach (string file in files)
            {
                string key = Path.GetFileNameWithoutExtension(file).Replace("Img_DotPic_", "");
                Dictionaries.Img_DotPic[key] = Image.FromFile(file);
            }
        }
        public static void LoadImg_Object()
        {
            string[] files = Directory.GetFiles(@"Object");
            foreach (string file in files)
            {
                //string File_Name = file.Replace("Object\\", "");
                Dictionaries.Img_Object.Add(Image.FromFile(file));
            }
        }

        public static void LoadImg_Button()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "Img_Button_*.png");
            foreach (string file in files)
            {
                string key = Path.GetFileNameWithoutExtension(file).Replace("Img_Button_", "");
                Dictionaries.Img_Button[key] = Image.FromFile(file);
            }
        }

        public static void LoadImg_Background()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "Img_Background_*.png");
            foreach (string file in files)
            {
                string key = Path.GetFileNameWithoutExtension(file).Replace("Img_Background_", "");
                Dictionaries.Img_Background[key] = Image.FromFile(file);
            }
        }
    }
    #endregion

    #region 進行状況管理
    public enum ConstNum
    {
        numWorlds = 7+1,
        numStages = 3+1
    }
    public partial class ClearCheck
    {
        //クリアチェック配列
        //0番目はそのWorldのレベル3つをすべてクリアしたらtrueにする。
        public static bool[,] IsCleared = new bool[(int)ConstNum.numWorlds, (int)ConstNum.numStages];

        //ボタン管理配列
        //0番目はWorldMapでそのボタンを押せるかどうか（押せる場合true）
        public static bool[,] IsButtonEnabled = new bool[(int)ConstNum.numWorlds, (int)ConstNum.numStages];
    }

    public partial class Func
    {
        public static void InitializeClearCheck()    //Main関数で呼び出す
        {
            for (int i = 0; i < (int)ConstNum.numWorlds; i++)
            {
                for(int j = 0; j < (int)ConstNum.numStages; j++)
                {
                    ClearCheck.IsCleared[i, j] = false;
                    ClearCheck.IsButtonEnabled[i, j] = false;
                }
            }
            ClearCheck.IsButtonEnabled[1, 0] = true;
            ClearCheck.IsButtonEnabled[1, 1] = true;
        }
    }
    #endregion

    #region カスタムボタン（文字の上に画像を描画する）
    public class CustomButton : Button
    {
        private Image foreImage;

        public Image ForeImage
        {
            get { return foreImage; }
            set
            {
                foreImage = value;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //ボタンのベース描画
            base.OnPaint(pevent);

            //文字の描画
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            //背景画像を文字の上に描画
            if (this.ForeImage != null)
            {
                //Zoomレイアウトで背景画像を描画
                //ボタンサイズ
                int buttonWidth = this.Width;
                int buttonHeight = this.Height;
                //画像サイズ
                int imageWidth = this.ForeImage.Width;
                int imageHeight = this.ForeImage.Height;

                //縦横比を保ちながらスケーリング
                float scale = Math.Min((float)buttonWidth / imageWidth, (float)buttonHeight / imageHeight);
                int scaleWidth = (int)(imageWidth * scale);
                int scaleHeight = (int)(imageHeight * scale);

                //位置調整
                int x = (buttonWidth - scaleWidth) / 2;
                int y = (buttonHeight - scaleHeight) / 2;
                Rectangle destRect = new Rectangle(x, y, scaleWidth, scaleHeight);
               
                pevent.Graphics.DrawImage(this.ForeImage, destRect);
            }
        }

        private Rectangle GetZoomedRectangle(Image img, Rectangle bounds)
        {
            float imageAspect = (float)img.Width / img.Height;
            float controlAspect = (float)bounds.Width / bounds.Height;

            if (imageAspect > controlAspect)
            {
                int newHeight = (int)(bounds.Width / imageAspect);
                int yOffset = (bounds.Height - newHeight) / 2;
                return new Rectangle(0, yOffset, bounds.Width, newHeight);
            }
            else
            {
                int newWidth = (int)(bounds.Height * imageAspect);
                int xOffset = (bounds.Width - newWidth) / 2;
                return new Rectangle(xOffset, 0, newWidth, bounds.Height);
            }
        }
    }
    #endregion
}
