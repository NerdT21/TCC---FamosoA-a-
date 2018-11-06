namespace FamosoAça.Screens.Entregavel_II.Controle_De_Fornecedores
{
    partial class frmCadastrarFornecedor
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mkbCep = new System.Windows.Forms.MaskedTextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeJuridico = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidadeF = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mkbCep
            // 
            this.mkbCep.Location = new System.Drawing.Point(178, 208);
            this.mkbCep.Mask = "00000-000";
            this.mkbCep.Name = "mkbCep";
            this.mkbCep.Size = new System.Drawing.Size(61, 20);
            this.mkbCep.TabIndex = 5;
            this.mkbCep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mkbCep_KeyUp);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(381, 243);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(42, 21);
            this.cboEstado.TabIndex = 7;
            // 
            // lblBairro
            // 
            this.lblBairro.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(122, 202);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(45, 25);
            this.lblBairro.TabIndex = 130;
            this.lblBairro.Text = "CEP";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(179, 150);
            this.txtTelefone.Mask = "(00)0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(77, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(82, 144);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(85, 25);
            this.lbltelefone.TabIndex = 128;
            this.lbltelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(180, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNomeJuridico
            // 
            this.lblNomeJuridico.AutoSize = true;
            this.lblNomeJuridico.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJuridico.Location = new System.Drawing.Point(99, 45);
            this.lblNomeJuridico.Name = "lblNomeJuridico";
            this.lblNomeJuridico.Size = new System.Drawing.Size(68, 25);
            this.lblNomeJuridico.TabIndex = 126;
            this.lblNomeJuridico.Text = "Nome ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(178, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(101, 81);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 124;
            this.lblEmail.Text = "E-mail";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(178, 121);
            this.txtCnpj.Mask = "00.000.000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(105, 20);
            this.txtCnpj.TabIndex = 3;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(178, 243);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(123, 20);
            this.txtCidade.TabIndex = 6;
            // 
            // lblCidadeF
            // 
            this.lblCidadeF.AutoSize = true;
            this.lblCidadeF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeF.Location = new System.Drawing.Point(96, 237);
            this.lblCidadeF.Name = "lblCidadeF";
            this.lblCidadeF.Size = new System.Drawing.Size(71, 25);
            this.lblCidadeF.TabIndex = 121;
            this.lblCidadeF.Text = "Cidade";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(307, 237);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(68, 25);
            this.lblestado.TabIndex = 120;
            this.lblestado.Text = "Estado";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(111, 115);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(56, 25);
            this.lblCNPJ.TabIndex = 119;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(246, 315);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 51);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmCadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.mkbCep);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomeJuridico);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidadeF);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblCNPJ);
            this.Name = "frmCadastrarFornecedor";
            this.Size = new System.Drawing.Size(596, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mkbCep;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeJuridico;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidadeF;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Button btnCadastrar;
    }
}
