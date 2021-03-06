// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using System.Linq;

    /// <summary>
    /// Context object with previous QnA's information.
    /// </summary>
    public partial class QueryDTOContext : QueryContextDTO
    {
        /// <summary>
        /// Initializes a new instance of the QueryDTOContext class.
        /// </summary>
        public QueryDTOContext()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryDTOContext class.
        /// </summary>
        /// <param name="previousQnaId">Previous QnA Id - qnaId of the top
        /// result.</param>
        /// <param name="previousUserQuery">Previous user query.</param>
        public QueryDTOContext(string previousQnaId = default(string), string previousUserQuery = default(string))
            : base(previousQnaId, previousUserQuery)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
