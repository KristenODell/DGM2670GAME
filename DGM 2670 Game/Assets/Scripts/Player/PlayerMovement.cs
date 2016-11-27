using UnityEngine;
using System.Collections;
using System;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController myCC;
    //public float speed = 8;
    Vector3 tempPos;

    public static Action<float> PlayerMove;

	// Use this for initialization
	void Start ()
    {
        myCC = GetComponent<CharacterController>();
        PlayerMove = PlayerMoveHandler;
	}
	
	public void PlayerMoveHandler (float speed)
    {
        tempPos.x = speed * Input.GetAxis("Horizontal");
        tempPos.z = speed * Input.GetAxis("Vertical");
        myCC.Move(tempPos * Time.deltaTime);
    }
}
