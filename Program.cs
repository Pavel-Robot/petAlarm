using DataBaseWithObj;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseWithObj;
using System.Globalization;
using System.Diagnostics;

namespace MyProject
{

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //DoDataBaseDefault();
            //DoForDataBaseTemp(); //Загружаю данные из БД
            //DoDataBaseCurrent();
            DownloadedCurrent();


            Form1 MainForm = new Form1();

            Application.Run(MainForm);

        }

        /// <summary>
        /// Заносим в память данные
        /// </summary>
        public static void DoForDataBaseTemp()
        {
            DataBase.NotyfyList.Clear();

            DataBase.NotyfyList.Add(new NotifyObj(
                "Заплати деньги за хату!",
                "Сегодня 5 число. Загляни в папку Долги и .xlsx:" +
                "1 Электричество 2 Мусор 3 СГК 4 ЖКУ 5 КАП РЕМ",
                new DateTime(DateTime.Today.Year, DateTime.Today.Month, 5, 0, 0, 0),
                new DateTime(DateTime.Today.Year, DateTime.Today.Month, 8, 0, 0, 0),
                6 * 60,
                5,
                1
                ));

            DataBase.NotyfyList.Add(new NotifyObj(
                "Отправь счетчики СГК!",
                "2 счетчика в уборной 2 в твоей комнате, отправить 4 значения!",
                new DateTime(DateTime.Today.Year, DateTime.Today.Month, 23, 0, 0, 0),
                new DateTime(DateTime.Today.Year, DateTime.Today.Month, 24, 0, 0, 0),
                4 * 60,
                3,
                1
                ));


            DataBase.NotyfyList.Add(new NotifyObj(
                "Приберись на кухне!",
                "1 помой посуду 2 вытри грязь 3 заполни воду 4 вынеси мусор!",
                new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 16, 0, 0),
                new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 18, 0, 0),
                10 * 60,
                5,
                2
                ));



        }

        /// <summary>
        /// Загружаю данные из файла
        /// </summary>
        public static void DoDataBaseDefault()
        {
            DataBase.NotyfyList.Clear();

            string[] lines = File.ReadAllLines("DataDefault.txt");


            foreach (string line in lines)
            {
                string[] parts = line.Split(';');

                DataBase.NotyfyList.Add(new NotifyObj(
                    parts[0],
                    parts[1],
                    new DateTime(Int32.Parse(parts[2]), Int32.Parse(parts[3]), Int32.Parse(parts[4]),
                                 Int32.Parse(parts[5]), Int32.Parse(parts[6]), Int32.Parse(parts[7])),

                    new DateTime(Int32.Parse(parts[8]), Int32.Parse(parts[9]), Int32.Parse(parts[10]),
                                 Int32.Parse(parts[11]), Int32.Parse(parts[12]), Int32.Parse(parts[13])),
                    Int32.Parse(parts[14]),
                    Int32.Parse(parts[15]),
                    Int32.Parse(parts[16])
                    ));
            }

        }

        /// <summary>
        /// Выгружаю то что есть в памяти на данный момент в файл
        /// </summary>
        public static void DoDataBaseCurrent()
        {
            string data = "";
            for (int i = 0; i < DataBase.NotyfyList.Count; i++)
            {
                var el = DataBase.NotyfyList[i];

                //(i + 1).ToString() + " " +
                string bdata = el.FullName + ";"
                    + el.Note + ";"
                    + el.DateStart.Year + ";" + el.DateStart.Month + ";" + el.DateStart.Day + ";"
                    + el.DateStart.Hour + ";" + el.DateStart.Minute + ";" + el.DateStart.Second + ";"
                    + el.DateEnd.Year + ";" + el.DateEnd.Month + ";" + el.DateEnd.Day + ";"
                    + el.DateEnd.Hour + ";" + el.DateEnd.Minute + ";" + el.DateEnd.Second + ";"
                    + el.WaitTime + ";"
                    + el.CountRepeat + ";"
                    + el.Type + "\n";

                data = data + bdata;

            }

            // Запись данных в файл
            using (StreamWriter writer = new StreamWriter("DataCurrent.txt", false))
            {
                writer.Write(data);
            }

        }

        public static void DownloadedCurrent()
        {
            string[] lines = File.ReadAllLines("DataCurrent.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');

                DataBase.NotyfyList.Add(new NotifyObj(
                    parts[0],
                    parts[1],
                    new DateTime(Int32.Parse(parts[2]), Int32.Parse(parts[3]), Int32.Parse(parts[4]),
                                 Int32.Parse(parts[5]), Int32.Parse(parts[6]), Int32.Parse(parts[7])),

                    new DateTime(Int32.Parse(parts[8]), Int32.Parse(parts[9]), Int32.Parse(parts[10]),
                                 Int32.Parse(parts[11]), Int32.Parse(parts[12]), Int32.Parse(parts[13])),
                    Int32.Parse(parts[14]),
                    Int32.Parse(parts[15]),
                    Int32.Parse(parts[16])
                    ));
            }

        }

        
    }
}