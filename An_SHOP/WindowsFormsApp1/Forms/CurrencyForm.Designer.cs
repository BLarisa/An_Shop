
namespace WindowsFormsApp1
{
    partial class CurrencyForm
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
            this.dollarLabel = new System.Windows.Forms.Label();
            this.euroLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dollarLabel
            // 
            this.dollarLabel.AutoSize = true;
            this.dollarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dollarLabel.Location = new System.Drawing.Point(12, 39);
            this.dollarLabel.Name = "dollarLabel";
            this.dollarLabel.Size = new System.Drawing.Size(93, 32);
            this.dollarLabel.TabIndex = 0;
            this.dollarLabel.Text = "label1";
            // 
            // euroLabel
            // 
            this.euroLabel.AutoSize = true;
            this.euroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.euroLabel.Location = new System.Drawing.Point(12, 85);
            this.euroLabel.Name = "euroLabel";
            this.euroLabel.Size = new System.Drawing.Size(93, 32);
            this.euroLabel.TabIndex = 1;
            this.euroLabel.Text = "label2";
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 163);
            this.Controls.Add(this.euroLabel);
            this.Controls.Add(this.dollarLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CurrencyForm";
            this.Text = "Курс валют";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dollarLabel;
        private System.Windows.Forms.Label euroLabel;
    }
}