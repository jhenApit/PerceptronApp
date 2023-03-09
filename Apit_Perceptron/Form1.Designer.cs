namespace Apit_Perceptron
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
            Title = new Label();
            btnClear = new Button();
            label1 = new Label();
            tbEpoch = new TextBox();
            btnLearn = new Button();
            tbIn2 = new TextBox();
            label2 = new Label();
            tbIn1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(395, 38);
            Title.TabIndex = 0;
            Title.Text = "XNOR Gate using Perceptron";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(15, 306);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 45);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 185);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 2;
            label1.Text = "Number of Epochs :";
            // 
            // tbEpoch
            // 
            tbEpoch.Location = new Point(222, 182);
            tbEpoch.Name = "tbEpoch";
            tbEpoch.Size = new Size(119, 27);
            tbEpoch.TabIndex = 3;
            // 
            // btnLearn
            // 
            btnLearn.Location = new Point(150, 306);
            btnLearn.Name = "btnLearn";
            btnLearn.Size = new Size(119, 45);
            btnLearn.TabIndex = 4;
            btnLearn.Text = "Learn";
            btnLearn.UseVisualStyleBackColor = true;
            btnLearn.Click += btnLearn_Click;
            // 
            // tbIn2
            // 
            tbIn2.Location = new Point(222, 124);
            tbIn2.Name = "tbIn2";
            tbIn2.Size = new Size(119, 27);
            tbIn2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 127);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 5;
            label2.Text = "Input 2 :";
            // 
            // tbIn1
            // 
            tbIn1.Location = new Point(222, 65);
            tbIn1.Name = "tbIn1";
            tbIn1.Size = new Size(119, 27);
            tbIn1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 68);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "Input 1 :";
            // 
            // button1
            // 
            button1.Location = new Point(288, 306);
            button1.Name = "button1";
            button1.Size = new Size(119, 45);
            button1.TabIndex = 9;
            button1.Text = "Predict";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 245);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 10;
            label4.Text = "OUTPUT :";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(281, 245);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 20);
            lblOutput.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 363);
            Controls.Add(lblOutput);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(tbIn1);
            Controls.Add(label3);
            Controls.Add(tbIn2);
            Controls.Add(label2);
            Controls.Add(btnLearn);
            Controls.Add(tbEpoch);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button btnClear;
        private Label label1;
        private TextBox tbEpoch;
        private Button btnLearn;
        private TextBox tbIn2;
        private Label label2;
        private TextBox tbIn1;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label lblOutput;
    }
}