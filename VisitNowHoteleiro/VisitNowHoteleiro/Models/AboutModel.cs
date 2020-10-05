namespace VisitNowHoteleiro.Models
{
    public class AboutModel : BaseModel
    {
        private string versionNumber;
        private string versionName;

        public string VersionNumber
        {
            get { return versionNumber; }
            set
            {
                versionNumber = value;
                OnPropertyChanged("VersionNumber");
            }
        }

        public string VersionName
        {
            get { return versionName; }
            set
            {
                versionName = value;
                OnPropertyChanged("VersionName");
            }
        }
    }
}
