using UnityEngine;
using System.Collections;

public class ColumnPool : MonoBehaviour
{
    public GameObject columnPrefab;                                    //The column game object.
    public int columnPoolSize = 5;                                    //How many columns to keep on standby.
    public float spawnRate;                                    //How quickly columns spawn.
    public float columnMin = -3f;                                    //Minimum y value of the column position.
    public float columnMax = 3f;                                    //Maximum y value of the column position.

    private GameObject[] columns;                                    //Collection of pooled columns.
    private int currentColumn = 0;                                    //Index of the current column in the collection.

    //private Vector2 objectPoolPosition = new Vector2(-1 , 6);        //A holding position for our unused columns offscreen.

    private Vector2 objectPoolPosition;
    private float spawnXPosition = 1f;
    private Vector2 startPosition;
    // array of difernt position

    public Vector2[] vecArray= new Vector2[]
{
   new Vector2( -3, 6 ),
   new Vector2( -2, 6 ),
   new Vector2( -1, 6 ),
   new Vector2( 0, 6 ),
    new Vector2( 3, 6 ),
   new Vector2( 2, 6 ),
   new Vector2( 1, 6 ),
   new Vector2( 0, 6 ),
};




private float timeSinceLastSpawned;
    //    private void OnEnable()
    //    {
    //        float spawnX = Random.Range(-3,3);


    //        Vector2 startPosition = new Vector2(spawnX, 6);

    //        //Vector2 endPosition = new Vector2(spawnX, -6);

    //        // objectPoolPosition = new Vector2(-1, 6);
    //        //Start();
    //        //run();
    //}
    private void Start()
    {
        SetPoolContent();
    }
    public void SetPoolContent()
    {
        float spawnX = Random.Range(-3, 3);


        Vector2 startPosition = new Vector2(spawnX, 6);
        //if (GameControl.gameOver == false)
        {
            timeSinceLastSpawned = 0f;

            //Initialize the columns collection.
            columns = new GameObject[columnPoolSize];
            //Loop through the collection... 
            for (int i = 0; i < columnPoolSize; i++)
            {
                //...and create the individual columns.
                columns[i] = (GameObject)Instantiate(columnPrefab, startPosition, Quaternion.identity);
                gameObject.SetActive(true);
            }
        }
       
    }


    //This spawns columns as long as the game is not over.
    void Update()
    {
        spawnRate = Random.Range(2, 3);

        timeSinceLastSpawned += Time.deltaTime;

        if ( timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;

            //Set a random y position for the column
            //float spawnXPosition = Random.Range(columnMin, columnMax);
            int spawnXPosition = Random.Range(0, 7);


            int prx = spawnXPosition;

            //...then set the current column to that position.
            //columns[currentColumn].transform.position = new Vector2(spawnXPosition, 6);
            columns[currentColumn].transform.position = vecArray[spawnXPosition];
            gameObject.SetActive(true);
            //Increase the value of currentColumn. If the new size is too big, set it back to zero
            currentColumn++;

            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }
        }
    }
}