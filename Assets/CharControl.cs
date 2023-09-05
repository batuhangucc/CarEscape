using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharControl : MonoBehaviour
{

    private Rigidbody2D rb;
    public float wait = 1f;
    public float moveSpeed = 5f;
    private ScoreManager theScoreManager;
    public GameKontrol GameKontrol;
    public GameKontrolSecond gameKontrol;
    [SerializeField] GameObject PauseS;
    [SerializeField] GameObject ResumeButton;
    [SerializeField] GameObject GameOverMenu;
    SpriteRenderer render;
    public Sprite[] Rotate;
    public int a = 0;
    float animTime = 0;
    int animCounter = 0;
    bool anim = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        theScoreManager = FindObjectOfType<ScoreManager>();
        gameKontrol = FindObjectOfType<GameKontrolSecond>();
        GameKontrol = FindObjectOfType<GameKontrol>();
        render = GetComponent<SpriteRenderer>();


    }
    public void MoveLeft()
    {
        rb.velocity = Vector2.left * moveSpeed;
        transform.rotation = Quaternion.Euler(0, 0, 45);


    }
    public void MoveRight()
    {
        rb.velocity = Vector2.right * moveSpeed;

        transform.rotation = Quaternion.Euler(0, 0, -45);
    }
    public void StopMove()
    {
        rb.velocity = Vector2.zero;
    }
    private void FixedUpdate()
    {
        Animation();
    }
    public void Animation()
    {
        if (anim == true)
        {
            animTime += Time.deltaTime;
            if (animTime > 0.2f)
            {
                render.sprite = Rotate[animCounter++];
                if (animCounter == Rotate.Length)
                {
                    animCounter = 0;
                }
                animTime = 0;
            }
        }

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Car" || collider.gameObject.tag == "Limit")
        {
            theScoreManager.scoreIncreasing = false;
            Time.timeScale = 0f;
            FindObjectOfType<AuidoManager>().Play("PlayerDeath");
            Destroy(this.gameObject);
            new WaitForSeconds(wait);
            GameOverMenu.SetActive(true);





        }





    }
}