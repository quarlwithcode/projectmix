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
	}
}
