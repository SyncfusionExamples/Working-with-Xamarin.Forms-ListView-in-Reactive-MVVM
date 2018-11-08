using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveSample
{
    public class BookListViewModel : ReactiveObject
    {
        #region Fields
        private ReactiveList<Book> _books;
        #endregion
        
        #region Properties
        public ReactiveList<Book> Books
        {
            get => _books;
            set => this.RaiseAndSetIfChanged(ref _books, value);
        }
        #endregion

        #region Constructor
        public BookListViewModel()
        {
            Books = new ReactiveList<Book> ();
            var random = new Random();
            for (int i = 0; i < Titles.Count(); i++)
            {
                var details = new Book()
                {
                    Title = Titles[i],
                    Author = Authors[i],
                };
                Books.Add(details);
            }
        }

        #endregion

        #region Fields

        string[] Titles = new string[]
        {
            "Fashion",
            "Electronics",
            "Home & Kitchen",
            "Sports & Health",
            "Kids",
            "Books",
            "Footware",
            "Mobile & Accesories",
            "FlowerGiftCakes",
            "Watches",
            "Jewellery",
            "Food",
            "Perfumes",
            "Movies & Music",
            "Cameras & Optics",
            "Fashion",
            "Electronics",
            "Home & Kitchen",
            "Sports & Health",
            "Kids",
            "Books",
            "Footware",
            "Mobile & Accesories",
            "FlowerGiftCakes",
            "Watches",
            "Jewellery",
            "Food",
            "Perfumes",
            "Movies & Music",
            "Cameras & Optics",
            "Fashion",
            "Electronics",
            "Home & Kitchen",
            "Sports & Health",
            "Kids",
            "Books",
            "Footware",
            "Mobile & Accesories",
            "FlowerGiftCakes",
            "Watches",
            "Jewellery",
            "Food",
            "Perfumes",
            "Movies & Music",
            "Cameras & Optics"

        };
        string[] Authors = new string[]
        {
           "Edward Abbey",
            "edwin A.Abbott",
            "Hans Aanurd",
            "Ben Aaronovitch ",
            "Christopher Abani",
            "Carmine Abate",
            "Peter Abelard",
            "Forest J. Ackerman",
            "Richard Adams",
            "Mirza Adeb",
            "Mark Twain",
            "Susan Kyle",
            "James Joyce",
            "Charles Dickens",
            "Leo Tolstoy",
            "Edward Abbey",
            "edwin A.Abbott",
            "Hans Aanurd",
            "Ben Aaronovitch ",
            "Christopher Abani",
            "Carmine Abate",
            "Peter Abelard",
            "Forest J. Ackerman",
            "Richard Adams",
            "Mirza Adeb",
            "Mark Twain",
            "Susan Kyle",
            "James Joyce",
            "Charles Dickens",
            "Leo Tolstoy",
             "Edward Abbey",
            "edwin A.Abbott",
            "Hans Aanurd",
            "Ben Aaronovitch ",
            "Christopher Abani",
            "Carmine Abate",
            "Peter Abelard",
            "Forest J. Ackerman",
            "Richard Adams",
            "Mirza Adeb",
            "Mark Twain",
            "Susan Kyle",
            "James Joyce",
            "Charles Dickens",
            "Leo Tolstoy"
        };
        #endregion
    }
}
