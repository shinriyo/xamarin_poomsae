﻿//-----------------------------------------------------------------------
// <copyright file="YouTubePage.cs" company="shinriyo">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Poomsae
{
    using OpenWebBrowserSample.Services;
    using Xamarin.Forms;

    /// <summary>
    /// You tube page.
    /// </summary>
    public class YouTubePage : ContentPage
    {
        public static string youtubeUrl { get; set; }

        public YouTubePage()
        {
            var baseHtml = @"<!DOCTYPE html>
            <html>
            <head>
              <script src=""jquery.js""></script>
              <script src=""js/mediaelement-and-player.min.js""></script>
              <link rel=""stylesheet"" href=""css/mediaelementplayer.css"" />
              <video width=""640"" height=""360"" id=""player1"" preload=""none"">
                <source type=""video/youtube""
                src=""{0}"" />
              </video>
              <script>
                var player = new MediaElementPlayer('#player1');
              </script>
            </head>
            <body>
            </body>
            </html>";

            var htmlSource = string.Format(baseHtml, youtubeUrl);
            var html = new HtmlWebViewSource
            {
                Html = htmlSource,
                // パスを取る時.
                BaseUrl = DependencyService.Get<IWebBrowserService>().Get(),
            };

            var webView = new WebView
            {
                Source = html
            };

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            Content = webView;
        }
    }
}
