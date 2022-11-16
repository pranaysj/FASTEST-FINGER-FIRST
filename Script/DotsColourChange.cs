using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotsColourChange : MonoBehaviour
{
    SpriteRenderer dotsSpriteRenderer;


    private void Start()
    {
        dotsSpriteRenderer = GetComponent<SpriteRenderer>();
        dotsSpriteRenderer.color = new Color(Random.value, Random.value, Random.value);
    }   
}
