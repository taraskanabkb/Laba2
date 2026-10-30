using laba2.Buhgalteria;
using laba2.Interfaces;
using laba2.Notify;
using laba2.Spravki;
using laba2.Users;

Patient patientA = new Patient("Aktan", "Asanov", "+996 555 123 456", "A+");
Patient patientB = new Patient("Samito", "Akigatsu", "+996 444 654 321", "B-");
Patient patientC = new Patient("Arab", "Arabskii", "+996 911 199 93", "O-");

patientA.DisplayInfo();

Kassa kassa = new Kassa();

Spravka83 pervaya = new Spravka83
{
    SpravkaName = "Spravka 83",
    Patient = patientA,
    Price = 250
};

SpravkaPochUvol vtoraya = new SpravkaPochUvol
{
    SpravkaName = "Справка об увольнений",
    Patient = patientB,
    Price = 50,
    Whyout = "Начальник говно, зп мала, коллектив говно, да и сама работа говно."
};

Spravka83 tretya = new Spravka83
{
    SpravkaName = "Spravka 83",
    Patient = patientC,
    Price = 500
};

List <ISpravka> infa= new List<ISpravka> { pervaya, vtoraya, tretya };

Kassa kassaA = new Kassa();
Console.WriteLine(kassaA.Total(infa));
kassaA.PrintCheck(infa);

vtoraya.Whywhy();
vtoraya.Whywhy();

Console.WriteLine();

Console.Write("Чем отправить сообщение (1 - SMS, 2 - Email, 3 - telegram): ");
int choosemess = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Сообщение: ");
string whatmessage = Console.ReadLine();
if (choosemess == 1) 
{
    INotifier notifier = new SmsNotifier();
    notifier.Send(pervaya.Patient, whatmessage);
}

else if (choosemess == 2)
{
    INotifier notifier = new EmailNotifier();
    notifier.Send(vtoraya.Patient, whatmessage);
}

else if (choosemess == 3)
{
    INotifier notifier = new TelegramNotifier();
    notifier.Send(tretya.Patient, whatmessage);
}
else { Console.WriteLine("error"); }