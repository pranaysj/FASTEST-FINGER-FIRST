using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DotsCreator : MonoBehaviour
{
    [SerializeField] GameObject dotPrefab;
    public GameObject instanceObject;
    [SerializeField] float countTheDots;
    [SerializeField] GameObject gameOverScene;
    TouchToDestory checckDestoryOfDot;
    float startTime, currentTime, finalTim;
    private IEnumerator coroutine;
    [SerializeField] Button button; 
    
    public void Start()
    {
        InvokeRepeating("SpawningOfDots", 0.5f, 1.0f);
        checckDestoryOfDot = GetComponent<TouchToDestory>();
        //button = GameObject.Find("Resume_Button").GetComponent<Button>();
    }
    
    public void SpawningOfDots()
    {
        Vector2 dotsPos = new Vector2(Random.Range(-6.4f, 6.4f), Random.Range(-15f, 12.5f));
        instanceObject = Instantiate(dotPrefab, dotsPos, Quaternion.identity);

        StartCoroutine(RestartScene());
    }

    public IEnumerator RestartScene()
    {
        yield return new WaitForSeconds(1.0f);
        if (!checckDestoryOfDot.isDestory)
        {
            Destroy(instanceObject);

            if (checckDestoryOfDot.isDestory == false && GameObject.FindGameObjectWithTag("Dot_Sprite") != null)
            {
                gameOverScene.SetActive(true);
                button.gameObject.SetActive(false);
            }
        }
        checckDestoryOfDot.isDestory = false;
    }

    private IEnumerator WaitAndIncrease()
    {
        yield return new WaitForSeconds(10);
        finalTim =+ 1.5f;
    }
}   
