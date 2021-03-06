// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct VideoAncillary : IEquatable<VideoAncillary> {

		public byte DID;
		public byte SDIDBlockNumber;
		public byte DataCount;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=0)]
		public byte[] Data;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
		private IntPtr[] _gstGstReserved;

		public static Gst.Video.VideoAncillary Zero = new Gst.Video.VideoAncillary ();

		public static Gst.Video.VideoAncillary New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoAncillary.Zero;
			return (Gst.Video.VideoAncillary) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoAncillary));
		}

		public bool Equals (VideoAncillary other)
		{
			return true && DID.Equals (other.DID) && SDIDBlockNumber.Equals (other.SDIDBlockNumber) && DataCount.Equals (other.DataCount) && Data.Equals (other.Data);
		}

		public override bool Equals (object other)
		{
			return other is VideoAncillary && Equals ((VideoAncillary) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ DID.GetHashCode () ^ SDIDBlockNumber.GetHashCode () ^ DataCount.GetHashCode () ^ Data.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
