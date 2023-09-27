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
    public partial class GUI_TabelaCliente : Form
    {
        public GUI_TabelaCliente()
        {
            InitializeComponent();
        }


        private void buIncluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            GUI_CadastroCliente GUI_Cliente = new GUI_CadastroCliente(OperacaoCadastro.ocIncluir, cliente);
            GUI_Cliente.ShowDialog();
            this.clienteTableAdapter2.Fill(this.bancodadospavDataSet.cliente);
            dataGridView1.Refresh();
        }

        private void buAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                ControladorCadastroCliente controladorCadastroCliente = new ControladorCadastroCliente();
                Cliente cliente = new Cliente();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int index = Int32.Parse(row.Cells["idClienteDataGridViewTextBoxColumn"].Value.ToString());
                cliente.alterarIdentificador(index);
                controladorCadastroCliente.selecionar(cliente);
                GUI_CadastroCliente GUI_Cliente = new GUI_CadastroCliente(OperacaoCadastro.ocAlterar, cliente);
                GUI_Cliente.ShowDialog();
                this.clienteTableAdapter2.Fill(this.bancodadospavDataSet.cliente);
                dataGridView1.Refresh();
            }
        }

        private void buExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                ControladorCadastroCliente controladorCadastroCliente = new ControladorCadastroCliente();
                Cliente cliente = new Cliente();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int index = Int32.Parse(row.Cells["idClienteDataGridViewTextBoxColumn"].Value.ToString());
                cliente.alterarIdentificador(index);
                DialogResult dialogResult = MessageBox.Show("Deseja excluir?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    controladorCadastroCliente.excluir(cliente);
                    this.clienteTableAdapter2.Fill(this.bancodadospavDataSet.cliente);
                    dataGridView1.Refresh();
                }
            }
        }

        private void buBuscar_Click(object sender, EventArgs e) 
        {
            DataView dv = new DataView(this.bancodadospavDataSet.cliente);
            dv.RowFilter = string.Format("NOME LIKE '%{0}%'", tbFiltragem.Text);
            dataGridView1.DataSource = dv;
        }

        private void buSelecionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                ControladorCadastroCliente controladorCadastroCliente = new ControladorCadastroCliente();
                Cliente cliente = new Cliente();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int index = Int32.Parse(row.Cells["idClienteDataGridViewTextBoxColumn"].Value.ToString());
                cliente.alterarIdentificador(index);
                controladorCadastroCliente.selecionar(cliente);
                GUI_CadastroCliente GUI_Cliente = new GUI_CadastroCliente(OperacaoCadastro.ocConsultar, cliente);
                GUI_Cliente.ShowDialog();
            }
        }

        private void GUI_TabelaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancodadospavDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter2.Fill(this.bancodadospavDataSet.cliente);
        }

        private void buFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
