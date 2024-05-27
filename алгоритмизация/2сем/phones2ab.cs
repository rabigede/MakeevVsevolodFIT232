using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class CallRecord
        {
            public string PhoneNumber { get; set; }
            public string DateTime { get; set; }
            public string Duration { get; set; }

            public CallRecord(string phoneNumber, string dateTime, string duration)
            {
                this.PhoneNumber = phoneNumber;
                this.DateTime = dateTime;
                this.Duration = duration;
            }
        }
        public class Menu
        {
            Queue<CallRecord> callRecords = new Queue<CallRecord>();
            public void Start()
            {
                while (true)
                {
                    Console.WriteLine("1. Создание базы, Добавление элементов базы");
                    Console.WriteLine("2. Вывод базы");
                    Console.WriteLine("3. Минуты по номеру");
                    Console.WriteLine("4. Минуты по дате");

                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            CreateDatabase();
                            break;
                        case 2:
                            Vidaem();
                            break;
                        case 3:
                            MinNum();
                            break;
                        case 4:
                            MinDat();
                            break;
                        default:
                            Console.WriteLine("Неверный выбор.");
                            break;
                    }
                }
            }
            public void CreateDatabase()
            {
                int i = 0;
                while (true)
                {
                    i++;
                    string i1;
                    string i2;
                    string i3;
                    Console.WriteLine($"Введите номер");
                    i1 = Console.ReadLine();
                    if (i1 == "0") { break; }
                    Console.WriteLine($"Введите дату без пробелов и символов, например: 01012001");
                    i2 = Console.ReadLine();
                    if (i2 == "0") { break; }
                    Console.WriteLine($"Введите время");
                    i3 = Console.ReadLine();
                    if (i3 == "0") { break; }
                    callRecords.Enqueue(new CallRecord(i1, i2, i3));
                    foreach (CallRecord p in callRecords)
                    {
                        Console.WriteLine("Номер телефона:\t" + p.PhoneNumber + "\nДата:\t" + p.DateTime + "\nВремя разговора\t" + p.Duration + "\n");
                    }
                    Console.WriteLine("Для выхода введите '0' ");
                }
            }
            public void Vidaem()
            {
                foreach (CallRecord p in callRecords)
                {
                    Console.WriteLine("Номер телефона:\t" + p.PhoneNumber + "\nДата:\t" + p.DateTime + "\nВремя разговора\t" + p.Duration + "\n");
                }
            }
            public void MinNum()
            {
                Hashtable totalMinutesByPhoneNumber = new Hashtable();

                foreach (CallRecord i in callRecords)
                {
                    string phoneNumber = i.PhoneNumber;
                    int duration = Convert.ToInt32(i.Duration);

                    if (totalMinutesByPhoneNumber.ContainsKey(phoneNumber))
                    {
                        totalMinutesByPhoneNumber[phoneNumber] = (int)totalMinutesByPhoneNumber[phoneNumber] + duration;
                    }
                    else
                    {
                        totalMinutesByPhoneNumber.Add(phoneNumber, duration);
                    }
                }

                foreach (DictionaryEntry entry in totalMinutesByPhoneNumber)
                {
                    Console.WriteLine($"Номер: {entry.Key}, Общее количество минут: {entry.Value}");
                }
            }
            public void MinDat()
            {
                Hashtable totalMinutesByDate = new Hashtable();

                foreach (CallRecord call in callRecords)
                {
                    string date = call.DateTime;
                    int duration = Convert.ToInt32(call.Duration);

                    if (totalMinutesByDate.ContainsKey(date))
                    {
                        totalMinutesByDate[date] = (int)totalMinutesByDate[date] + duration;
                    }
                    else
                    {
                        totalMinutesByDate.Add(date, duration);
                    }
                }

                foreach (DictionaryEntry entry in totalMinutesByDate)
                {
                    Console.WriteLine($"Дата: {entry.Key}, Общее количество минут: {entry.Value}");
                }
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, int> totalMinutesByNumber = new Dictionary<string, int>();
            Menu menu = new Menu();
            menu.Start();
            Console.ReadKey();
        }
    }
}