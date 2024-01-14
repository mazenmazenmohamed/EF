namespace WinEF
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
            grdViewEmployee = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            Add = new Button();
            SearchBox = new TextBox();
            Search = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)grdViewEmployee).BeginInit();
            SuspendLayout();
            // 
            // grdViewEmployee
            // 
            grdViewEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdViewEmployee.Location = new Point(0, 4);
            grdViewEmployee.Name = "grdViewEmployee";
            grdViewEmployee.RowHeadersWidth = 51;
            grdViewEmployee.Size = new Size(800, 446);
            grdViewEmployee.TabIndex = 0;
            grdViewEmployee.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(706, 456);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SavebtnClick;
            // 
            // button2
            // 
            button2.Location = new Point(606, 457);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Delete_Click;
            // 
            // Add
            // 
            Add.Location = new Point(506, 457);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 3;
            Add.Text = "Sort";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Sort_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(12, 459);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(165, 27);
            SearchBox.TabIndex = 4;
            SearchBox.Text = "Insert   ID   To   Search";
            // 
            // Search
            // 
            Search.Location = new Point(183, 457);
            Search.Name = "Search";
            Search.Size = new Size(94, 29);
            Search.TabIndex = 5;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // button3
            // 
            button3.Location = new Point(406, 458);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "Load";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Load_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 488);
            Controls.Add(button3);
            Controls.Add(Search);
            Controls.Add(SearchBox);
            Controls.Add(Add);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(grdViewEmployee);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grdViewEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdViewEmployee;
        private Button button1;
        private Button button2;
        private Button Add;
        private TextBox SearchBox;
        private Button Search;
        private Button button3;
    }
}