﻿using OrderRules.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;

namespace OrderRules.RuleChecker
{
    public static class DynamicOrderRuleLoader
    {
        public static List<DynamicOrderRule> LoadRules(string assemblyPath)
        {
            var rules = new List<DynamicOrderRule>();

            // TODO: Add code to dynamically load rules based on a path.
            if (!Directory.Exists(assemblyPath))
            {
                return rules;
            }

            IEnumerable<string> assemblyFiles = Directory.EnumerateFiles(assemblyPath, "*.dll", SearchOption.TopDirectoryOnly);

            foreach (var assemblyFile in assemblyFiles)
            {
                Assembly assembly = Assembly.LoadFrom(assemblyFile);

                foreach (var type in assembly.ExportedTypes)
                {
                    if( type.IsClass && typeof(IOrderRule).IsAssignableFrom(type))   // Does the class implement IOrderRule?
                    {
                        IOrderRule rule = Activator.CreateInstance(type) as IOrderRule;
                        rules.Add(new DynamicOrderRule(rule, type.FullName, type.Assembly.GetName().Name));
                    }
                }
            }


            return rules;
        }
    }
}
