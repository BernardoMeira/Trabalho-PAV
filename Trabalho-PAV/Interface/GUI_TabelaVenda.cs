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
    public partial class GUI_TabelaVenda : Form
    {
        public GUI_TabelaVenda()
        {
            InitializeComponent();
        }

        private void GUI_TabelaVenda_Load(object sender, EventArgs e)
        {
            this.vendaTableAdapter.Fill(this.bancodadospavDataSet1.venda);
        }

        private void buIncluir_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            FormaPagamentoVenda formaVenda = new FormaPagamentoVenda();
            GUI_CadastroVenda GUI_Venda = new GUI_CadastroVenda(OperacaoCadastro.ocIncluir, venda, formaVenda);
            GUI_Venda.ShowDialog();
            this.vendaTableAdapter.Fill(this.bancodadospavDataSet1.venda);
            dataGridView1.Refresh();
        }

        private void buAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                ControladorCadastroVenda controladorCadastroVenda = new ControladorCadastroVenda();
                Venda venda = new Venda();
                FormaPagamentoVenda formaVenda = new FormaPagamentoVenda();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int index = Int32.Parse(row.Cells["idVendaDataGridViewTextBoxColumn"].Value.ToString());
                venda.alterarIdentificador(index);
                controladorCadastroVenda.selecionar(venda);
                GUI_CadastroVenda GUI_Venda = new GUI_CadastroVenda(OperacaoCadastro.ocAlterar, venda, formaVenda);
                GUI_Venda.ShowDialog();
                this.vendaTableAdapter.Fill(this.bancodadospavDataSet1.venda);
                dataGridView1.Refresh();
            }
        }

        private void buExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                ControladorCadastroVenda controladorCadastroVenda = new ControladorCadastroVenda();
                Venda venda = new Venda();
                FormaPagamentoVenda formaVenda = new FormaPagamentoVenda();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int index = Int32.Parse(row.Cells["idVendaDataGridViewTextBoxColumn"].Value.ToString());
                venda.alterarIdentificador(index);
                DialogResult dialogResult = MessageBox.Show("Deseja excluir?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    controladorCadastroVenda.excluir(venda);
                    this.vendaTableAdapter.Fill(this.bancodadospavDataSet1.venda);
                    dataGridView1.Refresh();
                }
            }
        }

        private void buSelecionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                ControladorCadastroVenda controladorCadastroVenda = new ControladorCadastroVenda();
                Venda venda = new Venda();
                FormaPagamentoVenda formaVenda = new FormaPagamentoVenda();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int index = Int32.Parse(row.Cells["idVendaDataGridViewTextBoxColumn"].Value.ToString());
                venda.alterarIdentificador(index);
                controladorCadastroVenda.selecionar(venda);
                GUI_CadastroVenda GUI_Venda = new GUI_CadastroVenda(OperacaoCadastro.ocConsultar, venda, formaVenda);
                GUI_Venda.ShowDialog();
            }
        }

        private void buBuscar_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.bancodadospavDataSet1.venda);
            dv.RowFilter = string.Format("DATAHORA LIKE '%{0}%' OR ID_CLIENTE LIKE '%{0}%'", tbFiltragem.Text);
            dataGridView1.DataSource = dv;
        }

        private void buFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
