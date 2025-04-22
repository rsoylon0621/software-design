namespace lab2
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
            buttonCalculateFactorial = new Button();
            lblResult = new Label();
            txtInput = new TextBox();
            btnCalculateSum = new Button();
            txtArrayInput = new TextBox();
            lblSumResult = new Label();
            SuspendLayout();
            // 
            // buttonCalculateFactorial
            // 
            buttonCalculateFactorial.Location = new Point(331, 273);
            buttonCalculateFactorial.Name = "buttonCalculateFactorial";
            buttonCalculateFactorial.Size = new Size(178, 39);
            buttonCalculateFactorial.TabIndex = 0;
            buttonCalculateFactorial.Text = "Calculate Factorial";
            buttonCalculateFactorial.UseVisualStyleBackColor = true;
            buttonCalculateFactorial.Click += button1_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(243, 218);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(57, 25);
            lblResult.TabIndex = 2;
            lblResult.Text = "Label";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(243, 156);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 33);
            txtInput.TabIndex = 3;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(331, 345);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(178, 39);
            btnCalculateSum.TabIndex = 4;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(411, 156);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(100, 33);
            txtArrayInput.TabIndex = 5;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(411, 218);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(63, 25);
            lblSumResult.TabIndex = 6;
            lblSumResult.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSumResult);
            Controls.Add(txtArrayInput);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Controls.Add(buttonCalculateFactorial);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalculateFactorial;
        private Label lblResult;
        private TextBox txtInput;
        private Button btnCalculateSum;
        private TextBox txtArrayInput;
        private Label lblSumResult;
    }
}
