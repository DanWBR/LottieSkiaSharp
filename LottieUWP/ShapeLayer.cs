﻿using System.Collections.Generic;
using Windows.Foundation;
using MathNet.Numerics.LinearAlgebra.Single;

namespace LottieUWP
{
    internal class ShapeLayer : BaseLayer
    {
        private readonly ContentGroup _contentGroup;

        internal ShapeLayer(LottieDrawable lottieDrawable, Layer layerModel) : base(lottieDrawable, layerModel)
        {

            var shapeGroup = new ShapeGroup(layerModel.Name, layerModel.Shapes);
            _contentGroup = new ContentGroup(lottieDrawable, this, shapeGroup);
            _contentGroup.SetContents(new List<IContent>(), new List<IContent>());
        }

        public override void DrawLayer(BitmapCanvas canvas, DenseMatrix parentMatrix, int parentAlpha)
        {
            _contentGroup.Draw(canvas, parentMatrix, parentAlpha);
        }

        public override void GetBounds(out Rect outBounds, DenseMatrix parentMatrix)
        {
            base.GetBounds(out outBounds, parentMatrix);
            _contentGroup.GetBounds(out outBounds, BoundsMatrix);
        }

        public override void AddColorFilter(string layerName, string contentName, ColorFilter colorFilter)
        {
            _contentGroup.AddColorFilter(layerName, contentName, colorFilter);
        }
    }
}