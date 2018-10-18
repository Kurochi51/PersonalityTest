using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalityTest
{
    public partial class Results : Form
    {
        Form1 f1; Form2 f2; Form3 f3; Form4 f4; Form5 f5; Form6 f6; Form7 f7; Form8 f8; Form9 f9; Form10 f10;

        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            if (f1.q1.a==1 && f1.q2.a == 1 && f1.q3.a == 1 && f1.q4.a == 1 && f1.q5.a == 1 && f1.q6.a == 1 && f2.q1.a == 1 && f2.q2.a == 1 && f2.q3.a == 1 && f2.q4.a == 1 && f2.q5.a == 1 && f2.q6.a == 1)
            {

            }
        }
    }
}
