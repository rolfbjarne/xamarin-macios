// Copyright 2014-2015 Xamarin Inc. All rights reserved.
// Copyright 2019 Microsoft Corporation

#if IOS && !__MACCATALYST__
using AccessorySetupKit;
#else
using ASAccessory = Foundation.NSObject;
#endif
using CoreFoundation;
using Security;
using Network;
using OS_nw_parameters = System.IntPtr;
using OS_nw_interface = System.IntPtr;

#if MONOMAC || TVOS
using NEHotspotHelperOptions = Foundation.NSObject;
#endif

#if MONOMAC
using NEHotspotHelperResult = Foundation.NSObject;
using NEHotspotHelperCommandType = Foundation.NSObject;
using NEHotspotHelperConfidence = Foundation.NSObject;
#endif

namespace NetworkExtension {
	/// <summary>Enumerates errors relating to a DNS proxy.</summary>
	[NoTV]
	[ErrorDomain ("NEDNSProxyErrorDomain")]
	[MacCatalyst (13, 1)]
	[Native]
	enum NEDnsProxyManagerError : long {
		/// <summary>The configuration is invalid.</summary>
		Invalid = 1,
		/// <summary>The configuration is disabled.</summary>
		Disabled = 2,
		/// <summary>The configuration is stale.</summary>
		Stale = 3,
		/// <summary>The configuration cannot be removed.</summary>
		CannotBeRemoved = 4,
	}

	/// <summary>Enumerates the actions to be taken when a <see cref="NetworkExtension.NEFilterVerdict" /> is that a report should be made.</summary>
	[NoTV]
	[MacCatalyst (13, 1)]
	[Native]
	enum NEFilterAction : long {
		/// <summary>The configuration is invalid.</summary>
		Invalid = 0,
		/// <summary>Allow the traffic.</summary>
		Allow = 1,
		/// <summary>Drop the traffic.</summary>
		Drop = 2,
		/// <summary>Remediate the traffic.</summary>
		Remediate = 3,
		/// <summary>Filter the data.</summary>
		FilterData = 4,
	}

	[MacCatalyst (13, 1)]
	[Native]
	enum NEVpnIkev2TlsVersion : long {
		/// <summary>The default TLS version.</summary>
		Default = 0,
		/// <summary>TLS version 1.0.</summary>
		Tls1_0 = 1,
		/// <summary>TLS version 1.1.</summary>
		Tls1_1 = 2,
		/// <summary>TLS version 1.2.</summary>
		Tls1_2 = 3,
	}

	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[Native]
	enum NEHotspotConfigurationEapType : long {
		/// <summary>EAP-TLS authentication.</summary>
		Tls = 13,
		/// <summary>EAP-TTLS authentication.</summary>
		Ttls = 21,
		/// <summary>PEAP authentication.</summary>
		Peap = 25,
		/// <summary>EAP-FAST authentication.</summary>
		Fast = 43,
	}

	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[Native]
	enum NEHotspotConfigurationTtlsInnerAuthenticationType : long {
		/// <summary>PAP inner authentication.</summary>
		Pap = 0,
		/// <summary>CHAP inner authentication.</summary>
		Chap = 1,
		/// <summary>MS-CHAP inner authentication.</summary>
		MSChap = 2,
		/// <summary>MS-CHAPv2 inner authentication.</summary>
		MSChapv2 = 3,
		/// <summary>EAP inner authentication.</summary>
		Eap = 4,
	}

	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[Native]
	enum NEHotspotConfigurationEapTlsVersion : long {
		/// <summary>TLS version 1.0.</summary>
		Tls1_0 = 0,
		/// <summary>TLS version 1.1.</summary>
		Tls1_1 = 1,
		/// <summary>TLS version 1.2.</summary>
		Tls1_2 = 2,
	}

	/// <summary>Enumerates errors relating to network hostpot configuration.</summary>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[Native]
	[ErrorDomain ("NEHotspotConfigurationErrorDomain")]
	public enum NEHotspotConfigurationError : long {
		/// <summary>The configuration is invalid.</summary>
		Invalid = 0,
		/// <summary>The SSID is invalid.</summary>
		InvalidSsid = 1,
		/// <summary>The WPA passphrase is invalid.</summary>
		InvalidWpaPassphrase = 2,
		/// <summary>The WEP passphrase is invalid.</summary>
		InvalidWepPassphrase = 3,
		/// <summary>The EAP settings are invalid.</summary>
		InvalidEapSettings = 4,
		/// <summary>The Hotspot 2.0 settings are invalid.</summary>
		InvalidHS20Settings = 5,
		/// <summary>The Hotspot 2.0 domain name is invalid.</summary>
		InvalidHS20DomainName = 6,
		/// <summary>The user denied the request.</summary>
		UserDenied = 7,
		/// <summary>An internal error occurred.</summary>
		Internal = 8,
		/// <summary>The operation is pending.</summary>
		Pending = 9,
		/// <summary>A system configuration error occurred.</summary>
		SystemConfiguration = 10,
		/// <summary>An unknown error occurred.</summary>
		Unknown = 11,
		/// <summary>Join-once is not supported.</summary>
		JoinOnceNotSupported = 12,
		/// <summary>Already associated with the network.</summary>
		AlreadyAssociated = 13,
		/// <summary>The application is not in the foreground.</summary>
		ApplicationIsNotInForeground = 14,
		InvalidSsidPrefix = 15,
		UserUnauthorized = 16,
		SystemDenied = 17,
	}

	[NoTV]
	[NoiOS]
	[NoMacCatalyst]
	[Native]
	enum NEFilterManagerGrade : long {
		Firewall = 1,
		Inspector = 2,
	}

	[NoTV]
	[iOS (13, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	enum NETrafficDirection : long {
		Any = 0,
		Inbound = 1,
		Outbound = 2,
	}

	[NoTV]
	[NoiOS]
	[NoMacCatalyst]
	[Native]
	enum NENetworkRuleProtocol : long {
		Any = 0,
		Tcp = 1,
		Udp = 2,
	}

	[NoTV]
	[NoiOS]
	[NoMacCatalyst]
	[Native]
	enum NEFilterPacketProviderVerdict : long {
		Allow = 0,
		Drop = 1,
		Delay = 2,
	}

	[NoTV]
	[iOS (13, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	enum NEFilterReportEvent : long {
		NewFlow = 1,
		DataDecision = 2,
		FlowClosed = 3,
		[NoiOS]
		[NoMacCatalyst]
		Statistics = 4,
	}

	[NoTV, NoiOS, NoMacCatalyst]
	[Native]
	enum NEFilterReportFrequency : long {
		None,
		Low,
		Medium,
		High,
	}

	[NoTV, NoiOS, NoMacCatalyst]
	[Native]
	public enum NEFilterDataAttribute : long {
		HasIpHeader = 1,
	}

	[NoTV, NoMac, iOS (15, 0), MacCatalyst (15, 0)]
	[Native]
	enum NEHotspotNetworkSecurityType : long {
		Open = 0,
		Wep = 1,
		Personal = 2,
		Enterprise = 3,
		Unknown = 4,
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0), TV (17, 0)]
	[Native]
	[ErrorDomain ("NEVPNConnectionErrorDomain")]
	public enum NEVpnConnectionError : long {
		Overslept = 1,
		NoNetworkAvailable = 2,
		UnrecoverableNetworkChange = 3,
		ConfigurationFailed = 4,
		ServerAddressResolutionFailed = 5,
		ServerNotResponding = 6,
		ServerDead = 7,
		AuthenticationFailed = 8,
		ClientCertificateInvalid = 9,
		ClientCertificateNotYetValid = 10,
		ClientCertificateExpired = 11,
		PluginFailed = 12,
		ConfigurationNotFound = 13,
		PluginDisabled = 14,
		NegotiationFailed = 15,
		ServerDisconnected = 16,
		ServerCertificateInvalid = 17,
		ServerCertificateNotYetValid = 18,
		ServerCertificateExpired = 19,
	}

	delegate void NEAppProxyFlowOpenCallback ([NullAllowed] NSError completionHandler);

	/// <summary>Provides IO over a network socket.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEAppProxyFlowClassRef/index.html">Apple documentation for <c>NEAppProxyFlow</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Abstract] // documented as such and ...
	[DisableDefaultCtor] // can't be created (with `init`) without crashing introspection tests
	interface NEAppProxyFlow {
		/// <param name="localEndpoint">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Opens the flow.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'OpenWithLocalFlowEndpoint' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'OpenWithLocalFlowEndpoint' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'OpenWithLocalFlowEndpoint' instead.")]
		[Export ("openWithLocalEndpoint:completionHandler:")]
		[Async (XmlDocs = """
			<param name="localEndpoint">The local endpoint.</param>
			<summary>Opens the flow.</summary>
			<returns>A task that represents the asynchronous OpenWithLocalEndpoint operation</returns>
			<remarks>
			          <para copied="true">The OpenWithLocalEndpointAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void OpenWithLocalEndpoint ([NullAllowed] NWHostEndpoint localEndpoint, Action<NSError> completionHandler);

		/// <param name="error">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Closes the flow for reading.</summary>
		[Export ("closeReadWithError:")]
		void CloseRead ([NullAllowed] NSError error);

		/// <param name="error">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Closes the flow for writing.</summary>
		[Export ("closeWriteWithError:")]
		void CloseWrite ([NullAllowed] NSError error);

		[Internal]
		[NoTV, NoiOS, MacCatalyst (15, 0)]
		[Export ("setMetadata:")]
		void SetMetadata (OS_nw_parameters nwparameters);

		/// <summary>Gets the flow metadata.</summary>
		[Export ("metaData")]
		NEFlowMetaData MetaData { get; }

		[Internal]
		[NoTV, iOS (13, 4)]
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("networkInterface", ArgumentSemantic.Copy)]
		OS_nw_interface WeakNetworkInterface { get; set; }

		[NoTV, iOS (13, 4)]
		[MacCatalyst (13, 1)]
		NWInterface NetworkInterface {
			[Wrap ("Runtime.GetINativeObject<NWInterface> (WeakNetworkInterface, false)!")]
			get;
			[Wrap ("WeakNetworkInterface = Runtime.RetainAndAutoreleaseNativeObject (value)")]
			set;
		}

		[iOS (14, 2)]
		[MacCatalyst (14, 2)]
		[Export ("remoteHostname")]
		[NullAllowed]
		string RemoteHostname { get; }

		[iOS (14, 3)]
		[MacCatalyst (14, 3)]
		[Export ("isBound")]
		bool IsBound { get; }

		[Async]
		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("openWithLocalFlowEndpoint:completionHandler:")]
		void OpenWithLocalFlowEndpoint ([NullAllowed] Network.NWEndpoint localEndpoint, NEAppProxyFlowOpenCallback completionHandler);
	}

	/// <summary>Provides sockets by creating <see cref="NetworkExtension.NEAppProxyFlow" /> objects.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEAppProxyProviderClassRef/index.html">Apple documentation for <c>NEAppProxyProvider</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NETunnelProvider))]
	[DisableDefaultCtor] // no valid handle when `init` is called
	interface NEAppProxyProvider {
		/// <param name="options">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Starts the proxy with the specified <paramref name="options" /> and runs <paramref name="completionHandler" /> after the operation is complete.</summary>
		[Export ("startProxyWithOptions:completionHandler:")]
		[Async (XmlDocs = """
			<param name="options">The options dictionary.</param>
			<summary>Asynchronously starts the proxy with the specified <paramref name="options" />.</summary>
			<returns>A task that represents the asynchronous StartProxy operation</returns>
			""")]
		void StartProxy ([NullAllowed] NSDictionary<NSString, NSObject> options, Action<NSError> completionHandler);

		/// <param name="reason">The reason for the failure.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Stops the proxy with the specified <paramref name="reason" /> and runs <paramref name="completionHandler" /> when the operation is complete.</summary>
		[Export ("stopProxyWithReason:completionHandler:")]
		[Async (XmlDocs = """
			<param name="reason">The reason for the failure.</param>
			<summary>Stops the proxy with the specified <paramref name="reason" /> and returns when the operation is complete.</summary>
			<returns>A task that represents the asynchronous StopProxy operation</returns>
			<remarks>
			          <para copied="true">The StopProxyAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void StopProxy (NEProviderStopReason reason, Action completionHandler);

		/// <param name="error">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Cancels the proxy witht the specified error.</summary>
		[Export ("cancelProxyWithError:")]
		void CancelProxy ([NullAllowed] NSError error);

		/// <param name="flow">The network flow.</param>
		///         <summary>Handles the provided proxy <paramref name="flow" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("handleNewFlow:")]
		bool HandleNewFlow (NEAppProxyFlow flow);

		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("handleNewUDPFlow:initialRemoteEndpoint:")]
		[Deprecated (PlatformName.iOS, 18, 0, message: "Call 'HandleNewUdpFlowWithInitialFlowEndPoint' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Call 'HandleNewUdpFlowWithInitialFlowEndPoint' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Call 'HandleNewUdpFlowWithInitialFlowEndPoint' instead.")]
		bool HandleNewUdpFlow (NEAppProxyUdpFlow flow, NWEndpoint remoteEndpoint);

		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("handleNewUDPFlow:initialRemoteFlowEndpoint:")]
		bool HandleNewUdpFlowWithInitialFlowEndPoint (NEAppProxyUdpFlow flow, Network.NWEndpoint remoteEndpoint);
	}

	/// <summary>Configures and controls network tunnels received from an App Proxy Provider extension.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEAppProxyProviderManagerClassRef/index.html">Apple documentation for <c>NEAppProxyProviderManager</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NETunnelProviderManager))]
	[DisableDefaultCtor] // no valid handle when `init` is called
	interface NEAppProxyProviderManager {
		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Loads all proxy configurations for the app that were previously saved in the Network Extensions prefrences and runs <paramref name="completionHandler" /> when the operation is complete.</summary>
		[Static]
		[Export ("loadAllFromPreferencesWithCompletionHandler:")]
		[Async (XmlDocs = """
			<summary>Asynchronously loads all proxy configurations for the app that were previously saved in the Network Extensions preferences.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadAllFromPreferences operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSArray,Foundation.NSError&gt;.</para>
			        </returns>
			<remarks>
			          <para copied="true">The LoadAllFromPreferencesAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void LoadAllFromPreferences (Action<NSArray, NSError> completionHandler);
	}

	/// <summary>Provides IO over a TCP socket.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEAppProxyTCPFlowClassRef/index.html">Apple documentation for <c>NEAppProxyTCPFlow</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEAppProxyFlow), Name = "NEAppProxyTCPFlow")]
	[DisableDefaultCtor]
	interface NEAppProxyTcpFlow {
		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Reads data from the flow and runs <paramref name="completionHandler" /> when the operation is complete.</summary>
		[Export ("readDataWithCompletionHandler:")]
		[Async (XmlDocs = """
			<summary>Reads data from the flow and returns when the operation is complete.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous ReadData operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSData,Foundation.NSError&gt;.</para>
			        </returns>
			""")]
		void ReadData (Action<NSData, NSError> completionHandler);

		/// <param name="data">The data.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Writes the provided <paramref name="data" /> to the flow and runs <paramref name="completionHandler" /> when the operation is complete.</summary>
		[Export ("writeData:withCompletionHandler:")]
		[Async (XmlDocs = """
			<param name="data">The data.</param>
			<summary>Writes the provided <paramref name="data" /> to the flow and returns when the operation is complete.</summary>
			<returns>A task that represents the asynchronous WriteData operation</returns>
			<remarks>
			          <para copied="true">The WriteDataAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void WriteData (NSData data, Action<NSError> completionHandler);

		/// <summary>Gets a description of the remote endpoint.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Call 'RemoveFlowEndpoint' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Call 'RemoveFlowEndpoint' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Call 'RemoveFlowEndpoint' instead.")]
		[Export ("remoteEndpoint")]
		NWEndpoint RemoteEndpoint { get; }

		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("remoteFlowEndpoint")]
		Network.NWEndpoint RemoteFlowEndpoint { get; }
	}

	delegate void NEDatagramRead ([NullAllowed] NSData [] datagrams, [NullAllowed] NWEndpoint [] remoteEndpoints, [NullAllowed] NSError error);
	delegate void NEDatagramAndFlowEndpointsRead ([NullAllowed] NSData [] datagrams, [NullAllowed] Network.NWEndpoint [] remoteEndpoints, [NullAllowed] NSError error);
	delegate void NEDatagramWriteResult ([NullAllowed] NSError error);
	/// <summary>Provides IO over a UDP socket.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEAppProxyUDPFlowClassRef/index.html">Apple documentation for <c>NEAppProxyUDPFlow</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEAppProxyFlow), Name = "NEAppProxyUDPFlow")]
	[DisableDefaultCtor]
	interface NEAppProxyUdpFlow {
		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Reads datagrams from the flow and runs <paramref name="completionHandler" /> when the operation is complete.</summary>
		[Export ("readDatagramsWithCompletionHandler:")]
		[Async (ResultTypeName = "NEDatagramReadResult", XmlDocs = """
			<summary>Reads datagrams from the flow and runs the datagrams when the operation is complete.</summary>
			<returns>
			          <para>A task that represents the asynchronous ReadDatagrams operation.   The value of the TResult parameter is of type <c>Action&lt;NetworkExtension.NEDatagramReadResult&gt;</c>.</para>
			        </returns>
			""")]
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'ReadDatagramsAndFlowEndpoints' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'ReadDatagramsAndFlowEndpoints' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'ReadDatagramsAndFlowEndpoints' instead.")]
		void ReadDatagrams (NEDatagramRead completionHandler);

		/// <param name="datagrams">The array of datagrams to send.</param>
		///         <param name="remoteEndpoints">The remote endpoints for the datagrams.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Writes the provided <paramref name="datagrams" /> to the specified <paramref name="remoteEndpoints" /> and runs <paramref name="completionHandler" /> when the operation is complete.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'WriteDatagramsAndFlowEndpoints' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'WriteDatagramsAndFlowEndpoints' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'WriteDatagramsAndFlowEndpoints' instead.")]
		[Export ("writeDatagrams:sentByEndpoints:completionHandler:")]
		[Async (XmlDocs = """
			<param name="datagrams">The array of datagrams to send.</param>
			<param name="remoteEndpoints">The remote endpoints for the datagrams.</param>
			<summary>Asynchronously writes the provided <paramref name="datagrams" /> to the specified <paramref name="remoteEndpoints" /> and returns when the operation is complete.</summary>
			<returns>A task that represents the asynchronous WriteDatagrams operation</returns>
			<remarks>
			          <para copied="true">The WriteDatagramsAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void WriteDatagrams (NSData [] datagrams, NWEndpoint [] remoteEndpoints, Action<NSError> completionHandler);

		/// <summary>Gets a description of the local endpoint.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'LocalFlowEndpoint' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'LocalFlowEndpoint' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'LocalFlowEndpoint' instead.")]
		[NullAllowed, Export ("localEndpoint")]
		NWEndpoint LocalEndpoint { get; }

		[Async (ResultTypeName = "NEDatagramAndFlowEndpointsReadResult")]
		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("readDatagramsAndFlowEndpointsWithCompletionHandler:")]
		void ReadDatagramsAndFlowEndpoints (NEDatagramAndFlowEndpointsRead completionHandler);

		[Async]
		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("writeDatagrams:sentByFlowEndpoints:completionHandler:")]
		void WriteDatagramsAndFlowEndpoints (NSData [] datagrams, Network.NWEndpoint [] flowEndpoints, NEDatagramWriteResult completionHandler);

		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("localFlowEndpoint"), NullAllowed]
		Network.NWEndpoint LocalFlowEndpoint { get; }
	}

	/// <summary>Defines a rule that select network connections based on application signing identifier, application path, and/or hostname domain.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEAppRuleClassRef/index.html">Apple documentation for <c>NEAppRule</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NEAppRule : NSSecureCoding, NSCopying {
		/// <param name="signingIdentifier">The signing identifier.</param>
		/// <summary>Creates a new app rule with the provided signing identifier.</summary>
		[MacCatalyst (13, 1)]
		[NoMac]
		[Export ("initWithSigningIdentifier:")]
		NativeHandle Constructor (string signingIdentifier);

		/// <param name="signingIdentifier">The signing identifier.</param>
		/// <param name="designatedRequirement">The designated requirement string.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[NoiOS, NoMacCatalyst]
		[Export ("initWithSigningIdentifier:designatedRequirement:")]
		NativeHandle Constructor (string signingIdentifier, string designatedRequirement);

		/// <summary>Gets the MatchDesignatedRequirement value.</summary>
		[NoiOS, MacCatalyst (15, 0)]
		[Export ("matchDesignatedRequirement")]
		string MatchDesignatedRequirement { get; }

		/// <summary>Gets or sets the path to the app that matches the rule.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("matchPath")]
		string MatchPath { get; set; }

		/// <summary>Gets the signing identifier of the app that the rule matched.</summary>
		[Export ("matchSigningIdentifier")]
		string MatchSigningIdentifier { get; }

		/// <summary>Gets a list of domains for which VPN connection is allowed.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		///         <remarks>If this array is empty, then any domain is allowed.</remarks>
		[NullAllowed, Export ("matchDomains", ArgumentSemantic.Copy)]
		string [] MatchDomains { get; set; }

		[NoiOS, MacCatalyst (15, 0)]
		[NullAllowed, Export ("matchTools", ArgumentSemantic.Copy)]
		NEAppRule [] MatchTools { get; set; }
	}

	/// <summary>Contains DNS resolver settings for a network tunnel.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEDNSSettingsClassRef/index.html">Apple documentation for <c>NEDNSSettings</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Name = "NEDNSSettings")]
	[DisableDefaultCtor]
	interface NEDnsSettings : NSSecureCoding, NSCopying {
		/// <param name="servers">The array of server addresses.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithServers:")]
		NativeHandle Constructor (string [] servers);

		/// <summary>Gets the Servers value.</summary>
		[Export ("servers")]
		string [] Servers { get; }

		/// <summary>Gets or sets the SearchDomains value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("searchDomains", ArgumentSemantic.Copy)]
		string [] SearchDomains { get; set; }

		/// <summary>Gets or sets the DomainName value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("domainName")]
		string DomainName { get; set; }

		/// <summary>Gets or sets the MatchDomains value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("matchDomains", ArgumentSemantic.Copy)]
		string [] MatchDomains { get; set; }

		/// <summary>Gets or sets the MatchDomainsNoSearch value.</summary>
		[Export ("matchDomainsNoSearch")]
		bool MatchDomainsNoSearch { get; set; }

		[iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("dnsProtocol")]
		NEDnsProtocol DnsProtocol { get; }

		[iOS (14, 0), NoTV]
		[MacCatalyst (14, 0)]
		[Notification]
		[Field ("NEDNSSettingsConfigurationDidChangeNotification")]
		NSString ConfigurationDidChangeNotification { get; }

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("allowFailover")]
		bool AllowFailover { get; set; }
	}

	/// <summary>Provides filter flow control information to a <see cref="NetworkExtension.NEFilterDataProvider" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterControlProviderClassRef/index.html">Apple documentation for <c>NEFilterControlProvider</c></related>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEFilterProvider))]
	[DisableDefaultCtor] // no valid handle when `init` is called
	interface NEFilterControlProvider {
		/// <summary>Gets or sets a dictionary of remediation strings.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("remediationMap", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSDictionary<NSString, NSObject>> RemediationMap { get; set; }

		/// <summary>Gets or sets a dictionary of strings to append to URLs.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("URLAppendStringMap", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> UrlAppendStringMap { get; set; }

		/// <param name="report">The report.</param>
		///         <summary>Performs the handle report operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("handleReport:")]
		void HandleReport (NEFilterReport report);

		/// <param name="flow">The network flow.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Handles a user remediation request and runs <paramref name="completionHandler" /> after changing the rules.</summary>
		[Export ("handleRemediationForFlow:completionHandler:")]
		[Async (XmlDocs = """
			<param name="flow">The network flow.</param>
			<summary>Asynchronously handles a user remediation request.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous HandleRemediationForFlow operation.  The value of the TResult parameter is of type System.Action&lt;NetworkExtension.NEFilterControlVerdict&gt;.</para>
			        </returns>
			""")]
		void HandleRemediationForFlow (NEFilterFlow flow, Action<NEFilterControlVerdict> completionHandler);

		/// <param name="flow">The network flow.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Handles new filter rules and runs <paramref name="completionHandler" /> after changing the rules.</summary>
		[Export ("handleNewFlow:completionHandler:")]
		[Async (XmlDocs = """
			<param name="flow">The network flow.</param>
			<summary>Asynchronously handles new filter rules.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous HandleNewFlow operation.  The value of the TResult parameter is of type System.Action&lt;NetworkExtension.NEFilterControlVerdict&gt;.</para>
			        </returns>
			<remarks>
			          <para copied="true">The HandleNewFlowAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void HandleNewFlow (NEFilterFlow flow, Action<NEFilterControlVerdict> completionHandler);

		/// <summary>Method that is called to notify the Filter Data Provider that the filtering rules changed..</summary>
		[Export ("notifyRulesChanged")]
		void NotifyRulesChanged ();
	}

	/// <summary>Represents a Filter Control Provider decision about network data flow.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterControlVerdictClassRef/index.html">Apple documentation for <c>NEFilterControlVerdict</c></related>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEFilterNewFlowVerdict))]
	interface NEFilterControlVerdict : NSSecureCoding, NSCopying {
		/// <param name="updateRules">The updated content filter rules.</param>
		///         <summary>Creates and returns a verdict that allows the data flow, and updates the filtering rules.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("allowVerdictWithUpdateRules:")]
		NEFilterControlVerdict AllowVerdictWithUpdateRules (bool updateRules);

		/// <param name="updateRules">The updated content filter rules.</param>
		///         <summary>Creates and returns a verdict that drop the data in the flow, and updates the filtering rules.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("dropVerdictWithUpdateRules:")]
		NEFilterControlVerdict DropVerdictWithUpdateRules (bool updateRules);

		/// <summary>Creates and returns a verdict that indicates that the rules have been updated and future data flow will require new decisions.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("updateRules")]
		NEFilterControlVerdict UpdateRules ();
	}

	/// <summary>Filters network data.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterDataProviderClassRef/index.html">Apple documentation for <c>NEFilterDataProvider</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEFilterProvider))]
	[DisableDefaultCtor] // no valid handle when `init` is called
	interface NEFilterDataProvider {
		/// <param name="flow">The network flow.</param>
		///         <summary>Method that is called to filter a new network flow.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("handleNewFlow:")]
		NEFilterNewFlowVerdict HandleNewFlow (NEFilterFlow flow);

		/// <param name="flow">The network flow.</param>
		/// <param name="offset">The byte offset.</param>
		/// <param name="readBytes">The number of bytes to read.</param>
		/// <summary>Performs the handle inbound data from flow operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("handleInboundDataFromFlow:readBytesStartOffset:readBytes:")]
		NEFilterDataVerdict HandleInboundDataFromFlow (NEFilterFlow flow, nuint offset, NSData readBytes);

		/// <param name="flow">The network flow.</param>
		/// <param name="offset">The byte offset.</param>
		/// <param name="readBytes">The number of bytes to read.</param>
		/// <summary>Performs the handle outbound data from flow operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("handleOutboundDataFromFlow:readBytesStartOffset:readBytes:")]
		NEFilterDataVerdict HandleOutboundDataFromFlow (NEFilterFlow flow, nuint offset, NSData readBytes);

		/// <param name="flow">The network flow.</param>
		///         <summary>Method that is called to make a filtering decision for inbound data flow after the data is seen.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("handleInboundDataCompleteForFlow:")]
		NEFilterDataVerdict HandleInboundDataCompleteForFlow (NEFilterFlow flow);

		/// <param name="flow">The network flow.</param>
		///         <summary>ethod that is called to make a filtering decision for outbound data flow after the data is seen.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("handleOutboundDataCompleteForFlow:")]
		NEFilterDataVerdict HandleOutboundDataCompleteForFlow (NEFilterFlow flow);

		/// <param name="flow">The network flow.</param>
		///         <summary>Method that is called to handle a user remediation request.</summary>
		///         <returns>The result of the operation.</returns>
		[NoMac]
		[MacCatalyst (13, 1)]
		[Export ("handleRemediationForFlow:")]
		NEFilterRemediationVerdict HandleRemediationForFlow (NEFilterFlow flow);

		/// <summary>Method that is called to handle to handle a change to the filtering rules.</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		[Export ("handleRulesChanged")]
		void HandleRulesChanged ();

		[NoiOS, NoMacCatalyst]
		[Export ("applySettings:completionHandler:")]
		[Async]
		void ApplySettings ([NullAllowed] NEFilterSettings settings, Action<NSError> completionHandler);

		[NoiOS, NoMacCatalyst]
		[Export ("resumeFlow:withVerdict:")]
		void ResumeFlow (NEFilterFlow flow, NEFilterVerdict verdict);

		[NoTV, NoiOS, NoMacCatalyst]
		[Export ("updateFlow:usingVerdict:forDirection:")]
		void UpdateFlow (NEFilterSocketFlow flow, NEFilterDataVerdict verdict, NETrafficDirection direction);
	}

	/// <summary>Represents a Filter Data Provider decision about network data flow.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterDataVerdictClassRef/index.html">Apple documentation for <c>NEFilterDataVerdict</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEFilterVerdict))]
	interface NEFilterDataVerdict : NSSecureCoding, NSCopying {
		[NoTV, NoiOS, NoMacCatalyst]
		[Export ("statisticsReportFrequency", ArgumentSemantic.Assign)]
		NEFilterReportFrequency StatisticsReportFrequency { get; set; }

		/// <summary>Creates and returns a verdict that allows the current and subsequent data to be passed on.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("allowVerdict")]
		NEFilterDataVerdict AllowVerdict ();

		/// <summary>Creates and returns a verdict that drops the current and subsequent data.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("dropVerdict")]
		NEFilterDataVerdict DropVerdict ();

		/// <param name="remediationUrlMapKey">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="remediationButtonTextMapKey">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Creates and returns a verdict that drops the current and subsequent data, but allows the user to request access.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("remediateVerdictWithRemediationURLMapKey:remediationButtonTextMapKey:")]
		NEFilterDataVerdict RemediateVerdict ([NullAllowed] string remediationUrlMapKey, [NullAllowed] string remediationButtonTextMapKey);

		/// <param name="passBytes">The number of bytes to pass.</param>
		/// <param name="peekBytes">The number of bytes to peek.</param>
		/// <summary>Creates and returns a verdict that allows <paramref name="passBytes" /> to be passed on and notifies the system that it needs to see <paramref name="peekBytes" /> next.</summary>
		/// <returns>The result of the operation.</returns>
		[Static]
		[Export ("dataVerdictWithPassBytes:peekBytes:")]
		NEFilterDataVerdict DataVerdict (nuint passBytes, nuint peekBytes);

		/// <summary>Creates and returns a verdict that notifies the system that the Filter Control Provider needs to update the rules before deciding.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("needRulesVerdict")]
		NEFilterDataVerdict NeedRulesVerdict ();

		[NoiOS, MacCatalyst (15, 0)]
		[Static]
		[Export ("pauseVerdict")]
		NEFilterDataVerdict PauseVerdict ();
	}

	/// <summary>Contains information about a network data flow.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterFlowClassRef/index.html">Apple documentation for <c>NEFilterFlow</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEFilterFlow : NSSecureCoding, NSCopying {
		/// <summary>Gets the URL for the flow.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("URL")]
		NSUrl Url { get; }

		/// <summary>Gets the SourceAppUniqueIdentifier value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("sourceAppUniqueIdentifier")]
		NSData SourceAppUniqueIdentifier { get; }

		/// <summary>Gets the SourceAppIdentifier value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("sourceAppIdentifier")]
		string SourceAppIdentifier { get; }

		/// <summary>Gets the SourceAppVersion value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("sourceAppVersion")]
		string SourceAppVersion { get; }

		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("direction")]
		NETrafficDirection Direction { get; }

		[NoiOS, MacCatalyst (15, 0)]
		[NullAllowed, Export ("sourceAppAuditToken")]
		NSData SourceAppAuditToken { get; }

		[Mac (13, 0), NoiOS, NoMacCatalyst, NoTV]
		[NullAllowed]
		[Export ("sourceProcessAuditToken")]
		NSData SourceProcessAuditToken { get; }

		[iOS (13, 1)]
		[MacCatalyst (13, 1)]
		[Export ("identifier")]
		NSUuid Identifier { get; }
	}

	/// <summary>Manages content filter configurations.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterManagerClassRef/index.html">Apple documentation for <c>NEFilterManager</c></related>
	[NoTV]
	// according to Xcode7 SDK this was available (in parts) in iOS8
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NEFilterManager {
		/// <summary>Gets the shared filter manager instance.</summary>
		[Static]
		[Export ("sharedManager")]
		NEFilterManager SharedManager { get; }

		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Loads the filter from the configuration that is saved in the Network Extension preferences and runs a completion handler after the operation is complete.</summary>
		[Export ("loadFromPreferencesWithCompletionHandler:")]
		[Async (XmlDocs = """
			<summary>Loads the filter from the configuration that is saved in the Network Extension preferences and runs a completion handler after the operation is complete.</summary>
			<returns>A task that represents the asynchronous LoadFromPreferences operation</returns>
			""")]
		void LoadFromPreferences (Action<NSError> completionHandler);

		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Removes the filter from the Network Extensions preferences and runs a completion handler when the operation is complete.</summary>
		[Export ("removeFromPreferencesWithCompletionHandler:")]
		[Async (XmlDocs = """
			<summary>Removes the filter from the Network Extensions preferences and runs a completion handler when the operation is complete.</summary>
			<returns>A task that represents the asynchronous RemoveFromPreferences operation</returns>
			""")]
		void RemoveFromPreferences (Action<NSError> completionHandler);

		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Saves the filter in the Network Extensions preferences and runs a completion handler when the operation is complete.</summary>
		[Export ("saveToPreferencesWithCompletionHandler:")]
		[Async (XmlDocs = """
			<summary>Saves the filter in the Network Extensions preferences and runs a completion handler when the operation is complete.</summary>
			<returns>A task that represents the asynchronous SaveToPreferences operation</returns>
			<remarks>
			          <para copied="true">The SaveToPreferencesAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void SaveToPreferences (Action<NSError> completionHandler);

		/// <summary>Gets or sets a localized description of the filter.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("localizedDescription")]
		string LocalizedDescription { get; set; }

		/// <summary>Gets or sets an object that contains settings for the filter.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("providerConfiguration", ArgumentSemantic.Strong)]
		NEFilterProviderConfiguration ProviderConfiguration { get; set; }

		/// <summary>Get or sets a Boolean value that enables and disables the filter.</summary>
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		[Field ("NEFilterConfigurationDidChangeNotification")]
		[Notification]
		NSString ConfigurationDidChangeNotification { get; }

		[NoiOS]
		[NoMacCatalyst]
		[Export ("grade", ArgumentSemantic.Assign)]
		NEFilterManagerGrade Grade { get; set; }

		[NoTV, Mac (15, 0), NoiOS, MacCatalyst (18, 0)]
		[Export ("disableEncryptedDNSSettings", ArgumentSemantic.Assign)]
		bool DisableEncryptedDnsSettings { get; set; }
	}

	/// <summary>Represents a Filter Provider decision about network data flow the first time that the data is seen.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterNewFlowVerdictClassRef/index.html">Apple documentation for <c>NEFilterNewFlowVerdict</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEFilterVerdict))]
	interface NEFilterNewFlowVerdict : NSSecureCoding, NSCopying {
		[NoTV, NoiOS, NoMacCatalyst]
		[Export ("statisticsReportFrequency", ArgumentSemantic.Assign)]
		NEFilterReportFrequency StatisticsReportFrequency { get; set; }

		/// <summary>Creates and returns a verdict needs filter rules before it can decide.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("needRulesVerdict")]
		NEFilterNewFlowVerdict NeedRulesVerdict ();

		/// <summary>Returns a verdict that allows the data flow to pass.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("allowVerdict")]
		NEFilterNewFlowVerdict AllowVerdict ();

		/// <summary>Returns a verdict that drops the data flow and does not give the user the ability to request access.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("dropVerdict")]
		NEFilterNewFlowVerdict DropVerdict ();

		/// <param name="remediationUrlMapKey">The remediation URL map key.</param>
		///         <param name="remediationButtonTextMapKey">The remediation button text map key.</param>
		///         <summary>Returns a verdict that drops the data flow but gives the user the ability to request access.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("remediateVerdictWithRemediationURLMapKey:remediationButtonTextMapKey:")]
		NEFilterNewFlowVerdict RemediateVerdict (string remediationUrlMapKey, string remediationButtonTextMapKey);

		/// <param name="urlAppendMapKey">The URL append map key.</param>
		///         <summary>Returns a verdict that allows the data flow to pass, but that a string will be appended to the URL before the data is passed.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("URLAppendStringVerdictWithMapKey:")]
		NEFilterNewFlowVerdict UrlAppendStringVerdict (string urlAppendMapKey);

		/// <param name="filterInbound">Whether to filter inbound traffic.</param>
		/// <param name="peekInboundBytes">The number of inbound bytes to peek.</param>
		/// <param name="filterOutbound">Whether to filter outbound traffic.</param>
		/// <param name="peekOutboundBytes">The number of outbound bytes to peek.</param>
		/// <summary>Performs the filter data verdict operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Static]
		[Export ("filterDataVerdictWithFilterInbound:peekInboundBytes:filterOutbound:peekOutboundBytes:")]
		NEFilterNewFlowVerdict FilterDataVerdict (bool filterInbound, nuint peekInboundBytes, bool filterOutbound, nuint peekOutboundBytes);

		[NoiOS, MacCatalyst (15, 0)]
		[Static]
		[Export ("pauseVerdict")]
		NEFilterDataVerdict PauseVerdict ();
	}

	/// <summary>Base class for data and control filter providers.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterProviderClassRef/index.html">Apple documentation for <c>NEFilterProvider</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEProvider))]
	[Abstract] // documented as such
	interface NEFilterProvider {
		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Starts the content filter.</summary>
		[Export ("startFilterWithCompletionHandler:")]
		[Async (XmlDocs = """
			<summary>Starts the content filter asynchronously.</summary>
			<returns>A task that represents the asynchronous StartFilter operation</returns>
			""")]
		void StartFilter (Action<NSError> completionHandler);

		/// <param name="reason">The reason for the failure.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Stops the content filter with the specified reason.</summary>
		[Export ("stopFilterWithReason:completionHandler:")]
		[Async (XmlDocs = """
			<param name="reason">The reason for the failure.</param>
			<summary>Stops the content filter asynchronously.</summary>
			<returns>A task that represents the asynchronous StopFilter operation</returns>
			<remarks>
			          <para copied="true">The StopFilterAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void StopFilter (NEProviderStopReason reason, Action completionHandler);

		[iOS (13, 0)] // new in this (base) type
		[MacCatalyst (13, 1)]
		[Export ("handleReport:")]
		void HandleReport (NEFilterReport report);

		/// <summary>Gets the FilterConfiguration value.</summary>
		[Export ("filterConfiguration")]
		NEFilterProviderConfiguration FilterConfiguration { get; }

		/// <summary>Gets the RemediationMapRemediationButtonTexts value.</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		[Field ("NEFilterProviderRemediationMapRemediationButtonTexts")]
		NSString RemediationMapRemediationButtonTexts { get; }

		/// <summary>Gets the RemediationMapRemediationUrls value.</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		[Field ("NEFilterProviderRemediationMapRemediationURLs")]
		NSString RemediationMapRemediationUrls { get; }
	}

	/// <summary>Contains Filter Provider configuration data.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterProviderConfigurationClassRef/index.html">Apple documentation for <c>NEFilterProviderConfiguration</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEFilterProviderConfiguration : NSSecureCoding, NSCopying {
		/// <summary>Gets or sets a Boolean value that controls whether data that originates from WebKit browser objects should be filtered.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "Not supported on the platform.")]
		[Export ("filterBrowsers")]
		bool FilterBrowsers { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether data that originates from sockets should be filtered.</summary>
		[Export ("filterSockets")]
		bool FilterSockets { get; set; }

		/// <summary>Gets or sets a dictionary of vendor-specific settings.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("vendorConfiguration", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> VendorConfiguration { get; set; }

		/// <summary>Gets or sets the configuration server address.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("serverAddress")]
		string ServerAddress { get; set; }

		/// <summary>Gets or sets the user name.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("username")]
		string Username { get; set; }

		/// <summary>Gets or sets the name of the administering organization.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("organization")]
		string Organization { get; set; }

		/// <summary>Gets or sets the persistent reference to the password that is stored in the keychain.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("passwordReference", ArgumentSemantic.Copy)]
		NSData PasswordReference { get; set; }

		/// <summary>Gets or sets the persistent reference to APrivate key and certificate in the keychain.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("identityReference", ArgumentSemantic.Copy)]
		NSData IdentityReference { get; set; }

		[NoiOS]
		[MacCatalyst (15, 0)]
		[Export ("filterPackets")]
		bool FilterPackets { get; set; }

		[NoiOS]
		[MacCatalyst (15, 0)]
		[NullAllowed, Export ("filterDataProviderBundleIdentifier")]
		string FilterDataProviderBundleIdentifier { get; set; }

		[NoiOS]
		[MacCatalyst (15, 0)]
		[NullAllowed, Export ("filterPacketProviderBundleIdentifier")]
		string FilterPacketProviderBundleIdentifier { get; set; }
	}

	/// <summary>Represents a Filter Data Provider decision about network data flow after the user requests access.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterRemediationVerdictClassRef/index.html">Apple documentation for <c>NEFilterRemediationVerdict</c></related>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEFilterVerdict))]
	interface NEFilterRemediationVerdict : NSSecureCoding, NSCopying {
		/// <summary>Returns a verdict that indicates that the flow will be allowed to pass if it is requested in the future.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("allowVerdict")]
		NEFilterRemediationVerdict AllowVerdict ();

		/// <summary>Returns a verdict that indicates that the flow will be not allowed to pass if it is requested in the future.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("dropVerdict")]
		NEFilterRemediationVerdict DropVerdict ();

		/// <summary>Returns a verdict that indicates that filtering rules are needed before it can be decided whether the flow will be allowed to pass if it is requested in the future.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("needRulesVerdict")]
		NEFilterRemediationVerdict NeedRulesVerdict ();
	}

	/// <summary>Base class for content filter verdicts.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterVerdictClassRef/index.html">Apple documentation for <c>NEFilterVerdict</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEFilterVerdict : NSSecureCoding, NSCopying {
		/// <summary>Gets or sets the ShouldReport value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("shouldReport")]
		bool ShouldReport { get; set; }
	}

	/// <summary>Contains additional data about a network data flow.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFlowMetaDataClassRef/index.html">Apple documentation for <c>NEFlowMetaData</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEFlowMetaData : NSCopying, NSSecureCoding {
		/// <summary>Gets the version-specific signing identifier for the source app.</summary>
		[Export ("sourceAppUniqueIdentifier")]
		NSData SourceAppUniqueIdentifier { get; }

		/// <summary>Gets the signing identifier for the source app.</summary>
		[Export ("sourceAppSigningIdentifier")]
		string SourceAppSigningIdentifier { get; }

		[NoiOS]
		[MacCatalyst (15, 0)]
		[NullAllowed, Export ("sourceAppAuditToken")]
		NSData SourceAppAuditToken { get; }

		[NoTV, NoiOS, MacCatalyst (15, 0)]
		[NullAllowed, Export ("filterFlowIdentifier")]
		NSUuid FilterFlowIdentifier { get; }
	}

	/// <summary>A command handler block for a Hotspot Helper.</summary>
	[NoMac]
	[MacCatalyst (13, 1)]
	delegate void NEHotspotHelperHandler (NEHotspotHelperCommand cmd);

	/// <summary>Enables registration for Wi-Fi hotspots.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEHotspotHelperClassRef/index.html">Apple documentation for <c>NEHotspotHelper</c></related>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Deprecated (PlatformName.iOS, 26, 0, message: "Use 'NEHotspotManager' instead.")] // NEHotspotManager is swift only :/
	[Deprecated (PlatformName.MacCatalyst, 26, 0, message: "Use 'NEHotspotManager' instead.")] // NEHotspotManager is swift only :/
	interface NEHotspotHelper {
		[Static]
		[Internal]
		[Export ("registerWithOptions:queue:handler:")]
		bool Register ([NullAllowed] NSDictionary options, DispatchQueue queue, NEHotspotHelperHandler handler);

		/// <param name="options">The options dictionary.</param>
		///         <param name="queue">The dispatch queue.</param>
		///         <param name="handler">The completion handler.</param>
		///         <summary>Registers the hotspot helper.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Wrap ("Register (options.GetDictionary (), queue, handler)")]
		bool Register ([NullAllowed] NEHotspotHelperOptions options, DispatchQueue queue, NEHotspotHelperHandler handler);

		/// <param name="network">The network.</param>
		///         <summary>Ends the helper's authentication session.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("logoff:")]
		bool Logoff (NEHotspotNetwork network);

		/// <summary>Gets the list of supported network interfaces.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Static, NullAllowed]
		[Export ("supportedNetworkInterfaces")]
		NEHotspotNetwork [] SupportedNetworkInterfaces { get; }
	}

	/// <summary>Holds the name of the network handled by the applications.</summary>
	[NoTV]
	[Static]
	[NoMac]
	[MacCatalyst (13, 1)]
	interface NEHotspotHelperOptionInternal {
		/// <summary>The name of the network handled by the application.</summary>
		[Field ("kNEHotspotHelperOptionDisplayName")]
		NSString DisplayName { get; }
	}

	/// <summary>A reusable request for registering Wi-Fi hotspots.</summary>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[Category]
	[BaseType (typeof (NSMutableUrlRequest))]
	interface NSMutableURLRequest_NEHotspotHelper {
		/// <param name="command">The command.</param>
		/// <summary>Performs the bind to operation.</summary>
		[Export ("bindToHotspotHelperCommand:")]
		void BindTo (NEHotspotHelperCommand command);
	}

	/// <summary>Represents commands to a Hotspot Helper.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEHotspotHelperCommandClassRef/index.html">Apple documentation for <c>NEHotspotHelperCommand</c></related>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEHotspotHelperCommand {
		/// <summary>Gets the helper command type.</summary>
		[Export ("commandType")]
		NEHotspotHelperCommandType CommandType { get; }

		/// <summary>Gets the associated network.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("network")]
		NEHotspotNetwork Network { get; }

		/// <summary>Gets the NetworkList value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		///         <remarks>Gets a list of the associated networks.</remarks>
		[NullAllowed, Export ("networkList")]
		NEHotspotNetwork [] NetworkList { get; }

		/// <param name="result">The result.</param>
		///         <summary>Creates and returns a command response.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("createResponse:")]
		NEHotspotHelperResponse CreateResponse (NEHotspotHelperResult result);

		/// <param name="endpoint">The network endpoint.</param>
		///         <summary>Creates and returns a TCP connection.</summary>
		///         <returns>The result of the operation.</returns>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'NWParameters.RequiredInterface' with the 'Interface' property instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'NWParameters.RequiredInterface' with the 'Interface' property instead.")]
		[Export ("createTCPConnection:")]
		NWTcpConnection CreateTcpConnection (NWEndpoint endpoint);

		/// <param name="endpoint">The network endpoint.</param>
		///         <summary>Creates and returns a UDP connection.</summary>
		///         <returns>The result of the operation.</returns>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'NWParameters.RequiredInterface' with the 'Interface' property instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'NWParameters.RequiredInterface' with the 'Interface' property instead.")]
		[Export ("createUDPSession:")]
		NWUdpSession CreateUdpSession (NWEndpoint endpoint);

		[NoTV, NoMac, iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("interface")]
		NWInterface Interface { get; }
	}

	/// <summary>Contains a Hotspot Helper command response.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEHotspotHelperResponseClassRef/index.html">Apple documentation for <c>NEHotspotHelperResponse</c></related>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEHotspotHelperResponse {
		/// <param name="network">The network.</param>
		///         <summary>Sets the network that transmits the confidence information.</summary>
		[Export ("setNetwork:")]
		void SetNetwork (NEHotspotNetwork network);

		/// <param name="networkList">The list of networks.</param>
		///         <summary>Sets the handled networks.</summary>
		[Export ("setNetworkList:")]
		void SetNetworkList (NEHotspotNetwork [] networkList);

		/// <summary>Delivers the response.</summary>
		// deprecated, but the replacment API is Swift-only :/
		[Deprecated (PlatformName.iOS, 26, 0, message: "Use 'NEHotspotEvaluationProvider.HandleCommand' or 'NEHotspotAuthenticationProvider.HandleCommand' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 26, 0, message: "Use 'NEHotspotEvaluationProvider.HandleCommand' or 'NEHotspotAuthenticationProvider.HandleCommand' instead.")]
		[Export ("deliver")]
		void Deliver ();
	}

	/// <summary>Contains information about a Wi-Fi network hotspot.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEHotspotNetworkClassRef/index.html">Apple documentation for <c>NEHotspotNetwork</c></related>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEHotspotNetwork {
		/// <summary>Gets the network SSID.</summary>
		[Export ("SSID")]
		string Ssid { get; }

		/// <summary>Gets the BSSID for the network.</summary>
		[Export ("BSSID")]
		string Bssid { get; }

		/// <summary>Gets a value in [0.0, 1.0] that indicates the recent network strength.</summary>
		[Export ("signalStrength")]
		double SignalStrength { get; }

		/// <summary>Gets a Boolean value that tells whether the network is secure.</summary>
		[Export ("secure")]
		bool Secure { [Bind ("isSecure")] get; }

		/// <summary>Gets a Boolean value that tells whether the network was automatically joined.</summary>
		[Export ("autoJoined")]
		bool AutoJoined { [Bind ("didAutoJoin")] get; }

		/// <summary>Gets a Boolean value that tells whether the network was very recently joined.</summary>
		[Export ("justJoined")]
		bool JustJoined { [Bind ("didJustJoin")] get; }

		/// <summary>Gets a Boolean value that tells whether the hotspot helper is the chosen one for the network.</summary>
		[Export ("chosenHelper")]
		bool ChosenHelper { [Bind ("isChosenHelper")] get; }

		/// <param name="confidence">The confidence level.</param>
		///         <summary>Sets the hotspot's confidence.</summary>
		[Export ("setConfidence:")]
		void SetConfidence (NEHotspotHelperConfidence confidence);

		/// <param name="password">The password.</param>
		///         <summary>Sets the network password.</summary>
		[Export ("setPassword:")]
		void SetPassword (string password);

		[Async]
		[NoTV, NoMac, iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Static]
		[Export ("fetchCurrentWithCompletionHandler:")]
		void FetchCurrent (Action<NEHotspotNetwork> completionHandler);

		[NoTV, NoMac, iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("securityType")]
		NEHotspotNetworkSecurityType SecurityType { get; }
	}

	/// <summary>Settings for an IPv4 route.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEIPv4RouteClassRef/index.html">Apple documentation for <c>NEIPv4Route</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NEIPv4Route : NSSecureCoding, NSCopying {
		/// <param name="address">The address.</param>
		/// <param name="subnetMask">The subnet mask.</param>
		/// <summary>Creates a new IPv4 route with the specified address and subnet mask.</summary>
		[Export ("initWithDestinationAddress:subnetMask:")]
		NativeHandle Constructor (string address, string subnetMask);

		/// <summary>Gets the destination address.</summary>
		[Export ("destinationAddress")]
		string DestinationAddress { get; }

		/// <summary>Gets the destination subnet mask.</summary>
		[Export ("destinationSubnetMask")]
		string DestinationSubnetMask { get; }

		/// <summary>Gets or sets the next-hop gateway address.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("gatewayAddress")]
		string GatewayAddress { get; set; }

		/// <summary>Gets the default route.</summary>
		[Static]
		[Export ("defaultRoute")]
		NEIPv4Route DefaultRoute { get; }
	}

	/// <summary>Settings for an IPv6 route.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEIPv6RouteClassRef/index.html">Apple documentation for <c>NEIPv6Route</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NEIPv6Route : NSSecureCoding, NSCopying {
		/// <param name="address">The address.</param>
		/// <param name="networkPrefixLength">The network prefix length.</param>
		/// <summary>Creates a new IPv6 route with the specified destination address and prefix length.</summary>
		[Export ("initWithDestinationAddress:networkPrefixLength:")]
		NativeHandle Constructor (string address, NSNumber networkPrefixLength);

		/// <summary>Gets the destination address.</summary>
		[Export ("destinationAddress")]
		string DestinationAddress { get; }

		/// <summary>Gets the prefix length of the destination network.</summary>
		[Export ("destinationNetworkPrefixLength")]
		NSNumber DestinationNetworkPrefixLength { get; }

		/// <summary>Gets or sets the next-hop gateway address.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("gatewayAddress")]
		string GatewayAddress { get; set; }

		/// <summary>Gets the default route.</summary>
		[Static]
		[Export ("defaultRoute")]
		NEIPv6Route DefaultRoute { get; }
	}

	/// <summary>Settings for an IPv4 tunnel.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEIPv4SettingsClassRef/index.html">Apple documentation for <c>NEIPv4Settings</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NEIPv4Settings : NSSecureCoding, NSCopying {
		/// <param name="addresses">The array of addresses.</param>
		/// <param name="subnetMasks">The array of subnet masks.</param>
		/// <summary>Creates a new IPv4 route with the specified addresses and subnet masks..</summary>
		[Export ("initWithAddresses:subnetMasks:")]
		NativeHandle Constructor (string [] addresses, string [] subnetMasks);

		/// <summary>Gets the list of addresses to assign to the TUN interface.</summary>
		[Export ("addresses")]
		string [] Addresses { get; }

		/// <summary>Gets the list of subnet masks for the corresponding addresses.</summary>
		[Export ("subnetMasks")]
		string [] SubnetMasks { get; }

		/// <summary>Gets or sets the list of addresses that will be routed to TUN interface.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("includedRoutes", ArgumentSemantic.Copy)]
		NEIPv4Route [] IncludedRoutes { get; set; }

		/// <summary>Gets or sets the list of addresses that will be routed to the physical device.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("excludedRoutes", ArgumentSemantic.Copy)]
		NEIPv4Route [] ExcludedRoutes { get; set; }

		[NoTV, NoiOS, Mac (13, 0)]
		[NoMacCatalyst]
		[Export ("router")]
		[NullAllowed]
		string Router { get; set; }
	}

	/// <summary>Settings for an IPv6 tunnel.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEIPv6SettingsClassRef/index.html">Apple documentation for <c>NEIPv6Settings</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NEIPv6Settings : NSSecureCoding, NSCopying {
		/// <param name="addresses">The array of addresses.</param>
		/// <param name="networkPrefixLengths">The array of network prefix lengths.</param>
		/// <summary>Creates a new IPv6 settings object with the specified addresses and prefix lengths.</summary>
		[Export ("initWithAddresses:networkPrefixLengths:")]
		NativeHandle Constructor (string [] addresses, NSNumber [] networkPrefixLengths);

		/// <summary>Gets the addresses that are assigned to the TUN interface.</summary>
		[Export ("addresses")]
		string [] Addresses { get; }

		/// <summary>Gets the list of prefix lengths for each corresponding address.</summary>
		[Export ("networkPrefixLengths")]
		NSNumber [] NetworkPrefixLengths { get; }

		/// <summary>Gets or sets the list of addresses that will be routed to TUN interface.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("includedRoutes", ArgumentSemantic.Copy)]
		NEIPv6Route [] IncludedRoutes { get; set; }

		/// <summary>Gets or sets the list of addresses that will be routed to the physical device.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("excludedRoutes", ArgumentSemantic.Copy)]
		NEIPv6Route [] ExcludedRoutes { get; set; }
	}

	/// <summary>Base class for Network Extension Providers.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEProviderClassRef/index.html">Apple documentation for <c>NEProvider</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // init returns nil
	interface NEProvider {
		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Method that is called when the device is about to sleep.</summary>
		[Export ("sleepWithCompletionHandler:")]
		[Async (XmlDocs = """
			<summary>Method that is called when the device is about to sleep.</summary>
			<returns>A task that represents the asynchronous Sleep operation</returns>
			""")]
		void Sleep (Action completionHandler);

		/// <summary>Method that is called when the device wakes.</summary>
		[Export ("wake")]
		void Wake ();

		/// <param name="remoteEndpoint">The remote endpoint.</param>
		///         <param name="enableTLS">Whether to enable TLS.</param>
		///         <param name="TLSParameters">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="connectionDelegate">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Creates a TCP connection with the specified values.</summary>
		///         <returns>The result of the operation.</returns>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection' instead.")]
		[Export ("createTCPConnectionToEndpoint:enableTLS:TLSParameters:delegate:")]
		NWTcpConnection CreateTcpConnectionToEndpoint (NWEndpoint remoteEndpoint, bool enableTLS, [NullAllowed] NWTlsParameters TLSParameters, [NullAllowed] NSObject connectionDelegate);

		/// <param name="remoteEndpoint">The remote endpoint.</param>
		///         <param name="localEndpoint">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Creates a UDP connection with the specified values.</summary>
		///         <returns>The result of the operation.</returns>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection' instead.")]
		[Export ("createUDPSessionToEndpoint:fromEndpoint:")]
		NWUdpSession CreateUdpSessionToEndpoint (NWEndpoint remoteEndpoint, [NullAllowed] NWHostEndpoint localEndpoint);

		/// <summary>Gets the default connection path for new connections.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWPathMonitor' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWPathMonitor' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWPathMonitor' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWPathMonitor' instead.")]
		[NullAllowed, Export ("defaultPath")]
		NWPath DefaultPath { get; }

		/// <param name="message">The message data.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Displays a message to the user and passes a Boolean result to a completion handler when it is finished.</summary>
		[NoTV]
		[Deprecated (PlatformName.iOS, 12, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 14)]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Export ("displayMessage:completionHandler:")]
		[Async (XmlDocs = """
			<param name="message">The message data.</param>
			<summary>Displays a message to the user and passes a Boolean result to a completion handler when it is finished.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous DisplayMessage operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean&gt;.</para>
			        </returns>
			<remarks>
			          <para copied="true">The DisplayMessageAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void DisplayMessage (string message, Action<bool> completionHandler);

		[NoiOS]
		[MacCatalyst (15, 0)]
		[Static]
		[Export ("startSystemExtensionMode")]
		void StartSystemExtensionMode ();
	}

	/// <summary>HTTP proxy settings.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEProxySettingsClassRef/index.html">Apple documentation for <c>NEProxySettings</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEProxySettings : NSSecureCoding, NSCopying {
		/// <summary>Gets or sets a Boolean value that controls whether proxies can be auto-configured.</summary>
		[Export ("autoProxyConfigurationEnabled")]
		bool AutoProxyConfigurationEnabled { get; set; }

		/// <summary>Gets or sets the URL to the Proxy Auto Configuration script.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("proxyAutoConfigurationURL", ArgumentSemantic.Copy)]
		NSUrl ProxyAutoConfigurationUrl { get; set; }

		/// <summary>Gets or sets the Proxy Auto Configuration source code, in JavaScript.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("proxyAutoConfigurationJavaScript")]
		string ProxyAutoConfigurationJavaScript { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the settings are enabled for the HTTP protocol.</summary>
		[Export ("HTTPEnabled")]
		bool HttpEnabled { get; set; }

		/// <summary>Gets or sets the server that contains the settings for static HTTP server proxyies.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("HTTPServer", ArgumentSemantic.Copy)]
		NEProxyServer HttpServer { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the settings are enabled for the HTTPS protocol.</summary>
		[Export ("HTTPSEnabled")]
		bool HttpsEnabled { get; set; }

		/// <summary>Gets or sets the server that contains the settings for static HTTPS server proxyies.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("HTTPSServer", ArgumentSemantic.Copy)]
		NEProxyServer HttpsServer { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether single label host names are exempt from the proxy settings.</summary>
		[Export ("excludeSimpleHostnames")]
		bool ExcludeSimpleHostnames { get; set; }

		/// <summary>Gets or sets a list of domain name patterns for which matching domains re exempt from the proxy settings.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("exceptionList", ArgumentSemantic.Copy)]
		string [] ExceptionList { get; set; }

		/// <summary>Gets or sets a list of domains for which the proxy settings are applied.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("matchDomains", ArgumentSemantic.Copy)]
		string [] MatchDomains { get; set; }
	}

	/// <summary>Settings for AProxy server.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEProxyServerClassRef/index.html">Apple documentation for <c>NEProxyServer</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NEProxyServer : NSSecureCoding, NSCopying {
		/// <param name="address">The address.</param>
		/// <param name="port">The port number.</param>
		/// <summary>Creates a new proxy server with the specified address and port.</summary>
		[Export ("initWithAddress:port:")]
		NativeHandle Constructor (string address, nint port);

		/// <summary>Gets the address that was specified when the proxy server was created.</summary>
		[Export ("address")]
		string Address { get; }

		/// <summary>Gets the port that was specified when the proxy server was created.</summary>
		[Export ("port")]
		nint Port { get; }

		/// <summary>Gets or sets a Boolean value that controls whether authentication is needed on the server.</summary>
		[Export ("authenticationRequired")]
		bool AuthenticationRequired { get; set; }

		/// <summary>Gets or sets the user name.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("username")]
		string Username { get; set; }

		/// <summary>Gets or sets the password.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("password")]
		string Password { get; set; }
	}

	/// <summary>Settings for a network tunnel.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NETunnelNetworkSettingsClassRef/index.html">Apple documentation for <c>NETunnelNetworkSettings</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NETunnelNetworkSettings : NSSecureCoding, NSCopying {
		/// <param name="address">The address.</param>
		/// <summary>Creates a new tunnel network settings object for the specified remote address.</summary>
		[Export ("initWithTunnelRemoteAddress:")]
		NativeHandle Constructor (string address);

		/// <summary>Gets the remote address that was provided when the network tunnel object was created.</summary>
		[Export ("tunnelRemoteAddress")]
		string TunnelRemoteAddress { get; }

		/// <summary>Gets or sets the DNS settings for the tunnel.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("DNSSettings", ArgumentSemantic.Copy)]
		NEDnsSettings DnsSettings { get; set; }

		/// <summary>Gets or sets the proxy settings for the tunnel.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("proxySettings", ArgumentSemantic.Copy)]
		NEProxySettings ProxySettings { get; set; }
	}

#if XAMCORE_5_0
	delegate void NETunnelProviderHandleAppMessageCallback ([NullAllowed] NSData data);
#endif

	/// <summary>Base class for extensions that implement client-side ends of a network tunnel.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NETunnelProviderClassRef/index.html">Apple documentation for <c>NETunnelProvider</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEProvider))]
	[DisableDefaultCtor] // init returns nil
	interface NETunnelProvider {
		/// <param name="messageData">The message data.</param>
		///         <param name="completionHandler">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Method that is called to handle messages from the containing app.</summary>
		[Export ("handleAppMessage:completionHandler:")]
		[Async (XmlDocs = """
			<param name="messageData">The message data.</param>
			<summary>Method that is called to handle messages from the containing app.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous HandleAppMessage operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSData&gt;.</para>
			        </returns>
			""")]
#if XAMCORE_5_0
		void HandleAppMessage (NSData messageData, [NullAllowed] NETunnelProviderHandleAppMessageCallback completionHandler);
#else
		void HandleAppMessage (NSData messageData, [NullAllowed] Action<NSData> completionHandler);
#endif

		/// <param name="tunnelNetworkSettings">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="completionHandler">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Updates the network settings for the tunnel.</summary>
		[Export ("setTunnelNetworkSettings:completionHandler:")]
		[Async (XmlDocs = """
			<param name="tunnelNetworkSettings">The tunnel network settings.</param>
			<summary>Updates the network settings for the tunnel.</summary>
			<returns>A task that represents the asynchronous SetTunnelNetworkSettings operation</returns>
			<remarks>
			          <para copied="true">The SetTunnelNetworkSettingsAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void SetTunnelNetworkSettings ([NullAllowed] NETunnelNetworkSettings tunnelNetworkSettings, [NullAllowed] Action<NSError> completionHandler);

		/// <summary>Gets the tunnel configuration.</summary>
		[Export ("protocolConfiguration")]
		NEVpnProtocol ProtocolConfiguration { get; }

		/// <summary>Gets the rules that control which apps will use the tunneling session.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NoTV]
		[NullAllowed, Export ("appRules")]
		NEAppRule [] AppRules { get; }

		/// <summary>Gets the routing method.</summary>
		[NoTV]
		[Export ("routingMethod")]
		NETunnelProviderRoutingMethod RoutingMethod { get; }

		/// <summary>Gets or sets a Boolean value that tells the system that the tunnel is being reestablished.</summary>
		[Export ("reasserting")]
		bool Reasserting { get; set; }
	}

	/// <summary>Configures and controls a VPN connection.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NETunnelProviderManagerClassRef/index.html">Apple documentation for <c>NETunnelProviderManager</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEVpnManager))]
	interface NETunnelProviderManager {
		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Loads all of the calling app's VPN configurations from the Network Extension preferences and runs a completion handler when the operation is complete.</summary>
		[Static]
		[Export ("loadAllFromPreferencesWithCompletionHandler:")]
		[Async (XmlDocs = """
			<summary>Loads all of the calling app's VPN configurations from the Network Extension preferences and runs a completion handler when the operation is complete.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadAllFromPreferences operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSArray,Foundation.NSError&gt;.</para>
			        </returns>
			<remarks>
			          <para copied="true">The LoadAllFromPreferencesAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void LoadAllFromPreferences (Action<NSArray, NSError> completionHandler);

		[NoTV, NoiOS, MacCatalyst (15, 0)]
		[Static]
		[Export ("forPerAppVPN")]
		NETunnelProviderManager CreatePerAppVpn ();

		[NoTV]
		[return: NullAllowed]
		[Export ("copyAppRules")]
		NEAppRule [] CopyAppRules ();

		// CopyAppRules was incorrectly bound to AppRules and it is only available on macOS
		/// <summary>Gets a copy of the rules that control which apps can use the tunnel.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NoTV, NoiOS, MacCatalyst (15, 0)]
		[Export ("appRules", ArgumentSemantic.Copy)]
		NEAppRule [] AppRules { get; set; }

		/// <summary>Gets or sets the routing method.</summary>
		[NoTV]
		[Export ("routingMethod")]
		NETunnelProviderRoutingMethod RoutingMethod { get; }

		[NoTV, NoiOS, MacCatalyst (15, 0)]
		[Export ("safariDomains", ArgumentSemantic.Copy)]
		string [] SafariDomains { get; set; }

		[NoTV, NoiOS, MacCatalyst (15, 0)]
		[Export ("mailDomains", ArgumentSemantic.Copy)]
		string [] MailDomains { get; set; }

		[NoTV, NoiOS, MacCatalyst (15, 0)]
		[Export ("calendarDomains", ArgumentSemantic.Copy)]
		string [] CalendarDomains { get; set; }

		[NoTV, NoiOS, MacCatalyst (15, 0)]
		[Export ("contactsDomains", ArgumentSemantic.Copy)]
		string [] ContactsDomains { get; set; }

		[NoTV, NoiOS, MacCatalyst (15, 0)]
		[Export ("excludedDomains", ArgumentSemantic.Copy)]
		string [] ExcludedDomains { get; set; }

		[NoTV, NoiOS, MacCatalyst (15, 0)]
		[Export ("associatedDomains", ArgumentSemantic.Copy)]
		string [] AssociatedDomains { get; set; }
	}


	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Name = "NEVPNManager")]
	[DisableDefaultCtor] // Assertion failed: (0), function -[NEVPNManager init], file /SourceCache/NetworkExtension_Sim/NetworkExtension-168.1.8/Framework/NEVPNManager.m, line 41.
	interface NEVpnManager {

		/// <summary>Gets or sets the rules that control when on-demand connections will occur.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("onDemandRules", ArgumentSemantic.Copy)]
		NEOnDemandRule [] OnDemandRules { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether on-demand connections are allowed.</summary>
		[Export ("onDemandEnabled")]
		bool OnDemandEnabled { [Bind ("isOnDemandEnabled")] get; set; }

		/// <summary>Gets or sets the localized description of the VPN manager.</summary>
		[NullAllowed]
		[Export ("localizedDescription")]
		string LocalizedDescription { get; set; }

		/// <summary>Developers should not use this deprecated property. Developers should use 'ProtocolConfiguration' instead.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NoTV]
		[NullAllowed]
		[Export ("protocol", ArgumentSemantic.Retain)]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'ProtocolConfiguration' instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 11, message: "Use 'ProtocolConfiguration' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'ProtocolConfiguration' instead.")]
		NEVpnProtocol Protocol { get; set; }

		/// <summary>Gets or sets the protocol configuration for the VPN tunnel.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed]
		[Export ("protocolConfiguration", ArgumentSemantic.Retain)]
		NEVpnProtocol ProtocolConfiguration { get; set; }

		/// <summary>Gets the VPN connection.</summary>
		[Export ("connection")]
		NEVpnConnection Connection { get; }

		/// <summary>Gets or sets a Boolean value that controls whether the VPN configuration is valid.</summary>
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		/// <summary>Gets the shared VPN manager instance.</summary>
		[Static, Export ("sharedManager")]
		NEVpnManager SharedManager { get; }

		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Loads the saved VPN configuration from the Network Extension preferences and runs a completion handler when the operation completes.</summary>
		[Export ("loadFromPreferencesWithCompletionHandler:")]
		[Async]
		void LoadFromPreferences (Action<NSError> completionHandler); // nonnull !

		/// <param name="completionHandler">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Removes the configuration for this VPN manager from the Network Extension preferences and runs a completion handler when the operation completes.</summary>
		[Export ("removeFromPreferencesWithCompletionHandler:")]
		[Async]
		void RemoveFromPreferences ([NullAllowed] Action<NSError> completionHandler);

		/// <param name="completionHandler">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Saves the configuration for this VPN manager to the Network Extension preferences and runs a completion handler when the operation completes.</summary>
		[Export ("saveToPreferencesWithCompletionHandler:")]
		[Async]
		void SaveToPreferences ([NullAllowed] Action<NSError> completionHandler);

		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Internal]
		[Export ("setAuthorization:")]
		void _SetAuthorization (IntPtr auth);

		[Notification]
		[Field ("NEVPNConfigurationChangeNotification")]
		NSString ConfigurationChangeNotification { get; }
	}

	/// <summary>Represents a Virtual Private Network connection</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEVPNConnectionClassRef/index.html">Apple documentation for <c>NEVPNConnection</c></related>
	[MacCatalyst (13, 1), TV (17, 0)]
	[BaseType (typeof (NSObject), Name = "NEVPNConnection")]
	interface NEVpnConnection {

		/// <summary>Gets the date and time when the VPN connected.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("connectedDate")]
		NSDate ConnectedDate { get; }

		/// <summary>Gets the VPN connection status.</summary>
		[Export ("status")]
		NEVpnStatus Status { get; }

		/// <param name="error">The error, or null if none.</param>
		///         <summary>Begins connecting the VPN.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("startVPNTunnelAndReturnError:")]
		bool StartVpnTunnel (out NSError error);

		[MacCatalyst (13, 1)]
		[Internal]
		[Export ("startVPNTunnelWithOptions:andReturnError:")]
		bool StartVpnTunnel ([NullAllowed] NSDictionary options, out NSError error);

		/// <param name="options">The options dictionary.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Begins connecting the VPN.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Wrap ("StartVpnTunnel (options.GetDictionary (), out error);")]
		bool StartVpnTunnel ([NullAllowed] NEVpnConnectionStartOptions options, out NSError error);

		/// <summary>Begins disconnecting the VPN.</summary>
		[Export ("stopVPNTunnel")]
		void StopVpnTunnel ();

		/// <summary>Gets the VPN manager.</summary>
		[MacCatalyst (13, 1)]
		[Export ("manager")]
		NEVpnManager Manager { get; }

		[Notification]
		[Field ("NEVPNStatusDidChangeNotification")]
		NSString StatusDidChangeNotification { get; }

		[Async]
		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0)]
		[Export ("fetchLastDisconnectErrorWithCompletionHandler:")]
		void FetchLastDisconnectError (Action<NSError> handler);
	}

	[Static]
	[Internal]
	[MacCatalyst (13, 1)]
	interface NEVpnConnectionStartOptionInternal {
		[Field ("NEVPNConnectionStartOptionPassword")]
		NSString Password { get; }

		[Field ("NEVPNConnectionStartOptionUsername")]
		NSString Username { get; }
	}

	/// <summary>Holds protocol information for VPN connections</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEVPNProtocolClassRef/index.html">Apple documentation for <c>NEVPNProtocol</c></related>
	[MacCatalyst (13, 1)]
	[Abstract]
	[BaseType (typeof (NSObject), Name = "NEVPNProtocol")]
	interface NEVpnProtocol : NSCopying, NSSecureCoding {

		/// <summary>Gets or sets the tunneling server address.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("serverAddress")]
		string ServerAddress { get; set; }

		/// <summary>Gets or sets the user name.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("username")]
		string Username { get; set; }

		/// <summary>Gets or sets a reference to the keychain item for the password.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("passwordReference", ArgumentSemantic.Copy)]
		NSData PasswordReference { get; set; }

		/// <summary>Gets or sets a reference to the keychain item for the PKCS12 tunneling credential.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("identityReference", ArgumentSemantic.Copy)]
		NSData IdentityReference { get; set; }

		/// <summary>Gets or sets the private key and certificate data for the tunnel as PKCS12 formatted data.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("identityData", ArgumentSemantic.Copy)]
		NSData IdentityData { get; set; }

		/// <summary>Gets or sets the password for the PKCS12 data in the IdentityDatAProperty</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("identityDataPassword")]
		string IdentityDataPassword { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the VPN should disconnect when the device sleeps.</summary>
		[Export ("disconnectOnSleep")]
		bool DisconnectOnSleep { get; set; }

		/// <summary>Gets or sets the proxy settings for HTTPS and HTTP connections through the VPN tunnel.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("proxySettings", ArgumentSemantic.Copy)]
		NEProxySettings ProxySettings { get; set; }

		[iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("includeAllNetworks")]
		bool IncludeAllNetworks { get; set; }

		[iOS (14, 2)]
		[MacCatalyst (14, 2)]
		[Export ("excludeLocalNetworks")]
		bool ExcludeLocalNetworks { get; set; }

		[NoTV, Mac (13, 3), iOS (16, 4), MacCatalyst (16, 4)]
		[Export ("excludeCellularServices")]
		bool ExcludeCellularServices { get; set; }

		[NoTV, Mac (13, 3), iOS (16, 4), MacCatalyst (16, 4)]
		[Export ("excludeAPNs")]
		bool ExcludeApns { get; set; }

		[NoTV, Mac (14, 4), iOS (17, 4), MacCatalyst (17, 4)]
		[Export ("excludeDeviceCommunication")]
		bool ExcludeDeviceCommunication { get; set; }

		[Mac (11, 0)]
		[iOS (14, 2)]
		[MacCatalyst (14, 2)]
		[Export ("enforceRoutes")]
		bool EnforceRoutes { get; set; }

		[NoTV, NoMac, iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("sliceUUID", ArgumentSemantic.Copy), NullAllowed]
		string SliceUuid { get; set; }
	}

	/// <summary>IPSec protocol information for VPN connections</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEVPNProtocolIPSecClassRef/index.html">Apple documentation for <c>NEVPNProtocolIPSec</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEVpnProtocol), Name = "NEVPNProtocolIPSec")]
	interface NEVpnProtocolIpSec {

		/// <summary>Gets or sets the method for IPSec server authentication.</summary>
		[Export ("authenticationMethod")]
		NEVpnIkeAuthenticationMethod AuthenticationMethod { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether to use extended negotiation.</summary>
		[Export ("useExtendedAuthentication")]
		bool UseExtendedAuthentication { get; set; }

		/// <summary>Gets or sets a reference to the IKE shared secret in the keychain.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("sharedSecretReference", ArgumentSemantic.Copy)]
		NSData SharedSecretReference { get; set; }

		/// <summary>Gets or sets the local device for authentication.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("localIdentifier")]
		string LocalIdentifier { get; set; }

		/// <summary>Gets or sets the identifier IPSec server.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("remoteIdentifier")]
		string RemoteIdentifier { get; set; }
	}

	/// <summary>Holds the parameters for IKEv2 Security Association.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEVPNIKEv2SecurityAssociationParametersClassRef/index.html">Apple documentation for <c>NEVPNIKEv2SecurityAssociationParameters</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Name = "NEVPNIKEv2SecurityAssociationParameters")]
#if XAMCORE_5_0
	interface NEVpnIkev2SecurityAssociationParameters : NSSecureCoding, NSCopying {
#else
	interface NEVpnIke2SecurityAssociationParameters : NSSecureCoding, NSCopying {
#endif

		/// <summary>Gets or sets the encryption algorithm for the Security Association.</summary>
		[Export ("encryptionAlgorithm")]
		NEVpnIke2EncryptionAlgorithm EncryptionAlgorithm { get; set; }

		/// <summary>Gets or sets the integrity algorithm for the Security Association.</summary>
		[Export ("integrityAlgorithm")]
		NEVpnIke2IntegrityAlgorithm IntegrityAlgorithm { get; set; }

		/// <summary>Gets or sets the Security Association's Diffie Hellman group.</summary>
		[Export ("diffieHellmanGroup")]
		NEVpnIke2DiffieHellman DiffieHellmanGroup { get; set; }

		/// <summary>Gets or sets the Security Association's lifetime, in minutes.</summary>
		[Export ("lifetimeMinutes")]
		int LifetimeMinutes { get; set; } /* int32_t */

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("postQuantumKeyExchangeMethods", ArgumentSemantic.Copy)]
		[BindAs (typeof (NEVpnIkev2PostQuantumKeyExchangeMethod []))]
		NSNumber [] PostQuantumKeyExchangeMethods { get; set; }
	}

	/// <summary>IKEv2 protocol information for VPN connections</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEVPNProtocolIKEv2ClassRef/index.html">Apple documentation for <c>NEVPNProtocolIKEv2</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEVpnProtocolIpSec), Name = "NEVPNProtocolIKEv2")]
#if XAMCORE_5_0
	interface NEVpnProtocolIkev2 {
#else
	interface NEVpnProtocolIke2 {
#endif

		/// <summary>Gets or sets the rate at which the IKEv2 client will attempt to detect dead peers.</summary>
		[Export ("deadPeerDetectionRate")]
		NEVpnIke2DeadPeerDetectionRate DeadPeerDetectionRate { get; set; }

		/// <summary>Gets or sets the common name of issuer of the server certificate.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("serverCertificateIssuerCommonName")]
		string ServerCertificateIssuerCommonName { get; set; }

		/// <summary>Gets or sets the common name of the server certificate.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("serverCertificateCommonName")]
		string ServerCertificateCommonName { get; set; }

		/// <summary>Gets the security association parameters for the initial negotiation with the IKEv2 server.</summary>
		[Export ("IKESecurityAssociationParameters")]
		NEVpnIke2SecurityAssociationParameters IKESecurityAssociationParameters { get; }

		/// <summary>Gets the security association parameters for child IPSec security associations that will be negotiated with the IKEv2 server.</summary>
		[Export ("childSecurityAssociationParameters")]
		NEVpnIke2SecurityAssociationParameters ChildSecurityAssociationParameters { get; }

		/// <summary>Gets or sets the certificate type.</summary>
		[MacCatalyst (13, 1)]
		[Export ("certificateType")]
		NEVpnIke2CertificateType CertificateType { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether to use the internal subnets that are sent by the IKEv2 server.</summary>
		[MacCatalyst (13, 1)]
		[Export ("useConfigurationAttributeInternalIPSubnet")]
		bool UseConfigurationAttributeInternalIPSubnet { get; set; }

		/// <summary>Gets or sets a Boolean value that enables and disables MOBIKE.</summary>
		[MacCatalyst (13, 1)]
		[Export ("disableMOBIKE")]
		bool DisableMobike { get; set; }

		/// <summary>Gets or sets a Boolean value that enables and disables redirects by IKEv2.</summary>
		[MacCatalyst (13, 1)]
		[Export ("disableRedirect")]
		bool DisableRedirect { get; set; }

		/// <summary>Gets or sets a Boolean value that enables and disables Perfect Forward Secrecy.</summary>
		[MacCatalyst (13, 1)]
		[Export ("enablePFS")]
		bool EnablePfs { get; set; }

		/// <summary>Gets or sets a Boolean value that enables and disables revocation checking.</summary>
		[MacCatalyst (13, 1)]
		[Export ("enableRevocationCheck")]
		bool EnableRevocationCheck { get; set; }

		/// <summary>Gets or sets a Boolean value that enables or disables strict revocation checks.</summary>
		[MacCatalyst (13, 1)]
		[Export ("strictRevocationCheck")]
		bool StrictRevocationCheck { get; set; }

		/// <summary>Gets or sets the MinimumTlsVersion value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("minimumTLSVersion", ArgumentSemantic.Assign)]
		NEVpnIkev2TlsVersion MinimumTlsVersion { get; set; }

		/// <summary>Gets or sets the MaximumTlsVersion value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("maximumTLSVersion", ArgumentSemantic.Assign)]
		NEVpnIkev2TlsVersion MaximumTlsVersion { get; set; }

		[NoMac]
		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("enableFallback")]
		bool EnableFallback { get; set; }

		[iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("mtu")]
		nuint Mtu { get; set; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("ppkConfiguration", ArgumentSemantic.Copy), NullAllowed]
		NEVpnIkev2PpkConfiguration PpkConfiguration { get; set; }

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("allowPostQuantumKeyExchangeFallback")]
		bool AllowPostQuantumKeyExchangeFallback { get; set; }
	}

	/// <summary>Subclasses define rules for automatic connection to VPNs.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEOnDemandRuleClassRef/index.html">Apple documentation for <c>NEOnDemandRule</c></related>
	[MacCatalyst (13, 1)]
	[Abstract]
	[BaseType (typeof (NSObject))]
	interface NEOnDemandRule : NSSecureCoding, NSCopying {

		/// <summary>Gets the action for the rule</summary>
		[Export ("action")]
		NEOnDemandRuleAction Action { get; }

		/// <summary>Gets or sets the DNS search domains to match.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("DNSSearchDomainMatch")]
		string [] DnsSearchDomainMatch { get; set; }

		/// <summary>Gets or sets the DNS server addresses to match.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("DNSServerAddressMatch")]
		string [] DnsServerAddressMatch { get; set; }

		/// <summary>Gets or sets the interface type to match.</summary>
		[Export ("interfaceTypeMatch")]
		NEOnDemandRuleInterfaceType InterfaceTypeMatch { get; set; }

		/// <summary>Gets or sets the SSID to match.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("SSIDMatch")]
		string [] SsidMatch { get; set; }

		/// <summary>Gets or sets the URL at which to probe for an expected resource when the rule matches.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("probeURL", ArgumentSemantic.Copy)]
		NSUrl ProbeUrl { get; set; }
	}

	/// <summary>An <see cref="NetworkExtension.NEOnDemandRule" /> whose <see cref="NetworkExtension.NEOnDemandRule.Action" /> is <see cref="NetworkExtension.NEOnDemandRuleAction.Connect" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEOnDemandRuleConnectClassRef/index.html">Apple documentation for <c>NEOnDemandRuleConnect</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEOnDemandRule))]
	interface NEOnDemandRuleConnect {
	}

	/// <summary>An <see cref="NetworkExtension.NEOnDemandRule" /> whose <see cref="NetworkExtension.NEOnDemandRule.Action" /> is <see cref="NetworkExtension.NEOnDemandRuleAction.Disconnect" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEOnDemandRuleDisconnectClassRef/index.html">Apple documentation for <c>NEOnDemandRuleDisconnect</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEOnDemandRule))]
	interface NEOnDemandRuleDisconnect {
	}

	/// <summary>An <see cref="NetworkExtension.NEOnDemandRule" /> whose <see cref="NetworkExtension.NEOnDemandRule.Action" /> is <see cref="NetworkExtension.NEOnDemandRuleAction.Ignore" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEOnDemandRuleIgnoreClassRef/index.html">Apple documentation for <c>NEOnDemandRuleIgnore</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEOnDemandRule))]
	interface NEOnDemandRuleIgnore {
	}

	/// <summary>An <see cref="NetworkExtension.NEOnDemandRule" /> whose <see cref="NetworkExtension.NEOnDemandRule.Action" /> is <see cref="NetworkExtension.NEOnDemandRuleAction.EvaluateConnection" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEOnDemandRuleEvaluateConnectionClassRef/index.html">Apple documentation for <c>NEOnDemandRuleEvaluateConnection</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEOnDemandRule))]
	interface NEOnDemandRuleEvaluateConnection {

		/// <summary>Gets or sets the connection rules.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("connectionRules", ArgumentSemantic.Copy)]
		NEEvaluateConnectionRule [] ConnectionRules { get; set; }
	}

	/// <summary>Creates a connection between properties of a connection and an action to be taken.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEEvaluateConnectionRuleClassRef/index.html">Apple documentation for <c>NEEvaluateConnectionRule</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEEvaluateConnectionRule : NSSecureCoding, NSCopying {

		/// <param name="domains">The array of domains.</param>
		/// <param name="action">The action to take.</param>
		/// <summary>Creates a new connection rule for the provided domains and action.</summary>
		[Export ("initWithMatchDomains:andAction:")]
		NativeHandle Constructor (string [] domains, NEEvaluateConnectionRuleAction action);

		/// <summary>Gets the action to run when the network connection properties satisfy the rule for a new connection.</summary>
		[Export ("action")]
		NEEvaluateConnectionRuleAction Action { get; }

		/// <summary>The domains for which to run the rule.</summary>
		[Export ("matchDomains")]
		string [] MatchDomains { get; }

		/// <summary>Gets an array of DNS server names to use for resolving the destination hostname when evaluating connectivity, if the rule is <see cref="NetworkExtension.NEEvaluateConnectionRuleAction.ConnectIfNeeded" /></summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("useDNSServers", ArgumentSemantic.Copy)]
		string [] UseDnsServers { get; set; }

		/// <summary>A URL for which to start a VPN if a non-success HTTP code is returned, if the rule is <see cref="NetworkExtension.NEEvaluateConnectionRuleAction.ConnectIfNeeded" />.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("probeURL", ArgumentSemantic.Copy)]
		NSUrl ProbeUrl { get; set; }
	}

	/// <summary>Base class for descriptions of network resources.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NWEndpointClassRef/index.html">Apple documentation for <c>NWEndpoint</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Abstract]
	[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWEndpoint' instead.")]
	[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWEndpoint' instead.")]
	[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWEndpoint' instead.")]
	[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWEndpoint' instead.")]
	interface NWEndpoint : NSSecureCoding, NSCopying {
	}

	/// <summary>Description of a network endpoint that is identified by its hostname.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NWHostEndpointClassRef/index.html">Apple documentation for <c>NWHostEndpoint</c></related>
	[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWEndpoint' instead.")]
	[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWEndpoint' instead.")]
	[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWEndpoint' instead.")]
	[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWEndpoint' instead.")]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NWEndpoint))]
	[DisableDefaultCtor]
	interface NWHostEndpoint {
		/// <param name="hostname">The hostname.</param>
		///         <param name="port">The port number.</param>
		///         <summary>Creates and returns a new host endpoint with the provided values.</summary>
		///         <returns>The result of the operation.</returns>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWEndpoint.Create' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWEndpoint.Create' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWEndpoint.Create' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWEndpoint.Create' instead.")]
		[Static]
		[Export ("endpointWithHostname:port:")]
		NWHostEndpoint Create (string hostname, string port);

		/// <summary>Gets the host name.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWEndpoint.Hostname' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWEndpoint.Hostname' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWEndpoint.Hostname' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWEndpoint.Hostname' instead.")]
		[Export ("hostname")]
		string Hostname { get; }

		/// <summary>Gets the port.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWEndpoint.PortNumber' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWEndpoint.PortNumber' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWEndpoint.PortNumber' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWEndpoint.PortNumber' instead.")]
		[Export ("port")]
		string Port { get; }
	}

	/// <summary>Description of a Bonjour service endpoint.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NWBonjourServiceEndpointClassRef/index.html">Apple documentation for <c>NWBonjourServiceEndpoint</c></related>
	[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWEndpoint' instead.")]
	[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWEndpoint' instead.")]
	[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWEndpoint' instead.")]
	[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWEndpoint' instead.")]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NWEndpoint))]
	[DisableDefaultCtor]
	interface NWBonjourServiceEndpoint {

		/// <param name="name">The name.</param>
		///         <param name="type">The type.</param>
		///         <param name="domain">The domain name.</param>
		///         <summary>Creates and returns a new Bonjour service endpoint with the provided values.</summary>
		///         <returns>The result of the operation.</returns>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWEndpoint.CreateBonjourService' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWEndpoint.CreateBonjourService' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWEndpoint.CreateBonjourService' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWEndpoint.CreateBonjourService' instead.")]
		[Static]
		[Export ("endpointWithName:type:domain:")]
		NWBonjourServiceEndpoint Create (string name, string type, string domain);

		/// <summary>Gets the service name of the Bonjour endpoint.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWEndpoint.BonjourServiceName' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWEndpoint.BonjourServiceName' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWEndpoint.BonjourServiceName' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWEndpoint.BonjourServiceName' instead.")]
		[Export ("name")]
		string Name { get; }

		/// <summary>Gets the type of the Bonjour service.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWEndpoint.BonjourServiceType' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWEndpoint.BonjourServiceType' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWEndpoint.BonjourServiceType' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWEndpoint.BonjourServiceType' instead.")]

		[Export ("type")]
		string Type { get; }

		/// <summary>Gets the Bonjour domain of the endpoint.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWEndpoint.BonjourServiceDomain' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWEndpoint.BonjourServiceDomain' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWEndpoint.BonjourServiceDomain' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWEndpoint.BonjourServiceDomain' instead.")]

		[Export ("domain")]
		string Domain { get; }
	}

	/// <summary>Contains expense and status information about a network connection path.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NWPathClassRef/index.html">Apple documentation for <c>NWPath</c></related>
	[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWPath' instead.")]
	[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWPath' instead.")]
	[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWPath' instead.")]
	[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWPath' instead.")]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NWPath {
		/// <summary>Gets a value that describes the status of the path, such as whether it is ready to be used or is invalid.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWPath.Status' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWPath.Status' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWPath.Status' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWPath.Status' instead.")]
		[Export ("status")]
		NWPathStatus Status { get; }

		/// <summary>Gets a Boolean value that tells whether the path uses an expensive interface, such as a cellular network.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWPath.IsExpensive' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWPath.IsExpensive' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWPath.IsExpensive' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWPath.IsExpensive' instead.")]
		[Export ("expensive")]
		bool Expensive { [Bind ("isExpensive")] get; }

		/// <param name="path">The path string.</param>
		///         <summary>Returns <see langword="true" /> if this path represents the same path as the specified <paramref name="path" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWPath.EqualTo' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWPath.EqualTo' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWPath.EqualTo' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWPath.EqualTo' instead.")]
		[Export ("isEqualToPath:")]
		bool IsEqualToPath (NWPath path);

		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWPath.IsConstrained' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWPath.IsConstrained' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWPath.IsConstrained' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWPath.IsConstrained' instead.")]
		[TV (14, 0), iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("constrained")]
		bool Constrained { [Bind ("isConstrained")] get; }
	}

	/// <summary>Connects to and sends and receives data from TCP network connections.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NWTCPConnectionClassRef/index.html">Apple documentation for <c>NWTCPConnection</c></related>
	[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection' instead.")]
	[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection' instead.")]
	[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection' instead.")]
	[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection' instead.")]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Name = "NWTCPConnection")]
	interface NWTcpConnection {
		/// <param name="connection">The VPN connection.</param>
		/// <summary>Creates a new connection from the provided <paramref name="connection" />.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use the 'Network.NWConnection' constructor instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use the 'Network.NWConnection' constructor instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use the 'Network.NWConnection' constructor instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use the 'Network.NWConnection' constructor instead.")]
		[Export ("initWithUpgradeForConnection:")]
		NativeHandle Constructor (NWTcpConnection connection);

		/// <summary>Gets the state of the connection.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.SetStateChangedHandler' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.SetStateChangedHandler' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.SetStateChangedHandler' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.SetStateChangedHandler' instead.")]
		[Export ("state")]
		NWTcpConnectionState State { get; }

		/// <summary>Gets the TXT record of the connection.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.SetViabilityChangedHandler' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.SetViabilityChangedHandler' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.SetViabilityChangedHandler' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.SetViabilityChangedHandler' instead.")]
		[Export ("viable")]
		bool Viable { [Bind ("isViable")] get; }

		/// <summary>Gets a Boolean value that tells whether new connections to the remote endpoint have a better path available to them..</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.SetBetterPathAvailableHandler' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.SetBetterPathAvailableHandler' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.SetBetterPathAvailableHandler' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.SetBetterPathAvailableHandler' instead.")]
		[Export ("hasBetterPath")]
		bool HasBetterPath { get; }

		/// <summary>Gets the remote endpoint of the connection.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.Endpoint' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.Endpoint' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.Endpoint' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.Endpoint' instead.")]
		[Export ("endpoint")]
		NWEndpoint Endpoint { get; }

		/// <summary>Gets the path through which the connection was made.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.CurrentPath' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.CurrentPath' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.CurrentPath' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.CurrentPath' instead.")]
		[NullAllowed, Export ("connectedPath")]
		NWPath ConnectedPath { get; }

		/// <summary>Gets the address from which the connectio was made.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWPath.EffectiveLocalEndpoint' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWPath.EffectiveLocalEndpoint' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWPath.EffectiveLocalEndpoint' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWPath.EffectiveLocalEndpoint' instead.")]
		[NullAllowed, Export ("localAddress")]
		NWEndpoint LocalAddress { get; }

		/// <summary>Gets the remote endpoint to which the connection was made.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWPath.EffectiveRemoteEndpoint' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWPath.EffectiveRemoteEndpoint' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWPath.EffectiveRemoteEndpoint' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWPath.EffectiveRemoteEndpoint' instead.")]
		[NullAllowed, Export ("remoteAddress")]
		NWEndpoint RemoteAddress { get; }

		/// <summary>Gets the TxtRecord value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWEndpoint.TxtRecord' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWEndpoint.TxtRecord' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWEndpoint.TxtRecord' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWEndpoint.TxtRecord' instead.")]
		[NullAllowed, Export ("txtRecord")]
		NSData TxtRecord { get; }

		/// <summary>Gets the error that caused the connection to fail, if it failed.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.SetStateChangedHandler' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.SetStateChangedHandler' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.SetStateChangedHandler' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.SetStateChangedHandler' instead.")]
		[NullAllowed, Export ("error")]
		NSError Error { get; }

		/// <summary>Cancels the connection.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.Cancel' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.Cancel' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.Cancel' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.Cancel' instead.")]
		[Export ("cancel")]
		void Cancel ();

		/// <param name="length">The data length.</param>
		/// <param name="completion">The completion handler.</param>
		/// <summary>Reads the specified number of bytes from the connection.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.Receive' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.Receive' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.Receive' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.Receive' instead.")]
		[Export ("readLength:completionHandler:")]
		[Async (XmlDocs = """
			<param name="length">The data length.</param>
			<summary>Reads the specified length asynchronously.</summary>
			<returns>
			          <para>A task that represents the asynchronous ReadLength operation.   The value of the TResult parameter is a System.nuint.</para>
			        </returns>
			""")]
		void ReadLength (nuint length, Action<NSData, NSError> completion);

		/// <param name="minimum">The minimum length.</param>
		/// <param name="maximum">The maximum length.</param>
		/// <param name="completion">The completion handler.</param>
		/// <summary>Reads between the minimum and maximum number of bytes.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.Receive' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.Receive' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.Receive' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.Receive' instead.")]
		[Export ("readMinimumLength:maximumLength:completionHandler:")]
		[Async (XmlDocs = """
			<param name="minimum">The minimum length.</param>
			<param name="maximum">The maximum length.</param>
			<summary>Reads between the minimum and maximum length asynchronously.</summary>
			<returns>
			          <para>A task that represents the asynchronous ReadMinimumLength operation.   The value of the TResult parameter is a System.nuint.</para>
			        </returns>
			""")]
		void ReadMinimumLength (nuint minimum, nuint maximum, Action<NSData, NSError> completion);

		/// <param name="data">The data.</param>
		///         <param name="completion">The completion handler.</param>
		///         <summary>Writes the provided <paramref name="data" /> to the connection and runs a completion handler when the operation completes.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Export ("write:completionHandler:")]
		[Async (XmlDocs = """
			<param name="data">The data.</param>
			<summary>Writes the provided <paramref name="data" /> to the connection and runs a completion handler when the operation completes.</summary>
			<returns>A task that represents the asynchronous Write operation</returns>
			<remarks>
			          <para copied="true">The WriteAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void Write (NSData data, Action<NSError> completion);

		/// <summary>Closes the connection for write operations.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Export ("writeClose")]
		void WriteClose ();
	}

	interface INWTcpConnectionAuthenticationDelegate { }

	[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Security.SecProtocolOptions' instead.")]
	[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Security.SecProtocolOptions' instead.")]
	[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Security.SecProtocolOptions' instead.")]
	[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Security.SecProtocolOptions' instead.")]
	[MacCatalyst (13, 1)]
	[Protocol, Model]
	[BaseType (typeof (NSObject), Name = "NWTCPConnectionAuthenticationDelegate")]
	interface NWTcpConnectionAuthenticationDelegate {
		/// <param name="connection">The VPN connection.</param>
		///         <summary>Method that is called to inform the delegate that it should provide identity information.</summary>
		///         <returns>
		///           <see langword="true" /> to indicate that the delegate will provide identity information.</returns>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[Export ("shouldProvideIdentityForConnection:")]
		bool ShouldProvideIdentity (NWTcpConnection connection);

		/// <param name="connection">The VPN connection.</param>
		///         <param name="completion">The completion handler.</param>
		///         <summary>Method that is called to provide an identity and an optional certificate.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[Export ("provideIdentityForConnection:completionHandler:")]
		void ProvideIdentity (NWTcpConnection connection, Action<SecIdentity, NSArray> completion);

		/// <param name="connection">The VPN connection.</param>
		///         <summary>Method that is called to inform the delegate that it should evaluate trust.</summary>
		///         <returns>
		///           <see langword="true" /> to indicate that the delegate will evaluate trust.</returns>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[Export ("shouldEvaluateTrustForConnection:")]
		bool ShouldEvaluateTrust (NWTcpConnection connection);


		/// <param name="connection">The VPN connection.</param>
		///         <param name="peerCertificateChain">The peer certificate chain.</param>
		///         <param name="completion">The completion handler.</param>
		///         <summary>When implemented by the developer, overrides the default trust evaluation and runs a completion handler when the operation is complete.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[Export ("evaluateTrustForConnection:peerCertificateChain:completionHandler:")]
		[Async (XmlDocs = """
			<param name="connection">The VPN connection.</param>
			<param name="peerCertificateChain">The peer certificate chain.</param>
			<summary>When implemented by the developer, overrides the default trust evaluation and runs a completion handler when the operation is complete.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous EvaluateTrust operation.  The value of the TResult parameter is of type System.Action&lt;Security.SecTrust&gt;.</para>
			        </returns>
			<remarks>
			          <para copied="true">The EvaluateTrustAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void EvaluateTrust (NWTcpConnection connection, NSArray peerCertificateChain, Action<SecTrust> completion);
		// note: it's not clear (from headers) but based on other API it's likely to accept a mix of SecIdentity
		// and SecCertificate - both *NOT* NSObject -> because of that NSArray is used above
	}

	/// <summary>Contains transport layer security options.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NWTLSParametersClassRef/index.html">Apple documentation for <c>NWTLSParameters</c></related>
	[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Security.SecProtocolOptions' instead.")]
	[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Security.SecProtocolOptions' instead.")]
	[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Security.SecProtocolOptions' instead.")]
	[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Security.SecProtocolOptions' instead.")]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Name = "NWTLSParameters")]
	interface NWTlsParameters {
		/// <summary>Gets the session identifier of the TCP connection.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetTlsResumptionEnabled' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Security.SecProtocolOptions.SetTlsResumptionEnabled' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Security.SecProtocolOptions.SetTlsResumptionEnabled' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetTlsResumptionEnabled' instead.")]
		[NullAllowed, Export ("TLSSessionID", ArgumentSemantic.Copy)]
		NSData TlsSessionID { get; set; }

		/// <summary>Gets or sets an array of cipher suites to use for TLS.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Security.SecProtocolOptions.AddTlsCipherSuite' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Security.SecProtocolOptions.AddTlsCipherSuite' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Security.SecProtocolOptions.AddTlsCipherSuite' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Security.SecProtocolOptions.AddTlsCipherSuite' instead.")]
		[NullAllowed, Export ("SSLCipherSuites", ArgumentSemantic.Copy)]
		NSSet<NSNumber> SslCipherSuites { get; set; }

		/// <summary>Gets or sets the minimum allowed SSL protocol version.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetTlsMinVersion' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Security.SecProtocolOptions.SetTlsMinVersion' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Security.SecProtocolOptions.SetTlsMinVersion' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetTlsMinVersion' instead.")]
		[Export ("minimumSSLProtocolVersion", ArgumentSemantic.Assign)]
		nuint MinimumSslProtocolVersion { get; set; }

		/// <summary>Gets or sets the maximum allowed SSL protocol version.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetTlsMaxVersion' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Security.SecProtocolOptions.SetTlsMaxVersion' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Security.SecProtocolOptions.SetTlsMaxVersion' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Security.SecProtocolOptions.SetTlsMaxVersion' instead.")]
		[Export ("maximumSSLProtocolVersion", ArgumentSemantic.Assign)]
		nuint MaximumSslProtocolVersion { get; set; }
	}

	/// <summary>Establishes a UDP connection and and transmits UDP datAPackets.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NWUDPSessionClassRef/index.html">Apple documentation for <c>NWUDPSession</c></related>
	[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection' instead.")]
	[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection' instead.")]
	[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection' instead.")]
	[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection' instead.")]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Name = "NWUDPSession")]
	interface NWUdpSession {
		/// <param name="session">The VPN session.</param>
		/// <summary>Creates a new UDP session from an existing session.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use the 'Network.NWConnection' constructor instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use the 'Network.NWConnection' constructor instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use the 'Network.NWConnection' constructor instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use the 'Network.NWConnection' constructor instead.")]
		[Export ("initWithUpgradeForSession:")]
		NativeHandle Constructor (NWUdpSession session);

		/// <summary>Gets the UDP session state.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.SetStateChangedHandler' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.SetStateChangedHandler' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.SetStateChangedHandler' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.SetStateChangedHandler' instead.")]
		[Export ("state")]
		NWUdpSessionState State { get; }

		/// <summary>Gets the endpoint that was used to create the UDP session.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.Endpoint' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.Endpoint' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.Endpoint' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.Endpoint' instead.")]
		[Export ("endpoint")]
		NWEndpoint Endpoint { get; }

		/// <summary>Gets the current remote endpoint.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.CurrentPath' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.CurrentPath' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.CurrentPath' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.CurrentPath' instead.")]
		[NullAllowed, Export ("resolvedEndpoint")]
		NWEndpoint ResolvedEndpoint { get; }

		/// <summary>Gets a Boolean value that tells whether the session can transfer data.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.SetViabilityChangedHandler' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.SetViabilityChangedHandler' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.SetViabilityChangedHandler' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.SetViabilityChangedHandler' instead.")]
		[Export ("viable")]
		bool Viable { [Bind ("isViable")] get; }

		/// <summary>Get a Boolean value that tells whether new UDP sessions have a better path available to them.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.SetBetterPathAvailableHandler' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.SetBetterPathAvailableHandler' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.SetBetterPathAvailableHandler' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.SetBetterPathAvailableHandler' instead.")]
		[Export ("hasBetterPath")]
		bool HasBetterPath { get; }

		/// <summary>Gets the current path to the resolved endpoint.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.CurrentPath' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.CurrentPath' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.CurrentPath' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.CurrentPath' instead.")]
		[NullAllowed, Export ("currentPath")]
		NWPath CurrentPath { get; }

		/// <summary>Mark the current endpoint unusable and try to connect to the next one.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.CancelCurrentEndpoint' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.CurrentPath' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.CancelCurrentEndpoint' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.CancelCurrentEndpoint' instead.")]
		[Export ("tryNextResolvedEndpoint")]
		void TryNextResolvedEndpoint ();

		/// <summary>Gets the maximum write length, in bytes, of datagrams.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.MaximumDatagramSize' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.MaximumDatagramSize' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.MaximumDatagramSize' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.MaximumDatagramSize' instead.")]
		[Export ("maximumDatagramLength")]
		nuint MaximumDatagramLength { get; }

		/// <param name="handler">The completion handler.</param>
		/// <param name="maxDatagrams">The maximum number of datagrams.</param>
		/// <summary>Assigns a handler that will read, at most, <paramref name="maxDatagrams" />.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.Receive' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.Receive' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.Receive' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.Receive' instead.")]
		[Export ("setReadHandler:maxDatagrams:")]
		void SetReadHandler (Action<NSArray, NSError> handler, nuint maxDatagrams);

		/// <param name="datagramArray">The array of datagrams.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Writes the datagrams in the provided <paramref name="datagramArray" /> to the endpoint, and runs a completion handler when the operation completes.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Export ("writeMultipleDatagrams:completionHandler:")]
		[Async (XmlDocs = """
			<param name="datagramArray">The array of datagrams.</param>
			<summary>Writes the datagrams in the provided <paramref name="datagramArray" /> to the endpoint, and runs a completion handler when the operation completes.</summary>
			<returns>A task that represents the asynchronous WriteMultipleDatagrams operation</returns>
			""")]
		void WriteMultipleDatagrams (NSData [] datagramArray, Action<NSError> completionHandler);

		/// <param name="datagram">The datagram.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Writes the provided <paramref name="datagram" /> to the endpoint, and runs a completion handler when the operation completes.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.Send' instead.")]
		[Export ("writeDatagram:completionHandler:")]
		[Async (XmlDocs = """
			<param name="datagram">The datagram.</param>
			<summary>Writes the provided <paramref name="datagram" /> to the endpoint, and runs a completion handler when the operation completes.</summary>
			<returns>A task that represents the asynchronous WriteDatagram operation</returns>
			<remarks>
			          <para copied="true">The WriteDatagramAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void WriteDatagram (NSData datagram, Action<NSError> completionHandler);

		/// <summary>Cancels the UDP session.</summary>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'Network.NWConnection.Cancel' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'Network.NWConnection.Cancel' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'Network.NWConnection.Cancel' instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'Network.NWConnection.Cancel' instead.")]
		[Export ("cancel")]
		void Cancel ();
	}

	/// <summary>Contains information about a WebKit browser network data flow.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterBrowserFlowClassRef/index.html">Apple documentation for <c>NEFilterBrowserFlow</c></related>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEFilterFlow))]
	interface NEFilterBrowserFlow {

		/// <summary>The HTTP request.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("request")]
		NSUrlRequest Request { get; }

		/// <summary>The HTTP response.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("response")]
		[NullAllowed]
		NSUrlResponse Response { get; }

		/// <summary>Gets the URL of the page for which the flow was created.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("parentURL")]
		[NullAllowed]
		NSUrl ParentUrl { get; }
	}

	/// <summary>Contains information about network data flow over a socket.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterSocketFlowClassRef/index.html">Apple documentation for <c>NEFilterSocketFlow</c></related>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEFilterFlow))]
	interface NEFilterSocketFlow {
		/// <summary>Gets the RemoteEndpoint value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		///         <remarks>Gets the remote endpoint of the socket.</remarks>
		[NullAllowed]
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'RemoteFlowEndpoint' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'RemoteFlowEndpoint' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'RemoteFlowEndpoint' instead.")]
		[Export ("remoteEndpoint")]
		NWEndpoint RemoteEndpoint { get; }

		/// <summary>Gets the local endpoint of the socket.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'LocalFlowEndpoint' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'LocalFlowEndpoint' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'LocalFlowEndpoint' instead.")]
		[Export ("localEndpoint")]
		NWEndpoint LocalEndpoint { get; }

		/// <summary>Gets or sets the socket protocol family.</summary>
		[Export ("socketFamily")]
		int SocketFamily {
			get;
		}

		/// <summary>Gets or sets the socket type.</summary>
		[Export ("socketType")]
		int SocketType {
			get;
		}

		/// <summary>Gets or sets the socket protocol.</summary>
		[Export ("socketProtocol")]
		int SocketProtocol {
			get;
		}

		[NullAllowed]
		[NoTV, iOS (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("remoteHostname")]
		string RemoteHostname { get; }

		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("localFlowEndpoint"), NullAllowed]
		Network.NWEndpoint LocalFlowEndpoint { get; }

		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("remoteFlowEndpoint"), NullAllowed]
		Network.NWEndpoint RemoteFlowEndpoint { get; }
	}

	/// <summary>A reporting action taken on a filtered data flow.</summary>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEFilterReport : NSSecureCoding, NSCopying {

		/// <summary>Gets the Flow value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("flow")]
		NEFilterFlow Flow { get; }

		/// <summary>Gets the Action value.</summary>
		[Export ("action")]
		NEFilterAction Action { get; }

		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("event")]
		NEFilterReportEvent Event { get; }

		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("bytesInboundCount")]
		nuint BytesInboundCount { get; }

		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("bytesOutboundCount")]
		nuint BytesOutboundCount { get; }
	}

	/// <summary>Contains settings for a <see cref="NetworkExtension.NEPacketTunnelFlow" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEPacketTunnelNetworkSettingsClassRef/index.html">Apple documentation for <c>NEPacketTunnelNetworkSettings</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NETunnelNetworkSettings))]
	[DisableDefaultCtor]
	interface NEPacketTunnelNetworkSettings {
		/// <param name="address">The address.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithTunnelRemoteAddress:")]
		NativeHandle Constructor (string address);

		/// <summary>Gets or sets the IPv4 network tunnel settings.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("IPv4Settings", ArgumentSemantic.Copy)]
		[NullAllowed]
		NEIPv4Settings IPv4Settings { get; set; }

		/// <summary>Gets or sets the IPv6 network tunnel settings.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("IPv6Settings", ArgumentSemantic.Copy)]
		[NullAllowed]
		NEIPv6Settings IPv6Settings { get; set; }

		/// <summary>Gets or sets the overhead for storing tunneling protocol headers.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("tunnelOverheadBytes", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSNumber TunnelOverheadBytes { get; set; }

		/// <summary>Gets or sets the Maximum Transmission Unit (MTU) size for the TUN interface, in bytes.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("MTU", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSNumber Mtu { get; set; }
	}

	/// <summary>Provides IO over a TUN interface.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEPacketTunnelFlowClassRef/index.html">Apple documentation for <c>NEPacketTunnelFlow</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEPacketTunnelFlow {
		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Reads packets from the TUN interface and runs a handler when the operation completes.</summary>
		[Export ("readPacketsWithCompletionHandler:")]
		[Async (ResultType = typeof (NEPacketTunnelFlowReadResult), XmlDocs = """
			<summary>Reads packets from the TUN interface and runs a handler when the operation completes.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous ReadPackets operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSData[],Foundation.NSNumber[]&gt;.</para>
			        </returns>
			""")]
		void ReadPackets (Action<NSData [], NSNumber []> completionHandler);

		/// <param name="packets">The array of packets.</param>
		///         <param name="protocols">The array of protocol numbers.</param>
		///         <summary>Performs the write packets operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("writePackets:withProtocols:")]
		bool WritePackets (NSData [] packets, NSNumber [] protocols);

		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Sends a message to the provider and waits for a response.</summary>
		[MacCatalyst (13, 1)]
		[Async (XmlDocs = """
			<summary>Sends a message to the provider asynchronously.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous ReadPacketObjects operation.  The value of the TResult parameter is of type System.Action&lt;NetworkExtension.NEPacket[]&gt;.</para>
			        </returns>
			<remarks>
			          <para copied="true">The ReadPacketObjectsAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		[Export ("readPacketObjectsWithCompletionHandler:")]
		void ReadPacketObjects (Action<NEPacket []> completionHandler);

		/// <param name="packets">The array of packets.</param>
		///         <summary>Performs the write packet objects operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("writePacketObjects:")]
		bool WritePacketObjects (NEPacket [] packets);
	}

	/// <summary>Provides sockets by creating <see cref="NetworkExtension.NEPacketTunnelFlow" /> objects.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEPacketTunnelProviderClassRef/index.html">Apple documentation for <c>NEPacketTunnelProvider</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NETunnelProvider))]
	interface NEPacketTunnelProvider {
		/// <param name="options">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Starts the tunnel.</summary>
		[Export ("startTunnelWithOptions:completionHandler:")]
		[Async (XmlDocs = """
			<param name="options">The options dictionary.</param>
			<summary>Starts the tunnel.</summary>
			<returns>A task that represents the asynchronous StartTunnel operation</returns>
			""")]
		void StartTunnel ([NullAllowed] NSDictionary<NSString, NSObject> options, Action<NSError> completionHandler);

		/// <param name="reason">The reason for the failure.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Stops the Tunnel.</summary>
		[Export ("stopTunnelWithReason:completionHandler:")]
		[Async (XmlDocs = """
			<param name="reason">The reason for the failure.</param>
			<summary>Stops the Tunnel.</summary>
			<returns>A task that represents the asynchronous StopTunnel operation</returns>
			<remarks>
			          <para copied="true">The StopTunnelAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		void StopTunnel (NEProviderStopReason reason, Action completionHandler);

		/// <param name="error">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Cancels the tunnel with the specified error.</summary>
		[Export ("cancelTunnelWithError:")]
		void CancelTunnel ([NullAllowed] NSError error);

		/// <summary>Gets the packet flow that receives IP packets and injects IP packets into the network.</summary>
		[Export ("packetFlow")]
		NEPacketTunnelFlow PacketFlow { get; }

		/// <param name="remoteEndpoint">The remote endpoint for the connection.</param>
		///         <param name="enableTls">Whether TLS is enabled.</param>
		///         <param name="tlsParameters">
		///           <para>TLS parameters, if TLS is enabled.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="delegate">
		///           <para>Handler to run when the connection is created.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Creates a new tunneled TCP connection.</summary>
		///         <returns>The result of the operation.</returns>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'NWParameters.RequiredInterface' with the 'VirtualInterface' property instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'NWParameters.RequiredInterface' with the 'VirtualInterface' property instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'NWParameters.RequiredInterface' with the 'VirtualInterface' property instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'NWParameters.RequiredInterface' with the 'VirtualInterface' property instead.")]
		[Export ("createTCPConnectionThroughTunnelToEndpoint:enableTLS:TLSParameters:delegate:")]
		NWTcpConnection CreateTcpConnection (NWEndpoint remoteEndpoint, bool enableTls, [NullAllowed] NWTlsParameters tlsParameters, [NullAllowed] INWTcpConnectionAuthenticationDelegate @delegate);

		/// <param name="remoteEndpoint">The remote endpoint.</param>
		///         <param name="localEndpoint">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Creates a new tunneled UDP connection.</summary>
		///         <returns>The result of the operation.</returns>
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'NWParameters.RequiredInterface' with the 'VirtualInterface' property instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'NWParameters.RequiredInterface' with the 'VirtualInterface' property instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'NWParameters.RequiredInterface' with the 'VirtualInterface' property instead.")]
		[Deprecated (PlatformName.TvOS, 18, 0, message: "Use 'NWParameters.RequiredInterface' with the 'VirtualInterface' property instead.")]
		[Export ("createUDPSessionThroughTunnelToEndpoint:fromEndpoint:")]
		NWUdpSession CreateUdpSession (NWEndpoint remoteEndpoint, [NullAllowed] NWHostEndpoint localEndpoint);

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("virtualInterface"), NullAllowed]
		NWInterface VirtualInterface { get; }
	}

	/// <summary>Base class for extensions that implement client-side ends of a network tunnel.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NETunnelProviderProtocolClassRef/index.html">Apple documentation for <c>NETunnelProviderProtocol</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEVpnProtocol))]
	interface NETunnelProviderProtocol {
		/// <summary>Gets or sets a dictionary of developer-specified configuration values.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("providerConfiguration", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> ProviderConfiguration { get; set; }

		/// <summary>Gets or sets the bundle identifier for this configuration's tunnel provider extension.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("providerBundleIdentifier")]
		string ProviderBundleIdentifier { get; set; }
	}

	/// <summary>Represents and controls the state of a network tunnel connection.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NETunnelProviderSessionClassRef/index.html">Apple documentation for <c>NETunnelProviderSession</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEVpnConnection))]
	interface NETunnelProviderSession {
		/// <param name="options">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Begins connecting the tunnel.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("startTunnelWithOptions:andReturnError:")]
		bool StartTunnel ([NullAllowed] NSDictionary<NSString, NSObject> options, [NullAllowed] out NSError error);

		/// <summary>Begins disconnecting the tunnel.</summary>
		[Export ("stopTunnel")]
		void StopTunnel ();

		/// <param name="messageData">The message data.</param>
		///         <param name="error">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="responseHandler">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Sends the <paramref name="messageData" /> to the Tunnel Provider extension.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("sendProviderMessage:returnError:responseHandler:")]
		bool SendProviderMessage (NSData messageData, [NullAllowed] out NSError error, [NullAllowed] Action<NSData> responseHandler);
	}

	/// <summary>Provides network extension functionality for NEPacket.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/NetworkExtension/NEPacket">Apple documentation for <c>NEPacket</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEPacket : NSCopying, NSSecureCoding {
		/// <param name="data">The data.</param>
		/// <param name="protocolFamily">The protocol family.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithData:protocolFamily:")]
		NativeHandle Constructor (NSData data, /* sa_family_t */ byte protocolFamily);

		/// <summary>Gets the Data value.</summary>
		[Export ("data", ArgumentSemantic.Copy)]
		NSData Data { get; }

		/// <summary>Gets the ProtocolFamily value.</summary>
		[Export ("protocolFamily")]
		byte ProtocolFamily { get; }

		/// <summary>Gets the Metadata value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NoTV]
		[NullAllowed, Export ("metadata")]
		NEFlowMetaData Metadata { get; }

		[NoTV]
		[NoiOS]
		[MacCatalyst (15, 0)]
		[Export ("direction")]
		NETrafficDirection Direction { get; }
	}

	/// <summary>Encapsulates a DNS proxy.</summary>
	[NoTV]
	[MacCatalyst (13, 1)]
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject), Name = "NEDNSProxyManager")]
	interface NEDnsProxyManager {

		[Notification]
		[Field ("NEDNSProxyConfigurationDidChangeNotification")]
		NSString ProxyConfigurationDidChangeNotification { get; }

		/// <summary>Gets the SharedManager value.</summary>
		[Static]
		[Export ("sharedManager")]
		NEDnsProxyManager SharedManager { get; }

		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Loads all configurations from preferences.</summary>
		[Async (XmlDocs = """
			<summary>Loads all configurations asynchronously.</summary>
			<returns>A task that represents the asynchronous LoadFromPreferences operation</returns>
			""")]
		[Export ("loadFromPreferencesWithCompletionHandler:")]
		void LoadFromPreferences (Action<NSError> completionHandler);

		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Loads the configuration from preferences.</summary>
		[Async (XmlDocs = """
			<summary>Loads the configuration asynchronously.</summary>
			<returns>A task that represents the asynchronous RemoveFromPreferences operation</returns>
			""")]
		[Export ("removeFromPreferencesWithCompletionHandler:")]
		void RemoveFromPreferences (Action<NSError> completionHandler);

		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Removes the configuration from preferences.</summary>
		[Async (XmlDocs = """
			<summary>Removes the configuration asynchronously.</summary>
			<returns>A task that represents the asynchronous SaveToPreferences operation</returns>
			<remarks>
			          <para copied="true">The SaveToPreferencesAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		[Export ("saveToPreferencesWithCompletionHandler:")]
		void SaveToPreferences (Action<NSError> completionHandler);

		/// <summary>Gets or sets the LocalizedDescription value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("localizedDescription")]
		string LocalizedDescription { get; set; }

		/// <summary>Gets or sets the ProviderProtocol value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("providerProtocol", ArgumentSemantic.Strong)]
		NEDnsProxyProviderProtocol ProviderProtocol { get; set; }

		/// <summary>Gets or sets the Enabled value.</summary>
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }
	}

	/// <summary>The main class for intercepting DNS traffic originating on the device.</summary>
	[NoTV]
	[MacCatalyst (13, 1)]
	[DisableDefaultCtor]
	[BaseType (typeof (NEProvider), Name = "NEDNSProxyProvider")]
	interface NEDnsProxyProvider {

		/// <param name="options">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Saves the configuration to preferences.</summary>
		[Async (XmlDocs = """
			<param name="options">The options dictionary.</param>
			<summary>Saves the configuration asynchronously.</summary>
			<returns>A task that represents the asynchronous StartProxy operation</returns>
			""")]
		[Export ("startProxyWithOptions:completionHandler:")]
		void StartProxy ([NullAllowed] NSDictionary options, Action<NSError> completionHandler);

		/// <param name="reason">The reason for the failure.</param>
		///         <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Removes the configuration from preferences.</summary>
		[Async (XmlDocs = """
			<param name="reason">The reason for the failure.</param>
			<summary>Removes the configuration asynchronously.</summary>
			<returns>A task that represents the asynchronous StopProxy operation</returns>
			<remarks>
			          <para copied="true">The StopProxyAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		[Export ("stopProxyWithReason:completionHandler:")]
		void StopProxy (NEProviderStopReason reason, Action completionHandler);

		/// <param name="error">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the cancel proxy operation.</summary>
		[Export ("cancelProxyWithError:")]
		void CancelProxy ([NullAllowed] NSError error);

		/// <param name="flow">The network flow.</param>
		///         <summary>Performs the handle new flow operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("handleNewFlow:")]
		bool HandleNewFlow (NEAppProxyFlow flow);

		/// <summary>Gets the SystemDnsSettings value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("systemDNSSettings")]
		NEDnsSettings [] SystemDnsSettings { get; }

		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("handleNewUDPFlow:initialRemoteEndpoint:")]
		[Deprecated (PlatformName.iOS, 18, 0, message: "Use 'HandleNewUdpFlowWithInitialFlowEndPoint' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 18, 0, message: "Use 'HandleNewUdpFlowWithInitialFlowEndPoint' instead.")]
		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'HandleNewUdpFlowWithInitialFlowEndPoint' instead.")]
		bool HandleNewUdpFlow (NEAppProxyUdpFlow flow, NWEndpoint remoteEndpoint);

		[NoTV, Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("handleNewUDPFlow:initialRemoteFlowEndpoint:")]
		bool HandleNewUdpFlowWithInitialFlowEndPoint (NEAppProxyUdpFlow flow, Network.NWEndpoint remoteEndpoint);
	}

	/// <summary>Configuration settings for <see cref="NetworkExtension.NEDnsProxyProvider" /> objects.</summary>
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NEVpnProtocol), Name = "NEDNSProxyProviderProtocol")]
	interface NEDnsProxyProviderProtocol {

		/// <summary>Gets or sets the ProviderConfiguration value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("providerConfiguration", ArgumentSemantic.Copy)]
		NSDictionary ProviderConfiguration { get; set; }

		/// <summary>Gets or sets the ProviderBundleIdentifier value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("providerBundleIdentifier")]
		string ProviderBundleIdentifier { get; set; }
	}

	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEHotspotHS20Settings : NSCopying, NSSecureCoding {

		/// <summary>Gets the DomainName value.</summary>
		[Export ("domainName")]
		string DomainName { get; }

		/// <summary>Gets or sets the RoamingEnabled value.</summary>
		[Export ("roamingEnabled")]
		bool RoamingEnabled { [Bind ("isRoamingEnabled")] get; set; }

		/// <summary>Gets or sets the RoamingConsortiumOIs value.</summary>
		[Export ("roamingConsortiumOIs", ArgumentSemantic.Copy)]
		string [] RoamingConsortiumOIs { get; set; }

		/// <summary>Gets or sets the NaiRealmNames value.</summary>
		[Export ("naiRealmNames", ArgumentSemantic.Copy)]
		string [] NaiRealmNames { get; set; }

		/// <summary>Gets or sets the MccAndMncs value.</summary>
		[Export ("MCCAndMNCs", ArgumentSemantic.Copy)]
		string [] MccAndMncs { get; set; }

		/// <param name="domainName">The domain name.</param>
		/// <param name="roamingEnabled">Whether roaming is enabled.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithDomainName:roamingEnabled:")]
		NativeHandle Constructor (string domainName, bool roamingEnabled);
	}

	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Name = "NEHotspotEAPSettings")]
	interface NEHotspotEapSettings : NSCopying, NSSecureCoding {

		[Internal]
		[Export ("supportedEAPTypes", ArgumentSemantic.Copy)]
		IntPtr _SupportedEapTypes { get; set; }

		/// <summary>Gets or sets the Username value.</summary>
		[Export ("username")]
		string Username { get; set; }

		/// <summary>Gets or sets the OuterIdentity value.</summary>
		[Export ("outerIdentity")]
		string OuterIdentity { get; set; }

		/// <summary>Gets or sets the TtlsInnerAuthenticationType value.</summary>
		[Export ("ttlsInnerAuthenticationType", ArgumentSemantic.Assign)]
		NEHotspotConfigurationTtlsInnerAuthenticationType TtlsInnerAuthenticationType { get; set; }

		/// <summary>Gets or sets the Password value.</summary>
		[Export ("password")]
		string Password { get; set; }

		/// <summary>Gets or sets the TrustedServerNames value.</summary>
		[Export ("trustedServerNames", ArgumentSemantic.Copy)]
		string [] TrustedServerNames { get; set; }

		/// <summary>Gets or sets the TlsClientCertificateRequired value.</summary>
		[Export ("tlsClientCertificateRequired")]
		bool TlsClientCertificateRequired { [Bind ("isTLSClientCertificateRequired")] get; set; }

		/// <summary>Gets or sets the PreferredTlsVersion value.</summary>
		[Export ("preferredTLSVersion", ArgumentSemantic.Assign)]
		NEHotspotConfigurationEapTlsVersion PreferredTlsVersion { get; set; }

		/// <param name="identity">The identity.</param>
		///         <summary>Performs the set identity operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("setIdentity:")]
		bool SetIdentity (SecIdentity identity);

		/// <param name="certificates">The certificates array.</param>
		///         <summary>Performs the set trusted server certificates operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("setTrustedServerCertificates:")]
		bool SetTrustedServerCertificates (NSObject [] certificates);
	}

	/// <summary>Configuration settings for a network hotspot.</summary>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject))]
	interface NEHotspotConfiguration : NSCopying, NSSecureCoding {

		/// <summary>Gets the Ssid value.</summary>
		[Export ("SSID")]
		string Ssid { get; }

		/// <summary>Gets or sets the JoinOnce value.</summary>
		[Export ("joinOnce")]
		bool JoinOnce { get; set; }

		/// <summary>Gets or sets the LifeTimeInDays value.</summary>
		[Export ("lifeTimeInDays", ArgumentSemantic.Copy)]
		NSNumber LifeTimeInDays { get; set; }

		[Internal]
		[Export ("initWithSSID:")]
		IntPtr _InitWithSsid (string ssid);

		[Internal]
		[Export ("initWithSSID:passphrase:isWEP:")]
		IntPtr _InitWithSsidAndPassprase (string ssid, string passphrase, bool isWep);

		/// <param name="ssid">The SSID.</param>
		/// <param name="eapSettings">The EAP settings.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithSSID:eapSettings:")]
		NativeHandle Constructor (string ssid, NEHotspotEapSettings eapSettings);

		/// <param name="hs20Settings">The Hotspot 2.0 settings.</param>
		/// <param name="eapSettings">The EAP settings.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithHS20Settings:eapSettings:")]
		NativeHandle Constructor (NEHotspotHS20Settings hs20Settings, NEHotspotEapSettings eapSettings);

		[Internal]
		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("initWithSSIDPrefix:")]
		IntPtr _InitWithSsidPrefix (string ssidPrefix);

		[Internal]
		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("initWithSSIDPrefix:passphrase:isWEP:")]
		IntPtr _InitWithSsidPrefixAndPassphrase (string ssidPrefix, string passphrase, bool isWep);

		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("hidden")]
		bool Hidden { get; set; }

		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("SSIDPrefix")]
		string SsidPrefix { get; }
	}

	delegate void NEHotspotConfigurationManagerJoinHotspotCallback ([NullAllowed] NSError error);

	/// <summary>Manages the application or removal of <see cref="NetworkExtension.NEHotspotConfiguration" />.</summary>
	[NoTV]
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface NEHotspotConfigurationManager {

		/// <summary>Gets the SharedManager value.</summary>
		[Static]
		[Export ("sharedManager", ArgumentSemantic.Strong)]
		NEHotspotConfigurationManager SharedManager { get; }

		/// <param name="configuration">The configuration.</param>
		///         <param name="completionHandler">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Loads the configuration from preferences.</summary>
		[Async (XmlDocs = """
			<param name="configuration">The configuration.</param>
			<summary>Loads the configuration asynchronously.</summary>
			<returns>A task that represents the asynchronous ApplyConfiguration operation</returns>
			""")]
		[Export ("applyConfiguration:completionHandler:")]
		void ApplyConfiguration (NEHotspotConfiguration configuration, [NullAllowed] Action<NSError> completionHandler);

		/// <param name="ssid">The SSID.</param>
		///         <summary>Performs the remove configuration operation.</summary>
		[Export ("removeConfigurationForSSID:")]
		void RemoveConfiguration (string ssid);

		/// <param name="domainName">The domain name.</param>
		///         <summary>Performs the remove configuration for h s20 domain name operation.</summary>
		[Export ("removeConfigurationForHS20DomainName:")]
		void RemoveConfigurationForHS20DomainName (string domainName);

		/// <param name="completionHandler">The handler to call when the operation completes.</param>
		///         <summary>Saves the configuration to preferences.</summary>
		[Async (XmlDocs = """
			<summary>Saves the configuration asynchronously.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous GetConfiguredSsids operation.  The value of the TResult parameter is of type System.Action&lt;System.String[]&gt;.</para>
			        </returns>
			<remarks>
			          <para copied="true">The GetConfiguredSsidsAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>A task representing the asynchronous operation.</para>
			        </remarks>
			""")]
		[Export ("getConfiguredSSIDsWithCompletionHandler:")]
		void GetConfiguredSsids (Action<string []> completionHandler);

		// Headers say this method is available on Mac Catalyst, but the AccessorySetupKit framework (thus the ASAccessory type) is not, so we can't expose it in Mac Catalyst for now.
		[NoTV, NoMac, iOS (18, 0), NoMacCatalyst]
		[Async]
		[Export ("joinAccessoryHotspot:passphrase:completionHandler:")]
		void JoinAccessoryHotspot (ASAccessory accessory, string passphrase, [NullAllowed] NEHotspotConfigurationManagerJoinHotspotCallback completionHandler);

		// Headers say this method is available on Mac Catalyst, but the AccessorySetupKit framework (thus the ASAccessory type) is not, so we can't expose it in Mac Catalyst for now.
		[NoTV, NoMac, iOS (18, 0), NoMacCatalyst]
		[Async]
		[Export ("joinAccessoryHotspotWithoutSecurity:completionHandler:")]
		void JoinAccessoryHotspotWithoutSecurit (ASAccessory accessory, [NullAllowed] NEHotspotConfigurationManagerJoinHotspotCallback completionHandler);
	}

	[NoTV]
	[NoiOS]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NENetworkRule : NSSecureCoding, NSCopying {

		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Call the constructor overload that takes an 'NENetworkRuleConstructorOption' instead.")]
		[Export ("initWithDestinationNetwork:prefix:protocol:")]
		NativeHandle Constructor (NWHostEndpoint networkEndpoint, nuint destinationPrefix, NENetworkRuleProtocol protocol);

		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Call the constructor overload that takes an 'NENetworkRuleConstructorOption' instead.")]
		[Export ("initWithDestinationHost:protocol:")]
		NativeHandle Constructor (NWHostEndpoint hostEndpoint, NENetworkRuleProtocol protocol);

		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Call the constructor overload that takes an 'NENetworkRuleConstructorOption' instead.")]
		[Export ("initWithRemoteNetwork:remotePrefix:localNetwork:localPrefix:protocol:direction:")]
		NativeHandle Constructor ([NullAllowed] NWHostEndpoint remoteNetwork, nuint remotePrefix, [NullAllowed] NWHostEndpoint localNetwork, nuint localPrefix, NENetworkRuleProtocol protocol, NETrafficDirection direction);

		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'MatchRemoteHostOrNetworkEndpoint' instead.")]
		[NullAllowed, Export ("matchRemoteEndpoint")]
		NWHostEndpoint MatchRemoteEndpoint { get; }

		[Export ("matchRemotePrefix")]
		nuint MatchRemotePrefix { get; }

		[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use 'MatchLocalNetworkEndpoint' instead.")]
		[NullAllowed, Export ("matchLocalNetwork")]
		NWHostEndpoint MatchLocalNetwork { get; }

		[Export ("matchLocalPrefix")]
		nuint MatchLocalPrefix { get; }

		[Export ("matchProtocol")]
		NENetworkRuleProtocol MatchProtocol { get; }

		[Export ("matchDirection")]
		NETrafficDirection MatchDirection { get; }

		[NoTV, Mac (15, 0), NoiOS, NoMacCatalyst]
		[Export ("initWithDestinationNetworkEndpoint:prefix:protocol:")]
		NativeHandle Constructor (Network.NWEndpoint networkEndpoint, nuint destinationPrefix, NENetworkRuleProtocol protocol);

		[NoTV, Mac (15, 0), NoiOS, NoMacCatalyst]
		[Export ("initWithDestinationHostEndpoint:protocol:")]
		NativeHandle Constructor (Network.NWEndpoint hostEndpoint, NENetworkRuleProtocol protocol);

		[NoTV, Mac (15, 0), NoiOS, NoMacCatalyst]
		[Export ("initWithRemoteNetworkEndpoint:remotePrefix:localNetworkEndpoint:localPrefix:protocol:direction:")]
		NativeHandle Constructor ([NullAllowed] Network.NWEndpoint remoteNetwork, nuint remotePrefix, [NullAllowed] Network.NWEndpoint localNetwork, nuint localPrefix, NENetworkRuleProtocol protocol, NETrafficDirection direction);

		[NoTV, Mac (15, 0), NoiOS, NoMacCatalyst]
		[Export ("matchRemoteHostOrNetworkEndpoint"), NullAllowed]
		Network.NWEndpoint MatchRemoteHostOrNetworkEndpoint { get; }

		[NoTV, Mac (15, 0), NoiOS, NoMacCatalyst]
		[Export ("matchLocalNetworkEndpoint"), NullAllowed]
		Network.NWEndpoint MatchLocalNetworkEndpoint { get; }
	}

	[NoTV]
	[NoiOS]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NEFilterRule : NSSecureCoding, NSCopying {

		[Export ("initWithNetworkRule:action:")]
		NativeHandle Constructor (NENetworkRule networkRule, NEFilterAction action);

		[Export ("networkRule", ArgumentSemantic.Copy)]
		NENetworkRule NetworkRule { get; }

		[Export ("action")]
		NEFilterAction Action { get; }
	}

	[NoTV]
	[NoiOS]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface NEFilterSettings : NSSecureCoding, NSCopying {

		[Export ("initWithRules:defaultAction:")]
		NativeHandle Constructor (NEFilterRule [] rules, NEFilterAction defaultAction);

		[Export ("rules", ArgumentSemantic.Copy)]
		NEFilterRule [] Rules { get; }

		[Export ("defaultAction")]
		NEFilterAction DefaultAction { get; }
	}

	[NoTV]
	[NoiOS]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface NEFilterPacketContext {
	}

	[NoTV]
	[NoiOS]
	[NoMacCatalyst]
	delegate NEFilterPacketProviderVerdict NEFilterPacketHandler (NEFilterPacketContext context, IntPtr @interface, NETrafficDirection directiom, IntPtr packetBytes, nuint packetLength);

	[NoTV]
	[NoiOS]
	[NoMacCatalyst]
	[BaseType (typeof (NEFilterProvider))]
	[DisableDefaultCtor] // returns `nil`
	interface NEFilterPacketProvider {
		[NullAllowed, Export ("packetHandler", ArgumentSemantic.Strong)]
		NEFilterPacketHandler PacketHandler { get; set; }

		[Export ("delayCurrentPacket:")]
		NEPacket DelayCurrentPacket (NEFilterPacketContext context);

		[Export ("allowPacket:")]
		void AllowPacket (NEPacket packet);
	}

	[NoTV]
	[NoiOS]
	[NoMacCatalyst]
	[BaseType (typeof (NEVpnManager))]
	[DisableDefaultCtor]
	interface NETransparentProxyManager {

		[Static]
		[Async]
		[Export ("loadAllFromPreferencesWithCompletionHandler:")]
		void LoadAllFromPreferences (Action<NETransparentProxyManager [], NSError> completionHandler);
	}

	[NoTV]
	[NoiOS]
	[NoMacCatalyst]
	[BaseType (typeof (NETunnelNetworkSettings))]
	interface NETransparentProxyNetworkSettings {

		[NullAllowed, Export ("includedNetworkRules", ArgumentSemantic.Copy)]
		NENetworkRule [] IncludedNetworkRules { get; set; }

		[NullAllowed, Export ("excludedNetworkRules", ArgumentSemantic.Copy)]
		NENetworkRule [] ExcludedNetworkRules { get; set; }
	}

	[NoTV, NoMac, iOS (14, 0)]
	[MacCatalyst (14, 0)]
	[BaseType (typeof (NSObject))]
	interface NEAppPushManager {
		[Export ("matchSSIDs", ArgumentSemantic.Copy)]
		string [] MatchSsids { get; set; }

		[Export ("providerConfiguration", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> ProviderConfiguration { get; set; }

		[NullAllowed]
		[Export ("providerBundleIdentifier")]
		string ProviderBundleIdentifier { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		INEAppPushDelegate Delegate { get; set; }

		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		[Async]
		[Static]
		[Export ("loadAllFromPreferencesWithCompletionHandler:")]
		void LoadAllFromPreferences (Action<NEAppPushManager [], NSError> completionHandler);

		[Async]
		[Export ("loadFromPreferencesWithCompletionHandler:")]
		void LoadFromPreferences (Action<NSError> completionHandler);

		[Async]
		[Export ("removeFromPreferencesWithCompletionHandler:")]
		void RemoveFromPreferences (Action<NSError> completionHandler);

		[Async]
		[Export ("saveToPreferencesWithCompletionHandler:")]
		void SaveToPreferences (Action<NSError> completionHandler);

		[NullAllowed]
		[Export ("localizedDescription")]
		string LocalizedDescription { get; set; }

		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		[Export ("active")]
		bool Active { [Bind ("isActive")] get; }

		[NoTV, NoMac, iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("matchPrivateLTENetworks", ArgumentSemantic.Copy)]
		NEPrivateLteNetwork [] MatchPrivateLteNetworks { get; set; }

		[MacCatalyst (26, 0), NoTV, NoMac, iOS (26, 0)]
		[Export ("matchEthernet")]
		bool MatchEthernet { get; set; }
	}

	[NoTV, NoMac, iOS (14, 0)]
	[MacCatalyst (14, 0)]
	[BaseType (typeof (NEProvider))]
	[DisableDefaultCtor] // init returns nil
	interface NEAppPushProvider {
		[NullAllowed]
		[Export ("providerConfiguration")]
		NSDictionary<NSString, NSObject> ProviderConfiguration { get; }

		[Deprecated (PlatformName.iOS, 15, 0, message: "Use the synchronoys 'Start' method instead..")]
		[Deprecated (PlatformName.MacCatalyst, 12, 0, message: "Use the synchronoys 'Start' method instead..")]
		[Async]
		[Export ("startWithCompletionHandler:")]
		void Start (Action<NSError> completionHandler);

		[Async]
		[Export ("stopWithReason:completionHandler:")]
		void Stop (NEProviderStopReason reason, Action completionHandler);

		[Export ("reportIncomingCallWithUserInfo:")]
		void ReportIncomingCall (NSDictionary userInfo);

		[NoTV, NoMacCatalyst, NoMac, iOS (16, 4)]
		[Export ("reportPushToTalkMessageWithUserInfo:")]
		void ReportPushToTalkMessage (NSDictionary userInfo);

		[Export ("handleTimerEvent")]
		void HandleTimerEvent ();

		[NoTV, NoMac, iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("start")]
		void Start ();

		[MacCatalyst (26, 0), NoTV, NoMac, iOS (26, 0)]
		[Export ("unmatchEthernet")]
		void UnmatchEthernet ();
	}

	[iOS (14, 0), TV (17, 0)]
	[MacCatalyst (14, 0)]
	[BaseType (typeof (NEDnsSettings), Name = "NEDNSOverHTTPSSettings")]
	interface NEDnsOverHttpsSettings {
		[NullAllowed]
		[Export ("serverURL", ArgumentSemantic.Copy)]
		NSUrl ServerUrl { get; set; }

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0)]
		[Export ("identityReference", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSData IdentityReference { get; set; }
	}

	[iOS (14, 0), TV (17, 0)]
	[MacCatalyst (14, 0)]
	[BaseType (typeof (NEDnsSettings), Name = "NEDNSOverTLSSettings")]
	interface NEDnsOverTlsSettings {
		[NullAllowed]
		[Export ("serverName")]
		string ServerName { get; set; }

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0)]
		[Export ("identityReference", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSData IdentityReference { get; set; }
	}

	[NoTV, iOS (14, 0)]
	[MacCatalyst (14, 0)]
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject), Name = "NEDNSSettingsManager")]
	interface NEDnsSettingsManager {
		[Static]
		[Export ("sharedManager")]
		NEDnsSettingsManager SharedManager { get; }

		[Async]
		[Export ("loadFromPreferencesWithCompletionHandler:")]
		void LoadFromPreferences (Action<NSError> completionHandler);

		[Async]
		[Export ("removeFromPreferencesWithCompletionHandler:")]
		void RemoveFromPreferences (Action<NSError> completionHandler);

		[Async]
		[Export ("saveToPreferencesWithCompletionHandler:")]
		void SaveToPreferences (Action<NSError> completionHandler);

		[NullAllowed]
		[Export ("localizedDescription")]
		string LocalizedDescription { get; set; }

		[NullAllowed]
		[Export ("dnsSettings", ArgumentSemantic.Strong)]
		NEDnsSettings DnsSettings { get; set; }

		[NullAllowed]
		[Export ("onDemandRules", ArgumentSemantic.Copy)]
		NEOnDemandRule [] OnDemandRules { get; set; }

		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; }
	}

	interface INEAppPushDelegate { }

	[NoTV, NoMac, iOS (14, 0)]
	[MacCatalyst (14, 0)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface NEAppPushDelegate {
		[Abstract]
		[Export ("appPushManager:didReceiveIncomingCallWithUserInfo:")]
		void DidReceiveIncomingCall (NEAppPushManager manager, NSDictionary userInfo);
	}

	[NoMacCatalyst]
	[NoiOS]
	[NoTV]
	[BaseType (typeof (NEAppProxyProvider))]
	[DisableDefaultCtor] // `init` returns `nil`
	interface NETransparentProxyProvider {
	}

	[NoTV, NoMac, iOS (15, 0), MacCatalyst (15, 0)]
	[BaseType (typeof (NSObject), Name = "NEPrivateLTENetwork")]
	interface NEPrivateLteNetwork : NSCopying, NSSecureCoding {
		[Export ("mobileCountryCode")]
		string MobileCountryCode { get; set; }

		[Export ("mobileNetworkCode")]
		string MobileNetworkCode { get; set; }

		[NullAllowed]
		[Export ("trackingAreaCode")]
		string TrackingAreaCode { get; set; }
	}

	[NoTV, NoiOS, Mac (13, 0)]
	[NoMacCatalyst]
	[BaseType (typeof (NEPacketTunnelProvider))]
	[DisableDefaultCtor]
	interface NEEthernetTunnelProvider {
	}

	[NoTV, NoiOS, Mac (13, 0)]
	[NoMacCatalyst]
	[BaseType (typeof (NEPacketTunnelNetworkSettings))]
	interface NEEthernetTunnelNetworkSettings {
		[Export ("initWithTunnelRemoteAddress:ethernetAddress:mtu:")]
		NativeHandle Constructor (string address, string ethernetAddress, nint mtu);

		[Export ("ethernetAddress")]
		string EthernetAddress { get; }
	}

	[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
	[BaseType (typeof (NSObject))]
	interface NERelay : NSCopying, NSSecureCoding {
		[NullAllowed, Export ("HTTP3RelayURL", ArgumentSemantic.Copy)]
		NSUrl Http3RelayUrl { get; set; }

		[NullAllowed, Export ("HTTP2RelayURL", ArgumentSemantic.Copy)]
		NSUrl Http2RelayUrl { get; set; }

		[NullAllowed, Export ("dnsOverHTTPSURL", ArgumentSemantic.Copy)]
		NSUrl DnsOverHttpsUrl { get; set; }

		[NullAllowed, Export ("syntheticDNSAnswerIPv4Prefix")]
		string SyntheticDnsAnswerIPv4Prefix { get; set; }

		[NullAllowed, Export ("syntheticDNSAnswerIPv6Prefix")]
		string SyntheticDnsAnswerIPv6Prefix { get; set; }

		[Export ("additionalHTTPHeaderFields", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> AdditionalHttpHeaderFields { get; set; }

		[NullAllowed, Export ("rawPublicKeys", ArgumentSemantic.Copy)]
		NSData [] RawPublicKeys { get; set; }

		[NullAllowed, Export ("identityData", ArgumentSemantic.Copy)]
		NSData IdentityData { get; set; }

		[NullAllowed, Export ("identityDataPassword")]
		string IdentityDataPassword { get; set; }

		[Field ("NERelayErrorDomain")]
		NSString ErrorDomain { get; }

		[Notification, Field ("NERelayConfigurationDidChangeNotification")]
		NSString ConfigurationDidChangeNotification { get; }
	}

	delegate void NERelayManagerGetLastClientErrorsCallback ([NullAllowed] NSError [] errors);

	[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
	[BaseType (typeof (NSObject))]
	interface NERelayManager {
		[Static]
		[Export ("sharedManager")]
		NERelayManager Shared { get; }

		[Export ("loadFromPreferencesWithCompletionHandler:")]
		[Async]
		void LoadFromPreferences (Action<NSError> completionHandler);

		[Export ("removeFromPreferencesWithCompletionHandler:")]
		[Async]
		void RemoveFromPreferences (Action<NSError> completionHandler);

		[Export ("saveToPreferencesWithCompletionHandler:")]
		[Async]
		void SaveToPreferences (Action<NSError> completionHandler);

		[NullAllowed, Export ("localizedDescription")]
		string LocalizedDescription { get; set; }

		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		[NullAllowed, Export ("relays", ArgumentSemantic.Strong)]
		NERelay [] Relays { get; set; }

		[NullAllowed, Export ("matchDomains", ArgumentSemantic.Copy)]
		string [] MatchDomains { get; set; }

		[NullAllowed, Export ("excludedDomains", ArgumentSemantic.Copy)]
		string [] ExcludedDomains { get; set; }

		[NullAllowed, Export ("onDemandRules", ArgumentSemantic.Copy)]
		NEOnDemandRule [] OnDemandRules { get; set; }

		[Static]
		[Export ("loadAllManagersFromPreferencesWithCompletionHandler:")]
		[Async]
		void LoadAllManagersFromPreferences (Action<NSArray<NERelayManager>, NSError> completionHandler);

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("getLastClientErrors:completionHandler:")]
		[Async]
		void GetLastClientErrors (double seconds, NERelayManagerGetLastClientErrorsCallback completionHandler);

		[Export ("matchFQDNs", ArgumentSemantic.Copy), NullAllowed]
		[TV (18, 4), Mac (15, 4), iOS (18, 4), MacCatalyst (18, 4)]
		string [] MatchFqdns { get; set; }

		[Export ("excludedFQDNs", ArgumentSemantic.Copy), NullAllowed]
		[TV (18, 4), Mac (15, 4), iOS (18, 4), MacCatalyst (18, 4)]
		string [] ExcludedFqdns { get; set; }

		[Export ("UIToggleEnabled")]
		[TV (18, 4), Mac (15, 4), iOS (18, 4), MacCatalyst (18, 4)]
		bool UIToggleEnabled { [Bind ("isUIToggleEnabled")] get; set; }

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("allowDNSFailover")]
		bool AllowDNSFailover { [Bind ("isDNSFailoverAllowed")] get; set; }
	}

	/// <summary>Enumerates client errors that can occur with an <see cref="NERelayManager" />.</summary>
	[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[ErrorDomain ("NERelayClientErrorDomain")]
	[Native]
	enum NERelayManagerClientError : long {
		/// <summary>No error occurred.</summary>
		None = 1,
		/// <summary>DNS resolution failed.</summary>
		DNSFailed = 2,
		/// <summary>The relay server is unreachable.</summary>
		ServerUnreachable = 3,
		/// <summary>The relay server disconnected.</summary>
		ServerDisconnected = 4,
		/// <summary>The client certificate is missing.</summary>
		CertificateMissing = 5,
		/// <summary>The client certificate is invalid.</summary>
		CertificateInvalid = 6,
		/// <summary>The client certificate has expired.</summary>
		CertificateExpired = 7,
		/// <summary>The server certificate is invalid.</summary>
		ServerCertificateInvalid = 8,
		/// <summary>The server certificate has expired.</summary>
		ServerCertificateExpired = 9,
		/// <summary>An unspecified error occurred.</summary>
		Other = 10,
		/// <summary>The Provisioning Domain (PvD) configuration was truncated.</summary>
		PvDConfigurationTruncated = 11,
	}

	[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[BaseType (typeof (NSObject), Name = "NEVPNIKEv2PPKConfiguration")]
	interface NEVpnIkev2PpkConfiguration : NSCopying {
		[Export ("initWithIdentifier:keychainReference:")]
		NativeHandle Constructor (string identifier, NSData keychainReference);

		[Export ("identifier", ArgumentSemantic.Copy)]
		string Identifier { get; }

		[Export ("keychainReference", ArgumentSemantic.Copy)]
		NSData KeychainReference { get; }

		[Export ("isMandatory")]
		bool IsMandatory { get; set; }
	}


	[MacCatalyst (26, 0), NoTV, Mac (26, 0), iOS (26, 0)]
	[Native]
	[NativeName ("NEURLFilterVerdict")]
	public enum NEUrlFilterVerdict : long {
		Unknown = 1,
		Allow = 2,
		Deny = 3,
	}

	[MacCatalyst (26, 0), NoTV, Mac (26, 0), iOS (26, 0)]
	[BaseType (typeof (NSObject), Name = "NEURLFilter")]
	[DisableDefaultCtor]
	interface NEUrlFilter {
		[Async]
		[Static]
		[Export ("verdictForURL:completionHandler:")]
		void GetVerdict (NSUrl url, Action<NEUrlFilterVerdict> completionHandler);
	}

	[MacCatalyst (26, 0), TV (26, 0), Mac (26, 0), iOS (26, 0)]
	[Native]
	[NativeName ("NEVPNIKEv2PostQuantumKeyExchangeMethod")]
	public enum NEVpnIkev2PostQuantumKeyExchangeMethod : long {
		None = 0,
		Method36 = 36,
		Method37 = 37
	}
}
