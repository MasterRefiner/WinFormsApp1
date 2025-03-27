namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                Rectangle workingArea = Screen.FromHandle(this.Handle).WorkingArea; // Obtém a área útil da tela sem a barra de tarefas
                this.MaximizedBounds = workingArea;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            Form loginForm = Application.OpenForms["LoginForm"]; // Verifica se já existe uma instância aberta

            if (loginForm != null)
            {
                loginForm.BringToFront(); // Traz a janela para frente
                return; // Sai da função para evitar abrir outra instância
            }

            LoginForm f2 = new LoginForm();
            f2.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTab f3 = new NewTab();
            f3.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos Mapa Virtual|*.refmap|Arquivos PEF|*.pef|Arquivos PFD|*.pfd|Arquivos PID|*.pid|Arquivos de Texto|*.txt|Todos os Arquivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show($"Arquivo selecionado: {filePath}", "Arquivo Aberto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

