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
        PersonalityMath math;

        public Results()
        {
            InitializeComponent();
            m1.Text = math?.a1;
            m2.Text = math?.a2;
            e1.Text = math?.b1;
            e1.Text = math?.b2;
            n1.Text = math?.c1;
            n2.Text = math?.c2;
            t1.Text = math?.d1;
            t2.Text = math?.d2;
            i1.Text = math?.e1;
            i2.Text = math?.e2;
        }
    }
}
