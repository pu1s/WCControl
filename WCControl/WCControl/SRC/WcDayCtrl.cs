#region License

/***************************************************************************
 * Этот файл являетя частью исходного кода программы для работы с          * 
 * производственым календарем. Данная программа преднозначена для          *
 * использования в производственной и бухгалтерской сфере. Программа       *    
 * позволяет производить визуальный учет рабочего времени и его            *
 * корректировку в случае отличных от текущих требований по рабочему       *
 * времени.                                                                *
 * *************************************************************************
 * Автор программы и исходного кода: Алексанлр Горин pu1s@outlook.com      *
 * © AGSoft 2015. All rights reserved.                                     *
 * *************************************************************************
 * Изменение исходного кода программы и ее свойств разрешается только при  *
 * разрешении автора.                                                      *
 * *************************************************************************
 * Программа для некоммерческого использования распостраняется бесплатно.  *
 * Для коммерческого использования программы и ее компонентов (исходного   *
 * кода классов, исполняемых файлов, файлов исходного кода, исходного кода *
 * библиотек, dll распостранение осуществляется только после согласования  *
 * с автором исходного кода программы.                                     *
 * Программа распостраняется по принципу  AS IS "как есть", автор          * 
 * исходного кода и алгоритмов программы НЕ НЕСЕТ МАТЕРИАЛЬНОЙ или ДРУГОЙ  * 
 * ОТВЕТСТВЕННОСТИ за повреждение данных и устроств (узлов, или их         *
 * составляющих),входящих в состав электронно вычислительной машины и      *
 * оборудования подключенной к ней.                                        *
 * Использование программы и ее компонентов пользователь осуществляет на   *
 * свой страх и риск.                                                      *
 * *************************************************************************
 * Программа наисана на базе платформы MS.NET 4.5                          *
 * Версия языка C# 6.0                                                     *
 * *************************************************************************
 */

#endregion

#define TEST
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AGSoft.WCLib;
using WCControl;

namespace AGSoft
{
    [ToolboxItem(true)]
    public partial class WcDayCtrl : UserControl
    {
        #region Базовые опрделения

        #region Блокировщик

        private static readonly object Locker = new object();

        #endregion

        #region Поля

        private WcDay _wcDay;

        #endregion

        #region Свойства

        public WcDay WcDay
        {
            get
            {
                // блокировка потока
                lock (Locker)
                {
                    return _wcDay;
                }
            }
            set
            {
                // блокировка потока
                lock (Locker)
                {
                    // если комментарий или аттрибут календарного дня изменен
                    if (_wcDay.DayComment == value.DayComment || _wcDay.DayAttr == value.DayAttr) return;
                    _wcDay = value;
                    // вызываем событие
                    OnChangeWcDay();
                    Invalidate();
                }
            }
        }

        #endregion

        #region События

        public event EventHandler<WcDayChangeEventArgs> ChangeWcDay;

        #endregion

        #region Методы, возбуждающие события

        protected virtual void OnChangeWcDay()
        {
            var handler = ChangeWcDay;
            if (handler == null) return;
            handler(this, new WcDayChangeEventArgs(WcDay));
        }

        #endregion

        #region Конструкторы

        public WcDayCtrl()
        {
            InitializeComponent();
#if TEST
            _wcDay = new WcDay(DateTime.Now);
#endif
        }

        public WcDayCtrl(DateTime date) : this()
        {
            _wcDay = new WcDay(date);
        }

        public WcDayCtrl(DateTime date, WсDayAttr dayAttr, string comment) : this()
        {
            _wcDay = new WcDay(date);
            _wcDay.UpdateWcDayAttr(dayAttr);
            _wcDay.UpdateWcDayComment(comment);
        }

        #endregion

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // WcDayCtrl
            // 
            MaximumSize = new Size(20, 20);
            MinimumSize = new Size(20, 20);
            Name = "WcDayCtrl";
            Size = new Size(20, 20);
            ResumeLayout(false);
        }

        #endregion
    }
}