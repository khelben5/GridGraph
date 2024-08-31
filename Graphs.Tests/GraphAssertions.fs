module GraphAssertions

open Xunit
open Graphs

let assertShouldContainNode node graph =
    Assert.True(Graph.hasNode node graph, $"Graph should contain node {node |> Node.description}.")

let assertShouldContainEdge edge graph =
    Assert.True(Graph.hasEdge edge graph, $"Graph should contain edge {edge |> Edge.description}")

let assertShouldContain nodes edges graph =
    nodes |> Array.iter (fun node -> assertShouldContainNode node graph)
    edges |> Array.iter (fun edge -> assertShouldContainEdge edge graph)
