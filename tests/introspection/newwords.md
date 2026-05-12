# New words in the TypoTest allowed list compared to main (219 words)

## ACTUAL TYPOS in Apple APIs (12 words)
*These are genuine misspellings/errors in Apple's API names.*
### `Accurracy` → accuracy (double r)
[`src/corelocation.cs:271`](https://github.com/dotnet/macios/blob/6a356bdf007f4b59b1e996ccc55836cdbb5de431/src/corelocation.cs#L271)
```csharp
double AccurracyBestForNavigation { get; }
```

### `Aswas` → AsWas (missing camelCase split)
[`src/authenticationservices.cs:1348`](https://github.com/dotnet/macios/blob/6a356bdf007f4b59b1e996ccc55836cdbb5de431/src/authenticationservices.cs#L1348)
```csharp
void RegisterDefaultsForAswasInSetupAssistantIfNeeded ();
```

### `Denimonator` → denominator (transposed letters)
[`src/accessibility.cs:616`](https://github.com/dotnet/macios/blob/6a356bdf007f4b59b1e996ccc55836cdbb5de431/src/accessibility.cs#L616)
```csharp
AXMathExpression DenimonatorExpression { get; }
```

### `Diconnection` → disconnection (missing s)
[`src/corebluetooth.cs:546`](https://github.com/dotnet/macios/blob/6a356bdf007f4b59b1e996ccc55836cdbb5de431/src/corebluetooth.cs#L546)
```csharp
[iOS (17, 0), TV (17, 0), Mac (14, 0), MacCatalyst (17, 0), EventArgs ("CBPeripheralDiconnectionEvent")]
```

### `Dirbursement` → disbursement (transposed letters)
[`src/passkit.cs:3902`](https://github.com/dotnet/macios/blob/6a356bdf007f4b59b1e996ccc55836cdbb5de431/src/passkit.cs#L3902)
```csharp
interface PKDirbursementError {
```

### `Dismissable` → dismissible (-able vs -ible)
[`src/mailkit.cs:510`](https://github.com/dotnet/macios/blob/6a356bdf007f4b59b1e996ccc55836cdbb5de431/src/mailkit.cs#L510)
```csharp
bool Dismissable { [Bind ("isDismissable")] get; }
```

### `Emebedding` → embedding (transposed letters)
[`src/NaturalLanguage/Enums.cs:372`](https://github.com/dotnet/macios/blob/6a356bdf007f4b59b1e996ccc55836cdbb5de431/src/NaturalLanguage/Enums.cs#L372)
```csharp
public enum NLContextualEmebeddingKey {
```

### `Hermitean` → Hermitian (wrong vowels)
[`src/metalperformanceshadersgraph.cs:2479`](https://github.com/dotnet/macios/blob/6a356bdf007f4b59b1e996ccc55836cdbb5de431/src/metalperformanceshadersgraph.cs#L2479)
```csharp
[Export ("roundToOddHermitean")]
```

### `Inot` → into (transposed) or not (extra i)
[`src/mlcompute.cs:111`](https://github.com/dotnet/macios/blob/6a356bdf007f4b59b1e996ccc55836cdbb5de431/src/mlcompute.cs#L111)
```csharp
Inot32 = 7,
```

### `Remmote` → remote (double m)
[`src/Network/NWConnectionGroup.cs:119`](https://github.com/dotnet/macios/blob/6a356bdf007f4b59b1e996ccc55836cdbb5de431/src/Network/NWConnectionGroup.cs#L119)
```csharp
public NWEndpoint? GetRemmoteEndpoint (NWContentContext context)
```

### `Securit` → security (missing y)
[`src/CoreWlan/Enums.cs:118`](https://github.com/dotnet/macios/blob/6a356bdf007f4b59b1e996ccc55836cdbb5de431/src/CoreWlan/Enums.cs#L118)
```csharp
public enum CWSecurity : ulong {
```

### `Willl` → will (triple l)
[`src/avfoundation.cs:22540`](https://github.com/dotnet/macios/blob/6a356bdf007f4b59b1e996ccc55836cdbb5de431/src/avfoundation.cs#L22540)
```csharp
void WilllDownloadToUrl (NSUrlSession session, AVAssetDownloadTask assetDownloadTask, NSUrl location);
```


## ACCEPTABLE WORDS unknown to the spell checker (207 words)
*Valid abbreviations, acronyms, brand names, or domain-specific terms.*
  Abgr                      (pixel format: Alpha-Blue-Green-Red)
    src/coreimage.cs:3689
    [Obsolete ("Use 'CIFormat.Abgr8.GetConstant ()' instead.")]

  Activatable               (valid English: capable of being activated)
    src/pdfkit.cs:1436
    bool ActivatableTextField { [Bind ("isActivatableTextField")] get; }

  Adessive                  (grammatical case: near/at something)
    src/foundation.cs:1259
    Adessive,

  Afi                       (acronym: Application Family Identifier (NFC))
    src/corenfc.cs:324
    void WriteAfi (NFCIso15693RequestFlag flags, byte afi, Action<NSError> completionHandler);

  Ahap                      (acronym: Apple Haptic Audio Pattern)
    src/avfoundation.cs:537
    Ahap = 23,

  Aime                      (proper name (macOS API))
    src/avfoundation.cs:10073
    NSString QuickTimeMetadataAimeData { get; }

  Allative                  (grammatical case: motion towards)
    src/foundation.cs:1260
    Allative,

  Ancs                      (acronym: Apple Notification Center Service)
    src/corebluetooth.cs:115
    bool RequiresAncs { get; set; }

  Ane                       (acronym: Apple Neural Engine)
    src/mlcompute.cs:127
    Ane = 3, // Apple neural engine

  Apac                      (acronym: Asia-Pacific region code)
    src/AudioToolbox/AudioType.cs:148
    Apac = 0x61706163, // 'apac'

  Apdu                      (acronym: Application Protocol Data Unit)
    src/cryptotokenkit.cs:981
    NSData ApduTemplate { get; set; }

  Apl                       (acronym: Apple Pay Later)
    src/metrickit.cs:90
    MXUnitAveragePixelLuminance Apl { get; }

  Apns                      (acronym: Apple Push Notification Service)
    src/networkextension.cs:2547
    bool ExcludeApns { get; set; }

  Applei                    (Apple identifier prefix)
    src/avfoundation.cs:528
    [Field ("AVFileTypeAppleiTT")]

  Apv                       (acronym: Apple ProRes Video)
    src/authenticationservices.cs:2118
    NSData LoginRequestEncryptionApvPrefix { get; set; }

  Astc                      (acronym: Adaptive Scalable Texture Compression)
    src/imageio.cs:4515
    NSString AstcBlockSizeKey { get; }

  Atr                       (acronym: Answer To Reset (smart card))
    src/healthkit.cs:3314
    [Field ("HKQuantityTypeIdentifierAtrialFibrillationBurden")]

  Atsc                      (acronym: Advanced Television Systems Committee)
    src/CoreMedia/CMEnums.cs:644
    Atsc = (uint) CMClosedCaptionFormatType.ATSC,

  Audiograph                (audio processing graph)
    src/AppKit/Enums.cs:4432
    Audiograph,

  Authenticatable           (valid English: capable of being authenticated)
    src/authenticationservices.cs:2402
    interface IASAuthorizationWebBrowserExternallyAuthenticatableRequest { }

  Axept                     (payment system (Norwegian))
    src/passkit.cs:1986
    [Field ("PKPaymentNetworkBankAxept")]

  Bancomat                  (payment system (European ATM network))
    src/passkit.cs:1966
    [Field ("PKPaymentNetworkBancomat")]

  Ber                       (acronym: Basic Encoding Rules)
    src/Foundation/NSUrlSessionHandler.cs:6
    //     Nick Berardi <nick@nickberardi.com>

  Bgrx                      (pixel format: Blue-Green-Red-padded)
    src/coregraphics.cs:708
    Bgrx,

  Blockmap                  (compound: block map)
    src/fskit.cs:1088
    public enum FSBlockmapFlags : ulong {

  Blockquote                (HTML element: block quotation)
    src/appkit.cs:34939
    [Field ("NSAccessibilityBlockquoteSameLevelSearchKey")]

  Brotli                    (compression algorithm (Google))
    src/Compression/Enums.cs:19
    /// <summary>The Brotli compression format. The encoder in the Compression framework only supports the Brotli level 2 en...

  Bsd                       (acronym: Berkeley Software Distribution)
    src/fskit.cs:404
    string BsdName { get; }

  Callables                 (valid English: things that can be called)
    src/metalperformanceshadersgraph.cs:2027
    NSDictionary<NSString, MPSGraphExecutable> Callables { get; set; }

  Catmull                   (proper name: Catmull-Rom spline)
    src/Metal/MTLEnums.cs:2419
    CatmullRom = 1,

  Cct                       (acronym: Correlated Color Temperature)
    src/avfoundation.cs:10036
    NSString QuickTimeMetadataWhiteBalanceByCctColorMatrices { get; }

  Ccw                       (acronym: Counter-Clockwise)
    src/vision.cs:101
    ScaleFitRotate90Ccw = 256 + ScaleFit,

  Cdma                      (acronym: Code Division Multiple Access)
    src/Network/NWEnums.cs:331
    CellCdma = 0x87,

  Cea                       (acronym: Consumer Electronics Association)
    src/CoreMedia/CMEnums.cs:640
    Cea608 = (uint) CMClosedCaptionFormatType.CEA608,

  Chw                       (tensor layout: Channel-Height-Width)
    src/MetalPerformanceShadersGraph/MPSGraphEnums.cs:19
    Chw = 4,

  Cinemagraph               (photography: still photo with minor motion)
    src/tvservices.cs:199
    NSUrl CinemagraphUrl { get; set; }

  Cla                       (acronym: Class byte (smart card))
    src/appkit.cs:4
    // Coprightt 2010, James Clancey

  Clockstamp                (compound: clock stamp (timing))
    src/coremidi.cs:177
    DeltaClockstampTicksPerQuarterNote = 0x3,

  Codabar                   (barcode format)
    src/avfoundation.cs:12378
    [Field ("AVMetadataObjectTypeCodabarCode")]

  Conecs                    (payment system (French meal voucher))
    src/passkit.cs:2006
    [Field ("PKPaymentNetworkConecs")]

  Conv                      (abbreviation: convolution)
    src/scenekit.cs:2244
    float ConvertUnitsToMeters { get; set; } /* 'floating value encapsulated in a NSNumber' probably a float since it's a gr...

  Cose                      (acronym: CBOR Object Signing and Encryption)
    src/authenticationservices.cs:1565
    enum ASCoseAlgorithmIdentifier : long {

  Csr                       (acronym: Certificate Signing Request)
    src/MetalPerformanceShadersGraph/MPSGraphEnums.cs:96
    Csr = 2,

  Ctor                      (abbreviation: constructor)
    src/appkit.cs:640
    [DisableDefaultCtor] // An uncaught exception was raised: Creating more than one Application

  Dangi                     (Korean traditional calendar)
    src/foundation.cs:1836
    [Field ("NSCalendarIdentifierDangi")]

  Dankort                   (payment system (Danish debit card))
    src/passkit.cs:1830
    [Field ("PKPaymentNetworkDankort")]

  Denoise                   (valid English: remove noise)
    src/metalperformanceshaders.cs:17648
    [BaseType (typeof (NSObject), Name = "MPSSVGFDenoiser")]

  Denoised                  (valid English: noise removed)
    src/metalfx.cs:390
    interface IMTL4FXTemporalDenoisedScaler { }

  Dequantize                (ML term: reverse quantization)
    src/metalperformanceshaders.cs:16576
    [BaseType (typeof (MPSNDArrayMultiaryKernel), Name = "MPSNDArrayLUTDequantize")]

  Dfsi                      (acronym: Digital Feature Selector Identifier)
    src/corenfc.cs:342
    void LockDfsi (NFCIso15693RequestFlag flags, Action<NSError> completionHandler);

  Dhs                       (acronym: Diffie-Hellman Secret)
    src/passkit.cs:3558
    PKIdentityElement DocumentDhsComplianceStatusElement { get; }

  Dhwio                     (tensor layout: Depth-Height-Width-Input-Output)
    src/MetalPerformanceShadersGraph/MPSGraphEnums.cs:29
    Dhwio = 10,

  Dicom                     (acronym: Digital Imaging and Communications in Medicine)
    src/avfoundation.cs:542
    Dicom = 24,

  Dnssec                    (acronym: Domain Name System Security Extensions)
    src/Network/NWParameters.cs:649
    public bool RequiresDnssecValidation {

  Dsf                       (acronym: DSD Stream File)
    src/corenfc.cs:336
    void WriteDsfi (NFCIso15693RequestFlag flags, byte dsfid, Action<NSError> completionHandler);

  Dsfi                      (acronym: Digital Selector Feature Identifier)
    src/corenfc.cs:336
    void WriteDsfi (NFCIso15693RequestFlag flags, byte dsfid, Action<NSError> completionHandler);

  Dstu                      (acronym: Ukrainian national standard)
    src/HealthKit/Enums.cs:936
    Dstu2,

  Dtss                      (acronym: Data Transport Security Session)
    src/mediaextension.cs:262
    bool SamplesWithEarlierDtssMayHaveLaterPtssThanCursor (IMESampleCursor cursor);

  Ecg                       (acronym: Electrocardiogram)
    src/healthkit.cs:533
    NSString EcgClassification { get; }

  Elative                   (grammatical case: out of something)
    src/foundation.cs:1261
    Elative,

  Endc                      (acronym: E-UTRA-NR Dual Connectivity (5G))
    src/Network/NWEnums.cs:325
    CellEndcSub6 = 0x81,

  Erf                       (math: error function)
    src/metalperformanceshadersgraph.cs:285
    MPSGraphTensor Erf (MPSGraphTensor tensor, [NullAllowed] string name);

  Essive                    (grammatical case: being in a state)
    src/foundation.cs:1263
    Essive,

  Evdo                      (acronym: Evolution-Data Optimized (cellular))
    src/Network/NWEnums.cs:332
    CellEvdo = 0x88,

  Evictable                 (valid English: capable of being evicted)
    src/fileprovider.cs:173
    NonEvictableChildren = -2006,

  Extrinsics                (valid English: extrinsic camera parameters)
    src/imageio.cs:4682
    interface IOCameraExtrinsics {

  Feli                      (NFC: prefix for FeliCa (Sony contactless))
    src/passkit.cs:294
    /// <summary>Gets a Boolean value that tells whether Felica passes can be added to the library.</summary>

  Fft                       (acronym: Fast Fourier Transform)
    src/metalperformanceshadersgraph.cs:2339
    public enum MPSGraphFftScalingMode : ulong {

  Fieldset                  (HTML element: form field grouping)
    src/browserenginekit.cs:1091
    Fieldset = 1uL << 3,

  Fqdns                     (acronym: Fully Qualified Domain Names)
    src/networkextension.cs:4944
    string [] MatchFqdns { get; set; }

  Gainmap                   (HDR: gain map for tone mapping)
    src/imageio.cs:4441
    [Field ("kCGImageDestinationEncodeToISOGainmap")]

  Gbtac                     (acronym: Game Boy/Bluetooth Accessory Controller)
    src/intents.cs:3346
    Gbtac,

  Gbtdc                     (acronym: Game Boy/Bluetooth Device Controller)
    src/intents.cs:3349
    Gbtdc,

  Gcm                       (acronym: Galois/Counter Mode)
    src/security.cs:1245
    RsaEncryptionOaepSha224AesGcm,

  Gid                       (acronym: Group Identifier)
    src/fskit.cs:166
    Gid = 1L << 4,

  Gles                      (acronym: OpenGL ES)
    src/corevideo.cs:965
    NSString OpenGlesCompatibility { get; }

  Groupless                 (valid English: without a group)
    src/CoreMidi/MidiServices.cs:1782
    public bool UmpCanTransmitGroupless {

  Hhr                       (acronym: Half-Hour)
    src/videotoolbox.cs:1974
    bool PropagatePerFrameHhrDisplayMetadata { get; set; }

  Himyan                    (Himyarite (South Arabian script))
    src/passkit.cs:1994
    [Field ("PKPaymentNetworkHimyan")]

  Hindlegs                  (compound: hind legs (anatomy))
    src/vision.cs:938
    [Field ("VNAnimalBodyPoseObservationJointsGroupNameHindlegs")]

  Histogrammed              (valid English: processed into histogram)
    src/metrickit.cs:125
    MXHistogram<MXUnitSignalBars> HistogrammedCellularConditionTime { get; }

  Hpke                      (acronym: Hybrid Public Key Encryption)
    src/authenticationservices.cs:2195
    NSData LoginRequestHpkePreSharedKey { get; set; }

  Hwc                       (tensor layout: Height-Width-Channel)
    src/MetalPerformanceShadersGraph/MPSGraphEnums.cs:20
    Hwc = 5,

  Hwio                      (tensor layout: Height-Width-Input-Output)
    src/MetalPerformanceShadersGraph/MPSGraphEnums.cs:18
    Hwio = 3,

  Iap                       (acronym: In-App Purchase)
    src/intents.cs:16566
    string Iap2Identifier { get; }

  Iec                       (acronym: International Electrotechnical Commission)
    src/avfoundation.cs:20411
    NSString Iec_sRgb { get; }

  Imei                      (acronym: International Mobile Equipment Identity)
    src/uikit.cs:24802
    NSString CellularImei { get; }

  Inessive                  (grammatical case: being within)
    src/foundation.cs:1264
    Inessive,

  Interactable              (valid English: capable of interaction)
    src/appkit.cs:31162
    [Field ("NSAccessibilityAutoInteractableAttribute")]

  Intravaginal              (medical: within the vagina)
    src/healthkit.cs:5731
    IntravaginalRing,

  Isrc                      (acronym: International Standard Recording Code)
    src/avfoundation.cs:25891
    NSObject Isrc { get; set; }

  Itt                       (acronym: Intent To Track)
    src/avfoundation.cs:24883
    AVCaptionRegion AppleIttTopRegion { get; }

  Jaywan                    (payment system)
    src/passkit.cs:1998
    [Field ("PKPaymentNetworkJaywan")]

  Jrts                      (acronym: Japanese Real-Time Settlement)
    src/coremidi.cs:1249
    bool HasJrtsReceiveCapability { get; }

  Jwks                      (acronym: JSON Web Key Set)
    src/authenticationservices.cs:2018
    NSUrl JwksEndpointUrl { get; set; }

  Jws                       (acronym: JSON Web Signature)
    src/healthkit.cs:5796
    NSData JwsRepresentation { get; }

  Jwt                       (acronym: JSON Web Token)
    src/authenticationservices.cs:1582
    JwtBearer = 1L << 1,

  Keepalive                 (networking: keep-alive connection)
    src/Network/NWQuicMetadata.cs:31
    public ushort KeepaliveInterval {

  Keycode                   (compound: key code (input))
    src/CoreGraphics/CGEventTypes.cs:189
    KeyboardEventKeycode = 9,

  Keypath                   (compound: key path (KVO))
    src/authenticationservices.cs:2023
    [Export ("nonceResponseKeypath")]

  Kickboard                 (fitness: swimming kickboard)
    src/HealthKit/Enums.cs:715
    Kickboard = 6,

  Lbc                       (acronym: Location-Based Content)
    src/CoreMedia/CMEnums.cs:515
    ILbc = (uint) AudioFormatType.iLBC,

  Lte                       (acronym: Long-Term Evolution (4G))
    src/Network/NWEnums.cs:324
    CellLte = 0x80,

  Ltr                       (acronym: Left-To-Right)
    src/videotoolbox.cs:392
    NSString EnableLtr { get; }

  Lut                       (acronym: Look-Up Table)
    src/metalperformanceshaders.cs:16526
    Lut,

  Mebx                      (Intel Management Engine BIOS Extension)
    src/CoreMedia/CMTag.cs:57
    public static CMTag MediaSubTypeMebx { get => CMTagConstants.MediaSubTypeMebx; }

  Meeza                     (payment system (Egyptian))
    src/passkit.cs:1982
    [Field ("PKPaymentNetworkMeeza")]

  Mennekes                  (brand: EV charging connector type)
    src/intents.cs:3356
    [Field ("INCarChargingConnectorTypeMennekes")]

  Mifare                    (NFC: NXP contactless smart card technology)
    src/corenfc.cs:1107
    NFCMiFareFamily MifareFamily { get; }

  Mmw                       (acronym: Millimeter Wave)
    src/Network/NWEnums.cs:326
    CellEndcMmw = 0x82,

  Monoline                  (typography: single-weight stroke)
    src/pencilkit.cs:59
    [Field ("PKInkTypeMonoline")]

  Msi                       (acronym: Microsoft Installer / Mobile Station Identity)
    src/vision.cs:203
    MsiPlessey,

  Mtl                       (abbreviation: Metal (Apple GPU framework))
    src/metal.cs:5127
    IMTL4CommandQueue Mtl4CommandQueue { get; }

  Muid                      (acronym: Machine Unique Identifier)
    src/coremidi.cs:837
    bool ConnectInitiator (NSNumber initiatorMuid, MidiCIDeviceInfo deviceInfo);

  Multiary                  (valid English: having multiple parts)
    src/metalperformanceshaders.cs:3727
    [BaseType (typeof (MPSNDArrayMultiaryKernel))]

  Multiscript               (typography: supporting multiple scripts)
    src/accessibility.cs:622
    interface AXMathExpressionMultiscript {

  Multiselect               (UI: multiple selection)
    src/uikit.cs:33058
    interface UICellAccessoryMultiselect {

  Multivariant              (HLS: multi-variant playlist)
    src/avfoundation.cs:26455
    [Export ("isMultivariantPlaylist")]

  Multiview                 (valid English: multiple views)
    src/avfoundation.cs:372
    [Field ("AVMediaCharacteristicContainsStereoMultiviewVideo")]

  Nacs                      (acronym: North American Charging Standard)
    src/intents.cs:3351
    [Deprecated (PlatformName.iOS, 17, 4, message: "Use 'INCarChargingConnectorType.NacsDc' instead.")]

  Nanaco                    (payment system (Japanese e-money))
    src/passkit.cs:1954
    [Field ("PKPaymentNetworkNanaco")]

  Nand                      (logic gate: NOT AND)
    src/mlcompute.cs:2625
    LogicalNand = 9,

  Ncdhw                     (tensor layout: Batch-Channel-Depth-Height-Width)
    src/MetalPerformanceShadersGraph/MPSGraphEnums.cs:23
    Ncdhw = 7,

  Nchw                      (tensor layout: Batch-Channel-Height-Width)
    src/MetalPerformanceShadersGraph/MPSGraphEnums.cs:15
    Nchw = 0,

  nd                        (tensor: n-dimensional)
    src/appkit.cs:8
    // a copy of this software and associated documentation files (the

  Ndhwc                     (tensor layout: Batch-Depth-Height-Width-Channel)
    src/MetalPerformanceShadersGraph/MPSGraphEnums.cs:25
    Ndhwc = 8,

  Nfc                       (acronym: Near Field Communication)
    src/cryptotokenkit.cs:517
    delegate void TKCreateNfcSlotCallback ([NullAllowed] TKSmartCardSlotNFCSession session, [NullAllowed] NSError error);

  Nhwc                      (tensor layout: Batch-Height-Width-Channel)
    src/MetalPerformanceShadersGraph/MPSGraphEnums.cs:16
    Nhwc = 1,

  Noninteractive            (valid English: not interactive)
    src/xkit.cs:5169
    Noninteractive,

  Noop                      (abbreviation: no operation)
    src/coremidi.cs:173
    Noop = 0,

  Nsa                       (acronym: Non-Standalone (5G architecture))
    src/coretelephony.cs:137
    NSString NRNsa { get; }

  Ocr                       (acronym: Optical Character Recognition)
    src/pdfkit.cs:604
    NSString SaveTextFromOcrKey { get; }

  Odia                      (language: Odia (Indian language))
    src/foundation.cs:1820
    [Field ("NSCalendarIdentifierOdia")]

  Ohwi                      (tensor layout: Output-Height-Width-Input)
    src/metalperformanceshaders.cs:16607
    Ohwi = 0,

  Oidhw                     (tensor layout: Output-Input-Depth-Height-Width)
    src/MetalPerformanceShadersGraph/MPSGraphEnums.cs:27
    Oidhw = 9,

  Oihw                      (tensor layout: Output-Input-Height-Width)
    src/MetalPerformanceShadersGraph/MPSGraphEnums.cs:17
    Oihw = 2,

  Onnx                      (acronym: Open Neural Network Exchange)
    src/MetalPerformanceShadersGraph/MPSGraphEnums.cs:39
    OnnxSameLower = 4,

  Oper                      (abbreviation: operator)
    src/appkit.cs:77
    //	void Draw (CGRect inRect, CGRect fromRect, NSCompositingOperation operation, float fractionDelta);

  Overline                  (typography: line above text)
    src/AVFoundation/Enums.cs:1964
    Overline = 1uL << 2,

  Pci                       (acronym: Peripheral Component Interconnect)
    src/avfoundation.cs:3780
    NSString PortPci { get; }

  Photoplethysmogram        (medical: PPG measurement)
    src/sensorkit.cs:970
    [Field ("SRSensorPhotoplethysmogram")]

  Phq                       (acronym: Patient Health Questionnaire)
    src/healthkit.cs:6118
    public enum HKPhq9AssessmentRisk : long {

  Playout                   (media: content playout)
    src/avfoundation.cs:21246
    CMTime PlayoutLimit {

  Postback                  (networking: server callback)
    src/storekit.cs:1359
    [Deprecated (PlatformName.iOS, 15, 4, message: "Use 'UpdatePostback' instead.")]

  Ppk                       (acronym: Pre-shared Key Pair)
    src/networkextension.cs:2780
    NEVpnIkev2PpkConfiguration PpkConfiguration { get; set; }

  Preauthentication         (valid English: pre-authentication)
    src/authenticationservices.cs:2168
    [Export ("federationUserPreauthenticationURL", ArgumentSemantic.Copy)]

  Prefilter                 (valid English: pre-filter)
    src/metalperformanceshaders.cs:17574
    [Export ("variancePrefilterSigma")]

  Prereleased               (valid English: pre-released)
    src/gamekit.cs:4342
    Prereleased,

  Prf                       (acronym: Pseudo-Random Function)
    src/authenticationservices.cs:1629
    ASAuthorizationPublicKeyCredentialPrfAssertionInput Prf { get; set; }

  Pskc                      (acronym: Portable Symmetric Key Container)
    src/threadnetwork.cs:69
    NSData Pskc { get; }

  Pvr                       (acronym: PowerVR (GPU texture format))
    src/imageio.cs:4770
    PvrEncoder,

  Qwac                      (acronym: Qualified Website Authentication Certificate)
    src/security.cs:296
    NSString QwacValidation { get; }

  Raycast                   (valid English: ray casting operation)
    src/arkit.cs:141
    StopTrackedRaycasts = 1 << 2,

  Raycasts                  (plural of raycast)
    src/arkit.cs:141
    StopTrackedRaycasts = 1 << 2,

  Reauthentication          (valid English: re-authentication)
    src/authenticationservices.cs:2257
    [Export ("userNeedsReauthenticationWithCompletion:")]

  Reprojection              (valid English: re-projection)
    src/metalperformanceshaders.cs:17559
    [Export ("temporalReprojectionBlendFactor")]

  Rgbaf                     (pixel format: RGBA float)
    src/CoreImage/CIImage.cs:273
    format = CIFormat.Rgbaf;

  Rgbah                     (pixel format: RGBA half-float)
    src/coreimage.cs:3654
    [Obsolete ("Use 'CIFormat.Rgbah.GetConstant ()' instead.")]

  Rgbx                      (pixel format: RGB-padded)
    src/coregraphics.cs:705
    Rgbx,

  Rint                      (math: round to integer)
    src/metalperformanceshadersgraph.cs:217
    MPSGraphTensor Rint (MPSGraphTensor tensor, [NullAllowed] string name);

  Rle                       (acronym: Run-Length Encoding)
    src/ImageIO/Enums.cs:107
    Rle,

  Rsapss                    (acronym: RSA Probabilistic Signature Scheme)
    src/NetworkExtension/NEEnums.cs:240
    Rsapss = 6,

  Scc                       (acronym: Scenarist Closed Captions)
    src/avfoundation.cs:533
    Scc = 22,

  Sdh                       (acronym: Subtitles for the Deaf and Hard of hearing)
    src/tvservices.cs:163
    AudioTranscriptionSdh = 1uL << 14,

  Sdr                       (acronym: Standard Dynamic Range)
    src/imageio.cs:4434
    NSString EncodeToSdr { get; }

  Sel                       (abbreviation: selector (ObjC))
    src/appkit.cs:162
    Selector Action { get; set; }

  Sensel                    (sensor element (camera))
    src/corevideo.cs:773
    [Field ("kCVPixelBufferProResRAWKey_SenselSitingOffsets")]

  Signbit                   (math: sign bit)
    src/metalperformanceshadersgraph.cs:201
    MPSGraphTensor Signbit (MPSGraphTensor tensor, [NullAllowed] string name);

  Snn                       (acronym: Shared Nearest Neighbors)
    src/metalperformanceshaders.cs:16671
    interface IMPSnnGramMatrixCallback { }

  Sopen                     (function: secure open)
    src/appkit.cs:10547
    [Export ("panel:displayNameForType:"), DelegateName ("NSopenSavePanelDisplayName"), DefaultValue (null)]

  Spl                       (acronym: Sound Pressure Level)
    src/appkit.cs:7382
    [Deprecated (PlatformName.MacOSX, 10, 13, message: "Use 'NSSplitViewController' instead.")]

  Ssml                      (acronym: Speech Synthesis Markup Language)
    src/avfoundation.cs:21989
    AVSpeechUtterance FromSsmlRepresentation (string @string);

  Sso                       (acronym: Single Sign-On)
    src/authenticationservices.cs:2232
    NSDictionary SsoTokens { get; set; }

  st                        (tensor: spatial-temporal)
    src/appkit.cs:9
    // "Software"), to deal in the Software without restriction, including

  Sta                       (acronym: Station (WiFi))
    src/appkit.cs:181
    [Static]

  Strided                   (valid English: with a stride)
    src/metalperformanceshaders.cs:17273
    interface MPSNDArrayStridedSlice {

  Subband                   (signal processing: frequency sub-band)
    src/phase.cs:836
    [BaseType (typeof (NSObject), Name = "PHASECardioidDirectivityModelSubbandParameters")]

  Subfilter                 (compound: sub-filter)
    src/photosui.cs:700
    [Export ("anyFilterMatchingSubfilters:")]

  Subfilters                (plural of subfilter)
    src/photosui.cs:700
    [Export ("anyFilterMatchingSubfilters:")]

  Svfg                      (pixel processing order)
    src/metalperformanceshaders.cs:17650
    interface MPSSvfgDenoiser {

  Svgf                      (pixel processing order)
    src/metalperformanceshaders.cs:16680
    interface IMPSSvgfTextureAllocator { }

  Swolf                     (fitness: swim efficiency metric (Swim + Golf))
    src/healthkit.cs:1821
    NSString SwolfScore { get; }

  Sysex                     (MIDI: System Exclusive message)
    src/avfoundation.cs:25562
    [BaseType (typeof (AVMusicEvent), Name = "AVMIDISysexEvent")]

  Tbgr                      (pixel format: padded-Blue-Green-Red)
    src/CoreMedia/CMEnums.cs:668
    Tbgr = (uint) CMMediaType.TaggedBufferGroup,

  Tdoa                      (acronym: Time Difference Of Arrival)
    src/nearbyinteraction.cs:179
    void DidUpdateDlTdoaMeasurements (NISession session, NIDlTdoaMeasurement [] measurements);

  Tga                       (acronym: Truevision Graphics Adapter (image format))
    src/imageio.cs:114
    NSString TgaDictionary { get; }

  Tmoney                    (payment system (Korean transit card))
    src/passkit.cs:1978
    [Field ("PKPaymentNetworkTmoney")]

  Tonemap                   (graphics: tone mapping)
    src/imageio.cs:4453
    [Field ("kCGImageDestinationEncodeTonemapMode")]

  Tri                       (prefix: three (triangle, etc.))
    src/appkit.cs:314
    [Field ("NSAnimationTriggerOrderIn")]

  Unfetched                 (valid English: not yet fetched)
    src/cloudkit.cs:2773
    [Export ("zoneIDsWithUnfetchedServerChanges", ArgumentSemantic.Copy)]

  Unioning                  (valid English: performing a union)
    src/CoreGraphics/CGPath.cs:727
    static extern IntPtr CGPathCreateCopyByUnioningPath (IntPtr path, IntPtr maskPath, byte evenOddFillRule);

  Unmatch                   (valid English: undo a match)
    src/networkextension.cs:4736
    void UnmatchEthernet ();

  Unsolo                    (audio: undo solo)
    src/phase.cs:541
    void Unsolo ();

  Unsynced                  (valid English: not synchronized)
    src/fileprovider.cs:174
    UnsyncedEdits = -2007,

  Upi                       (acronym: Unified Payments Interface)
    src/messageui.cs:290
    void SetUpiVerificationCodeSendCompletion (Action<bool> completion);

  Ussd                      (acronym: Unstructured Supplementary Service Data)
    src/intents.cs:2774
    UnsupportedMmiUssd,

  Vbr                       (acronym: Variable Bit Rate)
    src/AudioToolbox/Enums.cs:112
    PacketSizeLimitForVbr = 0x70616b6c, // 'pakl'

  Vbv                       (acronym: Video Buffering Verifier)
    src/videotoolbox.cs:469
    NSString VbvMaxBitRate { get; }

  Voip                      (acronym: Voice over IP)
    src/coretelephony.cs:303
    bool AllowsVoip { get; }

  Vtt                       (acronym: WebVTT (Web Video Text Tracks))
    src/CoreMedia/CMEnums.cs:650
    WebVtt = (uint) CMSubtitleFormatType.WebVTT,

  Waon                      (payment system (Japanese e-money))
    src/passkit.cs:1962
    [Field ("PKPaymentNetworkWaon")]

  Wcdma                     (acronym: Wideband Code Division Multiple Access)
    src/Network/NWEnums.cs:329
    CellWcdma = 0x85,

  Xattrs                    (abbreviation: extended attributes)
    src/fskit.cs:955
    [Export ("listXattrsOfItem:replyHandler:")]

  Xbgr                      (pixel format: padded-Blue-Green-Red)
    src/coregraphics.cs:710
    Xbgr,

  Xmp                       (acronym: Extensible Metadata Platform)
    src/imageio.cs:4497
    NSString ShouldExcludeXmpKey { get; }

  Xrgb                      (pixel format: padded-Red-Green-Blue)
    src/coregraphics.cs:706
    Xrgb,

  Zenkaku                   (Japanese: full-width character)
    src/UIKit/UIEnums.cs:4301
    KeyboardZenkakuHankakuKanji = KeyboardLang5,

