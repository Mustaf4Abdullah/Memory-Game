namespace Memory_Game_Mustafa_Abdullah
{
    public partial class Giris : Form
    {
        static string izgara_sayisi1;


        static string Mod_Secenek;
        static string kullanci_adi;
        public Giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static string kullanci_getirme
        {
            get
            {
                return kullanci_adi;
            }
            set
            {
                kullanci_adi = value;

            }
        }
        public static string izgara_sayisi_getirme1
        {
            get
            {
                return izgara_sayisi1;

            }
            set
            {
                izgara_sayisi1 = value;

            }
        }

        public static string Mod_getirme
        {
            get
            {
                return Mod_Secenek;
            }
            set
            {
                Mod_Secenek = value;

            }
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            if ((Mod_Secenek!="" )&& (izgara_sayisi1!=""))
            {
                Oyun_Alani yeni = new Oyun_Alani();
                this.Hide();
                yeni.Show();

            }
            else { MessageBox.Show("lutfen secenekleri doldurunuz !!"); }
           
        }
        private void Easy_Mod_CheckedChanged(object sender, EventArgs e)
        {
            Normal_Mod.Enabled = false;
            Expert_Mod.Enabled = false;
            Mod_Secenek = "Easy";
        }
   
    private void Normal_Mod_CheckedChanged(object sender, EventArgs e)
        {
            Easy_Mod.Enabled = false;
            Expert_Mod.Enabled = false;
            Mod_Secenek = "Normal";
        }

        private void Expert_Mod_CheckedChanged(object sender, EventArgs e)
        {
            Easy_Mod.Enabled = false;
            Normal_Mod.Enabled = false;
            Mod_Secenek = "Expert";
        }

        private void Dort_izgara_CheckedChanged(object sender, EventArgs e)
        {
            Alti_izgara.Enabled = false;
            Sekiz_izgara.Enabled = false;
            izgara_sayisi1 = "4";

        }

        private void Alti_izgara_CheckedChanged(object sender, EventArgs e)
        {
            Dort_izgara.Enabled = false;
            Sekiz_izgara.Enabled = false;
            izgara_sayisi1 = "6";

        }

        private void Sekiz_izgara_CheckedChanged(object sender, EventArgs e)
        {
            Dort_izgara.Enabled = false;
            Alti_izgara.Enabled = false;
            izgara_sayisi1 = "8";
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Dort_izgara.Checked = false;
            Alti_izgara.Checked = false;
            Sekiz_izgara.Checked = false;
            Easy_Mod.Checked = false;
            Normal_Mod.Checked = false;
            Expert_Mod.Checked = false;
            Dort_izgara.Enabled = true;
            Alti_izgara.Enabled = true;
            Sekiz_izgara.Enabled =true;
            Easy_Mod.Enabled = true;
            Normal_Mod.Enabled = true;
            Expert_Mod.Enabled = true;
            izgara_sayisi1 = "";
            Mod_Secenek = "";


        }
    }


}