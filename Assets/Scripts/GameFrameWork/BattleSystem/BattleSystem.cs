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


			GameObject BattleRoot = new GameObject();
			BattleRoot.name = "BattleRoot";
			BattleRoot.transform.SetParent (null, false);
			//GameObject root = GameObject.Find ("Main");




			kk kkObj = BattleRoot.AddComponent<kk>();
			GameObject BattleRoot1 = new GameObject();
			BattleRoot1.name = "BattleRoot";

			BattleRoot1.transform.SetParent (BattleRoot.transform, false);


		}


	}
}