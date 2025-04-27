using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE
{
    internal class Ventas
    {
       public string ID {  get; set; }
        public int ID_Evento{ get; set; }
        [DataType(DataType.Date)]   
        public DateTime Fecha { get; set; }
        
        public string tipo_boleto { get; set;}
        public int cantidad { get; set; }
        public int total { get; set; }
        
    }
}
