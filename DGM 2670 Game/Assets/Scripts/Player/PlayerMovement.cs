using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController myCC;
    public float speed = 8;
    Vector3 tempPos;

	// Use this for initialization
	void Start ()
    {
        myCC = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        tempPos.x = speed * Input.GetAxis("Horizontal");
        tempPos.z = speed * Input.GetAxis("Vertical");
        myCC.Move(tempPos * Time.deltaTime);
    }
}
