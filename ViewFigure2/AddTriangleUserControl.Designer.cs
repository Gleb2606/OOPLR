namespace ViewFigure
{
    partial class AddTriangleUserControl
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
            this.labelHeightA = new System.Windows.Forms.Label();
            this.HeightA = new System.Windows.Forms.TextBox();
            this.SideA = new System.Windows.Forms.TextBox();
            this.labelMetersSideA = new System.Windows.Forms.Label();
            this.labelMetersHeightA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSideA
            // 
            this.labelSideA.AutoSize = true;
            this.labelSideA.Location = new System.Drawing.Point(3, 18);
            this.labelSideA.Name = "labelSideA";
            this.labelSideA.Size = new System.Drawing.Size(65, 15);
            this.labelSideA.TabIndex = 0;
            this.labelSideA.Text = "Сторона А";
            // 
            // labelHeightA
            // 
            this.labelHeightA.AutoSize = true;
            this.labelHeightA.Location = new System.Drawing.Point(8, 51);
            this.labelHeightA.Name = "labelHeightA";
            this.labelHeightA.Size = new System.Drawing.Size(58, 15);
            this.labelHeightA.TabIndex = 1;
            this.labelHeightA.Text = "Высота А";
            // 
            // HeightA
            // 
            this.HeightA.Location = new System.Drawing.Point(79, 15);
            this.HeightA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeightA.Name = "HeightA";
            this.HeightA.Size = new System.Drawing.Size(110, 23);
            this.HeightA.TabIndex = 2;
            this.HeightA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightA_KeyPress);
            // 
            // SideA
            // 
            this.SideA.Location = new System.Drawing.Point(79, 48);
            this.SideA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SideA.Name = "SideA";
            this.SideA.Size = new System.Drawing.Size(110, 23);
            this.SideA.TabIndex = 3;
            this.SideA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SideA_KeyPress);
            // 
            // labelMetersSideA
            // 
            this.labelMetersSideA.AutoSize = true;
            this.labelMetersSideA.Location = new System.Drawing.Point(192, 15);
            this.labelMetersSideA.Name = "labelMetersSideA";
            this.labelMetersSideA.Size = new System.Drawing.Size(16, 15);
            this.labelMetersSideA.TabIndex = 4;
            this.labelMetersSideA.Text = "м";
            // 
            // labelMetersHeightA
            // 
            this.labelMetersHeightA.AutoSize = true;
            this.labelMetersHeightA.Location = new System.Drawing.Point(192, 48);
            this.labelMetersHeightA.Name = "labelMetersHeightA";
            this.labelMetersHeightA.Size = new System.Drawing.Size(16, 15);
            this.labelMetersHeightA.TabIndex = 5;
            this.labelMetersHeightA.Text = "м";
            // 
            // AddTriangleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelHeightA);
            this.Controls.Add(this.labelSideA);
            this.Controls.Add(this.SideA);
            this.Controls.Add(this.HeightA);
            this.Controls.Add(this.labelMetersSideA);
            this.Controls.Add(this.labelMetersHeightA);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTriangleUserControl";
            this.Size = new System.Drawing.Size(219, 105);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSideA;
        private Label labelHeightA;
        private TextBox SideA;
        private TextBox HeightA;
        private Label labelMetersSideA;
        private Label labelMetersHeightA;
    }
}
