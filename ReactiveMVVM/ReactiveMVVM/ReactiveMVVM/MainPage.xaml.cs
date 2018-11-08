using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReactiveSample
{
    public partial class MainPage : ContentPage, IViewFor<BookListViewModel>
    {

       // readonly CompositeDisposable _bindingsDisposable = new CompositeDisposable();

        public BookListViewModel ViewModel { get; set; }
        
        #region Constructor
        public MainPage()
        {
            InitializeComponent();
            ViewModel = new BookListViewModel();
            this.Bind(ViewModel, vm => vm.Books, v => v.listview.ItemsSource);

        }
        #endregion

        //#region Protected Methods
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    ViewModel = new ArticleListViewModel();

        //    this.Bind(ViewModel, vm => vm.Articles, v => v.Articles.ItemsSource).DisposeWith(_bindingsDisposable);
        //}

        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();
        //    _bindingsDisposable.Clear();
        //}
        //#endregion

        #region ViewModel Setup
        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (BookListViewModel)value; }
        }
        #endregion
    }

}
