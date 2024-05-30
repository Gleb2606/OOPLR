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
            Random = new Button();
            Cancel = new Button();
            OK = new Button();
            comboBoxFigures = new ComboBox();
            labelChoose = new Label();
            addCircleUserControl = new AddCircleUserControl();
            addRectangleUserControl = new AddRectangleUserControl();
            addTriangleUserControl = new AddTriangleUserControl();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Random
            // 
#if DEBUG
            Random.Location = new Point(158, 38);
            Random.Margin = new Padding(3, 2, 3, 2);
            Random.Name = "Random";
            Random.Size = new Size(122, 22);
            Random.TabIndex = 26;
            Random.Text = "Случайная фигура";
            Random.UseVisualStyleBackColor = true;
            Random.Click += ButtonRandom_Click;
#endif
            // 
            // Cancel
            // 
            Cancel.Location = new Point(158, 213);
            Cancel.Margin = new Padding(3, 2, 3, 2);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(122, 22);
            Cancel.TabIndex = 25;
            Cancel.Text = "Отменить";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += ButtonCancel_Click;
            // 
            // OK
            // 
            OK.Location = new Point(19, 213);
            OK.Margin = new Padding(3, 2, 3, 2);
            OK.Name = "OK";
            OK.Size = new Size(122, 22);
            OK.TabIndex = 23;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += ButtonOK_Click;
            // 
            // comboBoxFigures
            // 
            comboBoxFigures.FormattingEnabled = true;
            comboBoxFigures.Location = new Point(18, 39);
            comboBoxFigures.Margin = new Padding(3, 2, 3, 2);
            comboBoxFigures.Name = "comboBoxFigures";
#if DEBUG
            comboBoxFigures.Size = new Size(123, 23);
#else
            comboBoxFigures.Size = new Size(262, 23);
#endif
            comboBoxFigures.TabIndex = 22;
            comboBoxFigures.SelectedIndexChanged += ComboBoxFigeres_SelectedIndexChanged;
            // 
            // labelChoose
            // 
            labelChoose.AutoSize = true;
            labelChoose.Location = new Point(18, 15);
            labelChoose.Name = "labelChoose";
            labelChoose.Size = new Size(104, 15);
            labelChoose.TabIndex = 21;
            labelChoose.Text = "Выберите фигуру";
            // 
            // addCircleUserControl
            // 
            addCircleUserControl.Location = new Point(18, 15);
            addCircleUserControl.Margin = new Padding(3, 2, 3, 2);
            addCircleUserControl.Name = "addCircleUserControl";
            addCircleUserControl.Size = new Size(214, 44);
            addCircleUserControl.TabIndex = 27;
            // 
            // addRectangleUserControl
            // 
            addRectangleUserControl.Location = new Point(18, 15);
            addRectangleUserControl.Margin = new Padding(3, 2, 3, 2);
            addRectangleUserControl.Name = "addRectangleUserControl";
            addRectangleUserControl.Size = new Size(220, 108);
            addRectangleUserControl.TabIndex = 28;
            // 
            // addTriangleUserControl
            // 
            addTriangleUserControl.Location = new Point(18, 15);
            addTriangleUserControl.Margin = new Padding(3, 2, 3, 2);
            addTriangleUserControl.Name = "addTriangleUserControl";
            addTriangleUserControl.Size = new Size(214, 98);
            addTriangleUserControl.TabIndex = 29;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addTriangleUserControl);
            groupBox1.Controls.Add(addRectangleUserControl);
            groupBox1.Controls.Add(addCircleUserControl);
            groupBox1.Location = new Point(18, 75);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(262, 128);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры фигуры";
            // 
            // AddFigureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(299, 246);
            Controls.Add(groupBox1);
            Controls.Add(Random);
            Controls.Add(Cancel);
            Controls.Add(OK);
            Controls.Add(comboBoxFigures);
            Controls.Add(labelChoose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AddFigureForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление фигуры";
            Load += AddForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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