﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA1014:MarkAssembliesWithClsCompliant", Justification = "The Silverlight presentation APIs are not CLS Compliant.")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Harness.AssemblyManager.#FilterByFilterClassParameter(System.Collections.Generic.List`1<Microsoft.Silverlight.Testing.UnitTesting.Harness.ITestClass>&)", Justification = "ToUpperInvariant doesn't existing in the Silverlight BCL")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1307:SpecifyStringComparison", MessageId = "System.String.IndexOf(System.String)", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Harness.AssemblyManager.#FilterByFilterClassParameter(System.Collections.Generic.List`1<Microsoft.Silverlight.Testing.UnitTesting.Harness.ITestClass>&)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Harness.LazyMethodInfo.#MethodInfo")]
[assembly: SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Harness.TestClassHelper.#FilterExclusiveClasses(System.Collections.Generic.List`1<Microsoft.Silverlight.Testing.UnitTesting.Metadata.ITestClass>&,Microsoft.Silverlight.Testing.Harness.LogMessageWriter)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Harness.TestClassHelper.#FilterTestsToRun(System.Collections.Generic.List`1<Microsoft.Silverlight.Testing.UnitTesting.Metadata.ITestClass>&,System.Collections.Generic.ICollection`1<System.String>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Harness.TestMethodHelper.#FilterExclusiveMethods(System.Collections.Generic.List`1<Microsoft.Silverlight.Testing.UnitTesting.Metadata.ITestMethod>&,Microsoft.Silverlight.Testing.Harness.LogMessageWriter)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Harness.TestRunFilter.#FilterTestClasses(System.Collections.Generic.List`1<Microsoft.Silverlight.Testing.UnitTesting.Metadata.ITestClass>&)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Harness.TestRunFilter.#FilterTestMethods(System.Collections.Generic.List`1<Microsoft.Silverlight.Testing.UnitTesting.Metadata.ITestMethod>&)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Harness.TestRunFilter.#SortTestClasses(System.Collections.Generic.List`1<Microsoft.Silverlight.Testing.UnitTesting.Metadata.ITestClass>&)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Harness.TestRunFilter.#SortTestMethods(System.Collections.Generic.List`1<Microsoft.Silverlight.Testing.UnitTesting.Metadata.ITestMethod>&)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Metadata.VisualStudio.ProviderAttributes.#TimeoutAttribute")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.UI.MethodFailure+Details.#AddBugAction(Microsoft.Silverlight.Testing.Html.HtmlControl)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.UI.MethodFailure+Details.#AddCopyAction(Microsoft.Silverlight.Testing.Html.HtmlControl)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1014:MarkAssembliesWithClsCompliant", Justification = "The Silverlight presentation APIs are not CLS Compliant.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Silverlight.Testing.UI", Justification = "This namespace is intended for use by richer harness implementations and should be kept available.")]
[assembly: SuppressMessage("General", "SWC1001:XmlDocumentationCommentShouldBeSpelledCorrectly", MessageId = "#eee")]
[assembly: SuppressMessage("General", "SWC1001:XmlDocumentationCommentShouldBeSpelledCorrectly", MessageId = "Bidi")]
[assembly: SuppressMessage("General", "SWC1001:XmlDocumentationCommentShouldBeSpelledCorrectly", MessageId = "#ddd")]
[assembly: SuppressMessage("General", "SWC1001:XmlDocumentationCommentShouldBeSpelledCorrectly", MessageId = "Zindex")]
[assembly: SuppressMessage("General", "SWC1001:XmlDocumentationCommentShouldBeSpelledCorrectly", MessageId = "br")]
[assembly: SuppressMessage("General", "SWC1001:XmlDocumentationCommentShouldBeSpelledCorrectly", MessageId = "coords")]
[assembly: SuppressMessage("General", "SWC1001:XmlDocumentationCommentShouldBeSpelledCorrectly", MessageId = "classid")]
[assembly: SuppressMessage("General", "SWC1001:XmlDocumentationCommentShouldBeSpelledCorrectly", MessageId = "fieldset")]
[assembly: SuppressMessage("General", "SWC1001:XmlDocumentationCommentShouldBeSpelledCorrectly", MessageId = "fieldset's")]
[assembly: SuppressMessage("General", "SWC1001:XmlDocumentationCommentShouldBeSpelledCorrectly", MessageId = "noframe")]
[assembly: SuppressMessage("General", "SWC1001:XmlDocumentationCommentShouldBeSpelledCorrectly", MessageId = "noscript")]
[assembly: SuppressMessage("General", "SWC1001:XmlDocumentationCommentShouldBeSpelledCorrectly", MessageId = "Runnable")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Silverlight.Testing.Service.WebTestService+RequestData.#RequestUri", Justification = "Provided for extensibility and future use.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Harness.UnitTestHarness.#Results")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Harness.VisualStudioLogProvider+Writer.#AddPendingWriteLine(System.String)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Silverlight.Testing.UnitTesting.Harness.VisualStudioLogProvider+Writer.#IncrementResults(Microsoft.Silverlight.Testing.Harness.TestOutcome)")]
[assembly: SuppressMessage("Microsoft.Maintainability", "CA1501:AvoidExcessiveInheritance", Scope = "type", Target = "Microsoft.Silverlight.Testing.UnitTesting.UI.ResultInspector+ExceptionDetails")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.VisualStudio.TestTools.UnitTesting")]