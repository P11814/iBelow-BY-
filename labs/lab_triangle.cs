/*
 * Created by SharpDevelop.
 * User: iBelow[BY]
 * Date: 11.03.2015
 * Time: 18:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 //что это за номер лр?
//1) Создать класс «Сторона» для хранения длины стороны фигуры. Обеспечить проверку на правильность ввода данных. Предусмотреть свойства для получения состояния объекта.
//Создать класс «Треугольник», обеспечивающий следующие возможности:
//• установку и получение длин сторон треугольника;
//• проверку на существование треугольника с заданными длинами сторон;
//• расчет периметра и площади треугольника;
//• определение типов треугольника: равнобедренный, равносторонний, разносторонний; остроугольный, тупоугольный, прямоугольный.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task {

    class side {
        private double a_side;
        private double b_side;
        private double c_side;
        private double p_triange;
        private double alpha;
        private double s_triangle;
        public side() { }
        public side(double a_side, double b_side, double c_side) {
            this.a_side = a_side;
            this.b_side = b_side;
            this.c_side = c_side;
            
        }
        /// <summary>
        /// A_SIDE
        /// </summary>
        public double A_SIDE {
            get {
                if (this.a_side == null) { //a_side типа double, не стоит его сравнивать с null, лучше с 0.0
                    return 0;
                } else
                    return this.a_side;
            }
            set {
                this.a_side = value;
            }
        }

        /// <summary>
        /// B_SIDE
        /// </summary>
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
        /// <summary>
        /// C_SIDE
        /// </summary>
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
            Console.ForegroundColor = ConsoleColor.Green; // настройка консоли делается в main
            if (a_side + b_side < c_side || a_side + c_side < b_side || b_side + c_side < a_side) {     // a + b <c && a + c <b && b + c <a

                Console.WriteLine("Треугольник не может существовать");
            } else {
                Console.WriteLine("Треугольник существует");
                p_triange = a_side + b_side + c_side;
                Console.WriteLine("Периметр треугольника = {0}", p_triange); // для подсчета периметра и площади должны быть
                //организованы отдельные методы, а не мотод проверки существования трегуольника
                
				/// <summary>
				/// ТУТ формума площади треугольника
				/// </summary>
                
				///Console.WriteLine("test = {0}",dt);
                
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

            } else if(a_side == b_side & a_side == c_side){
                Console.WriteLine("Треугольник \'Равносторонний\'");
            } 
            
            else {
                Console.WriteLine("Треугольник \'Разносторонний\'");
            }
        }
        
        
 

        public override string ToString() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if(alpha == 0)
            	return string.Format("\t A-side = {0}\n\t B-side = {1}\n\t C-side = {2}", a_side, b_side, c_side);
            else
            return string.Format("\t A-side = {0}\n\t B-side = {1}\n\t C-side = {2}\n\t alpha = {3}", a_side, b_side, c_side, alpha);
        }

        class Program {
            static void Main(string[] args) {
                side emp1 = new side();
                emp1.A_SIDE = 6; // дайте пользователю возможность самому всести данные по треугольнику
                emp1.B_SIZE = 8;
                emp1.C_SIZE = 10;
                emp1.TR_CHECK();
                emp1.TR_What_is();
                Console.WriteLine(emp1.ToString());
				Console.ReadLine();
            }
        }
    }
}
