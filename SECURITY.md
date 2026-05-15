# Security Policy

This project is suitable as an educational desktop application template. Do not use it with real patient, payment, or production pharmacy data without additional security work.

Known security follow-ups:

- Replace plain-text password storage with salted password hashing and a migration path for existing users.
- Add role checks around sensitive actions, not only role-based navigation.
- Move environment-specific connection strings out of committed config for deployed environments.
- Add backup and audit logging practices before handling operational data.
