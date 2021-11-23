using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Gestion_Instalacion_APP.Modelos
{
    public class App
    {
        public int Id { get; set; }
        [Required] //Encima de la propiedad lo deja obligatorio (using System.ComponentModel.DataAnnotations;)
        public string Nombre { get; set; }

    }
}
