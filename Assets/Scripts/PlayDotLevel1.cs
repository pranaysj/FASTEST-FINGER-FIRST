using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayDotLevel1 : MonoBehaviour
{
    public void Play()
    {
        StartCoroutine(PlayCall());
    }

    public IEnumerator PlayCall()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Dot_Level_1");
    }
}
