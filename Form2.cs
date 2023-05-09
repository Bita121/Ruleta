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

namespace Ruleta
{
   
    public partial class Form2 : Form
    {
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        int numarvieti = 3;
        Random rnd = new Random();
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (((textBox1 == null) || (textBox1.Text != "norocos" && textBox1.Text != "Norocos" && textBox1.Text != "NOROCOS" && textBox1.Text != "sarac" &&  textBox1.Text != "Sarac" && textBox1.Text != "SARAC")))
            {
                textBox2.Text = "Te rog sa introduci in chenarul din stanga optiunea norocos/sarac si apoi sa apesi pe buton";
            }
            else
            {
                string folder = @"F:\Joc\Fericit";
                string[] files = Directory.GetFiles(folder);
                pictureBox1.ImageLocation = files[rnd.Next(files.Length)];
                Console.WriteLine(pictureBox1.ImageLocation.ToString());
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\4.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\1.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\2.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\3.png" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\5.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\6.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\7.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\8.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
               
                //LOSING SIDE
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\9.jpeg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\10.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\11.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\12.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\13.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\14.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\15.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\16.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti++;
                    textBox2.Text = "Esti prea bun! Continua sa te joci AICI.\n" + "Acum ai: " + numarvieti + " Vieti";
                }
                if (numarvieti == 9)
                {
                    button1.Enabled = false;
                    MessageBox.Show("Curiozitatea a omorat pisica!\n Felicitari!\n Tocmai ti-ai irosit tot norocul.\n S-au dus cele 9 vieti, iar aplicatia se va inchide in 5 secunde");
                    wait(5000);
                    Application.Exit();

                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\1.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\2.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\3.png" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\4.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\5.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\6.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\7.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\8.jpg" && (textBox1.Text == "sarac" || textBox1.Text == "Sarac" || textBox1.Text == "SARAC"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\9.jpeg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\10.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\11.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\12.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\13.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\14.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\15.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (pictureBox1.ImageLocation == @"F:\Joc\Fericit\16.jpg" && (textBox1.Text == "norocos" || textBox1.Text == "Norocos" || textBox1.Text == "NOROCOS"))
                {
                    numarvieti--;
                    textBox2.Text = "Esti din ce in ce mai aproape de drumul cel bun...\n" + "Mai ai: " + numarvieti + " Vieti";
                }
                if (numarvieti == 0)
                {
                    button1.Enabled = false;
                    MessageBox.Show("Considera ca pe o lectie invatata!\n" + "...si un capitol incheiat!" + "\nJocul s-a terminat, aplicatia se va inchide in 5 secunde");
                    wait(5000);
                    Application.Exit();
                }

            }
        }

        
    }
}
