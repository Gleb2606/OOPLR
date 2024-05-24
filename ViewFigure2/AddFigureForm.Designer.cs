namespace ViewFigure
{
    partial class AddFigureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFigureForm));
            this.Random = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.comboBoxFigures = new System.Windows.Forms.ComboBox();
            this.labelChoose = new System.Windows.Forms.Label();
            this.addCircleUserControl = new ViewFigure.AddCircleUserControl();
            this.addRectangleUserControl = new ViewFigure.AddRectangleUserControl();
            this.addTriangleUserControl = new ViewFigure.AddTriangleUserControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(180, 50);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(140, 30);
            this.Random.TabIndex = 26;
            this.Random.Text = "Случайная фигура";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(180, 280);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(140, 30);
            this.Cancel.TabIndex = 25;
            this.Cancel.Text = "Отменить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(20, 280);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(140, 30);
            this.OK.TabIndex = 23;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // comboBoxFigures
            // 
            this.comboBoxFigures.FormattingEnabled = true;
            this.comboBoxFigures.Location = new System.Drawing.Point(20, 52);
            this.comboBoxFigures.Name = "comboBoxFigures";
            this.comboBoxFigures.Size = new System.Drawing.Size(140, 28);
            this.comboBoxFigures.TabIndex = 22;
            this.comboBoxFigures.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigeres_SelectedIndexChanged);
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Location = new System.Drawing.Point(20, 20);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(129, 20);
            this.labelChoose.TabIndex = 21;
            this.labelChoose.Text = "Выберите фигуру";
            // 
            // addCircleUserControl
            // 
            this.addCircleUserControl.Location = new System.Drawing.Point(20, 20);
            this.addCircleUserControl.Name = "addCircleUserControl";
            this.addCircleUserControl.Size = new System.Drawing.Size(244, 58);
            this.addCircleUserControl.TabIndex = 27;
            // 
            // addRectangleUserControl
            // 
            this.addRectangleUserControl.Location = new System.Drawing.Point(20, 20);
            this.addRectangleUserControl.Name = "addRectangleUserControl";
            this.addRectangleUserControl.Size = new System.Drawing.Size(252, 144);
            this.addRectangleUserControl.TabIndex = 28;
            // 
            // addTriangleUserControl
            // 
            this.addTriangleUserControl.Location = new System.Drawing.Point(20, 20);
            this.addTriangleUserControl.Name = "addTriangleUserControl";
            this.addTriangleUserControl.Size = new System.Drawing.Size(244, 131);
            this.addTriangleUserControl.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addTriangleUserControl);
            this.groupBox1.Controls.Add(this.addRectangleUserControl);
            this.groupBox1.Controls.Add(this.addCircleUserControl);
            this.groupBox1.Location = new System.Drawing.Point(20, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 170);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры фигуры";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(342, 328);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.comboBoxFigures);
            this.Controls.Add(this.labelChoose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление фигуры";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Button Random;
        private Button Cancel;
        private Button OK;
        private ComboBox comboBoxFigures;
        private Label labelChoose;
        private AddCircleUserControl addCircleUserControl;
        private AddRectangleUserControl addRectangleUserControl;
        private AddTriangleUserControl addTriangleUserControl;
        private GroupBox groupBox1;
    }
}