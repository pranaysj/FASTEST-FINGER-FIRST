using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelfDestory : MonoBehaviour
{
    [SerializeField] Renderer ren;
    //public bool back = false;

    void Start()
    {
        Color randomColour = new Color(Random.value, Random.value, Random.value);
        ren.material.color = randomColour;

        StartCoroutine(SelfDestoryDots());
    }

    public IEnumerator SelfDestoryDots()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
        //back = true;
        //Debug.Log("Perfect");
    }

    //public void Print()
    //{
    //    Debug.Log("Perfect");
    //}
}
