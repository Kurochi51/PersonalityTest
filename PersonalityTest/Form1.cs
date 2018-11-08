using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonalityTest
{
    public partial class Form1 : Form
    {

        public int j1
        {
            get { return q1.a; }
            set { q1.a = value; }
        }
        public int j2
        {
            get { return q2.a; }
            set { q2.a = value; }
        }
        public int j3
        {
            get { return q3.a; }
            set { q3.a = value; }
        }
        public int j4
        {
            get { return q4.a; }
            set { q4.a = value; }
        }
        public int j5
        {
            get { return q5.a; }
            set { q5.a = value; }
        }
        public int j6
        {
            get { return q6.a; }
            set { q6.a = value; }
        }

        public struct Answers { public int a; public RadioButton n; }
        public Answers q1, q2, q3, q4, q5, q6;

        int t =0;

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
            // DEBUG MODE ACTIVE: to remove replace == with !=
            if (t == 0)
            {
                MessageBox.Show("You haven't answered all the questions!");
                if (q1.n != null)
                    q1.n.Checked = false;
                if (q2.n != null)
                    q2.n.Checked = false;
                if (q3.n != null)
                    q3.n.Checked = false;
                if (q4.n != null)
                    q4.n.Checked = false;
                if (q5.n != null)
                    q5.n.Checked = false;
                if (q6.n != null)
                    q6.n.Checked = false;
                t = 0;
            }
            else
            {
                /// Attempt making an array and passing it around
                Form2 window = new Form2(q1.a, q2.a, q3.a, q4.a, q5.a, q6.a);
                /// Passing 6 variables works,but I can't do it multiple times neither on parts
                //PersonalityMath2 t = new PersonalityMath2(q1.a,q2.a,q3.a,q4.a,q5.a,q6.a);
                window.Show();
                window.Location = this.Location;
                this.Hide();
            }
        }
    }
}
