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
    public partial class StageSelect : Form
    {
        public StageSelect()
        {
            InitializeComponent();
        }

        #region 各種メンバ変数の定義
        private string _worldName;  //WorldMapで選択された学年

        public string WorldName     //こう書くと別フォームからアクセスできるっぽい。原理はよくわからん
        {
            get { return _worldName; }
            set { _worldName = value; }
            //別フォームからのアクセス例
            //StageSelect form = new StageSelect();
            //form.WorldName = "学年";
        }
        #endregion

        private void StageSelect_Load(object sender, EventArgs e)
        {
            labelWorld.Text = _worldName;   //学年表示の書き換え
        }

        #region 各種ボタン押下後の処理
        private void buttonToMap_Click(object sender, EventArgs e)
        {
            Func.CreateWorldMap(this);
        }
        #endregion
    }
}
