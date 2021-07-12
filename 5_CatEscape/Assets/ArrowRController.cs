using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player"); // 게임오브젝트 player 찾기
    }

    // Update is called once per frame
    void Update()
    {
        GameObject director = GameObject.Find("GameDirector"); // find메소드로 GameDirector 오브젝트를 찾기.

        // 화살 하락
        transform.Translate(0, -0.05f, 0);

        //화살 소멸
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
            director.GetComponent<GameDirector>().NonhitPoint();
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            Destroy(gameObject);

            //감독 스크립트에 충돌 전달.            
            director.GetComponent<GameDirector>().DecreaseHP(); // 그 오브젝트의 GameDirector 스크립트를 구하고 메소드를 호출.
            director.GetComponent<GameDirector>().HitPoint();
        }
    }
}
