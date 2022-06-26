using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvMedidores.DAL
{
    public class Medidor
    {
        private string idmedidor;
        private string tipo;

        public string Id { get => idmedidor; set => idmedidor = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {
            return idmedidor;
        }
    }
}
