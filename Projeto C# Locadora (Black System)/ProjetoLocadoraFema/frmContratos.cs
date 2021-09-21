using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoLocadoraFema.CAMADAS;

namespace ProjetoLocadoraFema
{
    public partial class frmContratos : Form
    {

        public frmContratos()
        {
            InitializeComponent();
        }

        private void frmContratos_Load(object sender, EventArgs e)
        {
            txtCPFClientesContratos.Enabled = false;
            txtNomeClientesContratos.Enabled = false;
            txtIDClienteContratos.Enabled = false;
            txtIDFilmesContrato.Enabled = false;
            txtNomeFilmeContratos.Enabled = false;
            txtValorFilmeContratos.Enabled = false;
            btnLimparContratos.Enabled = false;
            cBPrazoContrato.Enabled = false;
            btnConfirmarContrato.Enabled = false;
            cBContratos.Text = "--Opção--";
            btnProcurarContratos.Enabled = false;
        }

        private void cBContratos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cBContratos.Text == "--Opção--")
            {
                dtGrvContratos.DataSource = "";
            }
            if(cBContratos.Text == "Filmes")
            {
                CAMADAS.BLL.Filmes bllFilmes = new CAMADAS.BLL.Filmes();
                dtGrvContratos.DataSource = "";
                dtGrvContratos.DataSource = bllFilmes.SelectAtivos();
                btnConfirmarContrato.Text = "Confirmar";
                cBContratos.Enabled = true;
            }
            else if(cBContratos.Text == "Clientes")
            {
                CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
                dtGrvContratos.DataSource = "";
                dtGrvContratos.DataSource = bllClientes.Select();
                cBPrazoContrato.Enabled = false;
                btnConfirmarContrato.Text = "Confirmar";
            }
            else if(cBContratos.Text == "Alugados")
            {
                CAMADAS.BLL.Aluguel bllContratos = new CAMADAS.BLL.Aluguel();
                dtGrvContratos.DataSource = "";
                dtGrvContratos.DataSource = bllContratos.Select();
                btnConfirmarContrato.Text = "Devolver";
            }
        }

        private void dtGrvContratos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(cBContratos.Text == "Filmes")
            {
                txtIDFilmesContrato.Text = Convert.ToString(dtGrvContratos.SelectedRows[0].Cells["ID"].Value);
                txtNomeFilmeContratos.Text = Convert.ToString(dtGrvContratos.SelectedRows[0].Cells["Nome"].Value);
                txtValorFilmeContratos.Text = (Convert.ToString(dtGrvContratos.SelectedRows[0].Cells["Valor"].Value));
                cBPrazoContrato.Enabled = true;
                cBPrazoContrato.Text = "1";
            }
            else if(cBContratos.Text == "Clientes")
            {
                txtNomeClientesContratos.Text = Convert.ToString(dtGrvContratos.SelectedRows[0].Cells["Nome"].Value);
                txtIDClienteContratos.Text = Convert.ToString(dtGrvContratos.SelectedRows[0].Cells["ID"].Value);
                txtCPFClientesContratos.Text = Convert.ToString(dtGrvContratos.SelectedRows[0].Cells["CPF"].Value);
            }
            else if(cBContratos.Text == "Alugados")
            {
                
                
                btnConfirmarContrato.Enabled = true;
            }
            btnLimparContratos.Enabled = true;
            TesteValor();
        }

        private void LimparCampos()
        {
            txtCPFClientesContratos.Text = string.Empty;
            txtNomeClientesContratos.Text = string.Empty;
            txtIDClienteContratos.Text = string.Empty;
            txtIDFilmesContrato.Text = string.Empty;
            txtNomeFilmeContratos.Text = string.Empty;
            txtValorFilmeContratos.Text = string.Empty;
            txtIDCompraContratos.Text = string.Empty;
            btnLimparContratos.Enabled = false;
        }

        private void dtGrvContratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimparContratos_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnLimparContratos.Enabled = false;
            btnConfirmarContrato.Enabled = false;
        }

        private void cBPrazoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            double valor = (Convert.ToDouble(dtGrvContratos.SelectedRows[0].Cells["Valor"].Value));

            if (cBPrazoContrato.Text == "1")
            {
                txtValorFilmeContratos.Text = (Convert.ToString(valor));
            }
            if (cBPrazoContrato.Text == "3")
            {
                valor = (valor*1.40);
                txtValorFilmeContratos.Text = (Convert.ToString(valor));
            }
            if(cBPrazoContrato.Text == "7")
            {
                valor = (valor * 1.70);
                txtValorFilmeContratos.Text = (Convert.ToString(valor));
            }
            if(cBPrazoContrato.Text == "14")
            {
                valor = (valor * 2);
                txtValorFilmeContratos.Text = (Convert.ToString(valor));
            }
        }

        private void txtNomeClientesContratos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcurarContratos_Click(object sender, EventArgs e)
        {
           if(cBContratos.Text == "Clientes")
            {
                List<CAMADAS.MODEL.Clientes> lstClientes = new List<CAMADAS.MODEL.Clientes>();
                CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
                if (rbID.Checked)
                {
                    int id = Convert.ToInt32(txtPesquisarContratos.Text);
                    lstClientes = bllClientes.SelectByID(id);
                }
                else
                {
                    string nome = Convert.ToString(txtPesquisarContratos.Text);
                    lstClientes = bllClientes.SelectByNome(nome);
                }
                dtGrvContratos.DataSource = "";
                dtGrvContratos.DataSource = lstClientes;
            }
            else
            {
                List<CAMADAS.MODEL.Filmes> lstFilmes = new List<CAMADAS.MODEL.Filmes>();
                CAMADAS.BLL.Filmes bllFilmes = new CAMADAS.BLL.Filmes();
                if (rbID.Checked)
                {
                    int id = Convert.ToInt32(txtPesquisarContratos.Text);
                    lstFilmes = bllFilmes.SelectByIDAtivos(id);
                }
                else
                {
                    string nome = Convert.ToString(txtPesquisarContratos.Text);
                    lstFilmes = bllFilmes.SelectByNomeAtivos(nome);
                }
                dtGrvContratos.DataSource = "";
                dtGrvContratos.DataSource = lstFilmes;
            }
            
        }

        private void txtValorFilmeContratos_TextChanged(object sender, EventArgs e)
        {
            if(txtValorFilmeContratos.TextLength !=0)
            {
                cBPrazoContrato.Enabled = true;
            }
        }

        private void TesteValor()
        {
            if (txtIDFilmesContrato.TextLength != 0 &&
                txtIDClienteContratos.TextLength != 0 &&
                txtIDCompraContratos.TextLength != 0) 
                { btnConfirmarContrato.Enabled = true; }
        }

        private void btnVoltarContratos_Click(object sender, EventArgs e)
        {
            DialogResult voltar = MessageBox.Show("Deseja voltar?", "Retroceder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (voltar == DialogResult.Yes)
            {
                Close();
                frmPrincipal mainfrm = new frmPrincipal();
                mainfrm.Show();
            }
            else
            {
                MessageBox.Show("Saida Cancelada...", "Sair");
            }
        }

        private void btnConfirmarContrato_Click(object sender, EventArgs e)
        {
            
            if(btnConfirmarContrato.Text == "Confirmar")
            {
                DialogResult resultado = MessageBox.Show("Confirmar compra?", "Contrato", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    CAMADAS.MODEL.Aluguel aluguel = new CAMADAS.MODEL.Aluguel();
                    aluguel.ID = Convert.ToInt32(txtIDCompraContratos.Text);
                    aluguel.Cliente = Convert.ToInt32(txtIDClienteContratos.Text);
                    aluguel.Compra = (DateTime.Today.ToString("dd/MM/yyyy"));
                    int dias = Convert.ToInt32(cBPrazoContrato.Text);
                    aluguel.Prazo = (DateTime.Today.AddDays(dias).ToString("dd/MM/yyyy"));
                    aluguel.Valor = Convert.ToString(txtValorFilmeContratos.Text);
                    CAMADAS.BLL.Aluguel contratos = new CAMADAS.BLL.Aluguel();
                    contratos.Insert(aluguel);
                }
                else
                {
                    MessageBox.Show("Compra não confirmada...");
                }
            }
            if(btnConfirmarContrato.Text == "Devolver")
            {
                DialogResult resultado = MessageBox.Show("Confirmar devolução?", "Devolução", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado == DialogResult.Yes)
                {
                    CAMADAS.BLL.Aluguel contratos = new CAMADAS.BLL.Aluguel();
                    contratos.Delete(Convert.ToInt32(txtIDCompraContratos.Text));
                    CAMADAS.BLL.Aluguel bllContratos = new CAMADAS.BLL.Aluguel();
                    dtGrvContratos.DataSource = "";
                    dtGrvContratos.DataSource = bllContratos.Select();
                }
                else
                {
                    MessageBox.Show("Devolução não confirmada...");
                }
            }
            btnConfirmarContrato.Enabled = false;
            LimparCampos();
        }

        private void txtPesquisarContratos_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarContratos.TextLength != 0)
            {
                btnProcurarContratos.Enabled = true;
            }
            else
            {
                btnProcurarContratos.Enabled = false;
            }
        }

        private void txtIDCompraContratos_TextChanged(object sender, EventArgs e)
        {
            TesteValor();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
