using System;

namespace myApp
{
    class Program
    {
        static decimal StartGuess(decimal Lower, decimal Upper)
        {
            return Math.Round((Lower + Upper) / 2);
        }

        static void Main(string[] args)
        {
            decimal Upper = 100;
            decimal Lower = 1;
            decimal Guess = Math.Round((Lower + Upper) / 2);

                System.Console.WriteLine("Please pick a number between 1 and 100, then type 'okay'");
                var number = int.Parse(System.Console.ReadLine());
                while (Guess != number)
                {
                    System.Console.WriteLine($"Is it {Guess}? If so type \"yes\", if its higher type \"higher\", if its lower type \"lower\"");
                    var response = System.Console.ReadLine();
                    if (response == "lower")
                    {
                    Upper = Guess - 1;
                        Guess = StartGuess(Lower, Upper);
                    }
                    else if (response == "higher")
                    {
                        Lower = Guess + 1;
                        Guess = StartGuess(Lower, Upper);
                    }
                    else if (response == "yes")
                    {
                        Guess = StartGuess(Lower, Upper);
                    }
                    else
                    {
                        System.Console.WriteLine($"Something went wrong, start over!");
                    }
                }
                
            }
        }
    }

    
//start with upper=1000 and lower=1, divide in half for first guess
//if person says higher, take guess and add one to equal 'lower', run function (lower + upper /2)
//return amount. if person says lower, take current guess and subtract one to equal 'upper', run function (lower + upper/2)
//return amount. continue until solution is reached, return, "I guessed it!"