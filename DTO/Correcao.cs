using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Correcao
    {
        public Int32 IdCorrecao { get; set; }
        public Int32 Parametro_Minimo { get; set; }
        public Int32 Parametro_Maximo { get; set; }
        public Int32 Dose_Cafe { get; set; }
        public Int32 Dose_Almoco { get; set; }
        public Int32 Dose_Lanche { get; set; }
        public Int32 Dose_Jantar { get; set; }
        public Int32 Dose_Ceia { get; set; }
    }
}
