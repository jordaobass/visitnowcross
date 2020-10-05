using System.Collections.Generic;
using Xamarin.Forms;

namespace VisitNowHoteleiro.Infra
{
    public static class SharedPreferencesManager
    {
        public static void SaveOrUpdate(string key, object value)
        {
            if (!Application.Current.Properties.Keys.Contains(key))
            {
                Application.Current.Properties.Add(key, value);
            }
            else
            {
                Application.Current.Properties[key] = value;
            }

            Application.Current.SavePropertiesAsync();
        }

        public static void Remove(string key)
        {
            if (Application.Current.Properties.Keys.Contains(key))
            {
                Application.Current.Properties.Remove(key);
            }

            Application.Current.SavePropertiesAsync();
        }

        public static object GetByKey(string key)
        {
            if (Application.Current.Properties.Keys.Contains(key))
            {
                return Application.Current.Properties[key];
            }
            else
            {
                return null;
            }
        }

        public static void TryGetValue(string key, out object value)
        {
            Application.Current.Properties.TryGetValue(key, out value);
        }

        public static ICollection<string> GetAllKeys()
        {
            return Application.Current.Properties.Keys;
        }
    }
}
