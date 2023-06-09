﻿// Crest Ocean System

// Copyright 2021 Wave Harmonic Ltd

namespace Crest
{
    /// <summary>
    /// Puts together a hash from given data values
    /// </summary>
    public static class Hashy
    {
        public static int CreateHash() => 0x19384567;

        public static void AddFloat(float value, ref int hash)
        {
            hash ^= value.GetHashCode();
        }

        public static void AddInt(int value, ref int hash)
        {
            hash ^= value;
        }

        public static void AddBool(bool value, ref int hash)
        {
            hash ^= (value ? 0x74659374 : 0x62649035);
        }

        public static void AddObject(object value, ref int hash)
        {
            // Will be the index of this object instance
            hash ^= value.GetHashCode();
        }
    }
}
