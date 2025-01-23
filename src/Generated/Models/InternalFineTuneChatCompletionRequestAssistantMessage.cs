// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI.Chat;

namespace OpenAI.FineTuning
{
    internal partial class InternalFineTuneChatCompletionRequestAssistantMessage : AssistantChatMessage
    {
        public InternalFineTuneChatCompletionRequestAssistantMessage()
        {
        }

        internal InternalFineTuneChatCompletionRequestAssistantMessage(Chat.ChatMessageRole role, ChatMessageContent content, IDictionary<string, BinaryData> additionalBinaryDataProperties, string refusal, string participantName, IList<ChatToolCall> toolCalls, ChatFunctionCall functionCall) : base(role, content, additionalBinaryDataProperties, refusal, participantName, toolCalls, functionCall)
        {
        }
    }
}
