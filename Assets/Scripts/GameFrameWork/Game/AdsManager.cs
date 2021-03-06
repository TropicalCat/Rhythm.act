﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GE;
using UnityEngine.Advertisements;


namespace GFW
{
	public class AdsManager :  ServiceModule<AdsManager> 
	{

		string gpGameID = "1598965";
		string iosGameID = "1598966";

		public AdsManager()
		{
		}

		public void Init()
		{

			if (Advertisement.isSupported) 
			{
				Advertisement.Initialize (gpGameID, true);
			}

		}

		public void Destory()
		{
		}

		public void Clear()
		{
		}

		public bool AdsIsReady()
		{
			return Advertisement.IsReady();
		}



		public void ShowAd()
		{
			return;

			if (Advertisement.IsReady ())
				Advertisement.Show ();

			return;


			if(Advertisement.IsReady("rewardedVideo")) {
				var options = new ShowOptions();
				options.resultCallback = HandleShowResult;
				Advertisement.Show("rewardedVideo", options);
			}else{
				Debug.Log("Rewarded Video not available");
			}
		}

		//HandleShowResult will be called when the ad stops playing, and pass the result enumerator
		void HandleShowResult (ShowResult result)
		{
			if(result == ShowResult.Finished) {
				Debug.Log("Video completed - Offer a reward to the player");

			}else if(result == ShowResult.Skipped) {
				Debug.LogWarning("Video was skipped - Do NOT reward the player");

			}else if(result == ShowResult.Failed) {
				Debug.LogError("Video failed to show");
			}
		}



	}

}