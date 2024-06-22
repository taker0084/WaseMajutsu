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
    public partial class AnotherWorld : Form
    {
        public AnotherWorld()
        {
            InitializeComponent();
        }

        private void AnotherWorld_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile("Img_Background_AnotherWorld.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
