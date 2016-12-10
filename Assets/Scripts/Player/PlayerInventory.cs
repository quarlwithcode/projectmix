using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {

	private SectionController.Ingredient[] inventory;

	// Use this for initialization
	void Awake () {
		inventory = new SectionController.Ingredient[5];

		for(int i = 0; i < inventory.Length; i++){
			inventory[i] = SectionController.Ingredient.Empty;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public SectionController.Ingredient[] addIngredient(SectionController.Ingredient ingredient){
		for(int i = 0; i < inventory.Length; i++){
			if(inventory[i] == SectionController.Ingredient.Empty){
				inventory[i] = ingredient;
				//print(inventory);
				return inventory;
			}
		}
		return inventory;
	}

	public SectionController.Ingredient[] removeIngredient(){
		for(int i = inventory.Length-1; i >= 0; i--){
			if(inventory[i] != SectionController.Ingredient.Empty){
				inventory[i] = SectionController.Ingredient.Empty;
				return inventory;
			}
		}
		return inventory;
	}

	public SectionController.Ingredient[] getInventory(){
		return inventory;
	}
}
