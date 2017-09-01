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
    public partial class GuiCadastroAnimais : Form
    {
        public GuiCadastroAnimais()
        {
            InitializeComponent();
            userControlDetalhe1.Visible = false;
            userControlSanidade1.Visible = false;
            userControlPesagem1.Visible = false;
            userControlReproducao1.Visible = false;
            userControlFoto1.Visible = false;
            userControlPremios1.Visible = false;
        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = lblTab1.Width;
            bunifuSeparator1.Left = lblTab1.Left;
            userControlDetalhe1.Visible = false;
            userControlSanidade1.Visible = false;
            userControlPesagem1.Visible = false;
            userControlReproducao1.Visible = false;
            userControlFoto1.Visible = false;
            userControlPremios1.Visible = false;
            bunifuTransition1.ShowSync(userControlAnimais1);

        }

        private void lblTab2_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = lblTab2.Width;
            bunifuSeparator1.Left = lblTab2.Left;
            userControlAnimais1.Visible = false;
            userControlSanidade1.Visible = false;
            userControlPesagem1.Visible = false;
            userControlReproducao1.Visible = false;
            userControlFoto1.Visible = false;
            userControlPremios1.Visible = false;
            bunifuTransition1.ShowSync(userControlDetalhe1);
        }

        private void lblTab3_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = lblTab3.Width;
            bunifuSeparator1.Left = lblTab3.Left;
            userControlAnimais1.Visible = false;
            userControlDetalhe1.Visible = false;
            userControlSanidade1.Visible = false;
            userControlPesagem1.Visible = false;
            userControlReproducao1.Visible = false;
            userControlFoto1.Visible = false;
            userControlPremios1.Visible = false;
            bunifuTransition1.ShowSync(userControlSanidade1);
        }

        private void lblTab4_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = lblTab4.Width;
            bunifuSeparator1.Left = lblTab4.Left;
            userControlAnimais1.Visible = false;
            userControlDetalhe1.Visible = false;
            userControlSanidade1.Visible = false;
            userControlReproducao1.Visible = false;
            userControlFoto1.Visible = false;
            userControlPremios1.Visible = false;
            bunifuTransition1.ShowSync(userControlPesagem1);
        }

        private void lblTab5_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = lblTab5.Width;
            bunifuSeparator1.Left = lblTab5.Left;
            userControlAnimais1.Visible = false;
            userControlDetalhe1.Visible = false;
            userControlSanidade1.Visible = false;
            userControlPesagem1.Visible = false;
            userControlFoto1.Visible = false;
            userControlPremios1.Visible = false;
            bunifuTransition1.ShowSync(userControlReproducao1);
        }

        private void lblTab6_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = lblTab6.Width;
            bunifuSeparator1.Left = lblTab6.Left;
            userControlAnimais1.Visible = false;
            userControlDetalhe1.Visible = false;
            userControlSanidade1.Visible = false;
            userControlPesagem1.Visible = false;
            userControlReproducao1.Visible = false;
            userControlPremios1.Visible = false;
            bunifuTransition1.ShowSync(userControlFoto1);
        }

        private void lbltab7_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = lbltab7.Width;
            bunifuSeparator1.Left = lbltab7.Left;
            userControlAnimais1.Visible = false;
            userControlDetalhe1.Visible = false;
            userControlSanidade1.Visible = false;
            userControlPesagem1.Visible = false;
            userControlReproducao1.Visible = false;
            userControlFoto1.Visible = false;
            bunifuTransition1.ShowSync(userControlPremios1);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
