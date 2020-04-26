namespace Nasa.Open.Api.Attributes
{
    using System;

    /// <summary>
    /// Service BaseAddress eg : "planetary/apod"
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    internal class EndPointAttribute: Attribute
    {
        public string Path { get; }
        public string BaseAddress { get; }

        public EndPointAttribute(string baseAddress, string path)
        {
            Path = path;
            BaseAddress = baseAddress;
        }
    }
}
