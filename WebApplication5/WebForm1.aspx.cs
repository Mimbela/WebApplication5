using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //FORMA DE MANEJAR LISTAS GENÉRICAS
            //creo una lista, admite todos los metodos de order list. si añado, add. LA INSTANCIAMOS

            List<int> listaEnteros = new List<int>();
            listaEnteros.Add(1);
            listaEnteros.Add(2);
            listaEnteros.Add(3);
            listaEnteros.Add(4);

            foreach (int elemento in listaEnteros)
            {
                Response.Write(elemento); //en asp se usa response para imprimir
                Response.Write("<br>");
            }
            //******************************************inicializo y declaro a la vez 
            //******************************************manera individual:
            Persona personaHumana = new Persona
            {
                IdPersona = 1,
                FirstName = "Nancy",
                LastName = "Davolyo",
                Age = 23
                //control j DENTRO de las llaves, saco los atributos de la clase persona
                //creo objeto nuevo de persona y le declaro directamente los atributos

            };

            //*************************************manera grupañ
            //*********************En vez de trabajar con una unica persona lo expando:
            List<Persona> listaPersonas = new List<Persona>
            {
                new Persona {IdPersona=3, Age=32, LastName="kiko" , FirstName="uiee" },
                new Persona {IdPersona=5,Age=22, FirstName="gerte" , LastName="retnu" },
                new Persona {IdPersona=8 , Age=42, LastName="wedst" , FirstName="jeqa" }
            };
            //lo recorro
            foreach (Persona persona in listaPersonas)
            {
                Response.Write(string.Format("{0} , {1} ", persona.FirstName, persona.Age));
                Response.Write("<br>");
            }
        }
    }
}
//get lectura
 //    set escritura