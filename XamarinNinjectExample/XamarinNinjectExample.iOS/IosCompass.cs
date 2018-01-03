using System;

namespace XamarinNinjectExample.iOS
{
    /// <summary>
    /// Mock-implementation (don't have an iOS device available at the moment)
    /// </summary>
    public class IosCompass : ICompass
    {
        public event Compass.CompassUpdatedHandler CompassUpdated;

        public void Resume()
        {
            CompassUpdated?.Invoke(new Random().NextDouble() * 360.0);
        }

        public void Pause()
        {
        }
    }
}