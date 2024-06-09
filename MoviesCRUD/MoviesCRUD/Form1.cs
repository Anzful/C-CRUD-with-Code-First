using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using MoviesCRUD.Models;

namespace MoviesCRUD
{
    public partial class Form1 : Form
    {
        private MovieContext db = new MovieContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.Movies.Load();
            dataGridViewMovies.DataSource = db.Movies.Local.ToBindingList();
        }

        private void add_Click(object sender, EventArgs e)
        {
            var movie = new Movie
            {
                Title = title.Text,
                DurationInMinutes = int.Parse(duration.Text),
                YearOfRelease = int.Parse(year.Text),
                Category = new Category { Name = category.Text },
                Director = new Director
                {
                    FirstName = firstname.Text,
                    LastName = lastname.Text,
                    Nationality = new Nationality { Name = nationality.Text }
                },
                Review = new MovieReview
                {
                    Comment = comment.Text,
                    ReviewDate = reviewdate.Value,
                    Score = score.Value
                }
            };

            db.Movies.Add(movie);
            db.SaveChanges();
            dataGridViewMovies.Refresh();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridViewMovies.CurrentRow != null)
            {
                int id = (int)dataGridViewMovies.CurrentRow.Cells[0].Value;
                var movie = db.Movies.Include(m => m.Director).Include(m => m.Review).FirstOrDefault(m => m.ID == id);

                if (movie != null)
                {
                    movie.Title = title.Text;
                    movie.DurationInMinutes = int.Parse(duration.Text);
                    movie.YearOfRelease = int.Parse(year.Text);
                    movie.Category.Name = category.Text;
                    movie.Director.FirstName = firstname.Text;
                    movie.Director.LastName = lastname.Text;
                    movie.Director.Nationality.Name = nationality.Text;
                    movie.Review.Comment = comment.Text;
                    movie.Review.ReviewDate = reviewdate.Value;
                    movie.Review.Score = score.Value;

                    db.SaveChanges();
                    dataGridViewMovies.Refresh();
                }
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (dataGridViewMovies.CurrentRow != null)
            {
                int id = (int)dataGridViewMovies.CurrentRow.Cells[0].Value;
                var movie = db.Movies.Include(m => m.Director).Include(m => m.Review).FirstOrDefault(m => m.ID == id);

                if (movie != null)
                {
                    db.Movies.Remove(movie);
                    db.SaveChanges();
                    dataGridViewMovies.Refresh();
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchText = title.Text;

            if (!string.IsNullOrEmpty(searchText))
            {
                var searchResults = db.Movies.Where(m => m.Title.Contains(searchText)).ToList();
                dataGridViewMovies.DataSource = searchResults;
            }
        }

        
        private void title_TextChanged(object sender, EventArgs e) { }
        private void duration_TextChanged(object sender, EventArgs e) { }
        private void year_TextChanged(object sender, EventArgs e) { }
        private void category_TextChanged(object sender, EventArgs e) { }
        private void firstname_TextChanged(object sender, EventArgs e) { }
        private void lastname_TextChanged(object sender, EventArgs e) { }
        private void nationality_TextChanged(object sender, EventArgs e) { }
        private void reviewdate_ValueChanged(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void score_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
