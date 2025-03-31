namespace Task4
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
            btnSort_Click = new Button();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // btnSort_Click
            // 
            btnSort_Click.Location = new Point(27, 33);
            btnSort_Click.Name = "btnSort_Click";
            btnSort_Click.Size = new Size(108, 37);
            btnSort_Click.TabIndex = 0;
            btnSort_Click.Text = "button1";
            btnSort_Click.UseVisualStyleBackColor = true;
            btnSort_Click.Click += btnSort_Click_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(179, 33);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(553, 289);
            listBoxResults.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResults);
            Controls.Add(btnSort_Click);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSort_Click;
        private ListBox listBoxResults;
    }
}
