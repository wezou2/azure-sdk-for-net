// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Azure;
    using Management;
    using DataLake;
    using Store;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A WebHDFS exception thrown indicating the file or folder could not be
    /// found. Thrown when a 404 error response code is returned (not found).
    /// </summary>
    [Newtonsoft.Json.JsonObject("FileNotFoundException")]
    public partial class AdlsFileNotFoundException : AdlsRemoteException
    {
        /// <summary>
        /// Initializes a new instance of the AdlsFileNotFoundException class.
        /// </summary>
        public AdlsFileNotFoundException() { }

        /// <summary>
        /// Initializes a new instance of the AdlsFileNotFoundException class.
        /// </summary>
        /// <param name="javaClassName">the full class package name for the
        /// exception thrown, such as
        /// 'java.lang.IllegalArgumentException'.</param>
        /// <param name="message">the message associated with the exception
        /// that was thrown, such as 'Invalid value for webhdfs parameter
        /// "permission":...'.</param>
        public AdlsFileNotFoundException(string javaClassName = default(string), string message = default(string))
            : base(javaClassName, message)
        {
        }

    }
}
