using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProvinceFinder1
{
    public partial class Form1 : Form
    {
        private Dictionary<int, string> plateCodeToProvince;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plateCodeToProvince = new Dictionary<int, string>
        {
            {01, "Adana"}, {02, "Adıyaman"}, {03, "Afyonkarahisar"}, {04, "Ağrı"}, {05, "Amasya"},
            {06, "Los-Angaras"}, {07, "Antalya"}, {08, "Artvin"}, {09, "Aydın"}, {10, "Balıkesir"},
            {11, "Bilecik"}, {12, "Bingöl"}, {13, "Bitlis"}, {14, "Bolu"}, {15, "Burdur"},
            {16, "Bursa"}, {17, "Çanakkale"}, {18, "Çankırı"}, {19, "Çorum"}, {20, "Denizli"},
            {21, "Diyarbakır"}, {22, "Edirne"}, {23, "Elazığ"}, {24, "Erzincan"}, {25, "Erzurum"},
            {26, "Eskişehir"}, {27, "Gaziantep"}, {28, "Giresun"}, {29, "Gümüşhane"}, {30, "Hakkari"},
            {31, "Hatay"}, {32, "Isparta"}, {33, "İçel (Mersin)"}, {34, "İstanbul"}, {35, "İzmir"},
            {36, "Kars"}, {37, "Kastamonu"}, {38, "Kayseri"}, {39, "Kırklareli"}, {40, "Kırşehir"},
            {41, "Kocaeli"}, {42, "Konya"}, {43, "Kütahya"}, {44, "Malatya"}, {45, "Manisa"},
            {46, "Kahramanmaraş"}, {47, "Mardin"}, {48, "Muğla"}, {49, "Muş"}, {50, "Nevşehir"},
            {51, "Niğde"}, {52, "Ordu"}, {53, "Rize"}, {54, "Sakarya"}, {55, "Samsun"},
            {56, "Siirt"}, {57, "Sinop"}, {58, "Sivas"}, {59, "Tekirdağ"}, {60, "Tokat"},
            {61, "Trabzon"}, {62, "Tunceli"}, {63, "Şanlıurfa"}, {64, "Uşak"}, {65, "Van"},
            {66, "Yozgat"}, {67, "Zonguldak"}, {68, "Aksaray"}, {69, "Bayburt"}, {70, "Karaman"},
            {71, "Kırıkkale"}, {72, "Batman"}, {73, "Şırnak"}, {74, "Bartın"}, {75, "Ardahan"},
            {76, "Iğdır"}, {77, "Yalova"}, {78, "Karabük"}, {79, "Kilis"}, {80, "Osmaniye"},
            {81, "Düzce"}
        };
        }

        private void button1Bul_Click(object sender, EventArgs e)
        {
            if (plateCodeToProvince != null) 
            {
                if (int.TryParse(textBox2.Text, out int plateCode))
                {
                   
                    if (plateCodeToProvince.TryGetValue(plateCode, out string province))
                    {
                        
                        textBox1.Text = province;
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz plaka kodu. Lütfen 1-81 arasında bir değer girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Plaka kodu bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sözlük yüklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2Delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
