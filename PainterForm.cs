using System;
using System.Drawing;
using System.Windows.Forms;

namespace Painter
{
    public partial class PainterForm : Form
    {
        //List<Point> _coords = new List<Point>();

        private static readonly Dictionary<string, Size> brushSizes = new Dictionary<string, Size> 
        {
            {"small", new Size(4,4)},
            {"medium", new Size(8,8)},
            {"large", new Size(16,16)},
        };

        private bool ShouldPaint { get; set; } = false;

        private Color BrushColor { get; set; } = Color.Black;

        private Size BrushSize { get; set; } = brushSizes["small"];

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
                using (Graphics graphics = PaintPanel.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(BrushColor), e.X, e.Y, BrushSize.Width, BrushSize.Height);
                }

                /*_coords.Add(e.Location);
                Invalidate();*/
            }
        }

        private void ColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
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

        private void SizeRadioButton_CheckChanged(object sender, EventArgs e)
        {
            
        }

        /*protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach(Point p in _coords)
            {
                using (Graphics graphics = PaintPanel.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(BrushColor), p.X, p.Y, BrushSize.Width, BrushSize.Height);
                }
            }

        }*/
    }
}