using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGeneratorG : MonoBehaviour
{
    public GameObject arrowPrefabG;

    // float rnd = Random.Range(2.0f, 6.0f);
    float span = 7.0f;
    float delta = 5.0f;

    // Update is called once per frame
    void Update()
    {

        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0.0f;
            

            GameObject go = Instantiate(arrowPrefabG) as GameObject;
            int px2 = Random.Range(-7, 8);
            go.transform.position = new Vector3(px2, 7, 0);
        }

        // if (this.delta == this.span){
        //     float span = Random.Range(3.0f, 5.0f);
        // }


    }
}
