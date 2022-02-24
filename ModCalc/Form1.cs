using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int mod = Convert.ToInt32(textBox2.Text);
            string subjectString = textBox1.Text;
            
                Regex regexObj = new Regex("[0-9]+(?=/1)", RegexOptions.IgnoreCase);
                Match matchResults = regexObj.Match(subjectString);
                int negative = Convert.ToInt32(matchResults.Value);
            int x=0, y=0;
            do
            {
                x++;
                y++;
            }
            while ((x*negative+y*mod==1)|| (x * negative - y * mod == 1));
            textBox3.Text = Convert.ToString(x);

                //Match newStrign = Regex.Replace()




            //string pattern = "[0-9]+(?:/1)";
            //string q = textBox1.Text;
            //Match m = Regex.Match(q, pattern, RegexOptions.IgnoreCase);

            //textBox3.Text = m.Value;

            //string equasion = Convert.ToString(Parse(textBox1.Text));
            

            //textBox3.Text = equasion + mod;
            //int equation = Convert.ToInt32(textBox1.Text);

            //int answer = equation + mod;
            //textBox3.Text = answer.ToString();
        }
    }
    } 