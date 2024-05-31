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
            groupBox = new GroupBox();
            AreaCheckBox = new CheckBox();
            RectangleCheckBox = new CheckBox();
            TriangleCheckBox = new CheckBox();
            labelMeters = new Label();
            AreaTextBox = new TextBox();
            CircleCheckBox = new CheckBox();
            FilterButton = new Button();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(AreaCheckBox);
            groupBox.Controls.Add(RectangleCheckBox);
            groupBox.Controls.Add(TriangleCheckBox);
            groupBox.Controls.Add(labelMeters);
            groupBox.Controls.Add(AreaTextBox);
            groupBox.Controls.Add(CircleCheckBox);
            groupBox.Location = new Point(12, 11);
            groupBox.Margin = new Padding(3, 2, 3, 2);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(3, 2, 3, 2);
            groupBox.Size = new Size(188, 116);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Параметры фильтрации";
            // 
            // AreaCheckBox
            // 
            AreaCheckBox.AutoSize = true;
            AreaCheckBox.Location = new Point(9, 88);
            AreaCheckBox.Margin = new Padding(3, 2, 3, 2);
            AreaCheckBox.Name = "AreaCheckBox";
            AreaCheckBox.Size = new Size(78, 19);
            AreaCheckBox.TabIndex = 6;
            AreaCheckBox.Text = "Площадь";
            AreaCheckBox.UseVisualStyleBackColor = true;
            AreaCheckBox.CheckedChanged += AreaCheckBox_CheckedChanged;
            // 
            // RectangleCheckBox
            // 
            RectangleCheckBox.AutoSize = true;
            RectangleCheckBox.Location = new Point(9, 65);
            RectangleCheckBox.Margin = new Padding(3, 2, 3, 2);
            RectangleCheckBox.Name = "RectangleCheckBox";
            RectangleCheckBox.Size = new Size(115, 19);
            RectangleCheckBox.TabIndex = 5;
            RectangleCheckBox.Text = "Прямоугольник";
            RectangleCheckBox.UseVisualStyleBackColor = true;
            // 
            // TriangleCheckBox
            // 
            TriangleCheckBox.AutoSize = true;
            TriangleCheckBox.Location = new Point(9, 42);
            TriangleCheckBox.Margin = new Padding(3, 2, 3, 2);
            TriangleCheckBox.Name = "TriangleCheckBox";
            TriangleCheckBox.Size = new Size(96, 19);
            TriangleCheckBox.TabIndex = 4;
            TriangleCheckBox.Text = "Треугольник";
            TriangleCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelMeters
            // 
            labelMeters.AutoSize = true;
            labelMeters.Location = new Point(165, 92);
            labelMeters.Name = "labelMeters";
            labelMeters.Size = new Size(16, 15);
            labelMeters.TabIndex = 3;
            labelMeters.Text = "м";
            // 
            // AreaTextBox
            // 
            AreaTextBox.Location = new Point(87, 88);
            AreaTextBox.Margin = new Padding(3, 2, 3, 2);
            AreaTextBox.Name = "AreaTextBox";
            AreaTextBox.Size = new Size(72, 23);
            AreaTextBox.TabIndex = 2;
            AreaTextBox.TextChanged += AreaTextBox_TextChanged;
            AreaTextBox.KeyPress += AreaTextBox_KeyPress;
            // 
            // CircleCheckBox
            // 
            CircleCheckBox.AutoSize = true;
            CircleCheckBox.Location = new Point(9, 20);
            CircleCheckBox.Margin = new Padding(3, 2, 3, 2);
            CircleCheckBox.Name = "CircleCheckBox";
            CircleCheckBox.Size = new Size(51, 19);
            CircleCheckBox.TabIndex = 1;
            CircleCheckBox.Text = "Круг";
            CircleCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(12, 131);
            FilterButton.Margin = new Padding(3, 2, 3, 2);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(188, 22);
            FilterButton.TabIndex = 1;
            FilterButton.Text = "Отфильтровать";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += ButtonFilter_Click;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(212, 160);
            Controls.Add(FilterButton);
            Controls.Add(groupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FilterForm";
            Text = "Фильтр";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Label labelMeters;
        private TextBox AreaTextBox;
        private CheckBox CircleCheckBox;
        private Button FilterButton;
        private CheckBox AreaCheckBox;
        private CheckBox RectangleCheckBox;
        private CheckBox TriangleCheckBox;
    }
}