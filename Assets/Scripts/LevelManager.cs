using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject [] levels;

	public int _levelNum = 0;

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
			//Press "e" to switch levels
			switch (_levelNum) {
		case 3:
			levels[0].SetActive(true);
			levels[1].SetActive(false);
			levels[2].SetActive(false);
			break;
		case 2:
			levels[0].SetActive(false);
			levels[1].SetActive(true);
			levels[2].SetActive(false);
			break;
		case 1:
			levels[0].SetActive(false);
			levels[1].SetActive(false);
			levels[2].SetActive(true);
			break;

		default:
			levels[0].SetActive(false);
			levels[1].SetActive(false);
			levels[2].SetActive(false);
			break;

			}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown("e") == true){
			_levelNum++;
		}
		
		if(_levelNum > levels.Length){
			_levelNum = 0;
		}

		levelChange ();
		
		
	}
}