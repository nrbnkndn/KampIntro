using System;

namespace _2GunOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //TERNARY Operatörü
            Console.Write("[1-10] arasında sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            string cevap = "";
            cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
            Console.WriteLine(cevap);


            /*(normal if-else yapısı)

int sayi = 5;

if (sayi % 2 == 0)
{
   Console.WriteLine("Sayı çifttir");
}
else
{
   Console.WriteLine("Sayı tektir");
}

(ternary operatörü yapısı)

int sayi = 5;

string tekMiCiftMi = sayi % 2 == 0 ? "Sayı çifttir" : "Sayı tektir";

Console.WriteLine(tekMiCiftMi);
             * 
             * 
             */


            //SWITCH CASE yapısı
            Console.Write("Kaçıncı ayda olduğunuzu girin:");

            int ay = Convert.ToInt32(Console.ReadLine());

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.Write("Kış mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.Write("İlkbahar mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("Yaz mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.Write("Sonbahar mevsimi");
                    break;
                default:
                    Console.Write("Ay bilgisini yanlış girdiniz.");
                    break;
            }

            /*While döngüsü, içerisindeki koşul doğru (true) olduğu sürece tekrar eder. Koşul yanlış (false) olduğunda döngüden çıkılır.

While(koşul){

//Döngü gövdesi/Komutlar

}

While döngüsünde döngü değişkeni bulunmaz, bunun yerine while bloğuna girmeden başlangıçta değeri bilinen bir değişken kullanılır. Koşul ifadesiyle ilişkili olan bu değişkenin değeri döngü bloğu içerisinde değiştirilir.

int toplam = 0;
int i = 0;
 
while (i < 100)
{
    toplam += i;
    i++;
}
 
Console.WriteLine("1-100 arası sayıların toplamı : " + toplam);
             * 
             * 
             * 
             * 
             */
            int result = Add(1,2);
            Console.WriteLine(result);
        }

        static int Add (int sayi1, int sayi2, int sayi3=30) // default değer atayabiliyoruz. en sağdaki ve onun solundakiler atanabilir

        {
            return sayi1 + sayi2 + sayi3;
        }
    }
}
