using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonalityTest
{
    public partial class Form1 : Form
    {


        public struct Answers { public int a; public RadioButton n; }
        public Answers q1, q2, q3, q4, q5, q6;

        public int i=0;

        private void button2_Click(object sender, EventArgs e)
        {
            if(i==0)
            {
                Text = "Test de personalitate";
                button2.Text = "English";
                label21.Text = "Vi se pare dificil să vă prezentaţi altor persoane.";
                label3.Text = "Adeseori vă adânciţi aşa de mult în gânduri încât ignoraţi sau uitaţi ce se întâmplă în jur.";
                label6.Text = "Încercaţi să răspundeţi la e-mailuri cât mai curând posibil şi nu suportaţi să aveţi inboxul deranjat.";
                label9.Text = "Puteţi să vă relaxaţi şi să vă concentraţi cu uşurinţă, chiar dacă există un anumit grad de presiune.";
                label12.Text = "De obicei nu începeţi o conversaţie.";
                label15.Text = "Rareori faceţi ceva din pură curiozitate.";
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
                i =1;
            }
            else
            {
                i = 0;
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
                label21.Text = "You find it difficult to introduce yourself to other people.";
                label3.Text = "You often get so lost in thoughts that you ignore or forget your surroundings.";
                label6.Text = "You try to respond to your e-mails as soon as possible and cannot stand a messy inbox.";
                label9.Text = "You find it easy to stay relaxed even when there is some pressure.";
                label12.Text = "You do not usually initiate conversations.";
                label15.Text = "You rarely do something just out of sheer curiosity.";
            }
        }

        int t = 0, k = 0;

        public Form1()
        {
            InitializeComponent();
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
            if (t != 0 && k==0)
            {
                if (i == 0)
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
                Form2 window = new Form2(q1.a, q2.a, q3.a, q4.a, q5.a, q6.a, i);
                window.Show();
                window.Location = this.Location;
                this.Hide();
            }
        }
    }
}
