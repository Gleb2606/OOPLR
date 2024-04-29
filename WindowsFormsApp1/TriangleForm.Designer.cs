namespace WindowsFormsApp1
{
    partial class TriangleForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangleForm));
            this.textBoxsideA = new System.Windows.Forms.TextBox();
            this.textBoxHeightA = new System.Windows.Forms.TextBox();
            this.buttonArea = new System.Windows.Forms.Button();
            this.labelSideA = new System.Windows.Forms.Label();
            this.labelHeightA = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxsideA
            // 
            this.textBoxsideA.Location = new System.Drawing.Point(6, 12);
            this.textBoxsideA.Name = "textBoxsideA";
            this.textBoxsideA.Size = new System.Drawing.Size(157, 20);
            this.textBoxsideA.TabIndex = 0;
            // 
            // textBoxHeightA
            // 
            this.textBoxHeightA.Location = new System.Drawing.Point(6, 49);
            this.textBoxHeightA.Name = "textBoxHeightA";
            this.textBoxHeightA.Size = new System.Drawing.Size(157, 20);
            this.textBoxHeightA.TabIndex = 1;
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(262, 12);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(106, 57);
            this.buttonArea.TabIndex = 2;
            this.buttonArea.Text = "Расчет площади";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSideA
            // 
            this.labelSideA.AutoSize = true;
            this.labelSideA.Location = new System.Drawing.Point(169, 15);
            this.labelSideA.Name = "labelSideA";
            this.labelSideA.Size = new System.Drawing.Size(59, 13);
            this.labelSideA.TabIndex = 3;
            this.labelSideA.Text = "Сторона А";
            // 
            // labelHeightA
            // 
            this.labelHeightA.AutoSize = true;
            this.labelHeightA.Location = new System.Drawing.Point(169, 52);
            this.labelHeightA.Name = "labelHeightA";
            this.labelHeightA.Size = new System.Drawing.Size(55, 13);
            this.labelHeightA.TabIndex = 4;
            this.labelHeightA.Text = "Высота А";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "triangle.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WindowsFormsApp1.Properties.Resources.triangle;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.triangle;
            this.pictureBox1.InitialImage = global::WindowsFormsApp1.Properties.Resources.triangle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(380, 288);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHeightA);
            this.Controls.Add(this.labelSideA);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.textBoxHeightA);
            this.Controls.Add(this.textBoxsideA);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TriangleForm";
            this.Text = "Расчет площади трегольника";
            this.Load += new System.EventHandler(this.TriangleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxsideA;
        private System.Windows.Forms.TextBox textBoxHeightA;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Label labelSideA;
        private System.Windows.Forms.Label labelHeightA;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

