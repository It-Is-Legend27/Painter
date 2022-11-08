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
            this.LargeRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.SmallRadioButton = new System.Windows.Forms.RadioButton();
            this.ColorGroupBox.SuspendLayout();
            this.SizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaintPanel
            // 
            this.PaintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintPanel.Location = new System.Drawing.Point(180, 23);
            this.PaintPanel.Name = "PaintPanel";
            this.PaintPanel.Size = new System.Drawing.Size(402, 333);
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
            this.SizeGroupBox.Controls.Add(this.LargeRadioButton);
            this.SizeGroupBox.Controls.Add(this.MediumRadioButton);
            this.SizeGroupBox.Controls.Add(this.SmallRadioButton);
            this.SizeGroupBox.Location = new System.Drawing.Point(12, 216);
            this.SizeGroupBox.Name = "SizeGroupBox";
            this.SizeGroupBox.Size = new System.Drawing.Size(122, 140);
            this.SizeGroupBox.TabIndex = 2;
            this.SizeGroupBox.TabStop = false;
            this.SizeGroupBox.Text = "Size";
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
            // PainterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 369);
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
    }
}