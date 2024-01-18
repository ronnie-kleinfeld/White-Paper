﻿using LandonApi.Filters;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace LandonApi.Infrastructure {
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class EtagAttribute : Attribute, IFilterFactory {
        public bool IsReusable => true;

        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider) {
            return new EtagHeaderFilter();
        }
    }
}