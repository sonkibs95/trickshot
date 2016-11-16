using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovingObject : MonoBehaviour {

	private static MovingObject instance = null;

	// Game Instance Singleton
	public static MovingObject Instance
	{
		get
		{ 
			return instance; 
		}
	}
	private Vector2 startpoint;
	private Vector2 endpoint;
	private Vector2 currentpoint;
	bool isUp;
	bool isDown;
	public double radius;
	public float Speed;
	public Text score;
	const int count= 0 ;


	void Start (){
		
		isUp = false;
		isDown = false;
		startpoint = gameObject.transform.position;
		radius = 0.19;

	}

	void Update(){
		score.text = "" + count;
		if ((isUp & isDown) & Vector2.Distance (endpoint, startpoint) > radius) {
			GetComponent<Rigidbody2D>().AddForce((startpoint - endpoint) * Speed);
			isDown = false;
			isUp = false;

		}
		if(currentpoint != startpoint ){
			currentpoint = startpoint;

		                                 }

	}
	void OnMouseDown(){


		startpoint = gameObject.transform.position;
		isDown = true;


	}

	void OnMouseUp(){
		endpoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		isUp = true;


	}

	}





