using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class voto
    {

        private int votosBrancos;
        private int votosNulos;
        private int votosValidos;

        public int VotosBrancos
        {
            get
            {
                return votosBrancos;
            }

            set
            {
                votosBrancos = value;
            }
        }

        public int VotosNulos
        {
            get
            {
                return votosNulos;
            }

            set
            {
                votosNulos = value;
            }
        }

        public int VotosValidos
        {
            get
            {
                return votosValidos;
            }

            set
            {
                votosValidos = value;
            }
        }
    }
}
