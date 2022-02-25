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

        static int Parse(string expression)
        {
            return CSharpScript.EvaluateAsync<int>(expression).Result;
        }

        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        static int modInverse(int a, int m)
        {
            for (int x = 1; x < m; x++)
                if (((a % m) * (x % m)) % m == 1)
                    return x;
            return 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int equasion = Convert.ToInt32(Evaluate(textBox1.Text));
            int mod = Convert.ToInt32(textBox2.Text);

            string subjectString = textBox1.Text;

            Regex Inverse = new Regex("(?<=1/)[0-9]+", RegexOptions.IgnoreCase);
            Match matchInverse = Inverse.Match(subjectString);
            //textBox3.Text = Convert.ToString(modInverse(Convert.ToInt32(matchInverse.Groups[0].Value), mod));

            Regex Expression = new Regex("(?<=1/)[0-9]+", RegexOptions.IgnoreCase);
            Match matchExpression = Inverse.Match(subjectString);



            textBox3.Text = Convert.ToString(equasion % mod);

        }
    }
}