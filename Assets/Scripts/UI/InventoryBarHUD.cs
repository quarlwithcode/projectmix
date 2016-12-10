using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryBarHUD : MonoBehaviour {

	public UIManager uiManager;
	private PlayerInventory inventory;
	private Image[] panels;

	private SectionController.Ingredient[] ingredients;
	// Use this for initialization
	void Start () {
		inventory = uiManager.inventory;
		ingredients = inventory.getInventory();
		print(gameObject.GetComponentsInChildren<Image>()[1]);
		panels = new Image[ingredients.Length];

		panels = gameObject.GetComponentsInChildren<Image>();



	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(Input.GetKeyDown(KeyCode.Space)){
			ingredients = inventory.getInventory();
			for(int i = 0; i < ingredients.Length; i++){
				switch(ingredients[i]){
				case (SectionController.Ingredient.Vodka):
					print("Vodka!");
					panels[i+1].color = new Color(.398F,.199F,.598F);		//purple = new Color(.398F,.199F,.598F)
					break;
				case (SectionController.Ingredient.Rum):
					panels[i+1].color = new Color(0,0,(255/256F));		//purple = new Color(.398F,.199F,.598F)
					break;
				case (SectionController.Ingredient.Whiskey):
					panels[i+1].color = new Color(255/256F,0,255/256F);		//purple = new Color(.398F,.199F,.598F)
					break;
				case (SectionController.Ingredient.Tequila):
					panels[i+1].color = new Color(0,128/256F,0);		//purple = new Color(.398F,.199F,.598F)
					break;
				case (SectionController.Ingredient.Ice):
					panels[i+1].color = new Color(128/256F,128/256F,128/256F);		//purple = new Color(.398F,.199F,.598F)
					break;
				case (SectionController.Ingredient.Citrus):
					panels[i+1].color = new Color(255/256F,165/256F,0);		//purple = new Color(.398F,.199F,.598F)
					break;
				case (SectionController.Ingredient.Soda):
					panels[i+1].color = new Color(255/256F,255/256F,0);		//purple = new Color(.398F,.199F,.598F)
					break;
				case (SectionController.Ingredient.Garnish):
					panels[i+1].color = new Color(255/256F,0,0);		//purple = new Color(.398F,.199F,.598F)
					break;
				}

			}
		}
	}
}
