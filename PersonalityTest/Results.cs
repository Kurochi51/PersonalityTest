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
using System.Diagnostics;

namespace PersonalityTest
{
    public partial class Results : Form
    {
        public bool a, b, c, d, e5;
        string url;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Architect
            if(ptt.Text== "INTJ-T" || ptt.Text=="INTJ-A")
            {
                url = "https://www.16personalities.com/intj-personality";
            }
            //Logician
            else if (ptt.Text == "INTP-T" || ptt.Text == "INTP-A")
            {
                url = "https://www.16personalities.com/intp-personality";
            }
            //Commander
            else if (ptt.Text == "ENTJ-T" || ptt.Text == "ENTJ-A")
            {
                url = "https://www.16personalities.com/entj-personality";
            }
            //Debater
            else if (ptt.Text == "ENTP-T" || ptt.Text == "ENTP-A")
            {
                url = "https://www.16personalities.com/entp-personality";
            }
            //Advocate
            else if (ptt.Text == "INFJ-T" || ptt.Text == "INFJ-A")
            {
                url = "https://www.16personalities.com/infj-personality";
            }
            //Mediator
            else if (ptt.Text == "INFP-T" || ptt.Text == "INFP-A")
            {
                url = "https://www.16personalities.com/infp-personality";
            }
            //Protagonist
            else if (ptt.Text == "ENFJ-T" || ptt.Text == "ENFJ-A")
            {
                url = "https://www.16personalities.com/enfj-personality";
            }
            //Campaigner
            else if (ptt.Text == "ENFP-T" || ptt.Text == "ENFP-A")
            {
                url = "https://www.16personalities.com/enfp-personality";
            }
            //Logistician
            else if (ptt.Text == "ISTJ-T" || ptt.Text == "ISTJ-A")
            {
                url = "https://www.16personalities.com/istj-personality";
            }
            //Defender
            else if (ptt.Text == "ISFJ-T" || ptt.Text == "ISFJ-A")
            {
                url = "https://www.16personalities.com/isfj-personality";
            }
            //Executive
            else if (ptt.Text == "ESTJ-T" || ptt.Text == "ESTJ-A")
            {
                url = "https://www.16personalities.com/estj-personality";
            }
            //Consul
            else if (ptt.Text == "ESFJ-T" || ptt.Text == "ESFJ-A")
            {
                url = "https://www.16personalities.com/esfj-personality";
            }
            //Virtuso
            else if (ptt.Text == "ISTP-T" || ptt.Text == "ISTP-A")
            {
                url = "https://www.16personalities.com/istp-personality";
            }
            //Adventurer
            else if (ptt.Text == "ISFP-T" || ptt.Text == "ISFP-A")
            {
                url = "https://www.16personalities.com/isfp-personality";
            }
            //Entrepreneur
            else if (ptt.Text == "ESTP-T" || ptt.Text == "ESTP-A")
            {
                url = "https://www.16personalities.com/estp-personality";
            }
            else if (ptt.Text == "ESFP-T" || ptt.Text == "ESFP-A")
            {
                url = "https://www.16personalities.com/esfp-personality";
            }
            Process.Start(url);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i3 == 0)
            {
                Text = "Test de personalitate";
                button2.Text = "English";
                label1.Text = "Tipul tău de personalitate este:";
                label8.Hide();
                label7.Hide();
                label18.Hide();
                label25.Hide();
                label32.Hide();
                label2.Text = "Extravertit";
                label3.Text = "Introvertit";
                label5.Text = "Intuitiv";
                label4.Text = "Realist";
                label16.Text = "Centrat pe Logică";
                label15.Text = "Centrat pe Principii";
                label23.Text = "Organizator";
                label22.Text = "Căutător";
                label30.Text = "Asertiv";
                label29.Text = "Precaut";
                label13.Text = "Mental";
                label14.Text = "Energie";
                label21.Text = "Natură";
                label28.Text = "Tactici";
                label35.Text = "Identitate";
                if (a)//E---  or I--- 
                {
                    if (b)//-N--  or -S-- 
                    {
                        if (c)//--T-  or --F- 
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Aventurier";
                                    ptt.Text = "ISFP-T";
                                    
                                }
                                else
                                {
                                    pt.Text = "Aventurier";
                                    ptt.Text = "ISFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Apărător";
                                    ptt.Text = "ISFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Apărător";
                                    ptt.Text = "ISFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Virtuos";
                                    ptt.Text = "ISTP-T";
                                }
                                else
                                {
                                    pt.Text = "Virtuos";
                                    ptt.Text = "ISTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Logistician";
                                    ptt.Text = "ISTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Logistician";
                                    ptt.Text = "ISTJ-A";
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
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Mediator";
                                    ptt.Text = "INFP-T";
                                }
                                else
                                {
                                    pt.Text = "Mediator";
                                    ptt.Text = "INFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Susținător";
                                    ptt.Text = "INFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Susținător";
                                    ptt.Text = "INFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Logic";
                                    ptt.Text = "INTP-T";
                                }
                                else
                                {
                                    pt.Text = "Logic";
                                    ptt.Text = "INTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Arhitect";
                                    ptt.Text = "INTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Arhitect";
                                    ptt.Text = "INTJ-A";
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
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Animator";
                                    ptt.Text = "ESFP-T";
                                }
                                else
                                {
                                    pt.Text = "Animator";
                                    ptt.Text = "ESFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Consul";
                                    ptt.Text = "ESFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Consul";
                                    ptt.Text = "ESFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Antreprenor";
                                    ptt.Text = "ESTP-T";
                                }
                                else
                                {
                                    pt.Text = "Antreprenor";
                                    ptt.Text = "ESTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Director";
                                    ptt.Text = "ESTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Director";
                                    ptt.Text = "ESTJ-A";
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
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Activist";
                                    ptt.Text = "ENFP-T";
                                }
                                else
                                {
                                    pt.Text = "Activist";
                                    ptt.Text = "ENFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Protagonist";
                                    ptt.Text = "ENFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Protagonist";
                                    ptt.Text = "ENFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Polemist";
                                    ptt.Text = "ENTP-T";
                                }
                                else
                                {
                                    pt.Text = "Polemist";
                                    ptt.Text = "ENTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Conducător";
                                    ptt.Text = "ENTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Conducător";
                                    ptt.Text = "ENTJ-A";
                                }
                            }
                        }
                    }
                }
                i3 = 1;
            }
            else
            {
                i3 = 0;
                Text = "Personality Test";
                button2.Text = "Romanian";
                label1.Text = "Personality Type:";
                label8.Show();
                label7.Show();
                label18.Show();
                label25.Show();
                label32.Show();
                label2.Text = "Extraverted";
                label3.Text = "Introverted";
                label5.Text = "Intuitive";
                label4.Text = "Observant";
                label16.Text = "Thinking";
                label15.Text = "Feeling";
                label23.Text = "Judging";
                label22.Text = "Prospecting";
                label30.Text = "Assertive";
                label29.Text = "Turbulent";
                label13.Text = "Mind";
                label14.Text = "Energy";
                label21.Text = "Nature";
                label28.Text = "Tactics";
                label35.Text = "Identity";
                if (a)//E---  or I--- 
                {
                    if (b)//-N--  or -S-- 
                    {
                        if (c)//--T-  or --F- 
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Adventurer";
                                    ptt.Text = "ISFP-T";
                                }
                                else
                                {
                                    pt.Text = "Adventurer";
                                    ptt.Text = "ISFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Defender";
                                    ptt.Text = "ISFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Defender";
                                    ptt.Text = "ISFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Virtuoso";
                                    ptt.Text = "ISTP-T";
                                }
                                else
                                {
                                    pt.Text = "Virtuoso";
                                    ptt.Text = "ISTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Logistician";
                                    ptt.Text = "ISTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Logistician";
                                    ptt.Text = "ISTJ-A";
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
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Mediator";
                                    ptt.Text = "INFP-T";
                                }
                                else
                                {
                                    pt.Text = "Mediator";
                                    ptt.Text = "INFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Advocate";
                                    ptt.Text = "INFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Advocate";
                                    ptt.Text = "INFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Logician";
                                    ptt.Text = "INTP-T";
                                }
                                else
                                {
                                    pt.Text = "Logician";
                                    ptt.Text = "INTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Architect";
                                    ptt.Text = "INTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Architect";
                                    ptt.Text = "INTJ-A";
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
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Entertainer";
                                    ptt.Text = "ESFP-T";
                                }
                                else
                                {
                                    pt.Text = "Entertainer";
                                    ptt.Text = "ESFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Consul";
                                    ptt.Text = "ESFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Consul";
                                    ptt.Text = "ESFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Entrepreneur";
                                    ptt.Text = "ESTP-T";
                                }
                                else
                                {
                                    pt.Text = "Entrepreneur";
                                    ptt.Text = "ESTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Executive";
                                    ptt.Text = "ESTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Executive";
                                    ptt.Text = "ESTJ-A";
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
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Campaigner";
                                    ptt.Text = "ENFP-T";
                                }
                                else
                                {
                                    pt.Text = "Campaigner";
                                    ptt.Text = "ENFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Protagonist";
                                    ptt.Text = "ENFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Protagonist";
                                    ptt.Text = "ENFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Debater";
                                    ptt.Text = "ENTP-T";
                                }
                                else
                                {
                                    pt.Text = "Debater";
                                    ptt.Text = "ENTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Commander";
                                    ptt.Text = "ENTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Commander";
                                    ptt.Text = "ENTJ-A";
                                }
                            }
                        }
                    }
                }
            }
        }

        int i3;

        public Results(int a1, int a2, int b1, int b2, int c1, int c2, int d1, int d2, int e3, int e4, int i)
        {
            i3 = i;
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
                    e5 = false;
                else
                    e5 = true;
            }
            if (i3==1)
            {
                Text = "Test de personalitate";
                button2.Text = "English";
                label1.Text = "Tipul tău de personalitate este:";
                label8.Hide();
                label7.Hide();
                label18.Hide();
                label25.Hide();
                label32.Hide();
                label2.Text = "Extravertit";
                label3.Text = "Introvertit";
                label5.Text = "Intuitiv";
                label4.Text = "Realist";
                label16.Text = "Centrat pe Logică";
                label15.Text = "Centrat pe Principii";
                label23.Text = "Organizator";
                label22.Text = "Căutător";
                label30.Text = "Asertiv";
                label29.Text = "Precaut";
                label13.Text = "Mental";
                label14.Text = "Energie";
                label21.Text = "Natură";
                label28.Text = "Tactici";
                label35.Text = "Identitate";
                if (a)//E---  or I--- 
                {
                    if (b)//-N--  or -S-- 
                    {
                        if (c)//--T-  or --F- 
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Aventurier";
                                    ptt.Text = "ISFP-T";

                                }
                                else
                                {
                                    pt.Text = "Aventurier";
                                    ptt.Text = "ISFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Apărător";
                                    ptt.Text = "ISFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Apărător";
                                    ptt.Text = "ISFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Virtuos";
                                    ptt.Text = "ISTP-T";
                                }
                                else
                                {
                                    pt.Text = "Virtuos";
                                    ptt.Text = "ISTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Logistician";
                                    ptt.Text = "ISTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Logistician";
                                    ptt.Text = "ISTJ-A";
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
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Mediator";
                                    ptt.Text = "INFP-T";
                                }
                                else
                                {
                                    pt.Text = "Mediator";
                                    ptt.Text = "INFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Susținător";
                                    ptt.Text = "INFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Susținător";
                                    ptt.Text = "INFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Logic";
                                    ptt.Text = "INTP-T";
                                }
                                else
                                {
                                    pt.Text = "Logic";
                                    ptt.Text = "INTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Arhitect";
                                    ptt.Text = "INTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Arhitect";
                                    ptt.Text = "INTJ-A";
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
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Animator";
                                    ptt.Text = "ESFP-T";
                                }
                                else
                                {
                                    pt.Text = "Animator";
                                    ptt.Text = "ESFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Consul";
                                    ptt.Text = "ESFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Consul";
                                    ptt.Text = "ESFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Antreprenor";
                                    ptt.Text = "ESTP-T";
                                }
                                else
                                {
                                    pt.Text = "Antreprenor";
                                    ptt.Text = "ESTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Director";
                                    ptt.Text = "ESTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Director";
                                    ptt.Text = "ESTJ-A";
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
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Activist";
                                    ptt.Text = "ENFP-T";
                                }
                                else
                                {
                                    pt.Text = "Activist";
                                    ptt.Text = "ENFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Protagonist";
                                    ptt.Text = "ENFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Protagonist";
                                    ptt.Text = "ENFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Polemist";
                                    ptt.Text = "ENTP-T";
                                }
                                else
                                {
                                    pt.Text = "Polemist";
                                    ptt.Text = "ENTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Conducător";
                                    ptt.Text = "ENTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Conducător";
                                    ptt.Text = "ENTJ-A";
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Text = "Personality Test";
                button2.Text = "Romanian";
                label1.Text = "Personality Type:";
                label8.Show();
                label7.Show();
                label18.Show();
                label25.Show();
                label32.Show();
                label2.Text = "Extraverted";
                label3.Text = "Introverted";
                label5.Text = "Intuitive";
                label4.Text = "Observant";
                label16.Text = "Thinking";
                label15.Text = "Feeling";
                label23.Text = "Judging";
                label22.Text = "Prospecting";
                label30.Text = "Assertive";
                label29.Text = "Turbulent";
                label13.Text = "Mind";
                label14.Text = "Energy";
                label21.Text = "Nature";
                label28.Text = "Tactics";
                label35.Text = "Identity";
                if (a)//E---  or I--- 
                {
                    if (b)//-N--  or -S-- 
                    {
                        if (c)//--T-  or --F- 
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Adventurer";
                                    ptt.Text = "ISFP-T";
                                }
                                else
                                {
                                    pt.Text = "Adventurer";
                                    ptt.Text = "ISFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Defender";
                                    ptt.Text = "ISFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Defender";
                                    ptt.Text = "ISFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Virtuoso";
                                    ptt.Text = "ISTP-T";
                                }
                                else
                                {
                                    pt.Text = "Virtuoso";
                                    ptt.Text = "ISTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Logistician";
                                    ptt.Text = "ISTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Logistician";
                                    ptt.Text = "ISTJ-A";
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
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Mediator";
                                    ptt.Text = "INFP-T";
                                }
                                else
                                {
                                    pt.Text = "Mediator";
                                    ptt.Text = "INFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Advocate";
                                    ptt.Text = "INFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Advocate";
                                    ptt.Text = "INFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Logician";
                                    ptt.Text = "INTP-T";
                                }
                                else
                                {
                                    pt.Text = "Logician";
                                    ptt.Text = "INTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Architect";
                                    ptt.Text = "INTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Architect";
                                    ptt.Text = "INTJ-A";
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
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Entertainer";
                                    ptt.Text = "ESFP-T";
                                }
                                else
                                {
                                    pt.Text = "Entertainer";
                                    ptt.Text = "ESFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Consul";
                                    ptt.Text = "ESFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Consul";
                                    ptt.Text = "ESFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Entrepreneur";
                                    ptt.Text = "ESTP-T";
                                }
                                else
                                {
                                    pt.Text = "Entrepreneur";
                                    ptt.Text = "ESTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Executive";
                                    ptt.Text = "ESTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Executive";
                                    ptt.Text = "ESTJ-A";
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
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Campaigner";
                                    ptt.Text = "ENFP-T";
                                }
                                else
                                {
                                    pt.Text = "Campaigner";
                                    ptt.Text = "ENFP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Protagonist";
                                    ptt.Text = "ENFJ-T";
                                }
                                else
                                {
                                    pt.Text = "Protagonist";
                                    ptt.Text = "ENFJ-A";
                                }
                            }
                        }
                        else
                        {
                            if (d)//---J  or ---P 
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Debater";
                                    ptt.Text = "ENTP-T";
                                }
                                else
                                {
                                    pt.Text = "Debater";
                                    ptt.Text = "ENTP-A";
                                }
                            }
                            else
                            {
                                if (e5)// -T or -A
                                {
                                    pt.Text = "Commander";
                                    ptt.Text = "ENTJ-T";
                                }
                                else
                                {
                                    pt.Text = "Commander";
                                    ptt.Text = "ENTJ-A";
                                }
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
