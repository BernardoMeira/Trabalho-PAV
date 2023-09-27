namespace TrabalhoPAV.Interface
{
    partial class GUI_TabelaProduto
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
            this.buBuscar = new System.Windows.Forms.Button();
            this.buIncluir = new System.Windows.Forms.Button();
            this.buAlterar = new System.Windows.Forms.Button();
            this.buExcluir = new System.Windows.Forms.Button();
            this.buSelecionar = new System.Windows.Forms.Button();
            this.buFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFiltragem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bancodadospavDataSet2 = new TrabalhoPAV.bancodadospavDataSet2();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new TrabalhoPAV.bancodadospavDataSet2TableAdapters.produtoTableAdapter();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodadospavDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buBuscar
            // 
            this.buBuscar.Location = new System.Drawing.Point(599, 6);
            this.buBuscar.Name = "buBuscar";
            this.buBuscar.Size = new System.Drawing.Size(75, 23);
            this.buBuscar.TabIndex = 0;
            this.buBuscar.Text = "Buscar";
            this.buBuscar.UseVisualStyleBackColor = true;
            this.buBuscar.Click += new System.EventHandler(this.buBuscar_Click);
            // 
            // buIncluir
            // 
            this.buIncluir.Location = new System.Drawing.Point(599, 43);
            this.buIncluir.Name = "buIncluir";
            this.buIncluir.Size = new System.Drawing.Size(75, 23);
            this.buIncluir.TabIndex = 1;
            this.buIncluir.Text = "Incluir";
            this.buIncluir.UseVisualStyleBackColor = true;
            this.buIncluir.Click += new System.EventHandler(this.buIncluir_Click);
            // 
            // buAlterar
            // 
            this.buAlterar.Location = new System.Drawing.Point(599, 72);
            this.buAlterar.Name = "buAlterar";
            this.buAlterar.Size = new System.Drawing.Size(75, 23);
            this.buAlterar.TabIndex = 2;
            this.buAlterar.Text = "Alterar";
            this.buAlterar.UseVisualStyleBackColor = true;
            this.buAlterar.Click += new System.EventHandler(this.buAlterar_Click);
            // 
            // buExcluir
            // 
            this.buExcluir.Location = new System.Drawing.Point(599, 101);
            this.buExcluir.Name = "buExcluir";
            this.buExcluir.Size = new System.Drawing.Size(75, 23);
            this.buExcluir.TabIndex = 3;
            this.buExcluir.Text = "Excluir";
            this.buExcluir.UseVisualStyleBackColor = true;
            this.buExcluir.Click += new System.EventHandler(this.buExcluir_Click);
            // 
            // buSelecionar
            // 
            this.buSelecionar.Location = new System.Drawing.Point(599, 130);
            this.buSelecionar.Name = "buSelecionar";
            this.buSelecionar.Size = new System.Drawing.Size(75, 23);
            this.buSelecionar.TabIndex = 4;
            this.buSelecionar.Text = "Selecionar";
            this.buSelecionar.UseVisualStyleBackColor = true;
            this.buSelecionar.Click += new System.EventHandler(this.buSelecionar_Click);
            // 
            // buFechar
            // 
            this.buFechar.Location = new System.Drawing.Point(599, 353);
            this.buFechar.Name = "buFechar";
            this.buFechar.Size = new System.Drawing.Size(75, 23);
            this.buFechar.TabIndex = 5;
            this.buFechar.Text = "Fechar";
            this.buFechar.UseVisualStyleBackColor = true;
            this.buFechar.Click += new System.EventHandler(this.buFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtragem:";
            // 
            // tbFiltragem
            // 
            this.tbFiltragem.Location = new System.Drawing.Point(70, 6);
            this.tbFiltragem.Name = "tbFiltragem";
            this.tbFiltragem.Size = new System.Drawing.Size(523, 20);
            this.tbFiltragem.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.quantidadeestoqueDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.idfornecedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(581, 344);
            this.dataGridView1.TabIndex = 8;
            // 
            // bancodadospavDataSet2
            // 
            this.bancodadospavDataSet2.DataSetName = "bancodadospavDataSet2";
            this.bancodadospavDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.bancodadospavDataSet2;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "id_Produto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Codigo:";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome:";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // quantidadeestoqueDataGridViewTextBoxColumn
            // 
            this.quantidadeestoqueDataGridViewTextBoxColumn.DataPropertyName = "quantidade_estoque";
            this.quantidadeestoqueDataGridViewTextBoxColumn.HeaderText = "Estoque:";
            this.quantidadeestoqueDataGridViewTextBoxColumn.Name = "quantidadeestoqueDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço:";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Unidade:";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            // 
            // idfornecedorDataGridViewTextBoxColumn
            // 
            this.idfornecedorDataGridViewTextBoxColumn.DataPropertyName = "id_fornecedor";
            this.idfornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor:";
            this.idfornecedorDataGridViewTextBoxColumn.Name = "idfornecedorDataGridViewTextBoxColumn";
            // 
            // GUI_TabelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 388);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbFiltragem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buFechar);
            this.Controls.Add(this.buSelecionar);
            this.Controls.Add(this.buExcluir);
            this.Controls.Add(this.buAlterar);
            this.Controls.Add(this.buIncluir);
            this.Controls.Add(this.buBuscar);
            this.Name = "GUI_TabelaProduto";
            this.Text = "GUI_TabelaProduto";
            this.Load += new System.EventHandler(this.GUI_TabelaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodadospavDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buBuscar;
        private System.Windows.Forms.Button buIncluir;
        private System.Windows.Forms.Button buAlterar;
        private System.Windows.Forms.Button buExcluir;
        private System.Windows.Forms.Button buSelecionar;
        private System.Windows.Forms.Button buFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFiltragem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bancodadospavDataSet2 bancodadospavDataSet2;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private bancodadospavDataSet2TableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfornecedorDataGridViewTextBoxColumn;
    }
}