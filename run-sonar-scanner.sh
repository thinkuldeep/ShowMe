#!/bin/sh

#Start pre-processing
/Library/Frameworks/Mono.framework/Versions/Current/Commands/mono /Applications/sonarscannermsbuild/SonarScanner.MSBuild.exe begin /k:"UnityFirst" /d:sonar.host.url="http://localhost:9000" 

#rebuild
/Library/Frameworks/Mono.framework/Versions/Current/Commands/msbuild /t:rebuild ShowMe.sln 

#post processing
/Library/Frameworks/Mono.framework/Versions/Current/Commands/mono /Applications/sonarscannermsbuild/SonarScanner.MSBuild.exe end

