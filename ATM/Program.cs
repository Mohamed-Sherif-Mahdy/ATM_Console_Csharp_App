using System.ComponentModel.Design;
using System.Linq;

namespace ATM
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<BankUser> users = new List<BankUser>();
      fakedata(users);
      Console.WriteLine("WELCOME TO ATM...");
      while (true)
      {
        Console.WriteLine("CardNum:");
        string cardnum= Console.ReadLine();
        Console.WriteLine("pin:");
        int pin=int.Parse(Console.ReadLine());
        if (users.Where(c => c.cardNumber == cardnum && c.Pin==pin)
                              .Count() == 1)
         
        {
          BankUser user = users.SingleOrDefault(c => c.cardNumber == cardnum && c.Pin == pin);
          Console.WriteLine($"Welcome {user.firstName} {user.lastName} :)");
          Options();
          int choose = 0;
          do
          {
            choose = int.Parse(Console.ReadLine());
            if (choose == 1) deposit(user);
            else if (choose == 2) withdraw(user);
            else if (choose == 3) showBalance(user);
            else if (choose == 4) break;
            else choose = 0;

          }
          while (choose != 4);
          Console.WriteLine("Thank you for banking with us");
           
        }


        else
        {
          Console.WriteLine("Invalid Data...");
        }
      }


      
        }

    static void Options()
    {
      Console.WriteLine("Please choose from one of the following...");
      Console.WriteLine("1. Deposite");
      Console.WriteLine("2. Withdraw");
      Console.WriteLine("3. Show Balance");
      Console.WriteLine("4. Exit");
    }
    static void deposit(BankUser user)
    {
      Console.WriteLine("How much $$ would you like to deposit? ");
      user.balance += decimal.Parse(Console.ReadLine());
      Console.WriteLine($"YOUR BALANCE IS:{user.balance}");


    }

    static void withdraw(BankUser user)
    {
      Console.WriteLine("How much $$ would you like to withdraw? ");
      decimal amount = decimal.Parse(Console.ReadLine());
      if(amount <= user.balance)
      {
        user.balance -= amount;
      }
      
      Console.WriteLine($"YOUR BALANCE IS:{user.balance}");


    }

    static void showBalance(BankUser user)
    {
      Console.WriteLine($"YOUR BALANCE IS:{user.balance}");
    }

    static void fakedata(List<BankUser> users)
    {
     
      users.Add(new BankUser {
        firstName = "sherif",
        lastName = "Mahdy",
        cardNumber="0000000",
        Pin = 1234,
        balance = 100.0M
        });

      users.Add(new BankUser
      {
        firstName = "medo",
        lastName = "Mahdy",
        cardNumber = "0000001",
        Pin = 1234,
        balance = 200.0M
      });

      users.Add(new BankUser
      {
        firstName = "noun",
        lastName = "Mahdy",
        cardNumber = "0000002",
        Pin = 1234,
        balance = 300.0M
      });

    }
  }
}