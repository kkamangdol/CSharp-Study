namespace HelloCSharpWin
{
    partial class Calculator
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
            this.HelloLabel = new System.Windows.Forms.Label();
            this.Sum1 = new System.Windows.Forms.TextBox();
            this.Sum2 = new System.Windows.Forms.TextBox();
            this.SumNumbers = new System.Windows.Forms.Button();
            this.SumResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelloLabel.Location = new System.Drawing.Point(439, 290);
            this.HelloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(107, 15);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "여기를 클릭하세요";
            this.HelloLabel.Click += new System.EventHandler(this.HelloLabel_Click);
            // 
            // Sum1
            // 
            this.Sum1.Location = new System.Drawing.Point(439, 351);
            this.Sum1.Name = "Sum1";
            this.Sum1.Size = new System.Drawing.Size(100, 23);
            this.Sum1.TabIndex = 1;
            // 
            // Sum2
            // 
            this.Sum2.Location = new System.Drawing.Point(574, 351);
            this.Sum2.Name = "Sum2";
            this.Sum2.Size = new System.Drawing.Size(100, 23);
            this.Sum2.TabIndex = 2;
            // 
            // SumNumbers
            // 
            this.SumNumbers.Location = new System.Drawing.Point(713, 351);
            this.SumNumbers.Name = "SumNumbers";
            this.SumNumbers.Size = new System.Drawing.Size(75, 23);
            this.SumNumbers.TabIndex = 3;
            this.SumNumbers.Text = "=";
            this.SumNumbers.UseVisualStyleBackColor = true;
            this.SumNumbers.Click += new System.EventHandler(this.SumNumbers_Click);
            // 
            // SumResult
            // 
            this.SumResult.Location = new System.Drawing.Point(814, 351);
            this.SumResult.Name = "SumResult";
            this.SumResult.Size = new System.Drawing.Size(100, 23);
            this.SumResult.TabIndex = 4;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 731);
            this.Controls.Add(this.SumResult);
            this.Controls.Add(this.SumNumbers);
            this.Controls.Add(this.Sum2);
            this.Controls.Add(this.Sum1);
            this.Controls.Add(this.HelloLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HelloLabel;
        private TextBox Sum1;
        private TextBox Sum2;
        private Button SumNumbers;
        private TextBox SumResult;
    }
}