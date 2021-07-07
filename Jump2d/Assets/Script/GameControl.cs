



//using UnityEngine;
//using System.Collections;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;
//using System;

//public class GameControl : MonoBehaviour
//{
//    //    public static Action GameOver;
//    //    public static Action UpdateScore;
//    //     //public static GameControl instance;            //A reference to our game control script so we can access it statically.
//    //    public Text scoreText;                        //A reference to the UI text component that displays the player's score.
//    //    public GameObject gameOvertext;                //A reference to the object that displays the text which appears when the player dies.
//    //    public GameObject scoretext;
//    //    private float score;                        //The player's score.
//    //    public static bool gameOver = false;                //Is the game over?
//    //    public static float scrollSpeed = -1.5f;

//    //    public Text FinalScore;
//    //    //float score;
//    //    float startTime;
//    //    float stime;
//    //    public void Start()
//    //    {
//    //        startTime = Time.time;
//    //        score = 0f;

//    //        scoretext.SetActive(true);

//    //        //}
//    //        //void Awake()
//    //        //{
//    //        ////If we don't currently have a game control...
//    //        //if (instance == null)
//    //        //    //...set this one to be it...
//    //        //    instance = this;
//    //        ////...otherwise...
//    //        //else if (instance != this)
//    //        //    //...destroy this one because it is a duplicate.
//    //        //    Destroy(gameObject);
//    //    }
//    //    private void OnEnable()
//    //    {
//    //        GameOver += BallDied;
//    //        UpdateScore += BallScored;

//    //    }
//    //    private void OnDisable()
//    //    {
//    //        GameOver += BallDied;
//    //        UpdateScore += BallScored;
//    //    }
//    //    void Update()
//    //    {
//    //        //If the game is over and the player has pressed some input...
//    //        if (gameOver && Input.GetMouseButtonDown(0))
//    //        {
//    //            //...reload the current scene.


//    //            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//    //            //SceneManager.LoadScene("Main");
//    //            //score = 0;
//    //            //Reset();
//    //            //scoretext.SetActive(true);




//    //        }


//    //        ////score
//    //        //score = (int)(Time.time - startTime);
//    //        //scoreText.text = "Score: " + score.ToString();
//    //    }

//    //    public void BallScored()
//    //    {
//    //        //The bird can't score if the game is over.
//    //        if (gameOver)
//    //            return;
//    //        //If the game is not over, increase the score...
//    //        score++;
//    //        //...and adjust the score text.
//    //        scoreText.text = "Score: " + score.ToString();

//    //        //SfxManger.sfxinstance.audioClip
//    //    }
//    //    // public void PauseGame()
//    //    // {
//    //    //     Time.timeScale = 0;

//    //    // }

//    //    //public void ResumeGame()
//    //    // {
//    //    //     Time.timeScale = 1;

//    //    // }
//    //    public void BallDied()
//    //    {
//    //        //Activate the game over text.
//    //        gameOvertext.SetActive(true);

//    //        Debug.Log("game end");
//    //        //FinalScore.text = "Score: " + score.ToString();
//    //        ////Set the game to be over.
//    //        //scoretext.SetActive(false);
//    //        gameOver = true;


//    //SceneManager.LoadScene("Mainscene");

//}
//}