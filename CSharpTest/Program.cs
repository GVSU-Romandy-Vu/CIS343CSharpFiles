// See https://aka.ms/new-console-template for more information
using System;

namespace CSharpTest{
    class Calculator{
        
        static void add(string val1, string val2){
            float first = 0;
            float sec = 0;
            bool isVal1Num = float.TryParse(val1, out first);
            bool isVal2Num = float.TryParse(val2, out sec);
            if(isVal1Num && isVal2Num){
                float result = first + sec;
                Console.WriteLine("Result: " + result);
            }
            else{
                Console.WriteLine("Error, Try again.");
            }
        }

        static void sub(string val1, string val2){
            float first = 0;
            float sec = 0;
            bool isVal1Num = float.TryParse(val1, out first);
            bool isVal2Num = float.TryParse(val2, out sec);
            if(isVal1Num && isVal2Num){
                float result = first - sec;
                Console.WriteLine("Result: " + result);
            }
            else{
                Console.WriteLine("Error, Try again.");
            }
        }

        static void mult(string val1, string val2){
            float first = 0;
            float sec = 0;
            bool isVal1Num = float.TryParse(val1, out first);
            bool isVal2Num = float.TryParse(val2, out sec);
            if(isVal1Num && isVal2Num){
                float result = first * sec;
                Console.WriteLine("Result: " + result);
            }
            else{
                Console.WriteLine("Error, Try again.");
            }
        }

        static void div(string val1, string val2){
            float first = 0;
            float sec = 0;
            bool isVal1Num = float.TryParse(val1, out first);
            bool isVal2Num = float.TryParse(val2, out sec);
            if(isVal1Num && isVal2Num && sec != 0){
                float result = first / sec;
                Console.WriteLine("Result: " + result);
            }
            else{
                Console.WriteLine("Error, Try again.");
            }
        }

        
        
        static void Main(string[] args){
            string? val1 = "";
            string? val2 = "";
            string? op = "";
            Console.WriteLine("Hello World!");

            while(true){
                Console.WriteLine("Enter a number or 'q' to quit.");
                val1 = Console.ReadLine();
                
                if(val1.Contains('q')){
                    break;
                }

                Console.WriteLine("Enter an operation +, -, *, / or 'q' to quit");
                op = Console.ReadLine();

                if(op.Contains('q')){
                    goto end;
                }

                Console.WriteLine("Enter another number or 'q' to quit.");
                val2 = Console.ReadLine();
                if (val2.Contains('q')){
                    break;
                }

                if(String.Compare(op, "+") == 0){
                    Calculator.add(val1, val2);

                }
                else if(String.Compare(op, "-") == 0){
                    Calculator.sub(val1, val2);

                }

                else if(String.Compare(op, "*") == 0){
                    Calculator.mult(val1, val2);

                }
                else if(String.Compare(op, "/") == 0){
                    Calculator.div(val1, val2);

                }
                else{
                    Console.WriteLine("Error, Try again.");
                }

            }
            end:
            Console.WriteLine("Ended program");
            

        }
    }
}
