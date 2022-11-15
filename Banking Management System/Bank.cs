// Title: Bank Management System
// Author : Arularasi
// Created at : 04/10/2022
// Updated at : 08/10/2022
// Reviewed by: 
// Reviewed at: 
/*
interface IBankAccount{
  void depositMoney(int money);
  void checkBalance();
  void displayAccountDetails();
}
class BankAccount : IBankAccount{
  private int balance = 1000;
  private int accountNo;
  private string name;
  private int mobileNumber;
  public string bankName;
  public string bankBranchName;
  public int loanAccountNo;
  private int loanAmount;
  private string loanDescription;
  

  // Constructor
  public BankAccount(int accountNo,string name,int balance,string bankName , string branchName){  
    this.accountNo = accountNo;
    this.name = name;
    this.balance = balance;
    this.bankName = bankName;
    bankBranchName = branchName;
  }

  
  public string Name{
    get{  return name; }
    set{
      name = value;
    }
  }

  public int AccountNo{
    get{ return accountNo;}
    set{
      accountNo = value;
    }
  }
  public int LoanAccountNo{
    get{ return loanAccountNo;}
    set{
      loanAccountNo = value;
    }
  }
  public int LoanAmount{
    get{ return loanAmount;}
    set{
      loanAmount = value;
    }
  }
  public int Balance{
    get{ return balance;}
    set{
      balance = value;
    }
  }

  public void withdrawMoney(int money){ // method to withdraw money from account
    if(balance<money){
      Console.WriteLine("Sorry, Your account has insufficient balance.");
    }
    else {
      balance = balance-money;
      Console.WriteLine("Balance after Withdrawal : "+balance);
    }  
  }
  public void depositMoney(int money){ // method to deposit money
    balance = balance + money;
    Console.WriteLine("Balance after Deposit : "+balance);
  }
 
  public void checkBalance(){ // method to check the account balance
    Console.WriteLine("Your current balance is : "+balance);
  }

  public void displayAccountDetails(){ // method to display the account details
    Console.WriteLine("Account No : "+accountNo);
    Console.WriteLine("Name : "+Name); 
    Console.WriteLine("Balance : "+balance);
  }

  public virtual void getLoan(int loanAccountNo,string loanDescription,int money){
    loanAmount += money;
  }


  public virtual void displayLoanDetails(){
    Console.WriteLine("Loan Account Number: "+loanAccountNo); 
    Console.WriteLine("Loan Amount : "+loanAmount);
  }

}

class StateBankOfIndia: BankAccount{ 

  private string address;
  private int CIFNumber;
  private string mobileNumber;
  private double loanAmount;
  public double rateOfInterest = 7.75;
  public double interest;
  public int loanAccountNo;
  public StateBankOfIndia(int accountNo,string name,int CIFNumber,int balance,string bankName, string branchName,string address,string mobileNumber):base(accountNo,name,balance,bankName,branchName){
    this.address = address;
    this.mobileNumber = mobileNumber;
    this.CIFNumber = CIFNumber;
  }

  public override void getLoan(int loanAccountNo,string loanDescription,int money){
    this.loanAccountNo = loanAccountNo;
    loanAmount+=money;
    interest = (loanAmount*1*rateOfInterest)/100;
  }
  public override void displayLoanDetails(){
    Console.WriteLine("Loan Account Number: "+loanAccountNo);
    Console.WriteLine("Loan Amount : "+loanAmount);
    Console.WriteLine("Interest : "+interest);
  }
  
}


*/