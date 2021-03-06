// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.


using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.SignalR.Hosting;

namespace Microsoft.AspNet.SignalR
{
    /// <summary>
    /// Represents a SignalR request
    /// </summary>
    public interface IRequest
    {
        /// <summary>
        /// The local path part of the url
        /// </summary>
        string LocalPath { get; }
        
        /// <summary>
        /// Gets the querystring for this request.
        /// </summary>
        IReadableStringCollection QueryString { get; }

        /// <summary>
        /// Gets the headers for this request.
        /// </summary>
        IReadableStringCollection Headers { get; }

        /// <summary>
        /// Gets the cookies for this request.
        /// </summary>
        IReadableStringCollection Cookies { get; }

        /// <summary>
        /// Gets security information for the current HTTP request.
        /// </summary>
        ClaimsPrincipal User { get; }

        /// <summary>
        /// Reads the form of the http request
        /// </summary>
        /// <returns></returns>
        Task<IReadableStringCollection> ReadForm();
    }
}
