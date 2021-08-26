using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition; // 마우스를 클릭한 좌표
        } else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition; // 마우스를 뗀 좌표

            float swipeLength = (endPos.x - this.startPos.x);
            this.speed = swipeLength / 1000.0f; // 감속

            GetComponent<AudioSource>().Play();


        }

        transform.Translate(this.speed, 0, 0); // 이동, 로컬 좌표계
        this.speed *= 0.98f; // 감속
    }
}


