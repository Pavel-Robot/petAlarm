using DataBaseWithObj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            //this.Hide();

            dataGridView1.Rows.Clear();
            foreach (var element in DataBase.NotyfyList)
                dataGridView1.Rows.Add(element.FullName,
                    element.Note,
                    element.DateStart.ToString(),
                    element.DateEnd.ToString(),
                    element.WaitTime.ToString(),
                    element.CountRepeat.ToString(),
                    element.CountRepeatCurrent.ToString(),
                    element.DoOrNot.ToString()
                    );

            MyNotifyInit();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataBase.NotyfyList.Add(new NotifyObj(
                textBox1.Text,
                textBox2.Text,
                dateTimePicker2.Value,
                dateTimePicker3.Value,
                Int32.Parse(textBox3.Text),
                Int32.Parse(textBox4.Text),
                Int32.Parse(textBox5.Text)
                ));
            
        }

        public static void WeatherPng()
        {
            while (true)
            {

                try
                {

                    // Создаем новый процесс
                    Process process = new Process();

                    // Задаем путь к исполняемому файлу программы
                    process.StartInfo.FileName = "run.bat";

                    // Запускаем программу
                    process.Start();



                }
                catch (Exception ex)
                {
                    // Возникла ошибка при запуске программы
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

                System.Threading.Thread.Sleep(2 * 60 * 60 * 1000);
            }
        }

        private void MyNotifyInit()
        {
            var taskWeather = new Task(() =>
            {
                WeatherPng();
            });

            taskWeather.Start();
            

            foreach (var element in DataBase.NotyfyList)
            {
                //Console.WriteLine($"{element.FullName} ");
                element.NoteShowParallel();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.DoDataBaseDefault();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach (var element in DataBase.NotyfyList)
                dataGridView1.Rows.Add(element.FullName,
                    element.Note,
                    element.DateStart.ToString(),
                    element.DateEnd.ToString(),
                    element.WaitTime.ToString(),
                    element.CountRepeat.ToString(),
                    element.CountRepeatCurrent.ToString(),
                    element.DoOrNot.ToString()
                    );
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.DoDataBaseCurrent();
            Application.Restart();

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void удалитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }

        private void удалитьToolStripMenuItem_Click_2(object sender, EventArgs e)
        {

            int ind = dataGridView1.CurrentRow.Index;
            string name = DataBase.NotyfyList[ind].FullName;

            DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить запись {name}?",
                                       "Сообщение об удалении", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DataBase.NotyfyList.RemoveAt(ind);

                dataGridView1.Rows.Clear();

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.DoForDataBaseTemp();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void активностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.CurrentRow.Index;
            string name = DataBase.NotyfyList[ind].FullName;

            DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите изменить активность записи {name}?",
                                       "Сообщение об активноси ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                var Temp = DataBase.NotyfyList[ind].DoOrNot;
                if (Temp == true) 
                { 
                    DataBase.NotyfyList[ind].DoOrNot = false;
                }
                else
                    if (Temp == false) 
                        DataBase.NotyfyList[ind].DoOrNot = true;

                dataGridView1.Rows.Clear();

            }
        }

        private void обновпопыткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.CurrentRow.Index;
            DataBase.NotyfyList[ind].CountRepeatCurrent = DataBase.NotyfyList[ind].CountRepeat;
        }

        private void завершитьпотокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.CurrentRow.Index;
            DataBase.NotyfyList[ind].stopTask();
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
