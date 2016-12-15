using UnityEngine;
using System.Collections;
using System;

public class PlayerMovement : MonoBehaviour
{
    // Function with Parameters
    private CharacterController myCC;
    Vector3 tempPos;
    public float speedPowerUp;
    public float originalSpeed = 10;
    public float wait = 1;

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
