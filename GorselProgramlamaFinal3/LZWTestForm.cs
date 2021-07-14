using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaFinal3
{
    public partial class LZWTestForm : Form
    {
        public LZWTestForm()
        {
            InitializeComponent();
        }

        private void selectfilebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();//Kullanıcıdan bir dosya açmasını isteyen bir standart iletişim kutusu görüntüler.
            dosya.Filter = "Text Dosyası |*.txt; | Tüm Dosyalar |*.*";//Alınacak dosya uzantılarının tanımlandığı kod.
            dosya.Title = "DOSYA GEZGİNİ";//Dosya gezginin başlığı tanımalır.
            dosya.ShowDialog();//Openfiledialog nesnesi kullanıcıya pencere olarak sunulur.
            string DosyaYolu = dosya.FileName;//dosyanın ismi tekrar kullanımlarda kolay erişim için bir değişkene atanır.
            if (DosyaYolu == "")//Dosya yolunun alınıp alınmadığını kontrol eden mekanizma.
            //Eğer dosya gezgini açılır ve dosya seçilmezse olası hata mesajlarını engellemk ve kullanıcıya bilgi vermek için dosyayolunun düzgün alınıp alınamadığı kontrol edilir.
            {
                MessageBox.Show("Dosya gezgini dosya yolu seçilmeden kapatılmıştır.\n Lütfen tekrar deneyin.");
                //Kullanıcıyı yönlendirmek için mesaj kutusu oluşturuldu.
            }
            else
            {
                var reader = new StreamReader(DosyaYolu);
                string yazi = reader.ReadLine();
                richTextBox1.Text = yazi;
                //Kullanıcıyı yönlendirmek için mesaj kutusu oluşturuldu.
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); //Windows'ta bir dosyayı kaydetmek için kullanılan SaveFileDialog sınıfını çağırır.
            save.OverwritePrompt = false; //kaydedilen dosyayı varsayılan olarak seçiilen dosyanın üzerine yazma işlemini uyarı vermeden gerçekleştirir.
            save.CreatePrompt = true; //kaydedilecek dizinde kaydetmek istediğimiz dosyanın isminde bir dosya yoksa uyarı mesajı verir.
            save.Title = "Metin Dosyaları"; //Açılan dialog penceresinin başlığını belirler.
            save.DefaultExt = "txt"; //varsayılan dosya uzantılarını belirler.
            save.Filter = "txt Dosyaları (*.txt)|*.txt|Tüm Dosyalar(*.*)|*.*"; //dialog penceresindeki dosyaları belirtilen dosya türlerine göre filtreler ve sadece onlar görünür.
            if (save.ShowDialog() == DialogResult.OK) //dialog penceresini açma işlemini kontrol eder ve ok tuşuna basıldığında ekranı açma koşulunu oluşturur.
            {
                StreamWriter Kayit = new StreamWriter(save.FileName); //Bir belgeye yazı yamak için kullanılan StreamWriter sınıfı çağırılır.
                Kayit.WriteLine(richTextBox2.Text); //outputtextBox'ın içerisindeki verileri kaydeder.
                Kayit.Close(); //Dosyayı kapatır.
            }
        }

        private void compressbutton_Click(object sender, EventArgs e)
        {
            string a = richTextBox1.Text;
            string k = LempelZivWelchComponent.Compress(a);
            richTextBox2.Text = k;
        }

        private void decompressbutton_Click(object sender, EventArgs e)
        {
            string a = richTextBox1.Text;
            string k = LempelZivWelchComponent.Decompress(a);
            richTextBox2.Text = k;
        }
    }
}
