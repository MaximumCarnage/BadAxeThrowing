using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxeBladeCollision : MonoBehaviour {
	public float score;
	private float outerPoints = 10 ;
	private float innerPoints = 20 ;
	private float midPoints = 30;
	private float bullPoints = 50;
	private bool hitConfirm = false;
	public Rigidbody axeRb;
	public Text scoreText;

	void OnCollisionEnter(Collision other)
	{	
		if(hitConfirm == false){
			if(other.gameObject.tag == "targetOuter"){
				axeRb.constraints = RigidbodyConstraints.FreezeAll;
				score += outerPoints;
			}
			else if(other.gameObject.tag == "targetInner"){
				axeRb.constraints = RigidbodyConstraints.FreezeAll;
				score += innerPoints;
			}
			else if(other.gameObject.tag == "targetMid"){
				axeRb.constraints = RigidbodyConstraints.FreezeAll;
				score += midPoints;
			}
			else if(other.gameObject.tag == "targetBull"){
				axeRb.constraints = RigidbodyConstraints.FreezeAll;
				score += bullPoints;
			}
			scoreText.text = "Score: " + score;
			hitConfirm = true;
		}

		

		

	}

	public void setHitConfirm(){
		hitConfirm = false;
		
	}
}
