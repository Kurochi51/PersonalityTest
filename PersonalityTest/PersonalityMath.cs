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
        public int f1j1, f1j2, f1j3, f1j4, f1j5, f1j6;
        public int f2j1, f2j2, f2j3, f2j4, f2j5, f2j6;
        public int f3j1, f3j2, f3j3, f3j4, f3j5, f3j6;
        public int f4j1, f4j2, f4j3, f4j4, f4j5, f4j6;
        public int f5j1, f5j2, f5j3, f5j4, f5j5, f5j6;
        public int f6j1, f6j2, f6j3, f6j4, f6j5, f6j6;
        public int f7j1, f7j2, f7j3, f7j4, f7j5, f7j6;
        public int f8j1, f8j2, f8j3, f8j4, f8j5, f8j6;
        public int f9j1, f9j2, f9j3, f9j4, f9j5, f9j6;
        public int f10j1, f10j2, f10j3, f10j4, f10j5, f10j6;

        public struct Personality { public int mind; public int energy; public int nature; public int tactics; public int identify; }
        public Personality p1, p2, t;

        public int i;

        public int a1
        {
            get { return p1.mind; }
            set { p1.mind = value; }
        }

        public int a2
        { 
            get { return p2.mind; }
            set { p2.mind = value; }
        }

        public int b1
        {
            get { return p1.energy; }
            set { p1.energy = value; }
        }

        public int b2
        {
            get { return p2.energy; }
            set { p2.energy = value; }
        }

        public int c1
        {
            get { return p1.nature; }
            set { p1.nature = value; }
        }

        public int c2
        {
            get { return p2.nature; }
            set { p2.nature = value; }
        }

        public int d1
        {
            get { return p1.tactics; }
            set { p1.tactics = value; }
        }

        public int d2
        {
            get { return p2.tactics; }
            set { p2.tactics = value; }
        }

        public int e1
        {
            get { return p1.identify; }
            set { p1.identify = value; }
        }

        public int e2
        {
            get { return p2.identify; }
            set { p2.identify = value; }
        }

#pragma warning disable CS1690 // Accessing a member on a field of a marshal-by-reference class may cause a runtime exception

        public void Mind()
        {
            switch (f1j1)
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
            switch (f1j2)
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
            switch (f1j5)
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
            switch (f2j3)
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
            switch (f3j1)
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
            switch (f4j5)
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
            switch (f6j1)
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
            switch (f6j4)
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
            switch (f7j1)
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
            switch (f8j5)
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
            switch (f9j4)
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
            switch (f9j5)
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
            switch (f10j1)
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
            switch (f10j6)
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
            switch (f3j2)
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
            switch (f5j1)
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
            switch (f5j2)
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
            switch (f5j6)
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
            switch (f6j5)
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
            switch (f7j3)
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
            switch (f9j2)
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
            switch (f9j3)
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
            switch (f10j5)
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
            switch (f1j6)
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
            switch (f2j1)
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
            switch (f2j4)
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
            switch (f3j5)
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
            switch (f4j1)
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
            switch (f4j2)
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
            switch (f5j4)
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
            switch (f7j2)
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
            switch (f7j4)
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
            switch (f7j6)
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
            switch (f8j3)
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
            switch (f8j4)
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
            switch (f10j4)
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
            switch (f1j3)
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
            switch (f2j2)
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
            switch (f2j6)
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
            switch (f3j4)
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
            switch (f4j3)
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
            switch (f4j6)
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
            switch (f6j2)
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
            switch (f6j6)
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
            switch (f7j5)
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
            switch (f8j2)
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
            switch (f8j6)
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
            switch (f10j2)
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
            switch (f1j4)
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
            switch (f2j5)
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
            switch (f3j3)
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
            switch (f3j6)
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
            switch (f4j4)
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
            switch (f5j3)
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
            switch (f5j5)
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
            switch (f6j3)
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
            switch (f8j1)
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
            switch (f9j1)
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
            switch (f9j6)
            {
                case '1':
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
            switch (f10j3)
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
        }
    }
}
