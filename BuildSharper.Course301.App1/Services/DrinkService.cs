using BuildSharper.Course301.App1.Models;
using BuildSharper.Course301.App1.Services.Interfaces;

namespace BuildSharper.Course301.App1.Services
{
    public class DrinkService : IDrinkService
    {
        public Drink GetDrink(Guid drinkId)
        {
            return GetDrinks()?.Where(d => d.Id == drinkId)?.FirstOrDefault();
        }

        public List<Drink> GetDrinks()
        {
            var drinks = new List<Drink>();

            drinks.Add(new Drink()
            {
                Id = Guid.Parse("9b8a7901-befb-487d-a4ac-f2214a38acfe"),
                Name = "Margarita",
                AlcoholType = AlcoholType.Tequila,
                Instructions = "Rub the rim of the glass with the lime slice to make the salt stick to it. Take care to moisten only the outer rim and sprinkle the salt on it. The salt should present to the lips of the imbiber and never mix into the cocktail. Shake the other ingredients with ice, then carefully pour into the glass.",
                Ingredients = new List<string>()
                {
                    "1 1/2 oz Tequila",
                    "1/2 oz Triple sec",
                    "1 oz Lime juice",
                    "Salt"
                }
            });

            drinks.Add(new Drink()
            {
                Id = Guid.Parse("fe01bc81-34d1-44d9-bd0e-be8e228732fd"),
                Name = "Vodka Fizz",
                AlcoholType = AlcoholType.Vodka,
                Instructions = "Blend all ingredients, save nutmeg. Pour into large white wine glass and sprinkle nutmeg on top.",
                Ingredients = new List<string>()
                {
                    "2oz Vodka",
                    "2oz Half-and-half",
                    "2oz Limeade",
                    "Ice",
                    "Nutmeg"
                }
            });

            drinks.Add(new Drink()
            {
                Id = Guid.Parse("fbc04ec2-bb58-42b0-a599-d199b9f6b279"),
                Name = "Manhattan",
                AlcoholType = AlcoholType.Bourbon,
                Instructions = "Stirred over ice, strained into a chilled glass, garnished, and served up.",
                Ingredients = new List<string>()
                {
                    "3/4 oz Sweet Vermouth",
                    "2 1/2 oz Blended Bourbon",
                    "dash Bitters",
                    "2 or 3 Ice",
                    "1 Maraschino cherry",
                    "1 twist of Orange peel"
                }
            });

            return drinks;
        }
    }
}
