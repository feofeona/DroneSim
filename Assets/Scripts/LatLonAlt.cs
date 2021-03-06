﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatLonAlt : MonoBehaviour {
	ConstValue _constval;
	GameObject player;
	public float lat = 24.979212f;
	public float lon = 121.575308f;
	public float alt = 100;

	public float Startlat;
	public float Startlon;
	public float Startalt;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		_constval = player.GetComponent<ConstValue> ();

		Startlat = lat;
		Startlon = lon;
		Startalt = alt;
	}
	
	// Update is called once per frame
	void Update () {
		lat += player.transform.position.x / _constval.GetEarthRadius() * 180.0f / Mathf.PI;
		lon += player.transform.position.z / (Mathf.Cos(lat * Mathf.PI / 180.0f) * _constval.GetEarthRadius()) * 180.0f / Mathf.PI;
		alt -= player.transform.position.y;
	}
}
