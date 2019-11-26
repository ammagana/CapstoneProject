using OrderCookDeliver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderCookDeliver.Data
{
    public class DbInitializerCalendar
    {
        public static void Initialize(OrderCookDeliverContext context)
        {
            context.Database.EnsureCreated();

            // Look for any meals.
            if (context.Calendar.Any())
            {
                return;
            }

            var meals = new Calendar[]
            {
                new Calendar{ID=1, mealName="Soba Noodle", description="Buckwheat Asian " +
                "Soba Noodles in a spicy chilli garlic sauce with sauteed Bok Choy and Edamame.",
                preparationTime= "20", pricePerServg=3.00, ingredient_1="Soy Sauce", ingredient_2="Toasted " +
                "Sesame Oil", ingredient_3="Sriracha", ingredient_4="Chili Garlic Sauce",
                ingredient_5="Rice Wine Vinegar", ingredient_6="Soba Noodles", ingredient_7="Bok Choy",
                ingredient_8="Garlic", ingredient_9="Green Onions", ingredient_10="Bean Sprouts",
                ingredient_11="Cilantro", ingredient_12="Chrushed Red Pepper Flakes", ingredient_13="Edamame",
                ingredient_14="", ingredient_15="", ingredient_16="", ingredient_17="", calPerServg=191.7,
                totalFat=9.4, saturatedFat=1.3, transFat=0, monoUnsatFat=0.61, polyUnsatFat=1.01, omega_3=0.16,
                omega_6=0.84, cholesterol=0.00, totalCarb=19.5, dietaryFiber=5.6, sugar=3.7, protein=10.8,
                procedure="Get all of the ingredients and mix them up, throw them in a pot of your choice," +
                "and cook it til it smell good."},
                new Calendar{ID=2, mealName="Quinoa Stuffed Avocado", description="Ripened " +
                "Avocado stuffed wiht a southwestern inspired quinoa.", preparationTime="20", pricePerServg=4.14,
                ingredient_1="Avocado", ingredient_2="Quinoa ", ingredient_3="Black Beans", ingredient_4=
                "Green Onions", ingredient_5="Red Bell Pepper", ingredient_6="Corn", ingredient_7="Extra Virgin" +
                "Olive Oil", ingredient_8="Lime Juice", ingredient_9="Salt", ingredient_10="", ingredient_11="",
                ingredient_12="", ingredient_13="", ingredient_14="", ingredient_15="", ingredient_16="",
                ingredient_17="", calPerServg=191.7, totalFat=9.4, saturatedFat=1.3, transFat=0,
                monoUnsatFat=0.61, polyUnsatFat=1.01, omega_3=0.16, omega_6=0.84, cholesterol=0.00,
                totalCarb=19.5, dietaryFiber=5.6, sugar=3.7, protein=10.8,
                procedure="Round up the vermin, toss'em in a pot of scalding hot boiling water, and cook it til" +
                "it smell good." },
                new Calendar{ID=3, mealName="Zucchini Noodles and Kale Pesto", description=
                "Spiral zucchini noodles tossed in kae pesto topped with shaved carrots and parmesan.",
                preparationTime="30", pricePerServg=11.98, ingredient_1="Kale", ingredient_2="Basil", ingredient_3=
                "Salt", ingredient_4="Extra Virgin Olive Oil", ingredient_5="Pine Nuts", ingredient_6="Garlic",
                ingredient_7="Parmesan", ingredient_8="Zucchini", ingredient_9="Salt", ingredient_10="Black Pepper",
                ingredient_11="Carrots", ingredient_12="", ingredient_13="", ingredient_14="", ingredient_15="",
                ingredient_16="", ingredient_17="", calPerServg=191.7, totalFat=9.4, saturatedFat=1.3, transFat=0,
                monoUnsatFat=0.61, polyUnsatFat=1.01, omega_3=0.16, omega_6=0.84, cholesterol=0.00, totalCarb=19.5,
                dietaryFiber=5.6, sugar=3.7, protein=10.8, procedure="Scale'em, gut'em, and file'em. Then, throw them" +
                "on the grill of an open fire pit and cook'em til they smell good."},
                new Calendar{ID=4, mealName="Soba Noodle", description="Buckwheat Asian " +
                "Soba Noodles in a spicy chilli garlic sauce with sauteed Bok Choy and Edamame.",
                preparationTime="20", pricePerServg=3.00, ingredient_1="Soy Sauce", ingredient_2="Toasted " +
                "Sesame Oil", ingredient_3="Sriracha", ingredient_4="Chili Garlic Sauce",
                ingredient_5="Rice Wine Vinegar", ingredient_6="Soba Noodles", ingredient_7="Bok Choy",
                ingredient_8="Garlic", ingredient_9="Green Onions", ingredient_10="Bean Sprouts",
                ingredient_11="Cilantro", ingredient_12="Chrushed Red Pepper Flakes", ingredient_13="Edamame",
                ingredient_14="", ingredient_15="", ingredient_16="", ingredient_17="", calPerServg=191.7,
                totalFat=9.4, saturatedFat=1.3, transFat=0, monoUnsatFat=0.61, polyUnsatFat=1.01, omega_3=0.16,
                omega_6=0.84, cholesterol=0.00, totalCarb=19.5, dietaryFiber=5.6, sugar=3.7, protein=10.8,
                procedure="Get all of the ingredients and mix them up, throw them in a pot of your choice," +
                "and cook it til it smell good."},
                new Calendar{ID=5, mealName="Soba Noodle", description="Buckwheat Asian " +
                "Soba Noodles in a spicy chilli garlic sauce with sauteed Bok Choy and Edamame.",
                preparationTime="20", pricePerServg=3.00, ingredient_1="Soy Sauce", ingredient_2="Toasted " +
                "Sesame Oil", ingredient_3="Sriracha", ingredient_4="Chili Garlic Sauce",
                ingredient_5="Rice Wine Vinegar", ingredient_6="Soba Noodles", ingredient_7="Bok Choy",
                ingredient_8="Garlic", ingredient_9="Green Onions", ingredient_10="Bean Sprouts",
                ingredient_11="Cilantro", ingredient_12="Chrushed Red Pepper Flakes", ingredient_13="Edamame",
                ingredient_14="", ingredient_15="", ingredient_16="", ingredient_17="", calPerServg=191.7,
                totalFat=9.4, saturatedFat=1.3, transFat=0, monoUnsatFat=0.61, polyUnsatFat=1.01, omega_3=0.16,
                omega_6=0.84, cholesterol=0.00, totalCarb=19.5, dietaryFiber=5.6, sugar=3.7, protein=10.8,
                procedure="Get all of the ingredients and mix them up, throw them in a pot of your choice," +
                "and cook it til it smell good."},
                new Calendar{ID=6, mealName="Soba Noodle", description="Buckwheat Asian " +
                "Soba Noodles in a spicy chilli garlic sauce with sauteed Bok Choy and Edamame.",
                preparationTime="20", pricePerServg=3.00, ingredient_1="Soy Sauce", ingredient_2="Toasted " +
                "Sesame Oil", ingredient_3="Sriracha", ingredient_4="Chili Garlic Sauce",
                ingredient_5="Rice Wine Vinegar", ingredient_6="Soba Noodles", ingredient_7="Bok Choy",
                ingredient_8="Garlic", ingredient_9="Green Onions", ingredient_10="Bean Sprouts",
                ingredient_11="Cilantro", ingredient_12="Chrushed Red Pepper Flakes", ingredient_13="Edamame",
                ingredient_14="", ingredient_15="", ingredient_16="", ingredient_17="", calPerServg=191.7,
                totalFat=9.4, saturatedFat=1.3, transFat=0, monoUnsatFat=0.61, polyUnsatFat=1.01, omega_3=0.16,
                omega_6=0.84, cholesterol=0.00, totalCarb=19.5, dietaryFiber=5.6, sugar=3.7, protein=10.8,
                procedure="Get all of the ingredients and mix them up, throw them in a pot of your choice," +
                "and cook it til it smell good."} };
            foreach (Calendar c in meals)
            {
                context.Calendar.Add(c);

            }
            context.SaveChanges();

        }
    }
}
