using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21._10._2022___Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SetTimeFormat()
        {
            switch(comboBoxTimeFormat.Text)
            {
                case ("Полное время"):
                    {
                        label1.Text = DateTime.Now.ToString("dd-MMMM-yyyy HH:mm:ss.fff");
                        break;
                    }
                case ("Краткое время"):
                    {
                        label1.Text = DateTime.Now.ToString("HH:mm:ss");
                        break;
                    }
                case ("Только дата"):
                    {
                        label1.Text = DateTime.Now.ToString("dd-MMMM-yyyy");
                        break;
                        
                    }
                default:
                    {
                        MessageBox.Show("Выберите формат времени");
                        label1.Text = "Текущее время";
                    }
                    break;
            }

        }

        private void SetComboboxColor()
        {
            var button = comboChangeColor.BackColor.ToString();

            switch (button)
            {
                case ("Color.White"):
                    {
                      changeColor.BackColor = Color.Green;
                    }
                break;
                case ("Color.Green"):
                    {
                        changeColor.BackColor = Color.Yellow;
                    }
                    break;
                case ("Color.Yellow"):
                    {
                        changeColor.BackColor = Color.Yellow;
                    }
                    break;
                    default:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonShowTime(object sender, EventArgs e)
        {
            SetTimeFormat();
            //label1.Text = DateTime.Now.ToString("dd-MMMM-yyyy HH:mm:ss.fff");

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SetTimeFormat();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void changeColor_(object sender, MouseEventArgs e)
        {

            SetComboboxColor();
            //var button = sender as Button;
            //var originalColor = button.BackColor;

            //button.BackColor = Color.Red;
            //Thread.Sleep(1000);
            //button.BackColor = originalColor;


            //changeColor.BackColor = Color.Green;
            //Thread.Sleep(1000);
            //if (changeColor.BackColor == Color.Green)
            //{
            //    changeColor.BackColor = Color.Yellow;
            //    Thread.Sleep(1000);
            //}

            //if (changeColor.BackColor == Color.Yellow)
            //{
            //    changeColor.BackColor = Color.Green;
            //    Thread.Sleep(1000);
            //}

            //Thread.Sleep(1000);


        }
    }
}
