﻿using System;
namespace Xamarin.Forms
{
    public static class FormsMaterial
    {
        public static void Init()
        {
			// my only purpose is to exist so when called
			// this dll doesn't get removed

			VisualMarker.RegisterMaterial();
        }
    }
}