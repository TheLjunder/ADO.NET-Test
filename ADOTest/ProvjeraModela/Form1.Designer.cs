namespace ProvjeraModela
{
    partial class Form1
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
            this.dataGridViewZaposleniciNaProjektu = new System.Windows.Forms.DataGridView();
            this.dataGridViewRezervacije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewProjekti = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposleniciNaProjektu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjekti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZaposleniciNaProjektu
            // 
            this.dataGridViewZaposleniciNaProjektu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZaposleniciNaProjektu.Location = new System.Drawing.Point(545, 28);
            this.dataGridViewZaposleniciNaProjektu.Name = "dataGridViewZaposleniciNaProjektu";
            this.dataGridViewZaposleniciNaProjektu.Size = new System.Drawing.Size(330, 412);
            this.dataGridViewZaposleniciNaProjektu.TabIndex = 0;
            // 
            // dataGridViewRezervacije
            // 
            this.dataGridViewRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervacije.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewRezervacije.Name = "dataGridViewRezervacije";
            this.dataGridViewRezervacije.Size = new System.Drawing.Size(527, 412);
            this.dataGridViewRezervacije.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista svih rezervacija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista svih zaposlenika po projektima";
            // 
            // dataGridViewProjekti
            // 
            this.dataGridViewProjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjekti.Location = new System.Drawing.Point(881, 28);
            this.dataGridViewProjekti.Name = "dataGridViewProjekti";
            this.dataGridViewProjekti.Size = new System.Drawing.Size(284, 412);
            this.dataGridViewProjekti.TabIndex = 4;
            this.dataGridViewProjekti.SelectionChanged += new System.EventHandler(this.dataGridViewProjekti_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(881, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista svih projekata";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 721);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewProjekti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRezervacije);
            this.Controls.Add(this.dataGridViewZaposleniciNaProjektu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposleniciNaProjektu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjekti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZaposleniciNaProjektu;
        private System.Windows.Forms.DataGridView dataGridViewRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewProjekti;
        private System.Windows.Forms.Label label3;
    }
}

