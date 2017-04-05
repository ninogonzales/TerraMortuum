using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class GameOver : MonoBehaviour {

    BannerView banner;
    InterstitialAd interstitial;

    private void Start()
    {
        RequestBanner();
        RequestInterstitial();
    }
    
	public void TryAgainBtn(string scene)
	{
		SceneManager.LoadScene(scene);
	}
	public void QuitBtn(string scene)
	{
        banner.Show();
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
            RequestInterstitial();
        }
        else
        {
            RequestInterstitial();
        }
        
        SceneManager.LoadScene(scene);
	}
    private void RequestBanner()
    {  
        string adUnitId = "ca-app-pub-2041584599449732/9974049800";

        // Create a 320x50 banner at the top of the screen.
        banner = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        banner.LoadAd(request);
    }

    private void RequestInterstitial()
    {
        string adUnitId = "ca-app-pub-2041584599449732/9055719809";

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }
}