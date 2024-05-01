using System.Collections.ObjectModel;

namespace Menu.View;

public partial class MainPage : ContentPage
{

	private ObservableCollection<MenuItem> _MenuItensList;

	public ObservableCollection<MenuItem> MenuItensList
    {
		get { return _MenuItensList; }
		set { _MenuItensList = value; }
	}


	public MainPage()
	{
		InitializeComponent();

		MenuItensList = new ObservableCollection<MenuItem>()
		{
			
		};

        BindingContext = this;
    }
}