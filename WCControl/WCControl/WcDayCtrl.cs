using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AGSoft.WCLib;

namespace WCControl
{
    [ToolboxItem(typeof(WcDayCtrl)), ToolboxBitmap(typeof(Button), "WCDayControl")]
    
    public partial class WcDayCtrl : UserControl
    {
        public WcDayCtrl()
        {
            
            InitializeComponent();
        }

        public WcDay A { get; set; }
    }
}
