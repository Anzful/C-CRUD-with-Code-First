namespace MoviesCRUD.Models
{
    public class Director
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalityID { get; set; }
        public Nationality Nationality { get; set; }
    }
}
