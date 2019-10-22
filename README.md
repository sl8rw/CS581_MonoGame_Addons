# MonoGame Trello Board for our 581 group:

- https://trello.com/invite/b/9iFK5BR2/8c4fcccd4155f47c2dcfa7818ca526ce/cs581-monogame

# MonoGame CS581 Slater, Mike, and Josiah Additions:

- Slater

  - ~https://github.com/MonoGame/MonoGame/issues/6679~ **_COMPLETED_**
  - ~https://github.com/MonoGame/MonoGame/issues/6899~ **_COMPLETED_**
  - ~https://github.com/MonoGame/MonoGame/issues/3578~ **_COMPLETED_**
  - ~https://github.com/MonoGame/MonoGame/issues/6112~ **_COMPLETED_**
  - ~Exam Fix: Implement a change for vectors preventing division by 0 _ref:_ https://www.scratchapixel.com/lessons/3d-basic-rendering/minimal-ray-tracer-rendering-simple-shapes/ray-box-intersection~
  - ~**DocFX IMPORTANT:**https://github.com/MonoGame/MonoGame/issues/5559 _ref:_ https://github.com/dotnet/docfx/projects/1 for v3 of docFX~ **cancelled due to v3 release date in a few months**
  - https://github.com/MonoGame/MonoGame/issues/5745
  - https://github.com/MonoGame/MonoGame/issues/6909
  - https://github.com/MonoGame/MonoGame/issues/5616
  - https://github.com/MonoGame/MonoGame/issues/5745
  - Possible replacement issue: https://github.com/MonoGame/MonoGame/issues/6811

- Josiah
- Mike
  - https://github.com/MonoGame/MonoGame/issues/5000
  - https://github.com/MonoGame/MonoGame/issues/6633
  - https://github.com/MonoGame/MonoGame/issues/6603

# MonoGame How To Test Locally

- Make a MG project using the MG templates you can download with MG installed from [here](http://www.monogame.net/downloads/)
- Delete the MG assembly reference
- **Make sure to run the following before adding csproj file:**
  - `git submodule update --init`
  - if the above fails (_server does not..._) then run `git submodule sync` and then rerun `git submodule update --init`
  - Windows: `.\Protobuild.exe --generate $PLATFORM`
- Right click your solution project and add existing project. Find the csproj file in the MonoGame.Framework directory
- Add an assembly reference to this too
- Build as usual (this will use your local monogame edits so you can step into)

# MonoGame Documentation

- **possible documentation software change**: If using a mac, download docfx using Homebrew: `brew install docfx as this will install _v2.46_

# MonoGame (Original Readme)

One framework for creating powerful cross-platform games. The spiritual successor to XNA with thousands of titles shipped across desktop, mobile, and console platforms. [MonoGame](http://www.monogame.net/) is a fully managed .NET open source game framework without any black boxes. Create, develop and distribute your games your way.

[![Join the chat at https://gitter.im/MonoGame/MonoGame](https://badges.gitter.im/MonoGame/MonoGame.svg)](https://gitter.im/MonoGame/MonoGame?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

- [MonoGame Trello Board for our 581 group:](#monogame-trello-board-for-our-581-group)
- [MonoGame CS581 Slater, Mike, and Josiah Additions:](#monogame-cs581-slater-mike-and-josiah-additions)
- [MonoGame How To Test Locally](#monogame-how-to-test-locally)
- [MonoGame Documentation](#monogame-documentation)
- [MonoGame (Original Readme)](#monogame-original-readme)
  - [Build Status](#build-status)
  - [Supported Platforms](#supported-platforms)
  - [Support and Contributions](#support-and-contributions)
    - [Subscription](#subscription)
  - [Source Code](#source-code)
  - [Helpful Links](#helpful-links)
  - [License](#license)

## Build Status

Our [build server](http://teamcity.monogame.net/?guest=1) builds, tests, and packages the latest MonoGame changes. The table below shows the current build status for the develop branch.

| Name                            | Status                                                                                                                                                                                                             |
| :------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Build Windows, Web, and Android | [![Build Status](http://teamcity.monogame.net/app/rest/builds/buildType:MonoGame_DevelopWin/statusIcon)](http://teamcity.monogame.net/viewType.html?buildTypeId=MonoGame_DevelopWin&guest=1)                       |
| Build Mac, iOS, and Linux       | [![Build Status](http://teamcity.monogame.net/app/rest/builds/buildType:MonoGame_DevelopMac/statusIcon)](http://teamcity.monogame.net/viewType.html?buildTypeId=MonoGame_DevelopMac&guest=1)                       |
| Generate Documentation          | [![Build Status](http://teamcity.monogame.net/app/rest/builds/buildType:MonoGame_GenerateDocumentation/statusIcon)](http://teamcity.monogame.net/viewType.html?buildTypeId=MonoGame_GenerateDocumentation&guest=1) |
| Windows Tests                   | [![Build Status](http://teamcity.monogame.net/app/rest/builds/buildType:MonoGame_TestWindows/statusIcon)](http://teamcity.monogame.net/viewType.html?buildTypeId=MonoGame_TestWindows&guest=1)                     |
| Package NuGet                   | [![Build Status](http://teamcity.monogame.net/app/rest/builds/buildType:MonoGame_PackageNuGet/statusIcon)](http://teamcity.monogame.net/viewType.html?buildTypeId=MonoGame_PackageNuGet&guest=1)                   |
| Package Mac and Linux           | [![Build Status](http://teamcity.monogame.net/app/rest/builds/buildType:MonoGame_PackageMacAndLinux/statusIcon)](http://teamcity.monogame.net/viewType.html?buildTypeId=MonoGame_PackageMacAndLinux&guest=1)       |
| Package Windows                 | [![Build Status](http://teamcity.monogame.net/app/rest/builds/buildType:MonoGame_PackagingWindows/statusIcon)](http://teamcity.monogame.net/viewType.html?buildTypeId=MonoGame_PackagingWindows&guest=1)           |

## Supported Platforms

We support a growing list of platforms across the desktop, mobile, and console space. If there is a platform we don't support, please [make a request](https://github.com/MonoGame/MonoGame/issues) or [come help us](CONTRIBUTING.md) add it.

- Desktop PCs
  - Windows 10 Store Apps (UWP)
  - Windows Win32 (OpenGL & DirectX)
  - Linux (OpenGL)
  - Mac OS X (OpenGL)
- Mobile/Tablet Devices
  - Android (OpenGL)
  - iPhone/iPad (OpenGL)
  - Windows Phone 10 (UWP)
- Consoles (for registered developers)
  - PlayStation 4
  - PlayStation Vita
  - Xbox One (both UWP and XDK)
  - Nintendo Switch
- Other
  - tvOS (OpenGL)

## Support and Contributions

If you think you have found a bug or have a feature request, use our [issue tracker](https://github.com/MonoGame/MonoGame/issues). Before opening a new issue, please search to see if your problem has already been reported. Try to be as detailed as possible in your issue reports.

If you need help using MonoGame or have other questions we suggest you post on our [community forums](http://community.monogame.net). Please do not use the GitHub issue tracker for personal support requests.

If you are interested in contributing fixes or features to MonoGame, please read our [contributors guide](CONTRIBUTING.md) first.

### Subscription

If you'd like to help the project by supporting us financially, consider supporting us via a subscription for the price of a monthly coffee.

Money goes towards hosting, new hardware and if enough people subscribe a dedicated developer.

There are several options on our [Donation Page](http://www.monogame.net/donate/).

## Source Code

The full source code is available here from GitHub:

- Clone the source: `git clone https://github.com/MonoGame/MonoGame.git`
- Set up the submodules: `git submodule update --init`
- Run Protobuild.exe to generate project files and solutions.
  - If on Linux or Mac, run it with mono: `mono Protobuild.exe`
- You can generate solutions for platforms that are not buildable from the current OS with:
  - Windows: `.\Protobuild.exe --generate $PLATFORM`
  - Linux or Mac: `mono Protobuild.exe --generate $PLATFORM`
- Open the solution for your target platform to build the game framework.
- Open the solution for your development platform for building the pipeline and content tools.

For the prerequisites for building from source, please look at the [Requirements](REQUIREMENTS.md) file.

A high level breakdown of the components of the framework:

- The game framework is found in [MonoGame.Framework](MonoGame.Framework).
- The content pipeline is located in [MonoGame.Framework.Content.Pipeline](MonoGame.Framework.Content.Pipeline).
- The MonoDevelop addin is in [IDE/MonoDevelop](IDE/MonoDevelop).
- The Visual Studio templates are in [ProjectTemplates](ProjectTemplates).
- NuGet packages are located in [NuGetPackages](NuGetPackages).
- See [Test](Test) for the pipeline and framework unit tests.
- [Tools/MGCB](Tools/MGCB) is the command line tool for content processing.
- [Tools/2MGFX](Tools/2MGFX) is the command line effect compiler tool.
- The [Tools/Pipeline](Tools/Pipeline) tool is a GUI frontend for content processing.

## Helpful Links

- The official website is [monogame.net](http://www.monogame.net).
- Our [issue tracker](https://github.com/MonoGame/MonoGame/issues) is on GitHub.
- Use our [community forums](http://community.monogame.net/) for support questions.
- You can [chat live](https://gitter.im/mono/MonoGame?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) with the core developers and other users.
- The [official documentation](http://www.monogame.net/documentation/) is on our website.
- Download release and development [installers and packages](http://www.monogame.net/downloads/).
- Follow [@MonoGameTeam](https://twitter.com/monogameteam) on Twitter.

## License

The MonoGame project is under the [Microsoft Public License](https://opensource.org/licenses/MS-PL) except for a few portions of the code. See the [LICENSE.txt](LICENSE.txt) file for more details. Third-party libraries used by MonoGame are under their own licenses. Please refer to those libraries for details on the license they use.
