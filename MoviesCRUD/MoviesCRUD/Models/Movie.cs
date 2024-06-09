using MoviesCRUD.Models;

public class Movie
{
    public int ID { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public int YearOfRelease { get; set; }
    public int MovieCategoryID { get; set; } 
    public int DirectorID { get; set; }
    public virtual Category Category { get; set; } 
    public virtual Director Director { get; set; }
    public virtual MovieReview Review { get; set; }
}
