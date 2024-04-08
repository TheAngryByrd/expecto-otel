namespace Library1
open System.Diagnostics
open FsOpenTelemetry

module Say =
    let actSource = new ActivitySource("Library1", "1.0.0")
    let hello name =
        use act = actSource.StartActivityForFunc()
        act.AddTag("name", name) |> ignore
        sprintf "Hello %s" name
