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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void tb_mail_TextChanged(object sender, EventArgs e)
        {
            ValidateLoginFields();
        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            ValidateLoginFields();
        }

        private void ValidateLoginFields()
        {
            btnLOG.Enabled = !string.IsNullOrWhiteSpace(tb_mail.Text) && !string.IsNullOrWhiteSpace(tb_pass.Text);
        }


        private void btnLOG_Click(object sender, EventArgs e)
        {
            string email = tb_mail.Text;
            string password = tb_pass.Text;

            if (email == "admin" && password == "1234") // Substitua isso por um sistema de autenticação real
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Fecha a tela de login
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
