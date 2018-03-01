using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GE;

namespace GFW
{

	public class BattleSystem : ServiceModule<BattleSystem> 
	{

		// Use this for initialization
		public void Init ()
		{

		}

		// Update is called once per frame
		public void Update () 
		{

		}

		public BattleSystem()
		{
		}
			
		public void InitBattle()
		{
			List<RhythmConfig> shythmCfgs = RhythmConfigProvider.Instance.GetAllData ();


			GameObject battleRoot = new GameObject();
			battleRoot.name = "BattleRoot";
			battleRoot.transform.SetParent (null, false);
			//GameObject root = GameObject.Find ("Main");

			kk kkObj = battleRoot.AddComponent<kk>();



			GameObject ballRoot = new GameObject();
			ballRoot.name = "BallRoot";
			ballRoot.transform.SetParent (battleRoot.transform, false);

			GameObject ball =  Resources.Load ("Prefab/ball") as GameObject;
			GameObject ballCopy = GameObject.Instantiate (ball);
			ballCopy.transform.SetParent (ballRoot.transform, false);


			SpriteRenderer sp = ballCopy.GetComponent<SpriteRenderer> ();
			Texture2D texture = Resources.Load ("Texture/ball/duck") as Texture2D;
			sp.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);



			GameObject hand = Resources.Load ("Prefab/animation/chopsticks") as GameObject;
			GameObject handCopy = GameObject.Instantiate (hand);
			handCopy.transform.SetParent (battleRoot.transform, false);
			Animator ani = handCopy.GetComponent<Animator> ();
			if (null != ani) 
			{
				ani.Play ("Exit");
				//ani.StopPlayback ();
			}

		}


	}
}