module GridGraphTests

open Xunit
open Graphs

[<Fact>]
let ``Creates an empty graph`` () =
    let emptyGraph = GridGraph.empty ()
    GridGraph.isEmpty emptyGraph |> Assert.True

[<Fact>]
let ``Creates a non empty grid graph`` () =
    let vertex00 = Vertex.create 0 0
    let vertex01 = Vertex.create 0 1
    let vertex02 = Vertex.create 0 2
    let vertex10 = Vertex.create 1 0
    let vertex11 = Vertex.create 1 1
    let vertex12 = Vertex.create 1 2
    let vertex20 = Vertex.create 2 0
    let vertex21 = Vertex.create 2 1
    let vertex22 = Vertex.create 2 2

    let expectedEdges =
        [| Edge.create vertex00 vertex01
           Edge.create vertex10 vertex20
           Edge.create vertex00 vertex01
           Edge.create vertex10 vertex11
           Edge.create vertex20 vertex21
           Edge.create vertex10 vertex11
           Edge.create vertex11 vertex21
           Edge.create vertex01 vertex02
           Edge.create vertex11 vertex12
           Edge.create vertex21 vertex22
           Edge.create vertex02 vertex12
           Edge.create vertex12 vertex22 |]
        |> Array.choose Result.toOption

    let graph = GridGraph.create 3 3

    expectedEdges
    |> Array.iter (fun edge -> GraphAssertions.assertShouldContainEdge edge graph)

    Assert.Equal(9, GridGraph.vertexCount graph)
    Assert.Equal(12, GridGraph.edgeCount graph)
