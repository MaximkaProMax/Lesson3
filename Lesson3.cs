csharp
using System;

class Phone
{
    private string number;
    private string model;
    private double weight;

    public Phone(string number, string model, double weight)
    {
        this.number = number;
        this.model = model;
        this.weight = weight;
    }

    public Phone(string number, string model) : this(number, model, 0)
    {
    }

    public Phone() : this("", "", 0)
    {
    }

    public void receiveCall(string callerName)
    {
        Console.WriteLine("Звонит " + callerName);
    }

    public void receiveCall(string callerName, string callerNumber)
    {
        Console.WriteLine("Звонит " + callerName + ", номер телефона: " + callerNumber);
    }

    public string getNumber()
    {
        return number;
    }

    public void sendMessage(params string[] phoneNumbers)
    {
        Console.WriteLine("Отправить сообщение на следующие номера телефонов:");
        foreach (string phoneNumber in phoneNumbers)
        {
            Console.WriteLine(phoneNumber);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Phone phone1 = new Phone("123456789", "iPhone", 0.2);
        Phone phone2 = new Phone("987654321", "Samsung", 0.3);
        Phone phone3 = new Phone("456789123", "Nokia");

        Console.WriteLine("Телефон 1:");
        Console.WriteLine("Номер: " + phone1.getNumber());
        Console.WriteLine("Модель: " + phone1.model);
        Console.WriteLine("Вес: " + phone1.weight);

        Console.WriteLine("Телефон 2:");
        Console.WriteLine("Номер: " + phone2.getNumber());
        Console.WriteLine("Модель: " + phone2.model);
        Console.WriteLine("Вес: " + phone2.weight);

        Console.WriteLine("Телефон 3:");
        Console.WriteLine("Номер: " + phone3.getNumber());
        Console.WriteLine("Модель: " + phone3.model);
        Console.WriteLine("Вес: " + phone3.weight);

        phone1.receiveCall("John");
        phone2.receiveCall("Alice", "987654321");

        phone1.sendMessage("123456789", "987654321");
        phone2.sendMessage("123456789", "987654321", "456789123");
    }
}