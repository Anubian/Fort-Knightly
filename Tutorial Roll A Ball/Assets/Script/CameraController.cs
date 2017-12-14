using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame - Guaranteed to run after all items have been process in Update
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
