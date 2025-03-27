namespace WinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            tb_pass = new TextBox();
            tb_mail = new TextBox();
            btnLOG = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Location = new Point(104, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 37);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 10);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 2;
            label2.Text = "E-MAIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 55);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(152, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 37);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(51, 116);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(123, 100);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(tb_pass);
            panel3.Controls.Add(tb_mail);
            panel3.Location = new Point(174, 116);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 6;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(3, 57);
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.Size = new Size(194, 23);
            tb_pass.TabIndex = 1;
            tb_pass.TextChanged += tb_pass_TextChanged;
            // 
            // tb_mail
            // 
            tb_mail.Location = new Point(3, 12);
            tb_mail.Name = "tb_mail";
            tb_mail.Size = new Size(194, 23);
            tb_mail.TabIndex = 0;
            tb_mail.TextChanged += tb_mail_TextChanged;
            // 
            // btnLOG
            // 
            btnLOG.BackColor = SystemColors.ActiveCaption;
            btnLOG.FlatAppearance.BorderSize = 0;
            btnLOG.FlatStyle = FlatStyle.Flat;
            btnLOG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLOG.Location = new Point(98, 242);
            btnLOG.Name = "btnLOG";
            btnLOG.Size = new Size(104, 23);
            btnLOG.TabIndex = 7;
            btnLOG.Text = "SUBMETER";
            btnLOG.UseVisualStyleBackColor = false;
            btnLOG.Click += btnLOG_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(244, 242);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 8;
            button2.Text = "INSCREVER-SE";
            button2.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 292);
            Controls.Add(button2);
            Controls.Add(btnLOG);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conta de Usuário";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox tb_pass;
        private TextBox tb_mail;
        private Button btnLOG;
        private Button button2;
    }
}