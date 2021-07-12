// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ArrowGeneratorG : MonoBehaviour
// {
//     public GameObject arrowPrefabG;

//     float rnd = Random.Range(2.0f, 6.0f);
//     float count = 3.0f;

//     // Update is called once per frame
//     void Update()
//     {

//         this.count += Time.deltaTime;

//         if (this.count > this.rnd)
//         {
//             this.count = 0.0f;
//             float rnd = Random.Range(2.0f, 6.0f);

//             GameObject go = Instantiate(arrowPrefabG) as GameObject;
//             int px2 = Random.Range(-7, 8);
//             go.transform.position = new Vector3(px2, 7, 0);
//         }


//     }
// }
