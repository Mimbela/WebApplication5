using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    //OPERADORES LINQ TO OBJETC

    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var Persona = new { FirstName = "Jhon", LastName = "Freddy", Age = 23, IdPersona = 2 };
            ////trabajo con una variable anonima que son variables anonimas sin tipo
            ////trabajo con una variable anonima que son variables anonimas sin tipo


            //***********************************************EJEMPLO LINQ DE ARRAY
            //ESTO ES UNA ESTRUCTURA DE ARRAY INT
            int[] fiboNumbers = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            var data = from n in fiboNumbers
                       where n % 2 == 0
                       select n;

            foreach (int dato in data)
            {
                Response.Write(dato);
                Response.Write("<br>");
            }

            //********************************************OTRO EJEMPLO LINQ DE CADENA
            //convertirlos a mayuscula y devuelva
            string[] tools = { "martillo", "destornillador", "alicate", "tornillo" };
            var lista = from t in tools
                        select t.ToUpper();

            foreach (string s in lista)
            {
                Response.Write(s);
                Response.Write("<br>");
            }






















        }
    }
}