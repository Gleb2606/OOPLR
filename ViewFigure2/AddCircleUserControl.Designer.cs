namespace ViewFigure
{
    partial class AddCircleUserControl
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
            labelRadius = new Label();
            Radius = new TextBox();
            labelMeters = new Label();
            SuspendLayout();
            // 
            // labelRadius
            // 
            labelRadius.AutoSize = true;
            labelRadius.Location = new Point(18, 15);
            labelRadius.Name = "labelRadius";
            labelRadius.Size = new Size(65, 15);
            labelRadius.TabIndex = 0;
            labelRadius.Text = "Радиус";
            // 
            // Radius
            // 
            Radius.Location = new Point(88, 12);
            Radius.Margin = new Padding(3, 2, 3, 2);
            Radius.Name = "Radius";
            Radius.Size = new Size(100, 23);
            Radius.TabIndex = 1;
            // 
            // labelMeters
            // 
            labelMeters.AutoSize = true;
            labelMeters.Location = new Point(194, 15);
            labelMeters.Name = "labelMeters";
            labelMeters.Size = new Size(16, 15);
            labelMeters.TabIndex = 2;
            labelMeters.Text = "м";
            // 
            // AddCircleUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelMeters);
            Controls.Add(Radius);
            Controls.Add(labelRadius);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddCircleUserControl";
            Size = new Size(219, 45);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRadius;
        private TextBox Radius;
        private Label labelMeters;
    }
}
