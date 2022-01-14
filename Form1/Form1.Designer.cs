
namespace Form1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AmountOfBTC = new System.Windows.Forms.TextBox();
            this.Currencybox = new System.Windows.Forms.ComboBox();
            this.GetRatesBTN = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AmountOfBTC
            // 
            this.AmountOfBTC.Location = new System.Drawing.Point(50, 107);
            this.AmountOfBTC.Name = "AmountOfBTC";
            this.AmountOfBTC.PlaceholderText = "Amount Of BTC";
            this.AmountOfBTC.Size = new System.Drawing.Size(121, 23);
            this.AmountOfBTC.TabIndex = 0;
            // 
            // Currencybox
            // 
            this.Currencybox.FormattingEnabled = true;
            this.Currencybox.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP"});
            this.Currencybox.Location = new System.Drawing.Point(50, 52);
            this.Currencybox.Name = "Currencybox";
            this.Currencybox.Size = new System.Drawing.Size(121, 23);
            this.Currencybox.TabIndex = 1;
            this.Currencybox.Text = "Select currency";
            this.Currencybox.SelectedIndexChanged += new System.EventHandler(this.Currencybox_SelectedIndexChanged);
            // 
            // GetRatesBTN
            // 
            this.GetRatesBTN.Location = new System.Drawing.Point(209, 107);
            this.GetRatesBTN.Name = "GetRatesBTN";
            this.GetRatesBTN.Size = new System.Drawing.Size(75, 23);
            this.GetRatesBTN.TabIndex = 2;
            this.GetRatesBTN.Text = "Get Rates";
            this.GetRatesBTN.UseVisualStyleBackColor = true;
            this.GetRatesBTN.Click += new System.EventHandler(this.GetRatesBTN_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(50, 184);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(39, 15);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Result";
            this.ResultLabel.Visible = false;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(50, 229);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(121, 23);
            this.Result.TabIndex = 4;
            this.Result.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.GetRatesBTN);
            this.Controls.Add(this.Currencybox);
            this.Controls.Add(this.AmountOfBTC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AmountOfBTC;
        private System.Windows.Forms.ComboBox Currencybox;
        private System.Windows.Forms.Button GetRatesBTN;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox Result;
    }
}

