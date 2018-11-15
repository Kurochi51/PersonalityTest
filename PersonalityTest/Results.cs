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
        public bool a, b, c, d, e;
        public Results(int a1, int a2, int b1, int b2, int c1, int c2, int d1, int d2, int e3, int e4)
        {
            InitializeComponent();
            {
                if (a1 > 50)
                    a = false;
                else
                    a = true;
                if (b1 > 50)
                    b = false;
                else
                    b = true;
                if (c1 > 50)
                    c = false;
                else
                    c = true;
                if (d1 > 50)
                    d = false;
                else
                    d = true;
                if (e3 > 50)
                    e = false;
                else
                    e = true;
            }
            if (a)//E---  or I--- 
            {
                if (b)//-N--  or -S-- 
                {
                    if (c)//--T-  or --F- 
                    {
                        if (d)//---J  or ---P 
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Adventurer (ISFP-T)";
                            }
                            else
                            {
                                pt.Text = "Adventurer (ISFP-A)";
                            }
                        }
                        else
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Defender ISFJ-T";
                            }
                            else
                            {
                                pt.Text = "Defender ISFJ-A";
                            }
                        }
                    }
                    else
                    {
                        if (d)//---J  or ---P 
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Virtuoso ISTP-T";
                            }
                            else
                            {
                                pt.Text = "Virtuoso ISTP-A";
                            }
                        }
                        else
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Logistician ISTJ-T";
                            }
                            else
                            {
                                pt.Text = "Logistician ISTJ-A";
                            }
                        }
                    }
                }
                else
                {
                    if (c)//--T-  or --F- 
                    {
                        if (d)//---J  or ---P 
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Mediator INFP-T";
                            }
                            else
                            {
                                pt.Text = "Mediator INFP-A";
                            }
                        }
                        else
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Advocate INFJ-T";
                            }
                            else
                            {
                                pt.Text = "Advocate INFJ-A";
                            }
                        }
                    }
                    else
                    {
                        if (d)//---J  or ---P 
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Logician INTP-T";
                            }
                            else
                            {
                                pt.Text = "Logician INTP-A";
                            }
                        }
                        else
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Architect INTJ-T";
                            }
                            else
                            {
                                pt.Text = "Architect INTJ-A";
                            }
                        }
                    }
                }
            }
            else
            {
                if (b)//-N--  or -S-- 
                {
                    if (c)//--T-  or --F- 
                    {
                        if (d)//---J  or ---P 
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Entertainer ESFP-T";
                            }
                            else
                            {
                                pt.Text = "Entertainer ESFP-A";
                            }
                        }
                        else
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Consul ESFJ-T";
                            }
                            else
                            {
                                pt.Text = "Consul ESFJ-A";
                            }
                        }
                    }
                    else
                    {
                        if (d)//---J  or ---P 
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Entrepreneur ESTP-T";
                            }
                            else
                            {
                                pt.Text = "Entrepreneur ESTP-A";
                            }
                        }
                        else
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Executive ESTJ-T";
                            }
                            else
                            {
                                pt.Text = "Executive ESTJ-A";
                            }
                        }
                    }
                }
                else
                {
                    if (c)//--T-  or --F- 
                    {
                        if (d)//---J  or ---P 
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Campaigner ENFP-T";
                            }
                            else
                            {
                                pt.Text = "Campaigner ENFP-A";
                            }
                        }
                        else
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Protagonist ENFJ-T";
                            }
                            else
                            {
                                pt.Text = "Protagonist ENFJ-A";
                            }
                        }
                    }
                    else
                    {
                        if (d)//---J  or ---P 
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Debater ENTP-T";
                            }
                            else
                            {
                                pt.Text = "Debater ENTP-A";
                            }
                        }
                        else
                        {
                            if (e)// -T or -A
                            {
                                pt.Text = "Commander ENTJ-T";
                            }
                            else
                            {
                                pt.Text = "Commander ENTJ-A";
                            }
                        }
                    }
                }
            }
            m1.Text = a1.ToString();
            m2.Text = a2.ToString();
            e1.Text = b1.ToString();
            e2.Text = b2.ToString();
            n1.Text = c1.ToString();
            n2.Text = c2.ToString();
            t1.Text = d1.ToString();
            t2.Text = d2.ToString();
            i1.Text = e3.ToString();
            i2.Text = e4.ToString();
        }
    }
}
