namespace PrototipoMessier
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            lblLogo = new Label();
            lblLogoSub = new Label();
            pnlNavSep = new Panel();
            btnNavJogos = new Button();
            btnNavPacotes = new Button();
            btnNavHelp = new Button();
            btnNavSair = new Button();
            pnlMain = new Panel();
            lblDashTitle = new Label();
            lblDashSub = new Label();
            pnlCard1 = new Panel();
            lblCard1Title = new Label();
            lblCard1Desc = new Label();
            pnlCard2 = new Panel();
            lblCard2Title = new Label();
            lblCard2Desc = new Label();
            pnlCard3 = new Panel();
            lblCard3Title = new Label();
            lblCard3Desc = new Label();
            btnRel = new Button();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(10, 12, 20);
            pnlSidebar.Controls.Add(btnRel);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Controls.Add(lblLogoSub);
            pnlSidebar.Controls.Add(pnlNavSep);
            pnlSidebar.Controls.Add(btnNavJogos);
            pnlSidebar.Controls.Add(btnNavPacotes);
            pnlSidebar.Controls.Add(btnNavHelp);
            pnlSidebar.Controls.Add(btnNavSair);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 2, 3, 2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(210, 480);
            pnlSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(21, 13);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(102, 32);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Messier";
            lblLogo.Click += lblLogo_Click;
            // 
            // lblLogoSub
            // 
            lblLogoSub.AutoSize = true;
            lblLogoSub.Font = new Font("Segoe UI", 9F);
            lblLogoSub.ForeColor = Color.FromArgb(150, 160, 180);
            lblLogoSub.Location = new Point(21, 45);
            lblLogoSub.Name = "lblLogoSub";
            lblLogoSub.Size = new Size(80, 15);
            lblLogoSub.TabIndex = 1;
            lblLogoSub.Text = "Data & Creative";
            // 
            // pnlNavSep
            // 
            pnlNavSep.BackColor = Color.FromArgb(36, 40, 60);
            pnlNavSep.Location = new Point(21, 75);
            pnlNavSep.Margin = new Padding(3, 2, 3, 2);
            pnlNavSep.Name = "pnlNavSep";
            pnlNavSep.Size = new Size(168, 1);
            pnlNavSep.TabIndex = 2;
            // 
            // btnNavJogos
            // 
            btnNavJogos.BackColor = Color.Transparent;
            btnNavJogos.Cursor = Cursors.Hand;
            btnNavJogos.FlatAppearance.BorderSize = 0;
            btnNavJogos.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 35, 54);
            btnNavJogos.FlatStyle = FlatStyle.Flat;
            btnNavJogos.Font = new Font("Segoe UI", 11F);
            btnNavJogos.ForeColor = Color.FromArgb(220, 230, 240);
            btnNavJogos.Location = new Point(10, 90);
            btnNavJogos.Margin = new Padding(3, 2, 3, 2);
            btnNavJogos.Name = "btnNavJogos";
            btnNavJogos.Padding = new Padding(14, 0, 0, 0);
            btnNavJogos.Size = new Size(189, 36);
            btnNavJogos.TabIndex = 0;
            btnNavJogos.Text = "Jogos";
            btnNavJogos.TextAlign = ContentAlignment.MiddleLeft;
            btnNavJogos.UseVisualStyleBackColor = false;
            btnNavJogos.Click += jogosToolStripMenuItem_Click;
            // 
            // btnNavPacotes
            // 
            btnNavPacotes.BackColor = Color.Transparent;
            btnNavPacotes.Cursor = Cursors.Hand;
            btnNavPacotes.FlatAppearance.BorderSize = 0;
            btnNavPacotes.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 35, 54);
            btnNavPacotes.FlatStyle = FlatStyle.Flat;
            btnNavPacotes.Font = new Font("Segoe UI", 11F);
            btnNavPacotes.ForeColor = Color.FromArgb(220, 230, 240);
            btnNavPacotes.Location = new Point(10, 129);
            btnNavPacotes.Margin = new Padding(3, 2, 3, 2);
            btnNavPacotes.Name = "btnNavPacotes";
            btnNavPacotes.Padding = new Padding(14, 0, 0, 0);
            btnNavPacotes.Size = new Size(189, 36);
            btnNavPacotes.TabIndex = 1;
            btnNavPacotes.Text = "Pacotes";
            btnNavPacotes.TextAlign = ContentAlignment.MiddleLeft;
            btnNavPacotes.UseVisualStyleBackColor = false;
            btnNavPacotes.Click += pacotesToolStripMenuItem_Click;
            // 
            // btnNavHelp
            // 
            btnNavHelp.BackColor = Color.Transparent;
            btnNavHelp.Cursor = Cursors.Hand;
            btnNavHelp.FlatAppearance.BorderSize = 0;
            btnNavHelp.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 35, 54);
            btnNavHelp.FlatStyle = FlatStyle.Flat;
            btnNavHelp.Font = new Font("Segoe UI", 11F);
            btnNavHelp.ForeColor = Color.FromArgb(220, 230, 240);
            btnNavHelp.Location = new Point(10, 168);
            btnNavHelp.Margin = new Padding(3, 2, 3, 2);
            btnNavHelp.Name = "btnNavHelp";
            btnNavHelp.Padding = new Padding(14, 0, 0, 0);
            btnNavHelp.Size = new Size(189, 36);
            btnNavHelp.TabIndex = 2;
            btnNavHelp.Text = "Ajuda";
            btnNavHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnNavHelp.UseVisualStyleBackColor = false;
            btnNavHelp.Click += helpToolStripMenuItem_Click;
            // 
            // btnNavSair
            // 
            btnNavSair.BackColor = Color.Transparent;
            btnNavSair.Cursor = Cursors.Hand;
            btnNavSair.FlatAppearance.BorderSize = 0;
            btnNavSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 25, 25);
            btnNavSair.FlatStyle = FlatStyle.Flat;
            btnNavSair.Font = new Font("Segoe UI", 10F);
            btnNavSair.ForeColor = Color.FromArgb(200, 80, 80);
            btnNavSair.Location = new Point(10, 440);
            btnNavSair.Margin = new Padding(3, 2, 3, 2);
            btnNavSair.Name = "btnNavSair";
            btnNavSair.Padding = new Padding(14, 0, 0, 0);
            btnNavSair.Size = new Size(189, 33);
            btnNavSair.TabIndex = 3;
            btnNavSair.Text = "Sair";
            btnNavSair.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSair.UseVisualStyleBackColor = false;
            btnNavSair.Click += sairToolStripMenuItem_Click;
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.BackColor = Color.FromArgb(5, 6, 10);
            pnlMain.Controls.Add(lblDashTitle);
            pnlMain.Controls.Add(lblDashSub);
            pnlMain.Controls.Add(pnlCard1);
            pnlMain.Controls.Add(pnlCard2);
            pnlMain.Controls.Add(pnlCard3);
            pnlMain.Location = new Point(210, 0);
            pnlMain.Margin = new Padding(3, 2, 3, 2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(752, 480);
            pnlMain.TabIndex = 1;
            // 
            // lblDashTitle
            // 
            lblDashTitle.AutoSize = true;
            lblDashTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblDashTitle.ForeColor = Color.White;
            lblDashTitle.Location = new Point(42, 27);
            lblDashTitle.Name = "lblDashTitle";
            lblDashTitle.Size = new Size(219, 41);
            lblDashTitle.TabIndex = 0;
            lblDashTitle.Text = "Painel Messier";
            // 
            // lblDashSub
            // 
            lblDashSub.AutoSize = true;
            lblDashSub.Font = new Font("Segoe UI", 11F);
            lblDashSub.ForeColor = Color.FromArgb(150, 160, 180);
            lblDashSub.Location = new Point(42, 68);
            lblDashSub.Name = "lblDashSub";
            lblDashSub.Size = new Size(363, 20);
            lblDashSub.TabIndex = 1;
            lblDashSub.Text = "Sistema de jogos educacionais, pacotes e assinaturas.";
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.FromArgb(16, 18, 30);
            pnlCard1.Controls.Add(lblCard1Title);
            pnlCard1.Controls.Add(lblCard1Desc);
            pnlCard1.Cursor = Cursors.Hand;
            pnlCard1.Location = new Point(42, 135);
            pnlCard1.Margin = new Padding(3, 2, 3, 2);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(201, 105);
            pnlCard1.TabIndex = 2;
            pnlCard1.Click += jogosToolStripMenuItem_Click;
            // 
            // lblCard1Title
            // 
            lblCard1Title.AutoSize = true;
            lblCard1Title.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCard1Title.ForeColor = Color.White;
            lblCard1Title.Location = new Point(18, 22);
            lblCard1Title.Name = "lblCard1Title";
            lblCard1Title.Size = new Size(64, 25);
            lblCard1Title.TabIndex = 0;
            lblCard1Title.Text = "Jogos";
            // 
            // lblCard1Desc
            // 
            lblCard1Desc.Font = new Font("Segoe UI", 9F);
            lblCard1Desc.ForeColor = Color.FromArgb(150, 160, 180);
            lblCard1Desc.Location = new Point(18, 51);
            lblCard1Desc.Name = "lblCard1Desc";
            lblCard1Desc.Size = new Size(166, 38);
            lblCard1Desc.TabIndex = 1;
            lblCard1Desc.Text = "Cadastre e gerencie os jogos disponiveis";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.FromArgb(16, 18, 30);
            pnlCard2.Controls.Add(lblCard2Title);
            pnlCard2.Controls.Add(lblCard2Desc);
            pnlCard2.Cursor = Cursors.Hand;
            pnlCard2.Location = new Point(262, 135);
            pnlCard2.Margin = new Padding(3, 2, 3, 2);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(201, 105);
            pnlCard2.TabIndex = 3;
            pnlCard2.Click += pacotesToolStripMenuItem_Click;
            // 
            // lblCard2Title
            // 
            lblCard2Title.AutoSize = true;
            lblCard2Title.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCard2Title.ForeColor = Color.White;
            lblCard2Title.Location = new Point(18, 22);
            lblCard2Title.Name = "lblCard2Title";
            lblCard2Title.Size = new Size(80, 25);
            lblCard2Title.TabIndex = 0;
            lblCard2Title.Text = "Pacotes";
            // 
            // lblCard2Desc
            // 
            lblCard2Desc.Font = new Font("Segoe UI", 9F);
            lblCard2Desc.ForeColor = Color.FromArgb(150, 160, 180);
            lblCard2Desc.Location = new Point(18, 51);
            lblCard2Desc.Name = "lblCard2Desc";
            lblCard2Desc.Size = new Size(166, 38);
            lblCard2Desc.TabIndex = 1;
            lblCard2Desc.Text = "Monte pacotes de jogos para assinatura";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = Color.FromArgb(16, 18, 30);
            pnlCard3.Controls.Add(lblCard3Title);
            pnlCard3.Controls.Add(lblCard3Desc);
            pnlCard3.Cursor = Cursors.Hand;
            pnlCard3.Location = new Point(483, 135);
            pnlCard3.Margin = new Padding(3, 2, 3, 2);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(201, 105);
            pnlCard3.TabIndex = 4;
            pnlCard3.Click += helpToolStripMenuItem_Click;
            // 
            // lblCard3Title
            // 
            lblCard3Title.AutoSize = true;
            lblCard3Title.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCard3Title.ForeColor = Color.White;
            lblCard3Title.Location = new Point(18, 22);
            lblCard3Title.Name = "lblCard3Title";
            lblCard3Title.Size = new Size(64, 25);
            lblCard3Title.TabIndex = 0;
            lblCard3Title.Text = "Ajuda";
            // 
            // lblCard3Desc
            // 
            lblCard3Desc.Font = new Font("Segoe UI", 9F);
            lblCard3Desc.ForeColor = Color.FromArgb(150, 160, 180);
            lblCard3Desc.Location = new Point(18, 51);
            lblCard3Desc.Name = "lblCard3Desc";
            lblCard3Desc.Size = new Size(166, 38);
            lblCard3Desc.TabIndex = 1;
            lblCard3Desc.Text = "Acesse a central de ajuda do sistema";
            // 
            // btnRel
            // 
            btnRel.BackColor = Color.Transparent;
            btnRel.Cursor = Cursors.Hand;
            btnRel.FlatAppearance.BorderSize = 0;
            btnRel.FlatStyle = FlatStyle.Flat;
            btnRel.Font = new Font("Segoe UI", 11F);
            btnRel.ForeColor = Color.FromArgb(220, 230, 240);
            btnRel.Location = new Point(21, 209);
            btnRel.Name = "btnRel";
            btnRel.Size = new Size(168, 31);
            btnRel.TabIndex = 4;
            btnRel.Text = "Relatorios";
            btnRel.TextAlign = ContentAlignment.MiddleLeft;
            btnRel.UseVisualStyleBackColor = false;
            btnRel.Click += relatorioEscolaToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 6, 10);
            ClientSize = new Size(962, 480);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Messier Data & Creative";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            pnlCard3.ResumeLayout(false);
            pnlCard3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlMain;
        private Label lblLogo;
        private Label lblLogoSub;
        private Panel pnlNavSep;
        private Button btnNavJogos;
        private Button btnNavPacotes;
        private Button btnNavHelp;
        private Button btnNavSair;
        private Label lblDashTitle;
        private Label lblDashSub;
        private Panel pnlCard1;
        private Label lblCard1Title;
        private Label lblCard1Desc;
        private Panel pnlCard2;
        private Label lblCard2Title;
        private Label lblCard2Desc;
        private Panel pnlCard3;
        private Label lblCard3Title;
        private Label lblCard3Desc;
        private Button btnRel;
    }
}
