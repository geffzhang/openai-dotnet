// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Files
{
    internal static partial class FilePurposeExtensions
    {
        public static string ToSerialString(this Files.FilePurpose value) => value switch
        {
            Files.FilePurpose.Assistants => "assistants",
            Files.FilePurpose.AssistantsOutput => "assistants_output",
            Files.FilePurpose.Batch => "batch",
            Files.FilePurpose.BatchOutput => "batch_output",
            Files.FilePurpose.FineTune => "fine-tune",
            Files.FilePurpose.FineTuneResults => "fine-tune-results",
            Files.FilePurpose.Vision => "vision",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FilePurpose value.")
        };

        public static Files.FilePurpose ToFilePurpose(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "assistants"))
            {
                return Files.FilePurpose.Assistants;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "assistants_output"))
            {
                return Files.FilePurpose.AssistantsOutput;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "batch"))
            {
                return Files.FilePurpose.Batch;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "batch_output"))
            {
                return Files.FilePurpose.BatchOutput;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "fine-tune"))
            {
                return Files.FilePurpose.FineTune;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "fine-tune-results"))
            {
                return Files.FilePurpose.FineTuneResults;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "vision"))
            {
                return Files.FilePurpose.Vision;
            }
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FilePurpose value.");
        }
    }
}
