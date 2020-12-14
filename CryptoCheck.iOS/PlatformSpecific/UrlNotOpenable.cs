using System;
using UIKit;
using Foundation;

namespace CryptoCheck.iOS.PlatformSpecific
{
    /// <summary>
    /// iOS specific implementation to determine if the specified URL can
    /// be opened.
    /// </summary>
    public class UrlNotOpenable : CryptoCheck.Inspectors.UrlNotOpenable
    {
        /// <summary>
        /// Determines if the url in question can indeed be opened, iOS style.
        /// </summary>
        protected override bool CanOpenUrl(string url)
        {
            using (var nsUrl = new NSUrl(url))
            {
                return UIApplication.SharedApplication.CanOpenUrl(nsUrl);
            }
        }
    }
}
