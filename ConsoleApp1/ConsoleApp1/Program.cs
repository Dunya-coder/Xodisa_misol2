using System;

namespace ConsoleApp1
{
    delegate void SanaVaqt();
    class SanaCheck
    {
        // C# kodida SanaCheck klassi belgilangan vaqtga yetilganida
        //harakatlarni bajaradigan bir event mexanizmi yaratgan. onTime eventi
        //agar hozirgi vaqt 2023-10-29 23:00:02 dan keyin bo'lsa, chaqiriladi. Hello va Vaqt metodlari
        //shu eventga obuna bo'lib, ularni event chaqirilganda bajarishadi.
        public event SanaVaqt onTime;
        public void onEventTime()
        {
            DateTime date1 = new DateTime(2024, 10, 29, 23, 00, 02);
            if (DateTime.Now >= date1)
            {
                onTime();
            }
        }
        public void Hello()
        {
            Console.WriteLine("Assalomu aleykum!");
        }
        public void Vaqt()
        {
            Console.WriteLine("Vaqt bo'ldi!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SanaCheck sch = new SanaCheck();
            sch.onTime += sch.Hello;
            sch.onTime += sch.Vaqt;

            sch.onEventTime();
        }
    }
}
