using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTeoria
{
    class Perro:Animal 
    {

        public string Ladrar()
        {
            return "y va adrando.";        
        }


        public override string run()
        {
            return " El perro esta corriendo "; 
                   //base.run();
        }
    }
}
