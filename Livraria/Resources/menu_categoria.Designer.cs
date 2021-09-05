
namespace Livraria.Resources
{
    partial class menu_categoria
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
            this.roda_pe_superior = new System.Windows.Forms.Panel();
            this.limpar = new System.Windows.Forms.RadioButton();
            this.Aventura = new System.Windows.Forms.RadioButton();
            this.Ficcao = new System.Windows.Forms.RadioButton();
            this.Acao = new System.Windows.Forms.RadioButton();
            this.Drama = new System.Windows.Forms.RadioButton();
            this.Historia = new System.Windows.Forms.RadioButton();
            this.Guerra = new System.Windows.Forms.RadioButton();
            this.filtro_categoria_livros = new System.Windows.Forms.DataGridView();
            this.em_falta = new System.Windows.Forms.RadioButton();
            this.no_estoque = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.roda_pe_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtro_categoria_livros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Livraria.Properties.Resources.Captura_da_Web_4_8_2021_15150_www_bing10;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.roda_pe_superior);
            this.panel1.Controls.Add(this.filtro_categoria_livros);
            this.panel1.Controls.Add(this.em_falta);
            this.panel1.Controls.Add(this.no_estoque);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 581);
            this.panel1.TabIndex = 0;
            // 
            // roda_pe_superior
            // 
            this.roda_pe_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roda_pe_superior.Controls.Add(this.limpar);
            this.roda_pe_superior.Controls.Add(this.Aventura);
            this.roda_pe_superior.Controls.Add(this.Ficcao);
            this.roda_pe_superior.Controls.Add(this.Acao);
            this.roda_pe_superior.Controls.Add(this.Drama);
            this.roda_pe_superior.Controls.Add(this.Historia);
            this.roda_pe_superior.Controls.Add(this.Guerra);
            this.roda_pe_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.roda_pe_superior.Location = new System.Drawing.Point(0, 0);
            this.roda_pe_superior.Name = "roda_pe_superior";
            this.roda_pe_superior.Size = new System.Drawing.Size(676, 100);
            this.roda_pe_superior.TabIndex = 32;
            // 
            // limpar
            // 
            this.limpar.AutoSize = true;
            this.limpar.BackColor = System.Drawing.Color.Transparent;
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.limpar.Location = new System.Drawing.Point(154, 63);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(77, 22);
            this.limpar.TabIndex = 21;
            this.limpar.TabStop = true;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.CheckedChanged += new System.EventHandler(this.limpar_CheckedChanged);
            // 
            // Aventura
            // 
            this.Aventura.AutoSize = true;
            this.Aventura.BackColor = System.Drawing.Color.Transparent;
            this.Aventura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aventura.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Aventura.Location = new System.Drawing.Point(17, 15);
            this.Aventura.Name = "Aventura";
            this.Aventura.Size = new System.Drawing.Size(91, 22);
            this.Aventura.TabIndex = 15;
            this.Aventura.TabStop = true;
            this.Aventura.Text = "Aventura";
            this.Aventura.UseVisualStyleBackColor = false;
            this.Aventura.CheckedChanged += new System.EventHandler(this.Aventura_CheckedChanged);
            // 
            // Ficcao
            // 
            this.Ficcao.AutoSize = true;
            this.Ficcao.BackColor = System.Drawing.Color.Transparent;
            this.Ficcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ficcao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Ficcao.Location = new System.Drawing.Point(17, 63);
            this.Ficcao.Name = "Ficcao";
            this.Ficcao.Size = new System.Drawing.Size(77, 22);
            this.Ficcao.TabIndex = 20;
            this.Ficcao.TabStop = true;
            this.Ficcao.Text = "Ficção";
            this.Ficcao.UseVisualStyleBackColor = false;
            this.Ficcao.CheckedChanged += new System.EventHandler(this.Ficcao_CheckedChanged);
            // 
            // Acao
            // 
            this.Acao.AutoSize = true;
            this.Acao.BackColor = System.Drawing.Color.Transparent;
            this.Acao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Acao.Location = new System.Drawing.Point(154, 15);
            this.Acao.Name = "Acao";
            this.Acao.Size = new System.Drawing.Size(64, 22);
            this.Acao.TabIndex = 16;
            this.Acao.TabStop = true;
            this.Acao.Text = "Ação";
            this.Acao.UseVisualStyleBackColor = false;
            this.Acao.CheckedChanged += new System.EventHandler(this.Acao_CheckedChanged);
            // 
            // Drama
            // 
            this.Drama.AutoSize = true;
            this.Drama.BackColor = System.Drawing.Color.Transparent;
            this.Drama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drama.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Drama.Location = new System.Drawing.Point(544, 15);
            this.Drama.Name = "Drama";
            this.Drama.Size = new System.Drawing.Size(76, 22);
            this.Drama.TabIndex = 19;
            this.Drama.TabStop = true;
            this.Drama.Text = "Drama";
            this.Drama.UseVisualStyleBackColor = false;
            this.Drama.CheckedChanged += new System.EventHandler(this.Drama_CheckedChanged);
            // 
            // Historia
            // 
            this.Historia.AutoSize = true;
            this.Historia.BackColor = System.Drawing.Color.Transparent;
            this.Historia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Historia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Historia.Location = new System.Drawing.Point(388, 15);
            this.Historia.Name = "Historia";
            this.Historia.Size = new System.Drawing.Size(85, 22);
            this.Historia.TabIndex = 18;
            this.Historia.TabStop = true;
            this.Historia.Text = "História";
            this.Historia.UseVisualStyleBackColor = false;
            this.Historia.CheckedChanged += new System.EventHandler(this.Historia_CheckedChanged);
            // 
            // Guerra
            // 
            this.Guerra.AutoSize = true;
            this.Guerra.BackColor = System.Drawing.Color.Transparent;
            this.Guerra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guerra.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Guerra.Location = new System.Drawing.Point(270, 15);
            this.Guerra.Name = "Guerra";
            this.Guerra.Size = new System.Drawing.Size(78, 22);
            this.Guerra.TabIndex = 17;
            this.Guerra.TabStop = true;
            this.Guerra.Text = "Guerra";
            this.Guerra.UseVisualStyleBackColor = false;
            this.Guerra.CheckedChanged += new System.EventHandler(this.Guerra_CheckedChanged);
            // 
            // filtro_categoria_livros
            // 
            this.filtro_categoria_livros.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.filtro_categoria_livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filtro_categoria_livros.Location = new System.Drawing.Point(0, 231);
            this.filtro_categoria_livros.MultiSelect = false;
            this.filtro_categoria_livros.Name = "filtro_categoria_livros";
            this.filtro_categoria_livros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filtro_categoria_livros.Size = new System.Drawing.Size(540, 350);
            this.filtro_categoria_livros.TabIndex = 31;
            this.filtro_categoria_livros.Visible = false;
            // 
            // em_falta
            // 
            this.em_falta.AutoSize = true;
            this.em_falta.BackColor = System.Drawing.Color.Transparent;
            this.em_falta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.em_falta.Location = new System.Drawing.Point(125, 174);
            this.em_falta.Name = "em_falta";
            this.em_falta.Size = new System.Drawing.Size(86, 22);
            this.em_falta.TabIndex = 27;
            this.em_falta.Text = "em falta";
            this.em_falta.UseVisualStyleBackColor = false;
            // 
            // no_estoque
            // 
            this.no_estoque.AutoSize = true;
            this.no_estoque.BackColor = System.Drawing.Color.Transparent;
            this.no_estoque.Checked = true;
            this.no_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_estoque.Location = new System.Drawing.Point(9, 174);
            this.no_estoque.Name = "no_estoque";
            this.no_estoque.Size = new System.Drawing.Size(110, 22);
            this.no_estoque.TabIndex = 26;
            this.no_estoque.TabStop = true;
            this.no_estoque.Text = "no estoque";
            this.no_estoque.UseVisualStyleBackColor = false;
            // 
            // menu_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "menu_categoria";
            this.Size = new System.Drawing.Size(676, 581);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.roda_pe_superior.ResumeLayout(false);
            this.roda_pe_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtro_categoria_livros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton em_falta;
        private System.Windows.Forms.RadioButton no_estoque;
        private System.Windows.Forms.RadioButton Historia;
        private System.Windows.Forms.RadioButton Aventura;
        private System.Windows.Forms.RadioButton Ficcao;
        private System.Windows.Forms.RadioButton Acao;
        private System.Windows.Forms.RadioButton Drama;
        private System.Windows.Forms.RadioButton Guerra;
        private System.Windows.Forms.Panel roda_pe_superior;
        private System.Windows.Forms.DataGridView filtro_categoria_livros;
        private System.Windows.Forms.RadioButton limpar;
    }
}
