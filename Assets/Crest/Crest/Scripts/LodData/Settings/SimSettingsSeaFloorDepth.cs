﻿// Crest Ocean System

// Copyright 2021 Wave Harmonic Ltd

using UnityEngine;

namespace Crest
{
    [CreateAssetMenu(fileName = "SimSettingsSeaFloorDepth", menuName = "Crest/Sea Floor Depth Settings", order = 10000)]
    public class SimSettingsSeaFloorDepth : SimSettingsBase
    {
        [Tooltip("Allow varying water level, to support water bodies at different heights and rivers to run down slopes. Disabling this will save some memory and may improve performance on some platforms.")]
        public bool _allowVaryingWaterLevel = true;

        public override void AddToSettingsHash(ref int settingsHash)
        {
            base.AddToSettingsHash(ref settingsHash);

            Hashy.AddBool(_allowVaryingWaterLevel, ref settingsHash);
        }
    }
}
