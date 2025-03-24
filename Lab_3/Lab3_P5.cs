using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("General Hospital Details");
        }
    }
    public class Apollo : Hospital 
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Apollo Hospital: Known for its advanced medical facilities and comprehensive healthcare services.");
        }
    }

    public class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Wockhardt Hospital: Renowned for its cardiac care and patient-centric approach.");
        }
    }

    public class Gokul_Superspeciality :Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul Superspeciality Hospital: Offers a wide range of super-specialty services and expert medical care.");
        }
    }
}
