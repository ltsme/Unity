using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "만큼의 대미지를 입혔다.");
    }
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "만큼 대미지를 입었다.");
    }
}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);

        Vector2 playerPos = new Vector2(0,0);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
