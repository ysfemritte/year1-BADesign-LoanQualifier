namespace Loan_Qualifier
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.YearsTextBox = new System.Windows.Forms.TextBox();
            this.DecisionLabel = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Annual Salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Years at Current Job:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loan Decision:";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(184, 41);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(92, 20);
            this.SalaryTextBox.TabIndex = 3;
            // 
            // YearsTextBox
            // 
            this.YearsTextBox.Location = new System.Drawing.Point(184, 85);
            this.YearsTextBox.Name = "YearsTextBox";
            this.YearsTextBox.Size = new System.Drawing.Size(92, 20);
            this.YearsTextBox.TabIndex = 4;
            // 
            // DecisionLabel
            // 
            this.DecisionLabel.Location = new System.Drawing.Point(15, 165);
            this.DecisionLabel.Name = "DecisionLabel";
            this.DecisionLabel.Size = new System.Drawing.Size(261, 20);
            this.DecisionLabel.TabIndex = 5;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(15, 208);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 35);
            this.CheckButton.TabIndex = 6;
            this.CheckButton.Text = "Check Qualification";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(106, 208);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(74, 35);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(186, 208);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(90, 35);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 264);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.DecisionLabel);
            this.Controls.Add(this.YearsTextBox);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TextBox YearsTextBox;
        private System.Windows.Forms.TextBox DecisionLabel;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

