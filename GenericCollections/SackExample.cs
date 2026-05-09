using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public class SackExample
    {
        public void stackmethod()
        {
            string expression = "5 3 + 2 * 6 2 / -";

            double result = evaluateexpression(expression);
            Console.WriteLine($"result of expression: '{expression}' : {result}");
        }

        static double evaluateexpression(string expression)
        {
            //declare a stack collection object and use it to store values
            Stack<double> stack = new Stack<double>();
            string[] tokens = expression.Split(' ');

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    stack.Push(number); // push method function the same with the add method
                }
                else
                {
                    double operand2 = stack.Pop();
                    double operand1 = stack.Pop();
                    double tempresult = 0;

                    //apply the 4 mathemathical operations to the numbers then take out the results
                    // +  -  *  /

                    switch(token)
                    {
                        case "+":
                            tempresult = operand1 + operand2;
                            break;
                        case "-":
                            tempresult = operand1 - operand2;
                            break;
                        case "*":
                            tempresult = operand1 * operand2;
                            break;
                        case "/":
                            tempresult = operand1 / operand2;
                            break;
                        default:
                            throw new ArgumentException("invalid token" + token);
                    }

                    stack.Push(tempresult);
                }
            }
            return stack.Pop();
        }
    }
}
