using System;


namespace Busi.Alessandro._5H.SecondaWeb.Models
{
         public class Persona 
         {
             public int PersonaId {get;set;}

             public string Nome {get;set;}

             public string Cognome {get;set;}

             public DateTime Data { get; set; } = DateTime.Now;

         } 
}