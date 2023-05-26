using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Testing_Figuring_Out.Biljke;

namespace Testing_Figuring_Out
{
    public partial class Form1 : Form
    {
        //Pen pen = new Pen(Color.Black, 2);
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void OdabirBiljkaCBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Graphics graphic = this.CreateGraphics();
            //Rectangle rectangle = new Rectangle(10, 10, 40, 40);
            switch(OdabirBiljkaCBx.SelectedIndex)
            {
                case (int)Povrce.Mrkva:
                    Mrkva mrkva = new Mrkva();
                    DobriSusjediLb.Text = mrkva.DobriSusjedi();
                    LosiSusjediLb.Text = mrkva.LosiSusjedi();
                    break;

                case (int)Povrce.Celer:
                    Celer celer = new Celer();
                    DobriSusjediLb.Text = celer.DobriSusjedi();
                    LosiSusjediLb.Text = celer.LosiSusjedi();
                    break;

                case (int)Povrce.Cikla:
                    Cikla cikla = new Cikla();
                    DobriSusjediLb.Text = cikla.DobriSusjedi();
                    LosiSusjediLb.Text = cikla.LosiSusjedi();
                    break;

                case (int)Povrce.Cesnjak:
                    Cesnjak cesnjak = new Cesnjak();
                    DobriSusjediLb.Text = cesnjak.DobriSusjedi();
                    LosiSusjediLb.Text = cesnjak.LosiSusjedi();
                    break;

                case (int)Povrce.Endivija:
                    Endivija endivija = new Endivija();
                    DobriSusjediLb.Text = endivija.DobriSusjedi();
                    LosiSusjediLb.Text = endivija.LosiSusjedi();
                    break;

                case (int)Povrce.Grah:
                    Grah grah = new Grah();
                    DobriSusjediLb.Text = grah.DobriSusjedi();
                    LosiSusjediLb.Text = grah.LosiSusjedi();
                    break;

                case (int)Povrce.Grašak:
                    Grašak grasak = new Grašak();
                    DobriSusjediLb.Text = grasak.DobriSusjedi();
                    LosiSusjediLb.Text = grasak.LosiSusjedi();
                    break;

                case (int)Povrce.Jagoda:
                    Jagoda jagoda = new Jagoda();
                    DobriSusjediLb.Text = jagoda.DobriSusjedi();
                    LosiSusjediLb.Text = jagoda.LosiSusjedi();
                    break;

                case (int)Povrce.Komorač:
                    Komorač komorac = new Komorač();
                    DobriSusjediLb.Text = komorac.DobriSusjedi();
                    LosiSusjediLb.Text = komorac.LosiSusjedi();
                    break;

                case (int)Povrce.Korabica:
                    Korabica korabica = new Korabica();
                    DobriSusjediLb.Text = korabica.DobriSusjedi();
                    LosiSusjediLb.Text = korabica.LosiSusjedi();
                    break;

                case (int)Povrce.Krastavac:
                    Krastavac krastavac = new Krastavac();
                    DobriSusjediLb.Text = krastavac.DobriSusjedi();
                    LosiSusjediLb.Text = krastavac.LosiSusjedi();
                    break;

                case (int)Povrce.Krumpir:
                    Krumpir krumpir = new Krumpir();
                    DobriSusjediLb.Text = krumpir.DobriSusjedi();
                    LosiSusjediLb.Text = krumpir.LosiSusjedi();
                    break;

                case (int)Povrce.Kupusnjače:
                    Kupusnjače kupusnjace = new Kupusnjače();
                    DobriSusjediLb.Text = kupusnjace.DobriSusjedi();
                    LosiSusjediLb.Text = kupusnjace.LosiSusjedi();
                    break;

                case (int)Povrce.Luk:
                    Luk luk = new Luk();
                    DobriSusjediLb.Text = luk.DobriSusjedi();
                    LosiSusjediLb.Text = luk.LosiSusjedi();
                    break;

                case (int)Povrce.Blitva:
                    Blitva blitva = new Blitva();
                    DobriSusjediLb.Text = blitva.DobriSusjedi();
                    LosiSusjediLb.Text = blitva.LosiSusjedi();
                    break;

                case (int)Povrce.Poriluk:
                    Poriluk poriluk = new Poriluk();
                    DobriSusjediLb.Text = poriluk.DobriSusjedi();
                    LosiSusjediLb.Text = poriluk.LosiSusjedi();
                    break;

                case (int)Povrce.Rukola:
                    Rukola rukola = new Rukola();
                    DobriSusjediLb.Text = rukola.DobriSusjedi();
                    LosiSusjediLb.Text = rukola.LosiSusjedi();
                    break;

                case (int)Povrce.Radič:
                    Radič radic = new Radič();
                    DobriSusjediLb.Text = radic.DobriSusjedi();
                    LosiSusjediLb.Text = radic.LosiSusjedi();
                    break;

                case (int)Povrce.Rajčica:
                    Rajčica rajcica = new Rajčica();
                    DobriSusjediLb.Text = rajcica.DobriSusjedi();
                    LosiSusjediLb.Text = rajcica.LosiSusjedi();
                    break;

                case (int)Povrce.Rotkvica:
                    Rotkvica rotkvica = new Rotkvica();
                    DobriSusjediLb.Text = rotkvica.DobriSusjedi();
                    LosiSusjediLb.Text = rotkvica.LosiSusjedi();
                    break;

                case (int)Povrce.Salata:
                    Salata salata = new Salata();
                    DobriSusjediLb.Text = salata.DobriSusjedi();
                    LosiSusjediLb.Text = salata.LosiSusjedi();
                    break;

                case (int)Povrce.Šparoga:
                    Šparoga sparoga = new Šparoga();
                    DobriSusjediLb.Text = sparoga.DobriSusjedi();
                    LosiSusjediLb.Text = sparoga.LosiSusjedi();
                    break;

                case (int)Povrce.Špinat:
                    Špinat spinat = new Špinat();
                    DobriSusjediLb.Text = spinat.DobriSusjedi();
                    LosiSusjediLb.Text = spinat.LosiSusjedi();
                    break;

                case (int)Povrce.Tikvice:
                    Tikvice tikvice = new Tikvice();
                    DobriSusjediLb.Text = tikvice.DobriSusjedi();
                    LosiSusjediLb.Text = tikvice.LosiSusjedi();
                    break;

                case (int)Povrce.Brokula:
                    Brokula brokula = new Brokula();
                    DobriSusjediLb.Text = brokula.DobriSusjedi();
                    LosiSusjediLb.Text = brokula.LosiSusjedi();
                    break;

                case (int)Povrce.Paprika:
                    Paprika paprika = new Paprika();
                    DobriSusjediLb.Text = paprika.DobriSusjedi();
                    LosiSusjediLb.Text = paprika.LosiSusjedi();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LosiSusjediLb_Click(object sender, EventArgs e)
        {

        }
    }
    public enum Povrce
    {
        Mrkva,
        Celer,
        Cikla,
        Cesnjak,
        Endivija,
        Grah,
        Grašak,
        Jagoda,
        Komorač,
        Korabica,
        Krastavac,
        Krumpir,
        Kupusnjače,
        Luk,
        Blitva,
        Poriluk,
        Rukola,
        Radič,
        Rajčica,
        Rotkvica,
        Salata,
        Šparoga,
        Špinat,
        Tikvice,
        Brokula,
        Paprika
    }
}
