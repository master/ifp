open System.Net
open System
open System.IO

let mapReader (sr: TextReader) =
    Seq.initInfinite (fun _ -> sr.ReadLine())
    |> Seq.takeWhile (fun line -> line <> null)
    |> Seq.map (fun line -> line.Split('\t', '\n', ' '))
    |> Seq.map Seq.ofArray

let mapWriter (sw: TextWriter) (values: seq<string>) =
    values |> Seq.iter (sw.WriteLine)

// ---------------------------------------------------------------------------

let mapper (values: seq<string>): seq<string> =
//  TODO: your code here
    seq [""]

// ---------------------------------------------------------------------------

mapReader Console.In |> Seq.map mapper |> Seq.iter (mapWriter Console.Out)
