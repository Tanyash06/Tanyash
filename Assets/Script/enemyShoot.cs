using UnityEngine;
using System.Collections;

public class enemyShoot : MonoBehaviour {
	public GameObject bullet;
	public GameObject enemyGun;

	void Shoot () {

			GameObject newbullet = Instantiate (bullet);
		newbullet.transform.position = enemyGun.transform.position;
			newbullet.transform.localScale = new Vector2(2, 2);
		newbullet.GetComponent<SpriteRenderer> ().color=Color.red;
			newbullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-20,5);//randScale, randScale);
			Destroy (newbullet, 5);
		}
	void Start()
	{
		InvokeRepeating ("Shoot", 1, 3);
	}
}
