﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Microsoft.Diagnostics.Monitoring.EventPipe
{
    internal interface IStateWithTimestamp
    {
        public DateTime Timestamp { get; }
    }
}
