namespace EMailChangeBalanceNotifyer;

using INotifyer;

public class EMailChangeBalanceNotifyer : INotifyer
{
    private string _email;
    public EMailBalanceChangeNotifyer(string email)
    {
        _email = email;
    }
    public void Notify(int balance)
    {
        Console.WriteLine("EMailBalanceChangeNotifyer");
        Console.Writeline($"Email : {_email}");
        Console.Writeline($"Your balance is : {balance}");
    }
}