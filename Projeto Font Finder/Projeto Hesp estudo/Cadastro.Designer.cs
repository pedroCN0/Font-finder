namespace Projeto_Hesp_estudo
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.Cads = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cadnome = new System.Windows.Forms.TextBox();
            this.cadsenha = new System.Windows.Forms.TextBox();
            this.cademail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cadrg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cadcpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cads
            // 
            this.Cads.AutoSize = true;
            this.Cads.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cads.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cads.Location = new System.Drawing.Point(187, 79);
            this.Cads.Name = "Cads";
            this.Cads.Size = new System.Drawing.Size(70, 19);
            this.Cads.TabIndex = 3;
            this.Cads.Text = "Cadastro";
            this.Cads.Click += new System.EventHandler(this.tlog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome completo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(41, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(41, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // cadnome
            // 
            this.cadnome.Location = new System.Drawing.Point(184, 152);
            this.cadnome.Name = "cadnome";
            this.cadnome.Size = new System.Drawing.Size(270, 20);
            this.cadnome.TabIndex = 9;
            this.cadnome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // cadsenha
            // 
            this.cadsenha.Location = new System.Drawing.Point(184, 178);
            this.cadsenha.Name = "cadsenha";
            this.cadsenha.Size = new System.Drawing.Size(270, 20);
            this.cadsenha.TabIndex = 11;
            // 
            // cademail
            // 
            this.cademail.Location = new System.Drawing.Point(184, 204);
            this.cademail.Name = "cademail";
            this.cademail.Size = new System.Drawing.Size(270, 20);
            this.cademail.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(184, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cadrg
            // 
            this.cadrg.Location = new System.Drawing.Point(184, 256);
            this.cadrg.Name = "cadrg";
            this.cadrg.Size = new System.Drawing.Size(270, 20);
            this.cadrg.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(44, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "RG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(44, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "CPF";
            // 
            // cadcpf
            // 
            this.cadcpf.Location = new System.Drawing.Point(184, 230);
            this.cadcpf.Name = "cadcpf";
            this.cadcpf.Size = new System.Drawing.Size(270, 20);
            this.cadcpf.TabIndex = 15;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(485, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cadrg);
            this.Controls.Add(this.cadcpf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cademail);
            this.Controls.Add(this.cadsenha);
            this.Controls.Add(this.cadnome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cads);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.Text = "Font Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cadnome;
        private System.Windows.Forms.TextBox cadsenha;
        private System.Windows.Forms.TextBox cademail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cadrg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cadcpf;
    }
}