// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

// Original file: https://github.com/IdentityServer/IdentityServer4.Quickstart.UI
// Modified by Jan �koruba

using IdServe.STS.Identity.Quickstart.Consent;

namespace IdServe.STS.Identity.Quickstart.Device
{
    public class DeviceAuthorizationInputModel : ConsentInputModel
    {
        public string UserCode { get; set; }
    }
}