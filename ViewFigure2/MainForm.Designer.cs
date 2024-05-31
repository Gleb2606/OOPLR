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
            groupBox = new GroupBox();
            dataGridView = new DataGridView();
            CleanListButton = new Button();
            toolStrip = new ToolStrip();
            toolStripDropDownButton = new ToolStripDropDownButton();
            SaveFileToolStripMenuItem = new ToolStripMenuItem();
            OpenFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton = new ToolStripButton();
            FilterButton = new Button();
            CleanFilterButton = new Button();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteFigureButton
            // 
            DeleteFigureButton.Location = new Point(13, 251);
            DeleteFigureButton.Margin = new Padding(3, 2, 3, 2);
            DeleteFigureButton.Name = "DeleteFigureButton";
            DeleteFigureButton.Size = new Size(151, 22);
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
            groupBox.BackColor = SystemColors.ControlLightLight;
            groupBox.Controls.Add(dataGridView);
            groupBox.Location = new Point(4, 30);
            groupBox.Margin = new Padding(3, 2, 3, 2);
            groupBox.Name = "groupBox1";
            groupBox.Padding = new Padding(3, 2, 3, 2);
            groupBox.Size = new Size(463, 188);
            groupBox.TabIndex = 4;
            groupBox.TabStop = false;
            groupBox.Text = "Список фигур";
            // 
            // dataGridView1
            // 
            dataGridView.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(9, 20);
            dataGridView.Margin = new Padding(3, 2, 3, 2);
            dataGridView.Name = "dataGridView1";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(448, 164);
            dataGridView.TabIndex = 0;
            // 
            // CleanListButton
            // 
            CleanListButton.Location = new Point(250, 225);
            CleanListButton.Margin = new Padding(3, 2, 3, 2);
            CleanListButton.Name = "CleanListButton";
            CleanListButton.Size = new Size(217, 22);
            CleanListButton.TabIndex = 7;
            CleanListButton.Text = "Очистить список";
            CleanListButton.UseVisualStyleBackColor = true;
            CleanListButton.Click += CleanListButton_Click;
            // 
            // toolStrip1
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton, toolStripButton });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip1";
            toolStrip.Size = new Size(473, 25);
            toolStrip.TabIndex = 8;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { SaveFileToolStripMenuItem, OpenFileToolStripMenuItem });
            toolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton.Name = "toolStripDropDownButton1";
            toolStripDropDownButton.Size = new Size(49, 22);
            toolStripDropDownButton.Text = "Файл";
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
            toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton.ImageTransparentColor = Color.Magenta;
            toolStripButton.Name = "toolStripButton1";
            toolStripButton.Size = new Size(23, 22);
            toolStripButton.Text = "toolStripButton1";
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(170, 251);
            FilterButton.Margin = new Padding(3, 2, 3, 2);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(151, 22);
            FilterButton.TabIndex = 9;
            FilterButton.Text = "Фильтр";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // CleanFilterButton
            // 
            CleanFilterButton.Location = new Point(323, 251);
            CleanFilterButton.Margin = new Padding(3, 2, 3, 2);
            CleanFilterButton.Name = "CleanFilterButton";
            CleanFilterButton.Size = new Size(144, 22);
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
            ClientSize = new Size(473, 281);
            Controls.Add(CleanFilterButton);
            Controls.Add(CleanListButton);
            Controls.Add(FilterButton);
            Controls.Add(toolStrip);
            Controls.Add(DeleteFigureButton);
            Controls.Add(AddFigureButton);
            Controls.Add(groupBox);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Расчёт площади фигур";
            Load += Form1_Load;
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteFigureButton;
        private Button AddFigureButton;
        private GroupBox groupBox;
        public DataGridView dataGridView;
        private Button CleanListButton;
        private ToolStrip toolStrip;
        private ToolStripDropDownButton toolStripDropDownButton;
        private ToolStripMenuItem SaveFileToolStripMenuItem;
        private ToolStripMenuItem OpenFileToolStripMenuItem;
        private Button FilterButton;
        private Button CleanFilterButton;
        private ToolStripButton toolStripButton;

    }
}