using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonalityTest
{
    public partial class Form2 : Form
    {

        public int j1, j2, j3, j4, j5, j6, i2;

        private void button2_Click(object sender, EventArgs e)
        {
            if (i2 == 0)
            {
                Text = "Test de personalitate";
                button2.Text = "English";
                label21.Text = "Vă simţiţi superior celorlalţi.";
                label3.Text = "A fi organizat/ă este mai important pentru dumneavoastră decât a fi adaptabil/ă.";
                label6.Text = "De obicei sunteţi foarte motivat/ă şi energic/ă.";
                label9.Text = "Câştigarea unei dezbateri contează mai puţin decât să nu supăraţi pe nimeni.";
                label12.Text = "Adeseori aveţi senzaţia că trebuie să daţi explicaţii altora.";
                label15.Text = "Locuinţa şi locul unde lucraţi sunt destul de ordonate.";
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
                label21.Text = "You feel superior to other people.";
                label3.Text = "Being organized is more important to you than being adaptable.";
                label6.Text = "You are usually highly motivated and energetic.";
                label9.Text = "Winning a debate matters less to you than making sure no one gets upset.";
                label12.Text = "You often feel as if you have to justify yourself to other people.";
                label15.Text = "Your home and work environments are quite tidy.";
            }
        }

        public struct Answers { public int a; public RadioButton n; }
        public Answers q1, q2, q3, q4, q5, q6;

        int t = 0, k = 0;

        public Form2(int a, int b, int c, int d, int e, int f, int i)
        {
            i2 = i;
            j1 = a;
            j2 = b;
            j3 = c;
            j4 = d;
            j5 = e;
            j6 = f;
            InitializeComponent();
            if(i2==1)
            {
                Text = "Test de personalitate";
                button2.Text = "English";
                label21.Text = "Vă simţiţi superior celorlalţi.";
                label3.Text = "A fi organizat/ă este mai important pentru dumneavoastră decât a fi adaptabil/ă.";
                label6.Text = "De obicei sunteţi foarte motivat/ă şi energic/ă.";
                label9.Text = "Câştigarea unei dezbateri contează mai puţin decât să nu supăraţi pe nimeni.";
                label12.Text = "Adeseori aveţi senzaţia că trebuie să daţi explicaţii altora.";
                label15.Text = "Locuinţa şi locul unde lucraţi sunt destul de ordonate.";
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
                label21.Text = "You feel superior to other people.";
                label3.Text = "Being organized is more important to you than being adaptable.";
                label6.Text = "You are usually highly motivated and energetic.";
                label9.Text = "Winning a debate matters less to you than making sure no one gets upset.";
                label12.Text = "You often feel as if you have to justify yourself to other people.";
                label15.Text = "Your home and work environments are quite tidy.";
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
                Form3 window = new Form3(j1, j2, j3, j4, j5, j6, q1.a, q2.a, q3.a, q4.a, q5.a, q6.a, i2);
                window.Show();
                window.Location = this.Location;
                this.Hide();
            }
        }
    }
}
