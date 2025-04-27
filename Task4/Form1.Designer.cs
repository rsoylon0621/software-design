namespace Task4
{
    partial class DesSort
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
            btnSort.Location = new Point(31, 44);
            btnSort.Margin = new Padding(3, 4, 3, 4);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(123, 49);
            btnSort.TabIndex = 0;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(205, 44);
            listBoxResults.Margin = new Padding(3, 4, 3, 4);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(631, 384);
            listBoxResults.TabIndex = 1;
            // 
            // DesSort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(listBoxResults);
            Controls.Add(btnSort);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DesSort";
            Text = "DesSort";
            Load += DesSort_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSort;
        private ListBox listBoxResults;
    }
}
