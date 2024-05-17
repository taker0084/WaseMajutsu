using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            Application.Run(new Stage());
        }
    }

    public static partial class Func
    {
        #region フォーム呼び出し
        public static void CreateWorldMap(Form currentForm) //呼び出し方: Func.CreateWorldMap(this);
        {
            WorldMap form = new WorldMap();
            form.Show();

            //Prologue画面消すとアプリケーションが終了してしまう
            if (currentForm.GetType() != typeof(Prologue))
            {
                currentForm.Dispose();
            }
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
        public static void ResetListBox(ListBox listbox_Input,ListBox listbox)   //ListBoxの中身消去
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
    }
}
