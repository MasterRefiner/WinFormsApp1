namespace WinFormsApp1
{
    partial class NewTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTab));
            btnExNew = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnNPID = new Button();
            btnNPFD = new Button();
            btnNPEF = new Button();
            btnNMAP = new Button();
            button5 = new Button();
            btnCnc = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExNew
            // 
            btnExNew.BackgroundImage = (Image)resources.GetObject("btnExNew.BackgroundImage");
            btnExNew.BackgroundImageLayout = ImageLayout.Center;
            btnExNew.Dock = DockStyle.Right;
            btnExNew.FlatStyle = FlatStyle.Flat;
            btnExNew.Location = new Point(627, 0);
            btnExNew.Margin = new Padding(0);
            btnExNew.Name = "btnExNew";
            btnExNew.Size = new Size(32, 29);
            btnExNew.TabIndex = 0;
            btnExNew.UseVisualStyleBackColor = true;
            btnExNew.Click += btnExNew_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnExNew);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 29);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 7);
            label1.Name = "label1";
            label1.Size = new Size(196, 15);
            label1.TabIndex = 6;
            label1.Text = "Novo Documento MASTER REFINER";
            // 
            // btnNPID
            // 
            btnNPID.BackgroundImage = (Image)resources.GetObject("btnNPID.BackgroundImage");
            btnNPID.BackgroundImageLayout = ImageLayout.Zoom;
            btnNPID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNPID.ImageAlign = ContentAlignment.TopLeft;
            btnNPID.Location = new Point(66, 62);
            btnNPID.Name = "btnNPID";
            btnNPID.Size = new Size(106, 187);
            btnNPID.TabIndex = 2;
            btnNPID.Text = "Novo P&ID";
            btnNPID.TextAlign = ContentAlignment.BottomCenter;
            btnNPID.UseVisualStyleBackColor = true;
            btnNPID.Click += btnNPID_Click;
            // 
            // btnNPFD
            // 
            btnNPFD.BackgroundImage = (Image)resources.GetObject("btnNPFD.BackgroundImage");
            btnNPFD.BackgroundImageLayout = ImageLayout.Zoom;
            btnNPFD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNPFD.Location = new Point(204, 62);
            btnNPFD.Name = "btnNPFD";
            btnNPFD.Size = new Size(106, 187);
            btnNPFD.TabIndex = 3;
            btnNPFD.Text = "Novo PFD";
            btnNPFD.TextAlign = ContentAlignment.BottomCenter;
            btnNPFD.UseVisualStyleBackColor = true;
            btnNPFD.Click += btnNPFD_Click;
            // 
            // btnNPEF
            // 
            btnNPEF.BackgroundImage = (Image)resources.GetObject("btnNPEF.BackgroundImage");
            btnNPEF.BackgroundImageLayout = ImageLayout.Zoom;
            btnNPEF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNPEF.Location = new Point(347, 62);
            btnNPEF.Name = "btnNPEF";
            btnNPEF.Size = new Size(106, 187);
            btnNPEF.TabIndex = 4;
            btnNPEF.Text = "Novo PEFS";
            btnNPEF.TextAlign = ContentAlignment.BottomCenter;
            btnNPEF.UseVisualStyleBackColor = true;
            btnNPEF.Click += btnNPEF_Click;
            // 
            // btnNMAP
            // 
            btnNMAP.BackgroundImage = (Image)resources.GetObject("btnNMAP.BackgroundImage");
            btnNMAP.BackgroundImageLayout = ImageLayout.Zoom;
            btnNMAP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNMAP.Location = new Point(483, 62);
            btnNMAP.Name = "btnNMAP";
            btnNMAP.Size = new Size(106, 187);
            btnNMAP.TabIndex = 5;
            btnNMAP.Text = "Novo Mapa";
            btnNMAP.TextAlign = ContentAlignment.BottomCenter;
            btnNMAP.UseVisualStyleBackColor = true;
            btnNMAP.Click += btnNMAP_Click;
            // 
            // button5
            // 
            button5.Location = new Point(66, 305);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "Avançado";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnCnc
            // 
            btnCnc.Location = new Point(433, 305);
            btnCnc.Name = "btnCnc";
            btnCnc.Size = new Size(75, 23);
            btnCnc.TabIndex = 7;
            btnCnc.Text = "Cancelar";
            btnCnc.UseVisualStyleBackColor = true;
            btnCnc.Click += btnCnc_Click;
            // 
            // button7
            // 
            button7.Location = new Point(514, 305);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 8;
            button7.Text = "Ajuda";
            button7.UseVisualStyleBackColor = true;
            // 
            // NewTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 370);
            Controls.Add(button7);
            Controls.Add(btnCnc);
            Controls.Add(button5);
            Controls.Add(btnNMAP);
            Controls.Add(btnNPEF);
            Controls.Add(btnNPFD);
            Controls.Add(btnNPID);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewTab";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExNew;
        private Panel panel1;
        private Button btnNPID;
        private Button btnNPFD;
        private Button btnNPEF;
        private Button btnNMAP;
        private Label label1;
        private Button button5;
        private Button btnCnc;
        private Button button7;
    }
}