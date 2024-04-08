module TestApp1
open Expecto
open System.Threading

[<EntryPoint>]
let main argv =
    let results = Tests.runTestsInAssembly defaultConfig argv

    Thread.Sleep(10000)
    Tests.traceProvider.Dispose()
    Tests.loggerFactory.Dispose()
    Tests.meterProvider.Dispose()
    Thread.Sleep(10000)

    results
