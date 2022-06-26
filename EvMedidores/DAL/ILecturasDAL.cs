using EvMedidores.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvMedidores.DAL
{
    public interface ILecturasDAL
    {
        void AgregarLectura(String id, DateTime fecha, String consumo);

        List<Lectura> ObtenerLecturas();

        List<Lectura> FiltrarXIdMedidor(String id);

        string largoLista();
    }
}
