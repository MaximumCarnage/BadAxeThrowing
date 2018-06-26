using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject [] levels;

	public int _levelNum = 1;

	// Use this for initialization
	void Start () {

		levels = GameObject.FindGameObjectsWithTag("level");
		
		for(int i = 0; i< levels.Length; i++){

		}
			
			levels[0].SetActive(false);
			levels[1].SetActive(false);
			levels[2].SetActive(false);
			levels[3].SetActive(false);

		
	}

	void levelChange (){
			//Press "e" to switch levels
			switch (_levelNum) {
		case 3:
			levels[0].SetActive(false);
			levels[1].SetActive(false);
			levels[2].SetActive(false);
			levels[3].SetActive(true);
			break;
		case 2:
			levels[0].SetActive(false);
			levels[1].SetActive(false);
			levels[2].SetActive(true);
			levels[3].SetActive(false);
			break;
		case 1:
			levels[0].SetActive(false);
			levels[1].SetActive(true);
			levels[2].SetActive(false);
			levels[3].SetActive(false);
			break;

		default:
			levels[0].SetActive(true);
			levels[1].SetActive(false);
			levels[2].SetActive(false);
			levels[3].SetActive(false);
			break;
			
			}
		
	}

	public void level1(){
		_levelNum = 1;
	}

		public void level2(){
		_levelNum = 2;
	}

		public void level3(){
		_levelNum = 3;
	}

		public void menuUp(){
		_levelNum -= _levelNum ;
	}

		public void menudown(){
		levels[0].SetActive(false);
		}


	
	// Update is called once per frame
	void Update () {
		
		// if(Input.GetKeyDown("e") == true){
			
		// }
		
		if(_levelNum > levels.Length){
			_levelNum = 0;
		}

		levelChange ();
		
		
	}
}