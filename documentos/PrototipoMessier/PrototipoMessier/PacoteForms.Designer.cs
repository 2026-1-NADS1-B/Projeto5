namespace PrototipoMessier
{
    partial class PacoteForms
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
            lblSubtitle = new Label();
            pnlBody = new Panel();
            pnlLeft = new Panel();
            pnlFieldID = new Panel();
            label1 = new Label();
            txtID = new TextBox();
            pnlFieldNome = new Panel();
            label2 = new Label();
            txtNome = new TextBox();
            pnlJogos = new Panel();
            label3 = new Label();
            checkedListBox1 = new CheckedListBox();
            pnlButtons = new Panel();
            btnNovo = new Button();
            btnSalvar = new Button();
            pnlRight = new Panel();
            lblGridTitle = new Label();
            grdPacotes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlFieldID.SuspendLayout();
            pnlFieldNome.SuspendLayout();
            pnlJogos.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdPacotes).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(10, 12, 20);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(840, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(285, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📦 Cadastro de Pacotes";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(150, 160, 180);
            lblSubtitle.Location = new Point(24, 38);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(301, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Gamificação, tecnologia criativa e soluções para escolas";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(5, 6, 10);
            pnlBody.Controls.Add(pnlLeft);
            pnlBody.Controls.Add(pnlRight);
            pnlBody.Location = new Point(0, 60);
            pnlBody.Margin = new Padding(3, 2, 3, 2);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(840, 405);
            pnlBody.TabIndex = 1;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.Transparent;
            pnlLeft.Controls.Add(pnlFieldID);
            pnlLeft.Controls.Add(pnlFieldNome);
            pnlLeft.Controls.Add(pnlJogos);
            pnlLeft.Controls.Add(pnlButtons);
            pnlLeft.Location = new Point(24, 15);
            pnlLeft.Margin = new Padding(3, 2, 3, 2);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(420, 375);
            pnlLeft.TabIndex = 0;
            // 
            // pnlFieldID
            // 
            pnlFieldID.BackColor = Color.Transparent;
            pnlFieldID.Controls.Add(label1);
            pnlFieldID.Controls.Add(txtID);
            pnlFieldID.Location = new Point(0, 0);
            pnlFieldID.Margin = new Padding(3, 2, 3, 2);
            pnlFieldID.Name = "pnlFieldID";
            pnlFieldID.Size = new Size(88, 45);
            pnlFieldID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(150, 160, 180);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 13);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(16, 18, 30);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Segoe UI", 11F);
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(0, 16);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(88, 27);
            txtID.TabIndex = 0;
            // 
            // pnlFieldNome
            // 
            pnlFieldNome.BackColor = Color.Transparent;
            pnlFieldNome.Controls.Add(label2);
            pnlFieldNome.Controls.Add(txtNome);
            pnlFieldNome.Location = new Point(105, 0);
            pnlFieldNome.Margin = new Padding(3, 2, 3, 2);
            pnlFieldNome.Name = "pnlFieldNome";
            pnlFieldNome.Size = new Size(315, 45);
            pnlFieldNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(150, 160, 180);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 13);
            label2.TabIndex = 0;
            label2.Text = "NOME DO PACOTE";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(16, 18, 30);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.ForeColor = Color.White;
            txtNome.Location = new Point(0, 16);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(315, 27);
            txtNome.TabIndex = 1;
            // 
            // pnlJogos
            // 
            pnlJogos.BackColor = Color.Transparent;
            pnlJogos.Controls.Add(label3);
            pnlJogos.Controls.Add(checkedListBox1);
            pnlJogos.Location = new Point(0, 60);
            pnlJogos.Margin = new Padding(3, 2, 3, 2);
            pnlJogos.Name = "pnlJogos";
            pnlJogos.Size = new Size(420, 202);
            pnlJogos.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(150, 160, 180);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 13);
            label3.TabIndex = 0;
            label3.Text = "JOGOS DO PACOTE";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.FromArgb(16, 18, 30);
            checkedListBox1.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Segoe UI", 11F);
            checkedListBox1.ForeColor = Color.White;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Jogo 1", "Jogo 2", "Jogo 3", "Jogo 4", "Jogo 5" });
            checkedListBox1.Location = new Point(0, 18);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(420, 156);
            checkedListBox1.TabIndex = 2;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.Transparent;
            pnlButtons.Controls.Add(btnNovo);
            pnlButtons.Controls.Add(btnSalvar);
            pnlButtons.Location = new Point(0, 278);
            pnlButtons.Margin = new Padding(3, 2, 3, 2);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(420, 38);
            pnlButtons.TabIndex = 3;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.FromArgb(22, 25, 40);
            btnNovo.Cursor = Cursors.Hand;
            btnNovo.FlatAppearance.BorderColor = Color.FromArgb(0, 229, 255);
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNovo.ForeColor = Color.FromArgb(0, 229, 255);
            btnNovo.Location = new Point(0, 4);
            btnNovo.Margin = new Padding(3, 2, 3, 2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(114, 28);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo +";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 229, 255);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.FromArgb(5, 6, 10);
            btnSalvar.Location = new Point(306, 4);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(114, 28);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar ✓";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(10, 12, 20);
            pnlRight.Controls.Add(lblGridTitle);
            pnlRight.Controls.Add(grdPacotes);
            pnlRight.Location = new Point(469, 15);
            pnlRight.Margin = new Padding(3, 2, 3, 2);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(350, 375);
            pnlRight.TabIndex = 1;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(0, 229, 255);
            lblGridTitle.Location = new Point(14, 12);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(153, 20);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Pacotes Cadastrados";
            // 
            // grdPacotes
            // 
            grdPacotes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 21, 34);
            dataGridViewCellStyle1.ForeColor = Color.White;
            grdPacotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdPacotes.BackgroundColor = Color.FromArgb(10, 12, 20);
            grdPacotes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 25, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 229, 255);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdPacotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdPacotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPacotes.Columns.AddRange(new DataGridViewColumn[] { ID, Nome });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(16, 18, 30);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grdPacotes.DefaultCellStyle = dataGridViewCellStyle3;
            grdPacotes.GridColor = Color.FromArgb(36, 40, 60);
            grdPacotes.Location = new Point(14, 36);
            grdPacotes.Margin = new Padding(3, 2, 3, 2);
            grdPacotes.Name = "grdPacotes";
            grdPacotes.ReadOnly = true;
            grdPacotes.RowHeadersVisible = false;
            grdPacotes.RowTemplate.Height = 36;
            grdPacotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdPacotes.Size = new Size(322, 322);
            grdPacotes.TabIndex = 5;
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
            Nome.HeaderText = "Pacote";
            Nome.MaxInputLength = 20;
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 280;
            // 
            // PacoteForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 6, 10);
            ClientSize = new Size(840, 465);
            Controls.Add(pnlHeader);
            Controls.Add(pnlBody);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PacoteForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Pacotes";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlFieldID.ResumeLayout(false);
            pnlFieldID.PerformLayout();
            pnlFieldNome.ResumeLayout(false);
            pnlFieldNome.PerformLayout();
            pnlJogos.ResumeLayout(false);
            pnlJogos.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdPacotes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlBody;
        private Panel pnlLeft;
        private Panel pnlFieldID;
        private Label label1;
        private TextBox txtID;
        private Panel pnlFieldNome;
        private Label label2;
        private TextBox txtNome;
        private Panel pnlJogos;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private Panel pnlButtons;
        private Button btnNovo;
        private Button btnSalvar;
        private Panel pnlRight;
        private Label lblGridTitle;
        private DataGridView grdPacotes;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
    }
}
