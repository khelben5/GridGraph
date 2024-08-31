namespace Graphs

type UUID = private { value: System.Guid }

module UUID =
    let create () = { value = System.Guid.NewGuid() }

    let description uuid = $"{uuid.value}"
