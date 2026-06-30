using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class MedicalEquipment
    {
        public int serviceFee = 1000;
    }

    class DiagnosticScanner : MedicalEquipment
    {
        

        public int calculateTotalCost()
        {
            int CAA = 500;
            return serviceFee + CAA;
        }
    }
}
