namespace FamosoAça.Screens.Entregavel_I.Controle_de_Funcionários
{
    partial class frmCadastrarFuncionario
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
            this.label15 = new System.Windows.Forms.Label();
            this.mkbCep = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cboDepto = new System.Windows.Forms.ComboBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mkbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mkbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mkbRg = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudSalario = new System.Windows.Forms.NumericUpDown();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(85, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 17);
            this.label15.TabIndex = 111;
            this.label15.Text = "Salário";
            // 
            // mkbCep
            // 
            this.mkbCep.Location = new System.Drawing.Point(131, 212);
            this.mkbCep.Mask = "99999-999";
            this.mkbCep.Name = "mkbCep";
            this.mkbCep.Size = new System.Drawing.Size(59, 20);
            this.mkbCep.TabIndex = 8;
            this.mkbCep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCep_KeyUp);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(238, 338);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 47);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cboDepto
            // 
            this.cboDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepto.FormattingEnabled = true;
            this.cboDepto.Location = new System.Drawing.Point(391, 275);
            this.cboDepto.Name = "cboDepto";
            this.cboDepto.Size = new System.Drawing.Size(130, 21);
            this.cboDepto.TabIndex = 14;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(175, 275);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(116, 20);
            this.txtComplemento.TabIndex = 13;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(80, 240);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(288, 23);
            this.txtEndereco.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(82, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 107;
            this.label13.Text = "Complemento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(92, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 17);
            this.label12.TabIndex = 106;
            this.label12.Text = "CEP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(48, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 105;
            this.label11.Text = "Rua";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(296, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 104;
            this.label10.Text = "Departamento";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(350, 212);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(171, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(88, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 5);
            this.panel1.TabIndex = 103;
            // 
            // mkbNascimento
            // 
            this.mkbNascimento.Location = new System.Drawing.Point(163, 101);
            this.mkbNascimento.Mask = "00/00/0000";
            this.mkbNascimento.Name = "mkbNascimento";
            this.mkbNascimento.Size = new System.Drawing.Size(67, 20);
            this.mkbNascimento.TabIndex = 3;
            this.mkbNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(289, 101);
            this.mkbTelefone.Mask = "(00)00000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(83, 20);
            this.mkbTelefone.TabIndex = 4;
            // 
            // mkbCpf
            // 
            this.mkbCpf.Location = new System.Drawing.Point(146, 129);
            this.mkbCpf.Mask = "000.000.000-00";
            this.mkbCpf.Name = "mkbCpf";
            this.mkbCpf.Size = new System.Drawing.Size(83, 20);
            this.mkbCpf.TabIndex = 5;
            // 
            // mkbRg
            // 
            this.mkbRg.Location = new System.Drawing.Point(302, 127);
            this.mkbRg.Mask = "00.000.000-0";
            this.mkbRg.Name = "mkbRg";
            this.mkbRg.Size = new System.Drawing.Size(70, 20);
            this.mkbRg.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(241, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(204, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 101;
            this.label8.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(300, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 100;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(231, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 99;
            this.label6.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(80, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 98;
            this.label5.Text = " Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(269, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 97;
            this.label4.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(115, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 96;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(85, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 95;
            this.label2.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(85, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 94;
            this.label1.Text = "Nome";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(252, 210);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(39, 21);
            this.cboEstado.TabIndex = 9;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // pbxImagem
            // 
            this.pbxImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImagem.Location = new System.Drawing.Point(391, 36);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(112, 113);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagem.TabIndex = 108;
            this.pbxImagem.TabStop = false;
            this.pbxImagem.Click += new System.EventHandler(this.pbxImagem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nudSalario);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.groupBox1.Location = new System.Drawing.Point(51, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 329);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Funcionários";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // nudSalario
            // 
            this.nudSalario.DecimalPlaces = 2;
            this.nudSalario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSalario.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSalario.Location = new System.Drawing.Point(83, 159);
            this.nudSalario.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSalario.Name = "nudSalario";
            this.nudSalario.Size = new System.Drawing.Size(96, 23);
            this.nudSalario.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(404, 239);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(66, 23);
            this.txtNumero.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(375, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 17);
            this.label9.TabIndex = 107;
            this.label9.Text = "Nº";
            // 
            // frmCadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FamosoAça.Properties.Resources.Bachground_Famoso_Açaí;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.mkbCep);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cboDepto);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.pbxImagem);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mkbNascimento);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mkbTelefone);
            this.Controls.Add(this.mkbCpf);
            this.Controls.Add(this.mkbRg);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "frmCadastrarFuncionario";
            this.Size = new System.Drawing.Size(596, 397);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mkbCep;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cboDepto;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mkbNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.MaskedTextBox mkbCpf;
        private System.Windows.Forms.MaskedTextBox mkbRg;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudSalario;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label9;
    }
}
