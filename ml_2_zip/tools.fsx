module Seq = 
    let filterWithIndex (filter:int->'a->bool) (s:'a seq) =
        seq {
            let e = s.GetEnumerator()
            let mutable idx = 0
            while e.MoveNext() do
                if filter idx e.Current then
                    yield e.Current
                idx <- idx+1
    }

type System.Double with 
    static member tryParse s = match System.Double.TryParse s with | false,_ -> None | true,v -> Some v 
type System.Int32 with 
    static member tryParse s = match System.Int32.TryParse s with | false,_ -> None | true,v -> Some v 