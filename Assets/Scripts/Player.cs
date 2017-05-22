using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int health = 3;

    void collideWithEnemy(Enemy enemy)
    {
        enemy.Attack(this);
        if(health <= 0)
        {

        }
    }

    void OnCollisionEnter(Collision col)
    {
        Enemy enemy = col.collider.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            collideWithEnemy(enemy);
        }
    }
}