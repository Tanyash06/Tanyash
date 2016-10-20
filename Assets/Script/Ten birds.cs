using UnityEngine;
using System.Collections;

public class TEST : MonoBehaviour {
	public GameObject gem;



	// Use this for initialization
	void Start () {
		int randScale;
		for (int i = 0; i < 10; i++) {
			randScale = Random.Range (1,3);
			GameObject newGem=Instantiate(gem);
			newGem.AddComponent<PolygonCollider2D> ();
			newGem.AddComponent<Rigidbody2D> ().gravityScale = 2;
			newGem.transform.position = new Vector2 (Random.Range (-25, 15), Random.Range (-25, 15));
			newGem.transform.localScale = new Vector2 (randScale, randScale);
			newGem.name = "Bird" + i;
		}

	}

	// Update is called once per frame
	void Update () {

	}
}
