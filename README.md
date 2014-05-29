# Shipment Geek
Latest **release, with binary files**, can be found [here](https://github.com/HebronNor/ShipmentGeek/releases).

## What is Shipment Geek?
Shipment geek is a super light database manager for keeping track of incoming and outgoing shipments. Date, comment, items and whether the shipment has been received or lost can be stored, giving a nice overview of all shipments in transit.

## Screenshots
<img src="https://0vpggq.bn1304.livefilestore.com/y2p0DdF_9Mj0-aWPiL6ypMTaXUR9PBH-iebGHy2UjR6Orad3dX_onGCEP9IfkMzL2R2WIFK9A2tj-LaIadMMXOuia_Sj4uj6Y6VFC4LDkKkDdI/ShipmentGeek_Screen3.png?psid=1" width="400">

## Installation
No installation is required; simply unpack the release binary files (`ShipmentGeek_vX.X.X.zip`) to a folder of your choosing.

### Requirements
* Windows 7
* .NET Framework 4.5

## Upgrade
To upgrade your version of ShipmentGeek; unpack the release binary files (`ShipmentGeek_vX.X.X.zip`) to the folder containing your current version. Some files will be overwritten, but your library will not be affected.
Make sure ShipmentGeek is not running during the upgrade.

## Shipment library
Your shipment library is by default stored in `ShipmentGeek.xml`, but you can open and save the shipment file to any location. The shipment file is not affected when upgrading to a new version.

### Shipment backups
Every time you start ShipmentGeek a backup of your library is stored in the sub-folder `Backup/`, and named with the current date and time.

#### Restore backup
To restore a backup simply click the _Open shipment file_ button under the _File_ dropdown menu (or `CTRL+O`) and navigate to the backup file you wish to restore. Select it and press _Open_.
Then click _Save shipment file as..._ (or `CTRL+S`) and choose a location and name for the restored backup.

## Issues
The application is still work in progress so there may be bugs. Please report all bugs to the issue tracker on this repository ([here](https://github.com/HebronNor/ShipmentGeek/issues)).