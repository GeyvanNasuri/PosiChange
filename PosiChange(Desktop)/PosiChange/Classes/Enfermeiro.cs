using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosiChange.Classes
{
    public class Enfermeiro
    {
        public int CodEnfermeiro { get; set; }
        public string Nome { get; set; }
        internal List<Nivel> Nivel { get; set; }
        public int Coren { get; set; }
        public string Turno { get; set; }
        public DateTime Intervalo { get; set; }
        public string Telefone { get; set; }
    }
}
