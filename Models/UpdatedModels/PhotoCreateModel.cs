namespace PhotoStock.Models.UpdatedModels
{
    public class PhotoCreateModel
    {
        public string Name { get; set; }
        public string ContentUrl { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Cost { get; set; }
        public int PurchaseAmount { get; set; }
        public Author Author { get; set; }
    }
}
