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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
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
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры фильтрации";
            // 
            // AreaCheckBox
            // 
            this.AreaCheckBox.AutoSize = true;
            this.AreaCheckBox.Location = new System.Drawing.Point(10, 118);
            this.AreaCheckBox.Name = "AreaCheckBox";
            this.AreaCheckBox.Size = new System.Drawing.Size(79, 24);
            this.AreaCheckBox.TabIndex = 6;
            this.AreaCheckBox.Text = "Площадь";
            this.AreaCheckBox.UseVisualStyleBackColor = true;
            this.AreaCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxVolume_CheckedChanged);
            // 
            // RectangleCheckBox
            // 
            this.RectangleCheckBox.AutoSize = true;
            this.RectangleCheckBox.Location = new System.Drawing.Point(10, 87);
            this.RectangleCheckBox.Name = "RectangleCheckBox";
            this.RectangleCheckBox.Size = new System.Drawing.Size(150, 24);
            this.RectangleCheckBox.TabIndex = 5;
            this.RectangleCheckBox.Text = "Прямоугольник";
            this.RectangleCheckBox.UseVisualStyleBackColor = true;
            // 
            // TriangleCheckBox
            // 
            this.TriangleCheckBox.AutoSize = true;
            this.TriangleCheckBox.Location = new System.Drawing.Point(10, 56);
            this.TriangleCheckBox.Name = "TriangleCheckBox";
            this.TriangleCheckBox.Size = new System.Drawing.Size(104, 24);
            this.TriangleCheckBox.TabIndex = 4;
            this.TriangleCheckBox.Text = "Треугольник";
            this.TriangleCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelMeters
            // 
            this.labelMeters.AutoSize = true;
            this.labelMeters.Location = new System.Drawing.Point(160, 119);
            this.labelMeters.Name = "labelMeters";
            this.labelMeters.Size = new System.Drawing.Size(20, 20);
            this.labelMeters.TabIndex = 3;
            this.labelMeters.Text = "м";
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(99, 115);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(60, 27);
            this.AreaTextBox.TabIndex = 2;
            this.AreaTextBox.TextChanged += new System.EventHandler(this.textBoxVolume_TextChanged);
            this.AreaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVolume_KeyPress);
            // 
            // CircleCheckBox
            // 
            this.CircleCheckBox.AutoSize = true;
            this.CircleCheckBox.Location = new System.Drawing.Point(10, 26);
            this.CircleCheckBox.Name = "CircleCheckBox";
            this.CircleCheckBox.Size = new System.Drawing.Size(62, 24);
            this.CircleCheckBox.TabIndex = 1;
            this.CircleCheckBox.Text = "Круг";
            this.CircleCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(20, 175);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(200, 30);
            this.FilterButton.TabIndex = 1;
            this.FilterButton.Text = "Отфильтровать";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(242, 213);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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