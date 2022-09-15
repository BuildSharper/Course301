using BuildSharper.Course301.App1.Models;

namespace BuildSharper.Course301.App1.Services.Interfaces
{
    public interface IDrinkService
    {
        List<Drink> GetDrinks();

        Drink GetDrink(Guid drinkId);
    }
}
