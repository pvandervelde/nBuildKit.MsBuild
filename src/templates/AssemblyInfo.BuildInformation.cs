//-----------------------------------------------------------------------
// <copyright company="${CompanyName}">
//     Copyright (c) ${CompanyName}. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
//
//-----------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behaviour and will be lost
//     if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Nuclei.Build;

/*
 * THIS IS A GENERATED FILE. DO NOT MAKE CHANGES IN THIS FILE BECAUSE ANY
 * CHANGES WILL BE UNDONE THE NEXT TIME THE FILE IS GENERATED! 
 */

// The build configuration (e.g. debug/release)
[assembly: AssemblyConfiguration("${Configuration}")]

// The time the assembly was build
[assembly: AssemblyBuildTime(buildTime: "${Now}")]

// The version from which the assembly was build
[module: SuppressMessage(
    "Microsoft.Usage", 
    "CA2243:AttributeStringLiteralsShouldParseCorrectly", 
    Justification = "It's a VCS revision, not a version")]
[assembly: AssemblyBuildInformation(buildNumber: ${VersionBuild}, versionControlInformation: "${VcsRevision}")]