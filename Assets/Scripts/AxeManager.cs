using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeManager : MonoBehaviour {

	public GameObject [] axes;

	public int _axeNum = 0;

	// Use this for initialization
	void Start () {
		axes = GameObject.FindGameObjectsWithTag("axe");
		
		
		for(int i = 0; i< axes.Length; i++){
			
			
		}		

			axes[0].SetActive(false);
			axes[1].SetActive(false);
			axes[2].SetActive(false);
	}

		void axeChange (){
			//Press "w" to switch axes
			switch (_axeNum) {
		case 3:
			axes[0].SetActive(true);
			axes[1].SetActive(false);
			axes[2].SetActive(false);
			break;
		case 2:
			axes[0].SetActive(false);
			axes[1].SetActive(true);
			axes[2].SetActive(false);
			break;
		case 1:
			axes[0].SetActive(false);
			axes[1].SetActive(false);
			axes[2].SetActive(true);
			break;

		default:
			axes[0].SetActive(false);
			axes[1].SetActive(false);
			axes[2].SetActive(false);
			break;

			}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown("w") == true){
			_axeNum++;
		}
		
		if(_axeNum > axes.Length){
			_axeNum = 0;
		}

		axeChange ();
		
		
	}
}
