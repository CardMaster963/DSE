using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE
{
    internal class eventos
    {
        public int id_evento { get; set; }
        public string nombre { get; set; }
        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }  
        public string lugar {  get; set; }

        
        public TimeSpan hora{ get; set; }
        public int precio_preventa {  get; set; }
        public int precio_taquilla {  get; set; }  
        public int capacidad_personas { get; set; }
        
    }
}
