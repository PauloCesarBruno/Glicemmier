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
    public class Negocios_Correcao
    {
        Conect conect = new Conect();

        public String Inserir_Correcao(Correcao correcao)
        {
            try
            {
                conect.LimparParametros();
                conect.AddParametros("@IdCorrecao", correcao.IdCorrecao);
                conect.AddParametros("@Parametro_Minimo", correcao.Parametro_Minimo);
                conect.AddParametros("@Parametro_Maximo", correcao.Parametro_Maximo);
                conect.AddParametros("@Dose_Cafe", correcao.Dose_Cafe);
                conect.AddParametros("@Dose_Almoco", correcao.Dose_Almoco);
                conect.AddParametros("@Dose_Lanche", correcao.Dose_Lanche);
                conect.AddParametros("@Dose_Jantar", correcao.Dose_Jantar);
                conect.AddParametros("@Dose_Ceia", correcao.Dose_Ceia);
                String IdCorrecao = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InsereCorrecao").ToString();
                conect.FecharConexao();
                return IdCorrecao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public String Altera_Correcao(Correcao correcao)
        {
            try
            {
                conect.LimparParametros();
                conect.AddParametros("@IdCorrecao", correcao.IdCorrecao);
                conect.AddParametros("@Parametro_Minimo", correcao.Parametro_Minimo);
                conect.AddParametros("@Parametro_Maximo", correcao.Parametro_Maximo);
                conect.AddParametros("@Dose_Cafe", correcao.Dose_Cafe);
                conect.AddParametros("@Dose_Almoco", correcao.Dose_Almoco);
                conect.AddParametros("@Dose_Lanche", correcao.Dose_Lanche);
                conect.AddParametros("@Dose_Jantar", correcao.Dose_Jantar);
                conect.AddParametros("@Dose_Ceia", correcao.Dose_Ceia);
                String IdCorrecao = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlteraCorrecao").ToString();
                conect.FecharConexao();
                return IdCorrecao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
                      
        public Correcao_Colecao BuscaCorrecaoParametro (Int32 PMinimo)
        {
            try
            {
                Correcao_Colecao Colecao = new Correcao_Colecao();
                conect.LimparParametros();
                conect.AddParametros("@Parametro_Minimo", PMinimo);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaCorrecaoParamMinimo");
                foreach (DataRow linhas in dt.Rows)
                {
                    Correcao correcao = new Correcao();
                    correcao.IdCorrecao = Convert.ToInt32(linhas["IdCorrecao"]);
                    correcao.Parametro_Minimo = Convert.ToInt32(linhas["Parametro_Minimo"]);
                    correcao.Parametro_Maximo = Convert.ToInt32(linhas["Parametro_Maximo"]);
                    correcao.Dose_Cafe = Convert.ToInt32(linhas["Dose_Cafe"]);
                    correcao.Dose_Almoco = Convert.ToInt32(linhas["Dose_Almoco"]);
                    correcao.Dose_Lanche = Convert.ToInt32(linhas["Dose_Lanche"]);
                    correcao.Dose_Jantar = Convert.ToInt32(linhas["Dose_Jantar"]);
                    correcao.Dose_Ceia = Convert.ToInt32(linhas["Dose_Ceia"]);
                    Colecao.Add(correcao);
                    conect.FecharConexao();
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
