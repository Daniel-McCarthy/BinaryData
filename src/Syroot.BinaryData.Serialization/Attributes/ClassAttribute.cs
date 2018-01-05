using System;

namespace Syroot.BinaryData
{
    /// <summary>
    /// Configures a class or struct for reading and writing it through binary serialization.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class ClassAttribute : Attribute
    {
        // ---- PROPERTIES ---------------------------------------------------------------------------------------------

        /// <summary>
        /// Gets or sets a value indicating whether inherited members are read and written first. Defaults to
        /// <c>false</c>.
        /// </summary>
        public bool Inherit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether public members are not automatically read and written. Defaults to
        /// <c>false</c>.
        /// </summary>
        public bool Explicit { get; set; }
    }
}