namespace FamosoAça.Screens.Entregavel_IV.Fluxo_de_Caixa
{
    partial class frmFluxoCaixa
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
            this.dgvFluxoDeCaixa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoDeCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFluxoDeCaixa
            // 
            this.dgvFluxoDeCaixa.AllowUserToAddRows = false;
            this.dgvFluxoDeCaixa.AllowUserToDeleteRows = false;
            this.dgvFluxoDeCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFluxoDeCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvFluxoDeCaixa.Location = new System.Drawing.Point(46, 44);
            this.dgvFluxoDeCaixa.Name = "dgvFluxoDeCaixa";
            this.dgvFluxoDeCaixa.ReadOnly = true;
            this.dgvFluxoDeCaixa.Size = new System.Drawing.Size(504, 308);
            this.dgvFluxoDeCaixa.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DataReferencia";
            this.Column1.HeaderText = "Data de Referência";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ganhos";
            this.Column2.HeaderText = "Total Ganhos";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Despesas";
            this.Column3.HeaderText = "Total Despesas";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Saldo";
            this.Column4.HeaderText = "Saldo Final";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FamosoAça.Properties.Resources.Bachground_Famoso_Açaí;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgvFluxoDeCaixa);
            this.DoubleBuffered = true;
            this.Name = "frmFluxoCaixa";
            this.Size = new System.Drawing.Size(596, 397);
            this.Load += new System.EventHandler(this.frmFluxoCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoDeCaixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFluxoDeCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
