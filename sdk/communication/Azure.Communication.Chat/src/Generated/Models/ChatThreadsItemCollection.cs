// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> Collection of chat threads. </summary>
    internal partial class ChatThreadsItemCollection
    {
        /// <summary> Initializes a new instance of ChatThreadsItemCollection. </summary>
        /// <param name="value"> Collection of chat threads. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ChatThreadsItemCollection(IEnumerable<ChatThreadItem> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ChatThreadsItemCollection. </summary>
        /// <param name="value"> Collection of chat threads. </param>
        /// <param name="nextLink"> If there are more chat threads that can be retrieved, the next link will be populated. </param>
        internal ChatThreadsItemCollection(IReadOnlyList<ChatThreadItem> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of chat threads. </summary>
        public IReadOnlyList<ChatThreadItem> Value { get; }
        /// <summary> If there are more chat threads that can be retrieved, the next link will be populated. </summary>
        public string NextLink { get; }
    }
}
