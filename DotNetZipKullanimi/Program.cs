using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetZipKullanimi
{
    internal class Program
    {
        static void Main()
        {
            string kaynakKlasor = @"C:\_buraya_kaynak_klasor_gelecek";
            string ziplenmisDosya = @"C:\_buraya_ziplenmis_dosya_gelecek";

            // Klasörü arşivle
            ZipKlasor(kaynakKlasor, ziplenmisDosya);

            Console.WriteLine("Arşivleme işlemi tamamlandı.");
        }

        static void ZipKlasor(string kaynak, string ziplenmisDosya)
        {
            using (ZipFile zip = new ZipFile())
            {
                zip.AddDirectory(kaynak); // Klasörü arşiv dosyasına ekle
                zip.Password = "Parola";
                zip.Save(ziplenmisDosya); // Arşiv dosyasını kaydet
            }
        }
    }
}
