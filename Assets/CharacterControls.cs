using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    public int MoveSpeed = 5;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
        }

    }
}
