using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TouchToDestory : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreNumber;
    [SerializeField] TextMeshProUGUI scoreNumberRestart;
    public float score;
    DotsCreator dotsSpawnFromScript;
    public bool isDestory;
    AudioSource pingSound;

    public void Start()
    {
        pingSound = GetComponent<AudioSource>();
        dotsSpawnFromScript = GetComponent<DotsCreator>();
    }

    void Update()
    {
        if (Input.touchCount > 0 || Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Debug.DrawRay(ray,Vector3.forward);

            RaycastHit2D hit = Physics2D.Raycast(ray, Vector3.forward);

            if (hit.collider != null)
            {
                pingSound.Play();
                Destroy(hit.collider.gameObject);
                var finalScore = ++score;
                scoreNumber.text = "" + finalScore;
                scoreNumberRestart.text = "" + finalScore; 
                isDestory = true;
            }
        }
    }
}
