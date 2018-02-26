using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using GE;

namespace GFW
{
    public class DataProviderSystem : Singleton<DataProviderSystem>
    {
        private List<IDataProvider> mDataProvider = new List<IDataProvider>();

        public bool Init()
        {
            // 注册
			RegisterDataProvider (RhythmConfigProvider.Instance);

            // 加载
            if (!Load()) return false;
		
            return true;
        }

		public void Tick(float interval)
        {

        }

        public void Destroy()
        {
            mDataProvider.Clear();
        }

        private bool Load()
        {
            IDataProvider provider = null;
            for (int i = 0; i < mDataProvider.Count; ++i)
            {
                provider = mDataProvider[i];
                if (null != provider)
                {
					FileReader.LoadPath(FormatDataProviderPath(provider.Path()));

                    provider.Load();

                    if (!provider.Verify()) return false;

                    FileReader.UnLoad();
                }
            }

            return true;
        }

        private void RegisterDataProvider(IDataProvider dataProvider)
        {
            mDataProvider.Add(dataProvider);
        }

		public static string FormatDataProviderPath(string datapath)
        {
			return System.IO.Path.Combine(Application.streamingAssetsPath, datapath);
		}

		public void LoadExtraData (string path)
		{
			IDataProvider provider = null;
			for (int i = 0; i < mDataProvider.Count; ++i)
			{
				provider = mDataProvider[i];
				if (null != provider)
				{
					FileReader.LoadPath(System.IO.Path.Combine(path, provider.Path()));

					provider.LoadExtraData ();

					provider.Verify();

					FileReader.UnLoad();
				}
			}
		}
    }
}
