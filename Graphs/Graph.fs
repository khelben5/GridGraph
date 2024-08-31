namespace Graphs

type Graph =
    private
        { nodes: Node array
          edges: Edge array }

module Graph =

    let empty () = { nodes = [||]; edges = [||] }

    let withNodesAndEdges nodes edges = { nodes = nodes; edges = edges }

    let isEmpty graph =
        graph.nodes |> Array.isEmpty && graph.edges |> Array.isEmpty

    let createGrid height width =
        let nodes =
            (fun _ -> UUID.create () |> NodeId.create |> Node.createWithId)
            |> Array.init (height * width)

        withNodesAndEdges nodes [||]

    let addNode node graph =
        { graph with
            nodes = graph.nodes |> Array.append [| node |] }

    let hasNode node graph = graph.nodes |> Array.contains node

    let hasEdge edge graph = graph.edges |> Array.contains edge

    let nodes graph = graph.nodes

    let edges graph = graph.edges

    // let degree node =

    let description graph =
        let nodeDescriptions = graph.nodes |> Array.map Node.description
        let edgeDescriptions = graph.edges |> Array.map Edge.description
        $"Graph(nodes=[{nodeDescriptions}, edges={edgeDescriptions}])"
