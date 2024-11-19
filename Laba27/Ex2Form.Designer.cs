namespace Laba27
{
    partial class Ex2Form
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
            CoursesCheckedListBox = new CheckedListBox();
            CoursesLabel = new Label();
            SignUpButton = new Button();
            SuspendLayout();
            // 
            // CoursesCheckedListBox
            // 
            CoursesCheckedListBox.FormattingEnabled = true;
            CoursesCheckedListBox.Location = new Point(51, 129);
            CoursesCheckedListBox.Name = "CoursesCheckedListBox";
            CoursesCheckedListBox.Size = new Size(313, 184);
            CoursesCheckedListBox.TabIndex = 0;
            // 
            // CoursesLabel
            // 
            CoursesLabel.AutoSize = true;
            CoursesLabel.Location = new Point(163, 95);
            CoursesLabel.Name = "CoursesLabel";
            CoursesLabel.Size = new Size(98, 15);
            CoursesLabel.TabIndex = 1;
            CoursesLabel.Text = "Выберите курсы";
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(143, 358);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(104, 44);
            SignUpButton.TabIndex = 2;
            SignUpButton.Text = "Записаться";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // Ex2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 450);
            Controls.Add(SignUpButton);
            Controls.Add(CoursesLabel);
            Controls.Add(CoursesCheckedListBox);
            Name = "Ex2Form";
            Text = "Задание 2";
            Load += Ex2Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox CoursesCheckedListBox;
        private Label CoursesLabel;
        private Button SignUpButton;
    }
}