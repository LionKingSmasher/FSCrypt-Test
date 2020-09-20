// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printf "키를 입력하십시오: ";
    let mutable Key : int32 = System.Convert.ToInt32(Console.ReadLine());
    printf "라운드 횟수를 입력하십시오: ";
    let mutable Round : int32 = System.Convert.ToInt32(Console.ReadLine());
    let mutable Result : int32 = 0;
    printfn "%d" Key;
    Console.ReadLine() 
    |> Seq.iter (fun In ->
        for i = 0 to Round do 
            Result <- System.Convert.ToInt32(In) ^^^ Key;
            Key <- Result + 1;
        //printf "%c" (System.Convert.ToChar(Result));
        printf "%X" Result;
    )
    0
