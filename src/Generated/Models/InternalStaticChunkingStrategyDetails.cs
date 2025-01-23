// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.VectorStores
{
    internal partial class InternalStaticChunkingStrategyDetails
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalStaticChunkingStrategyDetails(int maxChunkSizeTokens, int chunkOverlapTokens)
        {
            MaxChunkSizeTokens = maxChunkSizeTokens;
            ChunkOverlapTokens = chunkOverlapTokens;
        }

        internal InternalStaticChunkingStrategyDetails(int maxChunkSizeTokens, int chunkOverlapTokens, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            MaxChunkSizeTokens = maxChunkSizeTokens;
            ChunkOverlapTokens = chunkOverlapTokens;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public int MaxChunkSizeTokens { get; set; }

        public int ChunkOverlapTokens { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
