using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    class Teacher:persona 
    {
        public string TeacherNo;

        public void setTeacherNo(string maestro)
        {
            TeacherNo = maestro; 
        }

        public override string playBasketball()
        {
            return " es el  maestro y  esta jugando ";
        }
        
           
        
    }
}
