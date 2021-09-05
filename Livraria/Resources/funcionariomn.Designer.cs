
namespace Livraria.Resources
{
    partial class funcionariomn
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.Label();
            this.nometxt = new System.Windows.Forms.MaskedTextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            this.coletor = new System.Windows.Forms.DataGridView();
            this.txtnome = new System.Windows.Forms.Label();
            this.inativo = new System.Windows.Forms.RadioButton();
            this.senhatxt = new System.Windows.Forms.MaskedTextBox();
            this.btnnovo = new System.Windows.Forms.Button();
            this.ativo = new System.Windows.Forms.RadioButton();
            this.btncancelar = new System.Windows.Forms.Button();
            this.logintxt = new System.Windows.Forms.MaskedTextBox();
            this.status = new System.Windows.Forms.Label();
            this.txtbusca = new System.Windows.Forms.RichTextBox();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.txtcod = new System.Windows.Forms.Label();
            this.messagem_para_usuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coletor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BackgroundImage = global::Livraria.Properties.Resources.Captura_da_Web_4_8_2021_15150_www_bing10;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.messagem_para_usuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtsenha);
            this.panel1.Controls.Add(this.nometxt);
            this.panel1.Controls.Add(this.lblcodigo);
            this.panel1.Controls.Add(this.txtlogin);
            this.panel1.Controls.Add(this.btnalterar);
            this.panel1.Controls.Add(this.coletor);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.inativo);
            this.panel1.Controls.Add(this.senhatxt);
            this.panel1.Controls.Add(this.btnnovo);
            this.panel1.Controls.Add(this.ativo);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Controls.Add(this.logintxt);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.txtbusca);
            this.panel1.Controls.Add(this.btngravar);
            this.panel1.Controls.Add(this.btnremover);
            this.panel1.Controls.Add(this.txtcod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 581);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(31, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Pesquisa:";
            // 
            // txtsenha
            // 
            this.txtsenha.AutoSize = true;
            this.txtsenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtsenha.Location = new System.Drawing.Point(54, 162);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(60, 18);
            this.txtsenha.TabIndex = 8;
            this.txtsenha.Text = "Senha:";
            // 
            // nometxt
            // 
            this.nometxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nometxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nometxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nometxt.ForeColor = System.Drawing.Color.Blue;
            this.nometxt.Location = new System.Drawing.Point(119, 200);
            this.nometxt.MinimumSize = new System.Drawing.Size(60, 2);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(221, 22);
            this.nometxt.TabIndex = 3;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.ForeColor = System.Drawing.Color.Red;
            this.lblcodigo.Location = new System.Drawing.Point(84, 91);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(0, 18);
            this.lblcodigo.TabIndex = 5;
            this.lblcodigo.Visible = false;
            // 
            // txtlogin
            // 
            this.txtlogin.AutoSize = true;
            this.txtlogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtlogin.Location = new System.Drawing.Point(60, 131);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(54, 18);
            this.txtlogin.TabIndex = 7;
            this.txtlogin.Text = "Login:";
            // 
            // btnalterar
            // 
            this.btnalterar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnalterar.FlatAppearance.BorderSize = 2;
            this.btnalterar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnalterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnalterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnalterar.Image = global::Livraria.Properties.Resources.interruptor1;
            this.btnalterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalterar.Location = new System.Drawing.Point(274, 3);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(130, 40);
            this.btnalterar.TabIndex = 3;
            this.btnalterar.Text = "   Alterar";
            this.btnalterar.UseVisualStyleBackColor = false;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // coletor
            // 
            this.coletor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.coletor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coletor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coletor.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.coletor.Location = new System.Drawing.Point(0, 279);
            this.coletor.MultiSelect = false;
            this.coletor.Name = "coletor";
            this.coletor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.coletor.Size = new System.Drawing.Size(540, 300);
            this.coletor.TabIndex = 13;
            this.coletor.Visible = false;
            this.coletor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.coletor_MouseDoubleClick);
            // 
            // txtnome
            // 
            this.txtnome.AutoSize = true;
            this.txtnome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtnome.Location = new System.Drawing.Point(19, 197);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(95, 18);
            this.txtnome.TabIndex = 6;
            this.txtnome.Text = "Nome/func:";
            // 
            // inativo
            // 
            this.inativo.AutoSize = true;
            this.inativo.BackColor = System.Drawing.Color.Transparent;
            this.inativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inativo.Location = new System.Drawing.Point(264, 92);
            this.inativo.Name = "inativo";
            this.inativo.Size = new System.Drawing.Size(75, 22);
            this.inativo.TabIndex = 23;
            this.inativo.Text = "Inativo";
            this.inativo.UseVisualStyleBackColor = false;
            // 
            // senhatxt
            // 
            this.senhatxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.senhatxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhatxt.ForeColor = System.Drawing.Color.Blue;
            this.senhatxt.Location = new System.Drawing.Point(119, 165);
            this.senhatxt.MinimumSize = new System.Drawing.Size(8, 2);
            this.senhatxt.Name = "senhatxt";
            this.senhatxt.Size = new System.Drawing.Size(222, 22);
            this.senhatxt.TabIndex = 9;
            this.senhatxt.UseSystemPasswordChar = true;
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnnovo.FlatAppearance.BorderSize = 2;
            this.btnnovo.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnnovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnnovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnnovo.Image = global::Livraria.Properties.Resources.adicionar1;
            this.btnnovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnovo.Location = new System.Drawing.Point(4, 3);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(130, 40);
            this.btnnovo.TabIndex = 1;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // ativo
            // 
            this.ativo.AutoSize = true;
            this.ativo.BackColor = System.Drawing.Color.Transparent;
            this.ativo.Checked = true;
            this.ativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ativo.Location = new System.Drawing.Point(186, 92);
            this.ativo.Name = "ativo";
            this.ativo.Size = new System.Drawing.Size(63, 22);
            this.ativo.TabIndex = 22;
            this.ativo.TabStop = true;
            this.ativo.Text = "Ativo";
            this.ativo.UseVisualStyleBackColor = false;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btncancelar.FlatAppearance.BorderSize = 2;
            this.btncancelar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btncancelar.Image = global::Livraria.Properties.Resources.cancelar_evento1;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(544, 3);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(130, 40);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "         Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // logintxt
            // 
            this.logintxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logintxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintxt.ForeColor = System.Drawing.Color.Blue;
            this.logintxt.Location = new System.Drawing.Point(120, 134);
            this.logintxt.MinimumSize = new System.Drawing.Size(60, 2);
            this.logintxt.Name = "logintxt";
            this.logintxt.Size = new System.Drawing.Size(221, 22);
            this.logintxt.TabIndex = 10;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.SystemColors.Desktop;
            this.status.Location = new System.Drawing.Point(125, 94);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(61, 18);
            this.status.TabIndex = 21;
            this.status.Text = "Status:";
            // 
            // txtbusca
            // 
            this.txtbusca.BackColor = System.Drawing.Color.White;
            this.txtbusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusca.ForeColor = System.Drawing.Color.Blue;
            this.txtbusca.Location = new System.Drawing.Point(117, 245);
            this.txtbusca.MinimumSize = new System.Drawing.Size(60, 4);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(221, 21);
            this.txtbusca.TabIndex = 19;
            this.txtbusca.Text = "";
            this.txtbusca.TextChanged += new System.EventHandler(this.txtbusca_TextChanged);
            // 
            // btngravar
            // 
            this.btngravar.BackColor = System.Drawing.Color.Gainsboro;
            this.btngravar.FlatAppearance.BorderSize = 2;
            this.btngravar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btngravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btngravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btngravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngravar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btngravar.Image = global::Livraria.Properties.Resources.salvar_pasta1;
            this.btngravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngravar.Location = new System.Drawing.Point(139, 3);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(130, 40);
            this.btngravar.TabIndex = 2;
            this.btngravar.Text = "      Salvar";
            this.btngravar.UseVisualStyleBackColor = false;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.Color.Gainsboro;
            this.btnremover.FlatAppearance.BorderSize = 2;
            this.btnremover.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnremover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnremover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnremover.Image = global::Livraria.Properties.Resources.lixeira1;
            this.btnremover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnremover.Location = new System.Drawing.Point(409, 3);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(130, 40);
            this.btnremover.TabIndex = 4;
            this.btnremover.Text = "       Remover";
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click_1);
            // 
            // txtcod
            // 
            this.txtcod.AutoSize = true;
            this.txtcod.BackColor = System.Drawing.Color.Transparent;
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.ForeColor = System.Drawing.Color.Red;
            this.txtcod.Location = new System.Drawing.Point(19, 92);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(67, 18);
            this.txtcod.TabIndex = 4;
            this.txtcod.Text = "Código:";
            this.txtcod.Visible = false;
            // 
            // messagem_para_usuario
            // 
            this.messagem_para_usuario.AutoSize = true;
            this.messagem_para_usuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.messagem_para_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagem_para_usuario.ForeColor = System.Drawing.Color.Black;
            this.messagem_para_usuario.Location = new System.Drawing.Point(362, 248);
            this.messagem_para_usuario.Name = "messagem_para_usuario";
            this.messagem_para_usuario.Size = new System.Drawing.Size(22, 18);
            this.messagem_para_usuario.TabIndex = 63;
            this.messagem_para_usuario.Text = "%";
            this.messagem_para_usuario.MouseHover += new System.EventHandler(this.messagem_para_usuario_MouseHover);
            // 
            // funcionariomn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.panel1);
            this.Name = "funcionariomn";
            this.Size = new System.Drawing.Size(676, 581);
            this.Load += new System.EventHandler(this.funcionariomenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coletor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox nometxt;
        private System.Windows.Forms.Label txtcod;
        private System.Windows.Forms.Label txtnome;
        private System.Windows.Forms.Label txtlogin;
        private System.Windows.Forms.Label txtsenha;
        private System.Windows.Forms.MaskedTextBox senhatxt;
        private System.Windows.Forms.MaskedTextBox logintxt;
        private System.Windows.Forms.DataGridView coletor;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.RichTextBox txtbusca;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.RadioButton ativo;
        private System.Windows.Forms.RadioButton inativo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label messagem_para_usuario;
    }
}
