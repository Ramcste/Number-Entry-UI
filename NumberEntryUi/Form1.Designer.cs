namespace NumberEntryUi
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
            this.addNumberButton = new System.Windows.Forms.Button();
            this.showAllNumberButton = new System.Windows.Forms.Button();
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.sumResultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addNumberButton
            // 
            this.addNumberButton.Location = new System.Drawing.Point(278, 82);
            this.addNumberButton.Name = "addNumberButton";
            this.addNumberButton.Size = new System.Drawing.Size(75, 23);
            this.addNumberButton.TabIndex = 0;
            this.addNumberButton.Text = "Add";
            this.addNumberButton.UseVisualStyleBackColor = true;
            this.addNumberButton.Click += new System.EventHandler(this.addNumberButton_Click_1);
            // 
            // showAllNumberButton
            // 
            this.showAllNumberButton.Location = new System.Drawing.Point(240, 122);
            this.showAllNumberButton.Name = "showAllNumberButton";
            this.showAllNumberButton.Size = new System.Drawing.Size(113, 23);
            this.showAllNumberButton.TabIndex = 1;
            this.showAllNumberButton.Text = "Show All Number";
            this.showAllNumberButton.UseVisualStyleBackColor = true;
            this.showAllNumberButton.Click += new System.EventHandler(this.showAllNumberButton_Click);
            // 
            // numberListBox
            // 
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.Location = new System.Drawing.Point(116, 162);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(120, 160);
            this.numberListBox.TabIndex = 2;
            // 
            // sumResultTextBox
            // 
            this.sumResultTextBox.Location = new System.Drawing.Point(253, 343);
            this.sumResultTextBox.Name = "sumResultTextBox";
            this.sumResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumResultTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sum Result:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(149, 56);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(204, 20);
            this.numberTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumResultTextBox);
            this.Controls.Add(this.numberListBox);
            this.Controls.Add(this.showAllNumberButton);
            this.Controls.Add(this.addNumberButton);
            this.Name = "Form1";
            this.Text = "Number UI APP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNumberButton;
        private System.Windows.Forms.Button showAllNumberButton;
        private System.Windows.Forms.ListBox numberListBox;
        private System.Windows.Forms.TextBox sumResultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label2;
    }
}

