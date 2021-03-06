﻿using JSharp;

[assembly: JType(TargetType = typeof(System.Collections.Generic.IEnumerable<>), Name = "java.lang.Iterable")]
[assembly: JType(TargetType = typeof(System.Func<,>), Name = "system.Func1")]
[assembly: JType(TargetType = typeof(System.Func<,,>), Name = "system.Func2")]
[assembly: JType(TargetType = typeof(System.Func<,,,>), Name = "system.Func3")]
[assembly: JType(TargetType = typeof(System.Func<,,,,>), Name = "system.Func4")]
[assembly: JType(TargetType = typeof(System.Action<>), Name = "system.Action1")]
[assembly: JType(TargetType = typeof(System.Action<,>), Name = "system.Action2")]
[assembly: JType(TargetType = typeof(System.Action<,,>), Name = "system.Action3")]
[assembly: JType(TargetType = typeof(System.Action<,,,>), Name = "system.Action4")]
[assembly: JType(TargetType = typeof(System.Exception), Name = "java.lang.RuntimeException")]
[assembly: JType(TargetType = typeof(System.Object), Name = "java.lang.Object")]
[assembly: JProperty(TargetType = typeof(System.Array), TargetProperty = "Length", NativeField=true)]
[assembly: JMethod(TargetType = typeof(System.String), TargetMethod = "get_Length", Name="length")]
//[assembly: JMethod(TargetType = typeof(System.Collections.Generic.IEnumerable<>), TargetMethod="GetEnumerator", Name = "iterator")]
