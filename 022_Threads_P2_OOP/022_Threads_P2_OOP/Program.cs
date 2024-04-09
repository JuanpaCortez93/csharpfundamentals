Accounts cuentaFamiliar = new Accounts(2000);
Thread[] hilosPersonas = new Thread[15];

for (int i = 0; i < 15; i++)
{
    Thread t = new Thread(cuentaFamiliar.WithdrawalsFamiliar);
    t.Name = i.ToString();
    hilosPersonas[i] = t;
}

for (int i = 0; i < 15; i++)
{
    hilosPersonas[i].Start(); 
    hilosPersonas[i].Join();
}


class Accounts
{
    public Accounts(double initialAmount)
    {
        _amount = initialAmount;
    }

    public double Withdrawals (double amount)
    {
        if ((_amount - amount) < 0) { 
            Console.WriteLine($"{Thread.CurrentThread.Name}\nSorry, your balance is not enough\n");
            return 0;
        }
        else
        {

            lock(blockBalance){
                Console.WriteLine($"{Thread.CurrentThread.Name}\nWithdrawal accomplished.\n{amount}USD retired. Your balance is: {_amount - amount}\n");
                _amount -= amount;
                return amount;
            }

        }

    }

    public void WithdrawalsFamiliar ()
    {
        Withdrawals(500);
    }

    public double Amount { get {return _amount; } set { _amount = value; } }

    private Object blockBalance = new Object();
    private double _amount = 0;

}