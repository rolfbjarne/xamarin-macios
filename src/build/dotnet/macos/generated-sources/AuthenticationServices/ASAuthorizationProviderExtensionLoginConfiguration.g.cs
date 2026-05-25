//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AuthenticationServices {
	[Register("ASAuthorizationProviderExtensionLoginConfiguration", true)]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos13.0")]
	public unsafe partial class ASAuthorizationProviderExtensionLoginConfiguration : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccountDisplayNameX = "accountDisplayName";
		static readonly NativeHandle selAccountDisplayNameXHandle = Selector.GetHandle ("accountDisplayName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAdditionalAuthorizationScopesX = "additionalAuthorizationScopes";
		static readonly NativeHandle selAdditionalAuthorizationScopesXHandle = Selector.GetHandle ("additionalAuthorizationScopes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAdditionalScopesX = "additionalScopes";
		static readonly NativeHandle selAdditionalScopesXHandle = Selector.GetHandle ("additionalScopes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudienceX = "audience";
		static readonly NativeHandle selAudienceXHandle = Selector.GetHandle ("audience");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClientIDX = "clientID";
		static readonly NativeHandle selClientIDXHandle = Selector.GetHandle ("clientID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConfigurationWithOpenIDConfigurationURL_ClientID_Issuer_Completion_X = "configurationWithOpenIDConfigurationURL:clientID:issuer:completion:";
		static readonly NativeHandle selConfigurationWithOpenIDConfigurationURL_ClientID_Issuer_Completion_XHandle = Selector.GetHandle ("configurationWithOpenIDConfigurationURL:clientID:issuer:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomFederationUserPreauthenticationRequestValuesX = "customFederationUserPreauthenticationRequestValues";
		static readonly NativeHandle selCustomFederationUserPreauthenticationRequestValuesXHandle = Selector.GetHandle ("customFederationUserPreauthenticationRequestValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomKeyExchangeRequestValuesX = "customKeyExchangeRequestValues";
		static readonly NativeHandle selCustomKeyExchangeRequestValuesXHandle = Selector.GetHandle ("customKeyExchangeRequestValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomKeyRequestValuesX = "customKeyRequestValues";
		static readonly NativeHandle selCustomKeyRequestValuesXHandle = Selector.GetHandle ("customKeyRequestValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomLoginRequestValuesX = "customLoginRequestValues";
		static readonly NativeHandle selCustomLoginRequestValuesXHandle = Selector.GetHandle ("customLoginRequestValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomNonceRequestValuesX = "customNonceRequestValues";
		static readonly NativeHandle selCustomNonceRequestValuesXHandle = Selector.GetHandle ("customNonceRequestValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomRefreshRequestValuesX = "customRefreshRequestValues";
		static readonly NativeHandle selCustomRefreshRequestValuesXHandle = Selector.GetHandle ("customRefreshRequestValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomRequestJWTParameterNameX = "customRequestJWTParameterName";
		static readonly NativeHandle selCustomRequestJWTParameterNameXHandle = Selector.GetHandle ("customRequestJWTParameterName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceContextX = "deviceContext";
		static readonly NativeHandle selDeviceContextXHandle = Selector.GetHandle ("deviceContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFederationMEXURLX = "federationMEXURL";
		static readonly NativeHandle selFederationMEXURLXHandle = Selector.GetHandle ("federationMEXURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFederationMEXURLKeypathX = "federationMEXURLKeypath";
		static readonly NativeHandle selFederationMEXURLKeypathXHandle = Selector.GetHandle ("federationMEXURLKeypath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFederationPredicateX = "federationPredicate";
		static readonly NativeHandle selFederationPredicateXHandle = Selector.GetHandle ("federationPredicate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFederationRequestURNX = "federationRequestURN";
		static readonly NativeHandle selFederationRequestURNXHandle = Selector.GetHandle ("federationRequestURN");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFederationTypeX = "federationType";
		static readonly NativeHandle selFederationTypeXHandle = Selector.GetHandle ("federationType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFederationUserPreauthenticationURLX = "federationUserPreauthenticationURL";
		static readonly NativeHandle selFederationUserPreauthenticationURLXHandle = Selector.GetHandle ("federationUserPreauthenticationURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroupRequestClaimNameX = "groupRequestClaimName";
		static readonly NativeHandle selGroupRequestClaimNameXHandle = Selector.GetHandle ("groupRequestClaimName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroupResponseClaimNameX = "groupResponseClaimName";
		static readonly NativeHandle selGroupResponseClaimNameXHandle = Selector.GetHandle ("groupResponseClaimName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHpkeAuthPublicKeyX = "hpkeAuthPublicKey";
		static readonly NativeHandle selHpkeAuthPublicKeyXHandle = Selector.GetHandle ("hpkeAuthPublicKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHpkePreSharedKeyX = "hpkePreSharedKey";
		static readonly NativeHandle selHpkePreSharedKeyXHandle = Selector.GetHandle ("hpkePreSharedKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHpkePreSharedKeyIDX = "hpkePreSharedKeyID";
		static readonly NativeHandle selHpkePreSharedKeyIDXHandle = Selector.GetHandle ("hpkePreSharedKeyID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIncludePreviousRefreshTokenInLoginRequestX = "includePreviousRefreshTokenInLoginRequest";
		static readonly NativeHandle selIncludePreviousRefreshTokenInLoginRequestXHandle = Selector.GetHandle ("includePreviousRefreshTokenInLoginRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithClientID_Issuer_TokenEndpointURL_JwksEndpointURL_Audience_X = "initWithClientID:issuer:tokenEndpointURL:jwksEndpointURL:audience:";
		static readonly NativeHandle selInitWithClientID_Issuer_TokenEndpointURL_JwksEndpointURL_Audience_XHandle = Selector.GetHandle ("initWithClientID:issuer:tokenEndpointURL:jwksEndpointURL:audience:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidCredentialPredicateX = "invalidCredentialPredicate";
		static readonly NativeHandle selInvalidCredentialPredicateXHandle = Selector.GetHandle ("invalidCredentialPredicate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIssuerX = "issuer";
		static readonly NativeHandle selIssuerXHandle = Selector.GetHandle ("issuer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJwksEndpointURLX = "jwksEndpointURL";
		static readonly NativeHandle selJwksEndpointURLXHandle = Selector.GetHandle ("jwksEndpointURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJwksTrustedRootCertificatesX = "jwksTrustedRootCertificates";
		static readonly NativeHandle selJwksTrustedRootCertificatesXHandle = Selector.GetHandle ("jwksTrustedRootCertificates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKerberosTicketMappingsX = "kerberosTicketMappings";
		static readonly NativeHandle selKerberosTicketMappingsXHandle = Selector.GetHandle ("kerberosTicketMappings");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyEndpointURLX = "keyEndpointURL";
		static readonly NativeHandle selKeyEndpointURLXHandle = Selector.GetHandle ("keyEndpointURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoginRequestEncryptionAPVPrefixX = "loginRequestEncryptionAPVPrefix";
		static readonly NativeHandle selLoginRequestEncryptionAPVPrefixXHandle = Selector.GetHandle ("loginRequestEncryptionAPVPrefix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoginRequestEncryptionAlgorithmX = "loginRequestEncryptionAlgorithm";
		static readonly NativeHandle selLoginRequestEncryptionAlgorithmXHandle = Selector.GetHandle ("loginRequestEncryptionAlgorithm");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoginRequestEncryptionPublicKeyX = "loginRequestEncryptionPublicKey";
		static readonly NativeHandle selLoginRequestEncryptionPublicKeyXHandle = Selector.GetHandle ("loginRequestEncryptionPublicKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoginRequestHPKEPreSharedKeyX = "loginRequestHPKEPreSharedKey";
		static readonly NativeHandle selLoginRequestHPKEPreSharedKeyXHandle = Selector.GetHandle ("loginRequestHPKEPreSharedKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoginRequestHPKEPreSharedKeyIDX = "loginRequestHPKEPreSharedKeyID";
		static readonly NativeHandle selLoginRequestHPKEPreSharedKeyIDXHandle = Selector.GetHandle ("loginRequestHPKEPreSharedKeyID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNonceEndpointURLX = "nonceEndpointURL";
		static readonly NativeHandle selNonceEndpointURLXHandle = Selector.GetHandle ("nonceEndpointURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNonceResponseKeypathX = "nonceResponseKeypath";
		static readonly NativeHandle selNonceResponseKeypathXHandle = Selector.GetHandle ("nonceResponseKeypath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviousRefreshTokenClaimNameX = "previousRefreshTokenClaimName";
		static readonly NativeHandle selPreviousRefreshTokenClaimNameXHandle = Selector.GetHandle ("previousRefreshTokenClaimName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRefreshEndpointURLX = "refreshEndpointURL";
		static readonly NativeHandle selRefreshEndpointURLXHandle = Selector.GetHandle ("refreshEndpointURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selServerNonceClaimNameX = "serverNonceClaimName";
		static readonly NativeHandle selServerNonceClaimNameXHandle = Selector.GetHandle ("serverNonceClaimName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccountDisplayName_X = "setAccountDisplayName:";
		static readonly NativeHandle selSetAccountDisplayName_XHandle = Selector.GetHandle ("setAccountDisplayName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAdditionalAuthorizationScopes_X = "setAdditionalAuthorizationScopes:";
		static readonly NativeHandle selSetAdditionalAuthorizationScopes_XHandle = Selector.GetHandle ("setAdditionalAuthorizationScopes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAdditionalScopes_X = "setAdditionalScopes:";
		static readonly NativeHandle selSetAdditionalScopes_XHandle = Selector.GetHandle ("setAdditionalScopes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAudience_X = "setAudience:";
		static readonly NativeHandle selSetAudience_XHandle = Selector.GetHandle ("setAudience:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomAssertionRequestBodyClaims_ReturningError_X = "setCustomAssertionRequestBodyClaims:returningError:";
		static readonly NativeHandle selSetCustomAssertionRequestBodyClaims_ReturningError_XHandle = Selector.GetHandle ("setCustomAssertionRequestBodyClaims:returningError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomAssertionRequestHeaderClaims_ReturningError_X = "setCustomAssertionRequestHeaderClaims:returningError:";
		static readonly NativeHandle selSetCustomAssertionRequestHeaderClaims_ReturningError_XHandle = Selector.GetHandle ("setCustomAssertionRequestHeaderClaims:returningError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomFederationUserPreauthenticationRequestValues_X = "setCustomFederationUserPreauthenticationRequestValues:";
		static readonly NativeHandle selSetCustomFederationUserPreauthenticationRequestValues_XHandle = Selector.GetHandle ("setCustomFederationUserPreauthenticationRequestValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomKeyExchangeRequestBodyClaims_ReturningError_X = "setCustomKeyExchangeRequestBodyClaims:returningError:";
		static readonly NativeHandle selSetCustomKeyExchangeRequestBodyClaims_ReturningError_XHandle = Selector.GetHandle ("setCustomKeyExchangeRequestBodyClaims:returningError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomKeyExchangeRequestHeaderClaims_ReturningError_X = "setCustomKeyExchangeRequestHeaderClaims:returningError:";
		static readonly NativeHandle selSetCustomKeyExchangeRequestHeaderClaims_ReturningError_XHandle = Selector.GetHandle ("setCustomKeyExchangeRequestHeaderClaims:returningError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomKeyExchangeRequestValues_X = "setCustomKeyExchangeRequestValues:";
		static readonly NativeHandle selSetCustomKeyExchangeRequestValues_XHandle = Selector.GetHandle ("setCustomKeyExchangeRequestValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomKeyRequestBodyClaims_ReturningError_X = "setCustomKeyRequestBodyClaims:returningError:";
		static readonly NativeHandle selSetCustomKeyRequestBodyClaims_ReturningError_XHandle = Selector.GetHandle ("setCustomKeyRequestBodyClaims:returningError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomKeyRequestHeaderClaims_ReturningError_X = "setCustomKeyRequestHeaderClaims:returningError:";
		static readonly NativeHandle selSetCustomKeyRequestHeaderClaims_ReturningError_XHandle = Selector.GetHandle ("setCustomKeyRequestHeaderClaims:returningError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomKeyRequestValues_X = "setCustomKeyRequestValues:";
		static readonly NativeHandle selSetCustomKeyRequestValues_XHandle = Selector.GetHandle ("setCustomKeyRequestValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomLoginRequestBodyClaims_ReturningError_X = "setCustomLoginRequestBodyClaims:returningError:";
		static readonly NativeHandle selSetCustomLoginRequestBodyClaims_ReturningError_XHandle = Selector.GetHandle ("setCustomLoginRequestBodyClaims:returningError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomLoginRequestHeaderClaims_ReturningError_X = "setCustomLoginRequestHeaderClaims:returningError:";
		static readonly NativeHandle selSetCustomLoginRequestHeaderClaims_ReturningError_XHandle = Selector.GetHandle ("setCustomLoginRequestHeaderClaims:returningError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomLoginRequestValues_X = "setCustomLoginRequestValues:";
		static readonly NativeHandle selSetCustomLoginRequestValues_XHandle = Selector.GetHandle ("setCustomLoginRequestValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomNonceRequestValues_X = "setCustomNonceRequestValues:";
		static readonly NativeHandle selSetCustomNonceRequestValues_XHandle = Selector.GetHandle ("setCustomNonceRequestValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomRefreshRequestBodyClaims_ReturningError_X = "setCustomRefreshRequestBodyClaims:returningError:";
		static readonly NativeHandle selSetCustomRefreshRequestBodyClaims_ReturningError_XHandle = Selector.GetHandle ("setCustomRefreshRequestBodyClaims:returningError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomRefreshRequestHeaderClaims_ReturningError_X = "setCustomRefreshRequestHeaderClaims:returningError:";
		static readonly NativeHandle selSetCustomRefreshRequestHeaderClaims_ReturningError_XHandle = Selector.GetHandle ("setCustomRefreshRequestHeaderClaims:returningError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomRefreshRequestValues_X = "setCustomRefreshRequestValues:";
		static readonly NativeHandle selSetCustomRefreshRequestValues_XHandle = Selector.GetHandle ("setCustomRefreshRequestValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomRequestJWTParameterName_X = "setCustomRequestJWTParameterName:";
		static readonly NativeHandle selSetCustomRequestJWTParameterName_XHandle = Selector.GetHandle ("setCustomRequestJWTParameterName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDeviceContext_X = "setDeviceContext:";
		static readonly NativeHandle selSetDeviceContext_XHandle = Selector.GetHandle ("setDeviceContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFederationMEXURL_X = "setFederationMEXURL:";
		static readonly NativeHandle selSetFederationMEXURL_XHandle = Selector.GetHandle ("setFederationMEXURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFederationMEXURLKeypath_X = "setFederationMEXURLKeypath:";
		static readonly NativeHandle selSetFederationMEXURLKeypath_XHandle = Selector.GetHandle ("setFederationMEXURLKeypath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFederationPredicate_X = "setFederationPredicate:";
		static readonly NativeHandle selSetFederationPredicate_XHandle = Selector.GetHandle ("setFederationPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFederationRequestURN_X = "setFederationRequestURN:";
		static readonly NativeHandle selSetFederationRequestURN_XHandle = Selector.GetHandle ("setFederationRequestURN:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFederationType_X = "setFederationType:";
		static readonly NativeHandle selSetFederationType_XHandle = Selector.GetHandle ("setFederationType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFederationUserPreauthenticationURL_X = "setFederationUserPreauthenticationURL:";
		static readonly NativeHandle selSetFederationUserPreauthenticationURL_XHandle = Selector.GetHandle ("setFederationUserPreauthenticationURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGroupRequestClaimName_X = "setGroupRequestClaimName:";
		static readonly NativeHandle selSetGroupRequestClaimName_XHandle = Selector.GetHandle ("setGroupRequestClaimName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGroupResponseClaimName_X = "setGroupResponseClaimName:";
		static readonly NativeHandle selSetGroupResponseClaimName_XHandle = Selector.GetHandle ("setGroupResponseClaimName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHpkeAuthPublicKey_X = "setHpkeAuthPublicKey:";
		static readonly NativeHandle selSetHpkeAuthPublicKey_XHandle = Selector.GetHandle ("setHpkeAuthPublicKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHpkePreSharedKey_X = "setHpkePreSharedKey:";
		static readonly NativeHandle selSetHpkePreSharedKey_XHandle = Selector.GetHandle ("setHpkePreSharedKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHpkePreSharedKeyID_X = "setHpkePreSharedKeyID:";
		static readonly NativeHandle selSetHpkePreSharedKeyID_XHandle = Selector.GetHandle ("setHpkePreSharedKeyID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIncludePreviousRefreshTokenInLoginRequest_X = "setIncludePreviousRefreshTokenInLoginRequest:";
		static readonly NativeHandle selSetIncludePreviousRefreshTokenInLoginRequest_XHandle = Selector.GetHandle ("setIncludePreviousRefreshTokenInLoginRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInvalidCredentialPredicate_X = "setInvalidCredentialPredicate:";
		static readonly NativeHandle selSetInvalidCredentialPredicate_XHandle = Selector.GetHandle ("setInvalidCredentialPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetJwksEndpointURL_X = "setJwksEndpointURL:";
		static readonly NativeHandle selSetJwksEndpointURL_XHandle = Selector.GetHandle ("setJwksEndpointURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetJwksTrustedRootCertificates_X = "setJwksTrustedRootCertificates:";
		static readonly NativeHandle selSetJwksTrustedRootCertificates_XHandle = Selector.GetHandle ("setJwksTrustedRootCertificates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetKerberosTicketMappings_X = "setKerberosTicketMappings:";
		static readonly NativeHandle selSetKerberosTicketMappings_XHandle = Selector.GetHandle ("setKerberosTicketMappings:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetKeyEndpointURL_X = "setKeyEndpointURL:";
		static readonly NativeHandle selSetKeyEndpointURL_XHandle = Selector.GetHandle ("setKeyEndpointURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLoginRequestEncryptionAPVPrefix_X = "setLoginRequestEncryptionAPVPrefix:";
		static readonly NativeHandle selSetLoginRequestEncryptionAPVPrefix_XHandle = Selector.GetHandle ("setLoginRequestEncryptionAPVPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLoginRequestEncryptionAlgorithm_X = "setLoginRequestEncryptionAlgorithm:";
		static readonly NativeHandle selSetLoginRequestEncryptionAlgorithm_XHandle = Selector.GetHandle ("setLoginRequestEncryptionAlgorithm:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLoginRequestEncryptionPublicKey_X = "setLoginRequestEncryptionPublicKey:";
		static readonly NativeHandle selSetLoginRequestEncryptionPublicKey_XHandle = Selector.GetHandle ("setLoginRequestEncryptionPublicKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLoginRequestHPKEPreSharedKey_X = "setLoginRequestHPKEPreSharedKey:";
		static readonly NativeHandle selSetLoginRequestHPKEPreSharedKey_XHandle = Selector.GetHandle ("setLoginRequestHPKEPreSharedKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLoginRequestHPKEPreSharedKeyID_X = "setLoginRequestHPKEPreSharedKeyID:";
		static readonly NativeHandle selSetLoginRequestHPKEPreSharedKeyID_XHandle = Selector.GetHandle ("setLoginRequestHPKEPreSharedKeyID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNonceEndpointURL_X = "setNonceEndpointURL:";
		static readonly NativeHandle selSetNonceEndpointURL_XHandle = Selector.GetHandle ("setNonceEndpointURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNonceResponseKeypath_X = "setNonceResponseKeypath:";
		static readonly NativeHandle selSetNonceResponseKeypath_XHandle = Selector.GetHandle ("setNonceResponseKeypath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreviousRefreshTokenClaimName_X = "setPreviousRefreshTokenClaimName:";
		static readonly NativeHandle selSetPreviousRefreshTokenClaimName_XHandle = Selector.GetHandle ("setPreviousRefreshTokenClaimName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRefreshEndpointURL_X = "setRefreshEndpointURL:";
		static readonly NativeHandle selSetRefreshEndpointURL_XHandle = Selector.GetHandle ("setRefreshEndpointURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetServerNonceClaimName_X = "setServerNonceClaimName:";
		static readonly NativeHandle selSetServerNonceClaimName_XHandle = Selector.GetHandle ("setServerNonceClaimName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTokenEndpointURL_X = "setTokenEndpointURL:";
		static readonly NativeHandle selSetTokenEndpointURL_XHandle = Selector.GetHandle ("setTokenEndpointURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUniqueIdentifierClaimName_X = "setUniqueIdentifierClaimName:";
		static readonly NativeHandle selSetUniqueIdentifierClaimName_XHandle = Selector.GetHandle ("setUniqueIdentifierClaimName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserSecureEnclaveKeyBiometricPolicy_X = "setUserSecureEnclaveKeyBiometricPolicy:";
		static readonly NativeHandle selSetUserSecureEnclaveKeyBiometricPolicy_XHandle = Selector.GetHandle ("setUserSecureEnclaveKeyBiometricPolicy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTokenEndpointURLX = "tokenEndpointURL";
		static readonly NativeHandle selTokenEndpointURLXHandle = Selector.GetHandle ("tokenEndpointURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniqueIdentifierClaimNameX = "uniqueIdentifierClaimName";
		static readonly NativeHandle selUniqueIdentifierClaimNameXHandle = Selector.GetHandle ("uniqueIdentifierClaimName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserSecureEnclaveKeyBiometricPolicyX = "userSecureEnclaveKeyBiometricPolicy";
		static readonly NativeHandle selUserSecureEnclaveKeyBiometricPolicyXHandle = Selector.GetHandle ("userSecureEnclaveKeyBiometricPolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ASAuthorizationProviderExtensionLoginConfiguration");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ASAuthorizationProviderExtensionLoginConfiguration (NSObjectFlag t) : base (t)
		{
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ASAuthorizationProviderExtensionLoginConfiguration (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithClientID:issuer:tokenEndpointURL:jwksEndpointURL:audience:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ASAuthorizationProviderExtensionLoginConfiguration (string clientId, string issuer, NSUrl tokenEndpointUrl, NSUrl jwksEndpointUrl, string? audience)
			: base (NSObjectFlag.Empty)
		{
			if (clientId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (clientId));
			if (issuer is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (issuer));
			var tokenEndpointUrl__handle__ = tokenEndpointUrl!.GetNonNullHandle (nameof (tokenEndpointUrl));
			var jwksEndpointUrl__handle__ = jwksEndpointUrl!.GetNonNullHandle (nameof (jwksEndpointUrl));
			var nsclientId = CFString.CreateNative (clientId);
			var nsissuer = CFString.CreateNative (issuer);
			var nsaudience = CFString.CreateNative (audience);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithClientID_Issuer_TokenEndpointURL_JwksEndpointURL_Audience_XHandle, nsclientId, nsissuer, tokenEndpointUrl__handle__, jwksEndpointUrl__handle__, nsaudience), "initWithClientID:issuer:tokenEndpointURL:jwksEndpointURL:audience:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithClientID_Issuer_TokenEndpointURL_JwksEndpointURL_Audience_XHandle, nsclientId, nsissuer, tokenEndpointUrl__handle__, jwksEndpointUrl__handle__, nsaudience), "initWithClientID:issuer:tokenEndpointURL:jwksEndpointURL:audience:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tokenEndpointUrl);
			GC.KeepAlive (jwksEndpointUrl);
			CFString.ReleaseNative (nsclientId);
			CFString.ReleaseNative (nsissuer);
			CFString.ReleaseNative (nsaudience);
		}
		[Export ("configurationWithOpenIDConfigurationURL:clientID:issuer:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Create (NSUrl openIdConfigurationUrl, string clientId, string? issuer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V32))]global::System.Action<ASAuthorizationProviderExtensionLoginConfiguration, NSError> handler)
		{
			var openIdConfigurationUrl__handle__ = openIdConfigurationUrl!.GetNonNullHandle (nameof (openIdConfigurationUrl));
			if (clientId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (clientId));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			var nsclientId = CFString.CreateNative (clientId);
			var nsissuer = CFString.CreateNative (issuer);
			using var block_handler = Trampolines.SDActionArity2V32.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selConfigurationWithOpenIDConfigurationURL_ClientID_Issuer_Completion_XHandle, openIdConfigurationUrl__handle__, nsclientId, nsissuer, (IntPtr) block_ptr_handler);
			GC.KeepAlive (openIdConfigurationUrl);
			CFString.ReleaseNative (nsclientId);
			CFString.ReleaseNative (nsissuer);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<ASAuthorizationProviderExtensionLoginConfiguration> CreateAsync (NSUrl openIdConfigurationUrl, string clientId, string? issuer)
		{
			var tcs = new TaskCompletionSource<ASAuthorizationProviderExtensionLoginConfiguration> ();
			Create(openIdConfigurationUrl, clientId, issuer, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("setCustomAssertionRequestBodyClaims:returningError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetCustomAssertionRequestBodyClaims (NSDictionary<NSString, NSObject> claims, out NSError? error)
		{
			var claims__handle__ = claims!.GetNonNullHandle (nameof (claims));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSetCustomAssertionRequestBodyClaims_ReturningError_XHandle, claims__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSetCustomAssertionRequestBodyClaims_ReturningError_XHandle, claims__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (claims);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("setCustomAssertionRequestHeaderClaims:returningError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetCustomAssertionRequestHeaderClaims (NSDictionary<NSString, NSObject> claims, out NSError? error)
		{
			var claims__handle__ = claims!.GetNonNullHandle (nameof (claims));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSetCustomAssertionRequestHeaderClaims_ReturningError_XHandle, claims__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSetCustomAssertionRequestHeaderClaims_ReturningError_XHandle, claims__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (claims);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("setCustomKeyExchangeRequestBodyClaims:returningError:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetCustomKeyExchangeRequestBodyClaims (NSDictionary<NSString, NSObject> claims, out NSError? error)
		{
			var claims__handle__ = claims!.GetNonNullHandle (nameof (claims));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSetCustomKeyExchangeRequestBodyClaims_ReturningError_XHandle, claims__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSetCustomKeyExchangeRequestBodyClaims_ReturningError_XHandle, claims__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (claims);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("setCustomKeyExchangeRequestHeaderClaims:returningError:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetCustomKeyExchangeRequestHeaderClaims (NSDictionary<NSString, NSObject> claims, out NSError? error)
		{
			var claims__handle__ = claims!.GetNonNullHandle (nameof (claims));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSetCustomKeyExchangeRequestHeaderClaims_ReturningError_XHandle, claims__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSetCustomKeyExchangeRequestHeaderClaims_ReturningError_XHandle, claims__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (claims);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("setCustomKeyRequestBodyClaims:returningError:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetCustomKeyRequestBodyClaims (NSDictionary<NSString, NSObject> claims, out NSError? error)
		{
			var claims__handle__ = claims!.GetNonNullHandle (nameof (claims));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSetCustomKeyRequestBodyClaims_ReturningError_XHandle, claims__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSetCustomKeyRequestBodyClaims_ReturningError_XHandle, claims__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (claims);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("setCustomKeyRequestHeaderClaims:returningError:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetCustomKeyRequestHeaderClaims (NSDictionary<NSString, NSObject> claims, out NSError? error)
		{
			var claims__handle__ = claims!.GetNonNullHandle (nameof (claims));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSetCustomKeyRequestHeaderClaims_ReturningError_XHandle, claims__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSetCustomKeyRequestHeaderClaims_ReturningError_XHandle, claims__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (claims);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("setCustomLoginRequestBodyClaims:returningError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetCustomLoginRequestBodyClaims (NSDictionary<NSString, NSObject> claims, out NSError? error)
		{
			var claims__handle__ = claims!.GetNonNullHandle (nameof (claims));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSetCustomLoginRequestBodyClaims_ReturningError_XHandle, claims__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSetCustomLoginRequestBodyClaims_ReturningError_XHandle, claims__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (claims);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("setCustomLoginRequestHeaderClaims:returningError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetCustomLoginRequestHeaderClaims (NSDictionary<NSString, NSObject> claims, out NSError? error)
		{
			var claims__handle__ = claims!.GetNonNullHandle (nameof (claims));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSetCustomLoginRequestHeaderClaims_ReturningError_XHandle, claims__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSetCustomLoginRequestHeaderClaims_ReturningError_XHandle, claims__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (claims);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("setCustomRefreshRequestBodyClaims:returningError:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetCustomRefreshRequestBodyClaims (NSDictionary<NSString, NSObject> claims, out NSError? error)
		{
			var claims__handle__ = claims!.GetNonNullHandle (nameof (claims));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSetCustomRefreshRequestBodyClaims_ReturningError_XHandle, claims__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSetCustomRefreshRequestBodyClaims_ReturningError_XHandle, claims__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (claims);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("setCustomRefreshRequestHeaderClaims:returningError:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetCustomRefreshRequestHeaderClaims (NSDictionary<NSString, NSObject> claims, out NSError? error)
		{
			var claims__handle__ = claims!.GetNonNullHandle (nameof (claims));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSetCustomRefreshRequestHeaderClaims_ReturningError_XHandle, claims__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSetCustomRefreshRequestHeaderClaims_ReturningError_XHandle, claims__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (claims);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AccountDisplayName {
			[Export ("accountDisplayName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccountDisplayNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccountDisplayNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccountDisplayName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccountDisplayName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccountDisplayName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual string? AdditionalAuthorizationScopes {
			[Export ("additionalAuthorizationScopes")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAdditionalAuthorizationScopesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAdditionalAuthorizationScopesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAdditionalAuthorizationScopes:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAdditionalAuthorizationScopes_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAdditionalAuthorizationScopes_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AdditionalScopes {
			[Export ("additionalScopes")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAdditionalScopesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAdditionalScopesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAdditionalScopes:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAdditionalScopes_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAdditionalScopes_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Audience {
			[Export ("audience")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAudienceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAudienceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAudience:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAudience_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAudience_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ClientId {
			[Export ("clientID")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selClientIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selClientIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSUrlQueryItem[] CustomFederationUserPreauthenticationRequestValues {
			[Export ("customFederationUserPreauthenticationRequestValues", ArgumentSemantic.Copy)]
			get {
				NSUrlQueryItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSUrlQueryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomFederationUserPreauthenticationRequestValuesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSUrlQueryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomFederationUserPreauthenticationRequestValuesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCustomFederationUserPreauthenticationRequestValues:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCustomFederationUserPreauthenticationRequestValues_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCustomFederationUserPreauthenticationRequestValues_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSUrlQueryItem[] CustomKeyExchangeRequestValues {
			[Export ("customKeyExchangeRequestValues", ArgumentSemantic.Copy)]
			get {
				NSUrlQueryItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSUrlQueryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomKeyExchangeRequestValuesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSUrlQueryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomKeyExchangeRequestValuesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCustomKeyExchangeRequestValues:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCustomKeyExchangeRequestValues_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCustomKeyExchangeRequestValues_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSUrlQueryItem[] CustomKeyRequestValues {
			[Export ("customKeyRequestValues", ArgumentSemantic.Copy)]
			get {
				NSUrlQueryItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSUrlQueryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomKeyRequestValuesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSUrlQueryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomKeyRequestValuesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCustomKeyRequestValues:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCustomKeyRequestValues_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCustomKeyRequestValues_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlQueryItem[] CustomLoginRequestValues {
			[Export ("customLoginRequestValues", ArgumentSemantic.Copy)]
			get {
				NSUrlQueryItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSUrlQueryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomLoginRequestValuesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSUrlQueryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomLoginRequestValuesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCustomLoginRequestValues:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCustomLoginRequestValues_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCustomLoginRequestValues_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlQueryItem[] CustomNonceRequestValues {
			[Export ("customNonceRequestValues", ArgumentSemantic.Copy)]
			get {
				NSUrlQueryItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSUrlQueryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomNonceRequestValuesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSUrlQueryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomNonceRequestValuesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCustomNonceRequestValues:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCustomNonceRequestValues_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCustomNonceRequestValues_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSUrlQueryItem[] CustomRefreshRequestValues {
			[Export ("customRefreshRequestValues", ArgumentSemantic.Copy)]
			get {
				NSUrlQueryItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSUrlQueryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomRefreshRequestValuesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSUrlQueryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomRefreshRequestValuesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCustomRefreshRequestValues:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCustomRefreshRequestValues_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCustomRefreshRequestValues_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual string? CustomRequestJwtParameterName {
			[Export ("customRequestJWTParameterName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomRequestJWTParameterNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomRequestJWTParameterNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCustomRequestJWTParameterName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCustomRequestJWTParameterName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCustomRequestJWTParameterName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSData? DeviceContext {
			[Export ("deviceContext", ArgumentSemantic.Copy)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeviceContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeviceContextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDeviceContext:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDeviceContext_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDeviceContext_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSUrl? FederationMexUrl {
			[Export ("federationMEXURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFederationMEXURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFederationMEXURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFederationMEXURL:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFederationMEXURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFederationMEXURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual string? FederationMexUrlKeypath {
			[Export ("federationMEXURLKeypath")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFederationMEXURLKeypathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFederationMEXURLKeypathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFederationMEXURLKeypath:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFederationMEXURLKeypath_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFederationMEXURLKeypath_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual string? FederationPredicate {
			[Export ("federationPredicate")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFederationPredicateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFederationPredicateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFederationPredicate:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFederationPredicate_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFederationPredicate_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual string? FederationRequestUrn {
			[Export ("federationRequestURN")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFederationRequestURNXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFederationRequestURNXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFederationRequestURN:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFederationRequestURN_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFederationRequestURN_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual ASAuthorizationProviderExtensionFederationType FederationType {
			[Export ("federationType", ArgumentSemantic.Assign)]
			get {
				ASAuthorizationProviderExtensionFederationType ret;
				if (IsDirectBinding) {
					ret = (AuthenticationServices.ASAuthorizationProviderExtensionFederationType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFederationTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AuthenticationServices.ASAuthorizationProviderExtensionFederationType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selFederationTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFederationType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFederationType_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetFederationType_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSUrl? FederationUserPreauthenticationUrl {
			[Export ("federationUserPreauthenticationURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFederationUserPreauthenticationURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFederationUserPreauthenticationURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFederationUserPreauthenticationURL:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFederationUserPreauthenticationURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFederationUserPreauthenticationURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual string? GroupRequestClaimName {
			[Export ("groupRequestClaimName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGroupRequestClaimNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGroupRequestClaimNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setGroupRequestClaimName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetGroupRequestClaimName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetGroupRequestClaimName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual string? GroupResponseClaimName {
			[Export ("groupResponseClaimName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGroupResponseClaimNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGroupResponseClaimNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setGroupResponseClaimName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetGroupResponseClaimName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetGroupResponseClaimName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual global::Security.SecKey? HpkeAuthPublicKey {
			[Export ("hpkeAuthPublicKey")]
			get {
				global::Security.SecKey ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::Security.SecKey> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHpkeAuthPublicKeyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::Security.SecKey> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHpkeAuthPublicKeyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setHpkeAuthPublicKey:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHpkeAuthPublicKey_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHpkeAuthPublicKey_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSData? HpkePreSharedKey {
			[Export ("hpkePreSharedKey", ArgumentSemantic.Copy)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHpkePreSharedKeyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHpkePreSharedKeyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setHpkePreSharedKey:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHpkePreSharedKey_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHpkePreSharedKey_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSData? HpkePreSharedKeyId {
			[Export ("hpkePreSharedKeyID", ArgumentSemantic.Copy)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHpkePreSharedKeyIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHpkePreSharedKeyIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setHpkePreSharedKeyID:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHpkePreSharedKeyID_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHpkePreSharedKeyID_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IncludePreviousRefreshTokenInLoginRequest {
			[Export ("includePreviousRefreshTokenInLoginRequest")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIncludePreviousRefreshTokenInLoginRequestXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIncludePreviousRefreshTokenInLoginRequestXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setIncludePreviousRefreshTokenInLoginRequest:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIncludePreviousRefreshTokenInLoginRequest_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetIncludePreviousRefreshTokenInLoginRequest_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? InvalidCredentialPredicate {
			[Export ("invalidCredentialPredicate")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInvalidCredentialPredicateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInvalidCredentialPredicateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setInvalidCredentialPredicate:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInvalidCredentialPredicate_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInvalidCredentialPredicate_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Issuer {
			[Export ("issuer")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIssuerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIssuerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl JwksEndpointUrl {
			[Export ("jwksEndpointURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selJwksEndpointURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selJwksEndpointURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setJwksEndpointURL:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetJwksEndpointURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetJwksEndpointURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSObject[] JwksTrustedRootCertificates {
			[Export ("jwksTrustedRootCertificates", ArgumentSemantic.Copy)]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selJwksTrustedRootCertificatesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selJwksTrustedRootCertificatesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setJwksTrustedRootCertificates:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetJwksTrustedRootCertificates_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetJwksTrustedRootCertificates_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ASAuthorizationProviderExtensionKerberosMapping[] KerberosTicketMappings {
			[Export ("kerberosTicketMappings", ArgumentSemantic.Copy)]
			get {
				ASAuthorizationProviderExtensionKerberosMapping[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<ASAuthorizationProviderExtensionKerberosMapping>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selKerberosTicketMappingsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<ASAuthorizationProviderExtensionKerberosMapping>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selKerberosTicketMappingsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setKerberosTicketMappings:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetKerberosTicketMappings_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetKerberosTicketMappings_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSUrl? KeyEndpointUrl {
			[Export ("keyEndpointURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selKeyEndpointURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selKeyEndpointURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setKeyEndpointURL:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetKeyEndpointURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetKeyEndpointURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual ASAuthorizationProviderExtensionEncryptionAlgorithm LoginRequestEncryptionAlgorithm {
			[Export ("loginRequestEncryptionAlgorithm", ArgumentSemantic.Copy)]
			get {
				ASAuthorizationProviderExtensionEncryptionAlgorithm ret;
				if (IsDirectBinding) {
					ret = (ASAuthorizationProviderExtensionEncryptionAlgorithm) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLoginRequestEncryptionAlgorithmXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (ASAuthorizationProviderExtensionEncryptionAlgorithm) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selLoginRequestEncryptionAlgorithmXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLoginRequestEncryptionAlgorithm:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetLoginRequestEncryptionAlgorithm_XHandle, (int)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetLoginRequestEncryptionAlgorithm_XHandle, (int)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSData? LoginRequestEncryptionApvPrefix {
			[Export ("loginRequestEncryptionAPVPrefix", ArgumentSemantic.Copy)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLoginRequestEncryptionAPVPrefixXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLoginRequestEncryptionAPVPrefixXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLoginRequestEncryptionAPVPrefix:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLoginRequestEncryptionAPVPrefix_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLoginRequestEncryptionAPVPrefix_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual global::Security.SecKey LoginRequestEncryptionPublicKey {
			[SupportedOSPlatform ("macos14.0")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				return new SecKey (this._LoginRequestEncryptionPublicKey, owns: false);
			}
			[SupportedOSPlatform ("macos14.0")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			set {
				_LoginRequestEncryptionPublicKey = Runtime.RetainAndAutoreleaseNativeObject (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSData? LoginRequestHpkePreSharedKey {
			[Export ("loginRequestHPKEPreSharedKey", ArgumentSemantic.Copy)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLoginRequestHPKEPreSharedKeyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLoginRequestHPKEPreSharedKeyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLoginRequestHPKEPreSharedKey:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLoginRequestHPKEPreSharedKey_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLoginRequestHPKEPreSharedKey_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSData? LoginRequestHpkePreSharedKeyID {
			[Export ("loginRequestHPKEPreSharedKeyID", ArgumentSemantic.Copy)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLoginRequestHPKEPreSharedKeyIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLoginRequestHPKEPreSharedKeyIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLoginRequestHPKEPreSharedKeyID:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLoginRequestHPKEPreSharedKeyID_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLoginRequestHPKEPreSharedKeyID_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl NonceEndpointUrl {
			[Export ("nonceEndpointURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNonceEndpointURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNonceEndpointURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setNonceEndpointURL:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetNonceEndpointURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetNonceEndpointURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string NonceResponseKeypath {
			[Export ("nonceResponseKeypath")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNonceResponseKeypathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNonceResponseKeypathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNonceResponseKeypath:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetNonceResponseKeypath_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetNonceResponseKeypath_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PreviousRefreshTokenClaimName {
			[Export ("previousRefreshTokenClaimName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreviousRefreshTokenClaimNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreviousRefreshTokenClaimNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreviousRefreshTokenClaimName:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPreviousRefreshTokenClaimName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPreviousRefreshTokenClaimName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSUrl? RefreshEndpointUrl {
			[Export ("refreshEndpointURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRefreshEndpointURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRefreshEndpointURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRefreshEndpointURL:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetRefreshEndpointURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetRefreshEndpointURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ServerNonceClaimName {
			[Export ("serverNonceClaimName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selServerNonceClaimNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selServerNonceClaimNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setServerNonceClaimName:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetServerNonceClaimName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetServerNonceClaimName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl TokenEndpointUrl {
			[Export ("tokenEndpointURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTokenEndpointURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTokenEndpointURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTokenEndpointURL:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTokenEndpointURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTokenEndpointURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual string? UniqueIdentifierClaimName {
			[Export ("uniqueIdentifierClaimName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUniqueIdentifierClaimNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUniqueIdentifierClaimNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setUniqueIdentifierClaimName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetUniqueIdentifierClaimName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUniqueIdentifierClaimName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual ASAuthorizationProviderExtensionUserSecureEnclaveKeyBiometricPolicy UserSecureEnclaveKeyBiometricPolicy {
			[Export ("userSecureEnclaveKeyBiometricPolicy", ArgumentSemantic.Assign)]
			get {
				ASAuthorizationProviderExtensionUserSecureEnclaveKeyBiometricPolicy ret;
				if (IsDirectBinding) {
					ret = (AuthenticationServices.ASAuthorizationProviderExtensionUserSecureEnclaveKeyBiometricPolicy) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selUserSecureEnclaveKeyBiometricPolicyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AuthenticationServices.ASAuthorizationProviderExtensionUserSecureEnclaveKeyBiometricPolicy) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selUserSecureEnclaveKeyBiometricPolicyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUserSecureEnclaveKeyBiometricPolicy:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetUserSecureEnclaveKeyBiometricPolicy_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetUserSecureEnclaveKeyBiometricPolicy_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		internal virtual nint _LoginRequestEncryptionPublicKey {
			[Export ("loginRequestEncryptionPublicKey", ArgumentSemantic.Assign)]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLoginRequestEncryptionPublicKeyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selLoginRequestEncryptionPublicKeyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLoginRequestEncryptionPublicKey:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLoginRequestEncryptionPublicKey_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetLoginRequestEncryptionPublicKey_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class ASAuthorizationProviderExtensionLoginConfiguration */
}
