namespace Laba27
{
    partial class Ex1Form
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
            CityComboBox = new ComboBox();
            OrderButton = new Button();
            CityLabel = new Label();
            SuspendLayout();
            // 
            // CityComboBox
            // 
            CityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CityComboBox.FormattingEnabled = true;
            CityComboBox.Location = new Point(163, 165);
            CityComboBox.Name = "CityComboBox";
            CityComboBox.Size = new Size(191, 23);
            CityComboBox.TabIndex = 0;
            // 
            // OrderButton
            // 
            OrderButton.Location = new Point(175, 236);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(161, 49);
            OrderButton.TabIndex = 1;
            OrderButton.Text = "Заказать";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(163, 147);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(162, 15);
            CityLabel.TabIndex = 2;
            CityLabel.Text = "Выберите пункт назначения";
            // 
            // Ex1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 389);
            Controls.Add(CityLabel);
            Controls.Add(OrderButton);
            Controls.Add(CityComboBox);
            Name = "Ex1Form";
            Text = "Задание 1";
            Load += Ex1Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CityComboBox;
        private Button OrderButton;
        private Label CityLabel;
    }
}