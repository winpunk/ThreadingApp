namespace ThreadingApp
{
    partial class ThreadingApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.threadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.mainListView = new System.Windows.Forms.ListView();
            this.ThreadId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GeneratedLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(61, 54);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // threadTextBox
            // 
            this.threadTextBox.Location = new System.Drawing.Point(90, 28);
            this.threadTextBox.MaxLength = 5;
            this.threadTextBox.Name = "threadTextBox";
            this.threadTextBox.Size = new System.Drawing.Size(100, 20);
            this.threadTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose number of threads (2-15):";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(142, 54);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // mainListView
            // 
            this.mainListView.AutoArrange = false;
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ThreadId,
            this.GeneratedLine});
            this.mainListView.FullRowSelect = true;
            this.mainListView.GridLines = true;
            this.mainListView.HideSelection = false;
            this.mainListView.Location = new System.Drawing.Point(12, 83);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(267, 423);
            this.mainListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mainListView.ListViewItemSorter = new Sorter();
            this.mainListView.TabIndex = 3;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            // 
            // ThreadId
            // 
            this.ThreadId.Tag = "Numeric";
            this.ThreadId.Text = "Thread ID";
            this.ThreadId.Width = 71;
            // 
            // GeneratedLine
            // 
            this.GeneratedLine.Text = "GeneratedLine";
            this.GeneratedLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GeneratedLine.Width = 170;
            // 
            // ThreadingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 518);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.mainListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.threadTextBox);
            this.Controls.Add(this.startButton);
            this.Name = "ThreadingApp";
            this.Text = "ThreadingApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox threadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.ColumnHeader ThreadId;
        private System.Windows.Forms.ColumnHeader GeneratedLine;
        private System.Windows.Forms.Button stopButton;
    }
}

