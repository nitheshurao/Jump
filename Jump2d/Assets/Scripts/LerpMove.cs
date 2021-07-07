using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMove : MonoBehaviour
{
    // Start is called before the first frame update
    private bool shouldLerp = true;
    public float timeStartedlerping;
    public float lerpTime;
    public Vector2 endPosition;
    public Vector2 startPosition;


    private void StardLerping()
    {
        timeStartedlerping = Time.time;
        shouldLerp = true;
    }

    public void Start()
    {
        StardLerping();

    }

    private void OnEnable()
    {
        float spawnX = Random.Range(-3, 3);

      
        startPosition = new Vector2(spawnX, 6);
     
        endPosition = new Vector2(spawnX, -6);

    }

    public void Update()
    {
        if (shouldLerp)
        {

            transform.position = Lerp(startPosition, endPosition, timeStartedlerping, lerpTime);
           
        }
        //if(transform.position == endPosition)
        //{
        //RandomGenerate.Instance.spawnFromPool("wood", startPosition, Quaternion.identity);

        //RandomGenerate.Instance.spawnFromPool("wood", startPosition, Quaternion.identity, true);

        //}
        if (transform.position.y < -5f)
        {
            //RandomGenerate.Instance.DeactiveFromPool("wood", endPosition, Quaternion.identity, true);
            //RandomGenerate.Instance.spawnFromPool("wood");
            Debug.Log("less then 5");
            StardLerping();

        }

        //if (transform.position.y > -5f)
        //{
        //    Debug.Log("greater then 5");
        //    //RandomGenerate.Instance.DeactiveFromPool("wood", endPosition, Quaternion.identity, true);
        //    RandomGenerate.Instance.AddToPool("wood", gameObject);
        //}
    }



    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStarted, float lerpTime = 1)
    {
        float timeSinceStarted = Time.time - timeStarted;
        float percentageCompleted = timeSinceStarted / lerpTime;

        var result = Vector3.Lerp(start, end, percentageCompleted);
        return result;
    }






    
}
