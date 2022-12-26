using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
           int time = DateTime.Now.Hour;

           if (time >=6 && time <11)
            Console.Write("Hoş Geldin");
           else if(time <= 18)
           Console.WriteLine("İyi Günler!");
           else
           Console.WriteLine("İyi Geceler!");

           String sonuc = time <=18 ? "İyi günler" : "İyi Geceler!";
           
           sonuc=time>=6 && time <11 ? "Günaydın" : time<=18 ? "İyi Günler!" : "iyi Geceler";
           Console.WriteLine(sonuc);

           
        }
    }
}
