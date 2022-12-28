using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        bool select;
        double x, y;
        public Form1()
        {
          
            {
                InitializeComponent();

            }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                MessageBox.Show("Программу разработала:\nСтудентка колледжа КИТП гр. ПКсп-120\nСереденина Виктория Дмитриевна\nВариант 18.");
           
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.AllowWebBrowserDrop = false;
            OpenFileDialog openFileDialogs = new OpenFileDialog();
                openFileDialogs.Filter = "*.html|*.html";
                openFileDialogs.ShowDialog();
                string[] repSplit = openFileDialogs.FileName.Split('\\');
                string curFile = repSplit[repSplit.Length - 1];
                if (curFile == "1.html")
                {
                    webBrowser1.Navigate(openFileDialogs.FileName);
                    select = true;
                }
                else if (curFile == "2.html")
                {
                    webBrowser1.Navigate(openFileDialogs.FileName);
                    select = false;
                }
                else
                {
                    
                }

        }
        void var1()
        {
            if (Double.TryParse(textBox1.Text, out x) && Double.TryParse(textBox2.Text, out y))
            {
                if (x * x + y * y < 36 && y > 4)
                {
                    MessageBox.Show("Внутри функции");
                    toolStripStatusLabel1.Text = "Внутри функции";
                }
                else if (x * x + y * y == 36 || y == 4)
                {
                    MessageBox.Show("На границе");
                    toolStripStatusLabel1.Text = "На границе";
                }
                else
                {
                    MessageBox.Show("Вне функции");
                    toolStripStatusLabel1.Text = "Вне функции";
                }
            }
            else
            {
                MessageBox.Show("Введите вещественное число");
            }
        }



        void var2()
        {
            if (Double.TryParse(textBox1.Text, out x) && Double.TryParse(textBox2.Text, out y))
            {
                if (x * x + y * y == 1 && y < 0 || x == -1)
                {
                    MessageBox.Show("Внутри функции");
                    toolStripStatusLabel1.Text = "Внутри функции";
                }
                else if (y >= 0)
                {
                    MessageBox.Show("Вне функции");
                    toolStripStatusLabel1.Text = "Вне функции";
                }
                else
                {
                    MessageBox.Show("На границе");
                     toolStripStatusLabel1.Text = "На границе";
                }
            }
            else
            {
                MessageBox.Show("Введите вещественное число");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (select)
            {
                var1();
            }
            else
            {
                var2();
            }
        }

       
    }
}
