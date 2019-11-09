# UpdateOrchestratorStop
[ALPHA] Stops Windows Update from waking up your PC (or at least, it tries to)

##

#### The problem

Windows 10 decides to wake up the PC to check for updates. This can happen at any time. Even putting the PC back into sleep mode isn't sufficient to stop it from waking the PC again in some cases. Windows ignores all settings regarding whether to wake the system or not, and actively prevents users from changing some of these settings.

#### The bigger problem

Microsoft: Your UX on this is stressful, and even dangerous.

Stressful: Being woken up at 1:30am because my PC has decided to wake itself up, knowing that I have to be up for work at 6am. I already have a troublesome sleep pattern, so you're making the situation worse.

Dangerous: Finding a laptop inside a bag has woken itself from sleep and is now overheating, potentially starting a fire.

#### The solution
An open source project that runs on any Windows PC with .net 3.5 or later, and attempts to stop the Windows update service. Note that this has only been tested on Windows 10 1903, should work on Windows 8 and 8.1, and probably won't work on Windows 7.

Further changes may be needed if this isn't sufficient to stop this problem.

This is a heavy-handed approach, but while Microsoft refuse to accept and fix the problem, I will take matters into my own hands.

#### Usage
This program runs as a desktop app and can be minimized to the notification area. If you want to start the Windows update orchestrator service, there's a button for that. If you want to stop it, there's a button for that.

You can also `Monitor Service` which will continually monitor the service and stop it from running. You should check this check box and then click the Stop button if you wish to use this functionality.

You can also `Watch for Suspend` which will attempt to stop the service as Windows is going into suspend mode.

##

#### DISCLAIMER

The use of the software on this website is done at your own discretion and risk and with agreement that you will be solely responsible for any damage to your computer system or loss of data that results from such activities. You are solely responsible for adequate protection and backup of the data and equipment used in connection with any of the software linked to this website, and we will not be liable for any damages that you may suffer connection with downloading, installing, using, modifying or distributing such software. No advice or information, whether oral or written, obtained by you from us or from this website shall create any warranty for the software.

Additionally, we make no warranty that:

 - The software will meet your requirements.
 - The software will be uninterrupted, timely, secure or error-free.
 - The results from the use of the software will be effective, accurate or reliable.
 - The quality of the software will meet your expectations.
 
 
The links to software and the related documentation made available on this website are subject to the following conditions:

 - The software could include technical or other mistakes, inaccuracies or typographical errors.
 - The software may be out of date, and we make no commitment to update such materials.
 - We assume no responsibility for errors or omissions in the software or documentation available from this website.
In no event shall we be liable to you or any third parties for any special, punitive, incidental, indirect or consequential damages of any kind, or any damages whatsoever, including, without limitation, those resulting from loss of use, lost data or profits, or any liability, arising out of or in connection with the use of this software.

##

[![forthebadge](https://forthebadge.com/images/badges/built-with-resentment.svg)](https://forthebadge.com)
