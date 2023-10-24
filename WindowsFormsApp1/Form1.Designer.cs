namespace WindowsFormsApp1
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
            this.lblNomeTarefa = new System.Windows.Forms.Label();
            this.lblDataTrabalho = new System.Windows.Forms.Label();
            this.txtNomeTarefa = new System.Windows.Forms.TextBox();
            this.mskDataTrabalho = new System.Windows.Forms.MaskedTextBox();
            this.btnResolver = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvTrabalhos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabalhos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeTarefa
            // 
            this.lblNomeTarefa.AutoSize = true;
            this.lblNomeTarefa.Location = new System.Drawing.Point(68, 32);
            this.lblNomeTarefa.Name = "lblNomeTarefa";
            this.lblNomeTarefa.Size = new System.Drawing.Size(38, 13);
            this.lblNomeTarefa.TabIndex = 0;
            this.lblNomeTarefa.Text = "Tarefa";
            // 
            // lblDataTrabalho
            // 
            this.lblDataTrabalho.AutoSize = true;
            this.lblDataTrabalho.Location = new System.Drawing.Point(181, 32);
            this.lblDataTrabalho.Name = "lblDataTrabalho";
            this.lblDataTrabalho.Size = new System.Drawing.Size(30, 13);
            this.lblDataTrabalho.TabIndex = 1;
            this.lblDataTrabalho.Text = "Data";
            // 
            // txtNomeTarefa
            // 
            this.txtNomeTarefa.Location = new System.Drawing.Point(71, 51);
            this.txtNomeTarefa.Name = "txtNomeTarefa";
            this.txtNomeTarefa.Size = new System.Drawing.Size(100, 20);
            this.txtNomeTarefa.TabIndex = 4;
            // 
            // mskDataTrabalho
            // 
            this.mskDataTrabalho.Location = new System.Drawing.Point(184, 50);
            this.mskDataTrabalho.Mask = "00/00/0000";
            this.mskDataTrabalho.Name = "mskDataTrabalho";
            this.mskDataTrabalho.Size = new System.Drawing.Size(100, 20);
            this.mskDataTrabalho.TabIndex = 5;
            // 
            // btnResolver
            // 
            this.btnResolver.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResolver.Image = global::WindowsFormsApp1.Properties.Resources.remover__1_;
            this.btnResolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResolver.Location = new System.Drawing.Point(483, 47);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(100, 23);
            this.btnResolver.TabIndex = 3;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.Image = global::WindowsFormsApp1.Properties.Resources.botao_adicionar;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(365, 47);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvTrabalhos
            // 
            this.dgvTrabalhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabalhos.Location = new System.Drawing.Point(12, 125);
            this.dgvTrabalhos.Name = "dgvTrabalhos";
            this.dgvTrabalhos.Size = new System.Drawing.Size(776, 313);
            this.dgvTrabalhos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTrabalhos);
            this.Controls.Add(this.mskDataTrabalho);
            this.Controls.Add(this.txtNomeTarefa);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblDataTrabalho);
            this.Controls.Add(this.lblNomeTarefa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabalhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeTarefa;
        private System.Windows.Forms.Label lblDataTrabalho;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.TextBox txtNomeTarefa;
        private System.Windows.Forms.MaskedTextBox mskDataTrabalho;
        private System.Windows.Forms.DataGridView dgvTrabalhos;
    }
}

