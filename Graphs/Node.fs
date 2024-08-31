namespace Graphs

type Node = private { id: NodeId }

module Node =

    let createWithId id = { id = id }

    let description node =
        $"Node({node.id |> NodeId.description})"
