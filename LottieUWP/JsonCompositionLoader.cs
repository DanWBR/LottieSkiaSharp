﻿using System.Threading;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.Graphics.Display;

namespace LottieUWP
{
    internal sealed class JsonCompositionLoader
    {
        private readonly IOnCompositionLoadedListener _loadedListener;
        private readonly CancellationToken _cancellationToken;

        internal JsonCompositionLoader(IOnCompositionLoadedListener loadedListener, CancellationToken cancellationToken)
        {
            _loadedListener = loadedListener;
            _cancellationToken = cancellationToken;
        }

        internal async Task<LottieComposition> Execute(params JsonObject[] @params)
        {
            var tcs = new TaskCompletionSource<LottieComposition>();
            var resolutionScale = DisplayInformation.GetForCurrentView().ResolutionScale;
            await Task.Run(() =>
            {
                tcs.SetResult(LottieComposition.Factory.FromJsonSync(resolutionScale, @params[0]));
            }, _cancellationToken);
            var result = await tcs.Task;
            _loadedListener.OnCompositionLoaded(result);
            return result;
        }
    }
}