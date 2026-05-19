namespace PrototipoMessier
{
    partial class RelEscolaForms
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
            btnImprimir = new Button();
            txtRel = new TextBox();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(10, 12, 20);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 86);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(28, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(257, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Relatório de Escolas";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(150, 160, 180);
            lblSubtitle.Location = new Point(30, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(413, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Visualização dos pacotes contratados no sistema Messier Data & Creative";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(5, 6, 10);
            pnlBody.Controls.Add(btnImprimir);
            pnlBody.Controls.Add(txtRel);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 86);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(900, 494);
            pnlBody.TabIndex = 1;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(0, 229, 255);
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnImprimir.ForeColor = Color.FromArgb(5, 6, 10);
            btnImprimir.Location = new Point(28, 24);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(160, 42);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Gerar relatório";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtRel
            // 
            txtRel.BackColor = Color.FromArgb(16, 18, 30);
            txtRel.BorderStyle = BorderStyle.FixedSingle;
            txtRel.Font = new Font("Consolas", 11F);
            txtRel.ForeColor = Color.White;
            txtRel.Location = new Point(28, 84);
            txtRel.Multiline = true;
            txtRel.Name = "txtRel";
            txtRel.ScrollBars = ScrollBars.Vertical;
            txtRel.Size = new Size(844, 380);
            txtRel.TabIndex = 1;
            // 
            // RelEscolaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 6, 10);
            ClientSize = new Size(900, 580);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "RelEscolaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório de Escolas";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlBody;
        private Button btnImprimir;
        private TextBox txtRel;
    }
}
