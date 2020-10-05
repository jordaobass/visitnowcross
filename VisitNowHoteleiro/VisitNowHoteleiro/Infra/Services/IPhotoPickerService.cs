using System.IO;
using System.Threading.Tasks;

namespace VisitNowHoteleiro.Infra.Services
{
    public interface IPhotoPickerService
    {
        Task<Stream> GetImageStreamAsync();
    }
}
