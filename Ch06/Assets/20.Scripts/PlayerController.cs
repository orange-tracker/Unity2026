using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 600.0f;
    float walkForce = 30f;
    float maxWalkSpeed = 2.0f;
    public Sprite[] walkSprites;
    public Sprite jumpSprite;
    float time = 0;
    int idx = 0;
    SpriteRenderer spriteRenderer;
  


    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && this.rigid2D.linearVelocityY==0)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        if (this.rigid2D.linearVelocityX < maxWalkSpeed)
        {

            this.rigid2D.AddForce(transform.right * walkForce);
        }

        if (this.rigid2D.linearVelocityY != 0)
        {
            this.spriteRenderer.sprite = this.jumpSprite;
        }
        else
        {

            this.time += Time.deltaTime;
            if (this.time > 0.1f)
            {
                this.time = 0;
                this.spriteRenderer.sprite = this.walkSprites[this.idx];
                this.idx = 1 - this.idx;
            }
        }

        if (transform.position.y<-10)
        {
            SceneManager.LoadScene("Main");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("°ñ");
        SceneManager.LoadScene("ClearScene");
    }
}
