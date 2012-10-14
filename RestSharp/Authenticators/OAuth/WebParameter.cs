#if !Smartphone && !WindowsCE
using System;
using System.Diagnostics;

#endif

namespace RestSharp.Authenticators.OAuth
{
#if !Smartphone && !WindowsCE
	[DebuggerDisplay("{Name}:{Value}")]
#endif
#if !SILVERLIGHT && !WINDOWS_PHONE && !WindowsCE
	[Serializable]
#endif
    internal class WebParameter : WebPair
	{
		public WebParameter(string name, string value) : base(name, value)
		{
		}
	}
}