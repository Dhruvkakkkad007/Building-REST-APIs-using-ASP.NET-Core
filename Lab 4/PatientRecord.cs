using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
     abstract class PatientRecord
    {
        public abstract void CompileRecord();
        
    }

    class InpatientMedicalRecord : PatientRecord
    {
        public override void CompileRecord()
        {
            Console.WriteLine("Compiling Inpatient Medical Record");
        }
    }

    class OutpatientMedicalRecord : PatientRecord
    {
        public override void CompileRecord()
        {
            Console.WriteLine("Compiling Outpatient Medical Record");
        }
    }
}
