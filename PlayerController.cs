using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    Rigidbody2D rbody;
    private float jumpForce = 680.0f;
    private float walkForce = 30.0f;
    private float maxWalkSpeed = 2.0f;
    private Animator animator;

    //점프 애니메이션용 변수
    public string targetObjectName;
    public bool IsJumped = false;
    void Start()
    {
        this.rbody = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (IsJumped == true){
            this.animator.SetBool("JumpBool",true);
        }
        if (Input.GetKeyDown(KeyCode.Space)&& this.rbody.velocity.y == 0)
        {
            //this.animator.SetTrigger("JumpTrigger");
            IsJumped = true;
            this.rbody.AddForce(transform.up*this.jumpForce);
        }
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx  = Mathf.Abs(this.rbody.velocity.x);
        if (speedx < this.maxWalkSpeed)
        {
            this.rbody.AddForce(transform.right*key*this.walkForce);
        }
        if (key != 0 )
        {
            transform.localScale = new Vector3(key,1,1);
        }
        this.animator.speed = speedx /  2.0f;

        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        IsJumped = false;
        this.animator.SetBool("JumpBool",false);
        if (other.gameObject.name == targetObjectName)
        {
            SceneManager.LoadScene("ClearScene");
            Debug.Log("끝");
        }
    
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            //SceneManager.LoadScene("ClearScene");
        }
    }
    
    /*void OnTriggerStay2D(Collider2D collision)
    { // 발이 무언가에 닿으면 
        IsJumped=false;
    }
    */
}
