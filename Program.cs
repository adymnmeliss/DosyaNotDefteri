using System;
using System.IO;

class Program
{
    static string dosyaYolu = "notlar.txt";

    static void Main()
    {
        int secim = 0;

        do
        {
            Console.WriteLine("\n=== Dosya Tabanlı Not Defteri ===");
            Console.WriteLine("1 Not Ekle");
            Console.WriteLine("2 Notları Oku");
            Console.WriteLine("3 Dosyayı Temizle");
            Console.WriteLine("0 Çıkış");
            Console.Write("Seçimin: ");

            secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                Console.Write("Notunuzu yazın: ");
                string? not = Console.ReadLine();

                File.AppendAllText(dosyaYolu, not + Environment.NewLine);
                Console.WriteLine(" Not kaydedildi.");
            }
            else if (secim == 2)
            {
                if (File.Exists(dosyaYolu))
                {
                    string tumNotlar = File.ReadAllText(dosyaYolu);
                    Console.WriteLine("\n--- Kayıtlı Notlar ---");
                    Console.WriteLine(tumNotlar);
                }
                else
                {
                    Console.WriteLine("Henüz not yok.");
                }
            }
            else if (secim == 3)
            {
                File.WriteAllText(dosyaYolu, "");
                Console.WriteLine(" Dosya temizlendi.");
            }

        } while (secim != 0);

        Console.WriteLine("Program kapatıldı.");
    }
}
