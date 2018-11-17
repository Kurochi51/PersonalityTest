using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonalityTest
{
    public partial class Form4 : Form
    {
        public int j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12, j13, j14, j15, j16, j17, j18, i2;

        private void button2_Click(object sender, EventArgs e)
        {
            if (i2 == 0)
            {
                Text = "Test de personalitate";
                button2.Text = "English";
                label21.Text = "Într-o discuţie, adevărul trebuie să fie mai important decât sentimentele oamenilor.";
                label3.Text = "Rareori vă gândiţi la modul în care acţiunile dumneavoastră afectează alte persoane.";
                label6.Text = "Stilul dumneavoastră de lucru seamănă mai mult cu nişte vârfuri de energie aleatoare decât cu o abordare metodică şi organizată.";
                label9.Text = "Sunteţi adeseori invidios/invidioasă pe alţii.";
                label12.Text = "Un joc video sau o carte interesantă este adesea mai bun(ă) decât un eveniment social.";
                label15.Text = "Cea mai importantă parte a fiecărui proiect este capacitatea de a întocmi un plan şi respectarea acestuia.";
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
                label21.Text = "In a discussion, truth should be more important than people’s sensitivities.";
                label3.Text = "You rarely worry about how your actions affect other people.";
                label6.Text = "Your work style is closer to random energy spikes than to a methodical and organized approach.";
                label9.Text = "You are often envious of others.";
                label12.Text = "An interesting book or a video game is often better than a social event.";
                label15.Text = "Being able to develop a plan and stick to it is the most important part of every project.";
            }
        }

        public struct Answers { public int a; public RadioButton n; }
        public Answers q1, q2, q3, q4, q5, q6;

        int t = 0, k = 0;

        public Form4(int a, int b, int c, int d, int e, int f, int a2, int b2, int c2, int d2, int e2, int f2, int a3, int b3, int c3, int d3, int e3, int f3, int i)
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
            InitializeComponent();
            if (i2 == 1)
            {
                Text = "Test de personalitate";
                button2.Text = "English";
                label21.Text = "Într-o discuţie, adevărul trebuie să fie mai important decât sentimentele oamenilor.";
                label3.Text = "Rareori vă gândiţi la modul în care acţiunile dumneavoastră afectează alte persoane.";
                label6.Text = "Stilul dumneavoastră de lucru seamănă mai mult cu nişte vârfuri de energie aleatoare decât cu o abordare metodică şi organizată.";
                label9.Text = "Sunteţi adeseori invidios/invidioasă pe alţii.";
                label12.Text = "Un joc video sau o carte interesantă este adesea mai bun(ă) decât un eveniment social.";
                label15.Text = "Cea mai importantă parte a fiecărui proiect este capacitatea de a întocmi un plan şi respectarea acestuia.";
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
                label21.Text = "In a discussion, truth should be more important than people’s sensitivities.";
                label3.Text = "You rarely worry about how your actions affect other people.";
                label6.Text = "Your work style is closer to random energy spikes than to a methodical and organized approach.";
                label9.Text = "You are often envious of others.";
                label12.Text = "An interesting book or a video game is often better than a social event.";
                label15.Text = "Being able to develop a plan and stick to it is the most important part of every project.";
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
                Form5 window = new Form5(j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12, j13, j14, j15, j16, j17, j18, q1.a, q2.a, q3.a, q4.a, q5.a, q6.a, i2);
                window.Show();
                window.Location = this.Location;
                this.Hide();
            }
        }
    }
}
