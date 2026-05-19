namespace PrototipoMessier
{
    partial class JogosForms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlForm = new Panel();
            pnlFieldID = new Panel();
            label1 = new Label();
            txtID = new TextBox();
            pnlFieldNome = new Panel();
            label2 = new Label();
            txtNome = new TextBox();
            pnlFieldTema = new Panel();
            lblTema = new Label();
            txtTema = new TextBox();
            pnlFieldDesc = new Panel();
            label3 = new Label();
            txtDescricao = new TextBox();
            pnlButtons = new Panel();
            btnNovo = new Button();
            btnSalvar = new Button();
            pnlGrid = new Panel();
            lblGridTitle = new Label();
            grdJogos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Tema = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlFieldID.SuspendLayout();
            pnlFieldNome.SuspendLayout();
            pnlFieldTema.SuspendLayout();
            pnlFieldDesc.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdJogos).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(20, 18, 48);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(858, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🎮 Cadastro de Jogos";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.FromArgb(13, 13, 30);
            pnlForm.Controls.Add(pnlFieldID);
            pnlForm.Controls.Add(pnlFieldNome);
            pnlForm.Controls.Add(pnlFieldTema);
            pnlForm.Controls.Add(pnlFieldDesc);
            pnlForm.Controls.Add(pnlButtons);
            pnlForm.Location = new Point(0, 60);
            pnlForm.Margin = new Padding(3, 2, 3, 2);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(858, 218);
            pnlForm.TabIndex = 1;
            // 
            // pnlFieldID
            // 
            pnlFieldID.BackColor = Color.Transparent;
            pnlFieldID.Controls.Add(label1);
            pnlFieldID.Controls.Add(txtID);
            pnlFieldID.Location = new Point(24, 15);
            pnlFieldID.Margin = new Padding(3, 2, 3, 2);
            pnlFieldID.Name = "pnlFieldID";
            pnlFieldID.Size = new Size(70, 45);
            pnlFieldID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(130, 120, 180);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 13);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(22, 20, 52);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Segoe UI", 11F);
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(0, 16);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(70, 27);
            txtID.TabIndex = 0;
            // 
            // pnlFieldNome
            // 
            pnlFieldNome.BackColor = Color.Transparent;
            pnlFieldNome.Controls.Add(label2);
            pnlFieldNome.Controls.Add(txtNome);
            pnlFieldNome.Location = new Point(112, 15);
            pnlFieldNome.Margin = new Padding(3, 2, 3, 2);
            pnlFieldNome.Name = "pnlFieldNome";
            pnlFieldNome.Size = new Size(332, 45);
            pnlFieldNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(130, 120, 180);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 13);
            label2.TabIndex = 0;
            label2.Text = "NOME DO JOGO";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(22, 20, 52);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.ForeColor = Color.White;
            txtNome.Location = new Point(0, 16);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(333, 27);
            txtNome.TabIndex = 1;
            // 
            // pnlFieldTema
            // 
            pnlFieldTema.BackColor = Color.Transparent;
            pnlFieldTema.Controls.Add(lblTema);
            pnlFieldTema.Controls.Add(txtTema);
            pnlFieldTema.Location = new Point(472, 15);
            pnlFieldTema.Margin = new Padding(3, 2, 3, 2);
            pnlFieldTema.Name = "pnlFieldTema";
            pnlFieldTema.Size = new Size(350, 45);
            pnlFieldTema.TabIndex = 2;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTema.ForeColor = Color.FromArgb(130, 120, 180);
            lblTema.Location = new Point(0, 0);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(38, 13);
            lblTema.TabIndex = 0;
            lblTema.Text = "TEMA";
            lblTema.Click += label4_Click;
            // 
            // txtTema
            // 
            txtTema.BackColor = Color.FromArgb(22, 20, 52);
            txtTema.BorderStyle = BorderStyle.FixedSingle;
            txtTema.Font = new Font("Segoe UI", 11F);
            txtTema.ForeColor = Color.White;
            txtTema.Location = new Point(0, 16);
            txtTema.Margin = new Padding(3, 2, 3, 2);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(350, 27);
            txtTema.TabIndex = 2;
            // 
            // pnlFieldDesc
            // 
            pnlFieldDesc.BackColor = Color.Transparent;
            pnlFieldDesc.Controls.Add(label3);
            pnlFieldDesc.Controls.Add(txtDescricao);
            pnlFieldDesc.Location = new Point(24, 82);
            pnlFieldDesc.Margin = new Padding(3, 2, 3, 2);
            pnlFieldDesc.Name = "pnlFieldDesc";
            pnlFieldDesc.Size = new Size(798, 82);
            pnlFieldDesc.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(130, 120, 180);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 13);
            label3.TabIndex = 0;
            label3.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.FromArgb(22, 20, 52);
            txtDescricao.BorderStyle = BorderStyle.FixedSingle;
            txtDescricao.Font = new Font("Segoe UI", 11F);
            txtDescricao.ForeColor = Color.White;
            txtDescricao.Location = new Point(0, 16);
            txtDescricao.Margin = new Padding(3, 2, 3, 2);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(798, 60);
            txtDescricao.TabIndex = 3;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.Transparent;
            pnlButtons.Controls.Add(btnNovo);
            pnlButtons.Controls.Add(btnSalvar);
            pnlButtons.Location = new Point(24, 172);
            pnlButtons.Margin = new Padding(3, 2, 3, 2);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(798, 38);
            pnlButtons.TabIndex = 4;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.FromArgb(30, 27, 65);
            btnNovo.Cursor = Cursors.Hand;
            btnNovo.FlatAppearance.BorderColor = Color.FromArgb(60, 55, 120);
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNovo.ForeColor = Color.FromArgb(160, 150, 220);
            btnNovo.Location = new Point(0, 4);
            btnNovo.Margin = new Padding(3, 2, 3, 2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(114, 28);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "+ Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(83, 74, 183);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(684, 4);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(114, 28);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar ✓";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(20, 18, 48);
            pnlGrid.Controls.Add(lblGridTitle);
            pnlGrid.Controls.Add(grdJogos);
            pnlGrid.Location = new Point(0, 268);
            pnlGrid.Margin = new Padding(3, 2, 3, 2);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(858, 242);
            pnlGrid.TabIndex = 2;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(160, 150, 220);
            lblGridTitle.Location = new Point(24, 12);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(140, 20);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Jogos Cadastrados";
            // 
            // grdJogos
            // 
            grdJogos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 24, 58);
            dataGridViewCellStyle1.ForeColor = Color.White;
            grdJogos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdJogos.BackgroundColor = Color.FromArgb(20, 18, 48);
            grdJogos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 27, 65);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(160, 150, 220);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdJogos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdJogos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdJogos.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, Tema, Descricao });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(22, 20, 52);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(83, 74, 183);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grdJogos.DefaultCellStyle = dataGridViewCellStyle3;
            grdJogos.GridColor = Color.FromArgb(40, 35, 80);
            grdJogos.Location = new Point(24, 36);
            grdJogos.Margin = new Padding(3, 2, 3, 2);
            grdJogos.Name = "grdJogos";
            grdJogos.ReadOnly = true;
            grdJogos.RowHeadersVisible = false;
            grdJogos.RowTemplate.Height = 36;
            grdJogos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdJogos.Size = new Size(808, 202);
            grdJogos.TabIndex = 6;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MaxInputLength = 3;
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 60;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MaxInputLength = 20;
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 260;
            // 
            // Tema
            // 
            Tema.HeaderText = "Tema";
            Tema.MinimumWidth = 8;
            Tema.Name = "Tema";
            Tema.ReadOnly = true;
            Tema.Width = 200;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 400;
            // 
            // JogosForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 30);
            ClientSize = new Size(858, 510);
            Controls.Add(pnlHeader);
            Controls.Add(pnlForm);
            Controls.Add(pnlGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "JogosForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Jogos";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlFieldID.ResumeLayout(false);
            pnlFieldID.PerformLayout();
            pnlFieldNome.ResumeLayout(false);
            pnlFieldNome.PerformLayout();
            pnlFieldTema.ResumeLayout(false);
            pnlFieldTema.PerformLayout();
            pnlFieldDesc.ResumeLayout(false);
            pnlFieldDesc.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdJogos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlForm;
        private Panel pnlFieldID;
        private Label label1;
        private TextBox txtID;
        private Panel pnlFieldNome;
        private Label label2;
        private TextBox txtNome;
        private Panel pnlFieldTema;
        private Label lblTema;
        private TextBox txtTema;
        private Panel pnlFieldDesc;
        private Label label3;
        private TextBox txtDescricao;
        private Panel pnlButtons;
        private Button btnNovo;
        private Button btnSalvar;
        private Panel pnlGrid;
        private Label lblGridTitle;
        private DataGridView grdJogos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Tema;
        private DataGridViewTextBoxColumn Descricao;
    }
}
