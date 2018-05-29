using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ArrayList arrList = new ArrayList();
            arrList.Add(
                new Estudiante
                {
                    Nombre = "Ana",
                    Apellido = "pope",
                    Scores = new int[] { 6, 4, 5, 7 }
                }
                );

            arrList.Add(
                new Estudiante
                {
                    Nombre = "Isaac",
                    Apellido = "Palma",
                    Scores = new int[] { 3, 8, 5 }

                }
                );

            arrList.Add(
                new Estudiante
                {
                    Nombre = "Sandra",
                    Apellido = "lio",
                    Scores = new int[] { 4, 2, 9, 8 }

                }
                );
            var query = from Estudiante estudiante in arrList
                        where estudiante.Scores[0] > 5
                        select estudiante;
            foreach (Estudiante s in query)
            {
                Response.Write(String.Format("{0} - {1}", s.Nombre, s.Apellido));
                Response.Write("<br>");
            }




        }
    }
}