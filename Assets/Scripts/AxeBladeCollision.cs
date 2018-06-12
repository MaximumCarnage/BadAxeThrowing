using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeBladeCollision : MonoBehaviour {

	public Rigidbody axeRb;
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "target"){
			axeRb.constraints = RigidbodyConstraints.FreezeAll;
		}
	}
}
