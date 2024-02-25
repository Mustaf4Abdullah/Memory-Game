using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Memory_Game_Mustafa_Abdullah
{
    public partial class Oyun_Alani : Form
    {
        public List<string> pictures = new List<string>();//fotograflarin ismini string olarak kaydeden bir liste tanimlamak
        Random random = new Random();
        private PictureBox firstClicked = null;
        private PictureBox secondClicked = null;
        int counterForWin = 0;
        System.Media.SoundPlayer sp1 = new System.Media.SoundPlayer();//sesleri tanimlamak
        System.Media.SoundPlayer sp2 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer sp3 = new System.Media.SoundPlayer();
        PictureBox[,] Pic_Box = new PictureBox[8, 8];//picturebox sinifindan 2 boyutlu bir nesne tanimlamak
        public Oyun_Alani()
        {
            InitializeComponent();
        }
        private void LoadPictures()
        {
            // giris formdan degiskenkeri tanimlamak

            string izgara_1 = Giris.izgara_sayisi_getirme1;

            int izgara10 = Convert.ToInt16(izgara_1);
            //Giris formdan gelenn izgara secenge gore fotograf klasoru bulmak ve yuklemek  
            if (izgara10 == 4)//Giris formdan gelen izgara sayisi
            {
                string name = "foto4";//klasorun ismi 
                pictures = Directory.GetFiles(name).ToList();//projenin kaydedildigi klasorun icindeki veriye ulasmak
                pictures.AddRange(pictures);//pictures listesine fotograflarin ismini kaydetmek 
            }
            else if (izgara10 == 6)
            {
                string name = "foto6";
                pictures = Directory.GetFiles(name).ToList();
                pictures.AddRange(pictures);
            }
            else if (izgara10 == 8)
            {
                string name = "foto8";
                pictures = Directory.GetFiles(name).ToList();
                pictures.AddRange(pictures);
            }
        }
        private void Oyun_Alani_Load(object sender, EventArgs e)
        {
            string kullanci_adi = Giris.kullanci_getirme;

            string izgara_1 = Giris.izgara_sayisi_getirme1;
            int izgara10 = Convert.ToInt16(izgara_1);

            string Mod = Giris.Mod_getirme;


            for (int i = 0; i < izgara10; i++)
            {
                for (int j = 0; j < izgara10; j++)
                {
                    Pic_Box[i, j] = new PictureBox();//yeni picturebox uye
                    Pic_Box[i, j].Location = new Point(3 + j * 80, 40 + i * 80);//pictureboxlarin konumu ve aralarindaki mesafe
                    Pic_Box[i, j].Size = new Size(65, 65);//pictureboxlarin hacmi
                    Pic_Box[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    //giris sayfasindan gelen Mod degeri ne ise ona gore click fonkisyona yonlendirmek 
                    if (Mod == "Easy")
                    {
                        Pic_Box[i, j].Click += new EventHandler(easy_mod);

                    }
                    if (Mod == "Normal")
                    {
                        Pic_Box[i, j].Click += new EventHandler(normal_mod);
                    }
                    if (Mod == "Expert")
                    {
                        Pic_Box[i, j].Click += new EventHandler(expert_mod);

                    }
                    this.Controls.Add(Pic_Box[i, j]);//tanimlanan picuebox ekrana cizmek
                }
            }
            LoadPictures(); //fotograflari yuklemek 
            AddPicturesToSquares(); //pictureboxlara fotograflari dagitmak 
            sp1.SoundLocation = "blip.wav"; // sesleri projenin klasorden yuklemek
            sp2.SoundLocation = "nono.wav";
            sp3.SoundLocation = "done.wav";
        }
        private void CheckIfWin()
        {
            string izgara_1 = Giris.izgara_sayisi_getirme1;

            int izgara10 = Convert.ToInt16(izgara_1);

            if (counterForWin == izgara10 * 2)//acilan ciftler bitti ise oyunu sonlandir
            {
                MessageBox.Show("Tebrikler bitti . ");
                Close();
            }
        }
        private void easy_mod(object sender, EventArgs e)
        {
            if (firstClicked == null)
            {
                firstClicked = sender as PictureBox;
                firstClicked.Image = Image.FromFile(firstClicked.Tag.ToString());// acilan ilk fotografi klasorde Tag'ni arartark getirme
                firstClicked.Refresh();

            }
            else

            {
                secondClicked = sender as PictureBox;
                secondClicked.Image = Image.FromFile(secondClicked.Tag.ToString());// acilan ikinci fotografi klasorde Tag'ni arartark getirme
                secondClicked.Refresh();
                System.Threading.Thread.Sleep(1000);
                if (firstClicked.Tag == secondClicked.Tag)
                {
                    sp3.Play();//dogru sesi oynatmak
                    firstClicked.Name = "acildi";
                    secondClicked.Name = "acildi";
                    firstClicked = null;
                    secondClicked = null;
                    CheckIfWin(); //oyun bitmesini kontrol eden fonksiyon 
                    counterForWin++;//kazanma sayaci artirmak 

                }
                else
                {
                    sp2.Play();//yanlis sesi oynatmak 
                    firstClicked.Image = Image.FromFile(@"peitto.jpg");
                    secondClicked.Image = Image.FromFile(@"peitto.jpg");

                    firstClicked = null;
                    secondClicked = null;
                }
            }

        }
        private void normal_mod(object sender, EventArgs e)
        {
            string izgara_1 = Giris.izgara_sayisi_getirme1;
            int izgara10 = Convert.ToInt16(izgara_1);
            if (firstClicked == null)
            {
                firstClicked = sender as PictureBox;
                firstClicked.Image = Image.FromFile(firstClicked.Tag.ToString());
                firstClicked.Refresh();
            }
            else
            {
                secondClicked = sender as PictureBox;
                secondClicked.Image = Image.FromFile(secondClicked.Tag.ToString());
                secondClicked.Refresh();
                System.Threading.Thread.Sleep(1000);
                if (firstClicked.Tag == secondClicked.Tag)
                {
                    sp3.Play();// dogru sesi oynatmak
                    firstClicked.Name = "acildi";
                    secondClicked.Name = "acildi";
                    firstClicked = null;
                    secondClicked = null;
                    CheckIfWin();
                    counterForWin++;
                }
                else
                {
                    sp2.Play();//yanlis sesi oynatmak 
                    var img = firstClicked.Tag.ToString();
                    firstClicked.Tag = secondClicked.Tag;
                    secondClicked.Tag = img;
                    firstClicked.Image = Image.FromFile(@"peitto.jpg");
                    secondClicked.Image = Image.FromFile(@"peitto.jpg");
                    firstClicked = null;
                    secondClicked = null;
                    img = null;
                }
            }
        }
        private void expert_mod(object sender, EventArgs e)
        {
            bool durum = true; 
            string izgara_1 = Giris.izgara_sayisi_getirme1;
            int izgara10 = Convert.ToInt16(izgara_1);
            if (firstClicked == null)
            {
                firstClicked = sender as PictureBox;
                firstClicked.Image = Image.FromFile(firstClicked.Tag.ToString());
                firstClicked.Name = "acildi";
                firstClicked.Refresh();
            }
            else
            {
                secondClicked = sender as PictureBox;
                secondClicked.Image = Image.FromFile(secondClicked.Tag.ToString()); //acilan ikinci fotografi klasorde Tag'ni arartark getirmek
                secondClicked.Name = "acildi";
                secondClicked.Refresh();
                System.Threading.Thread.Sleep(1000); //bir saniye bekletmek 
                if (firstClicked.Tag == secondClicked.Tag)//eger ailan fotografllar ayni ise 
                {
                    sp3.Play();//dogru sesi oynatmak
                    firstClicked.Name = "acik";
                    secondClicked.Name = "acik";
                    firstClicked = null;
                    secondClicked = null;
                    CheckIfWin();
                    counterForWin++; //kazanma sayaci artirmak 
                }
                else
                {
                    sp2.Play();//yanlis sesi oynatmak 
                    int x = 0, y = 0;
                    //secilen picturebox i ve j si bulamk icin 
                    for (int i = 0; i < izgara10; i++)
                    {
                        for (int j = 0; j < izgara10; j++)
                        {
                            if (Pic_Box[i, j] == firstClicked)
                            {
                                x = i;
                                y = j;
                            }
                        }
                    }
                    for (int i = x; i < izgara10; i++)
                    {
                        for (int j = y; j < izgara10; j++)
                        {
                            if(durum)
                            {
                                //index sona geldiyse sifirlayip en bastan baslamak
                                if (i == (izgara10 - 1) && (j == izgara10 - 1))
                                {
                                    i = 0;
                                    j = 0;
                                }

                                if (Pic_Box[i, j] != null)
                                {
                                    if (Pic_Box[i, j].Name == "kapali")//fotograf acik yada acilmis degilse 
                                    {

                                        MessageBox.Show(firstClicked.Name.ToString());

                                        var img0 = firstClicked.Tag.ToString();
                                        firstClicked.Tag = Pic_Box[i, j].Tag;
                                        Pic_Box[i, j].Tag = img0;
                                        img0 = null;
                                        firstClicked.Image = Image.FromFile(@"peitto.jpg");//fotograflari tekrar kapatmak
                                        secondClicked.Image = Image.FromFile(@"peitto.jpg");
                                        firstClicked.Name = "acildi";
                                        secondClicked.Name = "acildi";
                                        firstClicked = null;
                                        secondClicked = null;
                                        durum = false; 
                                        break;
                                    }
                                }
                            }

                            
                        }
                    }
                }
            }

        }
        private void Start_btn_Click(object sender, EventArgs e)
        {
            Start_btn.Enabled = false;
            show_btn.Enabled = false;
            Start_btn.BackColor = Color.Red;
            show_btn.BackColor = Color.Red;


        }
        private void AddPicturesToSquares()
        {
            //yine giris formdan degiskenkeri tanimlamak
            string izgara_1 = Giris.izgara_sayisi_getirme1;
            int izgara10 = Convert.ToInt16(izgara_1);
            for (int i = 0; i < izgara10; i++)
            {
                for (int j = 0; j < izgara10; j++)
                {
                    if (Pic_Box[i, j] != null)
                    {
                        int randomNum = random.Next(0, pictures.Count);// 0dan fotogrraflarin sayisi araliginda bir random almak
                        Pic_Box[i, j].Tag = @$"{pictures[randomNum]}";//o randomlu indexli fotografi isminin tag olarak yazmak 
                        Pic_Box[i, j].Image = Image.FromFile(@"peitto.jpg"); //picturebox fotografi kapali fotograf olarak almak
                        Pic_Box[i, j].Name = "kapali"; //ismi de kapali olarak tanimlaamak
                        pictures.RemoveAt(randomNum); //fotograflarin listesinden o aldigimiz random indexli item atmak
                    }
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Giris yeni = new Giris();
            this.Hide();
            yeni.Show();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            string izgara_1 = Giris.izgara_sayisi_getirme1;
            int izgara10 = Convert.ToInt16(izgara_1);
            for (int i = 0; i < (izgara10); i++)
            {
                for (int j = 0; j < (izgara10); j++)
                {
                    if (Pic_Box[i, j] != null)
                    {
                        Pic_Box[i, j].Image = Image.FromFile(Pic_Box[i, j].Tag.ToString());
                        Thread.Sleep(100);
                        Pic_Box[i, j].Refresh();
                        Pic_Box[i, j].Image = Image.FromFile(@"peitto.jpg");

                    }


                }
            }
        }

    }
}
