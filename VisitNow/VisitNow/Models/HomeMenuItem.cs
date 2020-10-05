namespace VisitNow.Models
{
    public enum MenuItemType
    {
        Items,
        Reservations,
        People,
        PaymentMethod,
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
