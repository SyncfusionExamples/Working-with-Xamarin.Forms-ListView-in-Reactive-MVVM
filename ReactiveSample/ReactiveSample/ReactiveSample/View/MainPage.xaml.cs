using ReactiveUI;
using ReactiveUI.XamForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Popup_Demo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ReactiveContentPage<ViewModel>
	{
		public MainPage(ViewModel viewModel)
		{
            ViewModel = viewModel;
            InitializeComponent();
			
        }

	}
}
