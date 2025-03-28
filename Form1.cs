<<<<<<< HEAD
=======
using System.Diagnostics;

>>>>>>> Update 28.03.2025Adicionar arquivos de projeto.
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
<<<<<<< HEAD
            openFileDialog.Filter = "Arquivos Mapa Virtual|*.refmap|Arquivos PEF|*.pef|Arquivos PFD|*.pfd|Arquivos PID|*.pid|Arquivos de Texto|*.txt|Todos os Arquivos|*.*";
=======
            openFileDialog.Filter = "Projetos Unreal|*.uproject|Arquivos PEF|*.pef|Arquivos PFD|*.pfd|Arquivos PID|*.pid|Executáveis|*.exe|Arquivos de Texto|*.txt|Todos os Arquivos|*.*";
>>>>>>> Update 28.03.2025Adicionar arquivos de projeto.

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
<<<<<<< HEAD
                MessageBox.Show($"Arquivo selecionado: {filePath}", "Arquivo Aberto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
=======
                string extension = Path.GetExtension(filePath).ToLower();

                try
                {
                    if (extension == ".uproject")
                    {
                        // Caminho do Unreal Engine (ajuste para a versão instalada)
                        string unrealEditorPath = @"C:\Program Files\Epic Games\UE_5.5\Engine\Binaries\Win64\UnrealEditor.exe";

                        if (File.Exists(unrealEditorPath))
                        {
                            Process.Start(unrealEditorPath, $"\"{filePath}\"");
                        }
                        else
                        {
                            MessageBox.Show("Unreal Engine não encontrado. Verifique o caminho do editor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (extension == ".exe")
                    {
                        // Executar arquivos .exe normalmente
                        Process.Start(filePath);
                    }
                    else
                    {
                        // Apenas exibir o caminho do arquivo
                        MessageBox.Show($"Arquivo selecionado: {filePath}", "Arquivo Aberto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao abrir o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracoesForm configForm = new ConfiguracoesForm(); // Supondo que você tenha um formulário chamado ConfiguracoesForm
            configForm.ShowDialog(); // Abre o formulário como modal
        }
>>>>>>> Update 28.03.2025Adicionar arquivos de projeto.
    }
}

