﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LightStore.Model
{
    /// <summary>
    /// Login for an operator model
    /// </summary>
    [DataContract]
    public sealed class LoginModel
    {
        /// <summary>
        /// Login/pseudo
        /// </summary>
        [DataMember]
        public string Login { get; set; }
    }
}