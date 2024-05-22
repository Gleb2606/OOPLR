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
            this.labelSideA = new System.Windows.Forms.Label();
            this.labelSideB = new System.Windows.Forms.Label();
            this.SideA = new System.Windows.Forms.TextBox();
            this.SideB = new System.Windows.Forms.TextBox();
            this.labelMetersSideA = new System.Windows.Forms.Label();
            this.labelMetersSideB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSideA
            // 
            this.labelSideA.AutoSize = true;
            this.labelSideA.Location = new System.Drawing.Point(18, 15);
            this.labelSideA.Name = "labelSideA";
            this.labelSideA.Size = new System.Drawing.Size(65, 15);
            this.labelSideA.TabIndex = 0;
            this.labelSideA.Text = "Сторона A";
            // 
            // labelSideB
            // 
            this.labelSideB.AutoSize = true;
            this.labelSideB.Location = new System.Drawing.Point(18, 45);
            this.labelSideB.Name = "labelSideB";
            this.labelSideB.Size = new System.Drawing.Size(64, 15);
            this.labelSideB.TabIndex = 1;
            this.labelSideB.Text = "Сторона В";
            // 
            // SideA
            // 
            this.SideA.Location = new System.Drawing.Point(89, 15);
            this.SideA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SideA.Name = "SideA";
            this.SideA.Size = new System.Drawing.Size(100, 23);
            this.SideA.TabIndex = 3;
            this.SideA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SideA_KeyPress);
            // 
            // SideB
            // 
            this.SideB.Location = new System.Drawing.Point(88, 45);
            this.SideB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SideB.Name = "SideB";
            this.SideB.Size = new System.Drawing.Size(101, 23);
            this.SideB.TabIndex = 4;
            this.SideB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SideB_KeyPress);
            // 
            // labelMetersSideA
            // 
            this.labelMetersSideA.AutoSize = true;
            this.labelMetersSideA.Location = new System.Drawing.Point(192, 18);
            this.labelMetersSideA.Name = "labelMetersSideA";
            this.labelMetersSideA.Size = new System.Drawing.Size(16, 15);
            this.labelMetersSideA.TabIndex = 6;
            this.labelMetersSideA.Text = "м";
            // 
            // labelMetersSideB
            // 
            this.labelMetersSideB.AutoSize = true;
            this.labelMetersSideB.Location = new System.Drawing.Point(192, 48);
            this.labelMetersSideB.Name = "labelMetersSideB";
            this.labelMetersSideB.Size = new System.Drawing.Size(16, 15);
            this.labelMetersSideB.TabIndex = 7;
            this.labelMetersSideB.Text = "м";
            // 
            // AddRectangleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMetersSideA);
            this.Controls.Add(this.labelMetersSideB);
            this.Controls.Add(this.SideA);
            this.Controls.Add(this.SideB);
            this.Controls.Add(this.labelSideA);
            this.Controls.Add(this.labelSideB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddRectangleUserControl";
            this.Size = new System.Drawing.Size(219, 105);
            this.ResumeLayout(false);
            this.PerformLayout();

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
