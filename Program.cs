using System;

namespace Try_Catch_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz: ");
                int girilenSayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:  "+girilenSayi);
            }

            catch(Exception ex)
            {
                    Console.WriteLine("Hata"+ ex.Message.ToString());
            }

            finally
            {

            }
        }
    }
}
