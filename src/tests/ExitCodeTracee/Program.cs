﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Tracee
{
    internal sealed class Program
    {
        private static int Main(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }

            return int.Parse(args[0]);
        }
    }
}
