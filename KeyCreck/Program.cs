namespace Sifre_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hacker uygulamasi
            //sifre 123A gibi olacak
            Console.WriteLine("Bilgisayarın Bulmasını İstediği Şifreyi Yazınız: ");
            string key = Console.ReadLine();
            int l = key.Length;
            int a;
            int sbt1 = 0;
            char c;

            for (int i = 0; i < l; i++)
            {
                string k = Convert.ToString(key[i]);
                bool result1 = int.TryParse(k, out a);
                bool result2 = Char.TryParse(k, out c);
                if (result1)
                {
                    Random rnd1 = new Random();
                    int rnd2 = rnd1.Next(9) + 1;
                    sbt1++;
                    if (rnd2 == a)
                    {
                        Console.Write(a);
                    }
                    else
                    {
                        i--;
                    }
                }
                if (result2 && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9')
                {
                    Random rnd3 = new Random();
                    int rnd4 = rnd3.Next(32, 126);
                    sbt1++;
                    if ((char)rnd4 == c)
                    {
                        Console.Write(c);
                    }
                    else
                    {
                        i--;
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine("Şifre "+sbt1+" Seferde Bulundu.");
        }
    }
}