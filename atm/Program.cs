public class CardHolder
{
    string firstName;
    string secondName;
    int pin;
    double balance;
    string cardNumber;

    public CardHolder(string firstName, string secondName, int pin, string cardNumber)
    {
        this.firstName = firstName;
        this.secondName = secondName;
        this.pin = pin;
        this.balance = 0;
        this.cardNumber = cardNumber;
    }

    public string GetFirstName()
    {
        return firstName;
    }

    public string GetSecondName()
    {
        return secondName;
    }

    public int GetPin()
    {
        return pin;
    }

    public string GetCardNumber()
    {
        return cardNumber;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void SetFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }

    public void SetSecondName(string newSecondName)
    {
        secondName = newSecondName;
    }

    public void SetBalance(double newBalance)
    {
        balance = newBalance;
    }

    public void SetPin(int newPin)
    {
        pin = newPin;
    }

    public void SetCardNumber(string newCardNumber)
    {
        cardNumber = newCardNumber;
    }
}

class Program
{
    static void Main(string[] args)
    {
        void ShowOptions()
        {
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Exit");
        }

        void CheckBalance(CardHolder cardHolder)
        {
            Console.WriteLine($"Your balance is {cardHolder.GetBalance()}");
        }

        void Deposit(CardHolder cardHolder)
        {
            Console.WriteLine("How much do you want to deposit?");
            double depositAmount = Double.Parse(Console.ReadLine());
            double newBalance = cardHolder.GetBalance() + depositAmount;
            cardHolder.SetBalance(newBalance);
        }

        void Withdraw(CardHolder cardHolder)
        {
            Console.WriteLine("How much do you want to withdraw?");
            double withdrawalAmount = double.Parse(Console.ReadLine());

            if (withdrawalAmount > cardHolder.GetBalance()) 
            { 
                Console.WriteLine("Not enough funds");
            }
            else
            {
                double newBalance = cardHolder.GetBalance() - withdrawalAmount;
                cardHolder.SetBalance(newBalance);
            }
        }
        //test//

        void Balance(CardHolder cardHolder)
            {
                Console.WriteLine($"your balance is {cardHolder.GetBalance()}");
            }

        List<CardHolder> cardHolders = new List<CardHolder>();
        cardHolders.Add(new CardHolder("John", "Smith", 1234,"49184618204818274710"));
        cardHolders.Add(new CardHolder("Jane", "Doe", 4321, "49184618204818274711"));
        cardHolders.Add(new CardHolder("Bob", "Smith", 1111, "49184618204818274712"));
        cardHolders.Add(new CardHolder("Alice", "Doe", 2222, "49184618204818274713"));
        cardHolders.Add(new CardHolder("Eve", "Smith", 3333, "49184618204818274714"));

        Console.WriteLine("welcome");
        Console.WriteLine("Please enter your card number");
        string cardNum = "";
        CardHolder currentUser;

      while (true)
        {
            try
            {
                cardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.GetCardNumber() == cardNum);

                if (currentUser != null)
                {
                    break; 
                }

                Console.WriteLine("Incorrect card number. Please try again.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter a valid card number.");
            }
        }

    }
        }

    

