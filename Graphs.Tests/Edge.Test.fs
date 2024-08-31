module EdgeTests

open Xunit
open Graphs

[<Fact>]
let ``Can not create an edge with the same vertex`` () =
    let nodeId = UUID.create () |> NodeId.create
    let result = Edge.create nodeId nodeId
    result |> Result.isError |> Assert.True

[<Fact>]
let ``Can create an edge with different vertices`` () =
    let nodeIdA = UUID.create () |> NodeId.create
    let nodeIdB = UUID.create () |> NodeId.create
    let result = Edge.create nodeIdA nodeIdB

    match result with
    | Ok edge ->
        Edge.connects nodeIdA edge |> Assert.True
        Edge.connects nodeIdB edge |> Assert.True
    | Error error -> Assert.Fail $"{error}"
