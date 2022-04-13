using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerE_EscreverJSON
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
    }
}
