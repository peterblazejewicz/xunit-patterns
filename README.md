# xUnit Tests Patters

Tests patterns taken from [xUnit](https://xunit.github.io/) [documentation](https://xunit.github.io/docs/) and elsewhere.

Note that this tests requires local installation of SQLite database.

## xUnit command line usage

Hard to find, but call `dnx test -?`
```
dnx test -?
xUnit.net DNX Runner (64-bit DNXCore 5.0)
Copyright (C) 2015 Outercurve Foundation.

usage: xunit.runner.dnx [configFile.json] [options] [reporter] [resultFormat filename [...]]

Valid options:
  -nologo                : do not show the copyright message
  -nocolor               : do not output results with colors
  -parallel option       : set parallelization based on option
                         :   none        - turn off all parallelization
                         :   collections - only parallelize collections
                         :   assemblies  - only parallelize assemblies
                         :   all         - parallelize collections and assemblies
  -maxthreads count      : maximum thread count for collection parallelization
                         :   default   - run with default (1 thread per CPU thread)
                         :   unlimited - run with unbounded thread count
                         :   (number)  - limit task thread pool size to 'count'
  -wait                  : wait for input after completion
  -diagnostics           : enable diagnostics messages for all test assemblies
  -trait "name=value"    : only run tests with matching name/value traits
                         : if specified more than once, acts as an OR operation
  -notrait "name=value"  : do not run tests with matching name/value traits
                         : if specified more than once, acts as an AND operation
  -method "name"         : run a given test method (should be fully specified;
                         : i.e., 'MyNamespace.MyClass.MyTestMethod')
                         : if specified more than once, acts as an OR operation
  -class "name"          : run all methods in a given test class (should be fully
                         : specified; i.e., 'MyNamespace.MyClass')
                         : if specified more than once, acts as an OR operation
  -namespace "name"      : run all methods in a given namespace (i.e.,
                         : 'MyNamespace.MySubNamespace')
                         : if specified more than once, acts as an OR operation

Reporters: (optional, choose only one)
  -appveyor              : forces AppVeyor CI mode (normally auto-detected)
  -quiet                 : do not show progress messages
  -teamcity              : forces TeamCity mode (normally auto-detected)
  -verbose               : show verbose progress messages

Result formats: (optional, choose one or more)
  -xml <filename>        : output results to xUnit.net v2 style XML file
```

This project can be run with:
```
dnx test -verbose
xUnit.net DNX Runner (32-bit DNX 4.5.1)
  Discovering: TestPatterns
  Discovered:  TestPatterns
  Starting:    TestPatterns
    TestPatterns.ClassFixtureTests.ConnectionIsEstablished
    TestPatterns.ConnectionTests.ConnectionIsEstablished
    TestPatterns.ClassFixtureTests.FooUserWasInserted
    TestPatterns.InsertTests.FooUserWasInserted
  Finished:    TestPatterns
=== TEST EXECUTION SUMMARY ===
   TestPatterns  Total: 4, Errors: 0, Failed: 0, Skipped: 0, Time: 0.227s
```

## Author

@peterblazejewicz