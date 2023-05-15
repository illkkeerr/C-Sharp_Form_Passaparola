using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaparolaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //b1.BackColor = SystemColors.ButtonFace;
        }

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void CevapKontrol(int soruNo)
        {

            Button button = new Button();
            button = ButonDondur(soruNo);
            if (SoruManager.Sorular[soruNo - 1].Cevaplar.Contains(textBox1.Text.ToLower().Trim()))
            {

                if (button != null)
                {
                    button.BackColor = Color.Green;
                    dogru++;
                    labelDogru.Text = dogru.ToString();
                }

            }
            else
            {
                if (button != null)
                {
                    button.BackColor = Color.Red;
                    yanlis++;
                    labelYanlis.Text = yanlis.ToString();
                }
            }



        }

        private Button ButonDondur(int soruNo)
        {
            switch (soruNo)
            {
                case 1: return b1;
                case 2: return b2;
                case 3: return b3;
                case 4: return b4;
                case 5: return b5;
                case 6: return b6;
                case 7: return b7;
                case 8: return b8;
                case 9: return b9;
                case 10: return b10;
                case 11: return b11;
                case 12: return b12;
                case 13: return b13;
                case 14: return b14;
                case 15: return b15;
                case 16: return b16;
                case 17: return b17;
                case 18: return b18;
                case 19: return b19;
                case 20: return b20;
                case 21: return b21;
                case 22: return b22;
                case 23: return b23;
                case 24: return b24;
            }
            return null;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    CevapKontrol(soruNo);
                    // linklabel1.Focus();
                    linklabel1.Text = "Sonraki>>";
                    this.soruNo++;
                    soruNoKontrol(soruNo);
                    SoruGoster(soruNo);
                    textBox1.Focus();
                    textBox1.Text = "";
                    Button button = ButonDondur(soruNo);
                    button25.Text = button.Text;
                    /*switch (soruNo)
                    {
                        case 1:
                            if (textBox1.Text == "akdeniz")
                            {
                                b1.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                            }
                            else
                            {
                                b1.BackColor = Color.Red;
                                yanlis++;
                                labelYanlis.Text = yanlis.ToString();
                            }
                            break;
                        case 2:
                            if (textBox1.Text == "bursa")
                            {
                                b2.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                            }
                            else
                            {
                                b2.BackColor = Color.Red;
                                yanlis++;
                                labelYanlis.Text = yanlis.ToString();
                            }
                            break;
                        case 3:
                            if (textBox1.Text == "cuma")
                            {
                                b3.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                            }
                            else
                            {
                                b3.BackColor = Color.Red;
                                yanlis++;
                                labelYanlis.Text = yanlis.ToString();
                            }
                            break;
                        case 4:
                            if (textBox1.Text == "diyarbakır")
                            {
                                b4.BackColor = Color.Green;
                                dogru++;
                                labelDogru.Text = dogru.ToString();
                            }
                            else
                            {
                                b4.BackColor = Color.Red;
                                yanlis++;
                                labelYanlis.Text = yanlis.ToString();
                            }
                            break;
                        case 5:
                            if (textBox1.Text == "eski")
                            {
                                b5.BackColor = Color.Green;
                            }
                            else
                            {
                                b5.BackColor = Color.Red;
                                yanlis++;
                                labelYanlis.Text = yanlis.ToString();
                            }
                            break;
                        case 6:
                            if (textBox1.Text == "ferman")
                            {
                                b6.BackColor = Color.Green;
                            }
                            else
                            {
                                b6.BackColor = Color.Red;
                                yanlis++;
                                labelYanlis.Text = yanlis.ToString();
                            }
                            break;
                        case 7:
                            if (textBox1.Text == "güneş")
                            {
                                b7.BackColor = Color.Green;
                            }
                            else
                            {
                                b7.BackColor = Color.Red;
                                yanlis++;
                                labelYanlis.Text = yanlis.ToString();
                            }
                            break;
                        case 8:
                            if (textBox1.Text == "cuma")
                            {
                                b8.BackColor = Color.Green;
                            }
                            else
                            {
                                b8.BackColor = Color.Red;
                                yanlis++;
                                labelYanlis.Text = yanlis.ToString();
                            }
                            break;
                        case 9:
                            if (textBox1.Text == "cuma")
                            {
                                b9.BackColor = Color.Green;
                            }
                            else
                            {
                                b9.BackColor = Color.Red;
                                yanlis++;
                                labelYanlis.Text = yanlis.ToString();
                            }
                            break;
                        case 10:
                            if (textBox1.Text == "cuma")
                            {
                                b10.BackColor = Color.Green;
                            }
                            else
                            {
                                b10.BackColor = Color.Red;
                                yanlis++;
                                labelYanlis.Text = yanlis.ToString();
                            }
                            break;
                        case 11:
                            if (textBox1.Text == "cuma")
                            {
                                b11.BackColor = Color.Green;
                            }
                            else
                            {
                                b11.BackColor = Color.Red;
                            }
                            break;
                        case 12:
                            if (textBox1.Text == "cuma")
                            {
                                b12.BackColor = Color.Green;
                            }
                            else
                            {
                                b12.BackColor = Color.Red;
                            }
                            break;
                        case 13:
                            if (textBox1.Text == "cuma")
                            {
                                b13.BackColor = Color.Green;
                            }
                            else
                            {
                                b13.BackColor = Color.Red;
                            }
                            break;
                        case 14:
                            if (textBox1.Text == "cuma")
                            {
                                b14.BackColor = Color.Green;
                            }
                            else
                            {
                                b14.BackColor = Color.Red;
                            }
                            break;
                        case 15:
                            if (textBox1.Text == "cuma")
                            {
                                b15.BackColor = Color.Green;
                            }
                            else
                            {
                                b15.BackColor = Color.Red;
                            }
                            break;
                        case 16:
                            if (textBox1.Text == "cuma")
                            {
                                b16.BackColor = Color.Green;
                            }
                            else
                            {
                                b16.BackColor = Color.Red;
                            }
                            break;
                        case 17:
                            if (textBox1.Text == "cuma")
                            {
                                b17.BackColor = Color.Green;
                            }
                            else
                            {
                                b17.BackColor = Color.Red;
                            }
                            break;
                        case 18:
                            if (textBox1.Text == "cuma")
                            {
                                b18.BackColor = Color.Green;
                            }
                            else
                            {
                                b18.BackColor = Color.Red;
                            }
                            break;
                        case 19:
                            if (textBox1.Text == "cuma")
                            {
                                b19.BackColor = Color.Green;
                            }
                            else
                            {
                                b19.BackColor = Color.Red;
                            }
                            break;
                        case 20:
                            if (textBox1.Text == "cuma")
                            {
                                b20.BackColor = Color.Green;
                            }
                            else
                            {
                                b20.BackColor = Color.Red;
                            }
                            break;
                        case 21:
                            if (textBox1.Text == "cuma")
                            {
                                b21.BackColor = Color.Green;
                            }
                            else
                            {
                                b21.BackColor = Color.Red;
                            }
                            break;
                        case 22:
                            if (textBox1.Text == "cuma")
                            {
                                b22.BackColor = Color.Green;
                            }
                            else
                            {
                                b22.BackColor = Color.Red;
                            }
                            break;
                        case 23:
                            if (textBox1.Text == "cuma")
                            {
                                b23.BackColor = Color.Green;
                            }
                            else
                            {
                                b23.BackColor = Color.Red;
                            }
                            break;
                        case 24:
                            if (textBox1.Text == "cuma")
                            {
                                b24.BackColor = Color.Green;
                            }
                            else
                            {
                                b24.BackColor = Color.Red;
                            }
                            break;

                    }*/
                }
                catch (Exception)
                {

                    ;
                }


            }
        }


        private void SoruGoster(int soruNo)
        {
            this.Text = soruNo.ToString();
            Button button = new Button();
            richTextBox1.Text = SoruManager.Sorular[soruNo - 1].Soru_;
            button = ButonDondur(soruNo);
            if (button != null)
            {
                button.BackColor = Color.Yellow;
            }

        }
        private void linklabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linklabel1.Text = "Sonraki>>";
                soruNo++;
                soruNoKontrol(soruNo);
                SoruGoster(soruNo);
                /* this.Text = soruNo.ToString();

                 if (soruNo == 1)
                 {
                     richTextBox1.Text = "Ülkemizin güney ksmındaki kıyı bölgesi";
                     b1.BackColor = Color.Yellow;
                 }
                 if (soruNo == 2)
                 {
                     richTextBox1.Text = "Yeşilliği ile ünlü Marmara ilimiz";
                     b2.BackColor = Color.Yellow;
                 }
                 if (soruNo == 3)
                 {
                     richTextBox1.Text = "Müslümanların kutsal günü";
                     b3.BackColor = Color.Yellow;
                 }
                 if (soruNo == 4)
                 {
                     richTextBox1.Text = "karpuzuyla ünlü ilimiz";
                     b4.BackColor = Color.Yellow;
                 }
                 if (soruNo == 5)
                 {
                     richTextBox1.Text = "yeni kelimesinin zıt anlamlısı";
                     b5.BackColor = Color.Yellow;
                 }
                 if (soruNo == 6)
                 {
                     richTextBox1.Text = "padişahın emirlerinin yazılı hali";
                     b6.BackColor = Color.Yellow;
                 }
                 if (soruNo == 7)
                 {
                     richTextBox1.Text = "dünyanın ısı kaynağı";
                     b7.BackColor = Color.Yellow;
                 }
                 if (soruNo == 8)
                 {
                     richTextBox1.Text = "öğrencilerin kötü karne getirince bakıştığı nesne";
                     b8.BackColor = Color.Yellow;
                 }
                 if (soruNo == 9)
                 {
                     richTextBox1.Text = "gülüyle ünlü ilimiz";
                     b9.BackColor = Color.Yellow;
                 }
                 if (soruNo == 10)
                 {
                     richTextBox1.Text = "mersinin diğer ismi";
                     b10.BackColor = Color.Yellow;
                 }
                 if (soruNo == 11)
                 {
                     richTextBox1.Text = "askeri bir topluluk";
                     b11.BackColor = Color.Yellow;
                 }
                 if (soruNo == 12)
                 {
                     richTextBox1.Text = "malatyanın meşhur meyvesi";
                     b12.BackColor = Color.Yellow;
                 }
                 if (soruNo == 13)
                 {
                     richTextBox1.Text = "her yıl bahar aylarında düzenlenen meşhur çiçek festivali";
                     b13.BackColor = Color.Yellow;
                 }
                 if (soruNo == 14)
                 {
                     richTextBox1.Text = "yılın 3. ayı";
                     b14.BackColor = Color.Yellow;
                 }
                 if (soruNo == 15)
                 {
                     richTextBox1.Text = "üflemeli bir müzük aleti";
                     b15.BackColor = Color.Yellow;
                 }
                 if (soruNo == 16)
                 {
                     richTextBox1.Text = "halk şairi";
                     b16.BackColor = Color.Yellow;
                 }
                 if (soruNo == 17)
                 {
                     richTextBox1.Text = "çocukların çok sevmediği pirinç havuç gibi sebzelerle yapılan yemek";
                     b17.BackColor = Color.Yellow;
                 }
                 if (soruNo == 18)
                 {
                     richTextBox1.Text = "11 ayın sultanı";
                     b18.BackColor = Color.Yellow;
                 }
                 if (soruNo == 19)
                 {
                     richTextBox1.Text = "ingilizcede yılan";
                     b19.BackColor = Color.Yellow;
                 }
                 if (soruNo == 20)
                 {
                     richTextBox1.Text = "Türkiye'nin megastarı";
                     b20.BackColor = Color.Yellow;
                 }
                 if (soruNo == 21)
                 {
                     richTextBox1.Text = "Ümit kelimesinin eş anlamlısı";
                     b21.BackColor = Color.Yellow;
                 }
                 if (soruNo == 22)
                 {
                     richTextBox1.Text = "kahvaltısı ile ünlü bir ilimiz";
                     b22.BackColor = Color.Yellow;
                 }
                 if (soruNo == 23)
                 {
                     richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı";
                     b23.BackColor = Color.Yellow;
                 }
                 if (soruNo == 24)
                 {
                     richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan yağıda yapılan bir kahvaltı besini";
                     b24.BackColor = Color.Yellow;
                 }*/
                textBox1.Focus();
                textBox1.Text = "";
                Button button = ButonDondur(soruNo);
                button25.Text = button.Text;

            }
            catch (Exception)
            {

                ;
            }



        }

        private void soruNoKontrol(int soruNo)
        {
            if (soruNo == 25)
            {

                var result = MessageBox.Show($"tebrikler yarışmayı sonlandırdınız\nDoğru:{dogru} Yanlış:{yanlis}", "Message", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    dogru = 0;
                    yanlis = 0;
                    this.soruNo = 0;
                    textBox1.Text = "";
                    labelDogru.Text = labelYanlis.Text = "0";
                    button25.Text = string.Empty;
                    richTextBox1.Text = string.Empty;
                    linklabel1.Text = "Başla";
                    
                    //b1.Focus();
                    foreach (Control item in this.Controls)
                    {
                        if (item is Button)
                        {
                            item.BackColor = SystemColors.ButtonFace;
                        }
                    }
                }
            }
        }
    }
}
