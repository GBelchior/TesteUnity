using UnityEngine;
using System.Collections;

public class MoverPersonagem3D : MonoBehaviour {

	public Animator animator;
	public float velocidade = 5f;

	void Update () {

		if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
		{
			//animator.SetInteger("WalkX", 1);
			//animator.SetInteger("Lado",2);
			transform.position += new Vector3 (1, 0, 0) * ( velocidade * Time.deltaTime );
		}
		if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
		{
			//animator.SetInteger("WalkX", -1);
			//animator.SetInteger("Lado",4);
			transform.position += new Vector3 (-1, 0, 0) * ( velocidade * Time.deltaTime );
		}
		if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
		{
			//animator.SetInteger("WalkZ", -1);
			//animator.SetInteger("Lado",3);
			transform.position += new Vector3(0, 0, -1) * ( velocidade * Time.deltaTime );
		}
		if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
		{
			//animator.SetInteger("WalkZ", 1);
			//animator.SetInteger("Lado",1);
			transform.position += new Vector3(0, 0, 1) * ( velocidade * Time.deltaTime );
		}
		if (!(Input.GetKey(KeyCode.D)) && !(Input.GetKey(KeyCode.A)) && !(Input.GetKey(KeyCode.RightArrow)) && !(Input.GetKey(KeyCode.LeftArrow)))
		{
			//animator.SetInteger("WalkX", 0);
		}
		if (!(Input.GetKey(KeyCode.W)) && !(Input.GetKey(KeyCode.S)) && !(Input.GetKey(KeyCode.UpArrow)) && !(Input.GetKey(KeyCode.DownArrow)))
		{
			//animator.SetInteger("WalkZ", 0);
		}

	}
}
