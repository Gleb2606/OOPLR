namespace ViewFigure
{
    partial class MainForm
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
            DeleteFigureButton = new Button();
            AddFigureButton = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            CleanListButton = new Button();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            SaveFileToolStripMenuItem = new ToolStripMenuItem();
            OpenFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripButton();
            FilterButton = new Button();
            CleanFilterButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteFigureButton
            // 
            DeleteFigureButton.Location = new Point(13, 255);
            DeleteFigureButton.Margin = new Padding(3, 2, 3, 2);
            DeleteFigureButton.Name = "DeleteFigureButton";
            DeleteFigureButton.Size = new Size(192, 22);
            DeleteFigureButton.TabIndex = 6;
            DeleteFigureButton.Text = "Удалить фигуру";
            DeleteFigureButton.UseVisualStyleBackColor = true;
            DeleteFigureButton.Click += DeleteFigureButton_Click;
            // 
            // AddFigureButton
            // 
            AddFigureButton.Location = new Point(13, 225);
            AddFigureButton.Margin = new Padding(3, 2, 3, 2);
            AddFigureButton.Name = "AddFigureButton";
            AddFigureButton.Size = new Size(231, 22);
            AddFigureButton.TabIndex = 5;
            AddFigureButton.Text = "Добавить фигуру";
            AddFigureButton.UseVisualStyleBackColor = true;
            AddFigureButton.Click += AddFigureButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(4, 30);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(463, 188);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список фигур";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 20);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(448, 164);
            dataGridView1.TabIndex = 0;
            // 
            // CleanListButton
            // 
            CleanListButton.Location = new Point(250, 225);
            CleanListButton.Margin = new Padding(3, 2, 3, 2);
            CleanListButton.Name = "CleanListButton";
            CleanListButton.Size = new Size(215, 22);
            CleanListButton.TabIndex = 7;
            CleanListButton.Text = "Очистить список";
            CleanListButton.UseVisualStyleBackColor = true;
            CleanListButton.Click += CleanListButton_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(479, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { SaveFileToolStripMenuItem, OpenFileToolStripMenuItem });
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(49, 22);
            toolStripDropDownButton1.Text = "Файл";
            // 
            // SaveFileToolStripMenuItem
            // 
            SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            SaveFileToolStripMenuItem.Size = new Size(165, 22);
            SaveFileToolStripMenuItem.Text = "Сохранить файл";
            SaveFileToolStripMenuItem.Click += SaveFileToolStripMenuItem_Click;
            // 
            // OpenFileToolStripMenuItem
            // 
            OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            OpenFileToolStripMenuItem.Size = new Size(165, 22);
            OpenFileToolStripMenuItem.Text = "Открыть файл";
            OpenFileToolStripMenuItem.Click += OpenFileToolStripMenuItem_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(211, 255);
            FilterButton.Margin = new Padding(3, 2, 3, 2);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(101, 22);
            FilterButton.TabIndex = 9;
            FilterButton.Text = "Фильтр";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // CleanFilterButton
            // 
            CleanFilterButton.Location = new Point(318, 255);
            CleanFilterButton.Margin = new Padding(3, 2, 3, 2);
            CleanFilterButton.Name = "CleanFilterButton";
            CleanFilterButton.Size = new Size(147, 22);
            CleanFilterButton.TabIndex = 10;
            CleanFilterButton.Text = "Сбросить";
            CleanFilterButton.UseVisualStyleBackColor = true;
            CleanFilterButton.Click += CleanFilterButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(479, 287);
            Controls.Add(CleanFilterButton);
            Controls.Add(CleanListButton);
            Controls.Add(FilterButton);
            Controls.Add(toolStrip1);
            Controls.Add(DeleteFigureButton);
            Controls.Add(AddFigureButton);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Расчёт площади фигур";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteFigureButton;
        private Button AddFigureButton;
        private GroupBox groupBox1;
        public DataGridView dataGridView1;
        private Button CleanListButton;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem SaveFileToolStripMenuItem;
        private ToolStripMenuItem OpenFileToolStripMenuItem;
        private Button FilterButton;
        private Button CleanFilterButton;
        private ToolStripButton toolStripButton1;

    }
}