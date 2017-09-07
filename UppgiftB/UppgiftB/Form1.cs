using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UppgiftB
{
    public partial class Form1 : Form
    {
        ArrayList kunder = new ArrayList();
        ArrayList bas = new ArrayList();
        ArrayList temp = new ArrayList();

        int min = 200;
        Customer kund;

        public Form1()
        {
            InitializeComponent();

            label1.Text = "Förnamn";
            label2.Text = "Efternamn";
            label3.Text = "Telefonnummer";
            label4.Text = "Stad";
            label5.Text = "Välj sorteringssätt";

            button1.Text = "Spara";
            button2.Text = "Förnamn";
            button3.Text = "Efternamn";
            button4.Text = "Stad";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kunder.Add(new Customer() { Fnamn = textBox1.Text,
                                        Enamn = textBox2.Text,
                                        Tel = int.Parse(textBox3.Text),
                                        Stad = textBox4.Text});
            bas.Add(new Customer() { Fnamn = textBox1.Text,
                                     Enamn = textBox2.Text,
                                     Tel = int.Parse(textBox3.Text),
                                     Stad = textBox4.Text});
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int length = bas.Count;
            for (int i = 0; i < length; i++)
            {
                foreach (Customer c in kunder)
                {
                    if (Convert.ToInt32(c.Fnamn[0]) < min)
                    {
                        min = Convert.ToInt32(c.Fnamn[0]);
                        kund = c;
                    }
                }
                min = 200;
                temp.Add(new Customer());
                temp[i] = kund;
                kunder.Remove(kund);
            }
            foreach (Customer c in temp)
            {
                listBox1.Items.Add(c.Fnamn+" "+c.Enamn+" "+c.Tel+" "+c.Stad);
            }
            for (int i = 0; i < temp.Count-1; i++)
            {
                kunder.Add(new Customer());
                kunder[i] = bas[i];
                temp.Remove(temp[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int length = bas.Count;
            for (int i = 0; i < length; i++)
            {
                foreach (Customer c in kunder)
                {
                    if (Convert.ToInt32(c.Enamn[0]) < min)
                    {
                        min = Convert.ToInt32(c.Enamn[0]);
                        kund = c;
                    }
                }
                min = 200;
                temp.Add(new Customer());
                temp[i] = kund;
                kunder.Remove(kund);
            }
            foreach (Customer c in temp)
            {
                listBox1.Items.Add(c.Fnamn + " " + c.Enamn + " " + c.Tel + " " + c.Stad);
            }
            for (int i = 0; i < temp.Count-1; i++)
            {
                kunder.Add(new Customer());
                kunder[i] = bas[i];
                temp.Remove(temp[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int length = bas.Count;
            for (int i = 0; i < length; i++)
            {
                foreach (Customer c in kunder)
                {
                    if (Convert.ToInt32(c.Stad[0]) < min)
                    {
                        min = Convert.ToInt32(c.Stad[0]);
                        kund = c;
                    }
                }
                min = 200;
                temp.Add(new Customer());
                temp[i] = kund;
                kunder.Remove(kund);
            }
            foreach (Customer c in temp)
            {
                listBox1.Items.Add(c.Fnamn + " " + c.Enamn + " " + c.Tel + " " + c.Stad);
            }
            for (int i = 0; i < temp.Count-1; i++)
            {
                kunder.Add(new Customer());
                kunder[i] = bas[i];
                temp.Remove(temp[i]);
            }
        }
    }
}
