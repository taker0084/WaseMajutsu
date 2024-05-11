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
    public partial class WorldMap : Form
    {
        public WorldMap()
        {
            InitializeComponent();
        }

        #region StageSelectフォームの呼び出し
        private void button1_Click(object sender, EventArgs e)
        {
            Func.CreateStageSelect(this, "1年生");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Func.CreateStageSelect(this, "2年生");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Func.CreateStageSelect(this, "3年生");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Func.CreateStageSelect(this, "4年生");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Func.CreateStageSelect(this, "5年生");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Func.CreateStageSelect(this, "6年生");
        }
        #endregion
    }
}
