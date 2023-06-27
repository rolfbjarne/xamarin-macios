#load "provision-shared.csx"

using System.Collections.Generic;

var beta = 2;
var runtimeUrls = new string [] {
	$"https://dl.internalx.com/xcodes/Xcode_15_beta_{beta}.watchOS_10_beta_{beta}_Simulator_Runtime.dmg",
	$"https://dl.internalx.com/xcodes/Xcode_15_beta_{beta}.iOS_17_beta_{beta}_Simulator_Runtime.dmg",
	$"https://dl.internalx.com/xcodes/Xcode_15_beta_{beta}.watchOS_10_beta_{beta}_Simulator_Runtime.dmg",
	$"https://dl.internalx.com/xcodes/Xcode_15_beta_{beta}.tvOS_17_beta_{beta}_Simulator_Runtime.dmg",
	$"https://dl.internalx.com/xcodes/Xcode_15_beta_{beta}.visionOS_{beta - 1}_beta_Simulator_Runtime.dmg",
};

var downloader = new Downloader ();
var headers = new List<(string, string)> { ("Authorization", $"token {AuthToken ("github.com")}") };
var targetPath = Path.Combine (Path.GetTempPath (), "provisionator-simulator-runtimes");
Directory.CreateDirectory (targetPath);

foreach (var url in runtimeUrls) {
	var targetFileName = Path.GetFileName (url);
	var targetFile = Path.Combine (targetPath, targetFileName);

	Console.WriteLine ($"Downloading {url} into {targetFile} ({Array.IndexOf (runtimeUrls, url) + 1}/{runtimeUrls.Length} files)...");
	var indexFile = await downloader.DownloadItemAsync (
		url,
		headers,
		targetPath,
		targetFileName,
		options: Downloader.Options.Default.WithUseCache (true),
		statusHandler: (status) => Console.WriteLine (status));

	Console.WriteLine ($"Downloaded {url} into {targetFile}");
}
