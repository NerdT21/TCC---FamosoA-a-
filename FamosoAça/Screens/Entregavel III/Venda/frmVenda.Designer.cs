namespace FamosoAça.Screens.Entregavel_III.ConsultarVenda
{
    partial class frmVenda
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNome = new System.Windows.Forms.ComboBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxCarrinho = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(167, 178);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(84, 20);
            this.nudQtd.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(221, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 48);
            this.button2.TabIndex = 39;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(15, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 5);
            this.panel1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Produto";
            // 
            // cboNome
            // 
            this.cboNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNome.FormattingEnabled = true;
            this.cboNome.Location = new System.Drawing.Point(167, 53);
            this.cboNome.Name = "cboNome";
            this.cboNome.Size = new System.Drawing.Size(121, 21);
            this.cboNome.TabIndex = 35;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(167, 139);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(121, 20);
            this.txtProduto.TabIndex = 34;
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(200, 261);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(67, 20);
            this.mskData.TabIndex = 33;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(417, 264);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(80, 20);
            this.txtValorTotal.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Data da Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Carrinho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Sub. Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FamosoAça.Properties.Resources.icons8_plus_32;
            this.pictureBox1.Location = new System.Drawing.Point(257, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Produto";
            // 
            // lbxCarrinho
            // 
            this.lbxCarrinho.FormattingEnabled = true;
            this.lbxCarrinho.Location = new System.Drawing.Point(349, 134);
            this.lbxCarrinho.Name = "lbxCarrinho";
            this.lbxCarrinho.Size = new System.Drawing.Size(148, 121);
            this.lbxCarrinho.TabIndex = 25;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudQtd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboNome);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxCarrinho);
            this.Name = "frmVenda";
            this.Size = new System.Drawing.Size(596, 397);
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNome;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxCarrinho;
    }
}
