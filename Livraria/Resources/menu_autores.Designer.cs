
namespace Livraria.Resources
{
    partial class menu_autores
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
            this.panel_atores = new System.Windows.Forms.Panel();
            this.busca_autores = new System.Windows.Forms.RichTextBox();
            this.tabela_autores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.roda_pe_inferior = new System.Windows.Forms.Panel();
            this.panel_atores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_autores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_atores
            // 
            this.panel_atores.BackgroundImage = global::Livraria.Properties.Resources.Captura_da_Web_4_8_2021_15150_www_bing10;
            this.panel_atores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_atores.Controls.Add(this.roda_pe_inferior);
            this.panel_atores.Controls.Add(this.label1);
            this.panel_atores.Controls.Add(this.tabela_autores);
            this.panel_atores.Controls.Add(this.busca_autores);
            this.panel_atores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_atores.Location = new System.Drawing.Point(0, 0);
            this.panel_atores.Name = "panel_atores";
            this.panel_atores.Size = new System.Drawing.Size(676, 581);
            this.panel_atores.TabIndex = 0;
            // 
            // busca_autores
            // 
            this.busca_autores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca_autores.ForeColor = System.Drawing.Color.Blue;
            this.busca_autores.Location = new System.Drawing.Point(135, 72);
            this.busca_autores.Name = "busca_autores";
            this.busca_autores.Size = new System.Drawing.Size(250, 21);
            this.busca_autores.TabIndex = 0;
            this.busca_autores.Text = "";
            this.busca_autores.TextChanged += new System.EventHandler(this.busca_autores_TextChanged);
            // 
            // tabela_autores
            // 
            this.tabela_autores.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tabela_autores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_autores.Location = new System.Drawing.Point(0, 229);
            this.tabela_autores.MultiSelect = false;
            this.tabela_autores.Name = "tabela_autores";
            this.tabela_autores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela_autores.Size = new System.Drawing.Size(540, 350);
            this.tabela_autores.TabIndex = 1;
            this.tabela_autores.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(164, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquise por nome do autor";
            // 
            // roda_pe_inferior
            // 
            this.roda_pe_inferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roda_pe_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roda_pe_inferior.Location = new System.Drawing.Point(0, 481);
            this.roda_pe_inferior.Name = "roda_pe_inferior";
            this.roda_pe_inferior.Size = new System.Drawing.Size(676, 100);
            this.roda_pe_inferior.TabIndex = 3;
            // 
            // menu_autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_atores);
            this.Name = "menu_autores";
            this.Size = new System.Drawing.Size(676, 581);
            this.panel_atores.ResumeLayout(false);
            this.panel_atores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_autores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_atores;
        private System.Windows.Forms.Panel roda_pe_inferior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabela_autores;
        private System.Windows.Forms.RichTextBox busca_autores;
    }
}
