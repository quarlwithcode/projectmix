using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryBarHUD : MonoBehaviour {

	public UIManager uiManager;
	private PlayerInventory inventory;
	private Image[] panels;

	private DrinkController.Ingredient[] ingredients;
	// Use this for initialization
	void Start () {
		inventory = uiManager.inventory;
		ingredients = inventory.getIngredients();
		print(gameObject.GetComponentsInChildren<Image>()[1]);
		panels = new Image[ingredients.Length];

		panels = gameObject.GetComponentsInChildren<Image>();



	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Q)){
			ingredients = inventory.getIngredients();
			for(int i = 0; i < ingredients.Length; i++){
				switch(ingredients[i]){
				case (DrinkController.Ingredient.Vodka):
					print("Vodka!");
					panels[i+1].color = new Color(.398F,.199F,.598F);		//purple = new Color(.398F,.199F,.598F)
					break;
				case (DrinkController.Ingredient.Rum):
					panels[i+1].color = new Color(0,0,(255/256F));		//purple = new Color(.398F,.199F,.598F)
					break;
				case (DrinkController.Ingredient.Whiskey):
					panels[i+1].color = new Color(255/256F,0,255/256F);		//purple = new Color(.398F,.199F,.598F)
					break;
				case (DrinkController.Ingredient.Tequila):
					panels[i+1].color = new Color(0,128/256F,0);		//purple = new Color(.398F,.199F,.598F)
					break;
				case (DrinkController.Ingredient.Ice):
					panels[i+1].color = new Color(128/256F,128/256F,128/256F);		//purple = new Color(.398F,.199F,.598F)
					break;
				case (DrinkController.Ingredient.Fruit):
					panels[i+1].color = new Color(255/256F,165/256F,0);		//purple = new Color(.398F,.199F,.598F)
					break;
				case (DrinkController.Ingredient.Soda):
					panels[i+1].color = new Color(255/256F,255/256F,0);		//purple = new Color(.398F,.199F,.598F)
					break;
				case (DrinkController.Ingredient.Garnish):
					panels[i+1].color = new Color(255/256F,0,0);		//purple = new Color(.398F,.199F,.598F)
					break;
				case (DrinkController.Ingredient.Empty):
					panels[i+1].color = new Color(1,1,1);		//purple = new Color(.398F,.199F,.598F)
					break;
				}

			}
				
		}
	}
}
