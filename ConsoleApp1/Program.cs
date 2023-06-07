using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

    /*class Calculator {
                    private double operand1;
                    private double operand2;
                    private string operator;

                    //getters
                    public double getOperand1() {return this.operand1}  
                    public double getOperand2() {return this.operand2} 
                    public string getOperator() {return this.operator} 

                    //setters
                    public void setOperand1(double operand1) {this.operand1 = operand1}  
                    public void setOperand2(double operand2) {this.operand2 = operand2} 
                    public void setOperator(string operator) {this.operator = operator} 

                    public void calculate(operand1, operand2, operator)
                    {
                        ...logic
                    }
                }*/

    /*class Calculator
    {
        private Stack<string> calculation;

        //getters
        public Stack<string> getCalculation() { return this.calculation; }

        //setters
        public void setCalculation(Stack<string> calculation) { this.calculation = calculation; }

        public void calculate(double operand1, double operand2, string operatorVal)
        {
            ...logic
                }
    }*/

namespace ConsoleApp1
{
    public class Program
    {
        //POSSIBLE CLASES: CALCULATOR, SCREEN, NUMBERBUTTONS, OPERATIONBUTTONS


        class Screen
        {

            //field
            private double result;

            public double getResult() { return this.result; }
            public void setResult(double result) { this.result = result; }

            //method
            public void display()
            {
                Console.WriteLine("Result: " + this.result);
            }

        }

        class NumberButton
        {

            //field
            private double operand;

            //getter
            public double getOperand() { return this.operand; }

            //setter
            public void setOperand(double operand) { this.operand = operand; }

        }

        class OperatorButton
        {

            //field
            private string operatorVal;

              //getter
              public string getOperatorVal() { return this.operatorVal; }

            //setter
            public void setOperatorVal(string operatorVal) { this.operatorVal = operatorVal; }

        }

        class Calculator
        {
            public double calculate(double operand1, double operand2, string operatorVal)
            {
                double result = 0;

                switch (operatorVal)
                {
                    case "+":
                        result = operand1 + operand2;
                        break;

                    case "-":
                        result = operand1 - operand2;
                        break;

                    case "*":
                        result = operand1 * operand2;
                        break;

                    case "/":
                        result = operand1 / operand2;
                        break;
                }

                return result;
            }
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("---- POLISH CALCULATOR ----");
            Console.WriteLine("---- FORMAT EXAMPLE: \"2 2 +\" OR \"47 7 *\" ----");
            Console.WriteLine("\t");

            //New Classes
            NumberButton operand1 = new NumberButton();
            NumberButton operand2 = new NumberButton();
            OperatorButton operatorVal = new OperatorButton();
            Calculator calculator = new Calculator();
            Screen screen = new Screen();

            try
            {
                while (true)
                {
                    Console.WriteLine("\t");
                    Console.WriteLine("Enter a calculation:");

                    string s = Console.ReadLine();
                    if (s == "") break;

                    Stack<string> tks = new Stack<string>(s.Split(' '));

                    if (tks.Count < 3 || Double.TryParse(tks.ElementAt(0), out double z))
                    {
                        throw new ArgumentException("Format Error");
                    }

                    if (!Double.TryParse(tks.ElementAt(2), out double x) || !Double.TryParse(tks.ElementAt(1), out double y))
                    {
                        throw new ArgumentException("Format Error");
                    }

                    operand1.setOperand(Convert.ToDouble(tks.ElementAt(2)));
                    operand2.setOperand(Convert.ToDouble(tks.ElementAt(1)));
                    operatorVal.setOperatorVal(tks.ElementAt(0));

                    double result = calculator.calculate(operand1.getOperand(), operand2.getOperand(), operatorVal.getOperatorVal());

                    screen.setResult(result);
                    screen.display();
                }
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }
            
        }
    }
}

