using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeTest
{
    class LocalDishTv : IVideoSource
    {
        const string SOURCE_NAME = "Local DISH TV";

        string IVideoSource.GetTvGuide()
        {
            return string.Format("Getting TV guide from - {0}", SOURCE_NAME);
        }

        string IVideoSource.PlayVideo()
        {
            return string.Format("Playing - {0}", SOURCE_NAME);
        }
    }
}
