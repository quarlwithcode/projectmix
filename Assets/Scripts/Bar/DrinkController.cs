using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public static class DrinkController {

	public enum Drink {Fail, Screwdriver, Businessman, Virgin, SororityGirl, Tempest, FrostyYeti, LaNoche, DirtyHombre, WizardLizard, DragonEmporer};
	public enum Ingredient {Vodka, Rum, Whiskey, Tequila, Ice, Fruit, Soda, Garnish, Empty};

	static Dictionary<Ingredient, int> ingredientsAmount;

	public static int totalIngredients(){
		return Enum.GetNames(typeof(Ingredient)).Length;
	}

	public static Ingredient[] getRecipe(Drink drink){

		Ingredient[] ingredients = new Ingredient[5];

		for(int i = 0; i < ingredients.Length; i++){
			ingredients[i] = Ingredient.Empty;
		}

		switch(drink){
		case (DrinkController.Drink.Screwdriver):
			ingredients[0] = Ingredient.Fruit;
			ingredients[1] = Ingredient.Ice;
			ingredients[2] = Ingredient.Vodka;
			ingredients[3] = Ingredient.Empty;
			ingredients[4] = Ingredient.Empty;
			break;
		case (DrinkController.Drink.Businessman):
			ingredients[0] = Ingredient.Whiskey;
			ingredients[1] = Ingredient.Vodka;
			ingredients[2] = Ingredient.Garnish;
			ingredients[3] = Ingredient.Empty;
			ingredients[4] = Ingredient.Empty;
			break;
		case (DrinkController.Drink.Virgin):
			ingredients[0] = Ingredient.Fruit;
			ingredients[1] = Ingredient.Soda;
			ingredients[2] = Ingredient.Ice;
			ingredients[3] = Ingredient.Empty;
			ingredients[4] = Ingredient.Empty;
			break;
		case (DrinkController.Drink.SororityGirl):
			ingredients[0] = Ingredient.Fruit;
			ingredients[1] = Ingredient.Rum;
			ingredients[2] = Ingredient.Soda;
			ingredients[3] = Ingredient.Ice;
			ingredients[4] = Ingredient.Empty;
			break;
		case (DrinkController.Drink.Tempest):
			ingredients[0] = Ingredient.Rum;
			ingredients[1] = Ingredient.Rum;
			ingredients[2] = Ingredient.Soda;
			ingredients[3] = Ingredient.Fruit;
			ingredients[4] = Ingredient.Empty;
			break;
		case (DrinkController.Drink.FrostyYeti):
			ingredients[0] = Ingredient.Ice;
			ingredients[1] = Ingredient.Ice;
			ingredients[2] = Ingredient.Vodka;
			ingredients[3] = Ingredient.Garnish;
			ingredients[4] = Ingredient.Empty;
			break;
		case (DrinkController.Drink.LaNoche):
			ingredients[0] = Ingredient.Tequila;
			ingredients[1] = Ingredient.Tequila;
			ingredients[2] = Ingredient.Ice;
			ingredients[3] = Ingredient.Garnish;
			ingredients[4] = Ingredient.Empty;
			break;
		case (DrinkController.Drink.DirtyHombre):
			ingredients[0] = Ingredient.Tequila;
			ingredients[1] = Ingredient.Rum;
			ingredients[2] = Ingredient.Garnish;
			ingredients[3] = Ingredient.Ice;
			ingredients[4] = Ingredient.Fruit;
			break;
		case (DrinkController.Drink.WizardLizard):
			ingredients[0] = Ingredient.Ice;
			ingredients[1] = Ingredient.Ice;
			ingredients[2] = Ingredient.Soda;
			ingredients[3] = Ingredient.Whiskey;
			ingredients[4] = Ingredient.Rum;
			break;
		case (DrinkController.Drink.DragonEmporer):
			ingredients[0] = Ingredient.Vodka;
			ingredients[1] = Ingredient.Vodka;
			ingredients[2] = Ingredient.Whiskey;
			ingredients[3] = Ingredient.Fruit;
			ingredients[4] = Ingredient.Garnish;
			break;
		}

		return ingredients;

	}

	public static Color[] recipeToColor(Ingredient[] ingredients){

		Color[] colors = new Color[5];

		for(int i = 0; i < ingredients.Length; i++){
			switch(ingredients[i]){
			case (DrinkController.Ingredient.Vodka):
				colors[i] = new Color(.398F,.199F,.598F);		//purple = new Color(.398F,.199F,.598F)
				break;
			case (DrinkController.Ingredient.Rum):
				colors[i] = new Color(0,0,(255/256F));		//purple = new Color(.398F,.199F,.598F)
				break;
			case (DrinkController.Ingredient.Whiskey):
				colors[i] = new Color(255/256F,0,255/256F);		//purple = new Color(.398F,.199F,.598F)
				break;
			case (DrinkController.Ingredient.Tequila):
				colors[i] = new Color(0,128/256F,0);		//purple = new Color(.398F,.199F,.598F)
				break;
			case (DrinkController.Ingredient.Ice):
				colors[i] = new Color(128/256F,128/256F,128/256F);		//purple = new Color(.398F,.199F,.598F)
				break;
			case (DrinkController.Ingredient.Fruit):
				colors[i]= new Color(255/256F,165/256F,0);		//purple = new Color(.398F,.199F,.598F)
				break;
			case (DrinkController.Ingredient.Soda):
				colors[i] = new Color(255/256F,255/256F,0);		//purple = new Color(.398F,.199F,.598F)
				break;
			case (DrinkController.Ingredient.Garnish):
				colors[i] = new Color(255/256F,0,0);		//purple = new Color(.398F,.199F,.598F)
				break;
			case (DrinkController.Ingredient.Empty):
				colors[i] = new Color(1,1,1,0);		//purple = new Color(.398F,.199F,.598F)
				break;
			}
		}



		return colors;

	}

	public static Drink checkRecipe(Ingredient[] ingredients){
		ingredientsAmount = new Dictionary<Ingredient, int>();

		for(int i = 0; i < totalIngredients(); i++){
			ingredientsAmount.Add((Ingredient)i, 0);
		}

		for(int i = 0; i < ingredients.Length; i++){
			switch(ingredients[i]){
			case (DrinkController.Ingredient.Vodka):
				ingredientsAmount[Ingredient.Vodka] = Array.FindAll(ingredients, isVodka).Length;
				break;
			case (DrinkController.Ingredient.Rum):
				ingredientsAmount[Ingredient.Rum] = Array.FindAll(ingredients, isRum).Length;
				break;
			case (DrinkController.Ingredient.Whiskey):
				ingredientsAmount[Ingredient.Whiskey] = Array.FindAll(ingredients, isWhiskey).Length;
				break;
			case (DrinkController.Ingredient.Tequila):
				ingredientsAmount[Ingredient.Tequila] = Array.FindAll(ingredients, isTequila).Length;
				break;
			case (DrinkController.Ingredient.Ice):
				ingredientsAmount[Ingredient.Ice] = Array.FindAll(ingredients, isIce).Length;
				break;
			case (DrinkController.Ingredient.Fruit):
				ingredientsAmount[Ingredient.Fruit] = Array.FindAll(ingredients, isFruit).Length;
				break;
			case (DrinkController.Ingredient.Soda):
				ingredientsAmount[Ingredient.Soda] = Array.FindAll(ingredients, isSoda).Length;
				break;
			case (DrinkController.Ingredient.Garnish):
				ingredientsAmount[Ingredient.Garnish] = Array.FindAll(ingredients, isGarnish).Length;
				break;
			}
		}



		if(checkIngredientNumber(ingredients) == 3){
			//Screwdriver
			if(ingredientsAmount[Ingredient.Fruit] == 1 && 
				ingredientsAmount[Ingredient.Ice] == 1 &&
				ingredientsAmount[Ingredient.Vodka] == 1){
				return Drink.Screwdriver;
			} //Businessman
			else if(ingredientsAmount[Ingredient.Whiskey] == 1 && 
				ingredientsAmount[Ingredient.Vodka] == 1 &&
				ingredientsAmount[Ingredient.Garnish] == 1){
				return Drink.Businessman;
			} //Virgin
			else if(ingredientsAmount[Ingredient.Fruit] == 1 && 
				ingredientsAmount[Ingredient.Soda] == 1 &&
				ingredientsAmount[Ingredient.Ice] == 1){
				return Drink.Virgin;
			}
		} else if(checkIngredientNumber(ingredients) == 4){
			//SororityGirl
			if(ingredientsAmount[Ingredient.Fruit] == 1 && 
				ingredientsAmount[Ingredient.Ice] == 1 &&
				ingredientsAmount[Ingredient.Soda] == 1 &&
				ingredientsAmount[Ingredient.Rum] == 1){
				return Drink.SororityGirl;
			} //Tempest
			else if(ingredientsAmount[Ingredient.Rum] == 2 && 
				ingredientsAmount[Ingredient.Soda] == 1 &&
				ingredientsAmount[Ingredient.Fruit] == 1){
				return Drink.Tempest;
			} //FrostyYeti
			else if(ingredientsAmount[Ingredient.Garnish] == 1 && 
				ingredientsAmount[Ingredient.Vodka] == 1 &&
				ingredientsAmount[Ingredient.Ice] == 2){
				return Drink.FrostyYeti;
			} //LaNoche
			else if(ingredientsAmount[Ingredient.Tequila] == 2 && 
				ingredientsAmount[Ingredient.Garnish] == 1 &&
				ingredientsAmount[Ingredient.Ice] == 1){
				return Drink.LaNoche;
			}
		} else if(checkIngredientNumber(ingredients) == 5){
			//DirtyHombre
			if(ingredientsAmount[Ingredient.Fruit] == 1 && 
				ingredientsAmount[Ingredient.Ice] == 1 &&
				ingredientsAmount[Ingredient.Garnish] == 1 &&
				ingredientsAmount[Ingredient.Rum] == 1 &&
				ingredientsAmount[Ingredient.Tequila] == 1){
				return Drink.DirtyHombre;
			} //DragonEmporer
			else if(ingredientsAmount[Ingredient.Vodka] == 2 && 
				ingredientsAmount[Ingredient.Whiskey] == 1 &&
				ingredientsAmount[Ingredient.Fruit] == 1 &&
				ingredientsAmount[Ingredient.Garnish] == 1){
				return Drink.DragonEmporer;
			} //WizardLizard
			else if(ingredientsAmount[Ingredient.Whiskey] == 1 && 
				ingredientsAmount[Ingredient.Soda] == 1 && 
				ingredientsAmount[Ingredient.Rum] == 1 &&
				ingredientsAmount[Ingredient.Ice] == 2){
				return Drink.WizardLizard;
			}
		}
		return Drink.Fail;
	}

	 static int checkIngredientNumber(Ingredient[] ingredients){
		int c = 0;
		for(int i = 0; i < ingredients.Length; i++){
			if(ingredients[i] != Ingredient.Empty){
				c++;
			}
		}
		return c;
	}

	static bool isFruit(DrinkController.Ingredient name)
	{

		return (name==DrinkController.Ingredient.Fruit);
	}

	static bool isIce(DrinkController.Ingredient name)
	{

		return (name==DrinkController.Ingredient.Ice);
	}

	static bool isSoda(DrinkController.Ingredient name)
	{

		return (name==DrinkController.Ingredient.Soda);
	}

	static bool isGarnish(DrinkController.Ingredient name)
	{

		return (name==DrinkController.Ingredient.Garnish);
	}

	static bool isVodka(DrinkController.Ingredient name)
	{

		return (name==DrinkController.Ingredient.Vodka);
	}

	static bool isRum(DrinkController.Ingredient name)
	{

		return (name==DrinkController.Ingredient.Rum);
	}

	static bool isWhiskey(DrinkController.Ingredient name)
	{

		return (name==DrinkController.Ingredient.Whiskey);
	}

	static bool isTequila(DrinkController.Ingredient name)
	{

		return (name==DrinkController.Ingredient.Tequila);
	}
}
