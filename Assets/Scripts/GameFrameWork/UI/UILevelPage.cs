using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GE;


namespace GFW
{
	public class UILevelPage : UIPage  
	{


		protected override void OnOpen(object arg = null)
		{
			base.OnOpen (arg);

		}

		protected override void OnClose(object arg = null)
		{
			
			base.OnClose (arg);
		}

		private void OnStart()
		{
			AudioManager.Instance.PlayClick ();


		}
	}
}
