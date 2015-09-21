// <auto-generated />
namespace Microsoft.AspNet.Authentication.OpenIdConnectBearer
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNet.Authentication.OpenIdConnectBearer.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The '{0}' option must be provided.
        /// </summary>
        internal static string Exception_OptionMustBeProvided
        {
            get { return GetString("Exception_OptionMustBeProvided"); }
        }

        /// <summary>
        /// The '{0}' option must be provided.
        /// </summary>
        internal static string FormatException_OptionMustBeProvided(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Exception_OptionMustBeProvided"), p0);
        }

        /// <summary>
        /// An ICertificateValidator cannot be specified at the same time as an HttpMessageHandler unless it is a WebRequestHandler.
        /// </summary>
        internal static string Exception_ValidatorHandlerMismatch
        {
            get { return GetString("Exception_ValidatorHandlerMismatch"); }
        }

        /// <summary>
        /// An ICertificateValidator cannot be specified at the same time as an HttpMessageHandler unless it is a WebRequestHandler.
        /// </summary>
        internal static string FormatException_ValidatorHandlerMismatch()
        {
            return GetString("Exception_ValidatorHandlerMismatch");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
