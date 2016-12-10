using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public UIManager uiManager;
	public PlayerInventory inventory;
	// Use this for initialization
	void Start () {
		uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
		inventory = GetComponent<PlayerInventory>();
		uiManager.inventory = inventory;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
