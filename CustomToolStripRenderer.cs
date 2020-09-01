
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

 


namespace IAINUNIV
{

    internal class CustomColorTable : ProfessionalColorTable
    {

        private Color getGradientBegin(Color color, double factor)
        {
            factor = (100 + factor) / 100;


            int[] c = new int[3] { color.R, color.G, color.B };

            for (int i = 0; i < 3; i++)
                c[i] = Math.Min((int)Math.Round((c[i] * factor)), 255);

            return Color.FromArgb(c[0], c[1], c[2]);
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
               // return getGradientBegin(SystemColors.Control, 20);
                return SystemColors.ControlLightLight;
            }
        }

        public override Color  ImageMarginGradientMiddle
        {
	        get 
	        {
              //  return getGradientBegin(SystemColors.Control, 10);
               
                return SystemColors.Control;
	        }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                //return System.Drawing.SystemColors.Control;
                return System.Drawing.SystemColors.ControlDark;
            }
        }

        public override Color ToolStripGradientBegin
        {
            get
            {
                return SystemColors.ControlLightLight;


            }
        }

        public override Color ToolStripGradientMiddle
        {
            get
            {
                return SystemColors.Control;
            }
        }

        public override Color ToolStripGradientEnd
        {
            get
            {
                return System.Drawing.SystemColors.ControlDark;
            }
        }

        public override Color ToolStripBorder
        {
            get
            {
                return System.Drawing.SystemColors.ControlDark;
            }
        }

        


    }
	

    internal class CustomToolStripRenderer : ToolStripProfessionalRenderer
    {
      //  private static Bitmap titleBarGripBmp;
      
     //   private static string titleBarGripEnc = @"Qk16AQAAAAAAADYAAAAoAAAAIwAAAAMAAAABABgAAAAAAAAAAADEDgAAxA4AAAAAAAAAAAAAuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5ANj+RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5ANj+RzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMANj+";

        // Define titlebar colors.
        //private static Color titlebarColor1 = Color.FromArgb(89, 135, 214);
        //private static Color titlebarColor2 = Color.FromArgb(76, 123, 204);
        //private static Color titlebarColor3 = Color.FromArgb(63, 111, 194);
        //private static Color titlebarColor4 = Color.FromArgb(50, 99, 184);
        //private static Color titlebarColor5 = Color.FromArgb(38, 88, 174);
        //private static Color titlebarColor6 = Color.FromArgb(25, 76, 164);
        //private static Color titlebarColor7 = Color.FromArgb(12, 64, 154);
        //private static Color borderColor = Color.FromArgb(0, 0, 128);

        //internal static Bitmap DeserializeFromBase64(string data)
        //{
        //    // Decode the string and create settingsAttr memory stream 
        //    // on the decoded string data.
        //    MemoryStream stream =
        //        new MemoryStream(Convert.FromBase64String(data));

        //    // Create settingsAttr new bitmap from the stream.
        //    Bitmap b = new Bitmap(stream);

        //    return b;
        //}

        static CustomToolStripRenderer()
        {
           // titleBarGripBmp = CustomToolStripRenderer.DeserializeFromBase64(titleBarGripEnc);
        }

        public CustomToolStripRenderer()
        {
        }

        //protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        //{

        //    Graphics g = e.Graphics;
        //    //    Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);

        //    //    Color gradientBegin = Color.FromArgb(203, 225, 252);
        //    //    Color gradientEnd = Color.FromArgb(125, 165, 224);

        //    //    ToolStripButton button = e.Item as ToolStripButton;
        //    //    if (button.Pressed || button.Checked)
        //    //    {
        //    //        gradientBegin = Color.FromArgb(254, 128, 62);
        //    //        gradientEnd = Color.FromArgb(255, 223, 154);
        //    //    }
        //    //    else if (button.Selected)
        //    //    {
        //    //        gradientBegin = Color.FromArgb(255, 255, 222);
        //    //        gradientEnd = Color.FromArgb(255, 203, 136);
        //    //    }

        //    //    using (Brush b = new LinearGradientBrush(
        //    //        bounds,
        //    //        gradientBegin,
        //    //        gradientEnd,
        //    //        LinearGradientMode.Vertical))
        //    //    {
        //    //        g.FillRectangle(b, bounds);
        //    //    }

        //    //    e.Graphics.DrawRectangle(
        //    //        SystemPens.ControlDarkDark,
        //    //        bounds);

        //    //    g.DrawLine(
        //    //        SystemPens.ControlDarkDark,
        //    //        bounds.X,
        //    //        bounds.Y,
        //    //        bounds.Width - 1,
        //    //        bounds.Y);

        //    //    g.DrawLine(
        //    //        SystemPens.ControlDarkDark,
        //    //        bounds.X,
        //    //        bounds.Y,
        //    //        bounds.X,
        //    //        bounds.Height - 1);

        //    //    ToolStrip toolStrip = button.Owner;
        //    //    ToolStripButton nextItem = button.Owner.GetItemAt(
        //    //        button.Bounds.X,
        //    //        button.Bounds.Bottom + 1) as ToolStripButton;

        //    //    if (nextItem == null)
        //    //    {
        //    //        g.DrawLine(
        //    //            SystemPens.ControlDarkDark,
        //    //            bounds.X,
        //    //            bounds.Height - 1,
        //    //            bounds.X + bounds.Width - 1,
        //    //            bounds.Height - 1);
        //    //    }
        //}

        //private void DrawTitleBar(Graphics g, Rectangle rect)
        //{
        //    // Assign the image for the grip.
        //    Image titlebarGrip = titleBarGripBmp;

        //    // Fill the titlebar. 
        //    // This produces the gradient and the rounded-corner effect.
        //    g.DrawLine(new Pen(titlebarColor1), rect.X, rect.Y, rect.X + rect.Width, rect.Y);
        //    g.DrawLine(new Pen(titlebarColor2), rect.X, rect.Y + 1, rect.X + rect.Width, rect.Y + 1);
        //    g.DrawLine(new Pen(titlebarColor3), rect.X, rect.Y + 2, rect.X + rect.Width, rect.Y + 2);
        //    g.DrawLine(new Pen(titlebarColor4), rect.X, rect.Y + 3, rect.X + rect.Width, rect.Y + 3);
        //    g.DrawLine(new Pen(titlebarColor5), rect.X, rect.Y + 4, rect.X + rect.Width, rect.Y + 4);
        //    g.DrawLine(new Pen(titlebarColor6), rect.X, rect.Y + 5, rect.X + rect.Width, rect.Y + 5);
        //    g.DrawLine(new Pen(titlebarColor7), rect.X, rect.Y + 6, rect.X + rect.Width, rect.Y + 6);

        //    // Center the titlebar grip.
        //    g.DrawImage(
        //        titlebarGrip,
        //        new Point(rect.X + ((rect.Width / 2) - (titlebarGrip.Width / 2)),
        //        rect.Y + 1));
        //}

        //// This method handles the RenderGrip event.
        //protected override void OnRenderGrip(ToolStripGripRenderEventArgs e)
        //{
        //    DrawTitleBar(
        //        e.Graphics,
        //        new Rectangle(0, 0, e.ToolStrip.Width, 7));
        //}

        // This method handles the RenderToolStripBorder event.
        //protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        //{
        //    DrawTitleBar(
        //        e.Graphics,
        //        new Rectangle(0, 0, e.ToolStrip.Width, 7));
        //}

        // This method handles the RenderButtonBackground event.
        //protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);

        //    Color gradientBegin = Color.FromArgb(203, 225, 252);
        //    Color gradientEnd = Color.FromArgb(125, 165, 224);

        //    ToolStripButton button = e.Item as ToolStripButton;
        //    if (button.Pressed || button.Checked)
        //    {
        //        gradientBegin = Color.FromArgb(254, 128, 62);
        //        gradientEnd = Color.FromArgb(255, 223, 154);
        //    }
        //    else if (button.Selected)
        //    {
        //        gradientBegin = Color.FromArgb(255, 255, 222);
        //        gradientEnd = Color.FromArgb(255, 203, 136);
        //    }

        //    using (Brush b = new LinearGradientBrush(
        //        bounds,
        //        gradientBegin,
        //        gradientEnd,
        //        LinearGradientMode.Vertical))
        //    {
        //        g.FillRectangle(b, bounds);
        //    }

        //    e.Graphics.DrawRectangle(
        //        SystemPens.ControlDarkDark,
        //        bounds);

        //    g.DrawLine(
        //        SystemPens.ControlDarkDark,
        //        bounds.X,
        //        bounds.Y,
        //        bounds.Width - 1,
        //        bounds.Y);

        //    g.DrawLine(
        //        SystemPens.ControlDarkDark,
        //        bounds.X,
        //        bounds.Y,
        //        bounds.X,
        //        bounds.Height - 1);

        //    ToolStrip toolStrip = button.Owner;
        //    ToolStripButton nextItem = button.Owner.GetItemAt(
        //        button.Bounds.X,
        //        button.Bounds.Bottom + 1) as ToolStripButton;

        //    if (nextItem == null)
        //    {
        //        g.DrawLine(
        //            SystemPens.ControlDarkDark,
        //            bounds.X,
        //            bounds.Height - 1,
        //            bounds.X + bounds.Width - 1,
        //            bounds.Height - 1);
        //    }
        //}
    }



}
