using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour {

	///////public
	public float speed_idou =  0.1f;
	public float speed_rotate =  90f;
	public bool local = true;
	public GameObject start;
	
	//////// private
	private float time = 0f;
	private Vector3 rotationVector;
	
	// Use this for initialization
	void Start () {
		rotationVector = new Vector3(0,0,speed_rotate);

	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (Input.GetMouseButton(0))
		{
			this.rotate ();
		}
		else
		{
			 this.idou ();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		transform.position = start.transform.position;
	}

	// idousuru
	private void idou(){
		//transform.position += transform.forward * speed_idou * time;
		transform.position += transform.forward * speed_idou;
	}

	// rotate
	private void rotate(){
		float sz;

		sz = speed_rotate;
		
		if (local == true)
		{
			transform.Rotate(new Vector3( 0, sz, 0) * Time.deltaTime * -1);
		}
		
		if (local == false)
		{
			transform.Rotate(new Vector3( 0, sz, 0) * Time.deltaTime * -1, Space.World);
		}
	}
}
