# Shipment Geek
Latest **release, with binary files**, can be found [here](https://github.com/HebronNor/ShipmentGeek/releases).

## What is Shipment Geek?
Shipment geek is a super light database manager for keeping track of incoming and outgoing shipments. Date, comment, items and whether the shipment has been received or lost can be stored, giving a nice overview of all shipments in transit.

## Screenshots
<img src="http://images.tilhol.net/github/shipmentgeek/shipmentgeek_screen4.png" width="450">

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

## Usage

### Shipment list
Received or missing shipments will be default be hidden from the shipment list, they can be shown by activating the _Show all shipments_ option on the _Shipment_ menu (or `CTRL+A`).
Received shipments will then be shown in green and missing shipments in red.

### Find shipment
To search for a shipment click the _Find_ menu option in the _Shipment_ menu (or `CTRL+F`). Enter search phrase and press enter, shipment **name** and **comment** will be searched.
Click _Clear filter_ in the _Shipment_ menu (or `CTRL+Shift+C`) to clear the search results.

### Updating shipment or item
Make sure to press _Save_ after you have updated a shipment or an item, otherwise your changes may be lost.

### Removing shipment or item
Right-click the shipment or item you want to remove to bring up the context menu.

## Issues
The application is still work in progress so there may be bugs. Please report all bugs to the issue tracker on this repository ([here](https://github.com/HebronNor/ShipmentGeek/issues)).
