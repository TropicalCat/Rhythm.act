using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GE;

namespace GFW
{
	public class AssetManager :  ServiceModule<AssetManager>
	{
		private Dictionary<string, Sprite> m_DicSprite;

		public AssetManager()
		{
			m_DicSprite = new Dictionary<string, Sprite> ();
		}

		public void Init()
		{
		}

		public void Destory()
		{
		}

		public void Clear()
		{
		}

		private void AddSprite(string name)
		{
		}

		public Sprite GetNumberSprite(string name)
		{
			Sprite sprite;
			m_DicSprite.TryGetValue (name, out sprite);
			return sprite;
		}



	}
}
