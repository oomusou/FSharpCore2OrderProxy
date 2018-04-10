open MemberLibrary
open OrderLibrary
open System

[<EntryPoint>]
let main argv =
    let account = "Sam"
    let originalPrice = 800.0
    let discount = 0.8
    
    let isMember = MemberService.isMember account
    
    let orderProxy =
        match isMember with
        | true  -> OrderService.getPrice
        | false -> fun _ price -> price 
    
    originalPrice
    |> orderProxy discount
    |> printf "Real price : %0.0f"        

    0 // return an integer exit code
