
namespace ExemploHashQuadratico
{
    partial class formsHashQuad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numTamanho = new System.Windows.Forms.NumericUpDown();
            this.btnCriar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSaida = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamanho:";
            // 
            // numTamanho
            // 
            this.numTamanho.Location = new System.Drawing.Point(78, 11);
            this.numTamanho.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTamanho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTamanho.Name = "numTamanho";
            this.numTamanho.Size = new System.Drawing.Size(120, 23);
            this.numTamanho.TabIndex = 1;
            this.numTamanho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(218, 10);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 2;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNome});
            this.dgvDados.Location = new System.Drawing.Point(13, 84);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowTemplate.Height = 25;
            this.dgvDados.Size = new System.Drawing.Size(343, 354);
            this.dgvDados.TabIndex = 3;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Width = 200;
            // 
            // txtSaida
            // 
            this.txtSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaida.Location = new System.Drawing.Point(401, 84);
            this.txtSaida.Multiline = true;
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSaida.Size = new System.Drawing.Size(387, 354);
            this.txtSaida.TabIndex = 4;
            // 
            // formsHashQuad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.numTamanho);
            this.Controls.Add(this.label1);
            this.Name = "formsHashQuad";
            this.Text = "Exemplo Sondagem Quadrática";
            ((System.ComponentModel.ISupportInitialize)(this.numTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTamanho;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.TextBox txtSaida;
    }
}

