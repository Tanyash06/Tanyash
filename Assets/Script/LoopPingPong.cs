using UnityEngine;
using System.Collections;

public class LoopPingPong : MonoBehaviour {

	void Start()
	{
		LeanTween.scale (gameObject, new Vector3 (1.1f, 1.1f, 1), 1).setLoopPingPong ();
	}
}
