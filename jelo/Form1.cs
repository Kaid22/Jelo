using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace jelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("jela.txt");
            while (!f.EndOfStream)
            {
                jela.Add(f.ReadLine());
            }
            for (int i = 1; i < jela.Count; i += 2)
            {
                cene.Add(int.Parse(jela[i]));
            }
        }
        List<string> jela = new List<string>();
        List<int> cene = new List<int>();
        int[] cene1;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();           
            for (int i = 0; i < jela.Count; i+=2)
            {
                textBox1.Text += jela[i] + ": " + jela[i + 1] + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cene1 = cene.ToArray();
            Array.Sort(cene1);
            textBox1.Clear();
            for (int i = 0; i < cene1.Length; i++)
            {
                for (int j = 1; j < jela.Count; j+=2)
                {
                    if (cene1[i] == int.Parse(jela[j]))
                    {
                        textBox1.Text += jela[j-1] + ": " + jela[j] + Environment.NewLine;
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cene1 = cene.ToArray();
            Array.Sort(cene1);
            Array.Reverse(cene1);
            textBox1.Clear();
            for (int i = 0; i < cene1.Length; i++)
            {
                for (int j = 1; j < jela.Count; j += 2)
                {
                    if (cene1[i] == int.Parse(jela[j]))
                    {
                        textBox1.Text += jela[j - 1] + ": " + jela[j] + Environment.NewLine;
                    }
                }

            }
        }
    }
}
