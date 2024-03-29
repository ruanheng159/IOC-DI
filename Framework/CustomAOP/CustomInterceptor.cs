﻿using System;
using Castle.DynamicProxy;

namespace Framework.CustomAOP
{
    public class CustomInterceptor : StandardInterceptor
    {
        /// <summary>
        /// 调用前的拦截器
        /// </summary>
        /// <param name="invocation"></param>
        protected override void PreProceed(IInvocation invocation)
        {
            Console.WriteLine($"调用前的拦截器，方法名是：{invocation.Method.Name}");
        }

        /// <summary>
        /// 拦截的方法返回时调用的拦截器
        /// </summary>
        /// <param name="invocation"></param>
        protected override void PerformProceed(IInvocation invocation)
        {
            Console.WriteLine($"拦截的方法返回时调用的拦截器，方法名是：{invocation.Method.Name}");
            base.PerformProceed(invocation);
        }

        /// <summary>
        /// 调用后的拦截器
        /// </summary>
        /// <param name="invocation"></param>
        protected override void PostProceed(IInvocation invocation)
        {
            Console.WriteLine($"调用后的拦截器，方法名是：{invocation.Method.Name}");
        }
    }
}