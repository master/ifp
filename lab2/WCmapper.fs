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

let wordCount (values: seq<string>): seq<string> =
    values |> Seq.map (fun word -> word + "\t1")

mapReader Console.In |> Seq.map wordCount |> Seq.iter (mapWriter Console.Out)
