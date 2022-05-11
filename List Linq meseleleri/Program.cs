using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Linq_meseleleri
{
    class Program
    {
        public static void  SadeEded(List<int>array,int n)
        {
            for (int i =0; i <n; i++)
            {
                if (array[i] % i != 0)
                    Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            #region  1. Verilmiş List`dən 0 dan fərqli və cüt olan elemetləri seç.+ 
            List<int> nums = new List<int>();
            nums.AddRange(new int[] { 1, 9, 67, 54, 0, 32, 7, 1, 0, 56, 875, 346, 9865 });
            var result = nums.Where(p => p % 2 == 0 & p != 0);
            Array.ForEach(result.ToArray(), Console.WriteLine);
            #endregion
            #region 2. Verilmiş List`dən R hərfi ilə başlayan və tərkibində a hərfi olan elementlərdən ibarət List`in uzunluğu.+
            List<string> array = new List<string>();
            array.AddRange(new string[] { "Rasad", "Madina", "Elon", "Jeff", "Ravana" });
            var result1 = array.Count(p => p.Contains('a') & p.StartsWith("R"));
            Console.WriteLine(result1);
            #endregion
            # region   3. Verilmiş List`dəki elementlərin içərisindən 12`nin bölənlərini seç.+
            List<int> array2 = new List<int>();
            array2.AddRange(new int[] { 2, 12, 34, 56, 48, 24, 56, 78, 90, 23, 456, 1, 4, 5, 6, 3 });
            var result3 = array2.Where(p => 12 % p == 0);
            Array.ForEach(result3.ToArray(), Console.WriteLine);
            #endregion
            #region 4. Verilmiş List`dəki elementlər içərisində ikirəqəmli və sadə olan ədədləri seç.-
            List<int> nums2 = new List<int>();
            nums2.AddRange(new int[] { 12, 3, 4, 56, 78, 2345, 34, 567, 76, 2, 87, 99, 91, 23, 47, 41 });
            var result4 = nums2.FindAll(p => p < 100);
            #endregion
            #region 5. Verilmiş List`dəki A hərfi ilə başlayan və tərkibində u hərfi olan ilk sözü ekrana çıxarın.+
            List<string> array3 = new List<string>();
            array3.AddRange(new string[] { "Medine", "Aynur", "Elon", "Jeff", "Musk", "Aynure" });
            var result5 = array3.FirstOrDefault(p => p.StartsWith("A") & p.Contains("u"));
            Console.WriteLine(result5);
            #endregion
            #region 6. Verilmiş List`dəki üçrəqəmli elementləri seçin.-
            List<int> array4 = new List<int>();
            array4.AddRange(new int[] { 1, 2, 34, 54, 234, 65, 123, 45, 234, 98, 678, 56, 456, 76, 9 });
            var result6 = array4.FindAll(p => p < 1000);
            //Array.ForEach(result6.ToArray, Console.WriteLine);
            #endregion
            #region 7. Verilmiş ArrayListdəki double tipində olan elementləri seçin.-
            ArrayList array5 = new ArrayList();
            foreach (var m in array5)
                array5.Add(Console.ReadLine());
            //var result7 = eded.Where(m => m == GetType(double));
            //Array.ForEach(result7.ToArray, Console.WriteLine);
            #endregion
            #region 8. Verilmiş List`dəki 2 və 3-ə bölünən elementləri seçin.-
            List<int> array6 = new List<int>();
            foreach (var m in array6)
                array6.Add(int.Parse(Console.ReadLine()));
            var result8 = array6.FindAll(p => p % 2 == 0 && p % 3 == 0);
            //Array.ForEach(result8.ToArray, Console.WriteLine);
            #endregion
            #region 9. Verilmiş List`dəki tək ədədləri seçin.-
            List<int> array7 = new List<int>();
            foreach (var m in array7)
                array7.Add(int.Parse(Console.ReadLine()));
            var result9 = array7.Where(p => p % 2 != 0);
            //Array.ForEach(result9.ToArray, Console.WriteLine);
            #endregion
            #region 10. Verilmiş List`dəki A hərfi ilə başlayan ilk elementini bütün hərfləri böyük olmaqla ekrana çıxarın.+
            List<string> array8 = new List<string>();
            array8.AddRange(new string[] { "Madina", "Xedice","Rasad", "Ahmad","Cemale","Huseyin","Vusal" });
            var result10 = array8.Find(p => p.Contains("A"));
            Console.WriteLine(result10.ToUpper());
            #endregion
        }
    }
}
