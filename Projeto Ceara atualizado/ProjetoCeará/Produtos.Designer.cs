namespace ProjetoCeará
{
    partial class Produtos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btninserirprod = new System.Windows.Forms.Button();
            this.btnexcluirprod = new System.Windows.Forms.Button();
            this.btneditarprod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(330, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUTOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(183, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 256);
            this.dataGridView1.TabIndex = 6;
            // 
            // btninserirprod
            // 
            this.btninserirprod.BackColor = System.Drawing.Color.OrangeRed;
            this.btninserirprod.FlatAppearance.BorderSize = 0;
            this.btninserirprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btninserirprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninserirprod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserirprod.ForeColor = System.Drawing.Color.White;
            this.btninserirprod.Image = ((System.Drawing.Image)(resources.GetObject("btninserirprod.Image")));
            this.btninserirprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninserirprod.Location = new System.Drawing.Point(183, 448);
            this.btninserirprod.Name = "btninserirprod";
            this.btninserirprod.Size = new System.Drawing.Size(107, 45);
            this.btninserirprod.TabIndex = 7;
            this.btninserirprod.Text = "Inserir";
            this.btninserirprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninserirprod.UseVisualStyleBackColor = false;
            this.btninserirprod.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnexcluirprod
            // 
            this.btnexcluirprod.BackColor = System.Drawing.Color.OrangeRed;
            this.btnexcluirprod.FlatAppearance.BorderSize = 0;
            this.btnexcluirprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnexcluirprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcluirprod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluirprod.ForeColor = System.Drawing.Color.White;
            this.btnexcluirprod.Image = ((System.Drawing.Image)(resources.GetObject("btnexcluirprod.Image")));
            this.btnexcluirprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcluirprod.Location = new System.Drawing.Point(479, 448);
            this.btnexcluirprod.Name = "btnexcluirprod";
            this.btnexcluirprod.Size = new System.Drawing.Size(107, 45);
            this.btnexcluirprod.TabIndex = 8;
            this.btnexcluirprod.Text = "Excluir";
            this.btnexcluirprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexcluirprod.UseVisualStyleBackColor = false;
            // 
            // btneditarprod
            // 
            this.btneditarprod.BackColor = System.Drawing.Color.OrangeRed;
            this.btneditarprod.FlatAppearance.BorderSize = 0;
            this.btneditarprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btneditarprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditarprod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditarprod.ForeColor = System.Drawing.Color.White;
            this.btneditarprod.Image = ((System.Drawing.Image)(resources.GetObject("btneditarprod.Image")));
            this.btneditarprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditarprod.Location = new System.Drawing.Point(335, 448);
            this.btneditarprod.Name = "btneditarprod";
            this.btneditarprod.Size = new System.Drawing.Size(107, 45);
            this.btneditarprod.TabIndex = 9;
            this.btneditarprod.Text = "Editar";
            this.btneditarprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditarprod.UseVisualStyleBackColor = false;
            this.btneditarprod.Click += new System.EventHandler(this.btneditarprod_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.btneditarprod);
            this.Controls.Add(this.btnexcluirprod);
            this.Controls.Add(this.btninserirprod);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btninserirprod;
        private System.Windows.Forms.Button btnexcluirprod;
        private System.Windows.Forms.Button btneditarprod;
    }
}