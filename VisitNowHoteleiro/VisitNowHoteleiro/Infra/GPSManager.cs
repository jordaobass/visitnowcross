using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using System;
using System.Threading.Tasks;

namespace VisitNowHoteleiro.Infra
{
    public class GPSManager
    {
        private EventHandler<PositionEventArgs> _positionChanged { get; set; }
        private EventHandler<PositionErrorEventArgs> _positionError { get; set; }

        public async Task StartListening(EventHandler<PositionEventArgs> positionChanged, EventHandler<PositionErrorEventArgs> positionError)
        {
            _positionChanged = positionChanged;
            _positionError = positionError;

            if (CrossGeolocator.Current.IsListening)
            {
                return;
            }

            await CrossGeolocator.Current.StartListeningAsync(TimeSpan.FromSeconds(5), 10, true);

            CrossGeolocator.Current.PositionChanged += this._positionChanged;
            CrossGeolocator.Current.PositionError += this._positionError;
        }

        public async Task StopListening()
        {
            if (!CrossGeolocator.Current.IsListening)
            {
                return;
            }

            await CrossGeolocator.Current.StopListeningAsync();

            CrossGeolocator.Current.PositionChanged -= this._positionChanged;
            CrossGeolocator.Current.PositionError -= this._positionError;
        }

        public async Task<Position> GetCurrentLocation()
        {
            Position position = null;
            try
            {
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 100;

                position = await locator.GetLastKnownLocationAsync();

                if (!locator.IsGeolocationAvailable || !locator.IsGeolocationEnabled)
                {
                    //not available or enabled
                    return default(Position);
                }

                position = await locator.GetPositionAsync(TimeSpan.FromSeconds(20), null, true);

            }
            catch (Exception)
            {
                //Display error as we have timed out or can't get location.
                //var err = ex.ToString();
            }

            if (position == null)
            {
                return default(Position);
            }

            /*
            var output = string.Format("Time: {0} \nLat: {1} \nLong: {2} \nAltitude: {3} \nAltitude Accuracy: {4} \nAccuracy: {5} \nHeading: {6} \nSpeed: {7}",
                position.Timestamp,
                position.Latitude,
                position.Longitude,
                position.Altitude,
                position.AltitudeAccuracy,
                position.Accuracy,
                position.Heading,
                position.Speed);
            */

            return position;
        }
    }
}
