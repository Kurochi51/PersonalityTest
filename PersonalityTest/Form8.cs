using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonalityTest
{
    public partial class Form8 : Form
    {

        public int j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12, j13, j14, j15, j16, j17, j18, j19, j20, j21, j22, j23, j24, j25, j26, j27, j28, j29, j30, j31, j32, j33, j34, j35, j36, j37, j38, j39, j40, j41, j42;

        private void button2_Click(object sender, EventArgs e)
        {
            if (i2 == 0)
            {
                Text = "Test de personalitate";
                button2.Text = "English";
                label21.Text = "Rareori vă simţiţi nesigur/ă.";
                label3.Text = "Nu aveţi nici o problemă în întocmirea şi respectarea unui orar personal.";
                label6.Text = "Atunci când vine vorba de lucrul în echipă, a avea dreptate este mai important decât a fi cooperant/ă.";
                label9.Text = "Credeţi că trebuie respectate părerile tuturor, indiferent dacă acestea sunt sau nu susţinute de fapte.";
                label12.Text = "Vă simţiţi mai energic/ă după ce petreceţi timpul cu un grup de persoane.";
                label15.Text = "Adeseori vă rătăciţi lucrurile.";
                label19.Text = "Ești de acord";
                label1.Text = "Ești de acord";
                label4.Text = "Ești de acord";
                label7.Text = "Ești de acord";
                label10.Text = "Ești de acord";
                label13.Text = "Ești de acord";
                label17.Text = "Nu ești de acord";
                label2.Text = "Nu ești de acord";
                label5.Text = "Nu ești de acord";
                label8.Text = "Nu ești de acord";
                label11.Text = "Nu ești de acord";
                label14.Text = "Nu ești de acord";
                button1.Text = "Următoarea";
                i2 = 1;
            }
            else
            {
                i2 = 0;
                Text = "Personality Test";
                button1.Text = "Next";
                button2.Text = "Romanian";
                label17.Text = "Disagree";
                label2.Text = "Disagree";
                label5.Text = "Disagree";
                label8.Text = "Disagree";
                label11.Text = "Disagree";
                label14.Text = "Disagree";
                label19.Text = "Agree";
                label1.Text = "Agree";
                label4.Text = "Agree";
                label7.Text = "Agree";
                label10.Text = "Agree";
                label13.Text = "Agree";
                label21.Text = "You rarely feel insecure.";
                label3.Text = "You have no difficulties coming up with a personal timetable and sticking to it.";
                label6.Text = "Being right is more important than being cooperative when it comes to teamwork.";
                label9.Text = "You think that everyone’s views should be respected regardless of whether they are supported by facts or not.";
                label12.Text = "You feel more energetic after spending time with a group of people.";
                label15.Text = "You frequently misplace your things.";
            }
        }

        public struct Answers { public int a; public RadioButton n; }
        public Answers q1, q2, q3, q4, q5, q6;

        int t = 0, k = 0, i2;

        public Form8(int a, int b, int c, int d, int e, int f, int a2, int b2, int c2, int d2, int e2, int f2, int a3, int b3, int c3, int d3, int e3, int f3, int a4, int b4, int c4, int d4, int e4, int f4, int a5, int b5, int c5, int d5, int e5, int f5, int a6, int b6, int c6, int d6, int e6, int f6, int a7, int b7, int c7, int d7, int e7, int f7, int i)
        {
            i2 = i;
            j1 = a;
            j2 = b;
            j3 = c;
            j4 = d;
            j5 = e;
            j6 = f;
            j7 = a2;
            j8 = b2;
            j9 = c2;
            j10 = d2;
            j11 = e2;
            j12 = f2;
            j13 = a3;
            j14 = b3;
            j15 = c3;
            j16 = d3;
            j17 = e3;
            j18 = f3;
            j19 = a4;
            j20 = b4;
            j21 = c4;
            j22 = d4;
            j23 = e4;
            j24 = f4;
            j25 = a5;
            j26 = b5;
            j27 = c5;
            j28 = d5;
            j29 = e5;
            j30 = f5;
            j31 = a6;
            j32 = b6;
            j33 = c6;
            j34 = d6;
            j35 = e6;
            j36 = f6;
            j37 = a7;
            j38 = b7;
            j39 = c7;
            j40 = d7;
            j41 = e7;
            j42 = f7;
            InitializeComponent();
            if (i2 == 1)
            {
                Text = "Test de personalitate";
                button2.Text = "English";
                label21.Text = "Rareori vă simţiţi nesigur/ă.";
                label3.Text = "Nu aveţi nici o problemă în întocmirea şi respectarea unui orar personal.";
                label6.Text = "Atunci când vine vorba de lucrul în echipă, a avea dreptate este mai important decât a fi cooperant/ă.";
                label9.Text = "Credeţi că trebuie respectate părerile tuturor, indiferent dacă acestea sunt sau nu susţinute de fapte.";
                label12.Text = "Vă simţiţi mai energic/ă după ce petreceţi timpul cu un grup de persoane.";
                label15.Text = "Adeseori vă rătăciţi lucrurile.";
                label19.Text = "Ești de acord";
                label1.Text = "Ești de acord";
                label4.Text = "Ești de acord";
                label7.Text = "Ești de acord";
                label10.Text = "Ești de acord";
                label13.Text = "Ești de acord";
                label17.Text = "Nu ești de acord";
                label2.Text = "Nu ești de acord";
                label5.Text = "Nu ești de acord";
                label8.Text = "Nu ești de acord";
                label11.Text = "Nu ești de acord";
                label14.Text = "Nu ești de acord";
                button1.Text = "Următoarea";
            }
            else
            {
                Text = "Personality Test";
                button1.Text = "Next";
                button2.Text = "Romanian";
                label17.Text = "Disagree";
                label2.Text = "Disagree";
                label5.Text = "Disagree";
                label8.Text = "Disagree";
                label11.Text = "Disagree";
                label14.Text = "Disagree";
                label19.Text = "Agree";
                label1.Text = "Agree";
                label4.Text = "Agree";
                label7.Text = "Agree";
                label10.Text = "Agree";
                label13.Text = "Agree";
                label21.Text = "You rarely feel insecure.";
                label3.Text = "You have no difficulties coming up with a personal timetable and sticking to it.";
                label6.Text = "Being right is more important than being cooperative when it comes to teamwork.";
                label9.Text = "You think that everyone’s views should be respected regardless of whether they are supported by facts or not.";
                label12.Text = "You feel more energetic after spending time with a group of people.";
                label15.Text = "You frequently misplace your things.";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /// Check if an option is selected for the first question and store the answer
            bool isAnyRadioButtonChecked1 = false;
            foreach (RadioButton rdo in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked1 = true;
                    q1.n = rdo;
                    q1.a = int.Parse(rdo.Name.Substring(3));
                    break;
                }
            }
            if (!isAnyRadioButtonChecked1)
            {
                t++;
            }
            bool isAnyRadioButtonChecked2 = false;
            foreach (RadioButton rdo in groupBox2.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked2 = true;
                    q2.n = rdo;
                    q2.a = int.Parse(rdo.Name.Substring(3));
                    break;
                }
            }
            if (!isAnyRadioButtonChecked2)
            {
                t++;
            }
            bool isAnyRadioButtonChecked3 = false;
            foreach (RadioButton rdo in groupBox3.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked3 = true;
                    q3.n = rdo;
                    q3.a = int.Parse(rdo.Name.Substring(3));
                    break;
                }
            }
            if (!isAnyRadioButtonChecked3)
            {
                t++;
            }
            bool isAnyRadioButtonChecked4 = false;
            foreach (RadioButton rdo in groupBox4.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked4 = true;
                    q4.n = rdo;
                    q4.a = int.Parse(rdo.Name.Substring(3));
                    break;
                }
            }
            if (!isAnyRadioButtonChecked4)
            {
                t++;
            }
            bool isAnyRadioButtonChecked5 = false;
            foreach (RadioButton rdo in groupBox5.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked5 = true;
                    q5.n = rdo;
                    q5.a = int.Parse(rdo.Name.Substring(3));
                    break;
                }
            }
            if (!isAnyRadioButtonChecked5)
            {
                t++;
            }
            bool isAnyRadioButtonChecked6 = false;
            foreach (RadioButton rdo in groupBox6.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked6 = true;
                    q6.n = rdo;
                    q6.a = int.Parse(rdo.Name.Substring(3));
                    break;
                }
            }
            if (!isAnyRadioButtonChecked6)
            {
                t++;
            }
            if (t != 0 && k == 0)
            {
                if (i2 == 0)
                {
                    MessageBox.Show("You haven't answered all the questions!");
                }
                else
                {
                    MessageBox.Show("Nu ați răspuns la toate întrebările!");
                }
                k++;
                t = 0;
            }
            else
            {
                Form9 window = new Form9(j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12, j13, j14, j15, j16, j17, j18, j19, j20, j21, j22, j23, j24, j25, j26, j27, j28, j29, j30, j31, j32, j33, j34, j35, j36, j37, j38, j39, j40, j41, j42, q1.a, q2.a, q3.a, q4.a, q5.a, q6.a, i2);
                window.Show();
                window.Location = this.Location;
                this.Hide();
            }
        }
    }
}
