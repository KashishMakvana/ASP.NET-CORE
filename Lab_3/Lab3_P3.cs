using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class RBI
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Interest rate as per RBI guidelines.");
        }
    }



    class HDFC : RBI
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Interest rate as per HDFC guidelines.");
        }
    }

    class SBI : RBI
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Interest rate as per SBI guidelines.");
        }
    }

    class ICICI : RBI
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Interest rate as per ICICI guidelines.");
        }
    }

}
