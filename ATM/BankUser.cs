using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace ATM
{
  public class BankUser {
    public string firstName {  get; set; }
    public string lastName { get; set; }
    public string cardNumber { get; set; }
    public int Pin {  get; set; }
    public decimal balance { get; set; }
    
    
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
    
  }
}