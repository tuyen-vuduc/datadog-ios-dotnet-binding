dirs=(Carthage/Build/*/) 
find=".xcframework"
replace=""

for dir in "${dirs[@]}"
do
    dirName="$(basename $dir)"
    frameworkName=${dirName//$find/$replace}
    echo $dir $frameworkName

    sharpie bind \
        --output libs/$frameworkName.iOS \
        --namespace $frameworkName \
        --sdk iphoneos17.2 \
        -scope $dir/ios-arm64_arm64e/$frameworkName.framework/Headers \
            $dir/ios-arm64_arm64e/$frameworkName.framework/Headers/*.h
done