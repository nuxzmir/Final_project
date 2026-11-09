
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Дипломочка
{
    public partial class Form1
    {
        private float baseWidth;
        private float baseHeight;
        private bool scalingInitialized = false;

        private void InitializeScaling()
        {
            baseWidth = ClientSize.Width;
            baseHeight = ClientSize.Height;

            scalingInitialized = true;

            ApplyScaling();
        }

        private void ApplyScaling()
        {
            if (!scalingInitialized)
                return;

            float scaleX = ClientSize.Width / baseWidth;
            float scaleY = ClientSize.Height / baseHeight;

            ScaleControls(this, scaleX, scaleY);
        }

        private void ScaleControls(
            Control parent,
            float scaleX,
            float scaleY)
        {
            foreach (Control control in parent.Controls)
            {
                control.Left = (int)(control.Left * scaleX);
                control.Top = (int)(control.Top * scaleY);
                control.Width = (int)(control.Width * scaleX);
                control.Height = (int)(control.Height * scaleY);

                float fontScale = Math.Min(scaleX, scaleY);

                control.Font = new Font(
                    control.Font.FontFamily,
                    Math.Max(6, control.Font.Size * fontScale),
                    control.Font.Style
                );

                if (control.HasChildren)
                    ScaleControls(control, scaleX, scaleY);
            }
        }
    }
}

