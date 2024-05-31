namespace ViewFigure
{
    partial class AddRectangleUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelSideA = new Label();
            labelSideB = new Label();
            SideA = new TextBox();
            SideB = new TextBox();
            labelMetersSideA = new Label();
            labelMetersSideB = new Label();
            SuspendLayout();
            // 
            // labelSideA
            // 
            labelSideA.AutoSize = true;
            labelSideA.Location = new Point(18, 15);
            labelSideA.Name = "labelSideA";
            labelSideA.Size = new Size(65, 15);
            labelSideA.TabIndex = 0;
            labelSideA.Text = "Сторона A";
            // 
            // labelSideB
            // 
            labelSideB.AutoSize = true;
            labelSideB.Location = new Point(18, 45);
            labelSideB.Name = "labelSideB";
            labelSideB.Size = new Size(64, 15);
            labelSideB.TabIndex = 1;
            labelSideB.Text = "Сторона В";
            // 
            // SideA
            // 
            SideA.Location = new Point(88, 12);
            SideA.Margin = new Padding(3, 2, 3, 2);
            SideA.Name = "SideA";
            SideA.Size = new Size(100, 23);
            SideA.TabIndex = 3;
            // 
            // SideB
            // 
            SideB.Location = new Point(88, 42);
            SideB.Margin = new Padding(3, 2, 3, 2);
            SideB.Name = "SideB";
            SideB.Size = new Size(100, 23);
            SideB.TabIndex = 4;
            // 
            // labelMetersSideA
            // 
            labelMetersSideA.AutoSize = true;
            labelMetersSideA.Location = new Point(194, 15);
            labelMetersSideA.Name = "labelMetersSideA";
            labelMetersSideA.Size = new Size(16, 15);
            labelMetersSideA.TabIndex = 6;
            labelMetersSideA.Text = "м";
            // 
            // labelMetersSideB
            // 
            labelMetersSideB.AutoSize = true;
            labelMetersSideB.Location = new Point(194, 45);
            labelMetersSideB.Name = "labelMetersSideB";
            labelMetersSideB.Size = new Size(16, 15);
            labelMetersSideB.TabIndex = 7;
            labelMetersSideB.Text = "м";
            // 
            // AddRectangleUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelMetersSideA);
            Controls.Add(labelMetersSideB);
            Controls.Add(SideA);
            Controls.Add(SideB);
            Controls.Add(labelSideA);
            Controls.Add(labelSideB);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddRectangleUserControl";
            Size = new Size(219, 105);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSideA;
        private Label labelSideB;
        private TextBox SideA;
        private TextBox SideB;
        private Label labelMetersSideA;
        private Label labelMetersSideB;
    }
}
