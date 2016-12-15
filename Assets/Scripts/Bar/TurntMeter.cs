using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurntMeter : MonoBehaviour {

	private Slider slider;
	public int loss;
	public int turntLevel;
	public float startingTime;
	public float repeatTime;
	public bool stillTurnt = true;
	public UIManager uiManager;
	void Start(){
		slider = GetComponent<Slider>();
		turntLevel = 100;
		InvokeRepeating("repeatTurntLoss", startingTime, repeatTime);
	}

	public void Update(){
		slider.value = (turntLevel/100F);

		if(!stillTurnt){
			uiManager.showGameOverMenu();
			Time.timeScale = 0;
		}
	}

	private void repeatTurntLoss(){
		turntLevel -= loss;
		checkTurnt();
	}

	private void checkTurnt(){
		if(turntLevel > 100){
			turntLevel = 100;
		} else if(turntLevel < 0){
			turntLevel = 0;
			stillTurnt = false;
		}
	}

	public void addTurnt(int t){
		turntLevel += t;
	}

	public void subtractTurnt(int t){
		turntLevel -= t;
	}
}
