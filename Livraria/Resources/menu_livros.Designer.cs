
namespace Livraria.Resources
{
    partial class menu_livros
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
            this.panel_menu_livros = new System.Windows.Forms.Panel();
            this.tabela_livros = new System.Windows.Forms.DataGridView();
            this.codigo_livros = new System.Windows.Forms.Label();
            this.label_livros = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quantidade_livros = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nome_autor = new System.Windows.Forms.MaskedTextBox();
            this.categoria_livro = new System.Windows.Forms.MaskedTextBox();
            this.nome_livro = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.em_falta = new System.Windows.Forms.RadioButton();
            this.no_estoque = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.busca_livros = new System.Windows.Forms.RichTextBox();
            this.btn_alterar_cliente = new System.Windows.Forms.Button();
            this.btn_cancelar_cliente = new System.Windows.Forms.Button();
            this.btn_novo_cliente = new System.Windows.Forms.Button();
            this.btn_remover_cliente = new System.Windows.Forms.Button();
            this.btn_salvar_cliente = new System.Windows.Forms.Button();
            this.messagem_para_usuario = new System.Windows.Forms.Label();
            this.panel_menu_livros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_livros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu_livros
            // 
            this.panel_menu_livros.BackgroundImage = global::Livraria.Properties.Resources.Captura_da_Web_4_8_2021_15150_www_bing10;
            this.panel_menu_livros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_menu_livros.Controls.Add(this.messagem_para_usuario);
            this.panel_menu_livros.Controls.Add(this.tabela_livros);
            this.panel_menu_livros.Controls.Add(this.codigo_livros);
            this.panel_menu_livros.Controls.Add(this.label_livros);
            this.panel_menu_livros.Controls.Add(this.groupBox1);
            this.panel_menu_livros.Controls.Add(this.em_falta);
            this.panel_menu_livros.Controls.Add(this.no_estoque);
            this.panel_menu_livros.Controls.Add(this.label1);
            this.panel_menu_livros.Controls.Add(this.busca_livros);
            this.panel_menu_livros.Controls.Add(this.btn_alterar_cliente);
            this.panel_menu_livros.Controls.Add(this.btn_cancelar_cliente);
            this.panel_menu_livros.Controls.Add(this.btn_novo_cliente);
            this.panel_menu_livros.Controls.Add(this.btn_remover_cliente);
            this.panel_menu_livros.Controls.Add(this.btn_salvar_cliente);
            this.panel_menu_livros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_menu_livros.Location = new System.Drawing.Point(0, 0);
            this.panel_menu_livros.Name = "panel_menu_livros";
            this.panel_menu_livros.Size = new System.Drawing.Size(676, 581);
            this.panel_menu_livros.TabIndex = 0;
            // 
            // tabela_livros
            // 
            this.tabela_livros.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tabela_livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_livros.Location = new System.Drawing.Point(0, 331);
            this.tabela_livros.MultiSelect = false;
            this.tabela_livros.Name = "tabela_livros";
            this.tabela_livros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela_livros.Size = new System.Drawing.Size(543, 250);
            this.tabela_livros.TabIndex = 38;
            this.tabela_livros.Visible = false;
            this.tabela_livros.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabela_livros_MouseDoubleClick_1);
            // 
            // codigo_livros
            // 
            this.codigo_livros.AutoSize = true;
            this.codigo_livros.BackColor = System.Drawing.Color.Transparent;
            this.codigo_livros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_livros.ForeColor = System.Drawing.Color.Red;
            this.codigo_livros.Location = new System.Drawing.Point(89, 82);
            this.codigo_livros.Name = "codigo_livros";
            this.codigo_livros.Size = new System.Drawing.Size(0, 18);
            this.codigo_livros.TabIndex = 37;
            this.codigo_livros.Visible = false;
            // 
            // label_livros
            // 
            this.label_livros.AutoSize = true;
            this.label_livros.BackColor = System.Drawing.Color.Transparent;
            this.label_livros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_livros.ForeColor = System.Drawing.Color.Red;
            this.label_livros.Location = new System.Drawing.Point(24, 82);
            this.label_livros.Name = "label_livros";
            this.label_livros.Size = new System.Drawing.Size(67, 18);
            this.label_livros.TabIndex = 36;
            this.label_livros.Text = "Código:";
            this.label_livros.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.quantidade_livros);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nome_autor);
            this.groupBox1.Controls.Add(this.categoria_livro);
            this.groupBox1.Controls.Add(this.nome_livro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 150);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // quantidade_livros
            // 
            this.quantidade_livros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.quantidade_livros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidade_livros.ForeColor = System.Drawing.Color.Blue;
            this.quantidade_livros.Location = new System.Drawing.Point(105, 118);
            this.quantidade_livros.Name = "quantidade_livros";
            this.quantidade_livros.Size = new System.Drawing.Size(215, 22);
            this.quantidade_livros.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quantidade:";
            // 
            // nome_autor
            // 
            this.nome_autor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nome_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_autor.ForeColor = System.Drawing.Color.Blue;
            this.nome_autor.Location = new System.Drawing.Point(105, 57);
            this.nome_autor.Name = "nome_autor";
            this.nome_autor.Size = new System.Drawing.Size(215, 22);
            this.nome_autor.TabIndex = 18;
            // 
            // categoria_livro
            // 
            this.categoria_livro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categoria_livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria_livro.ForeColor = System.Drawing.Color.Blue;
            this.categoria_livro.Location = new System.Drawing.Point(105, 83);
            this.categoria_livro.Name = "categoria_livro";
            this.categoria_livro.Size = new System.Drawing.Size(215, 22);
            this.categoria_livro.TabIndex = 20;
            // 
            // nome_livro
            // 
            this.nome_livro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nome_livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_livro.ForeColor = System.Drawing.Color.Blue;
            this.nome_livro.Location = new System.Drawing.Point(105, 28);
            this.nome_livro.Name = "nome_livro";
            this.nome_livro.Size = new System.Drawing.Size(215, 22);
            this.nome_livro.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Livro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Autor:";
            // 
            // em_falta
            // 
            this.em_falta.AutoSize = true;
            this.em_falta.BackColor = System.Drawing.Color.Transparent;
            this.em_falta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.em_falta.Location = new System.Drawing.Point(266, 82);
            this.em_falta.Name = "em_falta";
            this.em_falta.Size = new System.Drawing.Size(86, 22);
            this.em_falta.TabIndex = 15;
            this.em_falta.Text = "em falta";
            this.em_falta.UseVisualStyleBackColor = false;
            // 
            // no_estoque
            // 
            this.no_estoque.AutoSize = true;
            this.no_estoque.BackColor = System.Drawing.Color.Transparent;
            this.no_estoque.Checked = true;
            this.no_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_estoque.Location = new System.Drawing.Point(144, 82);
            this.no_estoque.Name = "no_estoque";
            this.no_estoque.Size = new System.Drawing.Size(110, 22);
            this.no_estoque.TabIndex = 14;
            this.no_estoque.TabStop = true;
            this.no_estoque.Text = "no estoque";
            this.no_estoque.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(154, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Livros Disponiveis";
            // 
            // busca_livros
            // 
            this.busca_livros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca_livros.ForeColor = System.Drawing.Color.Blue;
            this.busca_livros.Location = new System.Drawing.Point(112, 305);
            this.busca_livros.Name = "busca_livros";
            this.busca_livros.Size = new System.Drawing.Size(240, 21);
            this.busca_livros.TabIndex = 11;
            this.busca_livros.Text = "";
            this.busca_livros.TextChanged += new System.EventHandler(this.busca_livros_TextChanged);
            // 
            // btn_alterar_cliente
            // 
            this.btn_alterar_cliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_alterar_cliente.FlatAppearance.BorderSize = 2;
            this.btn_alterar_cliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_alterar_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_alterar_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_alterar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar_cliente.ForeColor = System.Drawing.Color.Black;
            this.btn_alterar_cliente.Image = global::Livraria.Properties.Resources.interruptor2;
            this.btn_alterar_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar_cliente.Location = new System.Drawing.Point(272, 3);
            this.btn_alterar_cliente.Name = "btn_alterar_cliente";
            this.btn_alterar_cliente.Size = new System.Drawing.Size(130, 40);
            this.btn_alterar_cliente.TabIndex = 7;
            this.btn_alterar_cliente.Text = "Alterar";
            this.btn_alterar_cliente.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar_cliente
            // 
            this.btn_cancelar_cliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cancelar_cliente.FlatAppearance.BorderSize = 2;
            this.btn_cancelar_cliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_cancelar_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cancelar_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_cliente.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar_cliente.Image = global::Livraria.Properties.Resources.cancelar_evento2;
            this.btn_cancelar_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar_cliente.Location = new System.Drawing.Point(544, 3);
            this.btn_cancelar_cliente.Name = "btn_cancelar_cliente";
            this.btn_cancelar_cliente.Size = new System.Drawing.Size(130, 40);
            this.btn_cancelar_cliente.TabIndex = 9;
            this.btn_cancelar_cliente.Text = "Cancelar";
            this.btn_cancelar_cliente.UseVisualStyleBackColor = false;
            // 
            // btn_novo_cliente
            // 
            this.btn_novo_cliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_novo_cliente.FlatAppearance.BorderSize = 2;
            this.btn_novo_cliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_novo_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_novo_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_novo_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo_cliente.ForeColor = System.Drawing.Color.Black;
            this.btn_novo_cliente.Image = global::Livraria.Properties.Resources.adicionar2;
            this.btn_novo_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo_cliente.Location = new System.Drawing.Point(1, 3);
            this.btn_novo_cliente.Name = "btn_novo_cliente";
            this.btn_novo_cliente.Size = new System.Drawing.Size(130, 40);
            this.btn_novo_cliente.TabIndex = 5;
            this.btn_novo_cliente.Text = "Novo";
            this.btn_novo_cliente.UseVisualStyleBackColor = false;
            // 
            // btn_remover_cliente
            // 
            this.btn_remover_cliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_remover_cliente.FlatAppearance.BorderSize = 2;
            this.btn_remover_cliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_remover_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_remover_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_remover_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover_cliente.ForeColor = System.Drawing.Color.Black;
            this.btn_remover_cliente.Image = global::Livraria.Properties.Resources.lixeira2;
            this.btn_remover_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remover_cliente.Location = new System.Drawing.Point(408, 3);
            this.btn_remover_cliente.Name = "btn_remover_cliente";
            this.btn_remover_cliente.Size = new System.Drawing.Size(130, 40);
            this.btn_remover_cliente.TabIndex = 8;
            this.btn_remover_cliente.Text = "Remover";
            this.btn_remover_cliente.UseVisualStyleBackColor = false;
            // 
            // btn_salvar_cliente
            // 
            this.btn_salvar_cliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_salvar_cliente.FlatAppearance.BorderSize = 2;
            this.btn_salvar_cliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_salvar_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_salvar_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_salvar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar_cliente.ForeColor = System.Drawing.Color.Black;
            this.btn_salvar_cliente.Image = global::Livraria.Properties.Resources.salvar_pasta2;
            this.btn_salvar_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salvar_cliente.Location = new System.Drawing.Point(136, 3);
            this.btn_salvar_cliente.Name = "btn_salvar_cliente";
            this.btn_salvar_cliente.Size = new System.Drawing.Size(130, 40);
            this.btn_salvar_cliente.TabIndex = 6;
            this.btn_salvar_cliente.Text = "Salvar";
            this.btn_salvar_cliente.UseVisualStyleBackColor = false;
            this.btn_salvar_cliente.Click += new System.EventHandler(this.btn_salvar_cliente_Click);
            // 
            // messagem_para_usuario
            // 
            this.messagem_para_usuario.AutoSize = true;
            this.messagem_para_usuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.messagem_para_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagem_para_usuario.ForeColor = System.Drawing.Color.Black;
            this.messagem_para_usuario.Location = new System.Drawing.Point(376, 306);
            this.messagem_para_usuario.Name = "messagem_para_usuario";
            this.messagem_para_usuario.Size = new System.Drawing.Size(22, 18);
            this.messagem_para_usuario.TabIndex = 63;
            this.messagem_para_usuario.Text = "%";
            this.messagem_para_usuario.MouseHover += new System.EventHandler(this.messagem_para_usuario_MouseHover);
            // 
            // menu_livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_menu_livros);
            this.Name = "menu_livros";
            this.Size = new System.Drawing.Size(676, 581);
            this.panel_menu_livros.ResumeLayout(false);
            this.panel_menu_livros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_livros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu_livros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox nome_autor;
        private System.Windows.Forms.MaskedTextBox categoria_livro;
        private System.Windows.Forms.MaskedTextBox nome_livro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton em_falta;
        private System.Windows.Forms.RadioButton no_estoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox busca_livros;
        private System.Windows.Forms.Button btn_alterar_cliente;
        private System.Windows.Forms.Button btn_cancelar_cliente;
        private System.Windows.Forms.Button btn_novo_cliente;
        private System.Windows.Forms.Button btn_remover_cliente;
        private System.Windows.Forms.Button btn_salvar_cliente;
        private System.Windows.Forms.MaskedTextBox quantidade_livros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label codigo_livros;
        private System.Windows.Forms.Label label_livros;
        private System.Windows.Forms.DataGridView tabela_livros;
        private System.Windows.Forms.Label messagem_para_usuario;
    }
}
