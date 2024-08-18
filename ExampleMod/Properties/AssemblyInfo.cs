using MelonLoader;
using System.Reflection;
using BI = ExampleMod.BuildInfo;
using ModClass = ExampleMod.ExampleMod;

// Don't modify these if you don't know what you're doing! See BuildInfo below...

[assembly: AssemblyTitle(BI.Title)]
[assembly: AssemblyProduct(BI.Title)]
[assembly: AssemblyDescription(BI.Description)]

[assembly: AssemblyVersion(BI.Version)]
[assembly: AssemblyFileVersion(BI.Version)]

[assembly: MelonInfo(typeof(ModClass), name: BI.Title, version: BI.Version, author: BI.Author)]
[assembly: MelonGame("Kyle Banks", "Farewell North")]

namespace ExampleMod
{
    /// <summary>
    /// Custom attributes for your mod - modify these to change how your mod appears on the title screen
    /// </summary>
    public class BuildInfo
    {
        public const string Title = "ExampleMod";
        public const string Description = "A short description";
        public const string Version = "0.0.1"; // Must follow Semantic Version v2; Major.Minor.Revision(.Patch)
        public const string Author = "";
    }
}
