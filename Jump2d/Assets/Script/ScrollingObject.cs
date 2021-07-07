using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;

    // Use this for initialization
    public  float scrollSpeed;
    private void OnEnable()
    {
        //rb2d.velocity = new Vector2(0, scrollSpeed);

    }
    private void OnDisable()
    {
        rb2d.velocity = new Vector2(0,0);

    }
    private void Start()
    {
        scrollSpeed = -1.5f;
        StartCoroutine(IncreasetTime());
        rb2d.velocity = new Vector2(0, scrollSpeed);
    }
    void Update()
    {
        // If the game is over, stop scrolling.
        //if (GameControl.gameOver == true)
        //{
        //    rb2d.velocity = Vector2.zero;
        //}
        Debug.Log("speed= " + scrollSpeed);
        //StartCoroutine(IncreasetTime());
        //scrollSpeed -= Time.deltaTime;
        rb2d.velocity = new Vector2(0, scrollSpeed);
    }

    IEnumerator IncreasetTime()
    {
        yield return new WaitForSeconds(10);
        scrollSpeed -= 0.1f;
        //scrollSpeed = -3f;

        Debug.Log("speed= " + scrollSpeed);

        if (scrollSpeed < -3.0f)
        {
            yield return new WaitForSeconds(15);
            Debug.Log("speed= " + scrollSpeed);
            scrollSpeed = -1.5f;
            //StartCoroutine(IncreasetTime());
        }
        rb2d.velocity = new Vector2(0, scrollSpeed);
      
        //yield return new WaitForSeconds(4);
        StartCoroutine(IncreasetTime());
    }

  
}