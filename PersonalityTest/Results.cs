using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace PersonalityTest
{
    public partial class Results : Form
    {
        PersonalityMath math = new PersonalityMath();

        public Results()
        {
            InitializeComponent();
            //math.Main();
            m1.Text = math.a1.ToString();
            m2.Text = math.a2.ToString();
            e1.Text = math.b1.ToString();
            e2.Text = math.b2.ToString();
            n1.Text = math.c1.ToString();
            n2.Text = math.c2.ToString();
            t1.Text = math.d1.ToString();
            t2.Text = math.d2.ToString();
            i1.Text = math.e1.ToString();
            i2.Text = math.e2.ToString();
        }
    }
}
