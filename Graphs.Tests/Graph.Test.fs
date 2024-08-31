module GraphTests

open Xunit
open Graphs

[<Fact>]
let ``Creates an empty graph`` () =
    let emptyGraph = GridGraph.empty ()
    GridGraph.isEmpty emptyGraph |> Assert.True
