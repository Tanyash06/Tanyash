using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
	public GameObject target;
	public GameObject bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftControl)) {
		int randScale;
		randScale = Random.Range(5,10);
		GameObject newbullet = Instantiate (bullet);
		newbullet.transform.position = target.transform.position;
		newbullet.transform.localScale = new Vector2(4, 4);
		newbullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (randScale, randScale);
		}
	}
}