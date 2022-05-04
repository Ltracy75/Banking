using Banking;

var Act1 = new Account()
    {
    Name = "Checking 1",
    };

var Act2 = new Account()
    {
    Name = "Checking 2",
    };

Act1.Deposit(44000);
Act2.Deposit(500);


Act1.Withdraw(200);
Act2.Withdraw(400);

Console.WriteLine($"Act1 Balance is {Act1.Balance:c} \nAct2 Balance is {Act2.Balance:c}");

Act2.Withdraw(400);

Console.WriteLine($"Act1 Balance is {Act1.Balance:c} \nAct2 Balance is {Act2.Balance:c}");

Act2.Transfer(100, Act1);

Console.WriteLine($"Act1 Balance is {Act1.Balance:c} \nAct2 Balance is {Act2.Balance:c}");

Act1.Deposit(-200);
Act2.Withdraw(-200);

Console.WriteLine($"Act1 Balance is {Act1.Balance:c} \nAct2 Balance is {Act2.Balance:c}");