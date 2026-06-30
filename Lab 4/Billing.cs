using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
     abstract class  Billing
    {   
        public abstract double CalculateBill();  
    }

    class InPatientBilling : Billing
    {
        public override double CalculateBill()
        {
            int roomCharge = 1000;
            int treatmentCharge = 500;
            return roomCharge + treatmentCharge; 
        }
    }

    class OutPatientBilling : Billing
    {
        public override double CalculateBill()
        {
           int consultationFee = 200;
            int treatmentCharge = 300;
            return consultationFee + treatmentCharge;
        }
    }
}
