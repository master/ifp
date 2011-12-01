open System.Net
open System
open System.IO

let reduceReader (sr: TextReader) =
    Seq.initInfinite (fun _ -> sr.ReadLine())
    |> Seq.takeWhile (fun line -> line <> null)
    |> Seq.map (fun line -> line.Split('\t', '\n', ' '))
    |> Seq.groupBy (fun line -> line.[0].Trim())
    |> Seq.map (fun (k, vs) -> (k, Seq.map (Seq.nth 1) vs))

let reduceWriter (sw: TextWriter) (key: string, values: seq<string>) =
    values |> Seq.map (fun v -> key + "\t" + v) |> Seq.iter sw.WriteLine
        
// ---------------------------------------------------------------------------

let reducer (key: string, values: seq<string>): (string * seq<string>) =
    //  TODO: your code here
    (key, seq [""])

// ---------------------------------------------------------------------------

reduceReader Console.In |> Seq.map reducer |> Seq.iter (reduceWriter Console.Out)
