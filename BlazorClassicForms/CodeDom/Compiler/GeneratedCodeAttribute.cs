﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.CodeDom.Compiler
{
    //
    // Summary:
    //     Identifies code generated by a tool. This class cannot be inherited.
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    public sealed class GeneratedCodeAttribute : Attribute
    {
        //
        // Summary:
        //     Initializes a new instance of the System.CodeDom.Compiler.GeneratedCodeAttribute
        //     class specifying the name and version of the tool that generated the code.
        //
        // Parameters:
        //   tool:
        //     The name of the tool that generated the code.
        //
        //   version:
        //     The version of the tool that generated the code.
        public GeneratedCodeAttribute(string tool, string version)
        {

        }

        //
        // Summary:
        //     Gets the name of the tool that generated the code.
        //
        // Returns:
        //     The name of the tool that generated to code.
        public string Tool { get; }
        //
        // Summary:
        //     Gets the version of the tool that generated the code.
        //
        // Returns:
        //     The version of the tool that generated the code.
        public string Version { get; }
    }
}