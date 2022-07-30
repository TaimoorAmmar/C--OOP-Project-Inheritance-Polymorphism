using System;

namespace Q2
{
    public class Employee
    {
        private int baseSalary = 1500;
        private int fuelAllowance;
        private int medicalAllowance;
        public virtual int getFuelAllowance()
        {
            return this.fuelAllowance;
        }
        public virtual int getMedicalAllowance()
        {
            return this.medicalAllowance;
        }
        public int getBaseSalary()
        {
            return this.baseSalary;
        }

    }

    public class Engineer : Employee
    {
        private int fuelAllowance = 100;
        private int medicalAllowance = 500;

        public override int getFuelAllowance()
        {
            return this.fuelAllowance;
        }
        public override int getMedicalAllowance()
        {
            return this.medicalAllowance;
        }

    }
    public class Manager : Employee
    {
        private int fuelAllowance = 250;
        private int medicalAllowance = 1000;

        public override int getFuelAllowance()
        {
            return this.fuelAllowance;
        }
        public override int getMedicalAllowance()
        {
            return this.medicalAllowance;
        }

    }
    public class Analyst : Employee
    {
        private int fuelAllowance = 150;
        private int medicalAllowance = 800;

        public override int getFuelAllowance()
        {
            return this.fuelAllowance;
        }
        public override int getMedicalAllowance()
        {
            return this.medicalAllowance;
        }

    }

    public class SalarySlip
    {
        private Employee employee;
        private string designation;

      
        public SalarySlip(string designation)
        {
            this.designation = designation;
        }



        public int getGrossSalary()
        {
            if (this.designation == "engineer" )
            {
                Engineer engineer = new Engineer();

                this.employee = engineer;
            }
            else if (this.designation == "manager")
            {
                Manager manager = new Manager();

                this.employee = manager;
            }
            else if (this.designation == "analyst")
            {
                Analyst analyst = new Analyst();

                this.employee = analyst;
            }
            else
            {
                Console.WriteLine("Please enter a correct designation");
            }
            int baseSalary = employee.getBaseSalary();
            int fuelAllowance = employee.getFuelAllowance();
            int medicalAllowance = employee.getMedicalAllowance();
            int totalGross = baseSalary + fuelAllowance + medicalAllowance;
            return totalGross;
        }
    }
    class Program
    {

       

        static void Main(string[] args)
        {
            Console.WriteLine("\n Enter a designation i.e 'engineer', 'manager' or 'analyst'");
            string designation = Console.ReadLine();
            SalarySlip salary = new SalarySlip(designation);
            
            Console.WriteLine("Gross Salary is = $"+ salary.getGrossSalary());

        }
    }
}
