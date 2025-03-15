export interface UserDto {
    id: number;
    auth0Id: string;
    email: string;
}

export interface UserEntity {
    id: number;
    auth0Id: string;
    email: string;
}

export interface SpinChallenge {
    id: number;
    roundId: number;
    challenge: string;
    weight: number;
}

export interface SpinGame {
    numRounds: number;
    id: number;
    name: string;
}

export interface SpinRound {
    id: number;
}

export interface SpinScore {
    id: number;
    playerId: number;
    gameId: number;
    score: number;
}

export interface Auth0LoginResponse {
    accessToken: string;
    refreshToken: string;
    scope: string;
    expiresIn: number;
    tokenType: string;
}

export interface Auth0RegisterResponse {
    id: string;
    email: string;
    emailVerified: boolean;
}

export interface AuthRequest {
    email: string;
    password: string;
}

