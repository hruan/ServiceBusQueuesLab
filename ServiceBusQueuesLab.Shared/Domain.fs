namespace ServiceBusQueuesLab.Shared.Domain

open System
open System.Runtime.Serialization

type Move =
    | Rock = 0
    | Paper = 1
    | Scissors = 2

type Round = Move * Move

type Outcome =
    | PlayerOneWins = 0
    | PlayerTwoWins = 1
    | Draw = 2

[<DataContract>]
type GameData () =
    [<field: DataMemberAttribute>]
    member val GameId = String.Empty with get, set

    [<field: DataMemberAttribute>]
    member val Participants = String.Empty, String.Empty with get, set

    [<field: DataMemberAttribute>]
    member val Rounds = Seq.empty<Round> with get, set

[<DataContract>]
type GameStatistics () =
    [<field: DataMemberAttribute>]
    member val GameId = String.Empty with get, set

    [<field: DataMemberAttribute>]
    member val Participants = String.Empty, String.Empty with get, set

    [<field: DataMemberAttribute>]
    member val Outcome = Outcome.Draw with get, set

    [<field: DataMemberAttribute>]
    member val RoundsWon = 0 with get, set

    [<field: DataMemberAttribute>]
    member val Rounds = 0 with get, set

module Game =
    let rec private decideOutcomeOf round reversed =
        let winner = if reversed then Outcome.PlayerTwoWins else Outcome.PlayerOneWins
        match round with
        | x, y when
            not (Enum.IsDefined(typeof<Move>, int x))
            || not (Enum.IsDefined(typeof<Move>, int y)) -> failwith "enum expected"
        | x, y when x = y           -> Outcome.Draw
        | Move.Rock, Move.Scissors  -> winner
        | Move.Scissors, Move.Paper -> winner
        | Move.Paper, Move.Rock     -> winner
        | x, y                      -> decideOutcomeOf (y, x) (not reversed)

    let private winnerOfRound round = decideOutcomeOf round false

    let OutcomeOf game =
        let outcomes = game
                       |> Seq.map winnerOfRound
                       |> Seq.filter (fun outcome -> outcome <> Outcome.Draw)
                       |> Seq.toArray
                       |> Array.partition (fun outcome -> outcome = Outcome.PlayerOneWins)
        let roundsWon = (fst outcomes).Length, (snd outcomes).Length
        match roundsWon with
        | x, y when x = y -> (Outcome.Draw, 0)
        | x, y when x < y -> (Outcome.PlayerTwoWins, snd roundsWon)
        | x, y when x > y -> (Outcome.PlayerOneWins, fst roundsWon)

    let WinnerOf (game: GameData) outcome =
        match outcome with
        | Outcome.Draw -> System.String.Empty
        | Outcome.PlayerOneWins -> fst game.Participants
        | Outcome.PlayerTwoWins -> snd game.Participants