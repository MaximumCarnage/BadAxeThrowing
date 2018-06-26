using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxeManager : MonoBehaviour {

	public GameObject [] axes;

	public int _axeNum = 1;

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

	public void axeUp(){
		Debug.Log(_axeNum);
		_axeNum++;
	}

		public void axedown(){
		Debug.Log(_axeNum);
		_axeNum--;
	}
	
	// Update is called once per frame
	void Update () {


		
		if(Input.GetKeyDown("w") == true){
			_axeNum++;
		}
		
		if(_axeNum > axes.Length){
			_axeNum = 1;
		}

		if(_axeNum <= 0){
			_axeNum = axes.Length;
		}

		axeChange ();
		
		
	}
}
