using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bankkonto
{
    public class IaccountInterface
    {
        BankAccount oneaccount = new BankAccount();

        public void Greeting(){
            Console.Clear();
            string[] intro = {
                "Welcome to your account overview.",
                "Choose an option:"
            };

            foreach (var s in intro)
            {
                Console.WriteLine(s);
            }
        }

        public void Options(){
            string[] options = {
                "1. Check balance",
                "2. Withdraw money",
                "3. Deposit money",
                "0. Exit"
            };

            foreach (var s in options)
            {
                Console.WriteLine(s);
            }

            bool makechoice = true;
            
            while(makechoice){
                var choice = Console.ReadKey();
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        oneaccount.print();
                        break;

                    case ConsoleKey.D2:
                        try{oneaccount.withdraw(OptionInput("Withdraw"));}
                        catch(ArgumentOutOfRangeException exInvalidValue){
                            Console.WriteLine(exInvalidValue.ParamName);
                        }
                        break;

                    case ConsoleKey.D3:
                        oneaccount.deposit(OptionInput("Deposit"));
                        break;  

                    case ConsoleKey.D0:
                        makechoice = false;
                        break;

                    default:
                        Console.WriteLine("Choose a valid option.");
                        break;
                }
            }
        }

        int OptionInput(string chosen) {
            Console.WriteLine($"How much do you want to {chosen}?");
            int amount = int.Parse(Console.ReadLine());
            return amount;
        }
    }
}