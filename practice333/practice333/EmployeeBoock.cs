using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice333
{
    internal class EmployeeBoock
    {
        private List<Employee> employees = new List<Employee>()
    {
        new Employee("Рыбакова Вероника Никитична", 1 , 40000),
        new Employee("Крючков Иван Никитич", 2 , 45000),
        new Employee("Васильев Михаил Матвеевич", 1 , 45222),
        new Employee("Черная Анна Кирилловна", 1 , 36444),
        new Employee("Никифорова Дарья Михайловна", 2 , 41548),
        new Employee("Медведева Ирина Фёдоровна", 3, 56123),
        new Employee("Дьяконова Есения Марковна", 3 , 60000),
        new Employee("Горбачева Василиса Андреевна", 2 , 41593),
        new Employee("Никифоров Арсений Александрович", 3 , 65231),
        new Employee("Лазарева Алёна Михайловна", 1 , 50273),
    };
       public void FullInfo()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Имя: {employee.FullName}, " +
                    $"Отдел: {employee.Department}," +
                    $"Зарплата: {employee.Salary}");
            }
        }

        public void FullSalary()
        {
            double sum = 0;

            foreach (var employee in employees)
            {
                sum += employee.Salary;
            }
        }

      public void MinSalary()
        {
            Console.WriteLine($"Минимальная зарплата: {employees.Min(e => e.Salary + "у" + e.FullName)}");
        }

      public void MaxSalary()
        {
            Console.WriteLine($"Мнимальная зарплата: {employees.Max(e => e.Salary + "у" + e.FullName)}");
        }

      public void AverageSalary()
        {
            Console.WriteLine($"Среднее значение зарплат: {employees.Average(e => e.Salary)}");
        }

      public void FullFio()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Имена всех сотрудников: {employee.FullName}");
            }

        }
      public void IndexSalary()
        {
            Console.WriteLine("Введите процент");
            double ind = Convert.ToDouble(Console.ReadLine());

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Salary *= ind);
            }

        }

      public void MinSalaryDepart()
        {
            Console.WriteLine("Введите номер отдела");
            double department = double.Parse(Console.ReadLine());
            var employeesInDepartment = employees.Where(e => e.Department == department);
            if (employeesInDepartment.Any())
            {
                var employeeMinSalary = employeesInDepartment.OrderBy(e => e.Salary).First();
                Console.WriteLine($"Человек с самой минимальной зарплатой в отделе {department}: {employeeMinSalary.FullName} - {employeeMinSalary.Salary} рублей");
            }
        }

     public  void MaxSalaryDepart()
        {
            Console.WriteLine("Введите номер отдела");
            int choicedepart3 = int.Parse(Console.ReadLine());
            var employeeDepart = employees.Where(e => e.Department == choicedepart3);

            if (employeeDepart.Any())
            {
                var employeeMinSalary = employeeDepart.OrderBy(e => e.Salary).First();
                Console.WriteLine($"Человек с минимальной зарплатой в отделе {choicedepart3}: {employeeMinSalary.FullName}");
            }
        }

      public  void AverageSalaryDepart()
        {
            int count = 0;
            double averagesalary = 0;
            Console.WriteLine("Введите отдел");
            int choicedepart = int.Parse(Console.ReadLine());
            foreach (var employee in employees)
            {
                count++;
                averagesalary += employee.Salary;
            }
            averagesalary /= count;
            Console.WriteLine($"Средняя зарплата по отделу{averagesalary}");
        }

       public void IndexSalaryDepart()
        {
            Console.WriteLine("Введите отдел");
            int choicedepart2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент");
            double indexdepart = double.Parse(Console.ReadLine());

            foreach (var employee in employees)
            {
                if (employee.Department == choicedepart2)
                {
                    employee.Department *= choicedepart2;
                    Console.WriteLine($"Зарплата равна: {employee}");
                }
            }

        }

       public void FullInfoDepart()
        {
            Console.WriteLine("Введите отдел");
            int choicedepart = int.Parse(Console.ReadLine());

            foreach (var employee in employees)
            {
                if (employee.Department == choicedepart)
                {
                    Console.WriteLine($"В этом отделе: {employee.FullName}, его зарплата: {employee.Salary}");
                }
            }

        }
        public void AddNew()
        {
            Console.WriteLine("Введите имя сотрудника");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Добавьте отдел сотрудника");
            int depar = int.Parse(Console.ReadLine());
            Console.WriteLine("Добавьте зарплату");
            double sal = double.Parse(Console.ReadLine());

            employees.Add(new Employee(fullName: name, depatment: depar, salary: sal));
            Console.WriteLine("Сотрудник добавлен");

        }

        public void Delete()
        {
            Console.WriteLine("Выберите сотрудника которого хотите удалить");
            int delname = int.Parse(Console.ReadLine());

            foreach (var employee in employees)
            {
                if (employee._id == delname)
                {
                    employees.Remove(employee);
                    break;
                }
            }
            Console.WriteLine("Список сотрудников после удаления:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FullName);
            }
        }
        public void EmployeeInDepartment()
        {
            var empindep = employees.OrderBy(empindep =>  empindep.Department);
            foreach (var employee in empindep)
            {
                Console.WriteLine($"Сотрудник в отделе {employee.Department} - {employee.FullName}");
            }
        }
    }
}
