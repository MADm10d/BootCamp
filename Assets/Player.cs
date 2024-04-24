 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform cameraTran;
    public float _speed = 5.55f;
    public int _lifes = 4;
    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = transform.position;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Forward was clicked");
            moveVector.y += _speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Down was clicked");
            moveVector.y -= _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left was clicked");
            moveVector.x -= _speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right was clicked");
            moveVector.x += _speed * Time.deltaTime;
        }
        transform.position = moveVector;

    moveVector.z = cameraTran.position.z;
        cameraTran.position = moveVector;
    }
}
