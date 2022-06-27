using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject ammo;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shot", 5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Shot(){
        GameObject obj = Instantiate(ammo);
        obj.transform.position = transform.position;
    }
}
