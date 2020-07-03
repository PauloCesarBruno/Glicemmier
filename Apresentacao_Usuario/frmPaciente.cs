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
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
            dgvPaciente.AutoGenerateColumns = false;
            dgvCorrecao.AutoGenerateColumns = false;
        }

        #region Metodos

        private void CapCelulaParametros()
        {
            try
            {
                String P1 = dgvCorrecao[1, 0].Value.ToString();
                String P2 = dgvCorrecao[2, 0].Value.ToString();
                String P3 = dgvCorrecao[1, 1].Value.ToString();
                String P4 = dgvCorrecao[2, 1].Value.ToString();
                String P5 = dgvCorrecao[1, 2].Value.ToString();
                String P6 = dgvCorrecao[2, 2].Value.ToString();
                String P7 = dgvCorrecao[1, 3].Value.ToString();
                String P8 = dgvCorrecao[2, 3].Value.ToString();
                String P9 = dgvCorrecao[1, 4].Value.ToString();
                String P10 = dgvCorrecao[2, 4].Value.ToString();
                String P11 = dgvCorrecao[1, 5].Value.ToString();
                String P12 = dgvCorrecao[2, 5].Value.ToString();

                txtParam1.Text = P1;
                txtParam1_.Text = P2;
                txtParam2.Text = P3;
                txtParam2_.Text = P4;
                txtParam3.Text = P5;
                txtParam3_.Text = P6;
                txtParam4.Text = P7;
                txtParam4_.Text = P8;
                txtParam5.Text = P9;
                txtParam5_.Text = P10;
                txtParam6.Text = P11;
                txtParam6_.Text = P12;
            }
            catch (Exception)
            {
                //
            }
        }

        private void FecharMes()
        {
            Conect conect = new Conect();
            SqlConnection conn = conect.Conexao();
            SqlCommand cmd = new SqlCommand("Truncate Table tbl_Paciente", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPaciente.DataSource = dt;
        }

        private void MostraParametros()
        {
            Conect conect = new Conect();
            SqlConnection conn = conect.Conexao();
            SqlCommand cmd = new SqlCommand("Select * From tbl_Correcao", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCorrecao.DataSource = dt;
        }

        private void Trava_Campos()
        {
            txtDia.ReadOnly = true;
            txtCafe.ReadOnly = true;
            txtAlmoco.ReadOnly = true;
            txtLanche.ReadOnly = true;
            txtJantar.ReadOnly = true;
            txtCeia.ReadOnly = true;
            txtObs.ReadOnly = true;
        }

        private void Libera_Campos()
        {
            txtDia.ReadOnly = false;
            txtCafe.ReadOnly = false;
            txtAlmoco.ReadOnly = false;
            txtLanche.ReadOnly = false;
            txtJantar.ReadOnly = false;
            txtCeia.ReadOnly = false;
            txtObs.ReadOnly = false;
        }

        private void Limpa_campos()
        {
            CarregarGrid();
            txtDia.Text = String.Empty;
            txtCafe.Text = String.Empty;
            txtAlmoco.Text = String.Empty;
            txtLanche.Text = String.Empty;
            txtJantar.Text = String.Empty;
            txtCeia.Text = String.Empty;
            txtObs.Text = String.Empty;
            txtBuscaNome.Text = String.Empty;
            txtBuscaDia.Text = String.Empty;
            txtBuscaNome.Focus();
        }

        private void Atualizar()
        {
            try
            {
                Limpa_campos();
                txtDia.Text = dgvPaciente.CurrentRow.Cells[2].Value.ToString();
                txtCafe.Text = dgvPaciente.CurrentRow.Cells[3].Value.ToString();
                txtAlmoco.Text = dgvPaciente.CurrentRow.Cells[4].Value.ToString();
                txtLanche.Text = dgvPaciente.CurrentRow.Cells[5].Value.ToString();
                txtJantar.Text = dgvPaciente.CurrentRow.Cells[6].Value.ToString();
                txtCeia.Text = dgvPaciente.CurrentRow.Cells[7].Value.ToString();
                txtObs.Text = dgvPaciente.CurrentRow.Cells[8].Value.ToString();
                btnNovo.Enabled = true;
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                txtBuscaDia.Focus();
            }
            catch (Exception)
            {
                //
            }
        }

        private void CarregarGrid()
        {
            Pacientes_Colecao Pcolecao = new Pacientes_Colecao();
            Negocios_Paciente Npaciente = new Negocios_Paciente();
            Pcolecao = Npaciente.BuscaPorNome(txtBuscaNome.Text);
            dgvPaciente.DataSource = null;
            dgvPaciente.DataSource = Pcolecao;
            dgvPaciente.Update();
            dgvPaciente.Refresh();
        }

        private void BuscaDia()
        {
            try
            {
                Pacientes_Colecao Pcolecao = new Pacientes_Colecao();
                Negocios_Paciente Npaciente = new Negocios_Paciente();
                Pcolecao = Npaciente.BuscaPorDia(Convert.ToInt32(txtBuscaDia.Text));
                dgvPaciente.DataSource = null;
                dgvPaciente.DataSource = Pcolecao;
                dgvPaciente.Update();
                dgvPaciente.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe: " + ex.Message);
            }
        }

        private void Inserir()
        {
            try
            {
                Pacientes pacientes = new Pacientes();
                Negocios_Paciente Npaciente = new Negocios_Paciente();
                pacientes.Nome = txtNome.Text;
                pacientes.Dia = Convert.ToInt32(txtDia.Text);
                pacientes.Antes_Cafe = Convert.ToInt32(txtCafe.Text);
                pacientes.Antes_Almoco = Convert.ToInt32(txtAlmoco.Text);
                pacientes.Antes_Lanche = Convert.ToInt32(txtLanche.Text);
                pacientes.Antes_Jantar = Convert.ToInt32(txtJantar.Text);
                pacientes.Antes_Ceia = Convert.ToInt32(txtCeia.Text);
                pacientes.Observacoes = txtObs.Text;
                Npaciente.Inserir_Pacientes(pacientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe: " + ex.Message);
            }
        }

        private void Alterar()
        {
            try
            {
                Pacientes pacientes = new Pacientes();
                Negocios_Paciente Npaciente = new Negocios_Paciente();
                pacientes.IdPaciente = Convert.ToInt32(txtCodigo.Text);
                pacientes.Nome = txtNome.Text;
                pacientes.Dia = Convert.ToInt32(txtDia.Text);
                pacientes.Antes_Cafe = Convert.ToInt32(txtCafe.Text);
                pacientes.Antes_Almoco = Convert.ToInt32(txtAlmoco.Text);
                pacientes.Antes_Lanche = Convert.ToInt32(txtLanche.Text);
                pacientes.Antes_Jantar = Convert.ToInt32(txtJantar.Text);
                pacientes.Antes_Ceia = Convert.ToInt32(txtCeia.Text);
                pacientes.Observacoes = txtObs.Text;
                Npaciente.Altera_Pacientes(pacientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe: " + ex.Message);
            }
        }

        private void Excluir()
        {
            try
            {
                Pacientes pacientes = new Pacientes();
                Negocios_Paciente Npaciente = new Negocios_Paciente();
                pacientes.IdPaciente = Convert.ToInt32(txtCodigo.Text);
                Npaciente.Exclui_Pacientes(pacientes);
            }
            catch (Exception)
            {
                //
            }
        }

        #endregion

        #region Comandos

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            MostraParametros();
            CarregarGrid();
            if (dgvPaciente.RowCount <= 0)
            {
                btnCorrigir.Enabled = false;
                btnCorrigirJantar.Enabled = false;
                btnCorrigirCeia.Enabled = false;
            }
            CapCelulaParametros();
            lblcabecalho.Text = "Parâmetros Clicêmicos de Nicolle Bueno Cordovil Bruno do Mês: " + DateTime.Now.Month.ToString() + " de " + DateTime.Now.Year.ToString();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
            Trava_Campos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Libera_Campos();
            txtDia.Text = "0";
            txtCafe.Text = "0";
            txtAlmoco.Text = "0";
            txtLanche.Text = "0";
            txtJantar.Text = "0";
            txtCeia.Text = "0";
            txtLanche.Text = "0";
            txtObs.Text = "";
            txtDia.Focus();
            btnInserir.Enabled = true;
            btnDeletar.Enabled = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            btnCorrigir.Enabled = true;
            btnCorrigirJantar.Enabled = true;
            btnCorrigirCeia.Enabled = true;
            btnCorrigirLanche.Enabled = true;
            // Café
            if (int.Parse(txtCafe.Text) >= int.Parse(txtParam1.Text.ToString()) && int.Parse(txtCafe.Text) <= int.Parse(txtParam1_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do café = " + txtCafe.Text + " Corrigir com 01 (UMA) dose de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Inserir();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtCafe.Text) >= int.Parse(txtParam2.Text.ToString()) && int.Parse(txtCafe.Text) <= int.Parse(txtParam2_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do café = " + txtCafe.Text + " Corrigir com 02 (DUAS) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Inserir();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtCafe.Text) >= int.Parse(txtParam3.Text.ToString()) && int.Parse(txtCafe.Text) <= int.Parse(txtParam3_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do café  = " + txtCafe.Text + " Corrigir com 02 (DUAS) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Inserir();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtCafe.Text) >= int.Parse(txtParam4.Text.ToString()) && int.Parse(txtCafe.Text) <= int.Parse(txtParam4_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do café = " + txtCafe.Text + " Corrigir com 02 (DUAS) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Inserir();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtCafe.Text) >= int.Parse(txtParam4_.Text.ToString()) && int.Parse(txtCafe.Text) <= int.Parse(txtParam5_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do café = " + txtCafe.Text + " Corrigir com 03 (TRÊS) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Inserir();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtCafe.Text) >= int.Parse(txtParam6.Text.ToString()) && int.Parse(txtCafe.Text) <= int.Parse(txtParam6_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do café = " + txtCafe.Text + " Corrigir com 04 (QUATRO) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "PERIGO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Inserir();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtCafe.Text) < int.Parse("60".ToString()))
            {

                // AQUI HIPOGLICEMIA.
                //==================================
                MessageBox.Show("Glicose antes do café = " + txtCafe.Text + " Detectado HIPOGLICEMIA -> Repor Açucar Urgente !!!", "PERIGO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Inserir();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtCafe.Text) == int.Parse("60".ToString()) || int.Parse(txtCafe.Text) == int.Parse("61".ToString ()) ||
                int.Parse(txtCafe.Text) == int.Parse("62".ToString()) || int.Parse(txtCafe.Text) == int.Parse("63".ToString()) ||
                int.Parse(txtCafe.Text) == int.Parse("64".ToString()) || int.Parse(txtCafe.Text) == int.Parse ("65".ToString()) ||
                int.Parse(txtCafe.Text) == int.Parse("66".ToString()) || int.Parse(txtCafe.Text) == int.Parse("67".ToString()) ||
                int.Parse(txtCafe.Text) == int.Parse("68".ToString()) || int.Parse(txtCafe.Text) == int.Parse("69".ToString()))
            {
                // AQUI QUANDO GLICOSE NORMAL.
                //==================================
                Inserir();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
            }

            else
            {
                //
            }
        }

        private void txtObs_Leave(object sender, EventArgs e)
        {
            btnInserir.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Libera_Campos();
            if (txtBuscaDia.Text == String.Empty)
            {
                MessageBox.Show("Não foi digitado o dia !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaDia.Focus();
            }
            else
            {
                BuscaDia();
                btnNovo.Enabled = false;
                btnCorrigir.Enabled = true;
                btnDeletar.Enabled = true;
                btnAtualizar.Focus();
            }
        }

        private void brnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvPaciente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = this.dgvPaciente.Rows[e.RowIndex];
            txtCodigo.Text = (linha.Cells[0].Value.ToString());
            txtDia.Text = (linha.Cells[2].Value.ToString());
            txtCafe.Text = (linha.Cells[3].Value.ToString());
            txtAlmoco.Text = (linha.Cells[4].Value.ToString());
            txtLanche.Text = (linha.Cells[5].Value.ToString());
            txtJantar.Text = (linha.Cells[6].Value.ToString());
            txtCeia.Text = (linha.Cells[7].Value.ToString());
            txtObs.Text = (linha.Cells[8].Value.ToString());
        }

        private void frmPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            // Almoço     
            Trava_Campos();
            if (int.Parse(txtAlmoco.Text) >= int.Parse(txtParam1.Text.ToString()) && int.Parse(txtAlmoco.Text) <= int.Parse(txtParam1_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Almoço = " + txtAlmoco.Text + " Corrigir com 01 (UMA) dose de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }
            else if (int.Parse(txtAlmoco.Text) >= int.Parse(txtParam2.Text.ToString()) && int.Parse(txtAlmoco.Text) <= int.Parse(txtParam2_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Almoço = " + txtAlmoco.Text + " Corrigir com 01 (UMA) dose de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtAlmoco.Text) >= int.Parse(txtParam3.Text.ToString()) && int.Parse(txtAlmoco.Text) <= int.Parse(txtParam3_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Almoço = " + txtAlmoco.Text + " Corrigir com 01 (UMA) dose de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtAlmoco.Text) >= int.Parse(txtParam4.Text.ToString()) && int.Parse(txtAlmoco.Text) <= int.Parse(txtParam4_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Almoço = " + txtAlmoco.Text + " Corrigir com 02 (DUAS) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtAlmoco.Text) >= int.Parse(txtParam4_.Text.ToString()) && int.Parse(txtAlmoco.Text) <= int.Parse(txtParam5_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Almoço = " + txtAlmoco.Text + " Corrigir com 03 (TRÊS) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtAlmoco.Text) >= int.Parse(txtParam6.Text.ToString()) && int.Parse(txtAlmoco.Text) <= int.Parse(txtParam6_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Almoço = " + txtAlmoco.Text + " Corrigir com 04 (QUATRO) doses de insulina - ALERTA PARA HOSPITAL !!!!", "PERIGO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtAlmoco.Text) < int.Parse("60".ToString()))
            {
                // AQUI HIPOGLICEMIA.
                //==================================
                MessageBox.Show("Glicose antes do Almoço = " + txtAlmoco.Text + " Detectado HIPOGLICEMIA -> Repor Açucar Urgente !!!", "PERIGO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtAlmoco.Text) == int.Parse("60".ToString()) || int.Parse(txtAlmoco.Text) == int.Parse("61".ToString()) ||
                int.Parse(txtAlmoco.Text) == int.Parse("62".ToString()) || int.Parse(txtAlmoco.Text) == int.Parse("63".ToString()) ||
                int.Parse(txtAlmoco.Text) == int.Parse("64".ToString()) || int.Parse(txtAlmoco.Text) == int.Parse("65".ToString()) ||
                int.Parse(txtAlmoco.Text) == int.Parse("66".ToString()) || int.Parse(txtAlmoco.Text) == int.Parse("67".ToString()) ||
                int.Parse(txtAlmoco.Text) == int.Parse("68".ToString()) || int.Parse(txtAlmoco.Text) == int.Parse("69".ToString()))
            {
                // AQUI QUANDO GLICOSE NORMAL.
                //==================================
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
            }

            else
            {
                //
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult perg = MessageBox.Show("Deseja realmente apagar este registro Sim ou Não ?", "EXCLUSÃO DE REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (perg != DialogResult.Yes)
            {
                MessageBox.Show("OK, Mantendo o registro !!!", "EXCLUSÃO DE REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_campos();
                Atualizar();
                MostraParametros();
                txtBuscaDia.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Registro Apagado com êxito !!!", "EXCLUSÃO DE REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Excluir();
                Atualizar();
                txtBuscaDia.Focus();
            }
        }

        private void btnCorrigirJantar_Click(object sender, EventArgs e)
        {
            // Jantar
            Trava_Campos();
            if (int.Parse(txtJantar.Text) >= int.Parse(txtParam1.Text.ToString()) && int.Parse(txtJantar.Text) <= int.Parse(txtParam1_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Jantar = " + txtJantar.Text + " Corrigir com 01 (UMA) dose de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtJantar.Text) >= int.Parse(txtParam2.Text.ToString()) && int.Parse(txtJantar.Text) <= int.Parse(txtParam2_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Jantar = " + txtJantar.Text + " Corrigir com 01 (UMA) dose de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtJantar.Text) >= int.Parse(txtParam3.Text.ToString()) && int.Parse(txtJantar.Text) <= int.Parse(txtParam3_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Jantar = " + txtJantar.Text + " Corrigir com 02 (DUAS) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtJantar.Text) >= int.Parse(txtParam4.Text.ToString()) && int.Parse(txtJantar.Text) <= int.Parse(txtParam4_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Jantar = " + txtJantar.Text + " Corrigir com 02 (DUAS) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtJantar.Text) >= int.Parse(txtParam4_.Text.ToString()) && int.Parse(txtJantar.Text) <= int.Parse(txtParam5_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Jantar = " + txtJantar.Text + " Corrigir com 03 (TRÊS) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtJantar.Text) >= int.Parse(txtParam6.Text.ToString()) && int.Parse(txtJantar.Text) <= int.Parse(txtParam6_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Jantar = " + txtJantar.Text + "Corrigir com 04 (QUATRO) doses de insulina - ALERTA PARA HOSPITAL !!!!", "PERIGO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtJantar.Text) < int.Parse("60".ToString()))
            {
                // AQUI HIPOGLICEMIA.
                //==================================
                MessageBox.Show("Glicose antes do Jantar = " + txtJantar.Text + " Detectado HIPOGLICEMIA -> Repor Açucar Urgente !!!", "PERIGO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtJantar.Text) == int.Parse("60".ToString()) || int.Parse(txtJantar.Text) == int.Parse("61".ToString()) ||
                int.Parse(txtJantar.Text) == int.Parse("62".ToString()) || int.Parse(txtJantar.Text) == int.Parse("63".ToString()) ||
                int.Parse(txtJantar.Text) == int.Parse("64".ToString()) || int.Parse(txtJantar.Text) == int.Parse("65".ToString()) ||
                int.Parse(txtJantar.Text) == int.Parse("66".ToString()) || int.Parse(txtJantar.Text) == int.Parse("67".ToString()) ||
                int.Parse(txtJantar.Text) == int.Parse("68".ToString()) || int.Parse(txtJantar.Text) == int.Parse("69".ToString()))
            {
                // AQUI QUANDO GLICOSE NORMAL.
                //==================================
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
            }

            else
            {
                //
            }
        }

        private void btnCorrigirCeia_Click(object sender, EventArgs e)
        {
            // Ceia
            Trava_Campos();
            if (int.Parse(txtCeia.Text) >= int.Parse(txtParam1.Text.ToString()) && int.Parse(txtCeia.Text) <= int.Parse(txtParam1_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes da Ceia = " + txtCeia.Text + " Este Parâmetro Antes CEIA não necessita correção, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtCeia.Text) >= int.Parse(txtParam2.Text.ToString()) && int.Parse(txtCeia.Text) <= int.Parse(txtParam2_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes da Ceia = " + txtCeia.Text + " Este Parâmetro Antes CEIA não necessita correção, Colocar no campo OBSERVAÇÕES !!!", "AVISO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtCeia.Text) >= int.Parse(txtParam3.Text.ToString()) && int.Parse(txtCeia.Text) <= int.Parse(txtParam3_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes da Ceia = " + txtCeia.Text + " Corrigir com 01 (UMA) dose de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtCeia.Text) >= int.Parse(txtParam4.Text.ToString()) && int.Parse(txtCeia.Text) <= int.Parse(txtParam4_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes da Ceia = " + txtCeia.Text + " Corrigir com 02 (DUAS) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtCeia.Text) >= int.Parse(txtParam4_.Text.ToString()) && int.Parse(txtCeia.Text) <= int.Parse(txtParam5_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes da Ceia = " + txtCeia.Text + " Corrigir com 03 (TRÊS) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtCeia.Text) >= int.Parse(txtParam6.Text.ToString()) && int.Parse(txtCeia.Text) <= int.Parse(txtParam6_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes da Ceia = " + txtCeia.Text + " Corrigir com 04 (QUATRO) doses de insulina - ALERTA PARA HOSPITAL !!!", "PERIGO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }


            else if (int.Parse(txtCeia.Text) < int.Parse("60".ToString()))
            {
                // AQUI HIPOGLICEMIA.
                //==================================
                MessageBox.Show("Glicose antes da Ceia = " + txtCeia.Text + " Detectado HIPOGLICEMIA -> Repor Açucar Urgente !!!", "PERIGO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtCeia.Text) == int.Parse("60".ToString()) || int.Parse(txtCeia.Text) == int.Parse("61".ToString()) ||
                int.Parse(txtCeia.Text) == int.Parse("62".ToString()) || int.Parse(txtCeia.Text) == int.Parse("63".ToString()) ||
                int.Parse(txtCeia.Text) == int.Parse("64".ToString()) || int.Parse(txtCeia.Text) == int.Parse("65".ToString()) ||
                int.Parse(txtCeia.Text) == int.Parse("66".ToString()) || int.Parse(txtCeia.Text) == int.Parse("67".ToString()) ||
                int.Parse(txtCeia.Text) == int.Parse("68".ToString()) || int.Parse(txtCeia.Text) == int.Parse("69".ToString()))
            {
                // AQUI QUANDO GLICOSE NORMAL.
                //==================================
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
            }

            else
            {
                //
            }
        }

        private void btnFecharMes_Click(object sender, EventArgs e)
        {
            btnCorrigir.Enabled = false;
            btnCorrigirJantar.Enabled = false;
            btnCorrigirCeia.Enabled = false;
            btnCorrigirLanche.Enabled = false;
            DialogResult perg = MessageBox.Show("ATENÇÃO: Antes de Fechar o Mapa do mês " + DateTime.Now.Month.ToString() + " NÃO SE ESQUEÇA DE IMPRIMIR E/OU SALVAR O MAPA.                  " + "Deseja Fechar O Mes " + DateTime.Now.Month.ToString() + " Sim ou Não ?", "Fechamento Mapa Mensal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (perg != DialogResult.Yes)
            {
                MessageBox.Show("OK, Mantendo o Mês " + DateTime.Now.Month.ToString() + " em Aberto !!!", "Fechamento Mapa Mensal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_campos();
                Atualizar();
                MostraParametros();
                txtBuscaDia.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Mapa do mês " + DateTime.Now.Month.ToString() + " Encerrado com  êxito !!!", "Fechamento Mapa Mensal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FecharMes();
                Atualizar();
                txtBuscaDia.Focus();
            }
        }

        private void btnChamaForm_Click(object sender, EventArgs e)
        {
            frmManipularParametros fmp = new frmManipularParametros();
            fmp.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmImpMapa fimp = new frmImpMapa();
            fimp.Show();
        }

        private void btnCorrigirLanche_Click(object sender, EventArgs e)
        {
            // Lanche    
            Trava_Campos();
            if (int.Parse(txtLanche.Text) >= int.Parse(txtParam1.Text.ToString()) && int.Parse(txtLanche.Text) <= int.Parse(txtParam1_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Lanche = " + txtLanche.Text + " Corrigir com 01 (UMA) dose de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtLanche.Text) >= int.Parse(txtParam2.Text.ToString()) && int.Parse(txtLanche.Text) <= int.Parse(txtParam2_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Lanche = " + txtLanche.Text + " Corrigir com 01 (UMA) dose de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtLanche.Text) >= int.Parse(txtParam3.Text.ToString()) && int.Parse(txtLanche.Text) <= int.Parse(txtParam3_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Lanche = " + txtLanche.Text + " Corrigir com 01 (UMA) dose de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtLanche.Text) >= int.Parse(txtParam4.Text.ToString()) && int.Parse(txtLanche.Text) <= int.Parse(txtParam4_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Lanche = " + txtLanche.Text + " Corrigir com 02 (DUAS) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtLanche.Text) >= int.Parse(txtParam4_.Text.ToString()) && int.Parse(txtLanche.Text) <= int.Parse(txtParam5_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Lanche = " + txtLanche.Text + " Corrigir com 03 (TRÊS) doses de insulina e caso tenha esquecido, Colocar no campo OBSERVAÇÕES !!!", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtLanche.Text) >= int.Parse(txtParam6.Text.ToString()) && int.Parse(txtLanche.Text) <= int.Parse(txtParam6_.Text.ToString()))
            {
                MessageBox.Show("Glicose antes do Lanche = " + txtLanche.Text + " Corrigir com 04 (QUATRO) doses de insulina - ALERTA PARA HOSPITAL !!!!", "PERIGO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                return;
            }

            else if (int.Parse(txtLanche.Text) < int.Parse("60".ToString()))
            {

                // AQUI HIPOGLICEMIA.
                //==================================
                MessageBox.Show("Glicose antes do Lanche = " + txtLanche.Text + " Detectado HIPOGLICEMIA -> Repor Açucar Urgente !!!", "PERIGO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
                return;
            }

            else if (int.Parse(txtLanche.Text) == int.Parse("60".ToString()) || int.Parse(txtLanche.Text) == int.Parse("61".ToString()) ||
                int.Parse(txtLanche.Text) == int.Parse("62".ToString()) || int.Parse(txtLanche.Text) == int.Parse("63".ToString()) ||
                int.Parse(txtLanche.Text) == int.Parse("64".ToString()) || int.Parse(txtLanche.Text) == int.Parse("65".ToString()) ||
                int.Parse(txtLanche.Text) == int.Parse("66".ToString()) || int.Parse(txtLanche.Text) == int.Parse("67".ToString()) ||
                int.Parse(txtLanche.Text) == int.Parse("68".ToString()) || int.Parse(txtLanche.Text) == int.Parse("69".ToString()))
            {
                // AQUI QUANDO GLICOSE NORMAL.
                //==================================
                Alterar();
                btnInserir.Enabled = false;
                btnDeletar.Enabled = false;
                Atualizar();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvPaciente.FirstDisplayedScrollingRowIndex = dgvPaciente.RowCount - 1;
                Trava_Campos();
            }

            else
            {
                //
            }
        }
    }
}

#endregion 
