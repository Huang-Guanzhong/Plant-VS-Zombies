using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Base : MonoBehaviour
{
    public static float health;
    public static float money;
    public TextMeshProUGUI healthUI;
    public TextMeshProUGUI moneyUI;


    // Start is called before the first frame update
    void Start()
    {
        health = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Sets the health of the base
    public void SetHealth(float life){
        health = life;
    }

    private void OnTriggerEnter2D(Collider2D other){
        //Destroys the enemy and subtracts the enemies number from the bases health
        if (other.tag == "Enemy"){
            health -= other.GetComponent<Enemy>().health;
            other.GetComponent<Enemy>().spawner.GetComponent<EnemySpawner>().destroyEnemy(other.gameObject);
        }
    }

    public static void AddMoney(float cash){
        money += cash;
        Debug.Log("You have " + money + " money");
        Debug.Log("You have " + health + " life");
    }

    public static float GetMoney(){
        return money;
    }

    public static float GetHealth(){
        return health;
    }
}
