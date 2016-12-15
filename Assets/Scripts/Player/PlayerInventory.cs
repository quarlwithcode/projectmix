using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {

	private DrinkController.Ingredient[] ingredients;
	private DrinkController.Drink currDrink;
	public DrinkController.Drink needDrink;

	// Use this for initialization
	void Awake () {
		ingredients = new DrinkController.Ingredient[5];



		clearIngredients();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E)){
			
			handDrink();
		}

		if(Input.GetKeyDown(KeyCode.Q)){
			removeIngredient();
		}
			
		takeOrder();


	}

	public DrinkController.Ingredient[] addIngredient(DrinkController.Ingredient ingredient){
		for(int i = 0; i < ingredients.Length; i++){
			if(ingredients[i] == DrinkController.Ingredient.Empty){
				ingredients[i] = ingredient;
				//print(inventory);
				return ingredients;
			}
		}
		return ingredients;
	}

	public DrinkController.Ingredient[] removeIngredient(){
		for(int i = ingredients.Length-1; i >= 0; i--){
			if(ingredients[i] != DrinkController.Ingredient.Empty){
				ingredients[i] = DrinkController.Ingredient.Empty;
				return ingredients;
			}
		}
		return ingredients;
	}

	public DrinkController.Ingredient[] getIngredients(){
		return ingredients;
	}

	private void handDrink(){
		currDrink = DrinkController.checkRecipe(ingredients);



		clearIngredients();
//		print("tried to hand dirnk");
		RaycastHit hit;
		Vector3 rayPoint = new Vector3(transform.position.x, transform.position.y+1, transform.position.z);
		NPCController npc;

		if (Physics.Raycast(rayPoint, Vector3.forward, out hit, 100.0f)){
//			print("checking for npc..");
			if(hit.collider.tag == "NPC"){
				npc = hit.collider.GetComponent<NPCController>();
				npc.giveOrder(currDrink);
			} else {
//				print("failed");
				currDrink = DrinkController.Drink.Fail;
			}

		} 
	}

	public void clearIngredients(){
		for(int i = 0; i < ingredients.Length; i++){
			ingredients[i] = DrinkController.Ingredient.Empty;
		}
	}

	private void takeOrder(){
		RaycastHit hit;
		Vector3 rayPoint = new Vector3(transform.position.x, transform.position.y+1, transform.position.z);
		NPCController npc;
		if (Physics.Raycast(rayPoint, Vector3.forward, out hit, 2.5f)){
			//			print("checking for npc..");
			if(hit.collider.tag == "NPC"){
				npc = hit.collider.GetComponent<NPCController>();
				npc.order();
			}

		} 
	}

//	public DrinkController.Drink getCurrDrink(){
//		return currDrink;
//	}
//
//	public void setCurrDrink(DrinkController.Drink drink){
//		currDrink = drink;
//	}

}
