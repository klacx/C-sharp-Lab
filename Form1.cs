using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4c_1
{
    public partial class Form1 : Form
    {
        double s101_A = 0, x667_A = 0, d870_A = 0, c489_A = 0, k567_A = 0, amount, totalAmount, totalPrice = 0;
        int discount = 0;
        string choice, text;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            totalAmount = s101_A + x667_A + d870_A + c489_A + k567_A;
            if (totalAmount>15)
            {
                discount = 20;
            }
            else 
            { 
                discount = 0; 
            }
            if (s101_A>0) 
            {
                plist.Items.Add("s101");
                ulist.Items.Add("RM5.00");
                qlist.Items.Add(s101_A.ToString());
                tlist.Items.Add("RM" + (s101_A * 5).ToString());
                totalPrice += (s101_A * 5);
            }
            if (x667_A > 0)
            {
                plist.Items.Add("x667");
                ulist.Items.Add("RM4.50");
                qlist.Items.Add(x667_A.ToString());
                tlist.Items.Add("RM"+(x667_A * 4.50).ToString());
                totalPrice += (x667_A * 5);
            }
            if (d870_A > 0)
            {
                plist.Items.Add("d870");
                ulist.Items.Add("RM2.99");
                qlist.Items.Add(d870_A.ToString());
                tlist.Items.Add("RM" + (d870_A * 2.99).ToString());
                totalPrice += (d870_A * 5);
            }
            if (c489_A > 0)
            {
                plist.Items.Add("c489");
                ulist.Items.Add("RM15.99");
                qlist.Items.Add(c489_A.ToString());
                tlist.Items.Add("RM" + (c489_A * 15.99).ToString());
                totalPrice += (c489_A * 15.99);
            }
            if (k567_A > 0)
            {
                plist.Items.Add("k567");
                ulist.Items.Add("RM59.99");
                qlist.Items.Add(k567_A.ToString());
                tlist.Items.Add("RM" + (k567_A * 59.99).ToString());
                totalPrice += (k567_A * 59.99);

            }

            totalPrice = totalPrice - (totalPrice / 100*discount);
            totalLabel.Text = "RM" + totalPrice.ToString();
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            if (itemList.SelectedIndex == 0)
            {
                amount = int.Parse(textBox1.Text);
                s101_A = s101_A + amount;
            }
            else if (itemList.SelectedIndex == 1)
            {
                amount = int.Parse(textBox1.Text);
                x667_A = x667_A + amount;
            }
            else if (itemList.SelectedIndex == 2)
            {
                amount = int.Parse(textBox1.Text);
                d870_A = d870_A + amount;
            }
            else if (itemList.SelectedIndex == 3)
            {
                amount = int.Parse(textBox1.Text);
                c489_A = c489_A + amount;
            }
            else if (itemList.SelectedIndex == 4)
            {
                amount = int.Parse(textBox1.Text);
                k567_A = k567_A + amount;
            }

            cartList.Items.Clear();

            if (s101_A > 0)
            {
                cartList.Items.Add("WritingPad*" + s101_A.ToString());
            }
            if (x667_A > 0)
            {
                cartList.Items.Add("Envelope*" + x667_A.ToString());
            }
            if (d870_A > 0) 
            {
                cartList.Items.Add("Pen*" + d870_A.ToString());
            }
            if (c489_A > 0) 
            {
                cartList.Items.Add("Stapler*" + c489_A.ToString());
            }
            if (k567_A > 0)
            {
                cartList.Items.Add("Planner*" + k567_A.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cartList.Items[cartList.SelectedIndex].ToString().Contains("WritingPad"))
            {
                s101_A = 0;
            }
            else if (cartList.Items[cartList.SelectedIndex].ToString().Contains("Envelope"))
            {
                x667_A = 0;
            }
            else if (cartList.Items[cartList.SelectedIndex].ToString().Contains("Tape"))
            {
                d870_A = 0;
            }
            else if (cartList.Items[cartList.SelectedIndex].ToString().Contains("Stapler"))
            {
                c489_A = 0;
            }
            else if (cartList.Items[cartList.SelectedIndex].ToString().Contains("Planner"))
            {
                k567_A = 0;
            }

            if (cartList.SelectedIndex == 0)
            {
                cartList.Items.RemoveAt(0);
            }
            else if (cartList.SelectedIndex == 1)
            {
                cartList.Items.RemoveAt(1);
            }
            else if (cartList.SelectedIndex == 2)
            {
                cartList.Items.RemoveAt(2);
            }
            else if (cartList.SelectedIndex == 3)
            {
                cartList.Items.RemoveAt(3);
            }
            else if (cartList.SelectedIndex == 4)
            {
                cartList.Items.RemoveAt(4);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            }
        }
    }

