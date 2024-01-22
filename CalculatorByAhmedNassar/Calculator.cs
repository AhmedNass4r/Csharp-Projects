using System;

namespace CalculatorByAhmedNassar
{
    class Program 
    {
        public static void Main(string []args)
        {   
            label:

            Console.WriteLine("By Ahmed Nassar");
            double num1,num2,result;

            Console.Write("Choose an operation + , - , * , / , % , quit : ");
            string UserChoice = Convert.ToString(Console.ReadLine());

            UserChoice = UserChoice.ToLower();

            Console.WriteLine();
            
            try
            {

                switch(UserChoice)
                {
                    case "+":

                        Console.Write("Enter the first number : ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the Second number : ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine();

                        result = num1 + num2;
                        Console.WriteLine("the result of {0} + {1} is {2}",num1,num2,result);

                        Console.WriteLine();

                        goto label;
                    
                    case "-":

                        Console.Write("Enter the first number : ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the Second number : ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine();

                        result = num1 - num2;
                        Console.WriteLine("the result of {0} - {1} is {2}",num1,num2,result);

                        Console.WriteLine();

                        goto label;
                    
                    case "*":

                        Console.Write("Enter the first number : ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the Second number : ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine();

                        result = num1 * num2;
                        Console.WriteLine("the result of {0} X {1} is {2}",num1,num2,result);

                        Console.WriteLine();

                        goto label;
                    
                    case "/":
                        
                        Console.Write("Enter the first number : ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the Second number : ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        if(num2 == 0)
                        {   
                            Console.WriteLine();
                            Console.WriteLine("Can't divide by Zero!");
                            Console.WriteLine();
                            goto label;
                        }
                        else
                        {   
                            Console.WriteLine();
                            result = num1 / num2;
                            Console.WriteLine("the result of {0} / {1} is {2}",num1,num2,result);
                            Console.WriteLine();
                            goto label;
                        }  

                    case "%":

                        Console.Write("Enter the first number : ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the Second number : ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        if(num2 == 0)
                        {   
                            Console.WriteLine();
                            Console.WriteLine("Can't divide by Zero!");
                            Console.WriteLine();
                            goto label;
                        }
                        else
                        {   
                            Console.WriteLine();
                            result = num1 % num2;
                            Console.WriteLine("the result of {0} % {1} is {2}",num1,num2,result);
                            Console.WriteLine();
                            goto label;
                        }

                    case "quit":
                            break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("invalid input!");
                        Console.WriteLine();
                        goto label;
                    
                }
            
            }
            
            catch(FormatException)
            {   
                Console.WriteLine();
                Console.WriteLine("Enter numbers only!");
                Console.WriteLine();
                goto label;
            }
            
            
        }
    }
}
