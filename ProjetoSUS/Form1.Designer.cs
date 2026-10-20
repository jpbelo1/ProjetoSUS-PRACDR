namespace ProjetoSUS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPrinc = new System.Windows.Forms.DataGridView();
            this.nomePac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfPac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidAtend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telPac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAcomp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telAcomp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAcomp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CadPac = new System.Windows.Forms.Button();
            this.labelTotalPac = new System.Windows.Forms.Label();
            this.TextPesq = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrinc
            // 
            this.dgvPrinc.AllowUserToAddRows = false;
            this.dgvPrinc.AllowUserToDeleteRows = false;
            this.dgvPrinc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrinc.BackgroundColor = System.Drawing.Color.Violet;
            this.dgvPrinc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrinc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomePac,
            this.cpfPac,
            this.dataNasc,
            this.tipoDoen,
            this.cid,
            this.unidAtend,
            this.telPac,
            this.emailPac,
            this.nomeAcomp,
            this.telAcomp,
            this.emailAcomp});
            this.dgvPrinc.Location = new System.Drawing.Point(12, 104);
            this.dgvPrinc.Name = "dgvPrinc";
            this.dgvPrinc.ReadOnly = true;
            this.dgvPrinc.Size = new System.Drawing.Size(1044, 412);
            this.dgvPrinc.TabIndex = 0;
            this.dgvPrinc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrinc_CellContentClick);
            // 
            // nomePac
            // 
            this.nomePac.HeaderText = "Nome";
            this.nomePac.Name = "nomePac";
            this.nomePac.ReadOnly = true;
            // 
            // cpfPac
            // 
            this.cpfPac.HeaderText = "CPF";
            this.cpfPac.Name = "cpfPac";
            this.cpfPac.ReadOnly = true;
            // 
            // dataNasc
            // 
            this.dataNasc.HeaderText = "Nascimento";
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.ReadOnly = true;
            // 
            // tipoDoen
            // 
            this.tipoDoen.HeaderText = "Tipo de Doença";
            this.tipoDoen.Name = "tipoDoen";
            this.tipoDoen.ReadOnly = true;
            // 
            // cid
            // 
            this.cid.HeaderText = "CID";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // unidAtend
            // 
            this.unidAtend.HeaderText = "Unid. Atendimento";
            this.unidAtend.Name = "unidAtend";
            this.unidAtend.ReadOnly = true;
            // 
            // telPac
            // 
            this.telPac.HeaderText = "Telefone";
            this.telPac.Name = "telPac";
            this.telPac.ReadOnly = true;
            // 
            // emailPac
            // 
            this.emailPac.HeaderText = "Email";
            this.emailPac.Name = "emailPac";
            this.emailPac.ReadOnly = true;
            // 
            // nomeAcomp
            // 
            this.nomeAcomp.HeaderText = "Acompanhante";
            this.nomeAcomp.Name = "nomeAcomp";
            this.nomeAcomp.ReadOnly = true;
            // 
            // telAcomp
            // 
            this.telAcomp.HeaderText = "Tel. Acomp.";
            this.telAcomp.Name = "telAcomp";
            this.telAcomp.ReadOnly = true;
            // 
            // emailAcomp
            // 
            this.emailAcomp.HeaderText = "Email Acomp.";
            this.emailAcomp.Name = "emailAcomp";
            this.emailAcomp.ReadOnly = true;
            // 
            // CadPac
            // 
            this.CadPac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CadPac.AutoSize = true;
            this.CadPac.BackColor = System.Drawing.Color.Violet;
            this.CadPac.Cursor = System.Windows.Forms.Cursors.Default;
            this.CadPac.Location = new System.Drawing.Point(950, 75);
            this.CadPac.Name = "CadPac";
            this.CadPac.Size = new System.Drawing.Size(106, 23);
            this.CadPac.TabIndex = 1;
            this.CadPac.Text = "Novo Paciente";
            this.CadPac.UseVisualStyleBackColor = false;
            this.CadPac.Click += new System.EventHandler(this.CadPac_Click);
            // 
            // labelTotalPac
            // 
            this.labelTotalPac.AutoSize = true;
            this.labelTotalPac.BackColor = System.Drawing.Color.Violet;
            this.labelTotalPac.Location = new System.Drawing.Point(467, 80);
            this.labelTotalPac.Name = "labelTotalPac";
            this.labelTotalPac.Size = new System.Drawing.Size(13, 13);
            this.labelTotalPac.TabIndex = 3;
            this.labelTotalPac.Text = "0";
            // 
            // TextPesq
            // 
            this.TextPesq.BackColor = System.Drawing.Color.Violet;
            this.TextPesq.Location = new System.Drawing.Point(90, 77);
            this.TextPesq.Name = "TextPesq";
            this.TextPesq.Size = new System.Drawing.Size(362, 20);
            this.TextPesq.TabIndex = 4;
            this.TextPesq.TextChanged += new System.EventHandler(this.TextPesq_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Purple;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Pesquisar:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Violet;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1068, 61);
            this.label1.TabIndex = 34;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLogin.AutoSize = true;
            this.ButtonLogin.BackColor = System.Drawing.Color.Violet;
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonLogin.Location = new System.Drawing.Point(838, 75);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(106, 23);
            this.ButtonLogin.TabIndex = 35;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.AutoSize = true;
            this.buttonLogout.BackColor = System.Drawing.Color.Gray;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonLogout.Location = new System.Drawing.Point(726, 75);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(106, 23);
            this.buttonLogout.TabIndex = 36;
            this.buttonLogout.Text = "Encerrar Sessão";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Violet;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 41);
            this.label2.TabIndex = 37;
            this.label2.Text = "PRACDR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Violet;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = " Programa de registo, acompanhamento e cuidado de doenças raras";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1068, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextPesq);
            this.Controls.Add(this.labelTotalPac);
            this.Controls.Add(this.CadPac);
            this.Controls.Add(this.dgvPrinc);
            this.Name = "Form1";
            this.Text = "PRACDR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrinc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfPac;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidAtend;
        private System.Windows.Forms.DataGridViewTextBoxColumn telPac;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPac;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAcomp;
        private System.Windows.Forms.DataGridViewTextBoxColumn telAcomp;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAcomp;
        private System.Windows.Forms.Button CadPac;
        private System.Windows.Forms.Label labelTotalPac;
        private System.Windows.Forms.TextBox TextPesq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

