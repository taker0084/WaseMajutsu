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
        #region ローカル変数宣言
        //ここに必要なBitmapやImageを作っていく
        #endregion

        private void Stage_Load(object sender, EventArgs e)
        {

        }
    }
}
