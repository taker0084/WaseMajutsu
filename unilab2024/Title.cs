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
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Func.CreatePrologue();
            //Func.CreateAnotherWorld(this);
        }
    }
}
