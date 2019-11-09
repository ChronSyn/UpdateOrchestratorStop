# UpdateOrchestratorStop
[ALPHA] Stops Windows Update from waking up your PC

##

#### The problem

Windows 10 decides to wake up the PC to check for updates. This can happen at any time. Even putting the PC back into sleep mode isn't sufficient to stop it from waking the PC again in some cases. Windows ignores all settings regarding whether to wake the system or not, and actively prevents users from changing some of these settings.

#### The bigger problem

Microsoft: Your UX on this is stressful, and even dangerous.

Stressful: Being woken up at 1:30am because my PC has decided to wake itself up, knowing that I have to be up for work at 6am. I already have a troublesome sleep pattern, so you're making the situation worse.

Dangerous: Finding a laptop inside a bag has woken itself from sleep and is now overheating, potentially starting a fire.

#### The solution
An open source project that runs on any Windows PC with .net 3.5 or later, and attempts to stop the Windows update service.

Further changes may be needed if this isn't sufficient to stop this problem.

This is a heavy-handed approach, but while Microsoft refuse to accept and fix the problem, I will take matters into my own hands.

[![forthebadge](https://forthebadge.com/images/badges/built-with-resentment.svg)](https://forthebadge.com)
