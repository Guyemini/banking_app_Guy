using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app
{
    public class Program
    {
        static void Main(string[] args)
        {
            // יצירת לקוחות
            Customer customer1 = new Customer(1, "Yossi Cohen", 123456789);
            Customer customer2 = new Customer(2, "Noa Levi", 987654321);

            // הדפסת פרטי הלקוחות
            customer1.PrintDetails();
            customer2.PrintDetails();

            // יצירת חשבונות
            CheckingAccount account1 = new CheckingAccount(1001, 5000, customer1);
            CheckingAccount account2 = new CheckingAccount(1002, 300, customer2);

            // הדפסת יתרות
            account1.PrintBalance();
            account2.PrintBalance();

            // הפקדה ומשיכה
            account1.Deposit(1000);
            account1.PrintBalance();

            account2.Withdraw(200); 
            account2.Withdraw(2000); 

            // יצירת סניף
            BankBranch branch = new BankBranch(1, "10 Bank Street, Tel Aviv");

            // הוספת חשבונות לסניף
            branch.AddAccount(account1);
            branch.AddAccount(account2);

            // הדפסת פרטי כל החשבונות בסניף
            Console.WriteLine(" List of accounts in the branch ");
            branch.PrintAccounts();



        }
    }
}
