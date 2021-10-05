using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameDirector : MonoBehaviour
{
    GameObject hpGage;
    GameObject score;    
    int hitPoint = 0;
    int nonhitPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGage = GameObject.Find("hpGage");
        this.score = GameObject.Find("Score");
    }

    public void DecreaseHP()
    {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void IncreaseHP()
    {
        this.hpGage.GetComponent<Image>().fillAmount += 0.1f;
    }

    public void HitPoint()
    {
        hitPoint++;
    }
    public void NonhitPoint()
    {
        nonhitPoint++;
    }


    // Update is called once per frame
    void Update()
    {
        this.score.GetComponent<Text>().text = "맞은 화살 수 " + hitPoint + " 개" + "\n"
            + "피한 화살 수 " + nonhitPoint + " 개";
    }
}
