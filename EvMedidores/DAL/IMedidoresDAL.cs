using EvMedidores.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvMedidores.DAL
{
    public interface IMedidoresDAL
    {
        List<String> ObtenerListaTipo();
        List<Medidor> ObtenerListaMedidores();
        List<Medidor> FiltrarXTipo(String tipo);


        Boolean ExisteMedidor(int id);

        Boolean AgregarMedidor(String id,String tipo);

        string largoListaMedidores();


    }
}
