using System;
using AGSoft.WCLib;

namespace AGSoft
{
    public class WcDayChangeEventArgs : EventArgs
    {
        public WcDay WcDay { get; set; }

        public WcDayChangeEventArgs(WcDay wcDay)
        {
            WcDay = wcDay;
        }

    }
}