namespace LibraryManagement.Win.Models
{
    public class Tbencyclopedia
    {
        public int Id { get; set; }
        public int PublicationId { get; set; }
        public virtual Tbpublication Publication { get; set; }

    }
}