using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    class persona
    {
        public string name;
        public string getname()
        {
            return name;
        }

        public void setname(string nombre )
        {
            name = nombre;
        }

        public virtual string playBasketball()
        {
            return " Esta jugando ";
        }
    }
                          // Naser Audeli Claros Rivera. Codigo SMIS099121
                          // Alexis Manuel Calix Magaña. Codigo SMIS021821

}       




