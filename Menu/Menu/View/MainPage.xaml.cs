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
            { new Menu.Model.MenuItem {  Name = "Sabor do Oeste", Description = "Um hambúrguer com molho barbecue, cebolas caramelizadas e queijo cheddar", Price = 25.00m}},
            { new Menu.Model.MenuItem {  Name = "Clássico Americano", Description = "Um hambúrguer simples com alface, tomate, queijo e maionese", Price = 20.00m}},
            { new Menu.Model.MenuItem {  Name = "Picante Mexicano", Description = "Hambúrguer com pimentão jalapeño, guacamole, queijo pepper jack e molho de chipotle", Price = 28.00m}},
            { new Menu.Model.MenuItem {  Name = "Rei da Selva", Description = "Um hambúrguer com bacon defumado, cebola crocante, queijo suíço e molho de mostarda e mel", Price = 30.00m}},
            { new Menu.Model.MenuItem {  Name = "Delícia Vegetariana", Description = "Hambúrguer de feijão preto com abacate, tomate, alface e molho de iogurte com ervas", Price = 22.00m}},
            { new Menu.Model.MenuItem {  Name = "Gigante do Pacífico", Description = "Hambúrguer de salmão grelhado com molho aioli de limão, rúcula e tomate", Price = 35.00m}},
            { new Menu.Model.MenuItem {  Name = "Festa no Campo", Description = "Hambúrguer de carne de porco desfiada com molho barbecue caseiro, coleslaw e cebola crispy", Price = 32.00m}},
            { new Menu.Model.MenuItem {  Name = "Mediterrâneo", Description = " Hambúrguer de cordeiro com queijo feta, azeitonas kalamata, tomate seco e molho tzatziki", Price = 33.00m}},
            { new Menu.Model.MenuItem {  Name = "Havaiano Tropicália", Description = "Hambúrguer de frango grelhado com abacaxi caramelizado, queijo provolone, alface e molho teriyaki", Price = 29.00m}},
            { new Menu.Model.MenuItem {  Name = "Sabor da Itália", Description = "Hambúrguer de carne de vitela com queijo mozzarella, pesto de manjericão, tomate fresco e rúcula", Price = 31.00m}},
        };

        MenuDrinksList = new ObservableCollection<Menu.Model.DrinksItens>()
        {
            { new Menu.Model.DrinksItens {  Name = "Sunset Sipper", Description = "Uma mistura refrescante de rum, suco de laranja e grenadine, servido com gelo e uma fatia de laranja para decorar", Price = 25.00m}},
            { new Menu.Model.DrinksItens {  Name = "Tropical Dream", Description = "Um coquetel exótico feito com rum, suco de abacaxi, coco cremoso e um toque de suco de limão, decorado com uma fatia de abacaxi", Price = 20.00m}},
            { new Menu.Model.DrinksItens {  Name = "Midnight Martini", Description = "Um elegante martini escuro, preparado com vodka, licor de café e um toque de creme, servido em uma taça de coquetel gelada", Price = 28.00m}},
            { new Menu.Model.DrinksItens {  Name = "Sapphire Breeze", Description = "Uma bebida refrescante feita com gin, blue curaçao, suco de limão e soda, servida sobre gelo com uma rodela de limão", Price = 30.00m}},
            { new Menu.Model.DrinksItens {  Name = "Golden Margarita", Description = "Uma margarita dourada e cintilante, preparada com tequila, licor de laranja, suco de limão fresco e uma pitada de açúcar, servida com uma borda de sal e uma fatia de limão", Price = 22.00m}},
            { new Menu.Model.DrinksItens {  Name = "Berry Bliss Mocktail", Description = "Um mocktail refrescante e frutado, feito com uma mistura de sucos de frutas vermelhas, soda limonada e um toque de xarope de açúcar, decorado com amoras frescas", Price = 35.00m}},
            { new Menu.Model.DrinksItens {  Name = "Citrus Sparkler", Description = "Uma bebida efervescente e cítrica feita com suco de laranja, limonada, soda e fatias de limão para um toque refrescante", Price = 32.00m}},
            { new Menu.Model.DrinksItens {  Name = "Mango Tango Cooler", Description = "Um mocktail tropical feito com purê de manga, suco de laranja, soda limonada e um toque de suco de limão, servido com gelo e uma fatia de manga para decorar", Price = 33.00m}},
            { new Menu.Model.DrinksItens {  Name = "Refreshing Cucumber Splash", Description = " Uma bebida refrescante e revitalizante feita com suco de pepino, água com gás, hortelã fresca e uma pitada de suco de limão, servida sobre gelo com uma fatia de pepino.", Price = 29.00m}},
            { new Menu.Model.DrinksItens {  Name = "Tropical Paradise Punch", Description = "Uma punch sem álcool cheia de sabores tropicais, feita com uma mistura de sucos de frutas tropicais, refrigerante de limão e pedaços de frutas frescas, como abacaxi e kiwi, para uma explosão de sabor.", Price = 31.00m}},
        };

        BindingContext = this;
    }
}