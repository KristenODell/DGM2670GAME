using UnityEngine;
using System.Collections;
using System;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController myCC;
    //public float speed = 8;
    Vector3 tempPos;
    //public float speed;
    public float speedPowerUp;
    public float originalSpeed = 10;
    public float wait = 1;


    //public static Action<float> PlayerMove;

	// Use this for initialization
	void Start ()
    {
        myCC = GetComponent<CharacterController>();
        UpdateFunction.PlayerMove += PlayerMoveHandler;
	}
	
	public void PlayerMoveHandler (float speed)
    {
        tempPos.x = speed * Input.GetAxis("Horizontal");
        tempPos.z = speed * Input.GetAxis("Vertical");
        myCC.Move(tempPos * Time.deltaTime);
    }
}
