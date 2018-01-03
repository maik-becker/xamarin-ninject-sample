using Android.Content;
using Android.Hardware;
using Java.Lang;
using Ninject;

namespace XamarinNinjectExample.Droid
{
    public class AndroidCompass : Object, ICompass, ISensorEventListener
    {
        private readonly Sensor _orientationSensor;
        private readonly SensorManager _sensorManager;


        [Inject]
        public AndroidCompass(AppContextWrapper appContext)
        {
            _sensorManager = (SensorManager) appContext.AppContext.GetSystemService(Context.SensorService);
            _orientationSensor = _sensorManager.GetDefaultSensor(SensorType.Orientation);
        }

        public event Compass.CompassUpdatedHandler CompassUpdated;

        public void OnAccuracyChanged(Sensor sensor, SensorStatus accuracy)
        {
            // Do nothing
        }

        public void OnSensorChanged(SensorEvent e)
        {
            CompassUpdated?.Invoke(e.Values[0]);
        }

        public void Resume()
        {
            _sensorManager.RegisterListener(this, _orientationSensor, SensorDelay.Game);
        }

        public void Pause()
        {
            _sensorManager.UnregisterListener(this);
        }
    }
}