using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GE;

namespace GFW
{
    public interface IDataProvider
    {
        string Path();

        void Load();

        bool Verify();

		void LoadExtraData ();
    }
}
