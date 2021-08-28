using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

/******************** CREATED BY YASSCOM **********************
*                                                             *
#         __   __ _    ____ ____   ____ ___  __  __           *
#         \ \ / // \  / ___/ ___| / ___/ _ \|  \/  |          *
#          \ V // _ \ \___ \___ \| |  | | | | |\/| |          *
#           | |/ ___ \ ___) |__) | |__| |_| | |  | |          *
#           |_/_/   \_\____/____/ \____\___/|_|  |_|          *
#                                                             *
#                       DEVOUJDA.COM                          *
#  https://www.youtube.com/channel/UChiPl4zBq6pNbZHT0rwTT9g   *
*                                                             *
***************************************************************    
*/

namespace GestureLockApp.GestureLockControl
{
    [DefaultEvent("PassCodeSubmitted")]
    [DesignTimeVisible(true)]
    public sealed class LockScreenControl : Control
    {
        // Used for circular hit-testing.
        private readonly GraphicsPath hitTestPath = new GraphicsPath();
        private readonly List<RectangleF> padRects = new List<RectangleF>();
        private readonly List<int> inputtedPassCode = new List<int>();
        private int lastHoveredCellIndex = -1;
        private int[] passCode;

        [Description("Determines whether to allow the gesture to be a closed loop path."),
        Category("Behavior"), DefaultValue(true)]
        public bool AllowClosedGesture { get; set; }

        private LockScreenRenderer renderer = new YASSCOMLockScreenRenderer();
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LockScreenRenderer Renderer
        {
            get { return renderer; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "Renderer cannot be null.");

                renderer = value;
            }
        }

        [Description("Whether to allow gestures to valid if they are inputted in reverse.")]
        [Category("Input"), DefaultValue(false)]
        public bool AllowReverseGesture { get; set; }

        private int columns = 3;

        [Description("How many columns to use for the gesture grid.")]
        [Category("Layout"), DefaultValue(3)]
        public int Columns
        {
            get { return columns; }
            set
            {
                columns = value;
                Invalidate();
                LayoutCells();
            }
        }

        private int rows = 3;

        [Description("How many rows to use for the gesture grid.")]
        [DefaultValue(3)]
        [Category("Layout")]
        public int Rows
        {
            get { return rows; }
            set
            {
                rows = value;
                Invalidate();
                LayoutCells();
            }
        }

        public LockScreenControl()
        {
            AllowClosedGesture = true;
            LayoutCells();
            DoubleBuffered = true;
        }

        private static void CellHovered(int hoveredIndex)
        {
        }

        [Description("Occurs when a pass-code has been submitted.")]
        [Category("Action")]
        public event EventHandler<PassCodeSubmittedEventArgs> PassCodeSubmitted;

        private void OnPassCodeSubmitted()
        {
            if (PassCodeSubmitted != null)
            {
                var args = new PassCodeSubmittedEventArgs(GetPassCodeValid(), inputtedPassCode.ToArray());
                PassCodeSubmitted(this, args);
            }
        }

        private bool GetPassCodeValid()
        {
            // Sanity check
            if (passCode == null || passCode.Length == 0 || inputtedPassCode.Count != passCode.Length)
            {
                return false;
            }

            // Gesture normally valid, or allowing gesture to be done in reverse and reversely inputted gesture is valid.
            return !passCode.Where((t, i) => t != inputtedPassCode[i]).Any()
                || (AllowReverseGesture && !passCode.Reverse().Where((t, i) => t != inputtedPassCode[i]).Any());
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < padRects.Count; i++)
                {
                    if (!CellCircleContainsCursor(i)) continue;
                    if (lastHoveredCellIndex != i)
                    {
                        if (inputtedPassCode.Count > 1 &&
                            i == inputtedPassCode[inputtedPassCode.Count - 2])
                        {
                            inputtedPassCode.RemoveAt(inputtedPassCode.Count - 1);
                            break;
                        }
                        if (inputtedPassCode.Contains(i) == false ||
                            (AllowClosedGesture
                             && inputtedPassCode.Count > 2 // can possible be closed 
                             && inputtedPassCode[0] == i // and is actually closed
                             && inputtedPassCode[0] != inputtedPassCode.Last())) // add not already closed
                        {
                            inputtedPassCode.Add(i);
                        }
                        CellHovered(i);
                        lastHoveredCellIndex = i;
                    }
                }
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            OnPassCodeSubmitted();
            inputtedPassCode.Clear();
            lastHoveredCellIndex = -1;
            Invalidate();
        }

        protected override Size DefaultSize
        {
            get { return new Size(300, 300); }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            LayoutCells();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                hitTestPath.Dispose();
            }
        }

        private GesturePadState GetGesturePadState(int padIndex)
        {
            var state = GesturePadState.None;
            if (inputtedPassCode.Contains(padIndex))
            {
                state |= GesturePadState.Inputted;
            }

            if (inputtedPassCode != null && inputtedPassCode.Count > 0)
            {
                if (inputtedPassCode[0] == padIndex)
                {
                    state |= GesturePadState.FirstInputted;
                }

                if (inputtedPassCode.Last() == padIndex)
                {
                    state |= GesturePadState.LastInputted;
                }
            }
            if (lastHoveredCellIndex == padIndex)
            {
                state |= GesturePadState.Hovered;
            }
            return state;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            renderer.RenderBackground(e.Graphics, ClientRectangle, BackColor);
            for (int i = 0; i < padRects.Count; i++)
            {
                Renderer.RenderPad(e.Graphics, padRects[i], GetGesturePadState(i), i);
            }
            if (inputtedPassCode.Count > 0)
            {
                var points = new PointF[inputtedPassCode.Count + 1];
                for (int i = 0; i < points.Length - 1; i++)
                {
                    RectangleF r = padRects[inputtedPassCode[i]];
                    points[i] = new PointF(r.X + r.Width / 2f, r.Y + r.Height / 2f);
                }
                points[points.Length - 1] = PointToClient(Cursor.Position);
                renderer.RenderGesture(e.Graphics, points);
            }
        }

        private void LayoutCells()
        {
            padRects.Clear();
            float height = Height / (float)columns;
            float width = Width / (float)rows;
            float smallestDim = (width > height) ? height : width;
            float xOffset = (Width - (smallestDim * columns)) / 2;
            float yOffset = (Height - (smallestDim * rows)) / 2;
            for (float row = 0; row < rows; row++)
            {
                for (float clm = 0; clm < columns; clm++)
                {
                    float x = clm * smallestDim + xOffset;
                    float y = row * smallestDim + yOffset;
                    var rect = new RectangleF(x, y, smallestDim, smallestDim);
                    int inflateAmount = (int)(smallestDim * 0.3 + 0.5);
                    rect.Inflate(-inflateAmount, -inflateAmount);
                    padRects.Add(rect);
                }
            }
        }

        public void SetPassCode(int[] code)
        {
            passCode = code;
        }

        private bool CellCircleContainsCursor(int cellIndex)
        {
            hitTestPath.Reset();
            hitTestPath.AddEllipse(padRects[cellIndex]);
            return hitTestPath.IsVisible(PointToClient(Cursor.Position));
        }
    }
}