using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new Title());
        }
    }

    public static partial class Func
    {
        #region フォーム呼び出し
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

        public static void CreateStageSelect(Form currentForm,string worldName) //呼び出し方: Func.CreateStageSelect(this,"1年生");
        {
            StageSelect form = new StageSelect();
            form.WorldName = worldName;
            form.Show();
            currentForm.Dispose();
        }

        public static void CreateStage(Form currentForm, string stageName) //呼び出し方: Func.CreateStageSelect(this,"1");  各ステージどう名付けるか決めたい
        {
            Stage form = new Stage();
            form.StageName = stageName;
            form.Show();
            currentForm.Dispose();
        }
        #endregion
    }

    #region Program.CS関数
    public static partial class Func
    {
        public static void ResetListBox(ListBox listbox_Input, ListBox listbox)   //ListBoxの中身消去
        {
            if (listbox_Input.SelectedIndex > -1)
            {
                listbox.Items.RemoveAt(listbox.SelectedIndex);
            }
            else
            {
                listbox.Items.Clear();
            }
        }

        public static void ForLoopCount(ListBox listbox)  //for文回数読み込み処理
        {
            if (listbox.SelectedItem != null)
            {
                string command = listbox.SelectedItem.ToString();

                if (command == "反復魔法おわり")
                {
                    return;
                }
                if (command.StartsWith("反復魔法"))
                {
                    string str_num = Regex.Replace(command, @"[^0-9]", "");
                    int num = int.Parse(str_num);

                    int id = listbox.SelectedIndex;
                    listbox.Items[id] = "反復魔法 (" + (num % 9 + 1).ToString() + ")";

                    listbox.Refresh();
                }
            }
        }

        public static void Move(List<int[]> movelist,string direction)    //指定方向に移動する関数
        {
            int Direction_Index = int.Parse(direction);
            int[][] move = new int[4][];       // up,right.down,leftの順
            move[0] = [0, -1];     //up
            move[1] = [1, 0];      //right
            move[2] = [0, 1];      //down 
            move[3] = [-1, 0];     //left
            movelist.Add(move[Direction_Index]);
        }

        public static (List<int[]>,int a) ForLoop(List<string> Move_Input, List<int[]> Move_A, List<int[]> Move_B,int i)
        {
            int trial = 0;
            int Now = 0;
            List<int[]> Return_List = new List<int[]>();
            int Return_Num = i;
            if (Move_Input[i].StartsWith("for"))
            {
                Now = i + 1;
                int.Parse(Regex.Replace(Move_Input[i], @"[^0-9]", ""));
                for (int j = 0; j < trial; j++)
                {
                    while (true)
                    {
                        if (Now  >= Move_Input.Count)
                        {
                            MessageBox.Show("「反復魔法」と「反復魔法おわり」はセットで使ってください");
                            return (Return_List, 0);
                        }
                        (Return_List, Now) = ForLoop(Move_Input,Move_A,Move_B Now );
                        if (Move_Input[Now] == "endfor") break;
                        else
                        {
                            if(int.Parse(Move_Input[Now]) < 4) Func.Move(Return_List, Move_Input[Now]);
                            else if (Move_Input[Now] == "A") Return_List.AddRange(Move_A);
                            else Return_List.AddRange(Move_B);
                            Now++;
                        }
                    }
                }
            }
            return (Return_List,Return_Num);
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
}
