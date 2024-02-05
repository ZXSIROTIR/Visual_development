using Account;
using SMSLowBalanceNotifyer;
using EMailChangeBalanceNotifyer;

Account vladislav = new Account(2266);

SMSLowBalanceNotifyer sms1 = new SMSLowBalanceNotifyer("+79648109258", 200);
SMSLowBalanceNotifyer sms2 = new SMSLowBalanceNotifyer("+79996405912", 1600);
SMSLowBalanceNotifyer sms3 = new SMSLowBalanceNotifyer("+70112356123", 5000);

EMailChangeBalanceNotifyer email1 = new EMailChangeBalanceNotifyer("random_name@mail.ru");

vladislav.AddNotifyer(sms1);    
vladislav.AddNotifyer(email1);
vladislav.ChangeBalance(89);
vladislav.ChangeBalance(3000);