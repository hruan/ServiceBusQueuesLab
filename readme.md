# Azure Service Bus lab: queues

The primary purpose of the this is to explore and gain an understanding of the
basic functionality of queues on Azure.

## Problem description

Imagine that you have a rock, paper, and scissors game running on mobile
devices where each user have an associated profile. You are tasked with writing
a service for determining the outcome of each games which is then used to
update the user profiles following each game.

At the conclusion of each games, the game id, its participants as well as the
players' moves for each round of the game, between 3 and 7 rounds in total, are
sent to a Service Bus queue. The body of each message contains the following
data:

    {
        "gameId":       <UUID>,
        "participants": [ <playerOneId>, <playerTwoId> ],
        "rounds":       [ [ <playerOneMove>, <playerTwoMove> ],
                        [ <playerOneMove>, <playerTwoMove> ],
                        [ <playerOneMove>, <playerTwoMove> ],
                          ... ]
    }

Additionally, each message header also contains the name of another queue
entity to which the game results are to be sent.

The service needs to accomplish the following steps:

- Receive messages from the queue
- Extract the game data from the message body
- Determine the outcome, as well as some other statistics of the game
- Reply to the queue entity in the message header with the game statistics

## Get started

1. Clone the repository
2. Open the solution in VS2013 (untested on previous releases of VS)
3. Ensure Windows Azure Service Bus NuGet packages are available
4. Read the comments on interfaces defined in the Contracts folder and
   optionally the types defined in Shared.Domain.
5. Substitute ``NotImplementedException`` with working implementation
6. (Optional) Climb to the top on the scoreboard! ("ClientId"-property
   needs to be set on outgoing message.)

