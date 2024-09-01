using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    public float mooveSpeed = 5;
    bool canMove = true;
    public float limitLeft = -12.25f;
    public float limitRigth = 12.25f;
    public float ResetBall = 7;


    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            Vector3 moveOffset = Vector3.zero;
            moveOffset.x = Input.GetAxis("Horizontal");
            moveOffset.x = moveOffset.x * mooveSpeed * Time.deltaTime;
            transform.position += moveOffset;
            Vector3 newPosition = transform.position + moveOffset;
            if (newPosition.x > limitRigth)
            {
                newPosition.x = limitRigth;
            }

            if (newPosition.x < limitLeft)
            {
                newPosition.x = limitLeft;
            }
            transform.position = newPosition;

            if (Input.GetButtonDown("Fire1"))
            {
                canMove = false;
                GetComponent<Rigidbody>().isKinematic = false;
                GetComponent<Rigidbody>().AddForce(Random.Range(-5f, 5f),0,0,ForceMode.Impulse);
            }


        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bottom")
        {
            canMove = true;
            GetComponent<Rigidbody>().isKinematic = true;
            transform.position = new Vector3(0, ResetBall, 0);
        }
    }
}
