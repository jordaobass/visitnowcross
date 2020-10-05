using System.Threading.Tasks;

namespace VisitNow.Infra.Services
{
    public class DataService : ServiceBase
    {
        //public async Task<Backend.BackendResponseResult> GetData(string authToken)
        //{
        //    Backend.BackendResponseResult _result = await GetBackendConnector().GetDataAsync(@"/data/company", "", authToken);

        //    if (_result.Result != Backend.ERequestResult.SUCESSO)
        //    {
        //        Backend.RESTServiceCallException functionalErrorException = new Backend.RESTServiceCallException() { ErrorList = _result.Error };
        //        throw functionalErrorException;
        //    }

        //    return _result;
        //}

        //public async Task<Backend.BackendResponseResult> UpdateData(Models.DataModel data, string authToken)
        //{
        //    Backend.BackendResponseResult _result = await GetBackendConnector().SaveOrUpdateAsync(data, "PUT", @"/data/company", "", authToken);

        //    if (_result.Result != Backend.ERequestResult.SUCESSO)
        //    {
        //        Backend.RESTServiceCallException functionalErrorException = new Backend.RESTServiceCallException() { ErrorList = _result.Error };
        //        throw functionalErrorException;
        //    }

        //    return _result;
        //}
    }
}
