﻿using System;

namespace SharpCompress.Common;

internal static class FlagUtility
{
    /// <summary>
    /// Returns true if the flag is set on the specified bit field.
    /// Currently only works with 32-bit bitfields.
    /// </summary>
    /// <typeparam name="T">Enumeration with Flags attribute</typeparam>
    /// <param name="bitField">Flagged variable</param>
    /// <param name="flag">Flag to test</param>
    /// <returns></returns>
    public static bool HasFlag<T>(long bitField, T flag) where T : struct =>
        HasFlag(bitField, flag);

    /// <summary>
    /// Returns true if the flag is set on the specified bit field.
    /// Currently only works with 32-bit bitfields.
    /// </summary>
    /// <typeparam name="T">Enumeration with Flags attribute</typeparam>
    /// <param name="bitField">Flagged variable</param>
    /// <param name="flag">Flag to test</param>
    /// <returns></returns>
    public static bool HasFlag<T>(ulong bitField, T flag) where T : struct =>
        HasFlag(bitField, flag);

    /// <summary>
    /// Returns true if the flag is set on the specified bit field.
    /// Currently only works with 32-bit bitfields.
    /// </summary>
    /// <param name="bitField">Flagged variable</param>
    /// <param name="flag">Flag to test</param>
    /// <returns></returns>
    public static bool HasFlag(ulong bitField, ulong flag) => ((bitField & flag) == flag);

    public static bool HasFlag(short bitField, short flag) => ((bitField & flag) == flag);

    /// <summary>
    /// Returns true if the flag is set on the specified bit field.
    /// Currently only works with 32-bit bitfields.
    /// </summary>
    /// <typeparam name="T">Enumeration with Flags attribute</typeparam>
    /// <param name="bitField">Flagged variable</param>
    /// <param name="flag">Flag to test</param>
    /// <returns></returns>
    public static bool HasFlag<T>(T bitField, T flag) where T : struct =>
        HasFlag(Convert.ToInt64(bitField), Convert.ToInt64(flag));

    /// <summary>
    /// Returns true if the flag is set on the specified bit field.
    /// Currently only works with 32-bit bitfields.
    /// </summary>
    /// <param name="bitField">Flagged variable</param>
    /// <param name="flag">Flag to test</param>
    /// <returns></returns>
    public static bool HasFlag(long bitField, long flag) => ((bitField & flag) == flag);

    /// <summary>
    /// Sets a bit-field to either on or off for the specified flag.
    /// </summary>
    /// <param name="bitField">Flagged variable</param>
    /// <param name="flag">Flag to change</param>
    /// <param name="on">bool</param>
    /// <returns>The flagged variable with the flag changed</returns>
    public static long SetFlag(long bitField, long flag, bool on)
    {
        if (on)
        {
            return bitField | flag;
        }
        return bitField & (~flag);
    }

    /// <summary>
    /// Sets a bit-field to either on or off for the specified flag.
    /// </summary>
    /// <typeparam name="T">Enumeration with Flags attribute</typeparam>
    /// <param name="bitField">Flagged variable</param>
    /// <param name="flag">Flag to change</param>
    /// <param name="on">bool</param>
    /// <returns>The flagged variable with the flag changed</returns>
    public static long SetFlag<T>(T bitField, T flag, bool on) where T : struct =>
        SetFlag(Convert.ToInt64(bitField), Convert.ToInt64(flag), on);
}
