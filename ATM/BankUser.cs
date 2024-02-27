using System.Net.NetworkInformation;

namespace ATM
{
  public class BankUser {
    public string firstName {  get; set; }
    public string lastName { get; set; }
    public string cardNumber { get; set; }
    public int Pin {  get; set; }
    public decimal balance { get; set; }
        public BankUser(string firstName,string lastName,string cardNumber,int Pin,decimal balance)
        {
          this.firstName = firstName;
          this.lastName = lastName;
          this.cardNumber = cardNumber;
          this.Pin=Pin;
          this.balance = balance;
        }
        public BankUser()
        {
            
        }
    public static bool checkPin(List<BankUser> users,string cardnum,int pin)
    {
      if (users.Where(c => c.cardNumber == cardnum && c.Pin == pin)
                             .Count() == 1)
        return true;
      return false;
    }
    public static BankUser GetUser(List<BankUser> users,string cardnum, int pin)
    {
      return users.SingleOrDefault(c => c.cardNumber == cardnum && c.Pin == pin);
    }


    public static void deposit(BankUser user)
    {
      Console.WriteLine("How much $$ would you like to deposit? ");
      user.balance += decimal.Parse(Console.ReadLine());
      Console.WriteLine($"YOUR BALANCE IS:{user.balance}");


    }

    public static void withdraw(BankUser user)
    {
      Console.WriteLine("How much $$ would you like to withdraw? ");
      decimal amount = decimal.Parse(Console.ReadLine());
      if (amount <= user.balance)
      {
        user.balance -= amount;
      }

      Console.WriteLine($"YOUR BALANCE IS:{user.balance}");


    }

    public static void showBalance(BankUser user)
    {
      Console.WriteLine($"YOUR BALANCE IS:{user.balance}");
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
  }
}