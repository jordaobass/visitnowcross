namespace VisitNowHoteleiro.Models
{
    public enum MenuItemType
    {
        Browse,
        Hotel,
        About,
        Exit
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
    }
}
