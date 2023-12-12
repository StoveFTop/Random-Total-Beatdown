using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] public float MOVE_SPEED = 10f;
	[SerializeField] public float JUMP_SPEED = 20f;

	private void Update()
	{
		Vector2 inputVector = new Vector2(0,0);

		if(Input.GetKey(KeyCode.A))
		{
			inputVector.x = -1;
		}

		if(Input.GetKey(KeyCode.D))
		{
			inputVector.x = +1;
		}

		if(Input.GetKey(KeyCode.Space))
		{
			inputVector.y = +1;
		}
		
		Vector2 moveVector = new Vector2(inputVector.x * MOVE_SPEED, inputVector.y * JUMP_SPEED);
		transform.position += (Vector3) moveVector * Time.deltaTime;
	}

}