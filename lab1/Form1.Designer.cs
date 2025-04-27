namespace lab1
{
	partial class AsSort
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
            btnSort = new Button();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Location = new Point(61, 54);
            btnSort.Margin = new Padding(3, 4, 3, 4);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(86, 31);
            btnSort.TabIndex = 0;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += button1_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(194, 57);
            listBoxResults.Margin = new Padding(3, 4, 3, 4);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(655, 444);
            listBoxResults.TabIndex = 1;
            // 
            // AsSort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(listBoxResults);
            Controls.Add(btnSort);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AsSort";
            Text = "AsSort";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSort;
        private ListBox listBoxResults;
    }
}
