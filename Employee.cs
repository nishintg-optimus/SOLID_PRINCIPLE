using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLE_12_NOV
{
    
    public class Employee
    {
        public string EmployeeType
        {
            get;
            set;
        }
        public double TotalHoursWorked
        {
            get;
            set;
        }
     
        public void Save(Employee emp)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.LogError(ex.Message);
            }
        }
    }

    public enum empType
    {
        FullTime,
        PartTime
    }
}
