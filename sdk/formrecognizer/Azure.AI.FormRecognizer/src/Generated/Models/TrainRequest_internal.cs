// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.FormRecognizer.Training;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Request parameter to train a new custom model. </summary>
    internal partial class TrainRequest_internal
    {
        /// <summary> Initializes a new instance of TrainRequest_internal. </summary>
        /// <param name="source"> Source path containing the training documents. </param>
        public TrainRequest_internal(string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            Source = source;
        }

        /// <summary> Initializes a new instance of TrainRequest_internal. </summary>
        /// <param name="source"> Source path containing the training documents. </param>
        /// <param name="sourceFilter"> Filter to apply to the documents in the source path for training. </param>
        /// <param name="useLabelFile"> Use label file for training a model. </param>
        internal TrainRequest_internal(string source, TrainingFileFilter sourceFilter, bool? useLabelFile)
        {
            Source = source;
            SourceFilter = sourceFilter;
            UseLabelFile = useLabelFile;
        }

        /// <summary> Source path containing the training documents. </summary>
        public string Source { get; }
        /// <summary> Filter to apply to the documents in the source path for training. </summary>
        public TrainingFileFilter SourceFilter { get; set; }
        /// <summary> Use label file for training a model. </summary>
        public bool? UseLabelFile { get; set; }
    }
}
