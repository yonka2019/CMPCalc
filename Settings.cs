using System;
using System.Windows.Forms;

namespace CardMonthlyPay
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            NumMaxMoney.ValueChanged += new EventHandler(MainForm.NumMaxMoney_ValueChanged);
            NumPayDay.ValueChanged += new EventHandler(MainForm.NumPayDay_ValueChanged);
        }
        public Settings(double NumMaxMoney, int NumPayDay)  : this()
        {
            this.NumMaxMoney.Value = (decimal)NumMaxMoney;
            this.NumPayDay.Value = NumPayDay;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

    }
}
