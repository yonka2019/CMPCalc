namespace CardMonthlyPay
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.NumPayDay = new System.Windows.Forms.NumericUpDown();
            this.NumMaxMoney = new System.Windows.Forms.NumericUpDown();
            this.LabelMaxWaste = new System.Windows.Forms.Label();
            this.LabelPayDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumPayDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMaxMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // NumPayDay
            // 
            this.NumPayDay.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumPayDay.Location = new System.Drawing.Point(48, 96);
            this.NumPayDay.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NumPayDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumPayDay.Name = "NumPayDay";
            this.NumPayDay.Size = new System.Drawing.Size(120, 35);
            this.NumPayDay.TabIndex = 0;
            this.NumPayDay.TabStop = false;
            this.NumPayDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumPayDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumMaxMoney
            // 
            this.NumMaxMoney.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumMaxMoney.Location = new System.Drawing.Point(48, 30);
            this.NumMaxMoney.Maximum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.NumMaxMoney.Name = "NumMaxMoney";
            this.NumMaxMoney.Size = new System.Drawing.Size(120, 35);
            this.NumMaxMoney.TabIndex = 1;
            this.NumMaxMoney.TabStop = false;
            this.NumMaxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelMaxWaste
            // 
            this.LabelMaxWaste.AutoSize = true;
            this.LabelMaxWaste.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMaxWaste.Location = new System.Drawing.Point(35, 10);
            this.LabelMaxWaste.Name = "LabelMaxWaste";
            this.LabelMaxWaste.Size = new System.Drawing.Size(146, 17);
            this.LabelMaxWaste.TabIndex = 2;
            this.LabelMaxWaste.Text = "Maximum allowed waste";
            this.LabelMaxWaste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPayDay
            // 
            this.LabelPayDay.AutoSize = true;
            this.LabelPayDay.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPayDay.Location = new System.Drawing.Point(51, 76);
            this.LabelPayDay.Name = "LabelPayDay";
            this.LabelPayDay.Size = new System.Drawing.Size(114, 17);
            this.LabelPayDay.TabIndex = 3;
            this.LabelPayDay.Text = "Day number to pay";
            this.LabelPayDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 146);
            this.Controls.Add(this.LabelPayDay);
            this.Controls.Add(this.LabelMaxWaste);
            this.Controls.Add(this.NumMaxMoney);
            this.Controls.Add(this.NumPayDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.NumPayDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMaxMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumPayDay;
        private System.Windows.Forms.NumericUpDown NumMaxMoney;
        private System.Windows.Forms.Label LabelMaxWaste;
        private System.Windows.Forms.Label LabelPayDay;
    }
}