using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtrl : MonoBehaviour
{
    public float move_speed;
    public float jump_force;

    Rigidbody RB;

    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * move_speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(Vector3.up * jump_force * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
