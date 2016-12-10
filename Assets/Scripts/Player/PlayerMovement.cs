using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public float movementSpeed;
	public float bound;
	private Rigidbody rig;
	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		movementSpeed = Input.GetAxis("Horizontal") * speed;
		rig.velocity = new Vector3(movementSpeed, 0, 0);

		if(transform.position.x <= -bound){
			movementSpeed = 0;
			transform.position = new Vector3(-bound, transform.position.y, transform.position.z);
		} else if(transform.position.x >= bound){
			movementSpeed= 0;
			transform.position = new Vector3(bound, transform.position.y, transform.position.z);
		}
	}
}
