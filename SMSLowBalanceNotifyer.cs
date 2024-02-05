namespace SMSLowBalanceNotifyer;

using INotifyer;

public class SMSLowBalanceNotifyer : INotifyer
{
    private string _phone;
    private string _lowbalanceValue;
    ptublic SMSLowBalanceNotifyer(string phone, int lowbalanceValue)
    {
        _phone = phone;
        _lowbalanceValue = lowbalanceValue;
    }
    public void Notify(int balance)
    {
        Console.WriteLine("SMSLowBalanceNotifyer");
        Console.WriteLine($"Number : {_phone}");
        if (balance < llowbalanceValue)
        {
            Console.Writeline($"balance is low {balance}")
        }
    }
}