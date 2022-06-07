using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEmpresta
{
    internal class Filme
    {
        public string codFilme { get; set; }
        public string titulo { get; set; }
        public Categoria categoria;
    }
}
