using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLocadoraFema
{
    public partial class frmPrincipal : Form
    {

        Form _objectForm;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fILMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _objectForm?.Close();
            _objectForm = new frmClientes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnPrincipal.Controls.Add(_objectForm);
            _objectForm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void filmesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _objectForm?.Close();

            _objectForm = new frmListarFilmes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnPrincipal.Controls.Add(_objectForm);
            _objectForm.Show();
        }

    

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void pnPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void msGerenciar_Click(object sender, EventArgs e)
        {

        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _objectForm?.Close();

            _objectForm = new frmContratos()
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnPrincipal.Controls.Add(_objectForm);
            _objectForm.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _objectForm?.Close();
            _objectForm = new frmSobre()
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnPrincipal.Controls.Add(_objectForm);
            _objectForm.Show();
        }
    }
}
