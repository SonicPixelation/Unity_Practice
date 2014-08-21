using UnityEngine;
using System.Collections;

public class Projectile_script : MonoBehaviour {

	private int tick;


	// Use this for initialization
	void Start () {

		StartCoroutine (WaitAndDestory(5));

	
	}
	
	// Update is called once per frame
	void Update () {

		rigidbody2D.AddForce (new Vector2 (0,5) );

	}

	IEnumerator WaitAndDestory(float time)  {

		yield return new WaitForSeconds (time);
		Destroy (gameObject);
		GameObject Player = GameObject.Find ("Player");
		Player_Controller Script = Player.GetComponent <Player_Controller> ();
		Script.limit--;
		

		}
}