module.exports = function() {
    var instanceRoot = "C:\\inetpub\\wwwroot\\habitat.dev.local";
  var config = {
    websiteRoot: instanceRoot + "\\Website",
    sitecoreLibraries: instanceRoot + "\\Website\\bin",
    licensePath: instanceRoot + "\\Data\\license.xml",
    solutionName: "Sitecore.Demo.Group",
    buildConfiguration: "Debug",
    runCleanBuilds: false
  };
  return config;
}