// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> WindowsProfile - Profile for Windows VMs in the container service cluster. </summary>
    public partial class WindowsProfile : WindowsProfileResponse
    {
        /// <summary> Initializes a new instance of WindowsProfile. </summary>
        public WindowsProfile()
        {
        }

        /// <summary> Initializes a new instance of WindowsProfile. </summary>
        /// <param name="adminUsername"> AdminUsername - Specifies the name of the administrator account. &lt;br&gt;&lt;br&gt; **restriction:** Cannot end in &quot;.&quot; &lt;br&gt;&lt;br&gt; **Disallowed values:** &quot;administrator&quot;, &quot;admin&quot;, &quot;user&quot;, &quot;user1&quot;, &quot;test&quot;, &quot;user2&quot;, &quot;test1&quot;, &quot;user3&quot;, &quot;admin1&quot;, &quot;1&quot;, &quot;123&quot;, &quot;a&quot;, &quot;actuser&quot;, &quot;adm&quot;, &quot;admin2&quot;, &quot;aspnet&quot;, &quot;backup&quot;, &quot;console&quot;, &quot;david&quot;, &quot;guest&quot;, &quot;john&quot;, &quot;owner&quot;, &quot;root&quot;, &quot;server&quot;, &quot;sql&quot;, &quot;support&quot;, &quot;support_388945a0&quot;, &quot;sys&quot;, &quot;test2&quot;, &quot;test3&quot;, &quot;user4&quot;, &quot;user5&quot;. &lt;br&gt;&lt;br&gt; **Minimum-length:** 1 character &lt;br&gt;&lt;br&gt; **Max-length:** 20 characters. </param>
        /// <param name="enableCsiProxy"> EnableCSIProxy - Whether to enable CSI proxy. </param>
        /// <param name="licenseType"> LicenseType - The licenseType to use for Windows VMs. Windows_Server is used to enable Azure Hybrid User Benefits for Windows VMs. Possible values include: &apos;None&apos;, &apos;Windows_Server&apos;. </param>
        /// <param name="adminPassword"> AdminPassword - Specifies the password of the administrator account. &lt;br&gt;&lt;br&gt; **Minimum-length:** 8 characters &lt;br&gt;&lt;br&gt; **Max-length:** 123 characters &lt;br&gt;&lt;br&gt; **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled &lt;br&gt; Has lower characters &lt;br&gt;Has upper characters &lt;br&gt; Has a digit &lt;br&gt; Has a special character (Regex match [\W_]) &lt;br&gt;&lt;br&gt; **Disallowed values:** &quot;abc@123&quot;, &quot;P@$$w0rd&quot;, &quot;P@ssw0rd&quot;, &quot;P@ssword123&quot;, &quot;Pa$$word&quot;, &quot;pass@word1&quot;, &quot;Password!&quot;, &quot;Password1&quot;, &quot;Password22&quot;, &quot;iloveyou!&quot;. </param>
        internal WindowsProfile(string adminUsername, bool? enableCsiProxy, LicenseType? licenseType, string adminPassword) : base(adminUsername, enableCsiProxy, licenseType)
        {
            AdminPassword = adminPassword;
        }

        /// <summary> AdminPassword - Specifies the password of the administrator account. &lt;br&gt;&lt;br&gt; **Minimum-length:** 8 characters &lt;br&gt;&lt;br&gt; **Max-length:** 123 characters &lt;br&gt;&lt;br&gt; **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled &lt;br&gt; Has lower characters &lt;br&gt;Has upper characters &lt;br&gt; Has a digit &lt;br&gt; Has a special character (Regex match [\W_]) &lt;br&gt;&lt;br&gt; **Disallowed values:** &quot;abc@123&quot;, &quot;P@$$w0rd&quot;, &quot;P@ssw0rd&quot;, &quot;P@ssword123&quot;, &quot;Pa$$word&quot;, &quot;pass@word1&quot;, &quot;Password!&quot;, &quot;Password1&quot;, &quot;Password22&quot;, &quot;iloveyou!&quot;. </summary>
        public string AdminPassword { get; set; }
    }
}
