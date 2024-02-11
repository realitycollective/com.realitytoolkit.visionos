﻿// Copyright (c) Reality Collective. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using RealityCollective.ServiceFramework.Editor;
using UnityEngine;

namespace RealityToolkit.VisionOS.Editor
{
    /// <summary>
    /// Dummy scriptable object used to find the relative path of the package.
    /// </summary>
    /// <inheritdoc cref="IPathFinder" />
    public class VisionOSPackagePathFinder : ScriptableObject, IPathFinder
    {
        /// <inheritdoc />
        public string Location => $"/Editor/{nameof(VisionOSPackagePathFinder)}.cs";
    }
}
