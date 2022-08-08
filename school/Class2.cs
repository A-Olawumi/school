  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    internal class Berry : Registration
    {

        public override string Firstterm(bool IsSchoolBus )
        {
            if (IsSchoolBus)
            {
                return "enter your school bus ID number";
            }
            else
            {
                return "You are not eligible to this service";

            }


             

        }   
        public override string Firstterm2(bool IsSchoolFeesPaid )
        { 

        if (IsSchoolFeesPaid)
            {
                return "enter your receipt number";
            }
            else
            {
                return "error";
             } 
}

    }
}
