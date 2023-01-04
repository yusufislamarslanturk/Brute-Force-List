using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekrarsiz = "";
            Console.Write("Kac kelime girilecek : ");
            //girilecek kelime sayisinin belirtilmesi
            int sayi = Convert.ToInt32(Console.ReadLine());

            string[] girilen = new string[sayi];

            //girilen sayi kadar kelimenin girilip dizi icine atanmasi
            for (int i = 0; i < sayi; i++)
            {
                Console.Write((i + 1) + ". Kelimeyi giriniz : ");

                girilen[i] = Console.ReadLine();
            }
            //girilen 3 stringin tek bir string haline cevrilmesi
            string girilenson = string.Join("", girilen);
            //bu string ifadenin tekrarsiz halinin olusturulmasi
            for (int i = 0; i < girilenson.Length; i++)
            {
                if (tekrarsiz.IndexOf(girilenson[i]) == -1)
                {
                    tekrarsiz += girilenson[i];
                }
            }
            ArrayList son = new ArrayList();
            //tekrarsiz stringin liste icerisine char seklinde eklenmesi
            for (int i = 0; i < tekrarsiz.Length; i++)
            {
                son.Add(tekrarsiz[i]);
                

            }
            son.Sort();

            //yazılacak dosyanin acilmasi
            StreamWriter dosya = new StreamWriter("C:\\Users\\YSARS\\Desktop\\yazilacak.txt");
           
            for (int j = 0; j < tekrarsiz.Length; j++)
            {
                for (int k = 0; k < tekrarsiz.Length; k++)
                {
                    for (int l = 0; l < tekrarsiz.Length; l++)
                    {
                        for (int m = 0; m < tekrarsiz.Length; m++)
                        { 
                        dosya.Write((son[j]).ToString());
                        dosya.Write((son[k]).ToString());
                        dosya.Write((son[l]).ToString());
                        dosya.Write((son[m]).ToString());
                        dosya.WriteLine();
                        
                                                    
                        }
                    }
                }
            }
            dosya.Close();
            Console.WriteLine("\n Sifreleme ilemi bitti lutfen txt dosyasını kontrol ediniz.");
            Console.ReadLine();
        }   
           
    }
}
