# Common API code

This is common code shared between the server and the client (nominally).  Code in here should have the following properties:
1. Be decoupled - assume nothing about the existence of the client or server environment, use inputs to configure for different environments.
2. Be deterministic - this will facilitate an authoritative or anti-cheat architecture later.
3. Be data driven - avoid baking in assumptions about the data driving algorithms.  Use the configuration system to read these parameters from user-modifiable data files.
4. Be extensible - prefer interfaces rather than concrete classes where possible.  Provide base implementations but don't *assume* the base implementation unless absolutely required.
6. Be asynchronous - avoid requiring callers to wait for long-running operations.  Allow either async calls or event callbacks to complete the work (prefer async calls).
