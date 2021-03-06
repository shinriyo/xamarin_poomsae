﻿//-----------------------------------------------------------------------
// <copyright file="DetailPage.cs" company="shinriyo">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Poomsae
{
    using System;
    using Xamarin.Forms;

    /// <summary>
    /// Detail.
    /// </summary>
    public interface IDetail
    {
        ContentPage Init();
    }

    /// <summary>
    /// Detail factory.
    /// </summary>
    public static class DetailFactory
    {
        /// <summary>
        /// Instantiate the specified obj. こいつで転送.
        /// </summary>
        /// <param name="obj">Object.</param>
        public static ContentPage CreateObject(IDetail obj)
        {
            return obj.Init();
        }
    }
}
