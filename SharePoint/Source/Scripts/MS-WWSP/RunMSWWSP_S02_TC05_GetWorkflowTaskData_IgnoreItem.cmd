@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_WWSP.S02_GetForItem.MSWWSP_S02_TC05_GetWorkflowTaskData_IgnoreItem /testcontainer:..\..\MS-WWSP\TestSuite\bin\Debug\MS-WWSP_TestSuite.dll /runconfig:..\..\MS-WWSP\MS-WWSP.testsettings /unique
pause