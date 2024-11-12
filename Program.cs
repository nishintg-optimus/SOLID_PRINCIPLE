
//cohesion=how closely realted a single finctionality is.
//coupling =how interdepent two component are..
//tightly coupled =highly dependent.
//new =when we use new keyword then it is making it tightly coupled.
//with the help of dependency injection we can remove the tightly coupled that happens bcz of new keyword.

/*
 srp checklist
.decompose big problem into small
.apply the principle of cohesion and coupling to segregate group
.origin of changes.
 */

/*
 * open closed principle 
 * software entities like classes modules methods etc
 * should be open for extensions but closed for modification.
 */

/*
 * if you see multiple if else then it is a sign that use ocp principle\
 * inheritance + polymorphism used....
 */

/*
 * OCP CHECKLIST
 * Identify the ocp scope like too may switch or too much if
 * extract base class
 * define the child class
 */

/*
 * lsp checklist
 * figure out inheritance implementation
 * are parents all functionality child has?
 * if few child doesnt share the Parent functionality then seprate the
 * base class and apply lsp
 * /

using System;
namespace SOLID_PRINCIPLE_12_NOV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new string('-',70);

            Employee empFTE = new Employee()
            {
                EmployeeType = empType.FullTime.ToString(),
                TotalHoursWorked = 10
             };

            Employee empPTE = new Employee()
            {
                EmployeeType = empType.PartTime.ToString(),
                TotalHoursWorked = 5
            };

            //EmployeeFinances employeeFinances = new EmployeeFinances();
            //var totalpay = employeeFinances.CalculatePay(empFTE);
            //Console.WriteLine(totalpay);


            //EmployeeFinances employeeFinances = new EmployeeFinancesForFTE();
            //var totalpay = employeeFinances.CalculatePay(empFTE);
            //Console.WriteLine(totalpay);

            EmployeeFinances employeeFinances = new EmployeeFinancesForPTE();
            var totalpay = employeeFinances.CalculatePay(empPTE);
            var totalRewards=employeeFinances.CalculateRewards(empPTE);
            Console.WriteLine(totalpay+".."+totalRewards);

        }
    }
}
