using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace SageBinaryData;

[StructLayout(LayoutKind.Sequential, Size = 128)]
[MiscellaneousBits(65)]
[NativeCppClass]
[DebugInfoInPDB]
internal struct PillageModuleData
{
}