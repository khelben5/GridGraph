namespace Graphs

type Graph =
    { nodes: Node array; edges: Edge array }

module Graph =

    let empty = { nodes = [||]; edges = [||] }
