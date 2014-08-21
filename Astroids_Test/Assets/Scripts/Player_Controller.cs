using UnityEngine;
using System.Collections;


public class Player_Controller : MonoBehaviour {

	private int tick;
	public int limit;
	public GameObject projectile;

	// Use this for initialization
	void Start () {
		limit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (tick % 5 == 0) {
			if (rigidbody2D.angularVelocity >= 0)
			rigidbody2D.angularVelocity -= 10;

			if (rigidbody2D.angularVelocity <= 0)
			rigidbody2D.angularVelocity += 10;
			}

		rigidbody2D.velocity = new Vector2 (0, 0);
		float xdirection = Input.GetAxis ("Horizontal");
		float ydirection = Input.GetAxis ("Vertical"); 

		rigidbody2D.AddTorque (-xdirection);
		rigidbody2D.AddForce (transform.up * ydirection * 100);

		if (Input.GetButton ("Fire1")) {
						if (limit == 0 || limit == 1) {
								FIRe ();
						}
				}
	
		
		tick++;
	}

	public void FIRe () {

		Transform muzzle = GameObject.Find ("Player/Muzzle").transform;
		 Instantiate (projectile, muzzle.localPosition, Quaternion.identity);
		limit++;

		}
}
