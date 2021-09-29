using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTeoria
{
    // CLASE HIJA O DERIVADA 
    //definir la releacion herencia entre gato y animal 
    class Gato:Animal 
    {
        //prpiedades
        public int vidas { get; set;  }

        //metodos
        public string meuw()
        {
            return "meeeeuuuuuwww";
        }

            //metodo sobreescrito
            public override string run()
            {
              return base.run ()+ " El gato esta coriendo....";
                
            }
    }
    
}
