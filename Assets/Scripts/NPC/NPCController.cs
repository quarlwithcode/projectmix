using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour {

	public DrinkController.Drink orderDrink;
	public GameObject exclamation;
	public GameObject drink;
	public SpriteRenderer image;
	public bool orderTaken;
	public TurntMeter tMeter;
	public Sprite[] drinks;

	private SpriteRenderer[] daimonds;
	private Color[] colors;

	private int potentialPoints;

	// Use this for initialization
	void Start () {
		orderDrink = (DrinkController.Drink)Random.Range(1, DrinkController.totalIngredients());
		exclamation.SetActive(true);
		drink.SetActive(false);
		orderTaken = false;

		if(tMeter == null){
			tMeter = GameObject.Find("TurntMeter").GetComponent<TurntMeter>();
		}

		daimonds = new SpriteRenderer[drink.transform.childCount];

		for(int i = 0; i < daimonds.Length; i++){
			daimonds[i] = drink.transform.GetChild(i).GetComponent<SpriteRenderer>();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void giveOrder(DrinkController.Drink drink){
		if(drink == orderDrink){
			tMeter.addTurnt(potentialPoints);
			Destroy(gameObject);
		}
	}

	public void order(){
		exclamation.SetActive(false);
		drink.SetActive(true);
		orderTaken = true;

		DrinkController.Ingredient[] ingredients = DrinkController.getRecipe(orderDrink);

		int c = 0;

		for(int i = 0; i < ingredients.Length; i++){
			if(ingredients[i] != DrinkController.Ingredient.Empty){
				c++;
			}
		}

		if(c == 3){
			potentialPoints = 5;
		} else if(c == 4){
			potentialPoints = 10;
		} else if(c == 5){
			potentialPoints = 15;
		}

		colors = DrinkController.recipeToColor(ingredients);

		for(int i = 0; i < daimonds.Length; i++){
			daimonds[i].color = colors[i];
		}

		switch(orderDrink){
		case (DrinkController.Drink.Screwdriver):
			image.sprite = drinks[0];		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Drink.Businessman):
			image.sprite = drinks[1];		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Drink.Virgin):
			image.sprite = drinks[2];		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Drink.SororityGirl):
			image.sprite = drinks[3];		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Drink.Tempest):
			image.sprite = drinks[4];		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Drink.FrostyYeti):
			image.sprite = drinks[5];		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Drink.LaNoche):
			image.sprite = drinks[6];		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Drink.DirtyHombre):
			image.sprite = drinks[7];		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Drink.WizardLizard):
			image.sprite = drinks[8];		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Drink.DragonEmporer):
			image.sprite = drinks[9];		//purple = new Color(.398F,.199F,.598F)
			break;
		}
	}
}
