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
    }
}