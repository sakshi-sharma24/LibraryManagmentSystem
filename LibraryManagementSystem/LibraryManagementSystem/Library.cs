using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    public class Library
    {

        List<Books> Bookslist = new List<Books>();
        public List<Books> SelectedBooks { get; private set; }
        public string LibraryName { get; private set; }
        public string LibraryLocation { get; private set; }
        public string PersonName { get; private set; }
        public long IssuedId { get; private set; }

        public Library(List<Books> selectedbooks, string nameoflibrary, string locationoflibrary, string nameofperson, long id)
        {
            SelectedBooks = selectedbooks;
            LibraryName = nameoflibrary;
            LibraryLocation = locationoflibrary;
            PersonName = nameofperson;
            IssuedId = id;
        }

        public void AddBooks(List<Books> selected)
        {
            foreach (Books book in selected)
            {
                selected.Add(book);
            }
        }

        public Books IssueBook(List<Books> selectedbooks)
        {
            if (selectedbooks.Count != 0)
            {
                Books issuedbooks = selectedbooks[0];
                selectedbooks.RemoveAt(0);
                return issuedbooks;
            }
            else
            {
                return null;
            }
        }


    }
}
