using EvMedidores.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ev3Medidores
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        private IMedidoresDAL medidoresDAL = new ListaMedidoresDAL();
        protected void Page_Load(object sender, EventArgs e)
        {           
        }
        

        
    }
}