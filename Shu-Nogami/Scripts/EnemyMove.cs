using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Vector3[] movePoints = new Vector3[2];
    public float changeTime = 5f;
    bool isPoint = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isPoint){
            transform.position += movePoints[0];
            if(transform.position.x > 7){
                isPoint = !isPoint;
            }
        }
        else{
            transform.position += movePoints[1];
            if(transform.position.x < -7){
                isPoint = !isPoint;
            }
        }
    }
}
