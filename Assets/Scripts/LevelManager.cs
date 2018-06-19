using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject [] levels;

	public AxeBladeCollision m_col;

	// Use this for initialization
	void Start () {

		levels = GameObject.FindGameObjectsWithTag("level");
		
		for(int i = 0; i< levels.Length; i++){
			Debug.Log("level Number "+i+" is named "+levels[i].name);
		}

			levels[0].SetActive(false);
			levels[1].SetActive(false);
			levels[2].SetActive(false);

		
	}

	void levelChange (){
		if(m_col.score == 0){
			levels[0].SetActive(false);
			levels[1].SetActive(true);
			levels[2].SetActive(false);
		}else if(m_col.score >= 10){
			levels[0].SetActive(false);
			levels[1].SetActive(false);
			levels[2].SetActive(true);
		}
	}
	
	// Update is called once per frame
	void Update () {

		levelChange();
		
	}
}
