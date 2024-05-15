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
            this.labelRadius = new System.Windows.Forms.Label();
            this.Radius = new System.Windows.Forms.TextBox();
            this.labelMeters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(18, 18);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(45, 15);
            this.labelRadius.TabIndex = 0;
            this.labelRadius.Text = "Радиус";
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(69, 15);
            this.Radius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(120, 23);
            this.Radius.TabIndex = 1;
            this.Radius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Radius_KeyPress);
            // 
            // labelMeters
            // 
            this.labelMeters.AutoSize = true;
            this.labelMeters.Location = new System.Drawing.Point(195, 18);
            this.labelMeters.Name = "labelMeters";
            this.labelMeters.Size = new System.Drawing.Size(16, 15);
            this.labelMeters.TabIndex = 2;
            this.labelMeters.Text = "м";
            // 
            // AddCircleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMeters);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.labelRadius);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCircleUserControl";
            this.Size = new System.Drawing.Size(219, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelRadius;
        private TextBox Radius;
        private Label labelMeters;
    }
}
