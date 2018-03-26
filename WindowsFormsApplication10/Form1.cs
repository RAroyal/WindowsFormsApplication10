using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[25];
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(150, 380);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //1
            Random ran = new Random();// 2
            for (int i = 0; i < 25; i++)// 3
            {
                Mas[i] = ran.Next(-5, 5);//4
                listBox1.Items.Add("Mas[" + (i + 1).ToString() +//5
                "] = " + Mas[i].ToString());//6
            }
            this.Size = new Size(300, 550);//7
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear(); //1
            for (int i = 0; i < 25; i++) //2
            {
                if (Mas[i] == 0)//3
                { Mas[i] = 0; }//4
                else//5
                {
                    if (Mas[i] < 0)//6
                        Mas[i] = Mas[i] * Mas[i];//7
                    else//8
                        Mas[i] = Mas[i] + 7;//9
                }

                listBox2.Items.Add("Mas[" + Convert.ToString(i + 1) +//10
                    "] = " + Mas[i].ToString());//11
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DodgerBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.GreenYellow;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkViolet;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label2.Left < this.Width)
            { label2.Left += 2; }
            else
            { label2.Left = -label2.Width; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        button10.Visible = true;
        label2.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button10.Visible = false;
            label2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            label2.Location = new Point(0,ran.Next(0,500));
        }
    }
}

