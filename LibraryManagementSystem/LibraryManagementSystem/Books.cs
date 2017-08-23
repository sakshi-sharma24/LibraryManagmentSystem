using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    public enum Genre
    {
        Sciencefiction,
        Satire,
        Drama,
        Action,
        Adventure,
        Romance,
        Mystery,
        Horror,
        Selfhelp,
        Health,
        Guide,
        Travel,
        Children,
        Religion,
        Spirituality,
        Science,
        History,
        Math,
        Anthology,
        Poetry,
        Encyclopedias,
        Dictionaries,
        Comics,
        Art,
        Cookbooks,
        Diaries,
        Journals,
        Prayer,
        Series,
        Trilogy,
        Biographies,
        Autobiographies,
        Fantasy
    }

    public class Books
    {
        public string Name { get; private set; }
        public Genre Category { get; }
        public long ISBNNumber { get; private set; }
        public List<string> AuthorName { get; set; }
        public string PublisherName { get; private set; }
        public int Edition { get; private set; }


        public Books(string name, Genre genre, long isbnnumber, List<string> authorname, string publishername, int edition)
        {
            Name = name;
            Category = genre;
            ISBNNumber = isbnnumber;
            AuthorName = authorname;
            PublisherName = publishername;
            Edition = edition;
        }

        public override string ToString()
        {
            return Name + " " + Category + " " + ISBNNumber + " " + AuthorName + " " + PublisherName + " " + Edition;
        }
    }
}
