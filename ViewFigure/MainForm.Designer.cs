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
            this.DeleteFigureButton = new System.Windows.Forms.Button();
            this.AddFigureButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CleanListButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.FilterButton = new System.Windows.Forms.Button();
            this.CleanFilterButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteFigureButton
            // 
            this.DeleteFigureButton.Location = new System.Drawing.Point(13, 255);
            this.DeleteFigureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteFigureButton.Name = "DeleteFigureButton";
            this.DeleteFigureButton.Size = new System.Drawing.Size(192, 22);
            this.DeleteFigureButton.TabIndex = 6;
            this.DeleteFigureButton.Text = "Удалить фигуру";
            this.DeleteFigureButton.UseVisualStyleBackColor = true;
            this.DeleteFigureButton.Click += new System.EventHandler(this.DeleteFigureButton_Click);
            // 
            // AddFigureButton
            // 
            this.AddFigureButton.Location = new System.Drawing.Point(13, 225);
            this.AddFigureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddFigureButton.Name = "AddFigureButton";
            this.AddFigureButton.Size = new System.Drawing.Size(192, 22);
            this.AddFigureButton.TabIndex = 5;
            this.AddFigureButton.Text = "Добавить фигуру";
            this.AddFigureButton.UseVisualStyleBackColor = true;
            this.AddFigureButton.Click += new System.EventHandler(this.AddFigureButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(443, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список фигур";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(428, 164);
            this.dataGridView1.TabIndex = 0;
            // 
            // CleanListButton
            // 
            this.CleanListButton.Location = new System.Drawing.Point(214, 225);
            this.CleanListButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CleanListButton.Name = "CleanListButton";
            this.CleanListButton.Size = new System.Drawing.Size(192, 22);
            this.CleanListButton.TabIndex = 7;
            this.CleanListButton.Text = "Очистить список";
            this.CleanListButton.UseVisualStyleBackColor = true;
            this.CleanListButton.Click += new System.EventHandler(this.CleanListButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(459, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFileToolStripMenuItem,
            this.OpenFileToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.SaveFileToolStripMenuItem.Text = "Сохранить файл";
            this.SaveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.OpenFileToolStripMenuItem.Text = "Открыть файл";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(214, 255);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(92, 22);
            this.FilterButton.TabIndex = 9;
            this.FilterButton.Text = "Фильтр";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // CleanFilterButton
            // 
            this.CleanFilterButton.Location = new System.Drawing.Point(315, 255);
            this.CleanFilterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CleanFilterButton.Name = "CleanFilterButton";
            this.CleanFilterButton.Size = new System.Drawing.Size(92, 22);
            this.CleanFilterButton.TabIndex = 10;
            this.CleanFilterButton.Text = "Сбросить";
            this.CleanFilterButton.UseVisualStyleBackColor = true;
            this.CleanFilterButton.Click += new System.EventHandler(this.CleanFilterButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(459, 287);
            this.Controls.Add(this.CleanFilterButton);
            this.Controls.Add(this.CleanListButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DeleteFigureButton);
            this.Controls.Add(this.AddFigureButton);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчёт площади фигур";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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