using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Domain.Entities
{
    public class Cliente : Base
    {
        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool IsAtivo { get; set; }

    }
}
