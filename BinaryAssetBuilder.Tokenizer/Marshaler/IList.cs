using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace Marshaler;

[StructLayout(LayoutKind.Sequential, Size = 4)]
[MiscellaneousBits(64)]
[DebugInfoInPDB]
[NativeCppClass]
internal static struct IList
{
}
