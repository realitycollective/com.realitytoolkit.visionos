// Copyright (c) Reality Collective. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using RealityCollective.ServiceFramework.Attributes;
using RealityToolkit.Player.Interfaces;
using RealityToolkit.Player.Modules;
using UnityEngine;

namespace RealityToolkit.VisionOS.Player
{
    /// <summary>
    /// <see cref="IPlayerRigServiceModule"/> used when running on the <see cref="VisionOSPlatform"/>.
    /// </summary>
    [RuntimePlatform(typeof(VisionOSPlatform))]
    [System.Runtime.InteropServices.Guid("4ed59a54-7d07-4abf-929a-2350d26be9e7")]
    public class VisionOSPlayerRigServiceModule : BasePlayerRigServiceModule, IVisionOSPlayerRigServiceModule
    {
        /// <inheritdoc />
        public VisionOSPlayerRigServiceModule(string name, uint priority, VisionOSPlayerRigServiceModuleProfile profile, IPlayerService parentService)
            : base(name, priority, profile, parentService) { }
    }
}