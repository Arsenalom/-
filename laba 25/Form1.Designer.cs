namespace laba_25
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePickerBirthDate = new DateTimePicker();
            label1 = new Label();
            labelAge = new Label();
            TrackBarTemp = new TrackBar();
            textBoxTemp = new TextBox();
            labelTemp = new Label();
            button1 = new Button();
            labelRadius = new Label();
            numericUpDown1 = new NumericUpDown();
            labelPerimetr = new Label();
            labelPlohad = new Label();
            ((System.ComponentModel.ISupportInitialize)TrackBarTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Location = new Point(36, 51);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(209, 27);
            dateTimePickerBirthDate.TabIndex = 0;
            dateTimePickerBirthDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Дата рождения";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(285, 58);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(67, 20);
            labelAge.TabIndex = 3;
            labelAge.Text = "Возраст:";
            // 
            // TrackBarTemp
            // 
            TrackBarTemp.Location = new Point(36, 126);
            TrackBarTemp.Maximum = 50;
            TrackBarTemp.Minimum = 10;
            TrackBarTemp.Name = "TrackBarTemp";
            TrackBarTemp.Size = new Size(209, 56);
            TrackBarTemp.TabIndex = 4;
            TrackBarTemp.Value = 10;
            TrackBarTemp.Scroll += trackBar1_Scroll;
            // 
            // textBoxTemp
            // 
            textBoxTemp.Location = new Point(285, 126);
            textBoxTemp.Name = "textBoxTemp";
            textBoxTemp.Size = new Size(61, 27);
            textBoxTemp.TabIndex = 6;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Location = new Point(36, 92);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(200, 20);
            labelTemp.TabIndex = 5;
            labelTemp.Text = "Температура в помещении";
            // 
            // button1
            // 
            button1.Location = new Point(256, 126);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelRadius
            // 
            labelRadius.AutoSize = true;
            labelRadius.Location = new Point(36, 185);
            labelRadius.Name = "labelRadius";
            labelRadius.Size = new Size(105, 20);
            labelRadius.TabIndex = 8;
            labelRadius.Text = "Радиус сферы";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(36, 221);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(209, 27);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // labelPerimetr
            // 
            labelPerimetr.AutoSize = true;
            labelPerimetr.Location = new Point(285, 221);
            labelPerimetr.Name = "labelPerimetr";
            labelPerimetr.Size = new Size(83, 20);
            labelPerimetr.TabIndex = 11;
            labelPerimetr.Text = "Периметр:";
            // 
            // labelPlohad
            // 
            labelPlohad.AutoSize = true;
            labelPlohad.Location = new Point(285, 279);
            labelPlohad.Name = "labelPlohad";
            labelPlohad.Size = new Size(76, 20);
            labelPlohad.TabIndex = 12;
            labelPlohad.Text = "Площадь:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 336);
            Controls.Add(labelPlohad);
            Controls.Add(labelPerimetr);
            Controls.Add(numericUpDown1);
            Controls.Add(labelRadius);
            Controls.Add(button1);
            Controls.Add(textBoxTemp);
            Controls.Add(labelTemp);
            Controls.Add(TrackBarTemp);
            Controls.Add(labelAge);
            Controls.Add(label1);
            Controls.Add(dateTimePickerBirthDate);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)TrackBarTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerBirthDate;
        private Label label1;
        private Label labelAge;
        private TrackBar TrackBarTemp;
        private TextBox textBoxTemp;
        private Label labelTemp;
        private Button button1;
        private Label labelRadius;
        private NumericUpDown numericUpDown1;
        private Label labelPerimetr;
        private Label labelPlohad;
    }
}
