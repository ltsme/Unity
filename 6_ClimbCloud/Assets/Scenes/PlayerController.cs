using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkspeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 점프 한다
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y ==0)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce); // = (0 , 1 , 0) * jumpForce = (0, jumpForce, 0)
        }

        // 좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) { key = 1; }
        if (Input.GetKey(KeyCode.LeftArrow)) { key = -1; }

        // 이동 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // 스피드 한도 내에서, 이동속도 설정
        if(speedx < this.maxWalkspeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }


        // 방향에 따른 이미지 전환
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // 플레이어 속도에 맞게 애니메이션 속도 
        this.animator.speed = speedx / 2.0f;

        //화면 밖 제어
        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene");
        }

    }
}
