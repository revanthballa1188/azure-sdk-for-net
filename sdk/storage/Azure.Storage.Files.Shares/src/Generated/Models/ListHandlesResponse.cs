// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> An enumeration of handles. </summary>
    internal partial class ListHandlesResponse
    {
        /// <summary> Initializes a new instance of <see cref="ListHandlesResponse"/>. </summary>
        /// <param name="nextMarker"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextMarker"/> is null. </exception>
        internal ListHandlesResponse(string nextMarker)
        {
            Argument.AssertNotNull(nextMarker, nameof(nextMarker));

            HandleList = new ChangeTrackingList<HandleItem>();
            NextMarker = nextMarker;
        }

        /// <summary> Initializes a new instance of <see cref="ListHandlesResponse"/>. </summary>
        /// <param name="handleList"></param>
        /// <param name="nextMarker"></param>
        internal ListHandlesResponse(IReadOnlyList<HandleItem> handleList, string nextMarker)
        {
            HandleList = handleList;
            NextMarker = nextMarker;
        }

        /// <summary> Gets the handle list. </summary>
        public IReadOnlyList<HandleItem> HandleList { get; }
        /// <summary> Gets the next marker. </summary>
        public string NextMarker { get; }
    }
}
