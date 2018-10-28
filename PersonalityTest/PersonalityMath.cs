using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace PersonalityTest
{
    class PersonalityMath
    {
        Form1 f1; Form2 f2; Form3 f3; Form4 f4; Form5 f5; Form6 f6; Form7 f7; Form8 f8; Form9 f9; Form10 f10;

        public struct Personality { public int mind; public int energy; public int nature; public int tactics; public int identify; }
        public Personality p1, p2, t;

        public int i;
        public string a1, a2, b1, b2, c1, c2, d1, d2, e1, e2;

#pragma warning disable CS1690 // Accessing a member on a field of a marshal-by-reference class may cause a runtime exception

        public void Mind()
        {
            switch (f1.q1.a)
            {
                case 1:
                    p1.mind -= 3;
                    p2.mind += 3;
                    break;
                case 2:
                    p1.mind -= 2;
                    p2.mind += 2;
                    break;
                case 3:
                    p1.mind -= 0;
                    p2.mind += 0;
                    t.mind++;
                    break;
                case 5:
                    p1.mind += 2;
                    p2.mind -= 2;
                    break;
                case 6:
                    p1.mind += 4;
                    p2.mind -= 4;
                    break;
                case 7:
                    p1.mind += 5;
                    p2.mind -= 5;
                    break;
                default:
                    break;
            }
            switch (f1.q2.a)
            {
                case 1:
                    p1.mind += 4;
                    p2.mind -= 4;
                    break;
                case 2:
                    p1.mind += 2;
                    p2.mind -= 2;
                    break;
                case 3:
                    p1.mind += 1;
                    p2.mind -= 1;
                    break;
                case 5:
                    p1.mind -= 1;
                    p2.mind += 1;
                    break;
                case 6:
                    p1.mind -= 3;
                    p2.mind += 3;
                    break;
                case 7:
                    p1.mind -= 4;
                    p2.mind += 4;
                    break;
                default:
                    break;
            }
            switch (f1.q5.a)
            {
                case 1:
                    p1.mind -= 3;
                    p2.mind += 3;
                    break;
                case 2:
                    p1.mind -= 2;
                    p2.mind += 2;
                    break;
                case 3:
                    p1.mind -= 0;
                    p2.mind += 0;
                    t.mind++;
                    break;
                case 5:
                    p1.mind += 2;
                    p2.mind -= 2;
                    break;
                case 6:
                    p1.mind += 4;
                    p2.mind -= 4;
                    break;
                case 7:
                    p1.mind += 5;
                    p2.mind -= 5;
                    break;
                default:
                    break;
            }
            switch (f2.q3.a)
            {
                case 1:
                    p1.mind +=5;
                    p2.mind -=5;
                    break;
                case 2:
                    p1.mind +=4;
                    p2.mind -=4;
                    break;
                case 3:
                    p1.mind +=2;
                    p2.mind -=2;
                    break;
                case 5:
                    p1.mind -=0;
                    p2.mind +=0;
                    t.mind++;
                    break;
                case 6:
                    p1.mind -=2;
                    p2.mind +=2;
                    break;
                case 7:
                    p1.mind -=3;
                    p2.mind +=3;
                    break;
                default:
                    break;
            }
            switch (f3.q1.a)
            {
                case 1:
                    p1.mind +=5;
                    p2.mind -=5;
                    break;
                case 2:
                    p1.mind +=4;
                    p2.mind -=4;
                    break;
                case 3:
                    p1.mind +=2;
                    p2.mind -=2;
                    break;
                case 5:
                    p1.mind -=0;
                    p2.mind +=0;
                    t.mind++;
                    break;
                case 6:
                    p1.mind -=2;
                    p2.mind +=2;
                    break;
                case 7:
                    p1.mind -=3;
                    p2.mind +=3;
                    break;
                default:
                    break;
            }
            switch (f4.q5.a)
            {
                case 1:
                    p1.mind -=3;
                    p2.mind +=3;
                    break;
                case 2:
                    p1.mind -=2;
                    p2.mind +=2;
                    break;
                case 3:
                    p1.mind -=0;
                    p2.mind +=0;
                    t.mind++;
                    break;
                case 5:
                    p1.mind -=2;
                    p2.mind +=2;
                    break;
                case 6:
                    p1.mind -=4;
                    p2.mind +=4;
                    break;
                case 7:
                    p1.mind -=5;
                    p2.mind +=5;
                    break;
                default:
                    break;
            }
            switch (f6.q1.a)
            {
                case 1:
                    p1.mind +=5;
                    p2.mind -=5;
                    break;
                case 2:
                    p1.mind +=4;
                    p2.mind -=4;
                    break;
                case 3:
                    p1.mind +=2;
                    p2.mind -=2;
                    break;
                case 5:
                    p1.mind -=0;
                    p2.mind +=0;
                    t.mind++;
                    break;
                case 6:
                    p1.mind -=2;
                    p2.mind +=2;
                    break;
                case 7:
                    p1.mind -=3;
                    p2.mind +=3;
                    break;
                default:
                    break;
            }
            switch (f6.q4.a)
            {
                case 1:
                    p1.mind +=5;
                    p2.mind -=5;
                    break;
                case 2:
                    p1.mind +=4;
                    p2.mind -=4;
                    break;
                case 3:
                    p1.mind +=2;
                    p2.mind -=2;
                    break;
                case 5:
                    p1.mind -=0;
                    p2.mind +=0;
                    t.mind++;
                    break;
                case 6:
                    p1.mind -=2;
                    p2.mind +=2;
                    break;
                case 7:
                    p1.mind -=3;
                    p2.mind +=3;
                    break;
                default:
                    break;
            }
            switch (f7.q1.a)
            {
                case 1:
                    p1.mind -=3;
                    p2.mind +=3;
                    break;
                case 2:
                    p1.mind -=2;
                    p2.mind +=2;
                    break;
                case 3:
                    p1.mind -=0;
                    p2.mind +=0;
                    t.mind++;
                    break;
                case 5:
                    p1.mind +=2;
                    p2.mind -=2;
                    break;
                case 6:
                    p1.mind +=4;
                    p2.mind -=4;
                    break;
                case 7:
                    p1.mind +=5;
                    p2.mind -=5;
                    break;
                default:
                    break;
            }
            switch (f8.q5.a)
            {
                case 1:
                    p1.mind +=5;
                    p2.mind -=5;
                    break;
                case 2:
                    p1.mind +=4;
                    p2.mind -=4;
                    break;
                case 3:
                    p1.mind +=2;
                    p2.mind -=2;
                    break;
                case 5:
                    p1.mind -=0;
                    p2.mind +=0;
                    t.mind++;
                    break;
                case 6:
                    p1.mind -=2;
                    p2.mind +=2;
                    break;
                case 7:
                    p1.mind -=3;
                    p2.mind +=3;
                    break;
                default:
                    break;
            }
            switch (f9.q4.a)
            {
                case 1:
                    p1.mind -=3;
                    p2.mind +=3;
                    break;
                case 2:
                    p1.mind -=2;
                    p2.mind +=2;
                    break;
                case 3:
                    p1.mind -=0;
                    p2.mind +=0;
                    t.mind++;
                    break;
                case 5:
                    p1.mind +=2;
                    p2.mind -=2;
                    break;
                case 6:
                    p1.mind +=4;
                    p2.mind -=4;
                    break;
                case 7:
                    p1.mind +=5;
                    p2.mind -=5;
                    break;
                default:
                    break;
            }
            switch (f9.q5.a)
            {
                case 1:
                    p1.mind -=4;
                    p2.mind +=4;
                    break;
                case 2:
                    p1.mind -=3;
                    p2.mind +=3;
                    break;
                case 3:
                    p1.mind -=1;
                    p2.mind +=1;
                    break;
                case 5:
                    p1.mind +=1;
                    p2.mind -=1;
                    break;
                case 6:
                    p1.mind +=2;
                    p2.mind -=2;
                    break;
                case 7:
                    p1.mind +=4;
                    p2.mind -=4;
                    break;
                default:
                    break;
            }
            switch (f10.q1.a)
            {
                case 1:
                    p1.mind -=3;
                    p2.mind +=3;
                    break;
                case 2:
                    p1.mind -=2;
                    p2.mind +=2;
                    break;
                case 3:
                    p1.mind -=0;
                    p2.mind +=0;
                    t.mind++;
                    break;
                case 5:
                    p1.mind +=2;
                    p2.mind -=2;
                    break;
                case 6:
                    p1.mind +=4;
                    p2.mind -=4;
                    break;
                case 7:
                    p1.mind +=5;
                    p2.mind -=5;
                    break;
                default:
                    break;
            }
            switch (f10.q6.a)
            {
                case 1:
                    p1.mind +=4;
                    p2.mind -=4;
                    break;
                case 2:
                    p1.mind +=2;
                    p2.mind -=2;
                    break;
                case 3:
                    p1.mind +=1;
                    p2.mind -=1;
                    break;
                case 5:
                    p1.mind -=1;
                    p2.mind +=1;
                    break;
                case 6:
                    p1.mind -=3;
                    p2.mind +=3;
                    break;
                case 7:
                    p1.mind -=4;
                    p2.mind +=4;
                    break;
                default:
                    break;
            }
        }

        public void Energy()
        {
            switch (f3.q2.a)
            {
                case 1:
                    p1.energy -=4;
                    p2.energy +=4;
                    break;
                case 2:
                    p1.energy -=3;
                    p2.energy +=3;
                    break;
                case 3:
                    p1.energy -=1;
                    p2.energy +=1;
                    break;
                case 5:
                    p1.energy +=1;
                    p2.energy -=1;
                    break;
                case 6:
                    p1.energy +=2;
                    p2.energy -=2;
                    break;
                case 7:
                    p1.energy +=4;
                    p2.energy -=4;
                    break;
                default:
                    break;
            }
            switch (f5.q1.a)
            {
                case 1:
                    p1.energy -=4;
                    p2.energy +=4;
                    break;
                case 2:
                    p1.energy -=3;
                    p2.energy +=3;
                    break;
                case 3:
                    p1.energy -=1;
                    p2.energy +=1;
                    break;
                case 5:
                    p1.energy +=1;
                    p2.energy -=1;
                    break;
                case 6:
                    p1.energy +=2;
                    p2.energy -=2;
                    break;
                case 7:
                    p1.energy +=4;
                    p2.energy -=4;
                    break;
                default:
                    break;
            }
            switch (f5.q2.a)
            {
                case 1:
                    p1.energy +=4;
                    p2.energy -=4;
                    break;
                case 2:
                    p1.energy +=2;
                    p2.energy -=2;
                    break;
                case 3:
                    p1.energy +=1;
                    p2.energy -=1;
                    break;
                case 5:
                    p1.energy -=1;
                    p2.energy +=1;
                    break;
                case 6:
                    p1.energy -=3;
                    p2.energy +=3;
                    break;
                case 7:
                    p1.energy -=4;
                    p2.energy +=4;
                    break;
                default:
                    break;
            }
            switch (f5.q6.a)
            {
                case 1:
                    p1.energy -=4;
                    p2.energy +=4;
                    break;
                case 2:
                    p1.energy -=3;
                    p2.energy +=3;
                    break;
                case 3:
                    p1.energy -=1;
                    p2.energy +=1;
                    break;
                case 5:
                    p1.energy +=1;
                    p2.energy -=1;
                    break;
                case 6:
                    p1.energy +=2;
                    p2.energy -=2;
                    break;
                case 7:
                    p1.energy +=4;
                    p2.energy -=4;
                    break;
                default:
                    break;
            }
            switch (f6.q5.a)
            {
                case 1:
                    p1.energy +=4;
                    p2.energy -=4;
                    break;
                case 2:
                    p1.energy +=2;
                    p2.energy -=2;
                    break;
                case 3:
                    p1.energy +=1;
                    p2.energy -=1;
                    break;
                case 5:
                    p1.energy -=1;
                    p2.energy +=1;
                    break;
                case 6:
                    p1.energy -=3;
                    p2.energy +=3;
                    break;
                case 7:
                    p1.energy -=4;
                    p2.energy +=4;
                    break;
                default:
                    break;
            }
            switch (f7.q3.a)
            {
                case 1:
                    p1.energy +=4;
                    p2.energy -=4;
                    break;
                case 2:
                    p1.energy +=2;
                    p2.energy -=2;
                    break;
                case 3:
                    p1.energy +=1;
                    p2.energy -=1;
                    break;
                case 5:
                    p1.energy -=1;
                    p2.energy +=1;
                    break;
                case 6:
                    p1.energy -=3;
                    p2.energy +=3;
                    break;
                case 7:
                    p1.energy -=4;
                    p2.energy +=4;
                    break;
                default:
                    break;
            }
            switch (f9.q2.a)
            {
                case 1:
                    p1.energy +=4;
                    p2.energy -=4;
                    break;
                case 2:
                    p1.energy +=2;
                    p2.energy -=2;
                    break;
                case 3:
                    p1.energy +=1;
                    p2.energy -=1;
                    break;
                case 5:
                    p1.energy -=1;
                    p2.energy +=1;
                    break;
                case 6:
                    p1.energy -=3;
                    p2.energy +=3;
                    break;
                case 7:
                    p1.energy -=4;
                    p2.energy +=4;
                    break;
                default:
                    break;
            }
            switch (f9.q3.a)
            {
                case 1:
                    p1.energy -=4;
                    p2.energy +=4;
                    break;
                case 2:
                    p1.energy -=3;
                    p2.energy +=3;
                    break;
                case 3:
                    p1.energy -=1;
                    p2.energy +=1;
                    break;
                case 5:
                    p1.energy +=1;
                    p2.energy -=1;
                    break;
                case 6:
                    p1.energy +=2;
                    p2.energy -=2;
                    break;
                case 7:
                    p1.energy +=4;
                    p2.energy -=4;
                    break;
                default:
                    break;
            }
            switch (f10.q5.a)
            {
                case 1:
                    p1.energy +=4;
                    p2.energy -=4;
                    break;
                case 2:
                    p1.energy +=2;
                    p2.energy -=2;
                    break;
                case 3:
                    p1.energy +=1;
                    p2.energy -=1;
                    break;
                case 5:
                    p1.energy -=1;
                    p2.energy +=1;
                    break;
                case 6:
                    p1.energy -=3;
                    p2.energy +=3;
                    break;
                case 7:
                    p1.energy -=4;
                    p2.energy +=4;
                    break;
                default:
                    break;
            }
        }

        public void Nature()
        {
            switch (f1.q6.a)
            {
                case 1:
                    p1.nature -= 4;
                    p2.nature += 4;
                    break;
                case 2:
                    p1.nature -= 3;
                    p2.nature += 3;
                    break;
                case 3:
                    p1.nature -= 1;
                    p2.nature += 1;
                    break;
                case 5:
                    p1.nature += 1;
                    p2.nature -= 1;
                    break;
                case 6:
                    p1.nature += 2;
                    p2.nature -= 2;
                    break;
                case 7:
                    p1.nature += 4;
                    p2.nature -= 4;
                    break;
                default:
                    break;
            }
            switch (f2.q1.a)
            {
                case 1:
                    p1.nature +=5;
                    p2.nature -=5;
                    break;
                case 2:
                    p1.nature +=4;
                    p2.nature -=4;
                    break;
                case 3:
                    p1.nature +=2;
                    p2.nature -=2;
                    break;
                case 5:
                    p1.nature -=0;
                    p2.nature +=0;
                    t.nature++;
                    break;
                case 6:
                    p1.nature -=2;
                    p2.nature +=2;
                    break;
                case 7:
                    p1.nature -=3;
                    p2.nature +=3;
                    break;
                default:
                    break;
            }
            switch (f2.q4.a)
            {
                case 1:
                    p1.nature -=3;
                    p2.nature +=3;
                    break;
                case 2:
                    p1.nature -=2;
                    p2.nature +=2;
                    break;
                case 3:
                    p1.nature -=0;
                    p2.nature +=0;
                    t.nature++;
                    break;
                case 5:
                    p1.nature +=2;
                    p2.nature -=2;
                    break;
                case 6:
                    p1.nature +=4;
                    p2.nature -=4;
                    break;
                case 7:
                    p1.nature +=5;
                    p2.nature -=5;
                    break;
                default:
                    break;
            }
            switch (f3.q5.a)
            {
                case 1:
                    p1.nature +=5;
                    p2.nature -=5;
                    break;
                case 2:
                    p1.nature +=4;
                    p2.nature -=4;
                    break;
                case 3:
                    p1.nature +=2;
                    p2.nature -=2;
                    break;
                case 5:
                    p1.nature -=0;
                    p2.nature +=0;
                    t.nature++;
                    break;
                case 6:
                    p1.nature -=2;
                    p2.nature +=2;
                    break;
                case 7:
                    p1.nature -=3;
                    p2.nature +=3;
                    break;
                default:
                    break;
            }
            switch (f4.q1.a)
            {
                case 1:
                    p1.nature +=5;
                    p2.nature -=5;
                    break;
                case 2:
                    p1.nature +=4;
                    p2.nature -=4;
                    break;
                case 3:
                    p1.nature +=2;
                    p2.nature -=2;
                    break;
                case 5:
                    p1.nature -=0;
                    p2.nature +=0;
                    t.nature++;
                    break;
                case 6:
                    p1.nature -=2;
                    p2.nature +=2;
                    break;
                case 7:
                    p1.nature -=3;
                    p2.nature +=3;
                    break;
                default:
                    break;
            }
            switch (f4.q2.a)
            {
                case 1:
                    p1.nature =5;
                    p2.nature =5;
                    break;
                case 2:
                    p1.nature =4;
                    p2.nature =4;
                    break;
                case 3:
                    p1.nature =2;
                    p2.nature =2;
                    break;
                case 5:
                    p1.nature =0;
                    p2.nature =0;
                    t.nature++;
                    break;
                case 6:
                    p1.nature =2;
                    p2.nature =2;
                    break;
                case 7:
                    p1.nature =3;
                    p2.nature =3;
                    break;
                default:
                    break;
            }
            switch (f5.q4.a)
            {
                case 1:
                    p1.nature -=3;
                    p2.nature +=3;
                    break;
                case 2:
                    p1.nature -=2;
                    p2.nature +=2;
                    break;
                case 3:
                    p1.nature -=0;
                    p2.nature +=0;
                    t.nature++;
                    break;
                case 5:
                    p1.nature +=2;
                    p2.nature -=2;
                    break;
                case 6:
                    p1.nature +=4;
                    p2.nature -=4;
                    break;
                case 7:
                    p1.nature +=5;
                    p2.nature -=5;
                    break;
                default:
                    break;
            }
            switch (f7.q2.a)
            {
                case 1:
                    p1.nature -=3;
                    p2.nature +=3;
                    break;
                case 2:
                    p1.nature -=2;
                    p2.nature +=2;
                    break;
                case 3:
                    p1.nature -=0;
                    p2.nature +=0;
                    t.nature++;
                    break;
                case 5:
                    p1.nature +=2;
                    p2.nature -=2;
                    break;
                case 6:
                    p1.nature +=4;
                    p2.nature -=4;
                    break;
                case 7:
                    p1.nature +=5;
                    p2.nature -=5;
                    break;
                default:
                    break;
            }
            switch (f7.q4.a)
            {
                case 1:
                    p1.nature +=5;
                    p2.nature -=5;
                    break;
                case 2:
                    p1.nature +=4;
                    p2.nature -=4;
                    break;
                case 3:
                    p1.nature +=2;
                    p2.nature -=2;
                    break;
                case 5:
                    p1.nature -=0;
                    p2.nature +=0;
                    t.nature++;
                    break;
                case 6:
                    p1.nature -=2;
                    p2.nature +=2;
                    break;
                case 7:
                    p1.nature -=3;
                    p2.nature +=3;
                    break;
                default:
                    break;
            }
            switch (f7.q6.a)
            {
                case 1:
                    p1.nature -=3;
                    p2.nature +=3;
                    break;
                case 2:
                    p1.nature -=2;
                    p2.nature +=2;
                    break;
                case 3:
                    p1.nature -=0;
                    p2.nature +=0;
                    t.nature++;
                    break;
                case 5:
                    p1.nature +=2;
                    p2.nature -=2;
                    break;
                case 6:
                    p1.nature +=4;
                    p2.nature -=4;
                    break;
                case 7:
                    p1.nature +=5;
                    p2.nature -=5;
                    break;
                default:
                    break;
            }
            switch (f8.q3.a)
            {
                case 1:
                    p1.nature +=5;
                    p2.nature -=5;
                    break;
                case 2:
                    p1.nature +=4;
                    p2.nature -=4;
                    break;
                case 3:
                    p1.nature +=2;
                    p2.nature -=2;
                    break;
                case 5:
                    p1.nature -=0;
                    p2.nature +=0;
                    t.nature++;
                    break;
                case 6:
                    p1.nature -=2;
                    p2.nature +=2;
                    break;
                case 7:
                    p1.nature -=3;
                    p2.nature +=3;
                    break;
                default:
                    break;
            }
            switch (f8.q4.a)
            {
                case 1:
                    p1.nature -=3;
                    p2.nature +=3;
                    break;
                case 2:
                    p1.nature -=2;
                    p2.nature +=2;
                    break;
                case 3:
                    p1.nature -=0;
                    p2.nature +=0;
                    t.nature++;
                    break;
                case 5:
                    p1.nature +=2;
                    p2.nature -=2;
                    break;
                case 6:
                    p1.nature +=4;
                    p2.nature -=4;
                    break;
                case 7:
                    p1.nature +=5;
                    p2.nature -=5;
                    break;
                default:
                    break;
            }
            switch (f10.q4.a)
            {
                case 1:
                    p1.nature -=3;
                    p2.nature +=3;
                    break;
                case 2:
                    p1.nature -=2;
                    p2.nature +=2;
                    break;
                case 3:
                    p1.nature -=0;
                    p2.nature +=0;
                    t.nature++;
                    break;
                case 5:
                    p1.nature +=2;
                    p2.nature -=2;
                    break;
                case 6:
                    p1.nature +=4;
                    p2.nature -=4;
                    break;
                case 7:
                    p1.nature +=5;
                    p2.nature -=5;
                    break;
                default:
                    break;
            }
        }

        public void Tactics()
        {
            switch (f1.q3.a)
            {
                case 1:
                    p1.tactics += 5;
                    p2.tactics -= 5;
                    break;
                case 2:
                    p1.tactics += 4;
                    p2.tactics -= 4;
                    break;
                case 3:
                    p1.tactics += 2;
                    p2.tactics -= 2;
                    break;
                case 5:
                    p1.tactics += 0;
                    p2.tactics -= 0;
                    t.tactics++;
                    break;
                case 6:
                    p1.tactics -= 2;
                    p2.tactics += 2;
                    break;
                case 7:
                    p1.tactics -= 3;
                    p2.tactics += 3;
                    break;
                default:
                    break;
            }
            switch (f2.q2.a)
            {
                case 1:
                    p1.tactics +=5;
                    p2.tactics -=5;
                    break;
                case 2:
                    p1.tactics +=4;
                    p2.tactics -=4;
                    break;
                case 3:
                    p1.tactics +=2;
                    p2.tactics -=2;
                    break;
                case 5:
                    p1.tactics -=0;
                    p2.tactics +=0;
                    t.tactics++;
                    break;
                case 6:
                    p1.tactics -=2;
                    p2.tactics +=2;
                    break;
                case 7:
                    p1.tactics -=3;
                    p2.tactics +=3;
                    break;
                default:
                    break;
            }
            switch (f2.q6.a)
            {
                case 1:
                    p1.tactics +=5;
                    p2.tactics -=5;
                    break;
                case 2:
                    p1.tactics +=4;
                    p2.tactics -=4;
                    break;
                case 3:
                    p1.tactics +=2;
                    p2.tactics -=2;
                    break;
                case 5:
                    p1.tactics -=0;
                    p2.tactics +=0;
                    t.tactics++;
                    break;
                case 6:
                    p1.tactics -=2;
                    p2.tactics +=2;
                    break;
                case 7:
                    p1.tactics -=3;
                    p2.tactics +=3;
                    break;
                default:
                    break;
            }
            switch (f3.q4.a)
            {
                case 1:
                    p1.tactics +=5;
                    p2.tactics -=5;
                    break;
                case 2:
                    p1.tactics +=4;
                    p2.tactics -=4;
                    break;
                case 3:
                    p1.tactics +=2;
                    p2.tactics -=2;
                    break;
                case 5:
                    p1.tactics -=0;
                    p2.tactics +=0;
                    t.tactics++;
                    break;
                case 6:
                    p1.tactics -=2;
                    p2.tactics +=2;
                    break;
                case 7:
                    p1.tactics -=5;
                    p2.tactics +=5;
                    break;
                default:
                    break;
            }
            switch (f4.q3.a)
            {
                case 1:
                    p1.tactics -=3;
                    p2.tactics +=3;
                    break;
                case 2:
                    p1.tactics -=2;
                    p2.tactics +=2;
                    break;
                case 3:
                    p1.tactics -=0;
                    p2.tactics +=0;
                    t.tactics++;
                    break;
                case 5:
                    p1.tactics +=2;
                    p2.tactics -=2;
                    break;
                case 6:
                    p1.tactics +=4;
                    p2.tactics -=4;
                    break;
                case 7:
                    p1.tactics +=5;
                    p2.tactics -=5;
                    break;
                default:
                    break;
            }
            switch (f4.q6.a)
            {
                case 1:
                    p1.tactics +=5;
                    p2.tactics -=5;
                    break;
                case 2:
                    p1.tactics +=4;
                    p2.tactics -=4;
                    break;
                case 3:
                    p1.tactics +=2;
                    p2.tactics -=2;
                    break;
                case 5:
                    p1.tactics -=0;
                    p2.tactics +=0;
                    t.tactics++;
                    break;
                case 6:
                    p1.tactics -=2;
                    p2.tactics +=2;
                    break;
                case 7:
                    p1.tactics -=3;
                    p2.tactics +=3;
                    break;
                default:
                    break;
            }
            switch (f6.q2.a)
            {
                case 1:
                    p1.tactics -=3;
                    p2.tactics +=3;
                    break;
                case 2:
                    p1.tactics -=2;
                    p2.tactics +=2;
                    break;
                case 3:
                    p1.tactics -=0;
                    p2.tactics +=0;
                    t.tactics++;
                    break;
                case 5:
                    p1.tactics +=2;
                    p2.tactics -=2;
                    break;
                case 6:
                    p1.tactics +=4;
                    p2.tactics -=4;
                    break;
                case 7:
                    p1.tactics +=5;
                    p2.tactics -=5;
                    break;
                default:
                    break;
            }
            switch (f6.q6.a)
            {
                case 1:
                    p1.tactics -=3;
                    p2.tactics +=3;
                    break;
                case 2:
                    p1.tactics -=2;
                    p2.tactics +=2;
                    break;
                case 3:
                    p1.tactics -=0;
                    p2.tactics +=0;
                    t.tactics++;
                    break;
                case 5:
                    p1.tactics +=2;
                    p2.tactics -=2;
                    break;
                case 6:
                    p1.tactics +=4;
                    p2.tactics -=4;
                    break;
                case 7:
                    p1.tactics +=5;
                    p2.tactics -=5;
                    break;
                default:
                    break;
            }
            switch (f7.q5.a)
            {
                case 1:
                    p1.tactics -=3;
                    p2.tactics +=3;
                    break;
                case 2:
                    p1.tactics -=2;
                    p2.tactics +=2;
                    break;
                case 3:
                    p1.tactics -=0;
                    p2.tactics +=0;
                    t.tactics++;
                    break;
                case 5:
                    p1.tactics +=2;
                    p2.tactics -=2;
                    break;
                case 6:
                    p1.tactics +=4;
                    p2.tactics -=4;
                    break;
                case 7:
                    p1.tactics +=5;
                    p2.tactics -=5;
                    break;
                default:
                    break;
            }
            switch (f8.q2.a)
            {
                case 1:
                    p1.tactics +=5;
                    p2.tactics -=5;
                    break;
                case 2:
                    p1.tactics +=4;
                    p2.tactics -=4;
                    break;
                case 3:
                    p1.tactics +=2;
                    p2.tactics -=2;
                    break;
                case 5:
                    p1.tactics -=0;
                    p2.tactics +=0;
                    t.tactics++;
                    break;
                case 6:
                    p1.tactics -=2;
                    p2.tactics +=2;
                    break;
                case 7:
                    p1.tactics -=3;
                    p2.tactics +=3;
                    break;
                default:
                    break;
            }
            switch (f8.q6.a)
            {
                case 1:
                    p1.tactics -=3;
                    p2.tactics +=3;
                    break;
                case 2:
                    p1.tactics -=2;
                    p2.tactics +=2;
                    break;
                case 3:
                    p1.tactics -=0;
                    p2.tactics +=0;
                    t.tactics++;
                    break;
                case 5:
                    p1.tactics +=2;
                    p2.tactics -=2;
                    break;
                case 6:
                    p1.tactics +=4;
                    p2.tactics -=4;
                    break;
                case 7:
                    p1.tactics +=5;
                    p2.tactics -=5;
                    break;
                default:
                    break;
            }
            switch (f10.q2.a)
            {
                case 1:
                    p1.tactics -=3;
                    p2.tactics +=3;
                    break;
                case 2:
                    p1.tactics -=2;
                    p2.tactics +=2;
                    break;
                case 3:
                    p1.tactics -=0;
                    p2.tactics +=0;
                    t.tactics++;
                    break;
                case 5:
                    p1.tactics +=2;
                    p2.tactics -=2;
                    break;
                case 6:
                    p1.tactics +=4;
                    p2.tactics -=4;
                    break;
                case 7:
                    p1.tactics +=5;
                    p2.tactics -=5;
                    break;
                default:
                    break;
            }
        }

        public void Identify()
        {
            switch (f1.q4.a)
            {
                case 1:
                    p1.identify += 5;
                    p2.identify -= 5;
                    break;
                case 2:
                    p1.identify += 4;
                    p2.identify -= 4;
                    break;
                case 3:
                    p1.identify += 2;
                    p2.identify -= 2;
                    break;
                case 5:
                    p1.identify += 0;
                    p2.identify -= 0;
                    t.identify++;
                    break;
                case 6:
                    p1.identify -= 2;
                    p2.identify += 2;
                    break;
                case 7:
                    p1.identify -= 3;
                    p2.identify += 3;
                    break;
                default:
                    break;
            }
            switch (f2.q5.a)
            {
                case 1:
                    p1.identify -=3;
                    p2.identify +=3;
                    break;
                case 2:
                    p1.identify -=2;
                    p2.identify +=2;
                    break;
                case 3:
                    p1.identify -=0;
                    p2.identify +=0;
                    t.identify++;
                    break;
                case 5:
                    p1.identify +=2;
                    p2.identify -=2;
                    break;
                case 6:
                    p1.identify +=4;
                    p2.identify -=4;
                    break;
                case 7:
                    p1.identify +=5;
                    p2.identify -=5;
                    break;
                default:
                    break;
            }
            switch (f3.q3.a)
            {
                case 1:
                    p1.identify +=5;
                    p2.identify -=5;
                    break;
                case 2:
                    p1.identify +=4;
                    p2.identify -=4;
                    break;
                case 3:
                    p1.identify +=2;
                    p2.identify -=2;
                    break;
                case 5:
                    p1.identify -=0;
                    p2.identify +=0;
                    t.identify++;
                    break;
                case 6:
                    p1.identify -=2;
                    p2.identify +=2;
                    break;
                case 7:
                    p1.identify -=3;
                    p2.identify +=3;
                    break;
                default:
                    break;
            }
            switch (f3.q6.a)
            {
                case 1:
                    p1.identify -=3;
                    p2.identify +=3;
                    break;
                case 2:
                    p1.identify -=2;
                    p2.identify +=2;
                    break;
                case 3:
                    p1.identify -=0;
                    p2.identify +=0;
                    t.identify++;
                    break;
                case 5:
                    p1.identify +=2;
                    p2.identify -=2;
                    break;
                case 6:
                    p1.identify +=4;
                    p2.identify -=4;
                    break;
                case 7:
                    p1.identify +=5;
                    p2.identify -=5;
                    break;
                default:
                    break;
            }
            switch (f4.q4.a)
            {
                case 1:
                    p1.identify -=3;
                    p2.identify +=3;
                    break;
                case 2:
                    p1.identify -=2;
                    p2.identify +=2;
                    break;
                case 3:
                    p1.identify -=0;
                    p2.identify +=0;
                    t.identify++;
                    break;
                case 5:
                    p1.identify +=2;
                    p2.identify -=2;
                    break;
                case 6:
                    p1.identify +=4;
                    p2.identify -=4;
                    break;
                case 7:
                    p1.identify +=5;
                    p2.identify -=5;
                    break;
                default:
                    break;
            }
            switch (f5.q3.a)
            {
                case 1:
                    p1.identify -=3;
                    p2.identify +=3;
                    break;
                case 2:
                    p1.identify -=2;
                    p2.identify +=2;
                    break;
                case 3:
                    p1.identify -=0;
                    p2.identify +=0;
                    t.identify++;
                    break;
                case 5:
                    p1.identify +=2;
                    p2.identify -=2;
                    break;
                case 6:
                    p1.identify +=4;
                    p2.identify -=4;
                    break;
                case 7:
                    p1.identify +=5;
                    p2.identify -=5;
                    break;
                default:
                    break;
            }
            switch (f5.q5.a)
            {
                case 1:
                    p1.identify +=5;
                    p2.identify -=5;
                    break;
                case 2:
                    p1.identify +=4;
                    p2.identify -=4;
                    break;
                case 3:
                    p1.identify +=2;
                    p2.identify -=2;
                    break;
                case 5:
                    p1.identify -=0;
                    p2.identify +=0;
                    t.identify++;
                    break;
                case 6:
                    p1.identify -=2;
                    p2.identify +=2;
                    break;
                case 7:
                    p1.identify -=4;
                    p2.identify +=4;
                    break;
                default:
                    break;
            }
            switch (f6.q3.a)
            {
                case 1:
                    p1.identify -=3;
                    p2.identify +=3;
                    break;
                case 2:
                    p1.identify -=2;
                    p2.identify +=2;
                    break;
                case 3:
                    p1.identify -=0;
                    p2.identify +=0;
                    t.identify++;
                    break;
                case 5:
                    p1.identify +=2;
                    p2.identify -=2;
                    break;
                case 6:
                    p1.identify +=4;
                    p2.identify -=4;
                    break;
                case 7:
                    p1.identify +=5;
                    p2.identify -=5;
                    break;
                default:
                    break;
            }
            switch (f8.q1.a)
            {
                case 1:
                    p1.identify +=5;
                    p2.identify -=5;
                    break;
                case 2:
                    p1.identify +=4;
                    p2.identify -=4;
                    break;
                case 3:
                    p1.identify +=2;
                    p2.identify -=2;
                    break;
                case 5:
                    p1.identify -=0;
                    p2.identify +=0;
                    t.identify++;
                    break;
                case 6:
                    p1.identify -=2;
                    p2.identify +=2;
                    break;
                case 7:
                    p1.identify -=3;
                    p2.identify +=3;
                    break;
                default:
                    break;
            }
            switch (f9.q1.a)
            {
                case 1:
                    p1.identify +=5;
                    p2.identify -=5;
                    break;
                case 2:
                    p1.identify +=4;
                    p2.identify -=4;
                    break;
                case 3:
                    p1.identify +=2;
                    p2.identify -=2;
                    break;
                case 5:
                    p1.identify -=0;
                    p2.identify +=0;
                    t.identify++;
                    break;
                case 6:
                    p1.identify -=2;
                    p2.identify +=2;
                    break;
                case 7:
                    p1.identify -=3;
                    p2.identify +=3;
                    break;
                default:
                    break;
            }
            switch (f9.q6.a)
            {
                case 1:
                    p1.identify -=3;
                    p2.identify +=3;
                    break;
                case 2:
                    p1.identify -=2;
                    p2.identify +=2;
                    break;
                case 3:
                    p1.identify -=0;
                    p2.identify +=0;
                    t.identify++;
                    break;
                case 5:
                    p1.identify +=2;
                    p2.identify -=2;
                    break;
                case 6:
                    p1.identify +=4;
                    p2.identify -=4;
                    break;
                case 7:
                    p1.identify +=5;
                    p2.identify -=5;
                    break;
                default:
                    break;
            }
            switch (f10.q3.a)
            {
                case 1:
                    p1.identify -=3;
                    p2.identify +=3;
                    break;
                case 2:
                    p1.identify -=2;
                    p2.identify +=2;
                    break;
                case 3:
                    p1.identify -=0;
                    p2.identify +=0;
                    t.identify++;
                    break;
                case 5:
                    p1.identify +=2;
                    p2.identify -=2;
                    break;
                case 6:
                    p1.identify +=4;
                    p2.identify -=4;
                    break;
                case 7:
                    p1.identify +=5;
                    p2.identify -=5;
                    break;
                default:
                    break;
            }
        }
#pragma warning restore CS1690 // Accessing a member on a field of a marshal-by-reference class may cause a runtime exception

        public void Main()
        {
            p1.mind = 49;
            p2.mind = 51;
            p1.energy = 45;
            p2.energy = 55;
            p1.nature = 49;
            p2.nature = 51;
            p1.tactics = 49;
            p2.tactics = 51;
            p1.identify = 49;
            p2.identify = 51;
            t.mind = 0;
            t.energy = 0;
            t.nature = 0;
            t.tactics = 0;
            t.identify = 0;
            Mind();
            if(t.mind!=0)
            {
                while(t.mind!=1)
                {
                    for (i = t.mind; i > 0; i--) 
                    {
                        p1.mind -= t.mind;
                        p2.mind += t.mind;
                    }
                    t.mind--;
                }
            }
            Energy();
            if (t.energy != 0)
            {
                while (t.energy != 1)
                {
                    for (i = t.energy; i > 0; i--)
                    {
                        p1.energy -= t.energy;
                        p2.energy += t.energy;
                    }
                    t.energy--;
                }
            }
            Nature();
            if (t.nature != 0)
            {
                while (t.nature != 1)
                {
                    for (i = t.nature; i > 0; i--)
                    {
                        p1.nature -= t.nature;
                        p2.nature += t.nature;
                    }
                    t.nature--;
                }
            }
            Tactics();
            if (t.tactics != 0)
            {
                while (t.tactics != 1)
                {
                    for (i = t.tactics; i > 0; i--)
                    {
                        p1.tactics -= t.mind;
                        p2.tactics += t.tactics;
                    }
                    t.tactics--;
                }
            }
            Identify();
            if (t.identify != 0)
            {
                while (t.identify != 1)
                {
                    for (i = t.identify; i > 0; i--)
                    {
                        p1.identify -= t.identify;
                        p2.identify += t.identify;
                    }
                    t.identify--;
                }
            }
            MessageBox.Show(a1);
            a1 = p1.mind.ToString();
            a2 = p2.mind.ToString();
            b1 = p1.energy.ToString();
            b2 = p2.energy.ToString();
            c1 = p1.nature.ToString();
            c2 = p2.nature.ToString();
            d1 = p1.tactics.ToString();
            d2 = p2.tactics.ToString();
            e1 = p1.identify.ToString();
            e2 = p2.identify.ToString();
        }
    }
}
