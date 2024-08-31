namespace Graphs

type Edge =
    private
        { nodeIdA: NodeId
          nodeIdB: NodeId }

type SameVertexError = { message: string }

module Edge =

    let create nodeIdA nodeIdB : Result<Edge, SameVertexError> =
        if nodeIdA = nodeIdB then
            Error { message = "Cannot create an edge with the same vertex." }
        else
            Ok { nodeIdA = nodeIdA; nodeIdB = nodeIdB }

    let connects nodeId edge =
        edge.nodeIdA = nodeId || edge.nodeIdB = nodeId

    let description edge =
        $"Edge({edge.nodeIdA |> NodeId.description}, {edge.nodeIdB |> NodeId.description})"
