using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataBaseWithObj
{
    static class DataBase
    {
        public static List<NotifyObj> NotyfyList = new List<NotifyObj>(); // Объект уведомлений

    }

    ///<summary>Класс уведомление с дом параметрами</summary>
	public class NotifyObj
    {

        /// <summary>
        /// Название уведомления
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Дата начала когда уведомление будет показываться с такой то даты
		/// </summary>
		public DateTime DateStart { get; set; }

        /// <summary>
        /// Дата конца когда уведомление будет показываться по такую-то дату
		/// </summary>
		public DateTime DateEnd { get; set; }

        /// <summary>
        /// Что будет сообщать уведомление
        /// <summary>
        public string Note { get; set; }

        /// <summary>
        /// Сам объект уведомления
        /// <summary>
        public NotifyIcon NoteObj { get; set; }

        /// <summary>
        /// Время определяющее через сколько будет повторено объявление в сек
        /// будем задавать его сами при определении
        /// <summary>
        public int WaitTime { get; set; }

        /// <summary>
        /// Кол-во повторений напоминания
        /// <summary>
        public int CountRepeat { get; set; }
        public int CountRepeatCurrent { get; set; }


        /// <summary>
        /// Тип объекта 1 - повторение события по дням в месяце без учета часов,
        /// Тип объекта 2 - повторение события в день недели с учетом времени.
        /// <summary>
        public int Type { get; set; }


        /// <summary>
        /// Задача работает? Если нет, то и не запускай
        /// <summary>
        public bool DoOrNot { get; set; }

        /// <summary>
        /// Время от которого задача не будет показываться в уведомлении или рабоатть
        /// <summary>
        public DateTime DataWorkStart { get; set; }

        /// <summary>
        /// Время до которого задача не будет показываться в уведомлении или рабоатть
        /// <summary>
        public DateTime DataWorkEnd { get; set; }

        /// <summary>
        /// Ссылка на текст или файл или еще что то..
        /// <summary>
        public int Cite { get; set; }

        /// <summary>
        /// График погоды
        /// <summary>
        public int Weather { get; set; }

        /// <summary>
        /// Задача
        /// <summary>
        public Task task { get; set; }

        /// <summary>
        /// В какие дни задача не работает
        /// <summary>
        public List<string> DaysHoliday { get; set; }
        


        /// <summary>
        /// Конструктор класса NotifyObj
        /// <param name="fullname">Название уведомления (заголовок)</param>
        /// <param name="datestart">Дата начала с</param>
        /// <param name="dateend">Дата окончания по</param>
        /// <param name="note">Сообщение уведомления</param>
        /// <param name="waittime">Ожидание в сек</param>
        /// <param name="countrepeat">Кол-во повторений</param>
        /// <param name="type">Тип объекта</param>
        /// <summary>
        public NotifyObj(
            string fullname,
            string note,
            DateTime datestart,
            DateTime dateend,
            int waittime,
            int countrepeat,
            int type
            )
        {

            this.FullName = fullname;
            this.Note = note;
            this.DateStart = datestart;
            this.DateEnd = dateend;
            this.WaitTime = waittime;
            this.CountRepeat = countrepeat;
            this.CountRepeatCurrent = countrepeat;
            this.Type = type;

            // Постоянно задаю значения
            this.DoOrNot = true;
            var daysHoliday = new List<string> { "Saturday", "Sunday" };
            this.DaysHoliday = daysHoliday;


            var notification = new System.Windows.Forms.NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                BalloonTipIcon = System.Windows.Forms.ToolTipIcon.None,
                BalloonTipTitle = this.FullName,
                BalloonTipText = this.Note
            };

            this.NoteObj = notification;
        }

        ///<summary> Метод для показа уведомления без параллельности </summary>
        public void NoteShow() 
        {
            // Проверка на то что сегодня правильный день в месяце в диапазаоне начала-конца
            if (Type == 1 && (DateStart.Day <= DateTime.Now.Day && DateEnd.Day >= DateTime.Now.Day)) 
            {
                if (!DaysHoliday.Contains(DateTime.Now.DayOfWeek.ToString()))
                {
                    System.Threading.Thread.Sleep(5 * 1000); // Задержка чтобы не сразу все вылетали как из пулемета
                    this.CountRepeatCurrent--;
                    this.NoteObj.ShowBalloonTip(300000);
                    System.Threading.Thread.Sleep(this.WaitTime * 60 * 1000);

                    //Console.WriteLine($"{this.FullName} я отнял попытку");
                }
                
            }  
            else 
            {
                // Проверка по часам для типа 2 и по дням недели
                if (!DaysHoliday.Contains(DateTime.Now.DayOfWeek.ToString())) { // Проверка с учетом дней отдыха
                if (Type == 2 && (DateStart.Hour <= DateTime.Now.Hour && DateEnd.Hour >= DateTime.Now.Hour))
                    {
                        System.Threading.Thread.Sleep(5 * 1000); // Задержка чтобы не сразу все вылетали как из пулемета
                        this.CountRepeatCurrent--;
                        this.NoteObj.ShowBalloonTip(300000);
                        System.Threading.Thread.Sleep(this.WaitTime * 60 * 1000);
                        
                        //Console.WriteLine($"{this.FullName} я отнял попытку");
                    }
                }
                //else Console.WriteLine($"{this.FullName} я не запустился");
                //если ждать не будет, то он не запуститься
            }
        }

        public void NoteShowWhile()
        {
            while(true)
            { 
                while(DoOrNot == true && CountRepeatCurrent > 0)
                {

                    if(CountRepeatCurrent == 0)
                        DoOrNot = false;
                    else 
                    { 
                        System.Threading.Thread.Sleep(10 * 1000);
                        NoteShow();
                        System.Threading.Thread.Sleep(10 * 1000);
                    }


                }
            }
        }

            ///<summary> Метод для показа уведомлений паралелльно </summary>
            public void NoteShowParallel() 
        {

            this.task = new Task(() =>
            {
                this.NoteShowWhile();
            });

            this.task.Start();
        } 

        /// <summary>
        /// Убить задачу
        /// </summary>
        public void stopTask()
        {

            /*var cts = new TaskCompletionSource<bool>();
            cts.SetCanceled();
            this.task.ContinueWith(t => cts.TrySetCanceled(), TaskContinuationOptions.ExecuteSynchronously);
            */


            DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите остановить запись?",
                                       "Остановить запись?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // Отменяем задачу
                var cts = new System.Threading.CancellationTokenSource();
                cts.Cancel();

                // Ожидаем окончания работы задачи
                try
                {
                    var a = 1;
                }
                catch (AggregateException) { }
                finally
                {
                    // Очищаем ресурсы
                    cts.Dispose();
                }

            }

            //this.task.Dispose();
        }
    }
}