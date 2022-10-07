using System;
using System.Windows.Forms;

namespace CardMonthlyPay
{
    public partial class MainForm : Form
    {
        // DATA
        private static double TotalCurrentMoney = 0; // 0 - 7000
        private static double MaxMoneyMonth = 0; // 0 - 7000
        private static int PayDay = 1; // 1 - 15 (DD.mm.yyyy)

        private const int MONTH_DAYS = 30;
        private static double MaxMoneyPerDay;
        private static double MaxMoneyUntilCurrentDay;

        public MainForm()
        {
            InitializeComponent();
        }

        private void NumCurrentMoney_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentTotal = (double)NumCurrentMoney.Value;
            Properties.Settings.Default.Save();

            SetData();
        }
        private void SetData()
        {
            //Console.WriteLine("\n-----------\n");
            TotalCurrentMoney = (int)NumCurrentMoney.Value;

            if (TotalCurrentMoney != 0 && MaxMoneyMonth != 0 && PayDay != 0) // check if all have some value
            {
                DateTime lastDateWithDay = LastDateWithDay(PayDay - 1);

                //Console.WriteLine("[INFO] Last date with day: " + lastDateWithDay.ToString("dd/MM/yyyy"));
                MaxMoneyPerDay = MaxMoneyMonth / MONTH_DAYS;
                //Console.WriteLine("[INFO] Max money per day: " + MaxMoneyPerDay);
                MaxMoneyUntilCurrentDay = (int)(DateTime.Now - lastDateWithDay).TotalDays * MaxMoneyPerDay;
                //Console.WriteLine("[INFO] Max money until current day: " + MaxMoneyUntilCurrentDay);

                SetBars(CalcPercentage(TotalCurrentMoney, MaxMoneyUntilCurrentDay));
            }
        }


        /*
         *      100             200             300
         * [PROGRESS BAR 1][PROGRESS BAR 2][PROGRESS BAR 3]
         *      LOW            MEDIUM           HIGH
         */
        public int CalcPercentage(double totalWastedMoneyForToday, double maxAllowedMoneyForToday)
        {
            if (maxAllowedMoneyForToday <= 0)
                return 0;
            int p;
            p = (int)(200 * (totalWastedMoneyForToday * 100.0 / maxAllowedMoneyForToday / 100.0)); // 0 - 300
            //Console.WriteLine("[INFO] " + p + "%");
            return p > 300 ? 300 : p;
        }

        public void SetBars(int percent)
        {
            if (percent <= 100)
            {
                PBGreat.Value = percent;
                PBOk.Value = 0;
                PBBad.Value = 0;
            }
            else if (percent <= 200)
            {
                PBGreat.Value = 100;
                PBOk.Value = percent - 100;
                PBBad.Value = 0;
            }
            else if (percent <= 300)
            {
                PBGreat.Value = 100;
                PBOk.Value = 100;
                PBBad.Value = percent - 200;
            }
        }

        public DateTime LastDateWithDay(int DayNumber)
        {
            DateTime now = DateTime.Now;

            return now.Day >= DayNumber
                ? new DateTime(now.Year, now.Month, DayNumber)
                : now.Month == 1 ? new DateTime(now.Year - 1, 12, DayNumber) : new DateTime(now.Year, now.Month - 1, DayNumber);
        }

        public static void NumMaxMoney_ValueChanged(object sender, EventArgs e)
        {
            MaxMoneyMonth = (int)((NumericUpDown)sender).Value;
            Properties.Settings.Default.MaxMoney = MaxMoneyMonth;
            Properties.Settings.Default.Save();
        }

        public static void NumPayDay_ValueChanged(object sender, EventArgs e)
        {
            PayDay = (int)((NumericUpDown)sender).Value;
            Properties.Settings.Default.PayDay = PayDay;
            Properties.Settings.Default.Save();
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
            NumCurrentMoney.Value = (decimal)Properties.Settings.Default.CurrentTotal;
            TotalCurrentMoney = Properties.Settings.Default.CurrentTotal;

            MaxMoneyMonth = Properties.Settings.Default.MaxMoney;

            PayDay = Properties.Settings.Default.PayDay;

            SetData();
        }
    }
}
