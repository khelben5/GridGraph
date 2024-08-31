module GraphAssertions

open Xunit
open Graphs

let assertShouldContainNode vertex graph =
    Assert.True(GridGraph.hasVertex vertex graph, $"Graph should contain vertex {vertex |> Vertex.description}.")

let assertShouldContainEdge edge graph =
    Assert.True(GridGraph.hasEdge edge graph, $"Graph should contain edge {edge |> Edge.description}")

let assertShouldContain nodes edges graph =
    nodes |> Array.iter (fun node -> assertShouldContainNode node graph)
    edges |> Array.iter (fun edge -> assertShouldContainEdge edge graph)
