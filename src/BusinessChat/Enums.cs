using ObjCRuntime;
using Foundation;

namespace BusinessChat {

	[iOS (11, 3)]
	[Native]
	public enum BCChatButtonStyle : long {
		Light = 0,
		Dark,
	}

	[iOS (11, 3)]
	public enum BCParameterName {

		[Field ("BCParameterNameIntent")]
		Intent,

		[Field ("BCParameterNameGroup")]
		Group,

		[Field ("BCParameterNameBody")]
		Body,
	}
}
