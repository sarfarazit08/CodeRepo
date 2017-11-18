namespace CurrencyConverter
{
    partial class CurrencyConverterForm
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
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtCurrency1 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "BP",
            "INR",
            "SD",
            "JY",
            "CY",
            "GM",
            "USD"});
            this.cb1.Location = new System.Drawing.Point(12, 12);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 21);
            this.cb1.TabIndex = 0;
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "BP",
            "INR",
            "SD",
            "JY",
            "CY",
            "GM",
            "USD"});
            this.cb2.Location = new System.Drawing.Point(12, 39);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(121, 21);
            this.cb2.TabIndex = 1;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(142, 43);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(0, 13);
            this.lblValue.TabIndex = 4;
            // 
            // txtCurrency1
            // 
            this.txtCurrency1.Location = new System.Drawing.Point(139, 12);
            this.txtCurrency1.Name = "txtCurrency1";
            this.txtCurrency1.Size = new System.Drawing.Size(121, 20);
            this.txtCurrency1.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 76);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // CurrencyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 110);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtCurrency1);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Name = "CurrencyConverterForm";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtCurrency1;
        private System.Windows.Forms.Button btnConvert;
    }
}

