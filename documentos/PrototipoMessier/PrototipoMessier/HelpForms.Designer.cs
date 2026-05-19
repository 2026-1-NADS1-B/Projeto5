namespace PrototipoMessier
{
    partial class HelpForms
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlBody = new Panel();
            pnlCard1 = new Panel();
            lblCard1Icon = new Label();
            lblCard1Title = new Label();
            lblCard1Text = new Label();
            pnlCard2 = new Panel();
            lblCard2Icon = new Label();
            lblCard2Title = new Label();
            lblCard2Text = new Label();
            pnlCard3 = new Panel();
            lblCard3Icon = new Label();
            lblCard3Title = new Label();
            lblCard3Text = new Label();
            pnlCard4 = new Panel();
            lblCard4Icon = new Label();
            lblCard4Title = new Label();
            lblCard4Text = new Label();
            lblContact = new Label();
            label1 = new Label();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard3.SuspendLayout();
            pnlCard4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(20, 18, 48);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(875, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(246, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "❓ Central de Ajuda";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(130, 120, 180);
            lblSubtitle.Location = new Point(24, 38);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(295, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Tudo o que você precisa saber sobre o sistema Messier";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(13, 13, 30);
            pnlBody.Controls.Add(pnlCard1);
            pnlBody.Controls.Add(pnlCard2);
            pnlBody.Controls.Add(pnlCard3);
            pnlBody.Controls.Add(pnlCard4);
            pnlBody.Controls.Add(lblContact);
            pnlBody.Controls.Add(label1);
            pnlBody.Location = new Point(0, 60);
            pnlBody.Margin = new Padding(3, 2, 3, 2);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(875, 420);
            pnlBody.TabIndex = 1;
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.FromArgb(22, 20, 52);
            pnlCard1.Controls.Add(lblCard1Icon);
            pnlCard1.Controls.Add(lblCard1Title);
            pnlCard1.Controls.Add(lblCard1Text);
            pnlCard1.Location = new Point(24, 21);
            pnlCard1.Margin = new Padding(3, 2, 3, 2);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(385, 128);
            pnlCard1.TabIndex = 0;
            // 
            // lblCard1Icon
            // 
            lblCard1Icon.AutoSize = true;
            lblCard1Icon.Font = new Font("Segoe UI", 26F);
            lblCard1Icon.ForeColor = Color.FromArgb(130, 110, 220);
            lblCard1Icon.Location = new Point(18, 5);
            lblCard1Icon.Name = "lblCard1Icon";
            lblCard1Icon.Size = new Size(68, 47);
            lblCard1Icon.TabIndex = 0;
            lblCard1Icon.Text = "🎮";
            lblCard1Icon.Click += lblCard1Icon_Click;
            // 
            // lblCard1Title
            // 
            lblCard1Title.AutoSize = true;
            lblCard1Title.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCard1Title.ForeColor = Color.White;
            lblCard1Title.Location = new Point(18, 52);
            lblCard1Title.Name = "lblCard1Title";
            lblCard1Title.Size = new Size(167, 25);
            lblCard1Title.TabIndex = 1;
            lblCard1Title.Text = "Cadastro de Jogos";
            // 
            // lblCard1Text
            // 
            lblCard1Text.Font = new Font("Segoe UI", 10F);
            lblCard1Text.ForeColor = Color.FromArgb(160, 150, 200);
            lblCard1Text.Location = new Point(18, 76);
            lblCard1Text.Name = "lblCard1Text";
            lblCard1Text.Size = new Size(350, 41);
            lblCard1Text.TabIndex = 2;
            lblCard1Text.Text = "Acesse Cadastros → Jogos para adicionar novos jogos.\nPreencha ID, Nome, Tema e Descrição e clique em Salvar.";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.FromArgb(22, 20, 52);
            pnlCard2.Controls.Add(lblCard2Icon);
            pnlCard2.Controls.Add(lblCard2Title);
            pnlCard2.Controls.Add(lblCard2Text);
            pnlCard2.Location = new Point(438, 21);
            pnlCard2.Margin = new Padding(3, 2, 3, 2);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(385, 128);
            pnlCard2.TabIndex = 1;
            // 
            // lblCard2Icon
            // 
            lblCard2Icon.AutoSize = true;
            lblCard2Icon.Font = new Font("Segoe UI", 26F);
            lblCard2Icon.ForeColor = Color.FromArgb(130, 110, 220);
            lblCard2Icon.Location = new Point(18, 5);
            lblCard2Icon.Name = "lblCard2Icon";
            lblCard2Icon.Size = new Size(68, 47);
            lblCard2Icon.TabIndex = 0;
            lblCard2Icon.Text = "📦";
            // 
            // lblCard2Title
            // 
            lblCard2Title.AutoSize = true;
            lblCard2Title.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCard2Title.ForeColor = Color.White;
            lblCard2Title.Location = new Point(18, 52);
            lblCard2Title.Name = "lblCard2Title";
            lblCard2Title.Size = new Size(184, 25);
            lblCard2Title.TabIndex = 1;
            lblCard2Title.Text = "Cadastro de Pacotes";
            // 
            // lblCard2Text
            // 
            lblCard2Text.Font = new Font("Segoe UI", 10F);
            lblCard2Text.ForeColor = Color.FromArgb(160, 150, 200);
            lblCard2Text.Location = new Point(18, 76);
            lblCard2Text.Name = "lblCard2Text";
            lblCard2Text.Size = new Size(350, 41);
            lblCard2Text.TabIndex = 2;
            lblCard2Text.Text = "Acesse Cadastros → Pacotes para criar pacotes de assinatura.\nSelecione os jogos do pacote e defina um nome.";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = Color.FromArgb(22, 20, 52);
            pnlCard3.Controls.Add(lblCard3Icon);
            pnlCard3.Controls.Add(lblCard3Title);
            pnlCard3.Controls.Add(lblCard3Text);
            pnlCard3.Location = new Point(24, 165);
            pnlCard3.Margin = new Padding(3, 2, 3, 2);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(385, 128);
            pnlCard3.TabIndex = 2;
            // 
            // lblCard3Icon
            // 
            lblCard3Icon.AutoSize = true;
            lblCard3Icon.Font = new Font("Segoe UI", 26F);
            lblCard3Icon.ForeColor = Color.FromArgb(130, 110, 220);
            lblCard3Icon.Location = new Point(18, 5);
            lblCard3Icon.Name = "lblCard3Icon";
            lblCard3Icon.Size = new Size(68, 47);
            lblCard3Icon.TabIndex = 0;
            lblCard3Icon.Text = "🔐";
            // 
            // lblCard3Title
            // 
            lblCard3Title.AutoSize = true;
            lblCard3Title.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCard3Title.ForeColor = Color.White;
            lblCard3Title.Location = new Point(18, 52);
            lblCard3Title.Name = "lblCard3Title";
            lblCard3Title.Size = new Size(168, 25);
            lblCard3Title.TabIndex = 1;
            lblCard3Title.Text = "Acesso ao Sistema";
            // 
            // lblCard3Text
            // 
            lblCard3Text.Font = new Font("Segoe UI", 10F);
            lblCard3Text.ForeColor = Color.FromArgb(160, 150, 200);
            lblCard3Text.Location = new Point(18, 76);
            lblCard3Text.Name = "lblCard3Text";
            lblCard3Text.Size = new Size(350, 41);
            lblCard3Text.TabIndex = 2;
            lblCard3Text.Text = "Use as credenciais fornecidas pelo administrador.\nEm caso de problemas, contate o suporte técnico.";
            // 
            // pnlCard4
            // 
            pnlCard4.BackColor = Color.FromArgb(22, 20, 52);
            pnlCard4.Controls.Add(lblCard4Icon);
            pnlCard4.Controls.Add(lblCard4Title);
            pnlCard4.Controls.Add(lblCard4Text);
            pnlCard4.Location = new Point(438, 165);
            pnlCard4.Margin = new Padding(3, 2, 3, 2);
            pnlCard4.Name = "pnlCard4";
            pnlCard4.Size = new Size(385, 128);
            pnlCard4.TabIndex = 3;
            // 
            // lblCard4Icon
            // 
            lblCard4Icon.AutoSize = true;
            lblCard4Icon.Font = new Font("Segoe UI", 26F);
            lblCard4Icon.ForeColor = Color.FromArgb(130, 110, 220);
            lblCard4Icon.Location = new Point(18, 5);
            lblCard4Icon.Name = "lblCard4Icon";
            lblCard4Icon.Size = new Size(68, 47);
            lblCard4Icon.TabIndex = 0;
            lblCard4Icon.Text = "🏫";
            // 
            // lblCard4Title
            // 
            lblCard4Title.AutoSize = true;
            lblCard4Title.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCard4Title.ForeColor = Color.White;
            lblCard4Title.Location = new Point(18, 52);
            lblCard4Title.Name = "lblCard4Title";
            lblCard4Title.Size = new Size(116, 25);
            lblCard4Title.TabIndex = 1;
            lblCard4Title.Text = "Para Escolas";
            // 
            // lblCard4Text
            // 
            lblCard4Text.Font = new Font("Segoe UI", 10F);
            lblCard4Text.ForeColor = Color.FromArgb(160, 150, 200);
            lblCard4Text.Location = new Point(18, 77);
            lblCard4Text.Name = "lblCard4Text";
            lblCard4Text.Size = new Size(350, 40);
            lblCard4Text.TabIndex = 2;
            lblCard4Text.Text = "Adquira pacote de jogos de acordo ao grau escolar.\nE aproveite jogos educacionais super divertidos!";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 9F);
            lblContact.ForeColor = Color.FromArgb(80, 70, 120);
            lblContact.Location = new Point(24, 322);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(398, 15);
            lblContact.TabIndex = 4;
            lblContact.Text = "📧 Suporte: suporte@messierdata.com.br  •  © 2025 Messier Data & Creative";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 1F);
            label1.ForeColor = Color.FromArgb(13, 13, 30);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(16, 3);
            label1.TabIndex = 5;
            label1.Text = "Central de Ajuda";
            // 
            // HelpForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 30);
            ClientSize = new Size(875, 480);
            Controls.Add(pnlHeader);
            Controls.Add(pnlBody);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HelpForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Central de Ajuda";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            pnlCard3.ResumeLayout(false);
            pnlCard3.PerformLayout();
            pnlCard4.ResumeLayout(false);
            pnlCard4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlBody;
        private Panel pnlCard1;
        private Label lblCard1Icon;
        private Label lblCard1Title;
        private Label lblCard1Text;
        private Panel pnlCard2;
        private Label lblCard2Icon;
        private Label lblCard2Title;
        private Label lblCard2Text;
        private Panel pnlCard3;
        private Label lblCard3Icon;
        private Label lblCard3Title;
        private Label lblCard3Text;
        private Panel pnlCard4;
        private Label lblCard4Icon;
        private Label lblCard4Title;
        private Label lblCard4Text;
        private Label lblContact;
        private Label label1;
    }
}
