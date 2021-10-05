using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;

    float span = 0.8f;
    float delta = 5.0f;
   
    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0.0f;

            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-7, 8);
            go.transform.position = new Vector3(px, 7, 0);
        }

    }
}
