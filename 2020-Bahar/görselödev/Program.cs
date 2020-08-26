using System;
using System.Threading;  // dahil et 
namespace ThreadConsole
{
    /**************************************
     * C#, threadler vasıtasıyla kodun paralel yürütülmesini destektler.
     * Thread başlatıldığında (Start()), thread'in isAlive() özelliği, thread sonlanana kadar true değeri döndürür.
     * 
     * Thread bittiğinde yeniden başlatılamaz.
     * 
     * join() metodu ile önce thread'in bitmesi beklenir. Sonra diğer threadler çalışır.
     * 
     * sleep(ms) ms kadar bekler
     * 
     * priority() threadlere öncelik verilmesi gerektiği durumlarda kullanılır. Highest- lowest (Enum)
     * 
     * *************************************/
    class Program
    {
        static void Main(string[] args)
        {
            

            Thread thread1 = new Thread(new ThreadStart(yaz0));
            Thread thread2 = new Thread(new ThreadStart(yazTire2));
           thread1.Priority = ThreadPriority.Lowest; //priority =  Enum
            thread2.Priority = ThreadPriority.Highest;
        // eğer öncelik verilmezse hepsinin önceliği aynıdır (normal)
            thread1.Start(); // Thread1 başlatıldı
          //  thread1.Join();

            thread2.Start();
            yazTire();
        }

        static void yaz0()
        {
            for (int i = 0; i < 1000; i++) {

                Console.Write("0");
            }
        }

        static void yazTire()
        {
            for (int i = 0; i < 1000; i++)
            {

                Console.Write("-");
            }
        }

        static void yazTire2()
        {
            for (int i = 0; i < 1000; i++)
            {

                Console.Write("_");
            }
        }
    }
}
