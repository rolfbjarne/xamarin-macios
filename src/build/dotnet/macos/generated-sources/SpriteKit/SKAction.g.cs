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
namespace SpriteKit {
	/// <summary>Modifies properties on a <see cref="T:SpriteKit.SKNode" />, often animating the changes. Sometimes reversible.</summary><remarks><para>Application developers use the static methods of <see cref="T:SpriteKit.SKAction" /> to create actions that can be applied to the <see cref="T:SpriteKit.SKNode" />s of a <see cref="T:SpriteKit.SKScene" />. Generally, animations are animated.</para><para>The <see cref="M:SpriteKit.SKAction.Group(SpriteKit.SKAction[])" />, <see cref="M:SpriteKit.SKAction.RepeatAction(SpriteKit.SKAction,System.UIntPtr)" /> and <see cref="M:SpriteKit.SKAction.RepeatActionForever(SpriteKit.SKAction)" />, and <see cref="M:SpriteKit.SKAction.Sequence(SpriteKit.SKAction[])" /> methods are composite actions that take, as parameters, children <see cref="T:SpriteKit.SKAction" />s. </para><para>Once a <see cref="T:SpriteKit.SKAction" /> is created, application developers run it with the <see cref="SpriteKit.SKNode.RunActionAsync(SpriteKit.SKAction)" /> method, as shown in this example:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var actions = SKAction.Group(
	/// 	new SKAction[] {
	/// 		SKAction.MoveBy(new CGVector(10, 10), 1),
	/// 		SKAction.FadeAlphaTo(0.3f, 1),
	/// 		SKAction.ScaleBy(0.8f, 1)
	/// });
	/// 
	/// b.Node.RunAction(actions);          
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKAction_Ref/index.html">Apple documentation for <c>SKAction</c></related>
	[Register("SKAction", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKAction : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionNamed_X = "actionNamed:";
		static readonly NativeHandle selActionNamed_XHandle = Selector.GetHandle ("actionNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionNamed_Duration_X = "actionNamed:duration:";
		static readonly NativeHandle selActionNamed_Duration_XHandle = Selector.GetHandle ("actionNamed:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionNamed_FromURL_X = "actionNamed:fromURL:";
		static readonly NativeHandle selActionNamed_FromURL_XHandle = Selector.GetHandle ("actionNamed:fromURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionNamed_FromURL_Duration_X = "actionNamed:fromURL:duration:";
		static readonly NativeHandle selActionNamed_FromURL_Duration_XHandle = Selector.GetHandle ("actionNamed:fromURL:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimateWithNormalTextures_TimePerFrame_X = "animateWithNormalTextures:timePerFrame:";
		static readonly NativeHandle selAnimateWithNormalTextures_TimePerFrame_XHandle = Selector.GetHandle ("animateWithNormalTextures:timePerFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimateWithNormalTextures_TimePerFrame_Resize_Restore_X = "animateWithNormalTextures:timePerFrame:resize:restore:";
		static readonly NativeHandle selAnimateWithNormalTextures_TimePerFrame_Resize_Restore_XHandle = Selector.GetHandle ("animateWithNormalTextures:timePerFrame:resize:restore:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimateWithTextures_TimePerFrame_X = "animateWithTextures:timePerFrame:";
		static readonly NativeHandle selAnimateWithTextures_TimePerFrame_XHandle = Selector.GetHandle ("animateWithTextures:timePerFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimateWithTextures_TimePerFrame_Resize_Restore_X = "animateWithTextures:timePerFrame:resize:restore:";
		static readonly NativeHandle selAnimateWithTextures_TimePerFrame_Resize_Restore_XHandle = Selector.GetHandle ("animateWithTextures:timePerFrame:resize:restore:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimateWithWarps_Times_X = "animateWithWarps:times:";
		static readonly NativeHandle selAnimateWithWarps_Times_XHandle = Selector.GetHandle ("animateWithWarps:times:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimateWithWarps_Times_Restore_X = "animateWithWarps:times:restore:";
		static readonly NativeHandle selAnimateWithWarps_Times_Restore_XHandle = Selector.GetHandle ("animateWithWarps:times:restore:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyAngularImpulse_Duration_X = "applyAngularImpulse:duration:";
		static readonly NativeHandle selApplyAngularImpulse_Duration_XHandle = Selector.GetHandle ("applyAngularImpulse:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyForce_AtPoint_Duration_X = "applyForce:atPoint:duration:";
		static readonly NativeHandle selApplyForce_AtPoint_Duration_XHandle = Selector.GetHandle ("applyForce:atPoint:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyForce_Duration_X = "applyForce:duration:";
		static readonly NativeHandle selApplyForce_Duration_XHandle = Selector.GetHandle ("applyForce:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyImpulse_AtPoint_Duration_X = "applyImpulse:atPoint:duration:";
		static readonly NativeHandle selApplyImpulse_AtPoint_Duration_XHandle = Selector.GetHandle ("applyImpulse:atPoint:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyImpulse_Duration_X = "applyImpulse:duration:";
		static readonly NativeHandle selApplyImpulse_Duration_XHandle = Selector.GetHandle ("applyImpulse:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyTorque_Duration_X = "applyTorque:duration:";
		static readonly NativeHandle selApplyTorque_Duration_XHandle = Selector.GetHandle ("applyTorque:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeChargeBy_Duration_X = "changeChargeBy:duration:";
		static readonly NativeHandle selChangeChargeBy_Duration_XHandle = Selector.GetHandle ("changeChargeBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeChargeTo_Duration_X = "changeChargeTo:duration:";
		static readonly NativeHandle selChangeChargeTo_Duration_XHandle = Selector.GetHandle ("changeChargeTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeMassBy_Duration_X = "changeMassBy:duration:";
		static readonly NativeHandle selChangeMassBy_Duration_XHandle = Selector.GetHandle ("changeMassBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeMassTo_Duration_X = "changeMassTo:duration:";
		static readonly NativeHandle selChangeMassTo_Duration_XHandle = Selector.GetHandle ("changeMassTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeObstructionBy_Duration_X = "changeObstructionBy:duration:";
		static readonly NativeHandle selChangeObstructionBy_Duration_XHandle = Selector.GetHandle ("changeObstructionBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeObstructionTo_Duration_X = "changeObstructionTo:duration:";
		static readonly NativeHandle selChangeObstructionTo_Duration_XHandle = Selector.GetHandle ("changeObstructionTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeOcclusionBy_Duration_X = "changeOcclusionBy:duration:";
		static readonly NativeHandle selChangeOcclusionBy_Duration_XHandle = Selector.GetHandle ("changeOcclusionBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeOcclusionTo_Duration_X = "changeOcclusionTo:duration:";
		static readonly NativeHandle selChangeOcclusionTo_Duration_XHandle = Selector.GetHandle ("changeOcclusionTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangePlaybackRateBy_Duration_X = "changePlaybackRateBy:duration:";
		static readonly NativeHandle selChangePlaybackRateBy_Duration_XHandle = Selector.GetHandle ("changePlaybackRateBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangePlaybackRateTo_Duration_X = "changePlaybackRateTo:duration:";
		static readonly NativeHandle selChangePlaybackRateTo_Duration_XHandle = Selector.GetHandle ("changePlaybackRateTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeReverbBy_Duration_X = "changeReverbBy:duration:";
		static readonly NativeHandle selChangeReverbBy_Duration_XHandle = Selector.GetHandle ("changeReverbBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeReverbTo_Duration_X = "changeReverbTo:duration:";
		static readonly NativeHandle selChangeReverbTo_Duration_XHandle = Selector.GetHandle ("changeReverbTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeVolumeBy_Duration_X = "changeVolumeBy:duration:";
		static readonly NativeHandle selChangeVolumeBy_Duration_XHandle = Selector.GetHandle ("changeVolumeBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeVolumeTo_Duration_X = "changeVolumeTo:duration:";
		static readonly NativeHandle selChangeVolumeTo_Duration_XHandle = Selector.GetHandle ("changeVolumeTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorizeWithColor_ColorBlendFactor_Duration_X = "colorizeWithColor:colorBlendFactor:duration:";
		static readonly NativeHandle selColorizeWithColor_ColorBlendFactor_Duration_XHandle = Selector.GetHandle ("colorizeWithColor:colorBlendFactor:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorizeWithColorBlendFactor_Duration_X = "colorizeWithColorBlendFactor:duration:";
		static readonly NativeHandle selColorizeWithColorBlendFactor_Duration_XHandle = Selector.GetHandle ("colorizeWithColorBlendFactor:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomActionWithDuration_ActionBlock_X = "customActionWithDuration:actionBlock:";
		static readonly NativeHandle selCustomActionWithDuration_ActionBlock_XHandle = Selector.GetHandle ("customActionWithDuration:actionBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDurationX = "duration";
		static readonly NativeHandle selDurationXHandle = Selector.GetHandle ("duration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFadeAlphaBy_Duration_X = "fadeAlphaBy:duration:";
		static readonly NativeHandle selFadeAlphaBy_Duration_XHandle = Selector.GetHandle ("fadeAlphaBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFadeAlphaTo_Duration_X = "fadeAlphaTo:duration:";
		static readonly NativeHandle selFadeAlphaTo_Duration_XHandle = Selector.GetHandle ("fadeAlphaTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFadeInWithDuration_X = "fadeInWithDuration:";
		static readonly NativeHandle selFadeInWithDuration_XHandle = Selector.GetHandle ("fadeInWithDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFadeOutWithDuration_X = "fadeOutWithDuration:";
		static readonly NativeHandle selFadeOutWithDuration_XHandle = Selector.GetHandle ("fadeOutWithDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFalloffBy_Duration_X = "falloffBy:duration:";
		static readonly NativeHandle selFalloffBy_Duration_XHandle = Selector.GetHandle ("falloffBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFalloffTo_Duration_X = "falloffTo:duration:";
		static readonly NativeHandle selFalloffTo_Duration_XHandle = Selector.GetHandle ("falloffTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFollowPath_AsOffset_OrientToPath_Duration_X = "followPath:asOffset:orientToPath:duration:";
		static readonly NativeHandle selFollowPath_AsOffset_OrientToPath_Duration_XHandle = Selector.GetHandle ("followPath:asOffset:orientToPath:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFollowPath_AsOffset_OrientToPath_Speed_X = "followPath:asOffset:orientToPath:speed:";
		static readonly NativeHandle selFollowPath_AsOffset_OrientToPath_Speed_XHandle = Selector.GetHandle ("followPath:asOffset:orientToPath:speed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFollowPath_Duration_X = "followPath:duration:";
		static readonly NativeHandle selFollowPath_Duration_XHandle = Selector.GetHandle ("followPath:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFollowPath_Speed_X = "followPath:speed:";
		static readonly NativeHandle selFollowPath_Speed_XHandle = Selector.GetHandle ("followPath:speed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroup_X = "group:";
		static readonly NativeHandle selGroup_XHandle = Selector.GetHandle ("group:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHideX = "hide";
		static readonly NativeHandle selHideXHandle = Selector.GetHandle ("hide");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveBy_Duration_X = "moveBy:duration:";
		static readonly NativeHandle selMoveBy_Duration_XHandle = Selector.GetHandle ("moveBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveByX_Y_Duration_X = "moveByX:y:duration:";
		static readonly NativeHandle selMoveByX_Y_Duration_XHandle = Selector.GetHandle ("moveByX:y:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveTo_Duration_X = "moveTo:duration:";
		static readonly NativeHandle selMoveTo_Duration_XHandle = Selector.GetHandle ("moveTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveToX_Duration_X = "moveToX:duration:";
		static readonly NativeHandle selMoveToX_Duration_XHandle = Selector.GetHandle ("moveToX:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveToY_Duration_X = "moveToY:duration:";
		static readonly NativeHandle selMoveToY_Duration_XHandle = Selector.GetHandle ("moveToY:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseX = "pause";
		static readonly NativeHandle selPauseXHandle = Selector.GetHandle ("pause");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformSelector_OnTarget_X = "performSelector:onTarget:";
		static readonly NativeHandle selPerformSelector_OnTarget_XHandle = Selector.GetHandle ("performSelector:onTarget:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayX = "play";
		static readonly NativeHandle selPlayXHandle = Selector.GetHandle ("play");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaySoundFileNamed_WaitForCompletion_X = "playSoundFileNamed:waitForCompletion:";
		static readonly NativeHandle selPlaySoundFileNamed_WaitForCompletion_XHandle = Selector.GetHandle ("playSoundFileNamed:waitForCompletion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReachTo_RootNode_Duration_X = "reachTo:rootNode:duration:";
		static readonly NativeHandle selReachTo_RootNode_Duration_XHandle = Selector.GetHandle ("reachTo:rootNode:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReachTo_RootNode_Velocity_X = "reachTo:rootNode:velocity:";
		static readonly NativeHandle selReachTo_RootNode_Velocity_XHandle = Selector.GetHandle ("reachTo:rootNode:velocity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReachToNode_RootNode_Duration_X = "reachToNode:rootNode:duration:";
		static readonly NativeHandle selReachToNode_RootNode_Duration_XHandle = Selector.GetHandle ("reachToNode:rootNode:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReachToNode_RootNode_Velocity_X = "reachToNode:rootNode:velocity:";
		static readonly NativeHandle selReachToNode_RootNode_Velocity_XHandle = Selector.GetHandle ("reachToNode:rootNode:velocity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveFromParentX = "removeFromParent";
		static readonly NativeHandle selRemoveFromParentXHandle = Selector.GetHandle ("removeFromParent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRepeatAction_Count_X = "repeatAction:count:";
		static readonly NativeHandle selRepeatAction_Count_XHandle = Selector.GetHandle ("repeatAction:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRepeatActionForever_X = "repeatActionForever:";
		static readonly NativeHandle selRepeatActionForever_XHandle = Selector.GetHandle ("repeatActionForever:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeByWidth_Height_Duration_X = "resizeByWidth:height:duration:";
		static readonly NativeHandle selResizeByWidth_Height_Duration_XHandle = Selector.GetHandle ("resizeByWidth:height:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeToHeight_Duration_X = "resizeToHeight:duration:";
		static readonly NativeHandle selResizeToHeight_Duration_XHandle = Selector.GetHandle ("resizeToHeight:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeToWidth_Duration_X = "resizeToWidth:duration:";
		static readonly NativeHandle selResizeToWidth_Duration_XHandle = Selector.GetHandle ("resizeToWidth:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeToWidth_Height_Duration_X = "resizeToWidth:height:duration:";
		static readonly NativeHandle selResizeToWidth_Height_Duration_XHandle = Selector.GetHandle ("resizeToWidth:height:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReversedActionX = "reversedAction";
		static readonly NativeHandle selReversedActionXHandle = Selector.GetHandle ("reversedAction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRotateByAngle_Duration_X = "rotateByAngle:duration:";
		static readonly NativeHandle selRotateByAngle_Duration_XHandle = Selector.GetHandle ("rotateByAngle:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRotateToAngle_Duration_X = "rotateToAngle:duration:";
		static readonly NativeHandle selRotateToAngle_Duration_XHandle = Selector.GetHandle ("rotateToAngle:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRotateToAngle_Duration_ShortestUnitArc_X = "rotateToAngle:duration:shortestUnitArc:";
		static readonly NativeHandle selRotateToAngle_Duration_ShortestUnitArc_XHandle = Selector.GetHandle ("rotateToAngle:duration:shortestUnitArc:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunAction_OnChildWithName_X = "runAction:onChildWithName:";
		static readonly NativeHandle selRunAction_OnChildWithName_XHandle = Selector.GetHandle ("runAction:onChildWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunBlock_X = "runBlock:";
		static readonly NativeHandle selRunBlock_XHandle = Selector.GetHandle ("runBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunBlock_Queue_X = "runBlock:queue:";
		static readonly NativeHandle selRunBlock_Queue_XHandle = Selector.GetHandle ("runBlock:queue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleBy_Duration_X = "scaleBy:duration:";
		static readonly NativeHandle selScaleBy_Duration_XHandle = Selector.GetHandle ("scaleBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleTo_Duration_X = "scaleTo:duration:";
		static readonly NativeHandle selScaleTo_Duration_XHandle = Selector.GetHandle ("scaleTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleToSize_Duration_X = "scaleToSize:duration:";
		static readonly NativeHandle selScaleToSize_Duration_XHandle = Selector.GetHandle ("scaleToSize:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleXBy_Y_Duration_X = "scaleXBy:y:duration:";
		static readonly NativeHandle selScaleXBy_Y_Duration_XHandle = Selector.GetHandle ("scaleXBy:y:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleXTo_Duration_X = "scaleXTo:duration:";
		static readonly NativeHandle selScaleXTo_Duration_XHandle = Selector.GetHandle ("scaleXTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleXTo_Y_Duration_X = "scaleXTo:y:duration:";
		static readonly NativeHandle selScaleXTo_Y_Duration_XHandle = Selector.GetHandle ("scaleXTo:y:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleYTo_Duration_X = "scaleYTo:duration:";
		static readonly NativeHandle selScaleYTo_Duration_XHandle = Selector.GetHandle ("scaleYTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSequence_X = "sequence:";
		static readonly NativeHandle selSequence_XHandle = Selector.GetHandle ("sequence:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDuration_X = "setDuration:";
		static readonly NativeHandle selSetDuration_XHandle = Selector.GetHandle ("setDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNormalTexture_X = "setNormalTexture:";
		static readonly NativeHandle selSetNormalTexture_XHandle = Selector.GetHandle ("setNormalTexture:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNormalTexture_Resize_X = "setNormalTexture:resize:";
		static readonly NativeHandle selSetNormalTexture_Resize_XHandle = Selector.GetHandle ("setNormalTexture:resize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSpeed_X = "setSpeed:";
		static readonly NativeHandle selSetSpeed_XHandle = Selector.GetHandle ("setSpeed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTexture_X = "setTexture:";
		static readonly NativeHandle selSetTexture_XHandle = Selector.GetHandle ("setTexture:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTexture_Resize_X = "setTexture:resize:";
		static readonly NativeHandle selSetTexture_Resize_XHandle = Selector.GetHandle ("setTexture:resize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTimingFunction_X = "setTimingFunction:";
		static readonly NativeHandle selSetTimingFunction_XHandle = Selector.GetHandle ("setTimingFunction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTimingMode_X = "setTimingMode:";
		static readonly NativeHandle selSetTimingMode_XHandle = Selector.GetHandle ("setTimingMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpeedX = "speed";
		static readonly NativeHandle selSpeedXHandle = Selector.GetHandle ("speed");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpeedBy_Duration_X = "speedBy:duration:";
		static readonly NativeHandle selSpeedBy_Duration_XHandle = Selector.GetHandle ("speedBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpeedTo_Duration_X = "speedTo:duration:";
		static readonly NativeHandle selSpeedTo_Duration_XHandle = Selector.GetHandle ("speedTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStereoPanBy_Duration_X = "stereoPanBy:duration:";
		static readonly NativeHandle selStereoPanBy_Duration_XHandle = Selector.GetHandle ("stereoPanBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStereoPanTo_Duration_X = "stereoPanTo:duration:";
		static readonly NativeHandle selStereoPanTo_Duration_XHandle = Selector.GetHandle ("stereoPanTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopX = "stop";
		static readonly NativeHandle selStopXHandle = Selector.GetHandle ("stop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrengthBy_Duration_X = "strengthBy:duration:";
		static readonly NativeHandle selStrengthBy_Duration_XHandle = Selector.GetHandle ("strengthBy:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrengthTo_Duration_X = "strengthTo:duration:";
		static readonly NativeHandle selStrengthTo_Duration_XHandle = Selector.GetHandle ("strengthTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimingFunctionX = "timingFunction";
		static readonly NativeHandle selTimingFunctionXHandle = Selector.GetHandle ("timingFunction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimingModeX = "timingMode";
		static readonly NativeHandle selTimingModeXHandle = Selector.GetHandle ("timingMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnhideX = "unhide";
		static readonly NativeHandle selUnhideXHandle = Selector.GetHandle ("unhide");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWaitForDuration_X = "waitForDuration:";
		static readonly NativeHandle selWaitForDuration_XHandle = Selector.GetHandle ("waitForDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWaitForDuration_WithRange_X = "waitForDuration:withRange:";
		static readonly NativeHandle selWaitForDuration_WithRange_XHandle = Selector.GetHandle ("waitForDuration:withRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWarpTo_Duration_X = "warpTo:duration:";
		static readonly NativeHandle selWarpTo_Duration_XHandle = Selector.GetHandle ("warpTo:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SKAction");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public SKAction (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}

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
		protected SKAction (NSObjectFlag t) : base (t)
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
		protected internal SKAction (NativeHandle handle) : base (handle)
		{
		}

		[Export ("animateWithWarps:times:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? Animate (SKWarpGeometry[] warps, NSNumber[] times)
		{
			if (warps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (warps));
			if (times is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (times));
			using var nsa_warps = NSArray.FromNSObjects (warps);
			using var nsa_times = NSArray.FromNSObjects (times);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selAnimateWithWarps_Times_XHandle, nsa_warps.Handle, nsa_times.Handle), false)!;
			return ret;
		}
		[Export ("animateWithWarps:times:restore:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? Animate (SKWarpGeometry[] warps, NSNumber[] times, bool restore)
		{
			if (warps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (warps));
			if (times is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (times));
			using var nsa_warps = NSArray.FromNSObjects (warps);
			using var nsa_times = NSArray.FromNSObjects (times);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (class_ptr, selAnimateWithWarps_Times_Restore_XHandle, nsa_warps.Handle, nsa_times.Handle, restore ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("animateWithNormalTextures:timePerFrame:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction AnimateWithNormalTextures (SKTexture[] textures, double secondsPerFrame)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, selAnimateWithNormalTextures_TimePerFrame_XHandle, nsa_textures.Handle, secondsPerFrame), false)!;
			return ret;
		}
		[Export ("animateWithNormalTextures:timePerFrame:resize:restore:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction AnimateWithNormalTextures (SKTexture[] textures, double secondsPerFrame, bool resize, bool restore)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double_bool_bool (class_ptr, selAnimateWithNormalTextures_TimePerFrame_Resize_Restore_XHandle, nsa_textures.Handle, secondsPerFrame, resize ? (byte) 1 : (byte) 0, restore ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("animateWithTextures:timePerFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction AnimateWithTextures (SKTexture[] textures, double sec)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, selAnimateWithTextures_TimePerFrame_XHandle, nsa_textures.Handle, sec), false)!;
			return ret;
		}
		[Export ("animateWithTextures:timePerFrame:resize:restore:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction AnimateWithTextures (SKTexture[] textures, double sec, bool resize, bool restore)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double_bool_bool (class_ptr, selAnimateWithTextures_TimePerFrame_Resize_Restore_XHandle, nsa_textures.Handle, sec, resize ? (byte) 1 : (byte) 0, restore ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		/// <param name="color">To be added.</param><param name="colorBlendFactor">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("colorizeWithColor:colorBlendFactor:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ColorizeWithColor (global::AppKit.NSColor color, nfloat colorBlendFactor, double sec)
		{
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat_Double (class_ptr, selColorizeWithColor_ColorBlendFactor_Duration_XHandle, color__handle__, colorBlendFactor, sec), false)!;
			GC.KeepAlive (color);
			return ret!;
		}
		/// <param name="colorBlendFactor">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("colorizeWithColorBlendFactor:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ColorizeWithColorBlendFactor (nfloat colorBlendFactor, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selColorizeWithColorBlendFactor_Duration_XHandle, colorBlendFactor, sec), false)!;
			return ret;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("actionNamed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? Create (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selActionNamed_XHandle, nsname), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("actionNamed:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? Create (string name, double duration)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, selActionNamed_Duration_XHandle, nsname, duration), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("actionNamed:fromURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? Create (string name, NSUrl url)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var nsname = CFString.CreateNative (name);
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selActionNamed_FromURL_XHandle, nsname, url__handle__), false)!;
			GC.KeepAlive (url);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("actionNamed:fromURL:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? Create (string name, NSUrl url, double duration)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var nsname = CFString.CreateNative (name);
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_Double (class_ptr, selActionNamed_FromURL_Duration_XHandle, nsname, url__handle__, duration), false)!;
			GC.KeepAlive (url);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="impulse">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("applyAngularImpulse:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateApplyAngularImpulse (nfloat impulse, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selApplyAngularImpulse_Duration_XHandle, impulse, duration), false)!;
			return ret;
		}
		[Export ("applyForce:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateApplyForce (CGVector force, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGVector_Double (class_ptr, selApplyForce_Duration_XHandle, force, duration), false)!;
			return ret;
		}
		[Export ("applyForce:atPoint:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateApplyForce (CGVector force, CGPoint point, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGVector_CGPoint_Double (class_ptr, selApplyForce_AtPoint_Duration_XHandle, force, point, duration), false)!;
			return ret;
		}
		[Export ("applyImpulse:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateApplyImpulse (CGVector impulse, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGVector_Double (class_ptr, selApplyImpulse_Duration_XHandle, impulse, duration), false)!;
			return ret;
		}
		[Export ("applyImpulse:atPoint:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateApplyImpulse (CGVector impulse, CGPoint point, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGVector_CGPoint_Double (class_ptr, selApplyImpulse_AtPoint_Duration_XHandle, impulse, point, duration), false)!;
			return ret;
		}
		/// <param name="torque">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("applyTorque:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateApplyTorque (nfloat torque, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selApplyTorque_Duration_XHandle, torque, duration), false)!;
			return ret;
		}
		[Export ("changeChargeBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeChargeBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangeChargeBy_Duration_XHandle, by, duration), false)!;
			return ret;
		}
		[Export ("changeChargeTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeChargeTo (float newCharge, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangeChargeTo_Duration_XHandle, newCharge, duration), false)!;
			return ret;
		}
		[Export ("changeMassBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeMassBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangeMassBy_Duration_XHandle, by, duration), false)!;
			return ret;
		}
		[Export ("changeMassTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeMassTo (float newMass, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangeMassTo_Duration_XHandle, newMass, duration), false)!;
			return ret;
		}
		[Export ("changeObstructionBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeObstructionBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangeObstructionBy_Duration_XHandle, by, duration), false)!;
			return ret;
		}
		[Export ("changeObstructionTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeObstructionTo (float target, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangeObstructionTo_Duration_XHandle, target, duration), false)!;
			return ret;
		}
		[Export ("changeOcclusionBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeOcclusionBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangeOcclusionBy_Duration_XHandle, by, duration), false)!;
			return ret;
		}
		[Export ("changeOcclusionTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeOcclusionTo (float target, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangeOcclusionTo_Duration_XHandle, target, duration), false)!;
			return ret;
		}
		[Export ("changePlaybackRateTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangePlaybackRate (float playbackRate, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangePlaybackRateTo_Duration_XHandle, playbackRate, duration), false)!;
			return ret;
		}
		[Export ("changePlaybackRateBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangePlaybackRateBy (float playbackRate, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangePlaybackRateBy_Duration_XHandle, playbackRate, duration), false)!;
			return ret;
		}
		[Export ("changeReverbBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeReverbBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangeReverbBy_Duration_XHandle, by, duration), false)!;
			return ret;
		}
		[Export ("changeReverbTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeReverbTo (float target, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangeReverbTo_Duration_XHandle, target, duration), false)!;
			return ret;
		}
		[Export ("changeVolumeTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeVolume (float newVolume, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangeVolumeTo_Duration_XHandle, newVolume, duration), false)!;
			return ret;
		}
		[Export ("changeVolumeBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeVolumeBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selChangeVolumeBy_Duration_XHandle, by, duration), false)!;
			return ret;
		}
		[Export ("pause")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreatePause ()
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPauseXHandle), false)!;
			return ret;
		}
		[Export ("play")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreatePlay ()
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPlayXHandle), false)!;
			return ret;
		}
		[Export ("stereoPanBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateStereoPanBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selStereoPanBy_Duration_XHandle, by, duration), false)!;
			return ret;
		}
		[Export ("stereoPanTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateStereoPanTo (float target, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selStereoPanTo_Duration_XHandle, target, duration), false)!;
			return ret;
		}
		[Export ("stop")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateStop ()
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selStopXHandle), false)!;
			return ret;
		}
		[Export ("customActionWithDuration:actionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKAction CustomActionWithDuration (double seconds, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSKActionDurationHandler))]SKActionDurationHandler actionHandler)
		{
			if (actionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actionHandler));
			using var block_actionHandler = Trampolines.SDSKActionDurationHandler.CreateBlock (actionHandler);
			BlockLiteral *block_ptr_actionHandler = &block_actionHandler;
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_NativeHandle (class_ptr, selCustomActionWithDuration_ActionBlock_XHandle, seconds, (IntPtr) block_ptr_actionHandler), false)!;
			return ret;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		/// <param name="factor">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fadeAlphaBy:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FadeAlphaBy (nfloat factor, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selFadeAlphaBy_Duration_XHandle, factor, sec), false)!;
			return ret;
		}
		/// <param name="alpha">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fadeAlphaTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FadeAlphaTo (nfloat alpha, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selFadeAlphaTo_Duration_XHandle, alpha, sec), false)!;
			return ret;
		}
		[Export ("fadeInWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FadeInWithDuration (double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selFadeInWithDuration_XHandle, sec), false)!;
			return ret;
		}
		[Export ("fadeOutWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FadeOutWithDuration (double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selFadeOutWithDuration_XHandle, sec), false)!;
			return ret;
		}
		[Export ("falloffBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FalloffBy (float to, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selFalloffBy_Duration_XHandle, to, duration), false)!;
			return ret;
		}
		[Export ("falloffTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FalloffTo (float falloff, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selFalloffTo_Duration_XHandle, falloff, sec), false)!;
			return ret;
		}
		[Export ("followPath:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FollowPath (CGPath path, double sec)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, selFollowPath_Duration_XHandle, path.Handle, sec), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		[Export ("followPath:asOffset:orientToPath:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FollowPath (CGPath path, bool offset, bool orient, double sec)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_bool_Double (class_ptr, selFollowPath_AsOffset_OrientToPath_Duration_XHandle, path.Handle, offset ? (byte) 1 : (byte) 0, orient ? (byte) 1 : (byte) 0, sec), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		/// <param name="path">To be added.</param><param name="speed">To be added.</param><summary>Creates an action that moves the <see cref="T:SpriteKit.SKNode" /> on which it is run over the <paramref name="path" />, at the specified <paramref name="speed" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("followPath:speed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FollowPath (CGPath path, nfloat speed)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (class_ptr, selFollowPath_Speed_XHandle, path.Handle, speed), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		/// <param name="path">To be added.</param><param name="offset">To be added.</param><param name="orient">To be added.</param><param name="speed">To be added.</param><summary>Creates an action that moves the <see cref="T:SpriteKit.SKNode" /> on which it is run over the <paramref name="path" />, with the specified offset, orientation, and speed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("followPath:asOffset:orientToPath:speed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FollowPath (CGPath path, bool offset, bool orient, nfloat speed)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_bool_nfloat (class_ptr, selFollowPath_AsOffset_OrientToPath_Speed_XHandle, path.Handle, offset ? (byte) 1 : (byte) 0, orient ? (byte) 1 : (byte) 0, speed), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		[Export ("group:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction Group (params SKAction[] actions)
		{
			if (actions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actions));
			using var nsa_actions = NSArray.FromNSObjects (actions);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selGroup_XHandle, nsa_actions.Handle), false)!;
			return ret;
		}
		[Export ("hide")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction Hide ()
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selHideXHandle), false)!;
			return ret;
		}
		/// <param name="deltaX">To be added.</param><param name="deltaY">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("moveByX:y:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction MoveBy (nfloat deltaX, nfloat deltaY, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_Double (class_ptr, selMoveByX_Y_Duration_XHandle, deltaX, deltaY, sec), false)!;
			return ret;
		}
		[Export ("moveBy:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction MoveBy (CGVector delta, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGVector_Double (class_ptr, selMoveBy_Duration_XHandle, delta, duration), false)!;
			return ret;
		}
		[Export ("moveTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction MoveTo (CGPoint location, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_Double (class_ptr, selMoveTo_Duration_XHandle, location, sec), false)!;
			return ret;
		}
		/// <param name="x">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("moveToX:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction MoveToX (nfloat x, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selMoveToX_Duration_XHandle, x, sec), false)!;
			return ret;
		}
		/// <param name="y">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("moveToY:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction MoveToY (nfloat y, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selMoveToY_Duration_XHandle, y, sec), false)!;
			return ret;
		}
		[Export ("performSelector:onTarget:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction PerformSelector (Selector selector, NSObject target)
		{
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPerformSelector_OnTarget_XHandle, selector.Handle, target__handle__), false)!;
			GC.KeepAlive (selector);
			GC.KeepAlive (target);
			return ret!;
		}
		[Export ("playSoundFileNamed:waitForCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction PlaySoundFileNamed (string soundFile, bool wait)
		{
			if (soundFile is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (soundFile));
			var nssoundFile = CFString.CreateNative (soundFile);
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, selPlaySoundFileNamed_WaitForCompletion_XHandle, nssoundFile, wait ? (byte) 1 : (byte) 0), false)!;
			CFString.ReleaseNative (nssoundFile);
			return ret!;
		}
		[Export ("reachTo:rootNode:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ReachTo (CGPoint position, SKNode rootNode, double secs)
		{
			var rootNode__handle__ = rootNode!.GetNonNullHandle (nameof (rootNode));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle_Double (class_ptr, selReachTo_RootNode_Duration_XHandle, position, rootNode__handle__, secs), false)!;
			GC.KeepAlive (rootNode);
			return ret!;
		}
		/// <param name="position">To be added.</param><param name="rootNode">To be added.</param><param name="velocity">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("reachTo:rootNode:velocity:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ReachTo (CGPoint position, SKNode rootNode, nfloat velocity)
		{
			var rootNode__handle__ = rootNode!.GetNonNullHandle (nameof (rootNode));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle_nfloat (class_ptr, selReachTo_RootNode_Velocity_XHandle, position, rootNode__handle__, velocity), false)!;
			GC.KeepAlive (rootNode);
			return ret!;
		}
		[Export ("reachToNode:rootNode:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ReachToNode (SKNode node, SKNode rootNode, double sec)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var rootNode__handle__ = rootNode!.GetNonNullHandle (nameof (rootNode));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_Double (class_ptr, selReachToNode_RootNode_Duration_XHandle, node__handle__, rootNode__handle__, sec), false)!;
			GC.KeepAlive (node);
			GC.KeepAlive (rootNode);
			return ret!;
		}
		/// <param name="node">To be added.</param><param name="rootNode">To be added.</param><param name="velocity">To be added.</param><summary>Creates an action that moves the node to which it is applied by rotating it, along with all nodes between it and <paramref name="rootNode" />, so that it is closer to <paramref name="node" />, in a way that moves the node at the speed that is specified by <paramref name="velocity" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("reachToNode:rootNode:velocity:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ReachToNode (SKNode node, SKNode rootNode, nfloat velocity)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var rootNode__handle__ = rootNode!.GetNonNullHandle (nameof (rootNode));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_nfloat (class_ptr, selReachToNode_RootNode_Velocity_XHandle, node__handle__, rootNode__handle__, velocity), false)!;
			GC.KeepAlive (node);
			GC.KeepAlive (rootNode);
			return ret!;
		}
		[Export ("removeFromParent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RemoveFromParent ()
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selRemoveFromParentXHandle), false)!;
			return ret;
		}
		/// <param name="action">To be added.</param><param name="count">To be added.</param><summary>Creates an action that repeats <paramref name="action" /> a specified number of times on the node on which it is run.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("repeatAction:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RepeatAction (SKAction action, nuint count)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (class_ptr, selRepeatAction_Count_XHandle, action__handle__, count), false)!;
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("repeatActionForever:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RepeatActionForever (SKAction action)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selRepeatActionForever_XHandle, action__handle__), false)!;
			GC.KeepAlive (action);
			return ret!;
		}
		/// <param name="width">To be added.</param><param name="height">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resizeByWidth:height:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ResizeByWidth (nfloat width, nfloat height, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_Double (class_ptr, selResizeByWidth_Height_Duration_XHandle, width, height, duration), false)!;
			return ret;
		}
		/// <param name="width">To be added.</param><param name="height">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resizeToWidth:height:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ResizeTo (nfloat width, nfloat height, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_Double (class_ptr, selResizeToWidth_Height_Duration_XHandle, width, height, duration), false)!;
			return ret;
		}
		/// <param name="height">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resizeToHeight:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ResizeToHeight (nfloat height, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selResizeToHeight_Duration_XHandle, height, duration), false)!;
			return ret;
		}
		/// <param name="width">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resizeToWidth:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ResizeToWidth (nfloat width, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selResizeToWidth_Duration_XHandle, width, duration), false)!;
			return ret;
		}
		/// <param name="radians">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rotateByAngle:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RotateByAngle (nfloat radians, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selRotateByAngle_Duration_XHandle, radians, sec), false)!;
			return ret;
		}
		/// <param name="radians">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rotateToAngle:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RotateToAngle (nfloat radians, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selRotateToAngle_Duration_XHandle, radians, sec), false)!;
			return ret;
		}
		/// <param name="radians">To be added.</param><param name="sec">To be added.</param><param name="shortedUnitArc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rotateToAngle:duration:shortestUnitArc:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RotateToAngle (nfloat radians, double sec, bool shortedUnitArc)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double_bool (class_ptr, selRotateToAngle_Duration_ShortestUnitArc_XHandle, radians, sec, shortedUnitArc ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("runBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKAction Run ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDAction.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selRunBlock_XHandle, (IntPtr) block_ptr_block), false)!;
			return ret;
		}
		[Export ("runBlock:queue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKAction Run ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action block, global::CoreFoundation.DispatchQueue queue)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			using var block_block = Trampolines.SDAction.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selRunBlock_Queue_XHandle, (IntPtr) block_ptr_block, queue.Handle), false)!;
			GC.KeepAlive (queue);
			return ret!;
		}
		[Export ("runAction:onChildWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RunAction (SKAction action, string name)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selRunAction_OnChildWithName_XHandle, action__handle__, nsname), false)!;
			GC.KeepAlive (action);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="scale">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleBy:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleBy (nfloat scale, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selScaleBy_Duration_XHandle, scale, sec), false)!;
			return ret;
		}
		/// <param name="xScale">To be added.</param><param name="yScale">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleXBy:y:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleBy (nfloat xScale, nfloat yScale, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_Double (class_ptr, selScaleXBy_Y_Duration_XHandle, xScale, yScale, sec), false)!;
			return ret;
		}
		/// <param name="scale">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleTo (nfloat scale, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selScaleTo_Duration_XHandle, scale, sec), false)!;
			return ret;
		}
		/// <param name="xScale">To be added.</param><param name="yScale">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleXTo:y:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleTo (nfloat xScale, nfloat yScale, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_Double (class_ptr, selScaleXTo_Y_Duration_XHandle, xScale, yScale, sec), false)!;
			return ret;
		}
		[Export ("scaleToSize:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleTo (CGSize size, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize_Double (class_ptr, selScaleToSize_Duration_XHandle, size, sec), false)!;
			return ret;
		}
		/// <param name="scale">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleXTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleXTo (nfloat scale, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selScaleXTo_Duration_XHandle, scale, sec), false)!;
			return ret;
		}
		/// <param name="scale">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleYTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleYTo (nfloat scale, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selScaleYTo_Duration_XHandle, scale, sec), false)!;
			return ret;
		}
		[Export ("sequence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction Sequence (params SKAction[] actions)
		{
			if (actions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actions));
			using var nsa_actions = NSArray.FromNSObjects (actions);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selSequence_XHandle, nsa_actions.Handle), false)!;
			return ret;
		}
		[Export ("setNormalTexture:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction SetNormalTexture (SKTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selSetNormalTexture_XHandle, texture__handle__), false)!;
			GC.KeepAlive (texture);
			return ret!;
		}
		[Export ("setNormalTexture:resize:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction SetNormalTexture (SKTexture texture, bool resize)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, selSetNormalTexture_Resize_XHandle, texture__handle__, resize ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (texture);
			return ret!;
		}
		[Export ("setTexture:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction SetTexture (SKTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selSetTexture_XHandle, texture__handle__), false)!;
			GC.KeepAlive (texture);
			return ret!;
		}
		[Export ("setTexture:resize:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction SetTexture (SKTexture texture, bool resize)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, selSetTexture_Resize_XHandle, texture__handle__, resize ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (texture);
			return ret!;
		}
		/// <param name="speed">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("speedBy:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction SpeedBy (nfloat speed, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selSpeedBy_Duration_XHandle, speed, sec), false)!;
			return ret;
		}
		/// <param name="speed">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("speedTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction SpeedTo (nfloat speed, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, selSpeedTo_Duration_XHandle, speed, sec), false)!;
			return ret;
		}
		[Export ("strengthBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction StrengthBy (float strength, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selStrengthBy_Duration_XHandle, strength, sec), false)!;
			return ret;
		}
		[Export ("strengthTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction StrengthTo (float strength, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, selStrengthTo_Duration_XHandle, strength, sec), false)!;
			return ret;
		}
		[Export ("unhide")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction Unhide ()
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selUnhideXHandle), false)!;
			return ret;
		}
		[Export ("waitForDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction WaitForDuration (double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selWaitForDuration_XHandle, sec), false)!;
			return ret;
		}
		[Export ("waitForDuration:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction WaitForDuration (double sec, double durationRange)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_Double (class_ptr, selWaitForDuration_WithRange_XHandle, sec, durationRange), false)!;
			return ret;
		}
		[Export ("warpTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? WarpTo (SKWarpGeometry warp, double duration)
		{
			var warp__handle__ = warp!.GetNonNullHandle (nameof (warp));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, selWarpTo_Duration_XHandle, warp__handle__, duration), false)!;
			GC.KeepAlive (warp);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Duration {
			[Export ("duration")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDurationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selDurationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDuration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetDuration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetDuration_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKAction ReversedAction {
			[Export ("reversedAction")]
			get {
				SKAction? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReversedActionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReversedActionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Speed {
			[Export ("speed")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selSpeedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selSpeedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSpeed:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetSpeed_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetSpeed_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Sets the function that transforms the times at which actions occur.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public unsafe SKActionTimingFunction? TimingFunction {
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTimingFunctionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTimingFunctionXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDSKActionTimingFunction.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSKActionTimingFunction))]
			set {
				using var block_value = Trampolines.SDSKActionTimingFunction.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTimingFunction_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTimingFunction_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Sets the function that transforms the times at which actions occur.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Obsolete ("Use 'TimingFunction' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public unsafe virtual SKActionTimingFunction2? TimingFunction2 {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDSKActionTimingFunction2))]
			[Export ("timingFunction", ArgumentSemantic.Assign)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTimingFunctionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTimingFunctionXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDSKActionTimingFunction2.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSKActionTimingFunction2))]
			[Export ("setTimingFunction:", ArgumentSemantic.Assign)]
			set {
				using var block_value = Trampolines.SDSKActionTimingFunction2.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTimingFunction_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTimingFunction_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKActionTimingMode TimingMode {
			[Export ("timingMode")]
			get {
				SKActionTimingMode ret;
				if (IsDirectBinding) {
					ret = (SKActionTimingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTimingModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SKActionTimingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTimingModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTimingMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTimingMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetTimingMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class SKAction */
}
