Imports NUnit.Framework
Imports TechTalk.SpecFlow
Imports System
Imports System.CodeDom.Compiler
Imports System.Reflection

<GeneratedCode("SpecFlow", "3.1.86")>
<SetUpFixture>
Public NotInheritable Class PROJECT_ROOT_NAMESPACE_NUnitAssemblyHooks
    <OneTimeSetUp>
    Public Shared Sub AssemblyInitialize()
        Dim currentAssembly As Assembly = GetType(PROJECT_ROOT_NAMESPACE_NUnitAssemblyHooks).Assembly

        TestRunnerManager.OnTestRunStart(currentAssembly)
    End Sub

    <OneTimeTearDown>
    Public Shared Sub AssemblyCleanup()
        Dim currentAssembly As Assembly = GetType(PROJECT_ROOT_NAMESPACE_NUnitAssemblyHooks).Assembly

        TestRunnerManager.OnTestRunEnd(currentAssembly)
    End Sub

End Class
