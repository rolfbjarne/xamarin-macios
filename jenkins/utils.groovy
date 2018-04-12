def reportGitHubStatus(commitHash, context, backref, statusResult, statusResultMessage) {
    step([
        $class: 'GitHubCommitStatusSetter',
        commitShaSource: [$class: "ManuallyEnteredShaSource", sha: commitHash],
        contextSource: [$class: 'ManuallyEnteredCommitContextSource', context: context],
        statusBackrefSource: [$class: 'ManuallyEnteredBackrefSource', backref: backref],
        statusResultSource: [$class: 'ConditionalStatusResultSource', results: [[$class: 'AnyBuildResult', state: statusResult, message: statusResultMessage]]]
    ])
}

def signPackage(packageDir, packageName) {
    echo "Signing ${packageName}"
    withCredentials([string(credentialsId: 'codesign_keychain_pw', variable: 'CODESIGN_KEYCHAIN_PASSWORD')]) {
        sh "security unlock-keychain -p $CODESIGN_KEYCHAIN_PASSWORD"
        sh "/usr/bin/productsign -s 'Developer ID Installer: Xamarin Inc' '${packageDir}/${packageName}' '${packageDir}/${packageName}-signed.pkg'"
        sh "/usr/sbin/spctl -vvv --assess --type install '${packageDir}/${packageName}-signed.pkg'"
    }
    sh "mv ${packageDir}/${packageName}-signed.pkg ${packageDir}/${packageName}"
    echo "Signed ${packageName}"
}

def commentOnCommit(commitHash, commentFile) {
    def markdown = readFile commentFile
    def json = groovy.json.JsonOutput.toJson([body: markdown])
    def jsonFile = "${commentFile}.json"
    writeFile jsonFile json
    sh "cat ${commentFile}"
    sh "cat ${jsonFile}"
    withCredentials([string(credentialsId: 'macios_github_comment_token', variable: 'GITHUB_COMMENT_TOKEN')]) {
        sh "curl -vvvv -i -H 'Authorization: token ${GITHUB_COMMENT_TOKEN}'  https://api.github.com/repos/xamarin/xamarin-macios/commits/${commitHash}/comments --request POST --data '@${jsonFile}'"
    }
}

return this
