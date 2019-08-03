using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;
using DTO;
using Regras_De_Negocios;
using ConexaoSqlServer;

namespace Apresentacao_Usuario
{
    public partial class frmManipularParametros : Form
    {
        Conect conect = new Conect();

        public frmManipularParametros()
        {
            InitializeComponent();
            dgvCorrecao.AutoGenerateColumns = false;
        }

        private void Buscar_Parametros()
        {
            try
            {
                Correcao_Colecao Ccorrecao = new Correcao_Colecao();
                Negocios_Correcao Ncorrecao = new Negocios_Correcao();
                Ccorrecao = Ncorrecao.BuscaCorrecaoParametro(Convert.ToInt32(txtBuscaDia.Text));
                dgvCorrecao.DataSource = null;
                dgvCorrecao.DataSource = Ccorrecao;
                dgvCorrecao.Update();
                dgvCorrecao.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe: " + ex.Message);
            }
        }

        private void CarregarGrid()
        {
            try
            {
                Conect conect = new Conect();
                SqlConnection conn = conect.Conexao();
                SqlCommand cmd = new SqlCommand("Select * From tbl_Correcao", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCorrecao.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe: " + ex.Message);
            }
        }

        private void Alterar()
        {
            Correcao correcao = new Correcao();
            Negocios_Correcao Ncorrecao = new Negocios_Correcao();
            correcao.IdCorrecao = Convert.ToInt32(txtCodigo.Text);
            correcao.Parametro_Minimo = Convert.ToInt32(txtPmim.Text);
            correcao.Parametro_Maximo = Convert.ToInt32(txtPmax.Text);
            correcao.Dose_Cafe = Convert.ToInt32(txtCafe.Text);
            correcao.Dose_Almoco = Convert.ToInt32(txtAlmoco.Text);
            correcao.Dose_Lanche = Convert.ToInt32(txtLanche.Text);
            correcao.Dose_Jantar = Convert.ToInt32(txtJantar.Text);
            correcao.Dose_Ceia = Convert.ToInt32(txtCeia.Text);
            Ncorrecao.Altera_Correcao(correcao);
        }

        private void frmManipularParametros_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            if (dgvCorrecao.RowCount <= 0)
            {
                btnInserir_Parametros.Enabled = true;
            }   
            
            lblcabecalho.Text = "Manipulação dos parâmetros Clicêmicos de Nicolle Bueno Cordovil Bruno.";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Buscar_Parametros();
            if(dgvCorrecao.RowCount <=0)
            {
                MessageBox.Show("Parâmetro MÍNIMO Informado não existe !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscaDia.Text = String.Empty;
                CarregarGrid();
                txtBuscaDia.Focus();
                return;
            }
            btnAlterar.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmManipularParametros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void dgvCorrecao_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhas = this.dgvCorrecao.Rows[e.RowIndex];
            txtCodigo.Text = (linhas.Cells[0].Value.ToString());
            txtPmim.Text = (linhas.Cells[1].Value.ToString());
            txtPmax.Text = (linhas.Cells[2].Value.ToString());
            txtCafe.Text = (linhas.Cells[3].Value.ToString());
            txtAlmoco.Text = (linhas.Cells[4].Value.ToString());
            txtLanche.Text = (linhas.Cells[5].Value.ToString());
            txtJantar.Text = (linhas.Cells[6].Value.ToString());
            txtCeia.Text = (linhas.Cells[7].Value.ToString());
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();           
            Application.Restart();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            btnAlterar.Enabled = false;
            txtBuscaDia.Text = String.Empty;
            txtBuscaDia.Focus();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmImpressaoParametros fip = new frmImpressaoParametros();
            fip.Show();
        }

        private void txtLanche_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
