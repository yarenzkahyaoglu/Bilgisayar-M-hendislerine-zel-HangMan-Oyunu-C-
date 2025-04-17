namespace Adam_Asmaca
{
    public partial class Form1 : Form
    {

        string[] kelimeler = { "ALGOR�TMA", "KODLAMA", "B�LG�SAYAR", "VER�", "YAZILIM", "DONANIM", "��LEMC�", "ANAKART", "VER�TABANI", "��FRELEME", "�NTERNET",
                        "G�VENL�K", "HACKER", "A�", "B�T", "PROGRAMLAMA" };
        string secilenKelime;
        char[] gizliKelime;
        int hak = 6;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            secilenKelime = kelimeler[rnd.Next(kelimeler.Length)];
            gizliKelime = new string('_', secilenKelime.Length).ToCharArray();
            lblKelime.Text = string.Join(" ", gizliKelime);
            hak = 6;
            lblHak.Text = "Hakk�n�z: " + hak;
            panelCizim.Invalidate();
            btnBaslat.Text = "Yeni Kelime";
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (txtHarf.Text.Length != 1)
            {
                MessageBox.Show("L�tfen sadece bir harf girin!");
                return;
            }

            char tahmin = char.ToUpper(txtHarf.Text[0]);
            bool dogruTahmin = false;

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                if (secilenKelime[i] == tahmin)
                {
                    gizliKelime[i] = tahmin;
                    dogruTahmin = true;
                }
            }

            if (!dogruTahmin)
            {
                hak--;
                panelCizim.Invalidate(); 
            }

            lblKelime.Text = string.Join(" ", gizliKelime);
            lblHak.Text = "Hakk�n�z: " + hak;

            if (hak == 0)
            {
                MessageBox.Show("Kaybettiniz! Kelime: " + secilenKelime);
                StartButton_Click(null, null); 
            }
            else if (!gizliKelime.Contains('_'))
            {
                MessageBox.Show("Tebrikler, kazand�n�z!");
                StartButton_Click(null, null); 
            }

            txtHarf.Clear();
            txtHarf.Focus();
        }

        private void panelCizim_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen kalem = new Pen(Color.Black, 3);

       
            g.DrawLine(kalem, 20, 180, 100, 180); // Zemin
            g.DrawLine(kalem, 60, 50, 60, 180);   // Direk
            g.DrawLine(kalem, 60, 50, 120, 50);   // �st �ubuk
            g.DrawLine(kalem, 120, 50, 120, 70);  // �p

            if (hak <= 5) g.DrawEllipse(kalem, 100, 70, 40, 40); // Kafa
            if (hak <= 4) g.DrawLine(kalem, 120, 110, 120, 150); // G�vde
            if (hak <= 3) g.DrawLine(kalem, 120, 120, 100, 140); // Sol kol
            if (hak <= 2) g.DrawLine(kalem, 120, 120, 140, 140); // Sa� kol
            if (hak <= 1) g.DrawLine(kalem, 120, 150, 100, 170); // Sol bacak
            if (hak <= 0) g.DrawLine(kalem, 120, 150, 140, 170); // Sa� bacak
        }

        private void lblKelime_Click(object sender, EventArgs e)
        {

        }
    }
}
