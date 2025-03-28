using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class NewTab : Form
    {
        public NewTab()
        {
            InitializeComponent();
        }

        private void btnExNew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCnc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNPID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade para criar novos diagramas de tubulações e intrumentos, será implementada em breve.", "Em desenvolvimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNPFD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade para criar novos diagramas de fluxo de processos de refino, a ser implementada no futuro.", "Em desenvolvimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNPEF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade para criar novos diagramas de processos esquematico de engenharia, será implementada em breve.", "Em desenvolvimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNMAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade para criar novo mapa virtual de simulação, ainda em desenvolvimento.", "Em desenvolvimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
