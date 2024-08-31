module NodeTests

open Xunit
open Graphs

[<Fact>]
let ``Creates a node`` () =
    let anyNodeId = UUID.create () |> NodeId.create
    let anyOtherNodeId = UUID.create () |> NodeId.create

    let firstNode = anyNodeId |> Node.createWithId
    let secondNode = anyNodeId |> Node.createWithId
    let thirdNode = anyOtherNodeId |> Node.createWithId

    Assert.Equal(firstNode, secondNode)
    Assert.NotEqual(firstNode, thirdNode)
    Assert.NotEqual(secondNode, thirdNode)
