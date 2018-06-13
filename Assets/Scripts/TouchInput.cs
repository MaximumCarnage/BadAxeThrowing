using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TouchInput : MonoBehaviour {


public Rigidbody axeRb;
public GameObject axeObj;
public GameObject axeContainer;
public Vector3 axeVel;


public Slider powerSlider;
private float speed = -0.02f;
private Vector3 firePos,rotateAngle;
private Vector2 firstPressPos,secondPressPos,currentSwipe;
private Quaternion fireRot;
private float rotate = -0.3f,zIncrem = 2f,yIncrem = 0.4f;
public bool axeHeld = true;
private float torque = 1f;

private int timer;
	// Use this for initialization
	void Start () {
		firePos = axeObj.transform.position;
		fireRot = axeObj.transform.rotation;

	}
	
	// Update is called once per frame
	void Update () {
		powerSlider.value = axeVel.z/1000;
		
		if(axeHeld){
			axeObj.transform.position =new Vector3(axeObj.transform.position.x+speed,axeObj.transform.position.y,axeObj.transform.position.z);
		}
		
		if(axeObj.transform.position.x<-3 )
		{
			speed*=-1;
		}else if(axeObj.transform.position.x>3){
			speed*=-1;
		}
		Debug.Log(timer);
		if(Input.GetMouseButtonDown(0) == true && axeHeld){
			firstPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
		}
		if(Input.GetMouseButton(0) == true && axeHeld){
			
			if(axeVel.z<1000){
				axeObj.transform.Rotate(0,0,rotate);
				axeVel.z += 2f;
				axeVel.y += 1f;
			}
			
			
		}
		else if(Input.GetMouseButtonUp(0) == true && axeHeld == true){
			secondPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
    	 	//create vector from the two points	
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
            currentSwipe.Normalize();
			
			 if(currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
        	{
            	axeObj.transform.rotation = fireRot;
				axeRb.constraints = RigidbodyConstraints.None;
				axeRb.AddForce( axeVel);
				axeRb.AddTorque(torque,0f,0f,ForceMode.Impulse);
				//axeRb.GetComponent<Rigidbody>().AddForce(axeVel);
				axeHeld = false;
				axeVel.z = 0;
				axeVel.y = 0;
        	}
			
		}
		if(!axeHeld){
			timer++;
			if(timer/100 >= 3){
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
		axeObj.GetComponentInChildren<AxeBladeCollision>().setHitConfirm();
		axeObj.transform.position = firePos;
		axeObj.transform.rotation = fireRot;
		axeRb.constraints = RigidbodyConstraints.FreezeAll;
		axeRb.velocity = Vector3.zero;
	}
}
