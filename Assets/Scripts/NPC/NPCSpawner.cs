using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour {

	public Transform[] sections;
	private List<Transform> availableSections;
	public Transform stoppingPoint;
	public int npcCount;
	public int npcSpeed = 3;
	public int startDelay = 2;
	public int startingAmount = 2;
	public int maxAmount = 8;
	public float npcY = 2F;
	public GameObject npc;
	public float spawnCooldown = 5F;
	private bool spawnReady = true;
	private int npcAllowed;
	private GameObject[] npcs;
	// Use this for initialization
	void Start () {
		npcCount = 0;
		npcAllowed = startingAmount;
		StartCoroutine(startingDelay(startDelay));
		availableSections = new List<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		npcCount = GameObject.FindGameObjectsWithTag("NPC").Length;

		if(npcCount < npcAllowed && spawnReady){
			Spawn();
		}
	}

	IEnumerator startingDelay(float sec){
		yield return new WaitForSeconds(sec);

		Spawn();
	}

	public void Spawn(){
		npcs = GameObject.FindGameObjectsWithTag("NPC");
		checkAvailableSections();
		int r = Random.Range(0,availableSections.Count-1);

		if(npcCount < npcAllowed && spawnReady){
			GameObject npcClone;
			npcClone = Instantiate(npc, new Vector3(availableSections[r].position.x, npcY, transform.position.z), transform.rotation) as GameObject;
			LeanTween.moveZ(npcClone, stoppingPoint.position.z, npcSpeed);
			spawnReady = false;
			StartCoroutine(startCooldown());
		}
		checkAvailableSections();
	}

	IEnumerator startCooldown(){
		yield return new WaitForSeconds(spawnCooldown);
		spawnReady = true;
	}

	private void checkAvailableSections(){
		availableSections = new List<Transform>();

		for(int i = 0; i < sections.Length; i++){
			availableSections.Add(sections[i]);
		}

		int[] bad = new int[npcs.Length];

		for(int i = 0; i < npcs.Length; i++){
			for(int j = 0; j < sections.Length; j++){
				if(npcs[i].transform.position.x == sections[j].position.x){
					bad[i] = j;
					print("Bad  " + bad.Length);
				}
			}
		}



		for(int i = 0; i < bad.Length; i++){
			availableSections.RemoveAt(bad[i]-i);
		}
		print("N " + npcs.Length);
		print("A " + availableSections.Count);
	}
}
