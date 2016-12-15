using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float speed;
	public float movementSpeed;
	public GameObject player;
	private Rigidbody rig;
	private PlayerMovement pmove;
	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody>();
		pmove = player.GetComponent<PlayerMovement>();
	}

	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3(player.transform.position.x,transform.position.y,transform.position.z);
	}
}
