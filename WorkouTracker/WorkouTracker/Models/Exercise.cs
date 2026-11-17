namespace WorkouTracker.Models
{
    public class Exercise
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> Images { get; set; }
        public string Category { get; set; }

        // Segédproperty a kép URL-jének kinyeréséhez a CollectionView számára
        public string ImageUrl => Images != null && Images.Count > 0
            ? $"https://raw.githubusercontent.com/yuhonas/free-exercise-db/main/exercises/{Images[0]}"
            : null;
    }
}