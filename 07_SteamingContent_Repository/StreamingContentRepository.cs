using _07_SteamingContent_Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SteamingContent_Repository
{
    public class StreamingContentRepository
    {
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        // CRUD methods below "Create Read Update Delete"
        // Create
        // Content

        public bool AddContentToDirtectory(StreamingContent newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;

            return wasAdded;
        }

        // Movie
        public bool AddContentToDirtectory(Movie newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;

            return wasAdded;
        }

        // Show

        // Episode
        // Read All
        // Content Read All
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        //Movie Read All
        public List<Movie> GetMovies()
        {
            // Initialize empty list
            List <Movie> allMovies = new List<Movie>();
            // Look thorugh our directory
            foreach(StreamingContent content in _contentDirectory)
            {
                // check if object is a Movie class
                if (content is Movie)
                {              
                              // Load into our list
                              // (content as Movie);
                    allMovies.Add((Movie)content);
                }
            }
            // Return out list
            return allMovies;
        }
        //Show Read All
        public List<Show> GetShows()
        {
            // setup our list
            List<Show> allShows = new List<Show>();
            // find our shows
            foreach(StreamingContent content in _contentDirectory)
            {
                // check if object is a Shows class
                if (content is Show)
                {
                    // Load into our list
                    // (content as Show)
                    allShows.Add((Show)content);
                }
            }
            // Gives shows back
            return allShows;
        }
        //Episode Read All

        // Get By Title
        // Content
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        // Movie
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent movie in _contentDirectory)
            {                                                // Using is to make sure movie 'is' of a class type Movie
                if (movie.Title.ToLower() == title.ToLower() && movie is Movie)
                {
                    return (Movie)movie;
                 // return movie as Movie "Using 'as' as a way to cast"
                }
            }
            return null;
        }
        // Show
        // GetShowByTitle
        // Accessor // Return Type // Name (Parameters)
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.Title.ToLower() == title.ToLower() && show.GetType() == typeof(Show))
                {
                    return (Show)show;
                }
            }
            return null;
        }
        // Epidsode

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContentValues)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if(oldContent != null)
            {
                oldContent.Title = newContentValues.Title;
                oldContent.Description = newContentValues.Description;
                oldContent.StarRating = newContentValues.StarRating;
                oldContent.TypeOfGenre = newContentValues.TypeOfGenre;
                oldContent.MaturityRating = newContentValues.MaturityRating;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingContent(string titleToDelete)
        {
            StreamingContent contentToDelete = GetContentByTitle(titleToDelete);
            if(contentToDelete == null)
            {
                return false;
            }
            else
            {
                _contentDirectory.Remove(contentToDelete);
                return true;
            }
        }
    }
}
