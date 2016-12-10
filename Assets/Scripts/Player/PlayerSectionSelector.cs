using UnityEngine;
using System.Collections;

public class PlayerSectionSelector : MonoBehaviour {

	public GameObject section;
	public PlayerController pControl;
	private SectionController.Ingredient currIng;
	// Use this for initialization
	void Start () {
		pControl = GetComponent<PlayerController>();
	}

	// Update is called once per frame
	void Update () {
		RaycastHit hit;

		if (Physics.Raycast(transform.position, Vector3.forward, out hit, 100.0f)){
			
			if(hit.collider.tag == "Section"){
				currIng = hit.collider.GetComponent<SectionController>().ingredient;
				pControl.uiManager.currIng = currIng;
			}
		}

		if(Input.GetKeyDown(KeyCode.Space)){
			pControl.inventory.addIngredient(currIng);
		}
	}
}
