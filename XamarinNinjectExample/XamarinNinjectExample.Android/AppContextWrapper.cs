using Android.Content;

namespace XamarinNinjectExample.Droid
{
    /// <summary>
    ///     Makes the app context available via DependencyInjection
    /// </summary>
    public class AppContextWrapper
    {
        public Context AppContext { get; private set; }

        public void UseContext(Context context)
        {
            AppContext = context;
        }
    }
}