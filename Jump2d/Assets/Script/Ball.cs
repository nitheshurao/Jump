using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float upForce;                    //Upward force of the "flap".
    private Vector2 _direction;
    public float speed;
    private bool isDead = false;            //Has the player collided with a wall?

    private Animator anim;                    //Reference to the Animator component.
    [SerializeField] Rigidbody2D rb2d;                //Holds a reference to the Rigidbody2D component of the bird.

    public Button Btn;

    public Text scoreText;                        //A reference to the UI text component that displays the player's score.
    public GameObject gameOvertext;                //A reference to the object that displays the text which appears when the player dies.
    public GameObject scoretext;
    public Text FinalScore;

    public Text timetxt;
    public Text FinalTime;
    public GameObject Joystic;
    /// <summary>
    ///
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public float maxJumpVelocity = 2f;

   
    /// </summary>
    public Joystick joystick;

    public Joystick joystick1;
    float horizontalMove;
    private float score;
    //Score sound
    public AudioClip coinClip;              // The sound to play when the collectables destroy.
public AudioSource collectablesAudio;

    //    //float score;
    float startTime;
    float stime;
    float times;

    float t;

    /// <summary>
    /// pause /start
    public GameObject _Pause;
    public GameObject _start;
    
    /// </summary>
    public void Start()
    {
        startTime = Time.time;
                score = 0f;
        _Pause.SetActive(true);
        _start.SetActive(false);
    }
    private void Update()
    {
        //if(joystick.Horizontal >= .2f)
        //{
        //    _direction = Vector2.left;
        //}
        //_direction= joystick.Horizontal*speed;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)|| joystick.Horizontal <= -.2f)
        {

            _direction = Vector2.left;
         horizontalMove = joystick.Horizontal * speed;
            //Left();
            //RandomGenerate.Instance.spawnFromPool("wood", startPosition, Quaternion.identity);

        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)|| joystick.Horizontal >= .2f)
        {

            _direction = Vector2.right;
        }


        else if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)|| joystick.Vertical >= .2f)
        {
            Debug.Log("btn presed");
            _direction = Vector2.up * 1f;

        }
        else
        {
            //_direction = Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.J) ? Vector2.up * 1f : Vector2.zero;
            //jump();
            _direction = Vector2.zero;

        }
        //score
         times = (int)(Time.time - startTime);
        timetxt.text = "Time:" + times.ToString();
        scoreText.text = "Score: " + score.ToString();
 t = times;
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            rb2d.AddForce(_direction * speed);

            //if (gameOver)
            //    return;
            //If the game is not over, increase the score...
            //score++;
            //...and adjust the score text.
            scoreText.text = "Score: " + score.ToString();
            //scoreText.text = score.ToString();
            stime = score;
        }

    }

  public   void PauseGame()
    {
        Time.timeScale = 0;

        _Pause.SetActive(false);
        _start.SetActive(true);
    
}

   public  void ResumeGame()
    {
        Time.timeScale = 1;
        _Pause.SetActive(true);
        _start.SetActive(false);
    }
    //public void jump()
    //{

    //    Debug.Log("jump");
    //    _direction =Vector2.up * 1f;

    //    rb2d.AddForce(_direction * jumpForce);
    //    _direction =Vector2.zero;
    //}

    /// </summary>
    /// <param name="other"></param>

    //void OnCollisionEnter2D(Collision2D other)
    //    {
    //        //// Zero out the bird's velocity
    //        ////Debug.Log("Die");
    //        //rb2d.velocity = Vector2.zero;
    //        //// If the bird collides with something set it to dead...
    //        //isDead = true;
    //        ////...tell the Animator about it...
    //        //anim.SetTrigger("Die");
    //        ////...and tell the game control about it.
    //        //GameControl.instance.BirdDied();
    //    }

    void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "coin")
            {
            //If the bird hits the trigger collider in between the columns then
            //tell the game control that the bird scored.
            //GameControl.instance.BallScored();
          //other.  gameObject.SetActive(false);


            score++;

            collectablesAudio = GetComponent<AudioSource>();
            // Change the audio clip of the audio source to the Coin clip and play it
            //collectablesAudio.clip = coinClip;
            collectablesAudio.PlayOneShot(coinClip);
            Debug.Log("coins");
        }

            if (other.tag == "end")
            {

            //GameControl.instance.BallDied();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //gameObject.GetComponent<GameControl>().BallDied();
            //Debug.Log("die");
            stime = score;
            FinalScore.text = "Score: " + stime.ToString();
            rb2d.velocity = Vector2.zero;
            isDead = true;
            scoretext.SetActive(false);
            gameOvertext.SetActive(true);
            Joystic.SetActive(false);
            FinalTime.text = "Time:" + t.ToString();
        }
            if (other.tag == "wall")
            {
                _direction = Vector2.zero;
                //Debug.Log("wall");
            }
        }
    
}