using System;
using System.Drawing;
using System.Windows.Forms;

namespace Painter
{
    public partial class PainterForm : Form
    {


        private bool ShouldPaint { get; set; } = false;

        private Color PaintColor { get; set; } = Color.Black;

        private Size BrushSize { get; set; } = new(4,4);

        public PainterForm()
        {
            InitializeComponent();
        }

        // should paint when mouse button is pressed down
        private void PainterPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Indicate that user is dragging the mouse
            ShouldPaint = true;
        }

        // stop painting when mouse button is released
        private void PainterPanel_MouseUp(object sender, MouseEventArgs e)
        {
            // indicate that user rekeased the mouse button
            ShouldPaint = false;
        }

        // draw circle whenever mouse moves with its button held down
        private void PainterPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint) // check if mouse button is being pressed
            {
                // draw circle where the mouse pointer is present
                using Graphics graphics = PaintPanel.CreateGraphics();
                {
                    graphics.FillEllipse(new SolidBrush(PaintColor), e.X, e.Y, BrushSize.Width, BrushSize.Height);
                }
            }
        }
    }
}