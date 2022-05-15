using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt.NET
{
    public partial class Form1 : Form
    {

        bool round = true;
        int count = 0;

        public Form1()
        {
            InitializeComponent();

            if (round)
            {
                whosturn.Text = "X Turn";
            }
            else
            {
                whosturn.Text = "O Turn";
            }

        }

        

        private void Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (round)
            {
                a.Text = "X";
            }
            else
            {
                a.Text = "O";
            }
            a.Enabled = false;          
            round = !round;
            count++;
            Checking();
        }

        private void Checking()
        {
            bool winner = false;

            if (round)
            {
                whosturn.Text = "X Turn";
            }
            else
            {
                whosturn.Text = "O Turn";
            }



            if ((X1.Text == X2.Text) && (X2.Text == X3.Text) && (!X1.Enabled))
            {
                winner = true;
            }

            else if ((Y1.Text == Y2.Text) && (Y2.Text == Y3.Text) && (!Y1.Enabled))
            {
                winner = true;
            }
            else if ((Z1.Text == Z2.Text) && (Z2.Text == Z3.Text) && (!Z1.Enabled))
            {
                winner = true;
            }

            else if ((X1.Text == Y1.Text) && (Y1.Text == Z1.Text) && (!X1.Enabled))
            {
                winner = true;
            }

            else if ((X2.Text == Y2.Text) && (Y2.Text == Z2.Text) && (!X2.Enabled))
            {
                winner = true;
            }
            else if ((X3.Text == Y3.Text) && (Y3.Text == Z3.Text) && (!X3.Enabled))
            {
                winner = true;
            }


            else if ((X1.Text == Y2.Text) && (Y2.Text == Z3.Text) && (!X1.Enabled))
            {
                winner = true;
            }

            else if ((X3.Text == Y2.Text) && (Y2.Text == Z1.Text) && (!Z1.Enabled))
            {
                winner = true;
            }
            



            if (winner)
            {
                Done();
                String win = "";
                if (round)
                {

                    win = " O ";
                    O_count.Text = (Int32.Parse(O_count.Text) + 1).ToString();
                    
                }
                else
                {
                    win = " X ";
                    X_count.Text = (Int32.Parse(X_count.Text) + 1).ToString();
                    
                }
                MessageBox.Show("Gratulację! wygrał" + win);
                


            }

            else
            {
                if(count == 9)
                {
                    MessageBox.Show("Remis!");
                }
            }


        }


        private void Done()
        {
            
                foreach (Control c in Controls)
                try
                {
                    {
                    Button a = (Button)c;
                    a.Enabled = false;

                }
            }
            catch
            {

            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count = 0;
            round = true;


            if (round)
            {
                whosturn.Text = "X Turn";
            }
            else
            {
                whosturn.Text = "O Turn";
            }



            foreach (Control c in Controls)
                try
                {

                    {

                        Button a = (Button)c;
                        a.Enabled = true;
                        a.Text = "";
                    }
                }
                catch
                {

                }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void X_count_Click(object sender, EventArgs e)
        {

        }

        private void resetScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X_count.Text = "0";
            O_count.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
