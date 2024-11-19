namespace Laba27
{
    partial class Ex3Form
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
            PlayerListBox = new ListBox();
            NotPlayerListBox = new ListBox();
            ToNotPlayerButton = new Button();
            ToAllNotPlayerButton = new Button();
            NewPlayerTextBox = new TextBox();
            NewPlayerLabel = new Label();
            ToPlayerButton = new Button();
            PlayerLabel = new Label();
            NotPlayerLabel = new Label();
            SuspendLayout();
            // 
            // PlayerListBox
            // 
            PlayerListBox.FormattingEnabled = true;
            PlayerListBox.ItemHeight = 15;
            PlayerListBox.Location = new Point(61, 93);
            PlayerListBox.Name = "PlayerListBox";
            PlayerListBox.Size = new Size(207, 154);
            PlayerListBox.TabIndex = 0;
            // 
            // NotPlayerListBox
            // 
            NotPlayerListBox.FormattingEnabled = true;
            NotPlayerListBox.ItemHeight = 15;
            NotPlayerListBox.Location = new Point(520, 93);
            NotPlayerListBox.Name = "NotPlayerListBox";
            NotPlayerListBox.Size = new Size(220, 154);
            NotPlayerListBox.TabIndex = 1;
            // 
            // ToNotPlayerButton
            // 
            ToNotPlayerButton.Location = new Point(343, 93);
            ToNotPlayerButton.Name = "ToNotPlayerButton";
            ToNotPlayerButton.Size = new Size(96, 47);
            ToNotPlayerButton.TabIndex = 2;
            ToNotPlayerButton.Text = ">";
            ToNotPlayerButton.UseVisualStyleBackColor = true;
            ToNotPlayerButton.Click += ToNotPlayerButton_Click;
            // 
            // ToAllNotPlayerButton
            // 
            ToAllNotPlayerButton.Location = new Point(343, 166);
            ToAllNotPlayerButton.Name = "ToAllNotPlayerButton";
            ToAllNotPlayerButton.Size = new Size(96, 46);
            ToAllNotPlayerButton.TabIndex = 3;
            ToAllNotPlayerButton.Text = ">>";
            ToAllNotPlayerButton.UseVisualStyleBackColor = true;
            ToAllNotPlayerButton.Click += ToAllNotPlayerButton_Click;
            // 
            // NewPlayerTextBox
            // 
            NewPlayerTextBox.Location = new Point(61, 306);
            NewPlayerTextBox.Name = "NewPlayerTextBox";
            NewPlayerTextBox.Size = new Size(276, 23);
            NewPlayerTextBox.TabIndex = 4;
            // 
            // NewPlayerLabel
            // 
            NewPlayerLabel.AutoSize = true;
            NewPlayerLabel.Location = new Point(61, 288);
            NewPlayerLabel.Name = "NewPlayerLabel";
            NewPlayerLabel.Size = new Size(133, 15);
            NewPlayerLabel.TabIndex = 5;
            NewPlayerLabel.Text = "Введите нового игрока";
            // 
            // ToPlayerButton
            // 
            ToPlayerButton.Location = new Point(91, 354);
            ToPlayerButton.Name = "ToPlayerButton";
            ToPlayerButton.Size = new Size(145, 65);
            ToPlayerButton.TabIndex = 6;
            ToPlayerButton.Text = "Добавить";
            ToPlayerButton.UseVisualStyleBackColor = true;
            ToPlayerButton.Click += ToPlayerButton_Click;
            // 
            // PlayerLabel
            // 
            PlayerLabel.AutoSize = true;
            PlayerLabel.Location = new Point(129, 62);
            PlayerLabel.Name = "PlayerLabel";
            PlayerLabel.Size = new Size(48, 15);
            PlayerLabel.TabIndex = 7;
            PlayerLabel.Text = "Игроки";
            // 
            // NotPlayerLabel
            // 
            NotPlayerLabel.AutoSize = true;
            NotPlayerLabel.Location = new Point(603, 62);
            NotPlayerLabel.Name = "NotPlayerLabel";
            NotPlayerLabel.Size = new Size(64, 15);
            NotPlayerLabel.TabIndex = 8;
            NotPlayerLabel.Text = "Не игроки";
            // 
            // Ex3Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NotPlayerLabel);
            Controls.Add(PlayerLabel);
            Controls.Add(ToPlayerButton);
            Controls.Add(NewPlayerLabel);
            Controls.Add(NewPlayerTextBox);
            Controls.Add(ToAllNotPlayerButton);
            Controls.Add(ToNotPlayerButton);
            Controls.Add(NotPlayerListBox);
            Controls.Add(PlayerListBox);
            Name = "Ex3Form";
            Text = "Задание 3";
            Load += Ex3Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox PlayerListBox;
        private ListBox NotPlayerListBox;
        private Button ToNotPlayerButton;
        private Button ToAllNotPlayerButton;
        private TextBox NewPlayerTextBox;
        private Label NewPlayerLabel;
        private Button ToPlayerButton;
        private Label PlayerLabel;
        private Label NotPlayerLabel;
    }
}