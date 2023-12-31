using Fusion;
using UnityEngine;

namespace Fusion104
{
	public struct NetworkInputData : INetworkInput
	{
		public const byte MOUSEBUTTON1 = 0x01;
		public const byte MOUSEBUTTON2 = 0x02;
		public const byte JUMP = 0x04;
		public byte buttons;
		public Vector3 direction;
	}
}
