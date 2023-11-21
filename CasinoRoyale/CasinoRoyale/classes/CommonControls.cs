using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CasinoRoyale.classes
{
    class CommonControls
    {
        // Remove square corners and create round rectangle corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );

        // Create common form styles
        public static void FormStyle(Form objForm)
        {
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.StartPosition = FormStartPosition.CenterScreen;
        }

        // Create FadeIn effects
        public static void FadeInEffect(Form objForm)
        {
            if (objForm.Opacity < 1)
                objForm.Opacity += .2;
        }

        // Create FadeOut effects
        public static void FadeOutEffect(Form objForm)
        {
            if (objForm.Opacity > 0)
                objForm.Opacity -= .2;
        }

        // Display custom messages
        public static void DisplayCustomMessage(Form objForm, string message)
        {
            MessageBox.Show(objForm, message, "Casino Royale", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
