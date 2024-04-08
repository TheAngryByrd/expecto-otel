namespace Library2
open System.Diagnostics
open FsOpenTelemetry
open Library1
module Say =
    let hello name =
        use act = Say.actSource.StartActivityForFunc()
        Say.hello name
        // printfn "Hello %s" name
