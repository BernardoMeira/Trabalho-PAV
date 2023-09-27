namespace TrabalhoPAV.Interface
{
    partial class GUI_CadastroVenda
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbCodigoCliente = new System.Windows.Forms.TextBox();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.buCancelar = new System.Windows.Forms.Button();
            this.buOk = new System.Windows.Forms.Button();
            this.tbDataHora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.itemvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancodadospavDataSet6 = new TrabalhoPAV.bancodadospavDataSet6();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancodadospavDataSet5 = new TrabalhoPAV.bancodadospavDataSet5();
            this.label6 = new System.Windows.Forms.Label();
            this.buAdicionar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.produtoTableAdapter = new TrabalhoPAV.bancodadospavDataSet4TableAdapters.produtoTableAdapter();
            this.produtoTableAdapter1 = new TrabalhoPAV.bancodadospavDataSet5TableAdapters.produtoTableAdapter();
            this.itemvendaTableAdapter = new TrabalhoPAV.bancodadospavDataSet6TableAdapters.itemvendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.itemvendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodadospavDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodadospavDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data e hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código do Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Total:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(90, 12);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(102, 20);
            this.tbCodigo.TabIndex = 4;
            // 
            // tbCodigoCliente
            // 
            this.tbCodigoCliente.Location = new System.Drawing.Point(327, 12);
            this.tbCodigoCliente.Name = "tbCodigoCliente";
            this.tbCodigoCliente.Size = new System.Drawing.Size(94, 20);
            this.tbCodigoCliente.TabIndex = 6;
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Location = new System.Drawing.Point(327, 43);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.Size = new System.Drawing.Size(94, 20);
            this.tbValorTotal.TabIndex = 7;
            // 
            // buCancelar
            // 
            this.buCancelar.Location = new System.Drawing.Point(598, 313);
            this.buCancelar.Name = "buCancelar";
            this.buCancelar.Size = new System.Drawing.Size(75, 23);
            this.buCancelar.TabIndex = 8;
            this.buCancelar.Text = "Cancelar";
            this.buCancelar.UseVisualStyleBackColor = true;
            this.buCancelar.Click += new System.EventHandler(this.buCancelar_Click_1);
            // 
            // buOk
            // 
            this.buOk.Location = new System.Drawing.Point(598, 284);
            this.buOk.Name = "buOk";
            this.buOk.Size = new System.Drawing.Size(75, 23);
            this.buOk.TabIndex = 9;
            this.buOk.Text = "Ok";
            this.buOk.UseVisualStyleBackColor = true;
            this.buOk.Click += new System.EventHandler(this.buOk_Click);
            // 
            // tbDataHora
            // 
            this.tbDataHora.Location = new System.Drawing.Point(90, 43);
            this.tbDataHora.Name = "tbDataHora";
            this.tbDataHora.Size = new System.Drawing.Size(102, 20);
            this.tbDataHora.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Forma de Pagamento:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemvendaBindingSource, "id_Venda", true));
            this.comboBox1.DataSource = this.produtoBindingSource;
            this.comboBox1.DisplayMember = "nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(331, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "id_Produto";
            // 
            // itemvendaBindingSource
            // 
            this.itemvendaBindingSource.DataMember = "itemvenda";
            this.itemvendaBindingSource.DataSource = this.bancodadospavDataSet6;
            // 
            // bancodadospavDataSet6
            // 
            this.bancodadospavDataSet6.DataSetName = "bancodadospavDataSet6";
            this.bancodadospavDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.bancodadospavDataSet5;
            // 
            // bancodadospavDataSet5
            // 
            this.bancodadospavDataSet5.DataSetName = "bancodadospavDataSet5";
            this.bancodadospavDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Produto:";
            // 
            // buAdicionar
            // 
            this.buAdicionar.Location = new System.Drawing.Point(598, 80);
            this.buAdicionar.Name = "buAdicionar";
            this.buAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buAdicionar.TabIndex = 14;
            this.buAdicionar.Text = "Adicionar";
            this.buAdicionar.UseVisualStyleBackColor = true;
            this.buAdicionar.Click += new System.EventHandler(this.buAdicionar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Quantidade:";
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(498, 82);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(94, 20);
            this.textQuantidade.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(577, 221);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cartão de Credito";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(141, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dinheiro";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(430, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 45);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter1
            // 
            this.produtoTableAdapter1.ClearBeforeFill = true;
            // 
            // itemvendaTableAdapter
            // 
            this.itemvendaTableAdapter.ClearBeforeFill = true;
            // 
            // GUI_CadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buAdicionar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDataHora);
            this.Controls.Add(this.buOk);
            this.Controls.Add(this.buCancelar);
            this.Controls.Add(this.tbValorTotal);
            this.Controls.Add(this.tbCodigoCliente);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_CadastroVenda";
            this.Text = "GUI_TabelaVenda";
            this.Load += new System.EventHandler(this.GUI_CadastroVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemvendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodadospavDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodadospavDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbCodigoCliente;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.Button buCancelar;
        private System.Windows.Forms.Button buOk;
        private System.Windows.Forms.TextBox tbDataHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buAdicionar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private bancodadospavDataSet4TableAdapters.produtoTableAdapter produtoTableAdapter;
        private bancodadospavDataSet5 bancodadospavDataSet5;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private bancodadospavDataSet5TableAdapters.produtoTableAdapter produtoTableAdapter1;
        private bancodadospavDataSet6 bancodadospavDataSet6;
        private System.Windows.Forms.BindingSource itemvendaBindingSource;
        private bancodadospavDataSet6TableAdapters.itemvendaTableAdapter itemvendaTableAdapter;
    }
}