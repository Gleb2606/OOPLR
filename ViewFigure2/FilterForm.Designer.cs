namespace ViewFigure
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AreaCheckBox = new System.Windows.Forms.CheckBox();
            this.RectangleCheckBox = new System.Windows.Forms.CheckBox();
            this.TriangleCheckBox = new System.Windows.Forms.CheckBox();
            this.labelMeters = new System.Windows.Forms.Label();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.CircleCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AreaCheckBox);
            this.groupBox1.Controls.Add(this.RectangleCheckBox);
            this.groupBox1.Controls.Add(this.TriangleCheckBox);
            this.groupBox1.Controls.Add(this.labelMeters);
            this.groupBox1.Controls.Add(this.AreaTextBox);
            this.groupBox1.Controls.Add(this.CircleCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(188, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры фильтрации";
            // 
            // AreaCheckBox
            // 
            this.AreaCheckBox.AutoSize = true;
            this.AreaCheckBox.Location = new System.Drawing.Point(9, 88);
            this.AreaCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AreaCheckBox.Name = "AreaCheckBox";
            this.AreaCheckBox.Size = new System.Drawing.Size(78, 19);
            this.AreaCheckBox.TabIndex = 6;
            this.AreaCheckBox.Text = "Площадь";
            this.AreaCheckBox.UseVisualStyleBackColor = true;
            this.AreaCheckBox.CheckedChanged += new System.EventHandler(this.AreaCheckBox_CheckedChanged);
            // 
            // RectangleCheckBox
            // 
            this.RectangleCheckBox.AutoSize = true;
            this.RectangleCheckBox.Location = new System.Drawing.Point(9, 65);
            this.RectangleCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleCheckBox.Name = "RectangleCheckBox";
            this.RectangleCheckBox.Size = new System.Drawing.Size(115, 19);
            this.RectangleCheckBox.TabIndex = 5;
            this.RectangleCheckBox.Text = "Прямоугольник";
            this.RectangleCheckBox.UseVisualStyleBackColor = true;
            // 
            // TriangleCheckBox
            // 
            this.TriangleCheckBox.AutoSize = true;
            this.TriangleCheckBox.Location = new System.Drawing.Point(9, 42);
            this.TriangleCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TriangleCheckBox.Name = "TriangleCheckBox";
            this.TriangleCheckBox.Size = new System.Drawing.Size(96, 19);
            this.TriangleCheckBox.TabIndex = 4;
            this.TriangleCheckBox.Text = "Треугольник";
            this.TriangleCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelMeters
            // 
            this.labelMeters.AutoSize = true;
            this.labelMeters.Location = new System.Drawing.Point(165, 92);
            this.labelMeters.Name = "labelMeters";
            this.labelMeters.Size = new System.Drawing.Size(16, 15);
            this.labelMeters.TabIndex = 3;
            this.labelMeters.Text = "м";
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(87, 88);
            this.AreaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(72, 23);
            this.AreaTextBox.TabIndex = 2;
            this.AreaTextBox.TextChanged += new System.EventHandler(this.AreaTextBox_TextChanged);
            this.AreaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AreaTextBox_KeyPress);
            // 
            // CircleCheckBox
            // 
            this.CircleCheckBox.AutoSize = true;
            this.CircleCheckBox.Location = new System.Drawing.Point(9, 20);
            this.CircleCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CircleCheckBox.Name = "CircleCheckBox";
            this.CircleCheckBox.Size = new System.Drawing.Size(51, 19);
            this.CircleCheckBox.TabIndex = 1;
            this.CircleCheckBox.Text = "Круг";
            this.CircleCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(18, 131);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(175, 22);
            this.FilterButton.TabIndex = 1;
            this.FilterButton.Text = "Отфильтровать";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(212, 160);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FilterForm";
            this.Text = "Фильтр";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label labelMeters;
        private TextBox AreaTextBox;
        private CheckBox CircleCheckBox;
        private Button FilterButton;
        private CheckBox AreaCheckBox;
        private CheckBox RectangleCheckBox;
        private CheckBox TriangleCheckBox;
    }
}