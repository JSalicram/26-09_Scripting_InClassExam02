using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class AdManager : MonoBehaviour
{
    public Text txt;
    public int adsViewed = 0;

    public void Update()
    {
        txt.text = ("Rewarded ads viewed: " + adsViewed);
    }

    public void adButtonPressed()
    {
        Analytics.CustomEvent("rewarded ad started");
        var options = new ShowOptions { resultCallback = HandleShowResult };
        Advertisement.Show(options);
    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("ad finished");
                Debug.Log("Here is your reward");
                adsViewed++;
                Analytics.CustomEvent("rewarded ad finished");
                break;
            case ShowResult.Skipped:
                Debug.Log("ad skipped");
                Analytics.CustomEvent("rewarded ad skipped");
                break;
            case ShowResult.Failed:
                Debug.LogError("ad failed");
                Analytics.CustomEvent("rewarded ad failed");
                break;
        }
    }
}
