
namespace ExemploHashDuplo
{
    partial class FormsHashDuplo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsHashDuplo));
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTamanho = new System.Windows.Forms.Label();
            this.numTamanho = new System.Windows.Forms.NumericUpDown();
            this.btnCriaLista = new System.Windows.Forms.Button();
            this.lbErro = new System.Windows.Forms.Label();
            this.txtOcorrencias = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            resources.ApplyResources(this.dgvLista, "dgvLista");
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome});
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowTemplate.Height = 25;
            // 
            // Codigo
            // 
            resources.ApplyResources(this.Codigo, "Codigo");
            this.Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            resources.ApplyResources(this.Nome, "Nome");
            this.Nome.Name = "Nome";
            // 
            // lbTamanho
            // 
            resources.ApplyResources(this.lbTamanho, "lbTamanho");
            this.lbTamanho.Name = "lbTamanho";
            // 
            // numTamanho
            // 
            resources.ApplyResources(this.numTamanho, "numTamanho");
            this.numTamanho.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTamanho.Name = "numTamanho";
            // 
            // btnCriaLista
            // 
            resources.ApplyResources(this.btnCriaLista, "btnCriaLista");
            this.btnCriaLista.Name = "btnCriaLista";
            this.btnCriaLista.UseVisualStyleBackColor = true;
            this.btnCriaLista.Click += new System.EventHandler(this.btnCriaLista_Click);
            // 
            // lbErro
            // 
            resources.ApplyResources(this.lbErro, "lbErro");
            this.lbErro.Name = "lbErro";
            // 
            // txtOcorrencias
            // 
            resources.ApplyResources(this.txtOcorrencias, "txtOcorrencias");
            this.txtOcorrencias.Name = "txtOcorrencias";
            // 
            // FormsHashDuplo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.txtOcorrencias);
            this.Controls.Add(this.lbErro);
            this.Controls.Add(this.btnCriaLista);
            this.Controls.Add(this.numTamanho);
            this.Controls.Add(this.lbTamanho);
            this.Controls.Add(this.dgvLista);
            this.Name = "FormsHashDuplo";
            this.Load += new System.EventHandler(this.FormsHashDuplo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lbTamanho;
        private System.Windows.Forms.NumericUpDown numTamanho;
        private System.Windows.Forms.Button btnCriaLista;
        private System.Windows.Forms.Label lbErro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.TextBox txtOcorrencias;
    }
}

