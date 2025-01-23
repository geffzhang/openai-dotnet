// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageDeltaContentImageUrlObjectImageUrl
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalMessageDeltaContentImageUrlObjectImageUrl()
        {
        }

        internal InternalMessageDeltaContentImageUrlObjectImageUrl(Uri url, string detail, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Url = url;
            Detail = detail;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public Uri Url { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
