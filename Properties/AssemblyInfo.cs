﻿using System.Reflection;
using System.Runtime.InteropServices;
using System.Web;
using Sitefinity.Sample.LeadScoreCriteria;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Sitefinity.Sample.LeadScoreCriteria")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Sitefinity.Sample.LeadScoreCriteria")]
[assembly: AssemblyCopyright("Copyright ©  2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("dfe3a5b0-cfd2-4234-b46c-bdb7e473dd98")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("10.0.6402.0")]
[assembly: AssemblyFileVersion("10.0.6402.0")]


[assembly: PreApplicationStartMethod(typeof(Installer), "PreApplicationStart")]