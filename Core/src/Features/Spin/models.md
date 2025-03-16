Game
- Id (PK, int)  
- State (enum)  
- NumberOfRounds (int)  
- CurrentRound (int)  

GamePlayer 
- PK: (GameId, PlayerId)  
- GameId (FK, int)
- PlayerId (FK, int)
- Active (bool)

Round 
- Id (PK, int)  
- GameId (FK, int)
- Completed (bool)  

RoundPlayer 
- PK: (RoundId, PlayerId)  
- RoundId (FK, int) 
- PlayerId (FK, int)
- IsHost (bool)

Challenge
- Id (PK, int)  
- RoundId (FK, int) 
- NumberOfParticipants (int)
- Text (string)  
- ReadBeforeSpin (bool)
- Weight (int)  ?????????

Player 
- Id (PK, int)  
