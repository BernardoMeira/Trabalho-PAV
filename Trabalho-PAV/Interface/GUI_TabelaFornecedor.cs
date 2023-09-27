using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPAV.Controladores;
using TrabalhoPAV.Entidades;

namespace TrabalhoPAV.Interface
{
    public partial class GUI_TabelaFornecedor : Form
    {
        public GUI_TabelaFornecedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buIncluir_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            GUI_CadastroFornecedor GUI_Fornecedor = new GUI_CadastroFornecedor(OperacaoCadastro.ocIncluir, fornecedor);
            GUI_Fornecedor.ShowDialog();
            this.fornecedorTableAdapter.Fill(this.bancodadospavDataSet3.fornecedor);
            dataGridView1.Refresh();
        }

        private void buAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                ControladorCadastroFornecedor controladorCadastroFornecedor = new ControladorCadastroFornecedor();
                Fornecedor fornecedor = new Fornecedor();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int index = Int32.Parse(row.Cells["idFornecedorDataGridViewTextBoxColumn"].Value.ToString());
                fornecedor.alterarIdentificador(index);
                controladorCadastroFornecedor.selecionar(fornecedor);
                GUI_CadastroFornecedor GUI_Fornecedor = new GUI_CadastroFornecedor(OperacaoCadastro.ocAlterar, fornecedor);
                GUI_Fornecedor.ShowDialog();
                this.fornecedorTableAdapter.Fill(this.bancodadospavDataSet3.fornecedor);
                dataGridView1.Refresh();
            }
        }

        private void buExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                ControladorCadastroFornecedor controladorCadastroFornecedor = new ControladorCadastroFornecedor();
                Fornecedor fornecedor = new Fornecedor();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int index = Int32.Parse(row.Cells["idFornecedorDataGridViewTextBoxColumn"].Value.ToString());
                fornecedor.alterarIdentificador(index);
                DialogResult dialogResult = MessageBox.Show("Deseja excluir?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    controladorCadastroFornecedor.excluir(fornecedor);
                    this.fornecedorTableAdapter.Fill(this.bancodadospavDataSet3.fornecedor);
                    dataGridView1.Refresh();
                }
            }
        }

        private void buSelecionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                ControladorCadastroFornecedor controladorCadastroFornecedor = new ControladorCadastroFornecedor();
                Fornecedor fornecedor = new Fornecedor();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int index = Int32.Parse(row.Cells["idFornecedorDataGridViewTextBoxColumn"].Value.ToString());
                fornecedor.alterarIdentificador(index);
                controladorCadastroFornecedor.selecionar(fornecedor);
                GUI_CadastroFornecedor GUI_Fornecedor = new GUI_CadastroFornecedor(OperacaoCadastro.ocConsultar, fornecedor);
                GUI_Fornecedor.ShowDialog();
            }
        }

        private void buFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buBuscar_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.bancodadospavDataSet3.fornecedor);
            dv.RowFilter = string.Format("NOME LIKE '%{0}%'", tbFiltragem.Text);
            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GUI_TabelaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancodadospavDataSet3.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.bancodadospavDataSet3.fornecedor);
            
        }
    }
}
