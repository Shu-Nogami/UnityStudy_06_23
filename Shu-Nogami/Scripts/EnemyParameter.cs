using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParameter : MonoBehaviour
{
    int life = 5;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "PlayerAmmo"){
            this.AddDamage();
            Destroy(other.gameObject);
        }
    }
    void AddDamage(){
        life--;
        if(life == 0){
            this.Dead();
        }
    }
    void Dead(){
        Destroy(this.gameObject);
        gameManager.Victory();
    }
}
