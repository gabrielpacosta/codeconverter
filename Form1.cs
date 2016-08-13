using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        string[] hex;
        List<String> bin = new List<String>();
        List<String> resultado = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbOutput.Text = "";
            textBox1.Text = "";

            int j = 0;
            hex = txbInput.Text.Split(' ');
            for (int i = 0; i < hex.Length; i=i+2)
            {
                int num = Convert.ToInt32(hex[i], 16) - 14;
                if (num > 13)
                {
                    bin.Add("1");
                }
                else
                {
                    bin.Add("0");
                }
                j++;
            }

            int k = 1;
            foreach (string b in bin)
            {
                if (k % 5 == 0)
                {
                    txbOutput.Text += " ";
                    k++;
                }
                txbOutput.Text += b;
                k++;
            }

            string[] result = txbOutput.Text.Split(' ');
            resultado = result.OfType<string>().ToList();

            foreach (string r in resultado)
            {
                textBox1.Text += Convert.ToInt32(r, 2).ToString("X");
            }

        }

        private void txbInput_TextChanged(object sender, EventArgs e)
        {
            int num = (txbInput.TextLength+1) / 5;
            label1.Text = "Número de códigos hex: " + (num + 1);
            label2.Text = "Tamanho do binário: " + ((num/2) + 1);

            if (num == 63)
            {
                System.Media.SystemSounds.Beep.Play();
                label1.Font = new Font(label1.Font, FontStyle.Underline);
                label2.Font = new Font(label2.Font, FontStyle.Underline);
            }
            else
            {
                label1.Font = new Font(label1.Font, FontStyle.Regular);
                label2.Font = new Font(label2.Font, FontStyle.Regular);
            }
        }
    }
}
