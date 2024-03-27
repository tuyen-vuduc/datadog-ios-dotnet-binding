# Datahog SDK for iOS

## Tools
- [Carthage](https://github.com/Carthage/Carthage)
- [Objective Sharpie](https://learn.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/)

## Steps to create/update

- 1/ Install above mentioned Tools
- 2/ Run `carthage update --use-xcframeworks`
- 3/ Run `sh gen.sh`
- 4/ Try compiling and correct compilation issues

# NOTES

## Dependency Tree

```
- 1. CrashReporter
- 2. DatadogCore
- 3. DatadogCrashReporting
    - 1. CrashReporter
    - 2. DatadogCore
- 4. DatadogInternal
    - 2. DatadogCore
    - 9. DatadogTrace
- 5. DatadogLogs
    - 2. DatadogCore
    - 4. DatadogInternal
- 6. DatadogObjc
    - 2. DatadogCore
    - 4. DatadogInternal
    - 5. DatadogLogs
    - 8. DatadogSessionReplay
    - 9. DatadogTrace
- 7. DatadogRUM
    - 2. DatadogCore
    - 4. DatadogInternal
- 8. DatadogSessionReplay
    - 2. DatadogCore
    - 4. DatadogInternal
- 9. DatadogTrace
    - 2. DatadogCore
- 10. DatadogWebViewTracking
    - 2. DatadogCore
    - 4. DatadogInternal
```

# LICENSE
This repository is licensed under The 3-Clause BSD license. However, Datahog libraries are licensed as specified by [Datahog](https://github.com/DataDog/dd-sdk-ios).