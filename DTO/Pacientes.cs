using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Pacientes
    {
        public Int32 IdPaciente { get; set; }
        public String Nome { get; set; }
        public Int32 Dia { get; set; }
        public Int32 Antes_Cafe { get; set; }
        public Int32 Antes_Almoco { get; set; }
        public Int32 Antes_Lanche { get; set; }
        public Int32 Antes_Jantar { get; set; }
        public Int32 Antes_Ceia { get; set; }
        public String  Observacoes { get; set; }       
    }
}
