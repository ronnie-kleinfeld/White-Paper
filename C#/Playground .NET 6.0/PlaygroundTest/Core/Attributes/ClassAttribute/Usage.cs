﻿using System.Reflection;
using System.Text;

namespace PlaygroundTest.Core.Attributes.ClassAttribute
{
    internal class Usage
    {
        public static string MakeJson<T>(T theClass) where T : class
        {

            Type type = typeof(T);

            // Get the class properties not include inherited properties
            var classProps = type.GetProperties(BindingFlags.Public
                                                | BindingFlags.NonPublic
                                                | BindingFlags.Static
                                                | BindingFlags.Instance);


            // find the attribute...
            var atts = type.GetCustomAttributes(true);
            if (atts.Any(x => x is SortAttribute))
            {
                var att = atts.FirstOrDefault(x => x is SortAttribute) as SortAttribute;
                if (att.ReverseOrder)
                {
                    classProps = classProps.OrderByDescending(x => x.Name).ToArray();
                }
                else
                {

                    classProps = classProps.OrderBy(x => x.Name).ToArray();
                }
            }

            // reverse the sort order when requested

            StringBuilder sb = new StringBuilder();
            sb.Append('{');
            sb.AppendLine();
            foreach (var prop in classProps)
            {
                sb.AppendLine($"   \"{prop.Name}\" : \"{prop.GetValue(theClass)}\",");

            }

            sb.Append('}');
            sb.AppendLine();

            return sb.ToString();
        }
    }
}