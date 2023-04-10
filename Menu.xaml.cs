namespace Calculator;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

	private void OnLightTheme(object sender, EventArgs e)
	{
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new LightTheme());
        }
    }

	private void OnDarkTheme(object sender, EventArgs e)
	{
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new DarkTheme());
        }
    }

	private void OnRedTheme(object sender, EventArgs e)
	{
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new RedTheme());
        }
    }

	private void OnPinkTheme(object sender, EventArgs e)
	{
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new PinkTheme());

        }
    }

    void RedTheme(System.Object sender, System.EventArgs e)
    {
    }
}