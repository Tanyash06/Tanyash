using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private int direction;
	private float speedForce;
	private Rigidbody2D rb2d;
	private bool isWalk=false;
	private bool isJump=false;
	private Vector2 unitPos;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		speedForce = 5;
		direction = 0;
	}
	

	void FixedUpdate () {
		if (!Input.GetKey (KeyCode.RightArrow) && !Input.GetKey (KeyCode.LeftArrow)) 
		{
			OnKeyUp ();
		}
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			RunRight ();
		}
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			RunLeft ();
		}
		if (Input.GetKey (KeyCode.Space)) 
		{
			isJump = true;
			OnJump ();
		}
	
	}
	public void RunRight()
	{
		isWalk = true;
		direction = 1;
		//rb2d.gameObject.transform.localScale = new Vector3(10, 10, 1);
		unitPos = new Vector2(direction * speedForce, rb2d.velocity.y);
		rb2d.velocity = unitPos;

	}
	public void RunLeft()
	{
		isWalk = true;
		direction = -1;
		//rb2d.gameObject.transform.localScale = new Vector3(-10, 10, 1);
		rb2d.velocity = new Vector2(direction * speedForce, rb2d.velocity.y);


	}
	public void OnJump()
	{
		if (isJump == true)
		{
			isWalk = false;
			//rb2d.gameObject.transform.localScale = new Vector3(-10, 10, 1);
			unitPos = new Vector2(rb2d.velocity.x, 10);
			rb2d.velocity = unitPos;
		}
	}
	public void OnKeyUp ()
	{
		if (rb2d.velocity.x == 0 && !isWalk)
		{
			return;
		}

		unitPos = new Vector2(rb2d.velocity.x, rb2d.velocity.y);
		rb2d.velocity = unitPos;
		isWalk = false;
	}
	}
	
