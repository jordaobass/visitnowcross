using VisitNowHoteleiro.Infra.Backend;

namespace VisitNowHoteleiro.Infra.Services
{
    public abstract class ServiceBase
    {
        protected BackendConnector _connector;

        protected virtual BackendConnector GetBackendConnector()
        {
            if (_connector == null)
            {
                _connector = new BackendConnector();
            }

            return _connector;
        }

        protected virtual BackendConnector GetBackendConnector(string baseAddress)
        {
            if (_connector == null)
            {
                _connector = new BackendConnector(baseAddress);
            }

            return _connector;
        }
    }
}
