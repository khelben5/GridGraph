namespace Graphs

type NodeId = private { value: UUID }

module NodeId =

    let create id = { value = id }

    let description nodeId = $"{nodeId.value |> UUID.description}"
