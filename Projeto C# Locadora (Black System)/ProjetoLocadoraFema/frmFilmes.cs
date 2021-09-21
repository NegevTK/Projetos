using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProjetoLocadoraFema
{
    public partial class frmListarFilmes : Form
    {
        int numid;

        public frmListarFilmes()
        {
            InitializeComponent();
        }

        private void frmListarFilmes_Load(object sender, EventArgs e)
        {
            DesativeButtons(false);
            CAMADAS.BLL.Filmes dalFilmes = new CAMADAS.BLL.Filmes();
            dtGrvListarFilmes.DataSource = "";
            dtGrvListarFilmes.DataSource = dalFilmes.Select();
            btnPesquistar.Enabled = false;
            cbStatusFilmes.Text = "--Opção--";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<CAMADAS.MODEL.Filmes> lstfilmes = new List<CAMADAS.MODEL.Filmes>();
            CAMADAS.BLL.Filmes bllFilmes = new CAMADAS.BLL.Filmes();
            
            if(cbStatusFilmes.Text == "--Opção--")
            {
                lstfilmes = bllFilmes.Select();
            }
            if (rBIDFilmes.Checked && cbStatusFilmes.Text == "Disponiveis")
            {
                int id = Convert.ToInt32(txtProcurarFilmes.Text);
                lstfilmes = bllFilmes.SelectByIDAtivos(id);
            }
            if (rBIDFilmes.Checked && cbStatusFilmes.Text == "Alugados")
            {
                int id = Convert.ToInt32(txtProcurarFilmes.Text);
                lstfilmes = bllFilmes.SelectByIDDesativados(id);
            }
            
            if (rbNomeFilmes.Checked && cbStatusFilmes.Text == "Disponiveis")
            {         
                string nome = Convert.ToString(txtProcurarFilmes.Text);
                lstfilmes = bllFilmes.SelectByNomeAtivos(nome);
            }
            if (rbNomeFilmes.Checked && cbStatusFilmes.Text == "Alugados")
            {
                string nome = Convert.ToString(txtProcurarFilmes.Text);
                lstfilmes = bllFilmes.SelectByNomeDesativados(nome);
            }
            dtGrvListarFilmes.DataSource = "";
            dtGrvListarFilmes.DataSource = lstfilmes;
        }


        private void btnAtualizarFilmes_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Filmes dalFilmes = new CAMADAS.BLL.Filmes();
            dtGrvListarFilmes.DataSource = "";
            dtGrvListarFilmes.DataSource = dalFilmes.SelectAtivos();
            DesativeButtons(false);
            rBIDFilmes.Checked = true;
            limparCampos();
        }


        private void dtGrvListarFilmes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void DesativeButtons(bool Status)
        {
            btnLimparFilmes.Enabled = Status;
            btnEditarFilmes.Enabled = Status;
            btnRemoverFilmes.Enabled = Status;
            btnInserirFilme.Enabled = Status;
        }

        private void btnEditarFilmes_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseja editar item selecionado?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CamposDesativados(true);
                txtIDFilmes.Enabled = false;

                CAMADAS.MODEL.Filmes bllFilmes = new CAMADAS.MODEL.Filmes();
                bllFilmes.ID = Convert.ToInt32(txtIDFilmes.Text);
                bllFilmes.Produtora = txtProdutoraFilmes.Text;
                bllFilmes.Nome = txtNomeFilmes.Text;
                bllFilmes.Categoria = txtCategoria.Text;
                bllFilmes.Data = Convert.ToString(dTPFilmes.Text);
                bllFilmes.Faixa = txtClassificacao.Text;
                bllFilmes.Valor = Convert.ToDouble(nUPPreco.Text);
                bllFilmes.Quantidade = Convert.ToInt32(nUDQtd.Text);
                CAMADAS.BLL.Filmes Filmes = new CAMADAS.BLL.Filmes();
                Filmes.Update(bllFilmes);
            }
            else
            {
                CamposDesativados(true);
                txtIDFilmes.Enabled = false;
            }
            CAMADAS.BLL.Filmes dalFilmes = new CAMADAS.BLL.Filmes();
            dtGrvListarFilmes.DataSource = "";
            dtGrvListarFilmes.DataSource = dalFilmes.Select();
            limparCampos();
            btnEditarFilmes.Enabled = false;
            btnRemoverFilmes.Enabled = false;
            btnInserirFilme.Enabled = false;
            cbStatusFilmes.Text = "--Opção--";
        }

        private void btnRemoverFilmes_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirmar remoção", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                CAMADAS.BLL.Filmes dalFilmes = new CAMADAS.BLL.Filmes();
                dalFilmes.Delete(numid);
                dtGrvListarFilmes.DataSource = "";
                dtGrvListarFilmes.DataSource = dalFilmes.Select();
                cbStatusFilmes.Text = "--Opção--";
                DesativeButtons(false);
            }
            else
            {
                MessageBox.Show("Remoção não confirmada...");
                DesativeButtons(false);
            }
            limparCampos();
        }

        private void dtGrvListarFilmes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DesativeButtons(true);
            btnLimparFilmes.Enabled = false;
            numid = Convert.ToInt32(dtGrvListarFilmes.SelectedRows[0].Cells["ID"].Value);
            string txtSetid = Convert.ToString(numid);
            txtIDFilmes.Text = txtSetid;
            txtProdutoraFilmes.Text = Convert.ToString(dtGrvListarFilmes.SelectedRows[0].Cells["Produtora"].Value);
            txtNomeFilmes.Text = Convert.ToString(dtGrvListarFilmes.SelectedRows[0].Cells["Nome"].Value);
            txtClassificacao.Text = Convert.ToString(dtGrvListarFilmes.SelectedRows[0].Cells["Faixa"].Value);
            txtCategoria.Text = Convert.ToString(dtGrvListarFilmes.SelectedRows[0].Cells["Categoria"].Value);
            nUPPreco.Text = Convert.ToString(dtGrvListarFilmes.SelectedRows[0].Cells["Valor"].Value);
            dTPFilmes.Text = Convert.ToString(dtGrvListarFilmes.SelectedRows[0].Cells["Data"].Value);
            nUDQtd.Text = Convert.ToString(dtGrvListarFilmes.SelectedRows[0].Cells["Quantidade"].Value);
            btnInserirFilme.Enabled = false;
            btnEditarFilmes.Enabled = true;
            txtIDFilmes.Enabled = false;
        }

        private void txtIDFilmes_TextChanged(object sender, EventArgs e)
        {
            if (txtIDFilmes.TextLength != 0)
            {
                btnLimparFilmes.Enabled = true;
            }
            else
            {
                btnLimparFilmes.Enabled = false;
            }
        }

        private void txtProdutoraFilmes_TextChanged(object sender, EventArgs e)
        {
            if (txtProdutoraFilmes.TextLength != 0)
            {
                btnLimparFilmes.Enabled = true;
            }
            else
            {
                btnLimparFilmes.Enabled = false;
            }
        }

        private void txtNomeFilmes_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeFilmes.TextLength != 0)
            {
                btnLimparFilmes.Enabled = true;
            }
            else
            {
                btnLimparFilmes.Enabled = false;
            }
            teste_valor();
        }

        private void txtClassificacao_TextChanged(object sender, EventArgs e)
        {
            if (txtClassificacao.TextLength != 0)
            {
                btnLimparFilmes.Enabled = true;
            }
            else
            {
                btnLimparFilmes.Enabled = false;
            }
            teste_valor();
        }

        private void teste_valor()
        {

            if (txtIDFilmes.TextLength != 0 &&
            txtProdutoraFilmes.TextLength != 0 &&
            txtNomeFilmes.TextLength != 0 &&
            txtCategoria.TextLength != 0 &&
            txtClassificacao.TextLength != 0 && 
            nUDQtd.Value != 0 &&
            btnEditarFilmes.Enabled == false)
            { btnInserirFilme.Enabled = true; }

        }

        private void limparCampos()
        {
            txtIDFilmes.Text = string.Empty;
            txtProdutoraFilmes.Text = string.Empty;
            txtNomeFilmes.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtClassificacao.Text = string.Empty;
            dTPFilmes.Text = string.Empty;
            txtProcurarFilmes.Text = string.Empty;
            nUDQtd.Text = string.Empty;
            nUPPreco.Value = 0;
            CamposDesativados(true);
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            limparCampos();
            DesativeButtons(false);
        }

        private void btnInserirFilme_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirmar inserção", "Inserir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                CAMADAS.MODEL.Filmes filme = new CAMADAS.MODEL.Filmes();
                filme.ID = Convert.ToInt32(txtIDFilmes.Text);
                filme.Produtora = txtProdutoraFilmes.Text;
                filme.Nome = txtNomeFilmes.Text;
                filme.Categoria = txtCategoria.Text;
                filme.Data = Convert.ToString(dTPFilmes.Text);
                filme.Faixa = txtClassificacao.Text;
                filme.Valor = Convert.ToDouble(nUPPreco.Text);
                filme.Quantidade = Convert.ToInt32(nUDQtd.Text);
                CAMADAS.BLL.Filmes dalFilmes = new CAMADAS.BLL.Filmes();
                dalFilmes.Insert(filme);
                dtGrvListarFilmes.DataSource = "";
                dtGrvListarFilmes.DataSource = dalFilmes.Select(); 
                cbStatusFilmes.Text = "--Opção--";
                limparCampos();
                DesativeButtons(false);
            }
            else
            {
                MessageBox.Show("Inserção não confirmada...");
                limparCampos();
                DesativeButtons(false);
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            if (txtCategoria.TextLength != 0)
            {
                btnLimparFilmes.Enabled = true;
            }
            else
            {
                btnLimparFilmes.Enabled = false;
            }
            teste_valor();
        }

        private void dTPFilmes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CamposDesativados(bool status)
        {
            txtIDFilmes.Enabled = status;
            txtProdutoraFilmes.Enabled = status;
            txtNomeFilmes.Enabled = status;
            txtCategoria.Enabled = status;
            txtClassificacao.Enabled = status;
            dTPFilmes.Enabled = status;
            nUPPreco.Enabled = status;
            nUDQtd.Enabled = status;
        }


        private void txtProcurarFilmes_TextChanged(object sender, EventArgs e)
        {
            if (txtProcurarFilmes.TextLength != 0)
            {
                btnLimparFilmes.Enabled = true;
                btnPesquistar.Enabled = true;
            }
            else
            {
                btnLimparFilmes.Enabled = false;
                btnPesquistar.Enabled = false;
            }
            teste_valor();
        }

        private void txtQtdFilmes_TextChanged(object sender, EventArgs e)
        {
            if (nUDQtd.Value != 0)
            {
                btnLimparFilmes.Enabled = true;
            }
            else
            {
                btnLimparFilmes.Enabled = false;
            }
            teste_valor();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInserirFilme_Click(object sender, EventArgs e)
        {

        }

        
        private void dtGrvListarFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult voltar = MessageBox.Show("Deseja voltar?", "Retroceder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(voltar == DialogResult.Yes)
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

        private void cbStatusFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbStatusFilmes.Text == "Disponiveis")
            {
                CAMADAS.BLL.Filmes dalFilmes = new CAMADAS.BLL.Filmes();
                dtGrvListarFilmes.DataSource = "";
                dtGrvListarFilmes.DataSource = dalFilmes.SelectAtivos();
            }
            if(cbStatusFilmes.Text == "Alugados")
            {
                CAMADAS.BLL.Filmes dalFilmes = new CAMADAS.BLL.Filmes();
                dtGrvListarFilmes.DataSource = "";
                dtGrvListarFilmes.DataSource = dalFilmes.SelectDesativados();
            }
            if (cbStatusFilmes.Text == "--Opção--")
            {
                CAMADAS.BLL.Filmes dalFilmes = new CAMADAS.BLL.Filmes();
                dtGrvListarFilmes.DataSource = "";
                dtGrvListarFilmes.DataSource = dalFilmes.Select();
            }
        }
    }
}
