using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Momosdk.Reactnative.RNMomosdkReactnative
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNMomosdkReactnativeModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNMomosdkReactnativeModule"/>.
        /// </summary>
        internal RNMomosdkReactnativeModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNMomosdkReactnative";
            }
        }
    }
}
