using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTeoria
{
    //CLASE PADRE O BASE 
    class Animal
    {
        public int animalAge { get; set;  }
        public Boolean animalFur { get; set; }
       


        //metodos

        public string getInfo()
        {
            var fur = "";
            if (animalFur == true)
            {
                fur = "Tiene pelo";
            }
            else
            {
                fur = "no tiene pelo "; 
            }
            return " El animal tiene  " + animalAge + "  años, y " + fur; 


        }



        public string  walk()
        {
            return " El animal esta caminando solo   ";
        }

        //overload del moetod walk 
        public string walk(string name, string owner)
        {
            return " El  " + name + " esta caminando con " + owner;
        }

        //este metodo se debe sobreescribir 
        public virtual string  run()
        {
            return " y El animal esta corriendo ";
        }

        
    }
}
