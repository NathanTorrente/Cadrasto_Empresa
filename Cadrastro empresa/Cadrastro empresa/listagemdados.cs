using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cadrastro_empresa
{
    public class listagemdados
    {
        public string cnpj { get; set; }
        public string razaoSocial { get; set; }

        public string nomefantasia { get; set; }

        public string situacaocadrastal { get; set; }
        public string Regimetributario { get; set; }

        public string datainicio { get; set; }

        public string telefone { get; set; }

        public string capitalsocial { get; set; }
        public string enderecocompleto { get; set; }
        public string tipo { get; set; }
        public string porte { get; set; }   
        public string naturezajuris { get; set; }    

        public string nomeproprietario { get; set; }
        public string cpfpropri { get; set; }

    }
}
