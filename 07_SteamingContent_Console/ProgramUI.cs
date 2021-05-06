using _07_SteamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SteamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        //CreateNewContent
                        CreateNewContent();
                        break;
                    case "2":
                    case "two":
                        //ViewAllContent
                        DisplayAllContent();
                        break;
                    case "3":
                    case "three":
                        //View Content By Title
                        DisplayContentByTitle();
                        break;
                    case "4":
                    case "four":
                        //Update Existing Content
                        UpdateContent();
                        break;
                    case "5":
                    case "five":
                        //Delete Existing Content
                        DeleteContent();
                        break;
                    case "6":
                    case "six":
                        //Exit
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }

                ////Another option
                //if (input == "1" || input == "one")
                //{

                //}


                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }

        }
        private void CreateNewContent() // optional challenge - ask the user to confirm information before adding to directory
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description of the content");
            newContent.Description = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the Star Rating for this content (0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            // newContent.StarRating = Convert.ToDouble(Console.ReadLine)

            //GenreType
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //MaturityRating
            Console.WriteLine("Enter the maturity rating for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. TV-G\n" +
                "6. TV-PG\n" +
                "7. TV-14\n" +
                "8. TV-MA\n");

            string maturityAsString = Console.ReadLine();
            int maturityAsInt = Convert.ToInt32(maturityAsString);
            newContent.MaturityRating = (MaturityRating)maturityAsInt;
            _repo.AddContentToDirtectory(newContent);
            bool wasAddedCorrectly = _repo.AddContentToDirtectory(newContent);
            if (wasAddedCorrectly)
            {
                Console.WriteLine("The content was added correctly!");
            }
            else
            {
                Console.WriteLine("Could not add the content.");
            }
        }
        private void DisplayAllContent() // Display All Content in the Directory
        {
            Console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();
            foreach(StreamingContent content in allContent)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
                Console.ResetColor();
            }
        }

        private void DisplayContentByTitle() // Display Content By Title get title from the user then display all properties of the content that has that title.
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine($"Enter the title you would like to see.");
            StreamingContent contentToDisplay = _repo.GetContentByTitle(Console.ReadLine());

            if (contentToDisplay != null)
            {
                Console.WriteLine($"Title: {contentToDisplay.Title}\n" +
                    $"Description: {contentToDisplay.Description}\n" +
                    $"Star Rating: {contentToDisplay.StarRating}\n" +
                    $"Genre: {contentToDisplay.TypeOfGenre}\n" +
                    $"Maturity Rating: {contentToDisplay.MaturityRating}\n" +
                    $"Family Friendly: {contentToDisplay.IsFamilyFriendly}");
            }
            else
            {
                Console.WriteLine("There is no content by that title.");
            }
        }

        private void UpdateContent()
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter the title of the content you would like to update");

            string oldTitle = Console.ReadLine();

            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description of the content");
            newContent.Description = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the Star Rating for this content (0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            // newContent.StarRating = Convert.ToDouble(Console.ReadLine)

            //GenreType
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //MaturityRating
            Console.WriteLine("Enter the maturity rating for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. TV-G\n" +
                "6. TV-PG\n" +
                "7. TV-14\n" +
                "8. TV-MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());

            bool wasUpdated =_repo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("The content was updated successfully");
            }
            else
            {
                Console.WriteLine("No content by that title exists");
            }
        }

        private void DeleteContent()
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine("Enter the title for the content you want to delete.");

            bool wasDeleted = _repo.DeleteExistingContent(Console.ReadLine());

            if (wasDeleted)
            {
                Console.WriteLine("Your content was successfully deleted!");
            }
            else
            {
                Console.WriteLine("Content could not be deleted.");
            }
        }

        private void SeedContentList()
        {
            StreamingContent future = new StreamingContent("Back to the Future", "Marty gets sent back in time", 4.5, GenreType.SciFi, MaturityRating.PG);
            StreamingContent starWars = new StreamingContent("Star Wars", "Jar Jar saves the day", 3.5, GenreType.SciFi, MaturityRating.PG_13);
            StreamingContent rubber = new StreamingContent("Rubber", "A tire comes to life and has a killing spree", 1.5, GenreType.Horror, MaturityRating.R);

            _repo.AddContentToDirtectory(future);
            _repo.AddContentToDirtectory(starWars);
            _repo.AddContentToDirtectory(rubber);
        }
    }
}
