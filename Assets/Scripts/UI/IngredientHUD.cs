using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IngredientHUD : MonoBehaviour {

	public UIManager uiManager;
	Text txt;

	// Use this for initialization
	void Start () {
		txt = GetComponent<Text>();
		uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = uiManager.currIng.ToString();

		switch(uiManager.currIng){
		case (DrinkController.Ingredient.Vodka):
			transform.parent.GetComponent<Image>().color = new Color(.398F,.199F,.598F);		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Ingredient.Rum):
			transform.parent.GetComponent<Image>().color = new Color(0,0,(255/256F));		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Ingredient.Whiskey):
			transform.parent.GetComponent<Image>().color = new Color(255/256F,0,255/256F);		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Ingredient.Tequila):
			transform.parent.GetComponent<Image>().color = new Color(0,128/256F,0);		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Ingredient.Ice):
			transform.parent.GetComponent<Image>().color = new Color(128/256F,128/256F,128/256F);		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Ingredient.Fruit):
			transform.parent.GetComponent<Image>().color= new Color(255/256F,165/256F,0);		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Ingredient.Soda):
			transform.parent.GetComponent<Image>().color = new Color(255/256F,255/256F,0);		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Ingredient.Garnish):
			transform.parent.GetComponent<Image>().color = new Color(255/256F,0,0);		//purple = new Color(.398F,.199F,.598F)
			break;
		case (DrinkController.Ingredient.Empty):
			transform.parent.GetComponent<Image>().color = new Color(1,1,1,0);		//purple = new Color(.398F,.199F,.598F)
			break;
		}
	}
}
