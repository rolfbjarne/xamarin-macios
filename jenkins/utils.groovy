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
    sh "mv ${packageDir}/${packageName}-signed.pkg ${packageDir}/${packageName}.pkg"
    echo "Signed ${packageName}"
}

return this
