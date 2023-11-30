public class cardHolder{
    string firstName;
    string secondName;
    int pin;
    double balance;
    string cardNumber;

    public cardHolder(string firstName,string secondName,int pin, double balance,string cardNumber)
    {
        this.firstName = firstName;
        this.secondName = secondName;
        this.pin = pin;
        this.balance = balance;
        this.cardNumber = cardNumber;

    }

    public string getFirstName(){
        return firstName;
    }
    public string getSecondName(){
        return secondName;
    }
    
    public int getPin()
    {
        return pin;
    }

    public string getCardNumber()
    {
        return cardNumber
    }
    public getBalance()
    {
        return balance;
    }

    public void setFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }
    public void setSecondName(string newSecondName)
    {
        secondName = newSecondName; 
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setCardNumber(string newCardNumber)
    {
        cardNumber = newCardNumber;
    }

    
}

public static void main(string[] args){

    void showOptions(){
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Deposit");
        Console.WriteLine("4. Exit");
    }

    void checkBalance(cardholder)
    {
        console.WriteLine($"your balance is {cardholder.getBalance}");
    }

    void deposit(cardholder)
    {
        

    }


}