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
    public partial class ConfiguracoesForm : Form
    {

        private bool arrastando = false;
        private Point pontoInicial;
        public ConfiguracoesForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnIdiom_Click(object sender, EventArgs e)
        {
            panelMES.Visible = false;
            panelIdiom.Visible = true;
            panelTheme.Visible = false;
            panelNotif.Visible = false;
            panelUpdate.Visible = false;
            panelAUT.Visible = false;
            panelBCKUP.Visible = false;
            panelEXT.Visible = false;
            panelSTRG.Visible = false;
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            panelAUT.Visible = false;
            panelBCKUP.Visible = false;
            panelEXT.Visible = false;
            panelSTRG.Visible = false;
            panelUpdate.Visible = false;
            panelNotif.Visible = false;
            panelIdiom.Visible = false;
            panelTheme.Visible = true;
            panelMES.Visible = false;
        }

        private void btnNotf_Click(object sender, EventArgs e)
        {
            panelAUT.Visible = false;
            panelMES.Visible = false;
            panelBCKUP.Visible = false;
            panelEXT.Visible = false;
            panelSTRG.Visible = false;
            panelNotif.Visible = true;
            panelIdiom.Visible = false;
            panelTheme.Visible = false;
            panelUpdate.Visible = false;
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            panelAUT.Visible = false;
            panelBCKUP.Visible = false;
            panelEXT.Visible = false;
            panelSTRG.Visible = false;
            panelNotif.Visible = false;
            panelIdiom.Visible = false;
            panelTheme.Visible = false;
            panelUpdate.Visible = true;
            panelMES.Visible = false;
        }

        private void btnBckup_Click(object sender, EventArgs e)
        {
            panelAUT.Visible = false;
            panelBCKUP.Visible = true;
            panelEXT.Visible = false;
            panelSTRG.Visible = false;
            panelNotif.Visible = false;
            panelIdiom.Visible = false;
            panelTheme.Visible = false;
            panelUpdate.Visible = false;
            panelMES.Visible = false;
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            panelAUT.Visible = false;
            panelBCKUP.Visible = false;
            panelEXT.Visible = true;
            panelSTRG.Visible = false;
            panelNotif.Visible = false;
            panelIdiom.Visible = false;
            panelTheme.Visible = false;
            panelUpdate.Visible = false;
            panelMES.Visible = false;
        }

        private void btnStrg_Click(object sender, EventArgs e)
        {
            panelAUT.Visible = false;
            panelBCKUP.Visible = false;
            panelEXT.Visible = false;
            panelSTRG.Visible = true;
            panelNotif.Visible = false;
            panelIdiom.Visible = false;
            panelTheme.Visible = false;
            panelUpdate.Visible = false;
            panelMES.Visible = false;
        }

        private void btnAut_Click(object sender, EventArgs e)
        {
            panelAUT.Visible = true;
            panelBCKUP.Visible = false;
            panelEXT.Visible = false;
            panelSTRG.Visible = false;
            panelNotif.Visible = false;
            panelIdiom.Visible = false;
            panelTheme.Visible = false;
            panelUpdate.Visible = false;
            panelMES.Visible = false;
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            panelMES.Visible = true;
            panelBCKUP.Visible = false;
            panelEXT.Visible = false;
            panelNotif.Visible = false;
            panelIdiom.Visible = false;
            panelTheme.Visible = false;
            panelUpdate.Visible = false;
            panelAUT.Visible = false;
            panelSTRG.Visible = false;
        }

        private void btnLib_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            arrastando = true;
            pontoInicial = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastando)
            {
                Point novoPonto = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(novoPonto.X - pontoInicial.X, novoPonto.Y - pontoInicial.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            arrastando = false;
        }
    }
}
