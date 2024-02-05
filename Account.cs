namespace Account;

using INotifyer;

public class Account
{
    private int _balance;
    private List<INotifyer> _notifyers = new List<Inotifyers>();
    public Account() { }
    public Account(int balance)
    {
        _balance = balance;
    }
    public void AddNotifyer(INotifyer notifyer)
    {
        _notifyers.Add(notifyer);
    }
    public void ChangeBalance(value)
    {
        _balance = value;
        Notification();
    }
    public int Balance
    {
        get { return _balance; }
    }
    private void Notification()
    {
        foreach(INotifyer n in _notifyers)
        {
            n.Notify(Balance);
        }
    }
}