﻿using System;
using System.Runtime.InteropServices;

namespace MonoGame.Utilities
{
    internal static partial class ReflectionHelpers
    {
        /// <summary>
        /// Generics handler for Marshal.SizeOf
        /// </summary>
        internal static class SizeOf<T>
        {
            static int _sizeOf;

            static SizeOf() { _sizeOf = Marshal.SizeOf<T>(); }

            public static int Get() { return _sizeOf; }
        }

        /// <summary>
        /// Fallback handler for Marshal.SizeOf(type)
        /// </summary>
        internal static int ManagedSizeOf(Type type) { return Marshal.SizeOf(type); }
    }
}
