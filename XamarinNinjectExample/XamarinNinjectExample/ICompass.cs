using System.Collections.Generic;

namespace XamarinNinjectExample
{
    public interface ICompass
    {
        event Compass.CompassUpdatedHandler CompassUpdated;

        void Resume();

        void Pause();
    }

    public sealed class Compass
    {   
        public delegate void CompassUpdatedHandler(double degrees);
    }
}
