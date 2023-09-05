using UnityEngine;

public class CoinAnimation : MonoBehaviour
{
    SpriteRenderer render;
    public Sprite[] Rotate;
    float animTime = 0;
    int animCounter = 0;
    float speed = 0.0f;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Animation();
    }
    public void Animation()
    {
        if (speed == 0)
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
}
