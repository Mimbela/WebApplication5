using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<int> listaEnteros = new List<int>();
            listaEnteros.Add(24);
            listaEnteros.Add(2);
            listaEnteros.Add(3);
            listaEnteros.Add(11);
            listaEnteros.Add(7);
            listaEnteros.Add(1);

            var data = (from n in listaEnteros
                        where n == 3
                        select n).FirstOrDefault();// FIRSTORDEFAULT devuelve el primer elemento o cero si no existe
            if (data>0)
            {
                Response.Write(data);
            }
            else
            {
                Response.Write("Dato no encontrado");
            }
            var otraConsulta = from n in listaEnteros
                               select n;
            int suma = otraConsulta.Sum(); //me suma todo con .sum
            decimal media = Convert.ToDecimal(otraConsulta.Average());

            int contador = otraConsulta.Count(); //cuenta los elementos con .count
            int maximo = otraConsulta.Max(); //maxinmo
            int minimo = otraConsulta.Min(); // minimo
                                             //**************************************************EJERCICIO
                                             //*******sacar los menor de 5 y mostrar por pantalla
                                             //suma de todos los resultados 
            int[] numeros = new int[] { 0, 4, 2, 6, 3, 8, 3, 1 }; //27

            var lista = from n in numeros
                        select n;
            int suma1 = lista.Sum();
            //Response.Write(suma1);

            var queryLambda = numeros //consulta anterior en expresión lambda
                .Where(n => n < 5)  //n va a ser menor que su valor a 5
                .OrderByDescending(n => n)
                .Distinct()
                .Select(n => n);

            var mayores = (from f in numeros  //EXPRESION CLASICA
                           where f < 5
                           orderby f descending
                           select f).Distinct();

            foreach (int i in queryLambda)
            {
                //Response.Write(i);
                //    Response.Write("<br>");
            }
            //***************************************************************EJERCICIO
            String[] pajaros = { "canario", "aguila", "jilguero", "arraca", "pinguino", "PINGUINO" };
            //seleccionar empieza por a
            //a jilguero
            //seleccionar ascendentemente

            var queryLambda1 = pajaros
                .Where(p => p.StartsWith("a"))
                .OrderBy(p => p)
                .Select(p => p);

            var queryLambda2 = pajaros
                .Where(j => j == "jilguero")
                .Select(j => j)
                .FirstOrDefault();

            foreach (string s in queryLambda1)
            {
                Response.Write(s);
                Response.Write("<br>");
            }
            //foreach (string u in queryLambda2)
            //{
            //    Response.Write(u);
            //    Response.Write("<br>");
            //}


        }
    }
}