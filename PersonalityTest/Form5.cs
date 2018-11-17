using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonalityTest
{
    public partial class Form5 : Form
    {
        public int j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12, j13, j14, j15, j16, j17, j18, j19, j20, j21, j22, j23, j24, i2;

        private void button2_Click(object sender, EventArgs e)
        {
            if (i2 == 0)
            {
                Text = "Test de personalitate";
                button2.Text = "English";
                label21.Text = "Rareori sunteţi distras/ă de fantezii şi idei.";
                label3.Text = "Atunci când vă plimbaţi prin natură sunteţi adeseori pierdut/ă în gânduri.";
                label6.Text = "Dacă cineva nu răspunde rapid la e-mail, începeţi să vă faceţi griji dacă nu cumva aţi spus ceva greşit.";
                label9.Text = "Ca părinte aţi prefera să vă crească copilul mai debrabă bun decât inteligent.";
                label12.Text = "Nu lăsaţi alte persoane să vă influenţeze acţiunile.";
                label15.Text = "Visele dumneavoastră tind să se centreze pe lumea reală şi evenimentele din aceasta.";
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
                label21.Text = "You rarely get carried away by fantasies and ideas.";
                label3.Text = "You often find yourself lost in thought when you are walking in nature.";
                label6.Text = "If someone does not respond to your e-mail quickly, you start worrying if you said something wrong.";
                label9.Text = "As a parent, you would rather see your child grow up kind than smart.";
                label12.Text = "You do not let other people influence your actions.";
                label15.Text = "When you sleep, your dreams tend to focus on the real world and its events.";
            }
        }

        public struct Answers { public int a; public RadioButton n; }
        public Answers q1, q2, q3, q4, q5, q6;

        int t = 0, k = 0;

        public Form5(int a, int b, int c, int d, int e, int f, int a2, int b2, int c2, int d2, int e2, int f2, int a3, int b3, int c3, int d3, int e3, int f3, int a4, int b4, int c4, int d4, int e4, int f4, int i)
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
            InitializeComponent();
            if (i2 == 1)
            {
                Text = "Test de personalitate";
                button2.Text = "English";
                label21.Text = "Rareori sunteţi distras/ă de fantezii şi idei.";
                label3.Text = "Atunci când vă plimbaţi prin natură sunteţi adeseori pierdut/ă în gânduri.";
                label6.Text = "Dacă cineva nu răspunde rapid la e-mail, începeţi să vă faceţi griji dacă nu cumva aţi spus ceva greşit.";
                label9.Text = "Ca părinte aţi prefera să vă crească copilul mai debrabă bun decât inteligent.";
                label12.Text = "Nu lăsaţi alte persoane să vă influenţeze acţiunile.";
                label15.Text = "Visele dumneavoastră tind să se centreze pe lumea reală şi evenimentele din aceasta.";
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
                label21.Text = "You rarely get carried away by fantasies and ideas.";
                label3.Text = "You often find yourself lost in thought when you are walking in nature.";
                label6.Text = "If someone does not respond to your e-mail quickly, you start worrying if you said something wrong.";
                label9.Text = "As a parent, you would rather see your child grow up kind than smart.";
                label12.Text = "You do not let other people influence your actions.";
                label15.Text = "When you sleep, your dreams tend to focus on the real world and its events.";
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
                Form6 window = new Form6(j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12, j13, j14, j15, j16, j17, j18, j19, j20, j21, j22, j23, j24, q1.a, q2.a, q3.a, q4.a, q5.a, q6.a, i2);
                window.Show();
                window.Location = this.Location;
                this.Hide();
            }
        }
    }
}
