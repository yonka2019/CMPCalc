namespace CardMonthlyPay
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PBLow = new System.Windows.Forms.ProgressBar();
            this.LabelMain = new System.Windows.Forms.Label();
            this.PBHigh = new System.Windows.Forms.ProgressBar();
            this.PBMedium = new System.Windows.Forms.ProgressBar();
            this.NumCurrentMoney = new System.Windows.Forms.NumericUpDown();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.tpMain = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumCurrentMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // PBLow
            // 
            this.PBLow.Location = new System.Drawing.Point(12, 81);
            this.PBLow.Name = "PBLow";
            this.PBLow.Size = new System.Drawing.Size(154, 23);
            this.PBLow.TabIndex = 0;
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMain.Location = new System.Drawing.Point(57, 9);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(389, 39);
            this.LabelMain.TabIndex = 1;
            this.LabelMain.Text = "Monthly Card Pay Calculation";
            // 
            // PBHigh
            // 
            this.PBHigh.Location = new System.Drawing.Point(336, 81);
            this.PBHigh.Name = "PBHigh";
            this.PBHigh.Size = new System.Drawing.Size(154, 23);
            this.PBHigh.TabIndex = 8;
            // 
            // PBMedium
            // 
            this.PBMedium.Location = new System.Drawing.Point(172, 81);
            this.PBMedium.Name = "PBMedium";
            this.PBMedium.Size = new System.Drawing.Size(158, 23);
            this.PBMedium.TabIndex = 9;
            // 
            // NumCurrentMoney
            // 
            this.NumCurrentMoney.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumCurrentMoney.Location = new System.Drawing.Point(203, 145);
            this.NumCurrentMoney.Maximum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.NumCurrentMoney.Name = "NumCurrentMoney";
            this.NumCurrentMoney.Size = new System.Drawing.Size(97, 33);
            this.NumCurrentMoney.TabIndex = 11;
            this.NumCurrentMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumCurrentMoney.ValueChanged += new System.EventHandler(this.NumCurrentMoney_ValueChanged);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTotal.Location = new System.Drawing.Point(201, 120);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(104, 22);
            this.LabelTotal.TabIndex = 12;
            this.LabelTotal.Text = "Current Total:";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Image = global::CardMonthlyPay.Properties.Resources.settings_48px;
            this.ButtonSettings.Location = new System.Drawing.Point(440, 126);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(50, 50);
            this.ButtonSettings.TabIndex = 10;
            this.tpMain.SetToolTip(this.ButtonSettings, "Open Settings");
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 188);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.NumCurrentMoney);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.PBMedium);
            this.Controls.Add(this.PBHigh);
            this.Controls.Add(this.LabelMain);
            this.Controls.Add(this.PBLow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MCP Calculation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumCurrentMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PBLow;
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.ProgressBar PBHigh;
        private System.Windows.Forms.ProgressBar PBMedium;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.NumericUpDown NumCurrentMoney;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.ToolTip tpMain;
    }
}

