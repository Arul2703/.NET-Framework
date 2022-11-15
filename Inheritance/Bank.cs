interface IBankAccount{
  void depositMoney(int money);
  void checkBalance();
  void transferMoney();
  void displayAccountDetails();
}

class BankAccount{

  // data members
  private string customerName;
  private double accountNumber;
  public int customerId;
  private double mobileNumber;
  private string address;
  private int accountBalance = 1000;

  public BankAccount(string customerName,double accountNumber,int CId,double mobileNumber,string address){
    this.customerName = customerName;
    this.accountNumber = accountNumber;
    this.customerId = CId;
    this.mobileNumber = mobileNumber;
    this.address = address;
  }
  // getters and settters
  public string CustomerName{
    get{ return customerName; }
    set{ customerName = value;}
  }

  public double AccountNumber{
    get{ return accountNumber;}
    set{
      accountNumber = value;
    }
  }
  public double MobileNumber{
    get{ return mobileNumber;}
    set{
      mobileNumber = value;
    }
  }

  public void createAccount(){
    Console.WriteLine("Enter the details to create Bank Account.");
    Console.Write("Customer Name: ");
    customerName = Console.ReadLine();
  }
   public void withdrawMoney(int money){ // method to withdraw money from account
    if(accountBalance<money){
      Console.WriteLine("Sorry, Your account has insufficient balance.");
    }
    else {
      accountBalance = accountBalance-money;
      Console.WriteLine("Balance after Withdrawal : "+accountBalance);
    }  
  }
  public void depositMoney(int money){ // method to deposit money
    accountBalance = accountBalance + money;
    Console.WriteLine("Balance after Deposit : "+accountBalance);
  }
 
  public void checkBalance(){ // method to check the account balance
    Console.WriteLine("Your current balance is : "+accountBalance);
  }

}







