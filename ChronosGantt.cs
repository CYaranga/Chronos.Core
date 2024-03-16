using SkiaSharp;
using SkiaSharp.Views.Desktop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Core
{
    //Create custom parameters for the control
    public class ChronosGantt: SKControl
    {
        [Description("Custom text property for the component"), Category("Custom")]
        public SKColor BackgroundDatesColor { get; set; } = SKColors.White;

        public ChronosGantt()
        {
            this.BackColor = System.Drawing.Color.White;
        }

        protected override void OnPaintSurface(SKPaintSurfaceEventArgs e)
        {
            base.OnPaintSurface(e);
            var canvas = e.Surface.Canvas;
            canvas.Clear(SKColors.White);
            DrawDatesArea(canvas);
        }

        private void DrawDatesArea(SKCanvas canvas)
        {
            canvas.DrawRect(0, 0, this.Width, 100, new SKPaint() { Color = SKColors.Orange });
        }
    }
}
