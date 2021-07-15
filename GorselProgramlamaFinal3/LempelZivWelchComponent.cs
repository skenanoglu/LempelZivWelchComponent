using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaFinal3
{
    public partial class LempelZivWelchComponent : Component
    {
        public string Inputtext;

        public LempelZivWelchComponent()
        {
            InitializeComponent();
        }

        public LempelZivWelchComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public static string Compress(string input)
        {
            List<string> compress_table = new List<string>();

            for (int i = 0; i < 256; i++)
            {
                char temp = (char)i;
                compress_table.Add(temp.ToString());
            }

            //Karakter kodlarını içerecek bir tamsayı listesi 
            List<int> compressed = new List<int>();
            //Bir dize oluşturulur ve  girdinin ilk karakterinin değeri atanır
            string temp_s = input[0].ToString();
            for (int i = 0; i < input.Length - 1; i++)
            {
                //Sonraki karaktere geçiş işlemi
                char temp_char = input[i + 1];
                //Kombinasyonları zaten tablodaysa, sonraki karakteri temp_s'ye eklenir
                if (compress_table.Contains(temp_s + temp_char))
                {
                    temp_s = temp_s + temp_char;
                }
                else
                {
                    //İlk karakterin kodunu listeye ekler
                    compressed.Add(compress_table.IndexOf(temp_s));
                    //Tabloya karakter kombinasyonu ekler
                    compress_table.Add(temp_s + temp_char);
                    //Bir dizeye sonraki karakteri atar
                    temp_s = temp_char.ToString();
                }
                if (i == input.Length - 2)
                {
                    compressed.Add(compress_table.IndexOf(temp_s));
                }

            }
            string output = "";
            //Tüm kodları çıkış satırına ekler
            foreach (int elem in compressed)
                output += $"{elem} ";
            //Satırın sonundaki boşluklar kesilir
            output = output.Trim();
            string res = output;
            return res;
        }
        public static string Decompress(string input)
        {
            //Bir dizeyi ayırıcı olarak boşluk içeren bir dize dizisine dönüştürür
            string[] arr = input.Split(' ');
            //Bir tamsayı dizisi oluşturur.
            int[] Ints = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                Ints[i] = int.Parse(arr[i]);
            //Bir dekompresyon tablosu bildirir
            List<string> decompress_table = new List<string>();
            for (int i = 0; i < 256; i++)
            {
                char temp = (char)i;
                decompress_table.Add(temp.ToString());
            }
            string output = "";
            //İlk sayıyı karaktere dönüştürme işlemini yapar
            int temp_i = Ints[0];
            string res = "";
            output += decompress_table[temp_i];
            res += output;
            string temp_s = "";
            char C = ' ';
            for (int i = 1; i < Ints.Length; i++)
            {
                //İkinci sayıyı bir sembole dönüştürür
                int next_temp = Ints[i];
                //Kitaplığa karakter kombinasyonu ekler
                if (decompress_table.Count - 1 < next_temp)
                {
                    temp_s = output;
                    temp_s = temp_s + C;
                }
                else
                {
                    temp_s = decompress_table[next_temp];
                }
                res += temp_s;
                C = temp_s[0];
                decompress_table.Add(output + C);
                output = temp_s;

            }
            return res;
        }
    }
}
