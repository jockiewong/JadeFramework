﻿using System;

namespace JadeFramework.Cache
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class CachingAttribute : Attribute
    {
        /// <summary>
        /// 过期时间 秒
        /// </summary>
        public int AbsoluteExpiration { get; set; }
    }
}
