using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize("4367065");
    }

    public void ShowBanner()
    {
        if (Advertisement.IsReady("Banner_Android"))
        {
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
            Advertisement.Banner.Show("Banner_Android");
        }
        else
        {
            StartCoroutine(ReadyShowBanner());
        }
    }

    IEnumerator ReadyShowBanner()
    {
        yield return new WaitForSeconds(1.0f);
        ShowBanner();
    }
}
