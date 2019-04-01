using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerMovement : MonoBehaviour
{
    [SerializeField] int Velocity = 1; // Maybe a max and min speed will be needed. int or bool?

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementControls();
    }

    private void MovementControls()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Velocity * Time.deltaTime);
        }
    }
}
