using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamera : MonoBehaviour {

	public Transform target;
    public float speed;

	public int _numMenu;

	public GameObject [] menus;

	// Use this for initialization
	void Start () {
		menus = GameObject.FindGameObjectsWithTag("menu");
		target.transform.position = menus[_numMenu].transform.position;	
	}
	
	
	// Update is called once per frame
	void Update () {

			if(Input.GetKeyDown("1")){
			
			if(_numMenu >= menus.Length-1){
				_numMenu = 1;
			}else{
				_numMenu++;
			}
		}

	// 	float step = speed * Time.deltaTime;
    //    transform.position = Vector3.MoveTowards(transform.position, target.position, step);

		//rot to face
		Vector3 direction = target.position - transform.position;
		Quaternion rotation = Quaternion.LookRotation(direction);
		transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);

		target.transform.position = menus[_numMenu].transform.position;	

	
	}

	public void Menuchange(){
		if(_numMenu >= menus.Length-1){
				_numMenu = 1;
			}else{
				_numMenu++;
			}
	}

	public void ReverseMenuchange(){
		if(_numMenu <= 1){
				_numMenu = menus.Length-1;
			}else{
				_numMenu--;
			}
	}
}
