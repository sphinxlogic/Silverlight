﻿// (c) Copyright Microsoft Corporation.
// This source is subject to [###LICENSE_NAME###].
// Please see [###LICENSE_LINK###] for details.
// All other rights reserved.

using System;

namespace Microsoft.Phone.Testing.Harness
{
  /// <summary>
  /// Well-known keys that can be used to mark decorator instances in log 
  /// message objects.
  /// </summary>
  public enum LogDecorator
  {
    /// <summary>
    /// Key for a decorator that is a simple Exception object.
    /// </summary>
    ExceptionObject,

    /// <summary>
    /// Key for a decorator that is a simple Name string property.
    /// </summary>
    NameProperty,

    /// <summary>
    /// An associated TestOutcome value.
    /// </summary>
    TestOutcome,

    /// <summary>
    /// The stage of a message or event.
    /// </summary>
    TestStage,

    /// <summary>
    /// The granularity of a message or event.
    /// </summary>
    TestGranularity,
  }
}
