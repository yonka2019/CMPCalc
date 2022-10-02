using System;
using System.Windows.Forms;

namespace CardMonthlyPay
{
    public partial class MainForm : Form
    {
        // DATA
        private static int TotalMoney = 0; // 0 - 7000
        private static int MaxMoneyMonth = 0; // 0 - 7000
        private static int PayDay = 1; // 1 - 15 (DD.mm.yyyy)

        private static int DaysInThisMonth;
        private static int MaxMoneyDay;
        private static int MaxForCurrentDay;

        public MainForm()
        {
            InitializeComponent();
            DaysInThisMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
        }

        private void NumCurrentMoney_ValueChanged(object sender, EventArgs e)
        {
            TotalMoney = (int)NumCurrentMoney.Value;
            if (TotalMoney != 0 && MaxMoneyMonth != 0 && PayDay != 0)
            {
                MaxMoneyDay = MaxMoneyMonth / DaysInThisMonth;
                MaxForCurrentDay = (((int)(DateTime.Now - LastDateWithDay(PayDay)).TotalDays)) * MaxMoneyDay; // days passed
                if (TotalMoney > MaxForCurrentDay)
                {
                    PBLow.Value = 100;
                    PBMedium.Value = 100;
                    PBHigh.Value = 20;

                }
            }
        }
        public DateTime LastDateWithDay(int DayNumber)
        {
            DateTime now = DateTime.Now;
            
            if (now.Day >= DayNumber)
                return new DateTime(now.Year, now.Month, DayNumber);
            else
            {
                if (now.Month == 1)
                    return new DateTime(now.Year - 1, 12, DayNumber);
                else
                    return new DateTime(now.Year, now.Month - 1, DayNumber);
            }
        }

        public static void NumMaxMoney_ValueChanged(object sender, EventArgs e)
        {
            MaxMoneyMonth = (int)((NumericUpDown)sender).Value;
        }

        public static void NumPayDay_ValueChanged(object sender, EventArgs e)
        {
            PayDay = (int)((NumericUpDown)sender).Value;
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(MaxMoneyMonth, PayDay);

            if (!IsOpen(settings))
                settings.Show();
        }

        private bool IsOpen(Form form)
        {
            bool isOpen = false;

            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == form.Name)
                {
                    isOpen = true;
                    return isOpen;
                }
                else
                    isOpen = false;
            }
            return isOpen;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
