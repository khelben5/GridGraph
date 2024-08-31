module GraphTests

open Xunit
open Graphs

[<Fact>]
let ``Creates an empty graph`` () =
    let emptyGraph = Graph.empty ()
    Graph.isEmpty emptyGraph |> Assert.True

[<Fact>]
let ``Creates a graph with nodes and edges`` () =
    let nodeIds = (fun _ -> UUID.create () |> NodeId.create) |> Array.init 4
    let nodes = nodeIds |> Array.map Node.createWithId

    let edges =
        [| Edge.create nodeIds[0] nodeIds[1]
           Edge.create nodeIds[1] nodeIds[2]
           Edge.create nodeIds[2] nodeIds[3]
           Edge.create nodeIds[3] nodeIds[0] |]
        |> Array.choose (fun result -> result |> Result.toOption)

    Graph.withNodesAndEdges nodes edges
    |> GraphAssertions.assertShouldContain nodes edges

[<Fact>]
let ``Adds a new node`` () =
    let node = UUID.create () |> NodeId.create |> Node.createWithId

    Graph.empty () |> Graph.addNode node |> Graph.hasNode node |> Assert.True
