using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MscrmTools.TimelineConfigurationReplicator
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Timeline Configuration Replicator"),
        ExportMetadata("Description", "Replicate the configuration of a timeline control to another timeline controls"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAMAAABEpIrGAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAGVUExURWBgYGNfX39TV707RYBTVnZXWb86ReYrOu0pOecrOsE5RHZWWVJYaUZSc1VaZ2ddXtYxPg0tkgAjlQ8sjltdY2lcXdowPvBPXPBOWz5LdyxBgztKd15eYfN1f/NyfE9Vaj5Kc0FMcQ4ukgEklUBMc2FgYJZKUNovPeAuPJdJTzhGdis+fS5AfFZaZmxbXJ5GTek2ROgxQKxCSnVXWt7X19vJy3lVWOZveOVtdnpVWHxVWOkqOr46RXtVWFBWaVNYaGhdXtQzQNMzQBAvkREujFpcY/FQXfFPXDZGeCU8gzlId19fYPWBivR4gVRZZ0tUblBWa0FNcqZETOUsOuUrOqRFTTpJeRozhxgyiCM5g3JYWqxBSes6SOs5R61BSeDLzdzHyX5UV+Nye+Jlb3NYWuUsO1dbZdUyP9QyPw8tjvBMWfBMWjZGefR6hPR5g2hcXkVLbzxBdT9Gc1xcY1xTZAQlkwEjlT9DdKFFTOMtO+MsO6JFTF9eYTI6eyUzgyc1gk1SanhWWbE/SOgqObM/SHlWWW5aXGStVpEAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAFMSURBVDhPvdJVU8NAFAXghCAXbZEWdxZ3hyLF3b1oocXd3Qr93bB776aTIfSJ4XvKzrnZydms8jfUEE0LVWlhIiw8AiAyKlqJiTWKw9xiBcFqiU8wSkwSAzY7QHIKgN2WmmaUnqEPZGbxgewclItvSnyAs9vyaOv8AooQKyzieXEJKy1D5RUUSZVV1TW1dYxWpuob6MEca2xqbvl9A9aqOQAcbe2sg1pInTjg7BIloNvZQy2k3j4xwGv2D/Cag0NGwyP6wOgYHxifQJMYSIGD0v/FFEVInZ7h+eycOr+wKCzR1+lcyyuray5amGLrG0HPUXVvbrmD3CiP5gXwah5FtpC2MbfsiBKw++NG7QVu1P4BrylbSIeBG3V0/D1wcnqGzi9EIOkHdXlFW1/fUITY7R3P7x8en57RyytFhL29+3wfn0FPwu+nh/+nKF9B/1BKk9x2LwAAAABJRU5ErkJggg=="),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "iVBORw0KGgoAAAANSUhEUgAAAFAAAABQCAMAAAC5zwKfAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAFEUExURWBgYG5aXI9NUswxPO0pOc8wO8kzPdQvOlVZZjRFeyE8jSA8kChAh+MpN+EqNixCgwAjlQQnlxI0mjtIdCM9jPFCTg4xnA0wnRQ1mTZFefivtfva3fius+4vPv////nAxPeVnPehp1NYZwcpmBg1jxk4lDhHdzVGesoyPAosl55FS+IpNqdCSs5rcvA4Rc9dZq+vr/3r7a2WmKWlpcd5gPeVm/RQWfeTmsJzero6Qr04QqxASKFFTQ8wlQQnmC9DgB06kTFEfvJJVfikqvNXYi5DgTVFeu4uPPJIVPijqfNVXzpIdDNFfB46kTlHdaBGTRk4lQIllwMnlypBhdRcZO4sO9ZOWNssONgtOQkrl+4wPjBDf/emrfiqsFNYZjk/djUxeyw4fQ8ljl9RYzhGdTQwfDEufxYnizUwfC4sgi0sgjEugC6HqmMAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAJoSURBVFhH7ZhZVxQxEEY7MaONG+qggiMz7oqgggruuIK74IK7Myru/v93U83XZLqzdAbqgeOZ+9L10HUPSXVVmCR9Nj5CSikQMyDkJqVUjUsp5GatI7ZwKI2OWL9S0GK7qZExHdi6LYbt6YrFIHbAY9ipjYO7ItldNkpYupFJsgfvV1OHKMcjHMLr1fiFe/HMhOnQvv0xDI94l3ygcRARCddOLhxtNFsIeYTqUOswokyY1h1Y34gDT1GOHMWeFzgWYfQIj0NR4gSyAniEwzCUOImsAKIGi+GU7pQRGIqMxWyiOD0OEZjIehllKBLj0xSUEywzcVXJoyPEmbNKnWPTaSanWq3ziFmYbDabFxCzwC0UF6dnLl1m20Ihr2RFvspTlVxHMCi7dQSU7laxsHtHXIPIcF0b0xto3wpmb5aVnmlzCwnVRJ567MfobbxeiTXRVoV37t5DRMK0PjcYw7xVlVx4f4r51GMXqgcPHyHKlvzYseQnMRO7p6JY/2o58Ag9n80AsgJ4hE9hKPEMWQEcrbdArbf4HI4uXryM2UTPcHBNhxgdwTy+COYBSzAfAZoNf+pxH/RCvlpS6jVXTcx3w1Lm4pe9fqUoNopWktE5vhzYE1u8gcfwVhujz5R3ZWNv48tB5KnnGV8O/ML3eGZC5/hyMPvBu+SPjU+ISOgcXw7siZYL9Y/HBsIV4Vrx/IXtzmebThtJIcwejuJJwvYX7FGRr8vICmCEBpl8g6HMd2QF6E34A1kBHNcs4yJp/4ShRAdZIdwXQcu/fv+x+BtVFT1teK+qNMyXaQTzdR/BfCHZp89/QZL8A2uahrDPPiWIAAAAAElFTkSuQmCC"),
        ExportMetadata("BackgroundColor", "#606060"),
        ExportMetadata("PrimaryFontColor", "White"),
        ExportMetadata("SecondaryFontColor", "White")]
    public class MyPlugin : PluginBase, IPayPalPlugin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MyPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        public string DonationDescription => "Donation for Timeline Configuration Replicator";

        public string EmailAccount => "tanguy92@hotmail.com";

        public override IXrmToolBoxPluginControl GetControl()
        {
            return new MyPluginControl();
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}