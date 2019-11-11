using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosiChange.Classes
{
    public class Mudanca
    {
        internal Paciente Patient { get; set; }
        public DateTime Proxima { get; set; }
        internal Posicao Position { get; set; }
        public DateTime Tempo { get; set; }


    }
}
