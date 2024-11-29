using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CoffeeShop_IMS
{
    internal class FormStylingCorners
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        public static void ApplyRoundedCorners(Form form, int ellipseWidth, int ellipseHeight)
        {
            if (form != null)
            {
                form.FormBorderStyle = FormBorderStyle.None;
                form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, ellipseWidth, ellipseHeight));
            }
        }

    }
}
