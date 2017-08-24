﻿//  ****************************************************************************
//  * The MIT License(MIT)
//  * Copyright © 2017 Thomas Due
//  * 
//  * Permission is hereby granted, free of charge, to any person obtaining a 
//  * copy of this software and associated documentation files (the “Software”), 
//  * to deal in the Software without restriction, including without limitation 
//  * the rights to use, copy, modify, merge, publish, distribute, sublicense, 
//  * and/or sell copies of the Software, and to permit persons to whom the  
//  * Software is furnished to do so, subject to the following conditions:
//  * 
//  * The above copyright notice and this permission notice shall be included in  
//  * all copies or substantial portions of the Software.
//  * 
//  * THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS  
//  * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
//  * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL  
//  * THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING  
//  * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
//  * IN THE SOFTWARE.
//  ****************************************************************************

using System.Security;
using Newtonsoft.Json;
using AgileCardsPrinting.Common;
// ReSharper disable NonReadonlyMemberInGetHashCode

namespace AgileCardsPrinting.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class SettingsModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsModel"/> class.
        /// </summary>
        public SettingsModel()
        {
            HostAddress = string.Empty;
            UserId = string.Empty;
            Password = null;
            MaxResult = 50;
        }

        /// <summary>
        /// Gets or sets the host address.
        /// </summary>
        /// <value>
        /// The host address.
        /// </value>
        public string HostAddress { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [JsonConverter(typeof(JsonEncryptionConverter))]
        public SecureString Password { get; set; }

        /// <summary>
        /// Gets or sets the maximum result.
        /// </summary>
        /// <value>
        /// The maximum result.
        /// </value>
        public int MaxResult { get; set; }

        /// <summary>
        /// Gets or sets the name of the report.
        /// </summary>
        /// <value>
        /// The name of the report.
        /// </value>
        public string ReportName { get; set; }

        /// <summary>
        /// Gets or sets the custom field1.
        /// </summary>
        /// <value>
        /// The custom field1.
        /// </value>
        public string CustomField1 { get; set; }

        /// <summary>
        /// Gets or sets the custom field2.
        /// </summary>
        /// <value>
        /// The custom field2.
        /// </value>
        public string CustomField2 { get; set; }

        /// <summary>
        /// Gets or sets the custom field3.
        /// </summary>
        /// <value>
        /// The custom field3.
        /// </value>
        public string CustomField3 { get; set; }

        /// <summary>
        /// Gets or sets the custom field4.
        /// </summary>
        /// <value>
        /// The custom field4.
        /// </value>
        public string CustomField4 { get; set; }

        protected bool Equals(SettingsModel other)
        {
            return //Equals(Password, other.Password) && 
                   MaxResult == other.MaxResult &&
                   string.Equals(HostAddress, other.HostAddress) &&
                   string.Equals(UserId, other.UserId) && 
                   string.Equals(ReportName, other.ReportName) && 
                   string.Equals(CustomField1, other.CustomField1) &&
                   string.Equals(CustomField2, other.CustomField2) && 
                   string.Equals(CustomField3, other.CustomField3) &&
                   string.Equals(CustomField4, other.CustomField4);
        }

        public override bool Equals(object obj)
        {
            return !ReferenceEquals(null, obj) && (ReferenceEquals(this, obj) || obj.GetType() == GetType() && Equals((SettingsModel) obj));
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = HostAddress != null ? HostAddress.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (UserId != null ? UserId.GetHashCode() : 0);
                //hashCode = (hashCode * 397) ^ (Password != null ? Password.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ MaxResult;
                hashCode = (hashCode * 397) ^ (ReportName != null ? ReportName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (CustomField1 != null ? CustomField1.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (CustomField2 != null ? CustomField2.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (CustomField3 != null ? CustomField3.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (CustomField4 != null ? CustomField4.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
