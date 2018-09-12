using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    float speed;
    [SerializeField]
    float turnSpeed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Vector3 newRotation = transform.rotation.eulerAngles;

        //newRotation.z -= Input.GetAxis("Horizontal") * turnSpeed;

        //transform.rotation = Quaternion.Euler(newRotation);



        //Vector3 direction = Vector3.zero;

        //direction.x = Input.GetAxis("Horizontal");

        //Vector3 movement = (direction * speed) * Time.deltaTime;

        //direction.y = Input.GetAxis("Vertical");

        //movement = (direction * speed) * Time.deltaTime;

        //transform.Translate(movement);

        //if (Input.GetKey(KeyCode.W))
        //{

        //    transform.Translate((Vector2.up * speed) * Time.deltaTime);

        //}

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {

            //transform.Translate((Vector2.left * speed) * Time.deltaTime);
            Vector3 newrotation = transform.rotation.eulerAngles;
            newrotation.z -= Input.GetAxis("Horizontal") * turnSpeed;
            transform.rotation = Quaternion.Euler(newrotation);

        }

    }
}
