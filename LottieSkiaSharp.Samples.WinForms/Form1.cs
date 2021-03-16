using LottieSharp;
using SkiaSharp;
using SkiaSharp.Views.Desktop;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LottieSkiaSharp.Samples.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var json = File.ReadAllText("data.json");
            var result = LottieCompositionFactory.FromJsonStringSync(json, "lol");

            _lottieDrawable.SetComposition(result.Value);
            _lottieDrawable.RepeatMode = RepeatMode.Restart;
            _lottieDrawable.RepeatCount = -1; //-1 == infinite
            _lottieDrawable.AnimatorUpdate += _lottieDrawable_AnimatorUpdate;

            _lottieDrawable.Start();            
        }

        LottieDrawable _lottieDrawable = new LottieDrawable();

        private void _lottieDrawable_AnimatorUpdate(object sender, ValueAnimator.ValueAnimatorUpdateEventArgs e)
        {
            //Trace.WriteLine($"AnimatorUpdate Frame:{_lottieDrawable.Frame}");
            skglControl1.Invalidate();
        }

        private void skglControl1_PaintSurface(object sender, SKPaintGLSurfaceEventArgs e)
        {
            //This is just set here so we have a background color
            e.Surface.Canvas.DrawColor(SKColors.AliceBlue);

            //
            _lottieDrawable.Draw(e.Surface.Canvas);
        }
    }
}
