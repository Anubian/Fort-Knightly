using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	// Speed of the player
	public float speed = 6f;

	//Private variables declare the type of variable and then the name
	// Stores the movement to be applied to player
	Vector3 movement;
	// reference to the animinator
	Animator anim;
	// reference to the rigid body
	Rigidbody playerRigidBody;
	// Tell raycast we only want it to hit the floor
	int floorMask;
	// Length of the ray cast from the camera
	float camRayLength = 100f;

	// Made to set up the references - Awake is like start - called even if the script is enabled or not
	void Awake() 
	{
		floorMask = LayerMask.GetMask ("Floor");
		anim = GetComponent<Animator> ();
		playerRigidBody = GetComponent<Rigidbody> ();
	}

	// FixedUpdate runs with physics - Function that fires every physics update
	void FixedUpdate ()
	{
		//GetAxisRaw will only have a value of -1, 0 or 1. Means character will immediatly move to max speed unlike GetAxis.
		//Horizontal automaticaly maps to a and d keys or left and right keys as seen in Unity Project Settings Input
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
	}

}
