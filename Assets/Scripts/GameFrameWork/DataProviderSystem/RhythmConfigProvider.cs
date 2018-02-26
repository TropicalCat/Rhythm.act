using System;
using System.Collections.Generic;
using GE;

namespace GFW
{
	public class RhythmConfig
	{
		public System.Int32 ID = 0;
		public System.String Shoot = string.Empty;
		public System.Single Time = 0;
		public System.Int32 Event = 0;
		public System.Int32 Operation = 0;
		public System.Single Touch = 0;
		public System.Single PerfectTouch = 0;
		public System.Single ValidTouch = 0;
	}

	public class RhythmConfigProvider : Singleton<RhythmConfigProvider>, IDataProvider
	{
		private List<RhythmConfig> dataList = new List<RhythmConfig>();
		public string Path()
		{
			return "data/Rhythm.txt";
		}
		public void Load()
		{
			dataList.Clear ();
			
			RhythmConfig item = null;
			while (!FileReader.IsEnd())
			{
				FileReader.ReadLine();
				item = new RhythmConfig();
				item.ID = FileReader.ReadInt ();
				item.Shoot = FileReader.ReadString();
				item.Time = FileReader.ReadFloat();
				item.Event = FileReader.ReadInt ();
				item.Operation = FileReader.ReadInt ();
				item.Touch = FileReader.ReadFloat ();
				item.PerfectTouch = FileReader.ReadFloat ();
				item.ValidTouch = FileReader.ReadFloat ();
				dataList.Add(item);
			}
		}
		public bool Verify()
		{
			return true;
		}
		public List<RhythmConfig> GetAllData()
		{
			return dataList;
		}
		public RhythmConfig GetData(System.String name)
		{
			RhythmConfig ret = null;
			for (int i = 0; i < dataList.Count; ++i)
			{
//				if (dataList [i].name.Equals (name)) {
//					ret = dataList [i];
//					break;
//				}
			}
			return ret;
		}
		public void LoadExtraData ()
		{
		}
	}
}
