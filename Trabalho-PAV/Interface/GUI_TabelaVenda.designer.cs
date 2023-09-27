namespace TrabalhoPAV.Interface
{
    partial class GUI_TabelaVenda
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancodadospavDataSet1 = new TrabalhoPAV.bancodadospavDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFiltragem = new System.Windows.Forms.TextBox();
            this.buBuscar = new System.Windows.Forms.Button();
            this.buIncluir = new System.Windows.Forms.Button();
            this.buAlterar = new System.Windows.Forms.Button();
            this.buExcluir = new System.Windows.Forms.Button();
            this.buSelecionar = new System.Windows.Forms.Button();
            this.buFechar = new System.Windows.Forms.Button();
            this.vendaTableAdapter = new TrabalhoPAV.bancodadospavDataSet1TableAdapters.vendaTableAdapter();
            this.idVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datahoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalvendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaovendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodadospavDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendaDataGridViewTextBoxColumn,
            this.datahoraDataGridViewTextBoxColumn,
            this.idclienteDataGridViewTextBoxColumn,
            this.totalvendaDataGridViewTextBoxColumn,
            this.situacaovendaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(590, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.bancodadospavDataSet1;
            // 
            // bancodadospavDataSet1
            // 
            this.bancodadospavDataSet1.DataSetName = "bancodadospavDataSet1";
            this.bancodadospavDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtragem:";
            // 
            // tbFiltragem
            // 
            this.tbFiltragem.Location = new System.Drawing.Point(77, 7);
            this.tbFiltragem.Name = "tbFiltragem";
            this.tbFiltragem.Size = new System.Drawing.Size(524, 20);
            this.tbFiltragem.TabIndex = 2;
            // 
            // buBuscar
            // 
            this.buBuscar.Location = new System.Drawing.Point(612, 5);
            this.buBuscar.Name = "buBuscar";
            this.buBuscar.Size = new System.Drawing.Size(75, 23);
            this.buBuscar.TabIndex = 3;
            this.buBuscar.Text = "Buscar";
            this.buBuscar.UseVisualStyleBackColor = true;
            this.buBuscar.Click += new System.EventHandler(this.buBuscar_Click);
            // 
            // buIncluir
            // 
            this.buIncluir.Location = new System.Drawing.Point(615, 42);
            this.buIncluir.Name = "buIncluir";
            this.buIncluir.Size = new System.Drawing.Size(75, 23);
            this.buIncluir.TabIndex = 4;
            this.buIncluir.Text = "Incluir";
            this.buIncluir.UseVisualStyleBackColor = true;
            this.buIncluir.Click += new System.EventHandler(this.buIncluir_Click);
            // 
            // buAlterar
            // 
            this.buAlterar.Location = new System.Drawing.Point(615, 71);
            this.buAlterar.Name = "buAlterar";
            this.buAlterar.Size = new System.Drawing.Size(75, 23);
            this.buAlterar.TabIndex = 5;
            this.buAlterar.Text = "Alterar";
            this.buAlterar.UseVisualStyleBackColor = true;
            this.buAlterar.Click += new System.EventHandler(this.buAlterar_Click);
            // 
            // buExcluir
            // 
            this.buExcluir.Location = new System.Drawing.Point(615, 100);
            this.buExcluir.Name = "buExcluir";
            this.buExcluir.Size = new System.Drawing.Size(75, 23);
            this.buExcluir.TabIndex = 6;
            this.buExcluir.Text = "Excluir";
            this.buExcluir.UseVisualStyleBackColor = true;
            this.buExcluir.Click += new System.EventHandler(this.buExcluir_Click);
            // 
            // buSelecionar
            // 
            this.buSelecionar.Location = new System.Drawing.Point(615, 129);
            this.buSelecionar.Name = "buSelecionar";
            this.buSelecionar.Size = new System.Drawing.Size(75, 23);
            this.buSelecionar.TabIndex = 7;
            this.buSelecionar.Text = "Selecionar";
            this.buSelecionar.UseVisualStyleBackColor = true;
            this.buSelecionar.Click += new System.EventHandler(this.buSelecionar_Click);
            // 
            // buFechar
            // 
            this.buFechar.Location = new System.Drawing.Point(615, 332);
            this.buFechar.Name = "buFechar";
            this.buFechar.Size = new System.Drawing.Size(75, 23);
            this.buFechar.TabIndex = 8;
            this.buFechar.Text = "Fechar";
            this.buFechar.UseVisualStyleBackColor = true;
            this.buFechar.Click += new System.EventHandler(this.buFechar_Click);
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // idVendaDataGridViewTextBoxColumn
            // 
            this.idVendaDataGridViewTextBoxColumn.DataPropertyName = "id_Venda";
            this.idVendaDataGridViewTextBoxColumn.HeaderText = "Codigo:";
            this.idVendaDataGridViewTextBoxColumn.Name = "idVendaDataGridViewTextBoxColumn";
            this.idVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datahoraDataGridViewTextBoxColumn
            // 
            this.datahoraDataGridViewTextBoxColumn.DataPropertyName = "datahora";
            this.datahoraDataGridViewTextBoxColumn.HeaderText = "Data e hora:";
            this.datahoraDataGridViewTextBoxColumn.Name = "datahoraDataGridViewTextBoxColumn";
            this.datahoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "Cliente:";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalvendaDataGridViewTextBoxColumn
            // 
            this.totalvendaDataGridViewTextBoxColumn.DataPropertyName = "total_venda";
            this.totalvendaDataGridViewTextBoxColumn.HeaderText = "Total:";
            this.totalvendaDataGridViewTextBoxColumn.Name = "totalvendaDataGridViewTextBoxColumn";
            this.totalvendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situacaovendaDataGridViewTextBoxColumn
            // 
            this.situacaovendaDataGridViewTextBoxColumn.DataPropertyName = "situacao_venda";
            this.situacaovendaDataGridViewTextBoxColumn.HeaderText = "Situação:";
            this.situacaovendaDataGridViewTextBoxColumn.Name = "situacaovendaDataGridViewTextBoxColumn";
            this.situacaovendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GUI_TabelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 367);
            this.Controls.Add(this.buFechar);
            this.Controls.Add(this.buSelecionar);
            this.Controls.Add(this.buExcluir);
            this.Controls.Add(this.buAlterar);
            this.Controls.Add(this.buIncluir);
            this.Controls.Add(this.buBuscar);
            this.Controls.Add(this.tbFiltragem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUI_TabelaVenda";
            this.Text = "GUI_CadastroVenda";
            this.Load += new System.EventHandler(this.GUI_TabelaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancodadospavDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFiltragem;
        private System.Windows.Forms.Button buBuscar;
        private System.Windows.Forms.Button buIncluir;
        private System.Windows.Forms.Button buAlterar;
        private System.Windows.Forms.Button buExcluir;
        private System.Windows.Forms.Button buSelecionar;
        private System.Windows.Forms.Button buFechar;
        private bancodadospavDataSet1 bancodadospavDataSet1;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private bancodadospavDataSet1TableAdapters.vendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datahoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalvendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaovendaDataGridViewTextBoxColumn;
    }
}