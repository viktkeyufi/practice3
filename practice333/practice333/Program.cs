using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice333;

    public class Program
    {
        public static void Main(string[] args)
        {
        Console.WriteLine("Введите номер задания");
        int choice = Convert.ToInt32(Console.ReadLine());
        EmployeeBoock employee = new EmployeeBoock();
        switch (choice) {
            case 1:
                employee.FullInfo();
                break;
            case 2:
                employee.FullSalary();  
                break;
            case 3:
                employee.MinSalary();
                break; 
            case 4:
                employee.MaxSalary();
                break;
            case 5:
                employee.AverageSalary();
                break;
            case 6:
                employee.IndexSalary();
                break;
            case 7:
                employee.MinSalaryDepart();
                break;
            case 8:
                employee.MaxSalaryDepart();    
                break;  
            case 9:
                employee.AverageSalaryDepart();
                break;
            case 10:
                employee.IndexSalaryDepart();
                break; 
            case 11:
                employee.FullInfoDepart();
                break;
            case 12:
                employee.AddNew();
                break;
            case 13:
                employee.Delete();
                break;
            case 14:
                employee.EmployeeInDepartment();
                break;


        }
        }
    }


