namespace Projeto_Hesp_estudo
{
    partial class busca_link
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(busca_link));
            this.tbbusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvpesquisa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // tbbusca
            // 
            this.tbbusca.Location = new System.Drawing.Point(265, 68);
            this.tbbusca.Name = "tbbusca";
            this.tbbusca.Size = new System.Drawing.Size(523, 20);
            this.tbbusca.TabIndex = 2;
            this.tbbusca.TextChanged += new System.EventHandler(this.tblink_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(282, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite abaixo o nome do site que deseja investigar";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.result.Location = new System.Drawing.Point(479, 145);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(106, 24);
            this.result.TabIndex = 4;
            this.result.Text = "Resultado:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Ivory;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(483, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvpesquisa
            // 
            this.dgvpesquisa.AllowUserToAddRows = false;
            this.dgvpesquisa.AllowUserToDeleteRows = false;
            this.dgvpesquisa.AllowUserToResizeColumns = false;
            this.dgvpesquisa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpesquisa.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpesquisa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvpesquisa.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvpesquisa.Location = new System.Drawing.Point(12, 194);
            this.dgvpesquisa.Name = "dgvpesquisa";
            this.dgvpesquisa.RowHeadersWidth = 50;
            this.dgvpesquisa.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dgvpesquisa.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvpesquisa.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvpesquisa.RowTemplate.Height = 30;
            this.dgvpesquisa.Size = new System.Drawing.Size(1041, 148);
            this.dgvpesquisa.TabIndex = 9;
            this.dgvpesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpesquisa_CellContentClick);
            // 
            // busca_link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1065, 481);
            this.Controls.Add(this.dgvpesquisa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbbusca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "busca_link";
            this.Text = "Font Finder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbbusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvpesquisa;
    }
}