using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AGSoft
{
    public partial class WcDayCtrl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._wcDayToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // WcDayCtrl
            // 
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(20, 20);
            this.MinimumSize = new System.Drawing.Size(20, 20);
            this.Name = "WcDayCtrl";
            this.Size = new System.Drawing.Size(20, 20);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
