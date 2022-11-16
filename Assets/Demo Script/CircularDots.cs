using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularDots : MonoBehaviour
{
    [SerializeField] GameObject dots;
    
    private void Start()
    {
        InvokeRepeating("DotSpawn", .5f, 1.5f);
        //des = gameObject.GetComponent<SelfDestory>();
    }

    void DotSpawn()
    {
        Vector2 dotsPos = new Vector2(Random.Range(-8f, 8f), Random.Range(-19f, 17f));
        Instantiate(dots, dotsPos, Quaternion.identity);
        
    }
}