using System.ComponentModel.Design;
using System.Linq;

namespace ATM
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<BankUser> users = new List<BankUser>();
      addfakedata(users);
      Console.WriteLine("WELCOME TO ATM...");
      while (true)
      {
        Console.WriteLine("CardNum:");
        string cardnum= Console.ReadLine();
        Console.WriteLine("pin:");
        int pin;
        if(int.TryParse(Console.ReadLine(), out pin)) 
        {
          if(BankUser.checkPin(users,cardnum!,pin))
          {
            BankUser user = BankUser.GetUser(users,cardnum,pin);
            Console.WriteLine($"Welcome {user.firstName} {user.lastName} :)");
            Options();
            int choose;
            do
            {
              if (int.TryParse(Console.ReadLine(), out choose))
              {
                if (choose == 1) BankUser.deposit(user);
                else if (choose == 2) BankUser.withdraw(user);
                else if (choose == 3) BankUser.showBalance(user);
                else if (choose == 4) break;
              }
              else
              {
                choose = 0;
                Console.WriteLine("Invalid Input");
              }

            }
            while (choose != 4);
            Console.WriteLine("Thank you for banking with us");

          }

          else
          {
            Console.WriteLine("Invalid Data...");
          }
        }
        else
        {
          Console.WriteLine("Invalid Input");
        }

      }
    }
    public static void addfakedata(List<BankUser> users)
    {

      users.Add(new BankUser
      {
        firstName = "sherif",
        lastName = "Mahdy",
        cardNumber = "0000000",
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
    static void Options()
    {
      Console.WriteLine("Please choose from one of the following...");
      Console.WriteLine("1. Deposite");
      Console.WriteLine("2. Withdraw");
      Console.WriteLine("3. Show Balance");
      Console.WriteLine("4. Exit");
    }   
  }
}