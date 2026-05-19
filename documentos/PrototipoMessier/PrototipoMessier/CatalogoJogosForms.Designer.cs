namespace PrototipoMessier
{
    partial class CatalogoJogosForms
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
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblsubTitulo = new Label();
            lblPacote = new Label();
            card1 = new Panel();
            titulo1 = new Label();
            desc1 = new Label();
            btn1 = new Button();
            card2 = new Panel();
            titulo2 = new Label();
            desc2 = new Label();
            btn2 = new Button();
            card3 = new Panel();
            titulo3 = new Label();
            desc3 = new Label();
            btn3 = new Button();
            panelHeader.SuspendLayout();
            card1.SuspendLayout();
            card2.SuspendLayout();
            card3.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(20, 18, 48);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblsubTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(980, 90);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(266, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🎮 Catálogo de Jogos";
            // 
            // lblsubTitulo
            // 
            lblsubTitulo.AutoSize = true;
            lblsubTitulo.Font = new Font("Segoe UI", 9F);
            lblsubTitulo.ForeColor = Color.FromArgb(130, 120, 180);
            lblsubTitulo.Location = new Point(28, 50);
            lblsubTitulo.Name = "lblsubTitulo";
            lblsubTitulo.Size = new Size(182, 15);
            lblsubTitulo.TabIndex = 1;
            lblsubTitulo.Text = "Jogos disponíveis para sua escola";
            // 
            // lblPacote
            // 
            lblPacote.AutoSize = true;
            lblPacote.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPacote.ForeColor = Color.FromArgb(160, 150, 220);
            lblPacote.Location = new Point(30, 110);
            lblPacote.Name = "lblPacote";
            lblPacote.Size = new Size(235, 19);
            lblPacote.TabIndex = 1;
            lblPacote.Text = "Pacote contratado: Fundamental I";
            // 
            // card1
            // 
            card1.BackColor = Color.FromArgb(22, 20, 52);
            card1.Controls.Add(titulo1);
            card1.Controls.Add(desc1);
            card1.Controls.Add(btn1);
            card1.Location = new Point(30, 160);
            card1.Name = "card1";
            card1.Size = new Size(280, 180);
            card1.TabIndex = 2;
            // 
            // titulo1
            // 
            titulo1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titulo1.ForeColor = Color.White;
            titulo1.Location = new Point(15, 15);
            titulo1.Name = "titulo1";
            titulo1.Size = new Size(262, 23);
            titulo1.TabIndex = 0;
            titulo1.Text = "Soma Ninja";
            // 
            // desc1
            // 
            desc1.ForeColor = Color.FromArgb(160, 150, 220);
            desc1.Location = new Point(15, 60);
            desc1.Name = "desc1";
            desc1.Size = new Size(240, 60);
            desc1.TabIndex = 1;
            desc1.Text = "Matemática • Fundamental I\nTreine operações de forma divertida";
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(83, 74, 183);
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(15, 130);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 35);
            btn1.TabIndex = 2;
            btn1.Text = "Jogar";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // card2
            // 
            card2.BackColor = Color.FromArgb(22, 20, 52);
            card2.Controls.Add(titulo2);
            card2.Controls.Add(desc2);
            card2.Controls.Add(btn2);
            card2.Location = new Point(340, 160);
            card2.Name = "card2";
            card2.Size = new Size(280, 180);
            card2.TabIndex = 3;
            // 
            // titulo2
            // 
            titulo2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titulo2.ForeColor = Color.White;
            titulo2.Location = new Point(15, 15);
            titulo2.Name = "titulo2";
            titulo2.Size = new Size(203, 23);
            titulo2.TabIndex = 0;
            titulo2.Text = "Detetive das Vogais";
            // 
            // desc2
            // 
            desc2.ForeColor = Color.FromArgb(160, 150, 220);
            desc2.Location = new Point(15, 60);
            desc2.Name = "desc2";
            desc2.Size = new Size(240, 60);
            desc2.TabIndex = 1;
            desc2.Text = "Português • Fundamental I\nIdentifique vogais escondidas em palavras e desafios interativos";
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(83, 74, 183);
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(15, 130);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 35);
            btn2.TabIndex = 2;
            btn2.Text = "Jogar";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // card3
            // 
            card3.BackColor = Color.FromArgb(22, 20, 52);
            card3.Controls.Add(titulo3);
            card3.Controls.Add(desc3);
            card3.Controls.Add(btn3);
            card3.Location = new Point(650, 160);
            card3.Name = "card3";
            card3.Size = new Size(280, 180);
            card3.TabIndex = 4;
            // 
            // titulo3
            // 
            titulo3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titulo3.ForeColor = Color.White;
            titulo3.Location = new Point(15, 15);
            titulo3.Name = "titulo3";
            titulo3.Size = new Size(228, 23);
            titulo3.TabIndex = 0;
            titulo3.Text = "Missão Animal";
            // 
            // desc3
            // 
            desc3.ForeColor = Color.FromArgb(160, 150, 220);
            desc3.Location = new Point(15, 60);
            desc3.Name = "desc3";
            desc3.Size = new Size(240, 60);
            desc3.TabIndex = 1;
            desc3.Text = "Ciências • Fundamental I\nRelacione animais aos seus habitats naturais e descubra novos animais e seus habitats naturais!";
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(83, 74, 183);
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(15, 130);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 35);
            btn3.TabIndex = 2;
            btn3.Text = "Jogar";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // CatalogoJogosForms
            // 
            BackColor = Color.FromArgb(13, 13, 30);
            ClientSize = new Size(980, 620);
            Controls.Add(panelHeader);
            Controls.Add(lblPacote);
            Controls.Add(card1);
            Controls.Add(card2);
            Controls.Add(card3);
            Name = "CatalogoJogosForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catálogo de Jogos";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            card1.ResumeLayout(false);
            card2.ResumeLayout(false);
            card3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblsubTitulo;
        private Label lblPacote;

        private Panel card1;
        private Panel card2;
        private Panel card3;

        private Label titulo1;
        private Label titulo2;
        private Label titulo3;

        private Label desc1;
        private Label desc2;
        private Label desc3;

        private Button btn1;
        private Button btn2;
        private Button btn3;
    }
}