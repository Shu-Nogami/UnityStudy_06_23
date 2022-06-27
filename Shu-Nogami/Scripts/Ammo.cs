using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    float deleteTime = 5.0f;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, deleteTime);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, speed, 0);
    }
}
