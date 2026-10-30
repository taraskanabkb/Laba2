using laba2.Users;
using System;
using System.Collections.Generic;
using System.Text;
namespace laba2.Notify;

internal interface INotifier
{
    void Send(Patient patient, string message);
}

public class SmsNotifier : INotifier
{
    public void Send(Patient patient, string message)
    {
        Console.WriteLine($"SMS на номер {patient.PhoneNumber}: {message}");
    }
}

public class EmailNotifier : INotifier
{
    public void Send(Patient email, string message)
    {
        Console.WriteLine($"Email на адрес {email.Name}83@gmail.com: {message}");
    }
}

public class TelegramNotifier : INotifier
{
    public void Send(Patient patient, string message)
    {
        Console.WriteLine($"Telegram сообщение для {patient.Name} {patient.Surname}: {message} на номер {patient.PhoneNumber}");
    }
}

