using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
		Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
			rb.AddForce(Vector3.left);
        if (Input.GetKey(KeyCode.D))
			rb.AddForce(Vector3.right);
        if (Input.GetKey(KeyCode.W))
			rb.AddForce(Vector3.forward);
        if (Input.GetKey(KeyCode.S))
			rb.AddForce(Vector3.back);
    }
	
	private void OnCollisionEnter(Collision collision)
    {
		Rigidbody rb = GetComponent<Rigidbody>();		
		rb.constraints = RigidbodyConstraints.FreezeRotation;
    }
	private void OnCollisionExit(Collision collision)
    {
		Rigidbody rb = GetComponent<Rigidbody>();		
        rb.constraints = RigidbodyConstraints.None;
    }

}
