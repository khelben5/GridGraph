namespace Graphs

type GridGraph =
    private
        { vertices: Vertex array
          edges: Edge array }

module GridGraph =

    let empty () = { vertices = [||]; edges = [||] }

    let isEmpty graph =
        Array.isEmpty graph.vertices && Array.isEmpty graph.edges

    let create height width = empty ()

    let vertexCount graph = Array.length graph.vertices

    let edgeCount graph = Array.length graph.edges

    let hasVertex vertex graph = graph.vertices |> Array.contains vertex

    let hasEdge edge graph = graph.edges |> Array.contains edge

    let description graph =
        let vertexDescriptions = graph.vertices |> Array.map Vertex.description
        let edgeDescriptions = graph.edges |> Array.map Edge.description
        $"Graph(nodes=[{vertexDescriptions}, edges={edgeDescriptions}])"
