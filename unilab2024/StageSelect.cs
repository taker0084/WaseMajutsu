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
        #region キー入力の設定等
        public StageSelect()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(WorldMap_KeyDown);
            this.KeyPreview = true;
        }
        #endregion

        #region 各種メンバ変数の定義
        private string _worldName;  //WorldMapで選択された学年
        private int _worldNumber;

        public string WorldName     //こう書くと別フォームからアクセスできるっぽい。原理はよくわからん
        {
            get { return _worldName; }
            set { _worldName = value; }
            //別フォームからのアクセス例
            //StageSelect form = new StageSelect();
            //form.WorldName = "学年";
        }
        public int WorldNumber
        {
            get { return _worldNumber; }
            set { _worldNumber = value; }
        }
        #endregion

        #region 読み込み時
        private void StageSelect_Load(object sender, EventArgs e)
        {
            pictureBox_Background.BackgroundImage = Dictionaries.Img_Background["StageSelect" + _worldNumber];
            labelWorld.Text = _worldName;   //学年表示の書き換え
            // buttonに対する処理
            foreach (Control control in this.Controls)
            {
                if (control is CustomButton button)
                {
                    string NameWithoutButton = button.Name.Replace("button_Stage", "");
                    if (int.TryParse(NameWithoutButton, out int j))
                    {
                        if (_worldNumber == 4)
                        {
                            switch (j)
                            {
                                case 1:
                                    button.Location = new Point(643, 600);
                                    button.Text = "卒業試験";
                                    break;
                                case 2:
                                case 3:
                                    button.Enabled = false;
                                    button.Visible = false;
                                    break;
                            }
                        }
                        if (ClearCheck.IsButtonEnabled[_worldNumber, j])
                        {
                            button.ForeImage = null;
                            button.Cursor = Cursors.Hand;
                            if (ClearCheck.IsNew[_worldNumber, j])
                            {
                                button.ConditionImage = Dictionaries.Img_Button["New"];
                            }
                            else if (ClearCheck.IsCleared[_worldNumber, j])
                            {
                                button.ConditionImage = Dictionaries.Img_Button["Clear"];
                            }
                            else
                            {
                                button.ConditionImage = null;
                            }
                        }
                        else
                        {
                            button.ForeImage = Dictionaries.Img_Button["Lock"];
                            button.Cursor = Cursors.No;
                        }
                    }
                    else
                    {
                        bool isWorldMap = true;
                        if (_worldNumber >= 5) isWorldMap = false;
                        if (Func.HasNewStageFromStageSelect(isWorldMap, _worldNumber))
                        {
                            button.ConditionImage = Dictionaries.Img_Button["New"];
                        }
                    }
                }
            }
        }
        #endregion

        #region 各種ボタン押下後の処理
        private void button_StageI_Click(object sender, EventArgs e)
        {
            CustomButton button = sender as CustomButton;
            if (button != null)
            {
                string NameWithoutButton = button.Name.Replace("button_Stage", "");
                if (int.TryParse(NameWithoutButton, out int j))
                {
                    if (!ClearCheck.IsButtonEnabled[_worldNumber, j]) return;
                    ClearCheck.IsNew[_worldNumber, j] = false;
                    Func.UpdateIsNew();
                    Func.CreateStage(this, _worldName, _worldNumber, j);
                }
            }
        }
        private void buttonToMap_Click(object sender, EventArgs e)
        {
            if (_worldNumber <= 4) Func.CreateWorldMap(this);
            else Func.CreateAnotherWorld(this);
        }
        #endregion

        #region クリアチェックスキップ用
        private void WorldMap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                
                for (int j = 0; j < (int)ConstNum.numStages; j++)
                {
                    ClearCheck.IsNew[_worldNumber, j] = false;
                    ClearCheck.IsCleared[_worldNumber, j] = true;
                    ClearCheck.IsButtonEnabled[_worldNumber, j] = true;
                }
                if (_worldNumber < 4)
                {
                    for (int j = 0; j <= 1; j++)
                    {
                        ClearCheck.IsButtonEnabled[_worldNumber + 1, j] = true;
                        ClearCheck.IsNew[_worldNumber + 1, j] = true;
                    }
                }
                else if( _worldNumber == 4)
                {
                    ClearCheck.IsCleared[4,0] = true;
                    for (int i = 5; i < (int)ConstNum.numWorlds; i++)
                    {
                        for(int j = 0; j <= 1; j++)
                        {
                            ClearCheck.IsButtonEnabled[i, j] = true;
                            ClearCheck.IsNew[i, j] = true;
                        }
                    }
                }

                Func.CreateStageSelect(this,_worldName, _worldNumber);
            }
        }
        #endregion
    }
}
