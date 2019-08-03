using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using DTO;
using ConexaoSqlServer;

namespace Regras_De_Negocios
{
    public class Negocios_Paciente
    {
        Conect conec = new Conect();

        public String Inserir_Pacientes (Pacientes pacientes)
        {
            try
            {
                conec.LimparParametros();
                // Não é Necessario o IdCliente, pois a chave é Auto Incremento.
                conec.AddParametros("@Nome", pacientes.Nome);
                conec.AddParametros("@Dia", pacientes.Dia);
                conec.AddParametros("@Antes_Cafe", pacientes.Antes_Cafe);
                conec.AddParametros("@Antes_Almoco", pacientes.Antes_Almoco);
                conec.AddParametros("@Antes_Lanche", pacientes.Antes_Lanche);
                conec.AddParametros("@Antes_Jantar", pacientes.Antes_Jantar);
                conec.AddParametros("@Antes_Ceia", pacientes.Antes_Ceia);
                conec.AddParametros("@Observacoes", pacientes.Observacoes);
                String IdPaciente = conec.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InserirPaciente").ToString();
                conec.FecharConexao();
                return IdPaciente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public String Altera_Pacientes(Pacientes pacientes)
        {
            try
            {
                conec.LimparParametros();
                conec.AddParametros("@IdPaciente", pacientes.IdPaciente);
                conec.AddParametros("@Nome", pacientes.Nome);
                conec.AddParametros("@Dia", pacientes.Dia);
                conec.AddParametros("@Antes_Cafe", pacientes.Antes_Cafe);
                conec.AddParametros("@Antes_Almoco", pacientes.Antes_Almoco);
                conec.AddParametros("@Antes_Lanche", pacientes.Antes_Lanche);
                conec.AddParametros("@Antes_Jantar", pacientes.Antes_Jantar);
                conec.AddParametros("@Antes_Ceia", pacientes.Antes_Ceia);
                conec.AddParametros("@Observacoes", pacientes.Observacoes);
                String IdPaciente = conec.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraPaciente").ToString();
                conec.FecharConexao();
                return IdPaciente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public String Exclui_Pacientes(Pacientes pacientes)
        {
            try
            {
                conec.LimparParametros();
                conec.AddParametros("@IdPaciente", pacientes.IdPaciente);
                String IdPaciente = conec.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_ExcluiPaciente").ToString();
                conec.FecharConexao();
                return IdPaciente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Pacientes_Colecao BuscaPorDia(Int32 Dia)
        {
            try
            {
                Pacientes_Colecao Colecao = new Pacientes_Colecao();
                conec.LimparParametros();
                conec.AddParametros("@Dia", Dia);
                DataTable dt = conec.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaPacienteDia");

                foreach (DataRow linhas in dt.Rows)
                {
                    Pacientes pacientes = new Pacientes();
                    pacientes.IdPaciente = Convert.ToInt32(linhas["IdPaciente"]);
                    pacientes.Nome = Convert.ToString(linhas["Nome"]);
                    pacientes.Dia = Convert.ToInt32(linhas["Dia"]);
                    pacientes.Antes_Cafe = Convert.ToInt32(linhas["Antes_Cafe"]);
                    pacientes.Antes_Almoco = Convert.ToInt32(linhas["Antes_Almoco"]);
                    pacientes.Antes_Lanche = Convert.ToInt32(linhas["Antes_Lanche"]);
                    pacientes.Antes_Jantar = Convert.ToInt32(linhas["Antes_Jantar"]);
                    pacientes.Antes_Ceia = Convert.ToInt32(linhas["Antes_Ceia"]);
                    pacientes.Observacoes = Convert.ToString(linhas["Observacoes"]);
                    Colecao.Add(pacientes);
                    conec.FecharConexao();
                }
                return Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Pacientes_Colecao BuscaPorNome (String Nome)
        {
            try
            {
                Pacientes_Colecao Colecao = new Pacientes_Colecao();
                conec.LimparParametros();
                conec.AddParametros("@Nome", Nome);
                DataTable dt = conec.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaPacienteNome");

                foreach (DataRow linhas in dt.Rows)
                {
                    Pacientes pacientes = new Pacientes();
                    pacientes.IdPaciente = Convert.ToInt32(linhas["IdPaciente"]);
                    pacientes.Nome = Convert.ToString(linhas["Nome"]);
                    pacientes.Dia = Convert.ToInt32(linhas["Dia"]);
                    pacientes.Antes_Cafe = Convert.ToInt32(linhas["Antes_Cafe"]);
                    pacientes.Antes_Almoco = Convert.ToInt32(linhas["Antes_Almoco"]);
                    pacientes.Antes_Lanche = Convert.ToInt32(linhas["Antes_Lanche"]);
                    pacientes.Antes_Jantar = Convert.ToInt32(linhas["Antes_Jantar"]);
                    pacientes.Antes_Ceia = Convert.ToInt32(linhas["Antes_Ceia"]);
                    pacientes.Observacoes = Convert.ToString(linhas["Observacoes"]);
                    Colecao.Add(pacientes);
                    conec.FecharConexao();
                }
                return Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
