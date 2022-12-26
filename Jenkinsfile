node {
	stage 'Checkout'
		git 'https://github.com/manishaskulkarni/HumanResourceSystem.git' 

	stage 'Build'
    bat 'C:\\Manisha\\NuGet\\nuget.exe restore HRSNew.sln'
		msBuild = tool 'msbuild'
	  bat """
	   "${msBuild}\\msbuild.exe" HRSNew.sln /p:Configuration=Release /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}
    """

	stage 'Archive'
		archive 'HRSNew/bin/**'

}
