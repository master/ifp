open System.Net
open System
open System.IO

let mapReader (sr: TextReader) =
    Seq.initInfinite (fun _ -> sr.ReadLine())
    |> Seq.takeWhile (fun line -> line <> null)
    |> Seq.map (fun line -> line.Split('\t', '\n', ' '))
    |> Seq.map Seq.ofArray

let mapWriter (sw: TextWriter) (key: string, values: seq<string>) =
    values |> Seq.map (fun v -> key + "\t" + v) |> Seq.iter sw.WriteLine

let wordCount (values: seq<string>): seq<string*seq<string>> =
    values |> Seq.map (fun word -> (word, seq ["1"]))

mapReader Console.In |> Seq.map wordCount |> Seq.iter (Seq.iter (mapWriter Console.Out))
