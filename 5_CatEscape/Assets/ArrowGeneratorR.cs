using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGeneratorR : MonoBehaviour
{
    public GameObject arrowPrefabR;

    float span = 1.5f;
    float delta = 30.0f; // 나오기 시작

    // Update is called once per frame
    void Update()    {

        this.delta += Time.deltaTime;        

        if (this.delta > this.span) // span 만큼 시간이 되면
        {
            this.delta = 0.0f;
            // float rnd = Random.Range(1.0f, 4.0f);

            GameObject go = Instantiate(arrowPrefabR) as GameObject;
            int px2 = Random.Range(-7, 8);
            go.transform.position = new Vector3(px2, 7, 0);
        }


    }
}
