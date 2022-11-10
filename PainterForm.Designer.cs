namespace Painter
{
    partial class PainterForm
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
            this.PaintPanel = new System.Windows.Forms.Panel();
            this.ColorGroupBox = new System.Windows.Forms.GroupBox();
            this.BlueRadioButton = new System.Windows.Forms.RadioButton();
            this.GreenRadioButton = new System.Windows.Forms.RadioButton();
            this.BlackRadioButton = new System.Windows.Forms.RadioButton();
            this.RedRadioButton = new System.Windows.Forms.RadioButton();
            this.SizeGroupBox = new System.Windows.Forms.GroupBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.CustomSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.LargeRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.SmallRadioButton = new System.Windows.Forms.RadioButton();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ColorGroupBox.SuspendLayout();
            this.SizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaintPanel
            // 
            this.PaintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintPanel.Location = new System.Drawing.Point(180, 23);
            this.PaintPanel.Name = "PaintPanel";
            this.PaintPanel.Size = new System.Drawing.Size(402, 435);
            this.PaintPanel.TabIndex = 0;
            this.PaintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PainterPanel_MouseDown);
            this.PaintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PainterPanel_MouseMove);
            this.PaintPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PainterPanel_MouseUp);
            // 
            // ColorGroupBox
            // 
            this.ColorGroupBox.Controls.Add(this.BlueRadioButton);
            this.ColorGroupBox.Controls.Add(this.GreenRadioButton);
            this.ColorGroupBox.Controls.Add(this.BlackRadioButton);
            this.ColorGroupBox.Controls.Add(this.RedRadioButton);
            this.ColorGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ColorGroupBox.Name = "ColorGroupBox";
            this.ColorGroupBox.Size = new System.Drawing.Size(122, 187);
            this.ColorGroupBox.TabIndex = 1;
            this.ColorGroupBox.TabStop = false;
            this.ColorGroupBox.Text = "Color";
            // 
            // BlueRadioButton
            // 
            this.BlueRadioButton.AutoSize = true;
            this.BlueRadioButton.Location = new System.Drawing.Point(27, 75);
            this.BlueRadioButton.Name = "BlueRadioButton";
            this.BlueRadioButton.Size = new System.Drawing.Size(59, 25);
            this.BlueRadioButton.TabIndex = 3;
            this.BlueRadioButton.Text = "Blue";
            this.BlueRadioButton.UseVisualStyleBackColor = true;
            this.BlueRadioButton.CheckedChanged += new System.EventHandler(this.ColorRadioButton_CheckedChanged);
            // 
            // GreenRadioButton
            // 
            this.GreenRadioButton.AutoSize = true;
            this.GreenRadioButton.Location = new System.Drawing.Point(27, 106);
            this.GreenRadioButton.Name = "GreenRadioButton";
            this.GreenRadioButton.Size = new System.Drawing.Size(71, 25);
            this.GreenRadioButton.TabIndex = 2;
            this.GreenRadioButton.Text = "Green";
            this.GreenRadioButton.UseVisualStyleBackColor = true;
            this.GreenRadioButton.CheckedChanged += new System.EventHandler(this.ColorRadioButton_CheckedChanged);
            // 
            // BlackRadioButton
            // 
            this.BlackRadioButton.AutoSize = true;
            this.BlackRadioButton.Checked = true;
            this.BlackRadioButton.Location = new System.Drawing.Point(27, 137);
            this.BlackRadioButton.Name = "BlackRadioButton";
            this.BlackRadioButton.Size = new System.Drawing.Size(65, 25);
            this.BlackRadioButton.TabIndex = 1;
            this.BlackRadioButton.TabStop = true;
            this.BlackRadioButton.Text = "Black";
            this.BlackRadioButton.UseVisualStyleBackColor = true;
            this.BlackRadioButton.CheckedChanged += new System.EventHandler(this.ColorRadioButton_CheckedChanged);
            // 
            // RedRadioButton
            // 
            this.RedRadioButton.AutoSize = true;
            this.RedRadioButton.Location = new System.Drawing.Point(27, 44);
            this.RedRadioButton.Name = "RedRadioButton";
            this.RedRadioButton.Size = new System.Drawing.Size(56, 25);
            this.RedRadioButton.TabIndex = 0;
            this.RedRadioButton.Text = "Red";
            this.RedRadioButton.UseVisualStyleBackColor = true;
            this.RedRadioButton.CheckedChanged += new System.EventHandler(this.ColorRadioButton_CheckedChanged);
            // 
            // SizeGroupBox
            // 
            this.SizeGroupBox.Controls.Add(this.EnterButton);
            this.SizeGroupBox.Controls.Add(this.SizeTextBox);
            this.SizeGroupBox.Controls.Add(this.CustomSizeRadioButton);
            this.SizeGroupBox.Controls.Add(this.LargeRadioButton);
            this.SizeGroupBox.Controls.Add(this.MediumRadioButton);
            this.SizeGroupBox.Controls.Add(this.SmallRadioButton);
            this.SizeGroupBox.Location = new System.Drawing.Point(12, 205);
            this.SizeGroupBox.Name = "SizeGroupBox";
            this.SizeGroupBox.Size = new System.Drawing.Size(122, 239);
            this.SizeGroupBox.TabIndex = 2;
            this.SizeGroupBox.TabStop = false;
            this.SizeGroupBox.Text = "Size";
            // 
            // EnterButton
            // 
            this.EnterButton.Enabled = false;
            this.EnterButton.Location = new System.Drawing.Point(27, 190);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(71, 34);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Enabled = false;
            this.SizeTextBox.Location = new System.Drawing.Point(27, 156);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(71, 33);
            this.SizeTextBox.TabIndex = 6;
            // 
            // CustomSizeRadioButton
            // 
            this.CustomSizeRadioButton.AutoSize = true;
            this.CustomSizeRadioButton.Location = new System.Drawing.Point(27, 124);
            this.CustomSizeRadioButton.Name = "CustomSizeRadioButton";
            this.CustomSizeRadioButton.Size = new System.Drawing.Size(84, 25);
            this.CustomSizeRadioButton.TabIndex = 5;
            this.CustomSizeRadioButton.TabStop = true;
            this.CustomSizeRadioButton.Text = "Custom";
            this.CustomSizeRadioButton.UseVisualStyleBackColor = true;
            this.CustomSizeRadioButton.CheckedChanged += new System.EventHandler(this.SizeRadioButton_CheckChanged);
            // 
            // LargeRadioButton
            // 
            this.LargeRadioButton.AutoSize = true;
            this.LargeRadioButton.Location = new System.Drawing.Point(27, 94);
            this.LargeRadioButton.Name = "LargeRadioButton";
            this.LargeRadioButton.Size = new System.Drawing.Size(69, 25);
            this.LargeRadioButton.TabIndex = 4;
            this.LargeRadioButton.Text = "Large";
            this.LargeRadioButton.UseVisualStyleBackColor = true;
            this.LargeRadioButton.CheckedChanged += new System.EventHandler(this.SizeRadioButton_CheckChanged);
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(27, 63);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(87, 25);
            this.MediumRadioButton.TabIndex = 3;
            this.MediumRadioButton.Text = "Medium";
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            this.MediumRadioButton.CheckedChanged += new System.EventHandler(this.SizeRadioButton_CheckChanged);
            // 
            // SmallRadioButton
            // 
            this.SmallRadioButton.AutoSize = true;
            this.SmallRadioButton.Checked = true;
            this.SmallRadioButton.Location = new System.Drawing.Point(27, 32);
            this.SmallRadioButton.Name = "SmallRadioButton";
            this.SmallRadioButton.Size = new System.Drawing.Size(68, 25);
            this.SmallRadioButton.TabIndex = 2;
            this.SmallRadioButton.TabStop = true;
            this.SmallRadioButton.Text = "Small";
            this.SmallRadioButton.UseVisualStyleBackColor = true;
            this.SmallRadioButton.CheckedChanged += new System.EventHandler(this.SizeRadioButton_CheckChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 450);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(122, 29);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PainterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 489);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SizeGroupBox);
            this.Controls.Add(this.ColorGroupBox);
            this.Controls.Add(this.PaintPanel);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PainterForm";
            this.Text = "Painter Deluxe";
            this.ColorGroupBox.ResumeLayout(false);
            this.ColorGroupBox.PerformLayout();
            this.SizeGroupBox.ResumeLayout(false);
            this.SizeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PaintPanel;
        private GroupBox ColorGroupBox;
        private GroupBox SizeGroupBox;
        private RadioButton RedRadioButton;
        private RadioButton GreenRadioButton;
        private RadioButton BlackRadioButton;
        private RadioButton BlueRadioButton;
        private RadioButton LargeRadioButton;
        private RadioButton MediumRadioButton;
        private RadioButton SmallRadioButton;
        private Button ClearButton;
        private RadioButton CustomSizeRadioButton;
        private TextBox SizeTextBox;
        private Button EnterButton;
    }
}