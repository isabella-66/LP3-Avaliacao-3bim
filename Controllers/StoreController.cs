using Microsoft.AspNetCore.Mvc;
using LP3_Avaliacao_3bi.ViewModels;

namespace LP3_Avaliacao_3bi.Controllers;

public class StoreController : Controller
{
    public static List<ShoppingViewModel> stores = new List<ShoppingViewModel>
    {
        new ShoppingViewModel(1, "Piso 2", "Leitura", "Entre no mundo dos livros e conheça outros milhares mundos!", "Loja", "leitura@hotmail.com"),
        new ShoppingViewModel(2, "Piso 1", "Kalunga", "Os mais diversos materiais que você precisa!", "Loja", "kalunga@hotmail.com"),
        new ShoppingViewModel(3, "Piso 3", "Mr Cheney", "Os cookies americanos originais mais deliciosos para você se deliciar!", "Quiosque", "mrcheney@hotmail.com"),
        new ShoppingViewModel(34, "Piso 1", "Baccio Di Latte", "O melhor sorvete direto da Itália!", "Quiosque", "bacciodl@hotmail.com"),
        new ShoppingViewModel(38, "Piso 3", "Mr Nuts", "Grãos caramelizados para adoçar a sua vida!", "Quiosque", "mrnuts@hotmail.com"),
    };
}