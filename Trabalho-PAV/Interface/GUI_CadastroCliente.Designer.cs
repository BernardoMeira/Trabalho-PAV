
namespace TrabalhoPAV.Interface
{
    partial class GUI_CadastroCliente
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
            this.buOk = new System.Windows.Forms.Button();
            this.buCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCPF_CNPJ = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textCEP = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.textComplemento = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.textLogradouro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buOk
            // 
            this.buOk.Location = new System.Drawing.Point(421, 296);
            this.buOk.Name = "buOk";
            this.buOk.Size = new System.Drawing.Size(75, 23);
            this.buOk.TabIndex = 0;
            this.buOk.Text = "Ok";
            this.buOk.UseVisualStyleBackColor = true;
            this.buOk.Click += new System.EventHandler(this.buOk_Click);
            // 
            // buCancelar
            // 
            this.buCancelar.Location = new System.Drawing.Point(502, 296);
            this.buCancelar.Name = "buCancelar";
            this.buCancelar.Size = new System.Drawing.Size(75, 23);
            this.buCancelar.TabIndex = 1;
            this.buCancelar.Text = "Cancelar";
            this.buCancelar.UseVisualStyleBackColor = true;
            this.buCancelar.Click += new System.EventHandler(this.buCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo:";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(80, 16);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(497, 20);
            this.textCodigo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF/CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Complemento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bairro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "CEP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Telefone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Email:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(80, 52);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(497, 20);
            this.textNome.TabIndex = 14;
            // 
            // textCPF_CNPJ
            // 
            this.textCPF_CNPJ.Location = new System.Drawing.Point(80, 86);
            this.textCPF_CNPJ.Name = "textCPF_CNPJ";
            this.textCPF_CNPJ.Size = new System.Drawing.Size(497, 20);
            this.textCPF_CNPJ.TabIndex = 15;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(80, 119);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(497, 20);
            this.textTelefone.TabIndex = 16;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(80, 156);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(497, 20);
            this.textEmail.TabIndex = 17;
            // 
            // textCEP
            // 
            this.textCEP.Location = new System.Drawing.Point(80, 189);
            this.textCEP.Name = "textCEP";
            this.textCEP.Size = new System.Drawing.Size(194, 20);
            this.textCEP.TabIndex = 18;
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(80, 221);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(194, 20);
            this.textCidade.TabIndex = 19;
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(80, 255);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(194, 20);
            this.textEstado.TabIndex = 20;
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(383, 189);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(194, 20);
            this.textNumero.TabIndex = 21;
            // 
            // textBairro
            // 
            this.textBairro.Location = new System.Drawing.Point(383, 218);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(194, 20);
            this.textBairro.TabIndex = 22;
            // 
            // textComplemento
            // 
            this.textComplemento.Location = new System.Drawing.Point(383, 251);
            this.textComplemento.Name = "textComplemento";
            this.textComplemento.Size = new System.Drawing.Size(194, 20);
            this.textComplemento.TabIndex = 23;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(16, 296);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(64, 13);
            this.lab.TabIndex = 24;
            this.lab.Text = "Logradouro:";
            // 
            // textLogradouro
            // 
            this.textLogradouro.Location = new System.Drawing.Point(80, 293);
            this.textLogradouro.Name = "textLogradouro";
            this.textLogradouro.Size = new System.Drawing.Size(194, 20);
            this.textLogradouro.TabIndex = 25;
            // 
            // GUI_CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 329);
            this.Controls.Add(this.textLogradouro);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.textComplemento);
            this.Controls.Add(this.textBairro);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.textCEP);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textCPF_CNPJ);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buCancelar);
            this.Controls.Add(this.buOk);
            this.Name = "GUI_CadastroCliente";
            this.Text = "GUI_CadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buOk;
        private System.Windows.Forms.Button buCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textCPF_CNPJ;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textCEP;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.TextBox textComplemento;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox textLogradouro;
    }
}