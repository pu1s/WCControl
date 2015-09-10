namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.wcDayCtrl1 = new AGSoft.WcDayCtrl();
            this.SuspendLayout();
            // 
            // wcDayCtrl1
            // 
            this.wcDayCtrl1.EnterMouseBgColor = System.Drawing.Color.Empty;
            this.wcDayCtrl1.HolldayBgColor = System.Drawing.Color.Empty;
            this.wcDayCtrl1.HollydayFontColor = System.Drawing.Color.Empty;
            this.wcDayCtrl1.IsAnimated = false;
            this.wcDayCtrl1.IsHint = false;
            this.wcDayCtrl1.IsMouseEnter = false;
            this.wcDayCtrl1.IsSelected = false;
            this.wcDayCtrl1.Location = new System.Drawing.Point(437, 82);
            this.wcDayCtrl1.MaximumSize = new System.Drawing.Size(20, 20);
            this.wcDayCtrl1.MinimumSize = new System.Drawing.Size(20, 20);
            this.wcDayCtrl1.Name = "wcDayCtrl1";
            this.wcDayCtrl1.ShortDayBgColor = System.Drawing.Color.Empty;
            this.wcDayCtrl1.ShortDayFontColor = System.Drawing.Color.Empty;
            this.wcDayCtrl1.Size = new System.Drawing.Size(20, 20);
            this.wcDayCtrl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 261);
            this.Controls.Add(this.wcDayCtrl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private AGSoft.WcDayCtrl wcDayCtrl1;










    }
}

