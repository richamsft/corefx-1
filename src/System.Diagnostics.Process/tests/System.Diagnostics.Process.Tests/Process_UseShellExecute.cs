// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using Xunit;

namespace Test_System_Diagnostics_Process
{
    public partial class ProcessTest
    {
        [Fact]
        public static void ProcessStartInfo_UseShellExecute()
        {
            ProcessStartInfo psi = new ProcessStartInfo();

            // Calling the setter
            try
            {
                psi.UseShellExecute = false;
            }
            catch (Exception)
            {
                Assert.True(false, "ProcessStartInfo_UseShellExecute001 failed");
            }

            //"ProcessStartInfo_UseShellExecute002 failed"
            Assert.Throws<PlatformNotSupportedException>(() => { psi.UseShellExecute = true; });

            // Calling the getter
            Assert.True(!psi.UseShellExecute, "ProcessStartInfo_UseShellExecute003 failed");
        }
    }
}