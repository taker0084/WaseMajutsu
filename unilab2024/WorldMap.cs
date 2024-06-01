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
            Func.CreateStageSelect(this, button1.Text,1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Func.CreateStageSelect(this, button2.Text,2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Func.CreateStageSelect(this, button3.Text,3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Func.CreateStageSelect(this, button4.Text,4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Func.CreateStageSelect(this, button5.Text,5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Func.CreateStageSelect(this, button6.Text,6);
        }
        #endregion
    }
}
