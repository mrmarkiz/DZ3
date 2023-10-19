namespace DZ3
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
            label1 = new Label();
            listBoxSimple = new ListBox();
            listBoxFibonacci = new ListBox();
            label2 = new Label();
            numericUpDownStart = new NumericUpDown();
            numericUpDownEnd = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonStartSimple = new Button();
            buttonStartFibonacci = new Button();
            buttonShutSimple = new Button();
            buttonShutFibonacci = new Button();
            buttonStopSimple = new Button();
            buttonStopFibonacci = new Button();
            buttonContinueSimple = new Button();
            buttonContinueFibonacci = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Simple nums:";
            // 
            // listBoxSimple
            // 
            listBoxSimple.FormattingEnabled = true;
            listBoxSimple.ItemHeight = 20;
            listBoxSimple.Location = new Point(12, 34);
            listBoxSimple.Name = "listBoxSimple";
            listBoxSimple.Size = new Size(202, 404);
            listBoxSimple.TabIndex = 1;
            // 
            // listBoxFibonacci
            // 
            listBoxFibonacci.FormattingEnabled = true;
            listBoxFibonacci.ItemHeight = 20;
            listBoxFibonacci.Location = new Point(249, 34);
            listBoxFibonacci.Name = "listBoxFibonacci";
            listBoxFibonacci.Size = new Size(202, 404);
            listBoxFibonacci.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 9);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Fibonacci nums:";
            // 
            // numericUpDownStart
            // 
            numericUpDownStart.Location = new Point(469, 58);
            numericUpDownStart.Name = "numericUpDownStart";
            numericUpDownStart.Size = new Size(150, 27);
            numericUpDownStart.TabIndex = 4;
            // 
            // numericUpDownEnd
            // 
            numericUpDownEnd.Location = new Point(632, 58);
            numericUpDownEnd.Name = "numericUpDownEnd";
            numericUpDownEnd.Size = new Size(150, 27);
            numericUpDownEnd.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 35);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 6;
            label3.Text = "Lower bound";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(655, 35);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 6;
            label4.Text = "Upper bound";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(483, 124);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 7;
            label5.Text = "For simple nums";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(640, 124);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 8;
            label6.Text = "For Fibonacci nums";
            // 
            // buttonStartSimple
            // 
            buttonStartSimple.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStartSimple.Location = new Point(469, 152);
            buttonStartSimple.Name = "buttonStartSimple";
            buttonStartSimple.Size = new Size(150, 50);
            buttonStartSimple.TabIndex = 9;
            buttonStartSimple.Tag = "S";
            buttonStartSimple.Text = "Start";
            buttonStartSimple.UseVisualStyleBackColor = true;
            buttonStartSimple.Click += buttonStart_Click;
            // 
            // buttonStartFibonacci
            // 
            buttonStartFibonacci.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStartFibonacci.Location = new Point(632, 152);
            buttonStartFibonacci.Name = "buttonStartFibonacci";
            buttonStartFibonacci.Size = new Size(150, 50);
            buttonStartFibonacci.TabIndex = 9;
            buttonStartFibonacci.Tag = "F";
            buttonStartFibonacci.Text = "Start";
            buttonStartFibonacci.UseVisualStyleBackColor = true;
            buttonStartFibonacci.Click += buttonStart_Click;
            // 
            // buttonShutSimple
            // 
            buttonShutSimple.Enabled = false;
            buttonShutSimple.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShutSimple.Location = new Point(469, 224);
            buttonShutSimple.Name = "buttonShutSimple";
            buttonShutSimple.Size = new Size(150, 50);
            buttonShutSimple.TabIndex = 9;
            buttonShutSimple.Tag = "S";
            buttonShutSimple.Text = "Shut";
            buttonShutSimple.UseVisualStyleBackColor = true;
            buttonShutSimple.Click += buttonShut_Click;
            // 
            // buttonShutFibonacci
            // 
            buttonShutFibonacci.Enabled = false;
            buttonShutFibonacci.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShutFibonacci.Location = new Point(632, 224);
            buttonShutFibonacci.Name = "buttonShutFibonacci";
            buttonShutFibonacci.Size = new Size(150, 50);
            buttonShutFibonacci.TabIndex = 9;
            buttonShutFibonacci.Tag = "F";
            buttonShutFibonacci.Text = "Shut";
            buttonShutFibonacci.UseVisualStyleBackColor = true;
            buttonShutFibonacci.Click += buttonShut_Click;
            // 
            // buttonStopSimple
            // 
            buttonStopSimple.Enabled = false;
            buttonStopSimple.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStopSimple.Location = new Point(469, 296);
            buttonStopSimple.Name = "buttonStopSimple";
            buttonStopSimple.Size = new Size(150, 50);
            buttonStopSimple.TabIndex = 9;
            buttonStopSimple.Tag = "S";
            buttonStopSimple.Text = "Stop";
            buttonStopSimple.UseVisualStyleBackColor = true;
            buttonStopSimple.Click += buttonStop_Click;
            // 
            // buttonStopFibonacci
            // 
            buttonStopFibonacci.Enabled = false;
            buttonStopFibonacci.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStopFibonacci.Location = new Point(632, 296);
            buttonStopFibonacci.Name = "buttonStopFibonacci";
            buttonStopFibonacci.Size = new Size(150, 50);
            buttonStopFibonacci.TabIndex = 9;
            buttonStopFibonacci.Tag = "F";
            buttonStopFibonacci.Text = "Stop";
            buttonStopFibonacci.UseVisualStyleBackColor = true;
            buttonStopFibonacci.Click += buttonStop_Click;
            // 
            // buttonContinueSimple
            // 
            buttonContinueSimple.Enabled = false;
            buttonContinueSimple.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonContinueSimple.Location = new Point(469, 369);
            buttonContinueSimple.Name = "buttonContinueSimple";
            buttonContinueSimple.Size = new Size(150, 50);
            buttonContinueSimple.TabIndex = 9;
            buttonContinueSimple.Tag = "S";
            buttonContinueSimple.Text = "Continue";
            buttonContinueSimple.UseVisualStyleBackColor = true;
            buttonContinueSimple.Click += buttonContinue_Click;
            // 
            // buttonContinueFibonacci
            // 
            buttonContinueFibonacci.Enabled = false;
            buttonContinueFibonacci.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonContinueFibonacci.Location = new Point(632, 369);
            buttonContinueFibonacci.Name = "buttonContinueFibonacci";
            buttonContinueFibonacci.Size = new Size(150, 50);
            buttonContinueFibonacci.TabIndex = 9;
            buttonContinueFibonacci.Tag = "F";
            buttonContinueFibonacci.Text = "Continue";
            buttonContinueFibonacci.UseVisualStyleBackColor = true;
            buttonContinueFibonacci.Click += buttonContinue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonContinueFibonacci);
            Controls.Add(buttonStopFibonacci);
            Controls.Add(buttonShutFibonacci);
            Controls.Add(buttonStartFibonacci);
            Controls.Add(buttonContinueSimple);
            Controls.Add(buttonStopSimple);
            Controls.Add(buttonShutSimple);
            Controls.Add(buttonStartSimple);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDownEnd);
            Controls.Add(numericUpDownStart);
            Controls.Add(listBoxFibonacci);
            Controls.Add(label2);
            Controls.Add(listBoxSimple);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxSimple;
        private ListBox listBoxFibonacci;
        private Label label2;
        private NumericUpDown numericUpDownStart;
        private NumericUpDown numericUpDownEnd;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonStartSimple;
        private Button buttonStartFibonacci;
        private Button buttonShutSimple;
        private Button buttonShutFibonacci;
        private Button buttonStopSimple;
        private Button buttonStopFibonacci;
        private Button buttonContinueSimple;
        private Button buttonContinueFibonacci;
    }
}