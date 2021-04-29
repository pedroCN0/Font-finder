namespace Projeto_Hesp_estudo
{
    partial class Grids
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grids));
            this.site = new System.Windows.Forms.DataGridView();
            this.usuário = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.site)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuário)).BeginInit();
            this.SuspendLayout();
            // 
            // site
            // 
            this.site.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.site.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.site.Location = new System.Drawing.Point(161, 58);
            this.site.Name = "site";
            this.site.Size = new System.Drawing.Size(240, 336);
            this.site.TabIndex = 3;
            this.site.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.site_CellClick);
            this.site.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.site_CellContentClick);
            // 
            // usuário
            // 
            this.usuário.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.usuário.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuário.Location = new System.Drawing.Point(554, 58);
            this.usuário.Name = "usuário";
            this.usuário.Size = new System.Drawing.Size(240, 336);
            this.usuário.TabIndex = 4;
            this.usuário.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuário_CellClick);
            this.usuário.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuário_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(346, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informações Cadastradas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Grids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(932, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuário);
            this.Controls.Add(this.site);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Grids";
            this.Text = "Font Finder";
            this.Load += new System.EventHandler(this.Grids_Load);
            ((System.ComponentModel.ISupportInitialize)(this.site)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuário)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView site;
        private System.Windows.Forms.DataGridView usuário;
        private System.Windows.Forms.Label label1;
    }
}