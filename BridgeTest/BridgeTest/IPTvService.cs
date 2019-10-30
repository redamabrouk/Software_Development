using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeTest
{
    class IPTvService : IVideoSource
    {
        const string SOURCE_NAME = "IP TV";

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
