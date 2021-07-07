using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       speed = Random.Range(3.0f, 10.0f);



    transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
}
