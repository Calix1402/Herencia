using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    class Student:persona 
    {

        public string StudentNo;
        
        public void setStudent( string  estuadinte)
        {
            StudentNo = estuadinte; 
        }
       

        public override string playBasketball()
        {
            return " es el estudiante y esta jugando "; 
        }
             
       
       
    }
}
