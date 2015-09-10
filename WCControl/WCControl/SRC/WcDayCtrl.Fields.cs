﻿#region License

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

using System.Drawing;
using System.Windows.Forms;

namespace WCControl
{
    public partial class WcDayCtrl
    {
        /* Цвета */
        private Color _hollydayBgColor;
        private Color _hollydayFontColor;
        private Color _shortDayBgColor;
        private Color _shortDayFontColor;
        private Color _enterMouseBgColor; 
        /* переменные */
        private bool _useAnimation;
        private bool _isSelected;
        private bool _useHint;
        /* Подсказка */
        private ToolTip _wcDayToolTip;
    }
}