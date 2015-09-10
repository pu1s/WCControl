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

using System.ComponentModel;
using System.Drawing;

namespace AGSoft
{
    public partial class WcDayCtrl
    {
        /* Свойства, определяющие внешний вид и поведение */

        // Свойство, определяющее анимацию при наведении указателя мыши
        [Browsable(true), Category("Внешний вид")]
        public bool UseAnimation
        {
            get { return _useAnimation; }

            set
            {
                if (value == _useAnimation) return;
                _useAnimation = value;
                Invalidate();
            }
        }
        // Свойство, определяюшее наведен ли указатель мыши на компонент
        [Browsable(false)]
        public bool IsMouseEnter { get; set; }
        // Свойство, определяющее включение подсказки в виде всплывающего окна
        [Browsable(true), Category("Внешний вид"), Description("Всплывающая подсказка"), DefaultValue(true)]
        public bool UseHint
        {
            get { return _useHint; }
            set
            {
                if(value==_useHint) return;
                _useHint = value;
                _wcDayToolTip.Active = _useHint;
            }
        }
        // Свойство, определяющее выбран ли компонент
        [Browsable(false)]
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (value == _isSelected) return;
                _isSelected = value;
                Invalidate();
            }
        }

        /* Цвета шрифтов */

        // Свойство, оперделяющее цвет шрифта рабочего дня
        [Browsable(false), Category("Цвет шрифта"), Description("Цвет шрифта рабочего дня")]
        public Color WorkDayFontColor
        {
            // совпадает с цветом шрифта контрола
            get { return ForeColor; }
        }

        // Свойство, оперделяющее цвет шрифта короткого дня
        [Browsable(true), Category("Цвет шрифта"), Description("Цвет шрифта короткого дня")]
        public Color ShortDayFontColor
        {
            get { return _shortDayFontColor; }
            set
            {
                if (value == _shortDayFontColor) return;
                _shortDayFontColor = value;
                Invalidate();
            }
        }

        // Свойство, оперделяющее цвет шрифта праздничного/выходного дня
        [Browsable(true), Category("Цвет шрифта"), Description("Цвет шрифта праздничного/выходного дня")]
        public Color HollydayFontColor
        {
            get { return _hollydayFontColor; }
            set
            {
                if (value == _hollydayFontColor) return;
                _hollydayFontColor = value;
                Invalidate();
            }
        }

        /* Цвета фона */

        // Цвет фона короткого дня
        [Browsable(true), Category("Цвет фона"), Description("Цвет фона короткого дня")]
        public Color ShortDayBgColor
        {
            get { return _shortDayBgColor; }
            set
            {
                if (value == _shortDayBgColor) return;
                _shortDayBgColor = value;
                Invalidate();
            }
        }

        // Цвет фона праздничного/выходного дня
        [Browsable(true), Category("Цвет фона"), Description("Цвет фона короткого дня")]
        public Color HolldayBgColor
        {
            get { return _hollydayBgColor; }
            set
            {
                if (value == _hollydayBgColor) return;
                _hollydayBgColor = value;
                Invalidate();
            }
        }

        // Цвет фона рабочего дня
        [Browsable(false), Category("Цвет фона"), Description("Цвет фона рабочего дня")]
        public Color WorkDayBgColor
        {
            // совпадает с цветом фона контрола
            get { return BackColor; }
        }

        // Цвет фона при наведении указателя мыши
        [Browsable(true), Category("Цвет фона"), Description("Цвет фона при наведении указателя мыши")]
        public Color EnterMouseBgColor
        {
            get { return _enterMouseBgColor; }
            set
            {
                if (value == _enterMouseBgColor) return;
                _enterMouseBgColor = value;
                Invalidate();
            }
        }
    }
}