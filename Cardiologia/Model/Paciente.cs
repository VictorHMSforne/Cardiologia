using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardiologia.Model
{
    public class Paciente
    {
        public int Id{ get; set; }
        public int registro { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public string cor { get; set; }
        public DateTime data_nascimento { get; set; }
    }
}
