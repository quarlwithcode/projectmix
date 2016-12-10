using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public UIManager uiManager;
	public PlayerInventory inventory;
	// Use this for initialization
	void Start () {
		uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
		inventory = GetComponent<PlayerInventory>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
