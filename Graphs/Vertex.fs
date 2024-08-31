namespace Graphs

type Vertex = private { x: int; y: int }

module Vertex =

    let create x y = { x = x; y = y }

    let description vertex = $"Vertex({vertex.x}, {vertex.y})"
