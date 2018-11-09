
# react-native-momosdk-reactnative

## Getting started

`$ npm install react-native-momosdk-reactnative --save`

### Mostly automatic installation

`$ react-native link react-native-momosdk-reactnative`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-momosdk-reactnative` and add `RNMomosdkReactnative.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNMomosdkReactnative.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNMomosdkReactnativePackage;` to the imports at the top of the file
  - Add `new RNMomosdkReactnativePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-momosdk-reactnative'
  	project(':react-native-momosdk-reactnative').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-momosdk-reactnative/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-momosdk-reactnative')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNMomosdkReactnative.sln` in `node_modules/react-native-momosdk-reactnative/windows/RNMomosdkReactnative.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Momosdk.Reactnative.RNMomosdkReactnative;` to the usings at the top of the file
  - Add `new RNMomosdkReactnativePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNMomosdkReactnative from 'react-native-momosdk-reactnative';

// TODO: What to do with the module?
RNMomosdkReactnative;
```
  