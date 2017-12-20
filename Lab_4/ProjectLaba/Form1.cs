using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        Stopwatch cl = new Stopwatch(); //Часы
        public Form1() //Запуск с Program
        {
            InitializeComponent(); //Инициализация всех компонентов
        }
        private void button1_Click(object sender, EventArgs e)  //Кнопка: Загрузка файла
        {
            cl.Reset();
            OpenFileDialog win1 = new OpenFileDialog();
            win1.InitialDirectory = "\\Mac/Home/Documents/Course_2\bkIT/Lab_4";
            win1.Filter = "txt files (*.txt)|*.txt";
            win1.FilterIndex = 2;
            win1.RestoreDirectory = true;
            if (win1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    cl.Start(); //Запуск отсчёта
                    string buf = File.ReadAllText(win1.FileName);
                    List<string> a = new List<string>();
                    string[] buf2 = buf.Split();
                    foreach (string l in buf2)
                    {
                        if (!a.Contains(l))
                            a.Add(l);
                    }
                    a.Sort();
                    addToListBox(a);
                    cl.Stop(); //Тормозим таймер
                    label1.Text = "Чтение файла, сортировка и вывод слов: "+ cl.ElapsedMilliseconds.ToString() + " миллисекунд";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения файла!\n" + ex.Message);
                }
            }
        }
        void addToListBox(List<string> a)
        {

            listBox1.BeginUpdate();
            foreach (string l in a)
            {
                listBox1.Items.Add(l);
            }
            listBox1.EndUpdate();
         }
        private void findb_Click(object sender, EventArgs e)      //Кнопка: Поиск слова
        {
            cl.Reset();
            cl.Start();
            listBox1.SelectedIndex = listBox1.FindStringExact(textBox1.Text);
            cl.Stop();
            label2.Text = "Поиск в списке: " + cl.ElapsedMilliseconds.ToString() + " миллисекунд";
        }
    }
}
