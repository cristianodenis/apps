
namespace projeto_login.Apresentacao
{
    partial class CadastreSe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cadastrarlogin = new System.Windows.Forms.MaskedTextBox();
            this.cadastrarsenha = new System.Windows.Forms.MaskedTextBox();
            this.confirmarsenha = new System.Windows.Forms.MaskedTextBox();
            this.cadastrar_login_senha = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "confirmar senha";
            // 
            // cadastrarlogin
            // 
            this.cadastrarlogin.Location = new System.Drawing.Point(78, 95);
            this.cadastrarlogin.Name = "cadastrarlogin";
            this.cadastrarlogin.Size = new System.Drawing.Size(148, 20);
            this.cadastrarlogin.TabIndex = 3;
            // 
            // cadastrarsenha
            // 
            this.cadastrarsenha.Location = new System.Drawing.Point(78, 159);
            this.cadastrarsenha.Name = "cadastrarsenha";
            this.cadastrarsenha.PasswordChar = '*';
            this.cadastrarsenha.Size = new System.Drawing.Size(111, 20);
            this.cadastrarsenha.TabIndex = 4;
            // 
            // confirmarsenha
            // 
            this.confirmarsenha.Location = new System.Drawing.Point(78, 228);
            this.confirmarsenha.Name = "confirmarsenha";
            this.confirmarsenha.PasswordChar = '*';
            this.confirmarsenha.Size = new System.Drawing.Size(111, 20);
            this.confirmarsenha.TabIndex = 5;
            // 
            // cadastrar_login_senha
            // 
            this.cadastrar_login_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar_login_senha.Location = new System.Drawing.Point(90, 272);
            this.cadastrar_login_senha.Name = "cadastrar_login_senha";
            this.cadastrar_login_senha.Size = new System.Drawing.Size(85, 23);
            this.cadastrar_login_senha.TabIndex = 6;
            this.cadastrar_login_senha.Text = "cadastrar";
            this.cadastrar_login_senha.UseVisualStyleBackColor = true;
            this.cadastrar_login_senha.Click += new System.EventHandler(this.cadastrar_login_senha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "informe login e senha abaixo";
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cadastrar_login_senha);
            this.Controls.Add(this.confirmarsenha);
            this.Controls.Add(this.cadastrarsenha);
            this.Controls.Add(this.cadastrarlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastreSe";
            this.Text = "CadastreSe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox cadastrarlogin;
        private System.Windows.Forms.MaskedTextBox cadastrarsenha;
        private System.Windows.Forms.MaskedTextBox confirmarsenha;
        private System.Windows.Forms.Button cadastrar_login_senha;
        private System.Windows.Forms.Label label4;
    }
}