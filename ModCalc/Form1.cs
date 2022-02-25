using System;
using System.Numerics;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp.Scripting;
namespace ModCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double Parse(string expression)
        {
            return CSharpScript.EvaluateAsync<double>(expression).Result;
        }

        int modInverse(int a, int n)
        {
            int i = n, v = 0, d = 1;
            while (a > 0)
            {
                int t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0) 
                v = (v + n) % n;
            return v;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string subjectString = textBox1.Text;

            //Regex regexObj = new Regex("[0-9]+(?=/1)", RegexOptions.IgnoreCase);
            //Match matchResults = regexObj.Match(subjectString);
            //int negative = Convert.ToInt32(matchResults.Value);
            //int x = 0, y = 0;

            int a = 2, n = 3;
            Console.WriteLine(modInverse(a, n));




            //for (int i = 0; i < 1000; i++)
            //{
            //    for (int j = 0; j < 1000; j++)
            //    {

            //        x++;
            //        y++;


            //    }
            //    if ((x * negative + y * mod == 1) || (x * negative - y * mod == 1))
            //        break;
            //}


            //textBox3.Text = Convert.ToString(x);

            //Match newStrign = Regex.Replace()




            //string pattern = "[0-9]+(?:/1)";
            //string q = textBox1.Text;
            //Match m = Regex.Match(q, pattern, RegexOptions.IgnoreCase);

            //textBox3.Text = m.Value;


            //done
            ////int equasion = Convert.ToInt32(Parse(textBox1.Text));
            ////int mod = Convert.ToInt32(textBox2.Text);



            ////textBox3.Text = Convert.ToString(equasion + mod);
            ////int answer = equasion + mod;
            ////textBox3.Text = answer.ToString();
        }
        

    }
    } 