using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {



	public Transform OrbitPivot;   // The transform that this object will orbit around
	public float OrbitSpeed = 100f;
	public Vector3 Axe = Vector3.up;


	void Start () {
		
	}


	// Update is called once per frame
	void Update () {

		this.transform.RotateAround(OrbitPivot.position, Axe, OrbitSpeed * Time.deltaTime);
	}



}

