using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControlCadastos1.Visible = false;
            userControlCadastroAnimais1.Visible = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 50)
            {
                panel1.Visible = false;
                panel1.Width = 255;
                bunifuTransition1.ShowSync(panel1);
                bunifuTransition2.ShowSync(pictureBox1);
            }
            else
            {
                pictureBox1.Visible = false;
                bunifuTransition2.Hide(pictureBox1);
                panel1.Visible = false;
                panel1.Width = 50;
                bunifuTransition1.ShowSync(panel1);
               // bunifuTransition2.ShowSync(pictureBox1);
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            userControlCadastos1.Visible = false;
            userControlCadastroAnimais1.Visible = false;
            bunifuTransition3.ShowSync(userControlDashboard1);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Visible = false;
            userControlCadastos1.Visible = false;
            bunifuTransition3.ShowSync(userControlCadastroAnimais1);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Visible = false;
            userControlCadastroAnimais1.Visible = false;
            bunifuTransition3.ShowSync(userControlCadastos1);
        }
    }
}
