using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Player 
{
    // Start is called before the first frame update
    private Vector2 _direction;
    public Vector2 startPosition;
    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            _direction = Vector2.left;

            //RandomGenerate.Instance.spawnFromPool("wood", startPosition, Quaternion.identity);

        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            _direction = Vector2.right;
        }else if (Input.GetKey(KeyCode.Space)|| Input.GetKey(KeyCode.W))
        {
            _direction = Vector2.up *1f;
        }

        else
        {

            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * speed);

           

        }
    }


     //public void AddForce(Vector2 force)
     //       {
     //           _rigidbody.AddForce(force);
     //       }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.tag == "Collider")
        {
            Debug.Log("Game Over");

        }
        if (collision.tag == "")
        {
        

        }

    }


    

}
