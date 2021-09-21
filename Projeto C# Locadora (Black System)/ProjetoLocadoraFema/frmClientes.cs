using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoLocadoraFema
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
            dTGrvClientes.DataSource = "";
            dTGrvClientes.DataSource = bllClientes.Select();
            DesativeButtons(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void DesativeButtons(bool status)
        {
            btnCadastrarClientes.Enabled = status;
            btnEditarClientes.Enabled = status;
            btnLimparClientes.Enabled = status;
            btnRemoverClientes.Enabled = status;
            btnProcurarCliente.Enabled = status;
        }

        private void TestValue()
        {
            if (txtIDCliente.TextLength != 0 &&
               txtNomeCliente.TextLength != 0 &&
               txtCPFCliente.TextLength != 0 &&
               txtEnderCliente.TextLength != 0 &&
               txtTelCliente.TextLength != 0 &&
               btnEditarClientes.Enabled == false)
            { btnCadastrarClientes.Enabled = true; }
        }

        private void LimparCampos()
        {
            txtIDCliente.Text = string.Empty;
            txtNomeCliente.Text = string.Empty;
            txtCPFCliente.Text = string.Empty;
            txtEnderCliente.Text = string.Empty;
            txtTelCliente.Text = string.Empty;
            txtProcurarClientes.Text = string.Empty;
            btnCadastrarClientes.Enabled = false;
            btnRemoverClientes.Enabled = false;
            btnEditarClientes.Enabled = false;
        }

        private void txtNomeCliente_TextChanged_1(object sender, EventArgs e)
        {
            if (txtNomeCliente.TextLength != 0)
            {
                btnLimparClientes.Enabled = true;
            }
            else
            {
                btnLimparClientes.Enabled = false;
            }
            TestValue();
        }

        private void txtIDCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIDCliente.TextLength != 0)
            {
                btnLimparClientes.Enabled = true;
            }
            else
            {
                btnLimparClientes.Enabled = false;
            }
            TestValue();
        }

        private void txtEnderCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtEnderCliente.TextLength != 0)
            {
                btnLimparClientes.Enabled = true;
            }
            else
            {
                btnLimparClientes.Enabled = false;
            }
            TestValue();
        }

        private void txtCPFCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCPFCliente.TextLength != 0)
            {
                btnLimparClientes.Enabled = true;
            }
            else
            {
                btnLimparClientes.Enabled = false;
            }
            TestValue();
        }

        private void txtTelCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtTelCliente.TextLength != 0)
            {
                btnLimparClientes.Enabled = true;
            }
            else
            {
                btnLimparClientes.Enabled = false;
            }
            TestValue();
        }

        private void txtProcurarClientes_TextChanged(object sender, EventArgs e)
        {
            if (txtProcurarClientes.TextLength != 0)
            {
                btnLimparClientes.Enabled = true;
                btnProcurarCliente.Enabled = true;
            }
            else
            {
                btnLimparClientes.Enabled = false;
                btnProcurarCliente.Enabled = false;
            }
        }

        private void btnLimparClientes_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnProcurarCliente_Click(object sender, EventArgs e)
        {
            List<CAMADAS.MODEL.Clientes> lstClientes = new List<CAMADAS.MODEL.Clientes>();
            CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
            if (rBID.Checked)
            {
                int id = Convert.ToInt32(txtProcurarClientes.Text);
                lstClientes = bllClientes.SelectByID(id);
            }
            else
            {
                string nome = Convert.ToString(txtProcurarClientes.Text);
                lstClientes = bllClientes.SelectByNome(nome);
            }
            dTGrvClientes.DataSource = "";
            dTGrvClientes.DataSource = lstClientes;
        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirmar inserção", "Inserir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
                cliente.ID = Convert.ToInt32(txtIDCliente.Text);
                cliente.Nome = txtNomeCliente.Text;
                cliente.CPF = txtCPFCliente.Text;
                cliente.Telefone = txtTelCliente.Text;
                cliente.Endereco = txtEnderCliente.Text;
                CAMADAS.BLL.Clientes BLLCliente = new CAMADAS.BLL.Clientes();
                BLLCliente.Inserir(cliente);
            }
            else
            {
                MessageBox.Show("Inserção não confirmada...");
            }
            CAMADAS.BLL.Clientes bllCliente = new CAMADAS.BLL.Clientes();
            dTGrvClientes.DataSource = "";
            dTGrvClientes.DataSource = bllCliente.Select();
            LimparCampos();
        }

        private void dTGrvClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIDCliente.Text = Convert.ToString(dTGrvClientes.SelectedRows[0].Cells["ID"].Value);
            txtNomeCliente.Text = Convert.ToString(dTGrvClientes.SelectedRows[0].Cells["Nome"].Value);
            txtCPFCliente.Text = Convert.ToString(dTGrvClientes.SelectedRows[0].Cells["CPF"].Value);
            txtEnderCliente.Text = Convert.ToString(dTGrvClientes.SelectedRows[0].Cells["Endereco"].Value);
            txtTelCliente.Text = Convert.ToString(dTGrvClientes.SelectedRows[0].Cells["Telefone"].Value);
            txtIDCliente.Enabled = false;
            btnRemoverClientes.Enabled = true;
            btnEditarClientes.Enabled = true;
            btnCadastrarClientes.Enabled = false;
        }

        private void btnRemoverClientes_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Excluir item selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirma == DialogResult.Yes)
            {
                int numid = Convert.ToInt32(dTGrvClientes.SelectedRows[0].Cells["ID"].Value);
                CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
                bllClientes.Delete(numid);
                dTGrvClientes.DataSource = "";
                dTGrvClientes.DataSource = bllClientes.Select();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Item não removido...", "Remoção");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult confirma = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirma == DialogResult.Yes)
            {
                Close();
                frmPrincipal main = new frmPrincipal();
                main.Show();
            }
            else
            {
                MessageBox.Show("Saida cancelada...", "Sair");
            }
        }

        private void btnAtualizarClientes_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
            dTGrvClientes.DataSource = "";
            dTGrvClientes.DataSource = bllClientes.Select();
            LimparCampos();
            rBID.Checked = true;
        }

        private void btnEditarClientes_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja editar item selecionado?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CAMADAS.MODEL.Clientes bllClientes = new CAMADAS.MODEL.Clientes();
                bllClientes.ID = Convert.ToInt32(txtIDCliente.Text);
                bllClientes.Nome = txtNomeCliente.Text;
                bllClientes.CPF = txtCPFCliente.Text;
                bllClientes.Endereco = txtEnderCliente.Text;
                bllClientes.Telefone = txtTelCliente.Text;
                CAMADAS.BLL.Clientes Clientes = new CAMADAS.BLL.Clientes();
                Clientes.Update(bllClientes);
            }
            else
            {
                MessageBox.Show("Edição não confirmada", "Editar");
            }
            CAMADAS.BLL.Clientes BllClientes = new CAMADAS.BLL.Clientes();
            dTGrvClientes.DataSource = "";
            dTGrvClientes.DataSource = BllClientes.Select();
            LimparCampos();
        }
    }
}
