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