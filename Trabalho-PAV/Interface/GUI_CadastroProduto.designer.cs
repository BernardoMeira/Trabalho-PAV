namespace TrabalhoPAV.Interface
{
    partial class GUI_CadastroProduto
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.tbCodigoFornecedor = new System.Windows.Forms.TextBox();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.tbUnidade = new System.Windows.Forms.TextBox();
            this.buOk = new System.Windows.Forms.Button();
            this.buCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade em Estoque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código do Fornecedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unidade:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(61, 6);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(455, 20);
            this.tbCodigo.TabIndex = 6;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(61, 46);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(455, 20);
            this.tbNome.TabIndex = 7;
            // 
            // tbQuantidadeEstoque
            // 
            this.tbQuantidadeEstoque.Location = new System.Drawing.Point(142, 93);
            this.tbQuantidadeEstoque.Name = "tbQuantidadeEstoque";
            this.tbQuantidadeEstoque.Size = new System.Drawing.Size(156, 20);
            this.tbQuantidadeEstoque.TabIndex = 8;
            // 
            // tbCodigoFornecedor
            // 
            this.tbCodigoFornecedor.Location = new System.Drawing.Point(142, 136);
            this.tbCodigoFornecedor.Name = "tbCodigoFornecedor";
            this.tbCodigoFornecedor.Size = new System.Drawing.Size(156, 20);
            this.tbCodigoFornecedor.TabIndex = 9;
            // 
            // tbPreco
            // 
            this.tbPreco.Location = new System.Drawing.Point(360, 93);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(156, 20);
            this.tbPreco.TabIndex = 10;
            // 
            // tbUnidade
            // 
            this.tbUnidade.Location = new System.Drawing.Point(360, 136);
            this.tbUnidade.Name = "tbUnidade";
            this.tbUnidade.Size = new System.Drawing.Size(156, 20);
            this.tbUnidade.TabIndex = 11;
            // 
            // buOk
            // 
            this.buOk.Location = new System.Drawing.Point(360, 194);
            this.buOk.Name = "buOk";
            this.buOk.Size = new System.Drawing.Size(75, 23);
            this.buOk.TabIndex = 12;
            this.buOk.Text = "Ok";
            this.buOk.UseVisualStyleBackColor = true;
            this.buOk.Click += new System.EventHandler(this.buOk_Click_1);
            // 
            // buCancelar
            // 
            this.buCancelar.Location = new System.Drawing.Point(441, 194);
            this.buCancelar.Name = "buCancelar";
            this.buCancelar.Size = new System.Drawing.Size(75, 23);
            this.buCancelar.TabIndex = 13;
            this.buCancelar.Text = "Cancelar";
            this.buCancelar.UseVisualStyleBackColor = true;
            this.buCancelar.Click += new System.EventHandler(this.buCancelar_Click_1);
            // 
            // GUI_CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 229);
            this.Controls.Add(this.buCancelar);
            this.Controls.Add(this.buOk);
            this.Controls.Add(this.tbUnidade);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.tbCodigoFornecedor);
            this.Controls.Add(this.tbQuantidadeEstoque);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_CadastroProduto";
            this.Text = "GUI_CadastroProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbQuantidadeEstoque;
        private System.Windows.Forms.TextBox tbCodigoFornecedor;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.TextBox tbUnidade;
        private System.Windows.Forms.Button buOk;
        private System.Windows.Forms.Button buCancelar;
    }
}