# SoundSwap

## Index

- [Installation](#installation)
- [About SoundSwap](#what-is-soundswap)
- [SoundSwap Features](#features)
- [Usage](#usage)

### Installation
Download SoundSwap (windows) [here](https://www.dropbox.com/scl/fi/wzfl37m6c9aq87pz5yl65/SoundSwapSetup.msi?rlkey=lhebk7xjt9cat4sy15hiebkmg&dl=1)

### What is SoundSwap?
<picture>
  <img alt="Screenshot of SoundSwapUI" src="https://github.com/duserc/SoundSwap/blob/main/images/SoundSwap.png">
</picture>
SoundSwap was programmed in `C# .net 6.0` using visual studio codes' winforms.

SoundSwap is a light-weight Audio Device switcher, that operates via programmable hotkeys. SoundSwap is designed to fill a void that I have personally felt the Windows Operating system has been lacking for many years: A fast, easy way to change the default audiodevice output, without the need to navigate through the ever changing, windows GUI.

In the spirit of keeping the application fast and easy to run, the design philosohpy for the application has been centered around ensuring the GUI is as easy to understand and operate as possible, for both the first time use and returning users.

Due to the nature of being a program that is "always on" and "always listening" to the assigned hotkeys, all features were added with a strong regard for memory and cpu usage.

### Features

- Displays fully dynamic list of audio output devices connected to the pc, in the format of "DataGridView". This consists of three visible columns: Audio Device, Enabled, Hotkey.
    - on program startup, checks for any previous saved settings from /config/settings.json
        - if there is no saved settings for any specific device, generate defualt settings and append to a list of object: sound devices, that will later be used to save settings.json and also queried into, saving memory on unessesary readings of the json file
- Intuitive "Enabled" tickbox column of "DataGridView" to toggle hotkeys on/off
    - Disabling a device's hotkey also removes the hotkey listener for that specific device, saving memory and cpu usage
- Fully Customizable Hotkeys
    - in the "hotkey" column of the "DataGridView", a textbox has been converted to enable recieving of combinational or singular hotkeys. Any hotkeys that interfere with windows operations, such as `ALT+F4` will not work, thanks to the hotkey [API](https://github.com/Willy-Kimura/HotkeyListener/blob/master/README.md)
    - Hotkey inputs are protected from all potential edge cases that could arise when they are attempted to be stored as a hotkey type, ect.
- Save button
    - The save button both updates the list of audio device objects, but also writes the users saved settings into the Settings.Json. This can then be loaded from on the next launch of the application.
- Main Menu Strip
    - The main menu strip provides full control of the application and offers complete accessibility for all users with only the utilization of the keyboard, if nessesary.
    - The main menu strip contains 3 typical sub menus:
        - `File`
            - `New`
                - `Detect new audio device`
                    - This button is programmed using an event listener to detect any changes with audio devices, included the addition, or ejection of any audio devices within the system, then restarting the application with the correct interface.
            - `Check for updates`
                - This button will run the `CheckForUpdates()` function, which will check the [dropbox folder](https://www.dropbox.com/sh/mr7p8317z9iggml/AAANX_o30Hr0hJzMa1sCMh17a?dl=0) that the application is downloaded from, reading the `Update.txt` file. If the file version != the version found in the file, then the user is prompted with an opportunity to update the program. If the user says yes then the program deletes the current exe and downloads the new one from the same dropbox folder.
                The function will then execute the new file, closing the current application.

                This function is also ran on application startup in order to ensure that the user is always using the most recent version.

                If the user does not have an active internet connection, SoundSwap will simply display `Version: Offline` at the bottom right of the program, and continue as normal.
                If the version is up to date it will display: `Version: 1.3.2 - Latest`
                On a similar note if it is not up to date, then it will display: `Version 1.3.2 Outdated`

                I decided to refrain from adding a timer to check for updates, as this would unessecarily impact memory and cpu usage and would add any functionality.
            - `Save`
                - This button provides the same utility as the main save button found on the mainForm
            - `Exit`
                - `To System Tray`
                    - This will hide the main form and fully minimize the application to the system tray.
                        - The Icon residing in the system tray still retains full functionality regarding any hotkey events and hotkey listeners. This is a vital feature of the product, maintaining very minimal impact on the pc.
                        - The system tray Icon contains its own `menu strip`, with its own `Double Click Event`
                            - System  Tray Menu Strip
                                - The menuStrip can be opened by right clicking the systemtrayIcon, containg the SoundSwap icon.
                                    - `Open`
                                        - This button, when clicked, returns the SoundSwap application to the normal window status.
                                    - `Quit`
                                        - This button, when clicked, fully closes the application.
                - `Quit`
                    - Similarly, this button fully closes the application.
        - `Settings`
            - `Launch on system startup?`
                - `yes`
                - `no`
                    - This menu gives the user an, easy to access opportunity to decide if they wish for the program to launch every time the PC is restarted. 
                    - Application name and icons are fully working in this menu.
            - `reset config and program`
                - This button is programmed to delete the config and restart the program. This allows the user, for whatever reason they chose, to completely wipe all previosly saved settings and restart the program as if a fresh install.
        - `Help`
            - `ReadMe`
                - This button will link the user to this ReadMe.md.


- Footer Menu Strip
    - The footer menu strip contains a progress bar, or "loading bar" with a status coinciding next to it, giving the user full feedback of the programs operations. This is executed on all operations, although sometimes its too fast for the human eye, it is clearly seen when, for example, an active hotkey is pressed and the default audio device is switched. This will then pause the status for a few moments, allowing the user to read the full status message.
- When the traditional red `X` at the top right of the screen is pressed, the program will instead minimize to the system tray. Still retaining full utility as mentioned above.
- On program launch, the user is prompted with an admin request popup. If this is accepted, the program will operate as normal. However, if the admin rights are declined, the program will not begin
    - This is a vital feature due to the read/writing of the program, but also to retain all of the features, in as many different situations as possible. 
        - For example, If another application is full screen, or also ran in admin mode, without admin privilidges, the hotkeys would not work. Instead however, most of the time, they work as expected. There are a few edge cases where some applications running in admin and fullscreen will not allow SoundSwap to register any hotkey inputs, however I have not been able to come to a fix for this as of yet.
        - Another feature that would not work without admin rights is ofcourse the "Launch on startup" option found in the settings menu.
- Fully customized GUI
    - Using winforms, the application has underwent full ui changes in an attempt to make the application very appealing and easy to understand. This was an important design goal for me to achieve, as mentioned above, I do intend on using this application in the future.
- Installer
    - SoundSwap also comes with an installer and an uninstaller. This creates the application with the relevant icons and shortcuts about the users pc. The installer will also delete and replace any older versions of the program when updating / installing.

### Usage

### Video Demo:  <URL HERE> WIP