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
            this.PBGreat = new System.Windows.Forms.ProgressBar();
            this.LabelMain = new System.Windows.Forms.Label();
            this.PBBad = new System.Windows.Forms.ProgressBar();
            this.PBOk = new System.Windows.Forms.ProgressBar();
            this.NumCurrentMoney = new System.Windows.Forms.NumericUpDown();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.tpMain = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumCurrentMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // PBGreat
            // 
            this.PBGreat.ForeColor = System.Drawing.Color.LimeGreen;
            this.PBGreat.Location = new System.Drawing.Point(12, 81);
            this.PBGreat.Name = "PBGreat";
            this.PBGreat.Size = new System.Drawing.Size(154, 23);
            this.PBGreat.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBGreat.TabIndex = 0;
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
            // PBBad
            // 
            this.PBBad.ForeColor = System.Drawing.Color.OrangeRed;
            this.PBBad.Location = new System.Drawing.Point(336, 81);
            this.PBBad.Name = "PBBad";
            this.PBBad.Size = new System.Drawing.Size(154, 23);
            this.PBBad.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBBad.TabIndex = 8;
            // 
            // PBOk
            // 
            this.PBOk.ForeColor = System.Drawing.Color.Goldenrod;
            this.PBOk.Location = new System.Drawing.Point(172, 81);
            this.PBOk.Name = "PBOk";
            this.PBOk.Size = new System.Drawing.Size(158, 23);
            this.PBOk.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBOk.TabIndex = 9;
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
            this.NumCurrentMoney.TabStop = false;
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
            this.ButtonSettings.Image = global::CardMonthlyPay.Properties.Resources.settings_38px;
            this.ButtonSettings.Location = new System.Drawing.Point(450, 136);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(40, 40);
            this.ButtonSettings.TabIndex = 10;
            this.ButtonSettings.TabStop = false;
            this.tpMain.SetToolTip(this.ButtonSettings, "Open Settings");
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(65, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Great";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(237, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(395, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bad";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 188);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.NumCurrentMoney);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.PBOk);
            this.Controls.Add(this.PBBad);
            this.Controls.Add(this.LabelMain);
            this.Controls.Add(this.PBGreat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MCP Calculation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumCurrentMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PBGreat;
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.ProgressBar PBBad;
        private System.Windows.Forms.ProgressBar PBOk;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.NumericUpDown NumCurrentMoney;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.ToolTip tpMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

