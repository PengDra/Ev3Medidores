using EvMedidores.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ev3Medidores
{
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new ListaMedidoresDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();
            }

        }
        private void cargarGrilla() {
            List<Medidor> medidores = medidoresDAL.ObtenerListaMedidores();
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
        }
        private void cargarGrilla(List<Medidor> filtrada)
        {
            
            this.grillaMedidores.DataSource = filtrada;
            this.grillaMedidores.DataBind();
        }
        protected void filtrarXTipoDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = this.filtrarXIdDdl.SelectedItem.Value;
            List<Medidor> filtrada = medidoresDAL.FiltrarXTipo(tipo);
            cargarGrilla(filtrada);
        }
    }
}