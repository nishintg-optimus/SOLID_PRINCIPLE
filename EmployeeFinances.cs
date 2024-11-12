using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SOLID_PRINCIPLE_12_NOV
{

    public class EmployeeRewards
    {
        public virtual double CalculateRewards(Employee employee)
        {
            return 100;
        }
    }
    public class EmployeeFinances : EmployeeRewards
    {
        public virtual double CalculatePay(Employee emp)
        {
            //if(emp.EmployeeType==empType.FullTime.ToString())
            //{
            //    return emp.TotalHoursWorked * 10;
            //}

            //if (emp.EmployeeType == empType.PartTime.ToString())
            //{
            //    return emp.TotalHoursWorked * 5;
            //}
            return 1;
        }
        public virtual double CalculateRewards(Employee emp)
        {
            return 100;
        }
    }
    public class EmployeeFinancesForFTE : EmployeeFinances
    {
        public override double CalculatePay(Employee emp)
        {
            return emp.TotalHoursWorked*10;
        }
        public override double CalculateRewards(Employee emp)
        {
            return 100;
        }

    }

    public class EmployeeFinancesForPTE : EmployeeFinances
    {
       public override double CalculatePay(Employee emp)
        {
            return emp.TotalHoursWorked *5;
        }
        public override double CalculateRewards(Employee emp)
        {
            return -100;
        }
    }
    public class EmployeeFinancesForContractor : EmployeeRewards
    {
        //public override double CalculatePay(Employee emp)
        //{
        //    throw new NotImplementedException();
        //}
        public override double CalculateRewards(Employee emp)
        {
            return -1999;
        }
    }
}
