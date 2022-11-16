using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroungMusic : MonoBehaviour
{
    BackGroungMusic instant = null;
    public AdsManager ads;

    private void Start()
    {
        ads.ShowBanner();
        if (instant != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instant = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    public void DisableMusic()
    {
        gameObject.SetActive(false);
    }
}
