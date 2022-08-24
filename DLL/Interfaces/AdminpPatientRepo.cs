using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Interfaces
{
   public  interface AdminpPatientRepo<CLASS, ID>
    {
        List<CLASS> GetPatient();
        int Patientcount();
    }
}
