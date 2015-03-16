using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xD {
    class Employee {

        private string firstName;
        private string lastName;
        private int age;
        private float salary;
        private static int count;
       
        public Employee() {
            count++;
        }

        public Employee(string first, string last, int age, float salary, string city) {
            this.firstName = first;
            this.lastName = last;
            this.age = age;
            this.salary = salary;
            this.CITY = city;
            count++;
        }

        public void SetName(string first) {
            this.firstName = first.ToUpper();
        }

        public string GetName() {
            if (this.firstName == null)
                return "No";
            else
                return this.firstName;

        }

//---------------------------------------------------


        public void SetAge(int age) {
            this.age = (age > 100 || age < 18) ? 0 : age;
        }

        public int GetAge() {
            return this.age;
        }
//---------------------------------------------------

 

        public string LASTNAME {
            get { if (this.lastName == null)
                return "No";
            else
                return this.lastName;
            }
            set { this.lastName = value; }
        }
//----------------------------------------------------
        public void SetSalary(int howmuch) {
            this.salary = howmuch;
        }

        public float GetSalary() {
            return this.salary;
        }

//----------------------------------------------------

        public string CITY { get; set; }

        public override string ToString() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return string.Format(@" First Name = {0}
 Last Name = {1}
 Age = {2}
 Salary = {3}
 City = {4}", firstName, lastName, age, salary, CITY);
        }

        public static int COUNT {
            get { return count; }

        }



        static void Main(string[] args) {
            Employee emp1 = new Employee();
            Console.WriteLine(emp1.ToString());
            emp1.SetName("Пушкин");
            emp1.SetAge(32);
            emp1.LASTNAME = "Саня";
            emp1.CITY = "China";
            emp1.SetSalary(15);
            Console.WriteLine();
            Console.WriteLine(emp1.ToString());

            Employee emp2 = new Employee("Барак","Обама",33,320, "Minsk");
            Console.WriteLine(emp2.ToString());
            Console.WriteLine("Количество работничков = {0}", Employee.COUNT);
        }

    }
}
