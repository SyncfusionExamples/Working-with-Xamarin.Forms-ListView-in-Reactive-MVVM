using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Popup_Demo
{
    public class ViewModel : ReactiveObject, INotifyPropertyChanged
	{

        #region Fields
        private ObservableCollection<Article> _articles;

        #endregion
        #region Properties
        public ObservableCollection<Article> Articles
        {
            get => _articles;
            set => this.RaiseAndSetIfChanged(ref _articles, value);
        }

        #endregion

        #region Constructor
        public ViewModel()
        {
            Articles = new ObservableCollection<Article>();
            var random = new Random();
            for (int i = 0; i < Titles.Count(); i++)
            {
                var details = new Article()
                {
                    Title = Titles[i],
                    Author = Authors[i],
                };
                Articles.Add(details);
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
