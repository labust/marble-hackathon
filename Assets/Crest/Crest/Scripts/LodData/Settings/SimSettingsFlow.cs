﻿// Crest Ocean System

// Copyright 2020 Wave Harmonic Ltd

using UnityEngine;

namespace Crest
{
    [CreateAssetMenu(fileName = "SimSettingsFlow", menuName = "Crest/Flow Sim Settings", order = 10000)]
    public class SimSettingsFlow : SimSettingsBase
    {
        /// <summary>
        /// The version of this asset. Can be used to migrate across versions. This value should
        /// only be changed when the editor upgrades the version.
        /// </summary>
        [SerializeField, HideInInspector]
#pragma warning disable 414
        int _version = 0;
#pragma warning restore 414
    }
}
