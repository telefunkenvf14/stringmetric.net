﻿module StringMetric.Hamming

open System

let metric (str1: string) (str2: string) =
    if String.IsNullOrEmpty str1
       || String.IsNullOrEmpty str2
       || str1.Length <> str2.Length
    then None
    else
        let len = float str1.Length
        let equalCount =
            str1
            |> Seq.zip str2
            |> Seq.map (fun (x,y) -> if x = y then 1 else 0)
            |> Seq.sum
            |> float
        Some (equalCount / len)
