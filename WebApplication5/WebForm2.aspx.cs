using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Gato gato = new Gato
            {
                Age = 10,
                Name = "Flufly"
            };

            //me hago una lista de gato
            List<Gato> listaGatos = new List<Gato>
            {
                new Gato {Age = 2, Name="Miso"},
                new Gato {Age=9 , Name="Maya" }
            };
            //añado el primer gato individual a la lista para obtener la lista completa
            foreach (Gato gatitos in listaGatos)
            {
                Response.Write(string.Format("{0}-{1}", gatitos.Name, gatitos.Age));
                Response.Write("<br>");
            }
        }
    }
}