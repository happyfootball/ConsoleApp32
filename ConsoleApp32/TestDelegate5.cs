using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    //定义冒泡排序类
    class BubbleSorter
    {
        static public void Sort(object [] sortArray,CompareOp gtMethod)
        {
            for (int i = 0; i < sortArray.Length; i++)
            {
                for (int j = 0; j < sortArray.Length; j++)
                {
                    if (gtMethod(sortArray[j],sortArray[i]))
                    {
                        object temp = sortArray[i];
                        sortArray[i] = sortArray[j];
                        sortArray[j] = temp;
                    }
                }
                
            }
        }
    }

    //定义员工类实例

    class Employee {
        private string name;
        private decimal salary;

        public Employee(string name,decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public override string ToString() {
            return string.Format(name+",{0:C}",salary);
        }

        public static bool RhsIsGreater(object lhs, object rhs) {
            Employee empLhs=(Employee)lhs;
            Employee empRhs = (Employee)rhs;
            return (empRhs.salary>empLhs.salary);

        }
    }


    delegate bool CompareOp(object lhs, object rhs);
    class TestDelegate5
    {
        static void Main()
        {
            Employee[] employees =
            {
            new Employee("Bugs Bunny", 20000),
            new Employee("Elmer Fudd ", 10000),
            new Employee("Daffy Duck", 25000),
            new Employee("Wiley Coyote", (decimal)1000000.38),
            new Employee("Foghorn Leghorn", 23000),
            new Employee("RoadRunner'", 50000)};
            CompareOp employeeCompareOp = new CompareOp(Employee.RhsIsGreater);
            BubbleSorter.Sort(employees, employeeCompareOp);
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].ToString());
            }
            Console.ReadLine();

        }
    }
}

