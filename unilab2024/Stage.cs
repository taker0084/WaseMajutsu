using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unilab2024
{
    public partial class Stage : Form
    {
        public Stage()
        {
            InitializeComponent();
        }
        private string _stageName;
        public string StageName     //StageSelectからの呼び出し用
        {
            get { return _stageName; }
            set { _stageName = value; }
            //別フォームからのアクセス例
            //Stage form = new StageSelect();
            //form.StageName = "ステージ名";
        }
    }
}
