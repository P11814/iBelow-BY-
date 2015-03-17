

//Написать приложение, которое будет отображать в консоли заданные пользователем простейшие геометрические фигуры. 

//Пользователь выбирает фигуру и задает ее расположение на экране, а также размер и цвет с помощью меню. 

//Все заданные пользователем фигуры отображаются одновременно на экране. 

//Фигуры (прямоугольник, ромб, треугольник, трапеция, многоугольник) рисуются звездочками или другими символами. 

//Для реализации программы необходимо разработать иерархию классов (продумать возможность абстрагирования). 

//Все заданные пользователем фигуры хранить в объекте «Коллекция геометрических фигур», который имеет метод «отобразить все фигуры». 

//Отображение всех заданных фигур указанным методом должно осуществляться с помощью конструкции foreach, для чего необходимо классу 

//«Коллекция геометрических фигур» реализовать соответствующие интерфейсы.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace task {

    public class Sharp {
        public double a_side;
        public double b_side;
        public double c_side;
        public double d_side;
        public double e_side;
        public double f_side;
        public double p_triange;
        public double alpha;
        public double s_triangle;
    }

    #region Triangle
    class Triangle : Sharp {

        public Triangle() { }
        public Triangle(double a_side, double b_side, double c_side) {
            this.a_side = a_side;
            this.b_side = b_side;
            this.c_side = c_side;
        }

        public double A_SIDE {
            get {
                if (this.a_side == null) {
                    return 0;
                } else
                    return this.a_side;
            }
            set {
                this.a_side = value;
            }
        }


        public double B_SIZE {
            get {
                if (this.b_side == null)
                    return 0;
                else
                    return this.b_side;
            }
            set {
                this.b_side = value;
            }
        }

        public double C_SIZE {
            get {
                if (this.c_side == null)
                    return 0;
                else
                    return this.c_side;
            }
            set {
                this.c_side = value;
            }
        }

        public void TR_CHECK() {
            Console.ForegroundColor = ConsoleColor.Green;
            if (a_side + b_side < c_side || a_side + c_side < b_side || b_side + c_side < a_side) {     // a + b <c && a + c <b && b + c <a

                Console.WriteLine("Треугольник не может существовать");
            } else {
                Console.WriteLine("Треугольник существует");
                p_triange = a_side + b_side + c_side;
                Console.WriteLine("Периметр треугольника = {0}", p_triange);
                double pp_triange = p_triange / 2;
                s_triangle = Math.Sqrt(pp_triange * (pp_triange - a_side) * (pp_triange - b_side) * (pp_triange - c_side));
                Console.WriteLine("Площадь треугольника = {0}", s_triangle);
            }
        }

        public void TR_What_is() {
            Console.ForegroundColor = ConsoleColor.Red;
            if (a_side == b_side && a_side == c_side && b_side == c_side)
                Console.WriteLine("Треугольник равнобедренный");
            else if (a_side * a_side + b_side * b_side == c_side * c_side && b_side * b_side + c_side * c_side == a_side * a_side && a_side * a_side + c_side * c_side == b_side * b_side) {
                Console.WriteLine("Треугольник \'Прямоугольный\'");

            } else if (a_side == b_side & a_side == c_side) {
                Console.WriteLine("Треугольник \'Равносторонний\'");
            } else {
                Console.WriteLine("Треугольник \'Разносторонний\'");
            }

        }
        public override string ToString() {
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (alpha == 0)
                return string.Format("\t A-side = {0}\n\t B-side = {1}\n\t C-side = {2}", a_side, b_side, c_side);
            else
                return string.Format("\t A-side = {0}\n\t B-side = {1}\n\t C-side = {2}\n\t alpha = {3}", a_side, b_side, c_side, alpha);
        }



    }



    #endregion

    #region Rectangle
    public class Rectangle : Sharp {
        public Rectangle() { }
        public Rectangle(double a_side, double b_side) {
            this.a_side = a_side;
            this.b_side = b_side;
        }

        public double A_SIDE {
            get {
                if (this.a_side == null) {
                    return 0;
                } else
                    return this.a_side;
            }
            set {
                this.a_side = value;
                c_side = a_side;

            }
        }
        public double B_SIDE {
            get {
                if (this.b_side == null) {
                    return 0;
                } else
                    return this.b_side;
            }
            set {
                this.b_side = value;
                d_side = b_side;
            }
        }

        public void RC_CHECK() {
            if (a_side > 0 & b_side > 0)
                Console.WriteLine("Rectangle is good  =)");

            else
                Console.WriteLine("Error");
        }


        public override string ToString() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return string.Format("\t A-side = {0}\n\t B-side = {1}\n\t", a_side, b_side);
        }
    #endregion


        class Program {
            static void Main(string[] args) {
                Triangle emp1 = new Triangle();
                emp1.A_SIDE = 6;
                emp1.B_SIZE = 8;
                emp1.C_SIZE = 10;
                emp1.TR_CHECK();
                emp1.TR_What_is();
                Console.WriteLine(emp1.ToString());
                Console.ReadLine();
                Rectangle emp2 = new Rectangle();
                emp2.A_SIDE = 5;
                emp2.B_SIDE = 10;
                emp2.RC_CHECK();
                Console.WriteLine(emp2.ToString());

            }
        }

    }
}






