/**
 * Angel Badillo
 * CMPS 4143
 * Program 6: Extended Painter Program
 * A simple extension to the painter program illustrated in
 *  fig. 14.38 in the textbook "Visual C#: How to Program 6e". This program's 
 *  GUI is meant to closely resemble the GUI in fig. 14.43 in the
 *  aforementioned textbook, but has a few extra features and components,
 *  such as a "clear" button to clear the panel where you draw,
 *  and an option to enter a custom brush size.
 */
namespace Painter
{
    public partial class PainterForm : Form
    {
        // Types of brush sizes to be picked by radio buttons
        private enum BrushSizes
        {
            Small = 4,
            Medium = 8,
            Large = 16,
        }

        // Determines if PaintPanel should be painted on. False by default
        private bool ShouldPaint { get; set; } = false;

        // Saves the current selected brush color. Black by default
        private Color BrushColor { get; set; } = Color.Black;

        // Saves the current selected brush size. "Small" by default.
        private int BrushSize { get; set; } = (int)BrushSizes.Small;

        public PainterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the mouse button is pressed down. Sets
        /// ShouldPaint to true, meaning painting should occur (once mouse is
        /// moved).
        /// </summary>
        /// <param name="sender"> 
        /// Component (Panel) that raised the event. 
        /// </param>
        /// <param name="e"> 
        /// Mouse event arguments.
        /// </param>
        private void PainterPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Indicate that user is dragging the mouse
            ShouldPaint = true;
        }

        /// <summary>
        /// Event handler for when the mouse button is released after
        /// being pressed and held down. Sets should paint to false,
        /// meaning painting should not occur.
        /// </summary>
        /// <param name="sender">
        /// Component (Panel) that raised the event.
        /// </param>
        /// <param name="e">
        /// Mouse event arguments.
        /// </param>
        private void PainterPanel_MouseUp(object sender, MouseEventArgs e)
        {
            // indicate that user released the mouse button
            ShouldPaint = false;
        }

        /// <summary>
        /// Event handler for mouse is moved. If ShouldPaint is true (mouse
        /// is pressed down), filled in circles will be consecutively painted, 
        /// following the position of the mouse.
        /// </summary>
        /// <param name="sender">
        /// Component (PaintPanel) that raised the event.
        /// </param>
        /// <param name="e">
        /// Mouse event arguments.
        /// </param>
        private void PainterPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint) // check if mouse button is being pressed
            {
                // draw circle where the mouse pointer is present
                using (Graphics graphics = PaintPanel.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(BrushColor), e.X, e.Y, 
                        BrushSize, BrushSize);
                }
            }
        }

        /// <summary>
        /// Event handler for when there is a change in which 
        /// color radio button is checked. If the button that is checked
        /// changes, determine which button is checked, and set BrushColor
        /// to the appropriate Color value.
        /// </summary>
        /// <param name="sender">
        /// Component (RadioButton) that raised the event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void ColorRadioButton_CheckedChanged(object sender, 
            EventArgs e)
        {
            // Determine which radio button is checked and change
            // BrushColor to appropriate Color value
            if (sender == RedRadioButton)
            {
                BrushColor = Color.Red;
            }
            else if (sender == BlueRadioButton)
            {
                BrushColor = Color.Blue;
            }
            else if (sender == GreenRadioButton)
            {
                BrushColor = Color.Green;
            }
            else
            {
                BrushColor = Color.Black;
            }
        }

        /// <summary>
        /// Event handler for when there is a change in which size radio
        /// button is checked. If the button that is checked changes,
        /// determine which button is checked, and set BrushSize to the
        /// appropriate size (int).
        /// </summary>
        /// <param name="sender">
        /// Component (RadioButton) that raised the event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void SizeRadioButton_CheckChanged(object sender, EventArgs e)
        {
            // Determine which radio button is checked and change
            // BrushColor to appropriate size (int)
            if (sender == SmallRadioButton)
            {
                BrushSize = (int)BrushSizes.Small;

                // Disable custom size textbox and enter button
                SizeTextBox.Enabled = false;
                EnterButton.Enabled = false;
            }
            else if (sender == MediumRadioButton)
            {
                BrushSize = (int)BrushSizes.Medium;

                // Disable custom size textbox and enter button
                SizeTextBox.Enabled = false;
                EnterButton.Enabled = false;
            }
            else if (sender == LargeRadioButton)
            {
                BrushSize = (int)BrushSizes.Large;

                // Disable custom size textbox and enter button
                SizeTextBox.Enabled = false;
                EnterButton.Enabled = false;
            }
            // Enables user to enter custom size
            else
            {
                SizeTextBox.Enabled = true;
                EnterButton.Enabled = true;
            }
        }

        /// <summary>
        /// Event handler for when ClearButton is clicked. Clears PaintPanel
        /// by calling Invalidate() on it, thus forcing the panel to be
        /// redrawn.
        /// </summary>
        /// <param name="sender">
        /// Component (Button) that raised the event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            PaintPanel.Invalidate();
        }

        /// <summary>
        /// Event handler for when EnterButton is clicked. Sets BrushSize
        /// to the size entered by user in SizeTextBox.
        /// </summary>
        /// <param name="sender">
        /// Component (Button) that raised the event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void EnterButton_Click(object sender, EventArgs e)
        {
            // Set BrushSize to size in specified in SizeTextBox, if it's
            // a positive integer.
            try
            {   
                // Exception thrown user input is not an integer
                int customSize = int.Parse(SizeTextBox.Text);
                
                // Throw exception if size is 0 or lesser.
                if (customSize <= 0)
                    throw new Exception();

                BrushSize = customSize;
            }
            // Display message box explaining error
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid brush size, a " +
                    "positive integer.", "Invalid Brush Size", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}