[<EntryPoint>]
let main argv =
  let a=System.Int32.Parse(argv.[0])
  let next x=
    match x with
    | x when x%2=0->x/2
    | _->x*3+1
  let rec cseq n = 
    match next n with
    | n when n=1->[1]
    | n -> [n]@cseq n
  [a]@(cseq a)
  |>Seq.length
  |>printfn "%d"
  0