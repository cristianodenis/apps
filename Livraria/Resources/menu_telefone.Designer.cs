
namespace Livraria.Resources
{
    partial class menu_telefone
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_busca_tel = new System.Windows.Forms.RichTextBox();
            this.busca_telefones = new System.Windows.Forms.DataGridView();
            this.messagem_para_usuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busca_telefones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BackgroundImage = global::Livraria.Properties.Resources.Captura_da_Web_4_8_2021_15150_www_bing10;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.messagem_para_usuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_busca_tel);
            this.panel1.Controls.Add(this.busca_telefones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 581);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(183, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pesquise por nome do cliente:";
            // 
            // txt_busca_tel
            // 
            this.txt_busca_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busca_tel.ForeColor = System.Drawing.Color.Blue;
            this.txt_busca_tel.Location = new System.Drawing.Point(189, 83);
            this.txt_busca_tel.Name = "txt_busca_tel";
            this.txt_busca_tel.Size = new System.Drawing.Size(240, 21);
            this.txt_busca_tel.TabIndex = 3;
            this.txt_busca_tel.Text = "";
            this.txt_busca_tel.TextChanged += new System.EventHandler(this.txt_busca_tel_TextChanged);
            // 
            // busca_telefones
            // 
            this.busca_telefones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.busca_telefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busca_telefones.Location = new System.Drawing.Point(155, 121);
            this.busca_telefones.MultiSelect = false;
            this.busca_telefones.Name = "busca_telefones";
            this.busca_telefones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.busca_telefones.Size = new System.Drawing.Size(340, 460);
            this.busca_telefones.StandardTab = true;
            this.busca_telefones.TabIndex = 1;
            this.busca_telefones.Visible = false;
            // 
            // messagem_para_usuario
            // 
            this.messagem_para_usuario.AutoSize = true;
            this.messagem_para_usuario.BackColor = System.Drawing.Color.White;
            this.messagem_para_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagem_para_usuario.ForeColor = System.Drawing.Color.Black;
            this.messagem_para_usuario.Location = new System.Drawing.Point(452, 84);
            this.messagem_para_usuario.Name = "messagem_para_usuario";
            this.messagem_para_usuario.Size = new System.Drawing.Size(22, 18);
            this.messagem_para_usuario.TabIndex = 63;
            this.messagem_para_usuario.Text = "%";
            this.messagem_para_usuario.MouseHover += new System.EventHandler(this.messagem_para_usuario_MouseHover);
            // 
            // menu_telefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "menu_telefone";
            this.Size = new System.Drawing.Size(676, 581);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busca_telefones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_busca_tel;
        private System.Windows.Forms.DataGridView busca_telefones;
        private System.Windows.Forms.Label messagem_para_usuario;
    }
}
