# Auth0 Setup guide

## Info
After testing the implementation only registration should happen via the backend,
getting new access tokens with refresh token and logging in should be done via the frontend
directly to Auth0 servers. Delete all other boilerplate methods.

When you login og register you need to use a valid mail as username, and a password
with one capital letter, one number and one special character.

## Steps
1. Navigate to Auth0 [Dashboard](https://manage.auth0.com/dashboard/us/dev-8gif55bqfum82z1v/)
2. Create a new Api under Application > APIs > Create API
3. Add refresh tokens and password under Applications > Your app > Settings > Advanced Settings > Grant Types > Save Changes
4. Add configuration values from Applications > Your app > Settings like so
```json
"Auth0": {
    "Issuer": "https://<your_domain>",
    "Audience": "<audience_Indentifier>", // this is the Auth0 Management API
    "ClientId": "<your_client-id>",
    "ClientSecret": "your_client-secret>"
}
```
5. Add a default directory to "Username-Password-Authentication" under Settings > General > Default Directory

