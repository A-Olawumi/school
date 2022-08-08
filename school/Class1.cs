using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public abstract class Registration
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string DOB { get; set; }
        public string Grade { get; set; }   
        
        public bool IsSchoolBus { get; set; }
        public bool IsSchoolFeesPaid { get; set; }
        public int GradeId { get; set; }
        public string HouseAddress ()
        {
            return "houseaddress number";

        }
        public int HouseAddress( int housenumber)
        {
            return housenumber;
        }
        
       
         
       

        public abstract string Firstterm(bool IsSchoolBus);

        public abstract string Firstterm2(bool IsSchoolFeesPaid);
        

        }
    }
    


