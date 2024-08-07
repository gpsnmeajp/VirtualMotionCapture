﻿using System;
using UnityEngine;

namespace VMC
{
    public class VMCEvents
    {
        public static Action<GameObject> OnCurrentModelChanged = null;
        public static Action<GameObject> OnModelLoaded = null;
        public static Action<GameObject> OnModelUnloading = null;
        public static Action<Camera> OnCameraChanged = null;
        public static Action OnLightChanged = null;
        public static Action<string> OnLoadedConfigPathChanged = null;
        public static Action<GameObject> BeforeApplyMotion = null;
        public static Action<GameObject> AfterApplyMotion = null;
    }
}