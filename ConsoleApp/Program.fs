open MemberLibrary
open OrderLibrary
open System

[<EntryPoint>]
let main argv =
    let account = "Sam"
    let originalPrice = 800.0
    let discount = 0.8
    
    originalPrice
    |> OrderService.getPrice discount
    |> printfn "Real price:%0.0f"        

    0 // return an integer exit code
