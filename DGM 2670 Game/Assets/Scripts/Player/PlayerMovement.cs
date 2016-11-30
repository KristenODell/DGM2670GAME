using UnityEngine;
using System.Collections;
using System;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController myCC;
    //public float speed = 8;
    Vector3 tempPos;
    public float speed;
    public float speedPowerUp;
    public float originalSpeed = 10;
    public float wait = 1;

    public IEnumerator IncreaseSpeed()
    {
        int i = 10;
        while (i > 0)
        {
            speed = speedPowerUp;
            yield return new WaitForSeconds(wait);
            i--;
         }
        speed = originalSpeed;
    }

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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(IncreaseSpeed());
        }
    }
}
