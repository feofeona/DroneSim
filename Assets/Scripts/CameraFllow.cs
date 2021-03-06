﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFllow : MonoBehaviour {
	Transform Drone;
	Vector3 velocityCameraFllow;
	Vector3 CameraPosition = new Vector3(0, 2, -12);
	float angle = 15;
	void Awake(){
		Drone = GameObject.FindGameObjectWithTag ("Player").transform;

	}
	void FixedUpdate(){
		transform.position = Vector3.SmoothDamp (transform.position,
			Drone.transform.TransformPoint (CameraPosition) ,
			ref velocityCameraFllow, 0.05f);

		transform.rotation = Quaternion.Euler (new Vector3 (angle, Drone.GetComponent<DroneMove> ().currentYRotation, 0));
	}
}
