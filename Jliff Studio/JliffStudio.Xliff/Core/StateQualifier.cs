using System;

namespace JliffStudio.Xliff
{
    public class StateQualifier
    {
        /// <summary>
        /// Indicates an exact match. An exact match occurs when a source text of a segment is exactly the same as the source text of a segment that was translated previously.
        /// </summary>
        public static StateQualifier ExactMatch = new StateQualifier("exact-match", false);

        /// <summary>
        /// Indicates a fuzzy match. A fuzzy match occurs when a source text of a segment is very similar to the source text of a segment that was translated previously (e.g. when the difference is casing, a few changed words, white-space discripancy, etc.).
        /// </summary>
        public static StateQualifier FuzzyMatch = new StateQualifier("fuzzy-match", false);

        /// <summary>
        /// Indicates a match based on matching IDs (in addition to matching text).
        /// </summary>
        public static StateQualifier IdMatch = new StateQualifier("id-match", false);

        /// <summary>
        /// Indicates a translation derived from a glossary.
        /// </summary>
        public static StateQualifier LeveragedGlossary = new StateQualifier("leveraged-glossary", false);

        /// <summary>
        /// Indicates a translation derived from existing translation.
        /// </summary>
        public static StateQualifier LeveragedInherited = new StateQualifier("leveraged-inherited", false);

        /// <summary>
        /// Indicates a translation derived from machine translation.
        /// </summary>
        public static StateQualifier LeveragedMachineTranslation = new StateQualifier("leveraged-mt", false);

        /// <summary>
        /// Indicates a translation derived from a translation repository.
        /// </summary>
        public static StateQualifier LeveragedRepository = new StateQualifier("leveraged-repository", false);

        /// <summary>
        /// Indicates a translation derived from a translation memory.
        /// </summary>
        public static StateQualifier LeveragedTranslationMemory = new StateQualifier("leveraged-tm", false);

        /// <summary>
        /// Indicates the translation is suggested by machine translation.
        /// </summary>
        public static StateQualifier MachineTranslationSuggestion = new StateQualifier("mt-suggestion", false);

        /// <summary>
        /// Indicates that the item has been rejected because of incorrect grammar.
        /// </summary>
        public static StateQualifier RejectedGrammar = new StateQualifier("rejected-grammar", false);

        /// <summary>
        /// 	Indicates that the item has been rejected because it is incorrect.
        /// </summary>
        public static StateQualifier RejectedInaccurate = new StateQualifier("rejected-inaccurate", false);

        /// <summary>
        /// Indicates that the item has been rejected because it is too long or too short.
        /// </summary>
        public static StateQualifier RejectedLength = new StateQualifier("rejected-length", false);

        /// <summary>
        /// Indicates that the item has been rejected because of incorrect spelling.
        /// </summary>
        public static StateQualifier RejectedSpelling = new StateQualifier("rejected-spelling", false);

        /// <summary>
        /// 	Indicates the translation is suggested by translation memory.
        /// </summary>
        public static StateQualifier TranslationMemorySuggestion = new StateQualifier("tm-suggestion", false);

        public string Value { get; }

        public StateQualifier(string value)
            : this(value, true)
        {
        }

        private StateQualifier(string value, bool userDefined)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(nameof(value));
            }

            Value = userDefined ? $"x-{value}" : value;
        }
    }
}