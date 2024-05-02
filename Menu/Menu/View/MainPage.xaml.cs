using System.Collections.ObjectModel;

namespace Menu.View;

public partial class MainPage : ContentPage
{

	private ObservableCollection<Menu.Model.MenuItem> _MenuItensList;

	public ObservableCollection<Menu.Model.MenuItem> MenuItensList
    {
		get { return _MenuItensList; }
		set { _MenuItensList = value; }
	}

    private ObservableCollection<Menu.Model.DrinksItens> _MenuDrinksList;

    public ObservableCollection<Menu.Model.DrinksItens> MenuDrinksList
    {
        get { return _MenuDrinksList; }
        set { _MenuDrinksList = value; }
    }


    public MainPage()
	{
		InitializeComponent();

        MenuItensList = new ObservableCollection<Menu.Model.MenuItem>()
        {
            { new Menu.Model.MenuItem {  Name = "Sabor do Oeste", Description = "Um hamb�rguer com molho barbecue, cebolas caramelizadas e queijo cheddar", Price = 25.00m}},
            { new Menu.Model.MenuItem {  Name = "Cl�ssico Americano", Description = "Um hamb�rguer simples com alface, tomate, queijo e maionese", Price = 20.00m}},
            { new Menu.Model.MenuItem {  Name = "Picante Mexicano", Description = "Hamb�rguer com piment�o jalape�o, guacamole, queijo pepper jack e molho de chipotle", Price = 28.00m}},
            { new Menu.Model.MenuItem {  Name = "Rei da Selva", Description = "Um hamb�rguer com bacon defumado, cebola crocante, queijo su��o e molho de mostarda e mel", Price = 30.00m}},
            { new Menu.Model.MenuItem {  Name = "Del�cia Vegetariana", Description = "Hamb�rguer de feij�o preto com abacate, tomate, alface e molho de iogurte com ervas", Price = 22.00m}},
            { new Menu.Model.MenuItem {  Name = "Gigante do Pac�fico", Description = "Hamb�rguer de salm�o grelhado com molho aioli de lim�o, r�cula e tomate", Price = 35.00m}},
            { new Menu.Model.MenuItem {  Name = "Festa no Campo", Description = "Hamb�rguer de carne de porco desfiada com molho barbecue caseiro, coleslaw e cebola crispy", Price = 32.00m}},
            { new Menu.Model.MenuItem {  Name = "Mediterr�neo", Description = " Hamb�rguer de cordeiro com queijo feta, azeitonas kalamata, tomate seco e molho tzatziki", Price = 33.00m}},
            { new Menu.Model.MenuItem {  Name = "Havaiano Tropic�lia", Description = "Hamb�rguer de frango grelhado com abacaxi caramelizado, queijo provolone, alface e molho teriyaki", Price = 29.00m}},
            { new Menu.Model.MenuItem {  Name = "Sabor da It�lia", Description = "Hamb�rguer de carne de vitela com queijo mozzarella, pesto de manjeric�o, tomate fresco e r�cula", Price = 31.00m}},
        };

        MenuDrinksList = new ObservableCollection<Menu.Model.DrinksItens>()
        {
            { new Menu.Model.DrinksItens {  Name = "Sunset Sipper", Description = "Uma mistura refrescante de rum, suco de laranja e grenadine, servido com gelo e uma fatia de laranja para decorar", Price = 25.00m}},
            { new Menu.Model.DrinksItens {  Name = "Tropical Dream", Description = "Um coquetel ex�tico feito com rum, suco de abacaxi, coco cremoso e um toque de suco de lim�o, decorado com uma fatia de abacaxi", Price = 20.00m}},
            { new Menu.Model.DrinksItens {  Name = "Midnight Martini", Description = "Um elegante martini escuro, preparado com vodka, licor de caf� e um toque de creme, servido em uma ta�a de coquetel gelada", Price = 28.00m}},
            { new Menu.Model.DrinksItens {  Name = "Sapphire Breeze", Description = "Uma bebida refrescante feita com gin, blue cura�ao, suco de lim�o e soda, servida sobre gelo com uma rodela de lim�o", Price = 30.00m}},
            { new Menu.Model.DrinksItens {  Name = "Golden Margarita", Description = "Uma margarita dourada e cintilante, preparada com tequila, licor de laranja, suco de lim�o fresco e uma pitada de a��car, servida com uma borda de sal e uma fatia de lim�o", Price = 22.00m}},
            { new Menu.Model.DrinksItens {  Name = "Berry Bliss Mocktail", Description = "Um mocktail refrescante e frutado, feito com uma mistura de sucos de frutas vermelhas, soda limonada e um toque de xarope de a��car, decorado com amoras frescas", Price = 35.00m}},
            { new Menu.Model.DrinksItens {  Name = "Citrus Sparkler", Description = "Uma bebida efervescente e c�trica feita com suco de laranja, limonada, soda e fatias de lim�o para um toque refrescante", Price = 32.00m}},
            { new Menu.Model.DrinksItens {  Name = "Mango Tango Cooler", Description = "Um mocktail tropical feito com pur� de manga, suco de laranja, soda limonada e um toque de suco de lim�o, servido com gelo e uma fatia de manga para decorar", Price = 33.00m}},
            { new Menu.Model.DrinksItens {  Name = "Refreshing Cucumber Splash", Description = " Uma bebida refrescante e revitalizante feita com suco de pepino, �gua com g�s, hortel� fresca e uma pitada de suco de lim�o, servida sobre gelo com uma fatia de pepino.", Price = 29.00m}},
            { new Menu.Model.DrinksItens {  Name = "Tropical Paradise Punch", Description = "Uma punch sem �lcool cheia de sabores tropicais, feita com uma mistura de sucos de frutas tropicais, refrigerante de lim�o e peda�os de frutas frescas, como abacaxi e kiwi, para uma explos�o de sabor.", Price = 31.00m}},
        };

        BindingContext = this;
    }
}