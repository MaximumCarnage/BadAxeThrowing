using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TouchInput : MonoBehaviour {


public Rigidbody axeRb;
public GameObject axeObj;
public Vector3 axeVel;

public Slider powerSlider;
private float speed = 0.1f;
private Vector3 firePos;
private float rotate = -0.3f;
public bool axeHeld = true;

private int timer;
	// Use this for initialization
	void Start () {
		firePos = axeObj.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		powerSlider.value = axeVel.z/1000;
		Debug.Log(timer);
		if(Input.GetMouseButton(0) == true && axeHeld){
			if(axeVel.z<1000){
				axeObj.GetComponent<Transform>().Rotate ( new Vector3( rotate,0,0) );
				axeVel.z += 2f;
			}
			
		}
		else if(Input.GetMouseButtonUp(0) == true && axeHeld == true){
			
			
			axeObj.transform.eulerAngles = Vector3.zero;
			axeRb.constraints = RigidbodyConstraints.None;
			axeRb.GetComponent<Rigidbody>().AddForce(axeVel);
			axeHeld = false;
			axeVel.z = 0;
		}
		if(!axeHeld){
			timer++;
			if(timer/100 >= 6){
				resetAxe();
			}
		}
		
		//  if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        // {
        //     // Get movement of the finger since last frame
        //     Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

        //     // Move object across XY plane
        //     transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
        // }
		
	}

	public void resetAxe(){
		timer = 0;
		axeHeld = true;
		axeObj.transform.position = firePos;
		axeObj.transform.rotation = Quaternion.identity;
		axeRb.constraints = RigidbodyConstraints.FreezeAll;
		axeRb.velocity = Vector3.zero;
	}
}
