using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeTest
{
    interface IVideoSource
    {
        string GetTvGuide();
        string PlayVideo();
    }
}
