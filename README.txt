==============================================
About OpenAttend
==============================================
Created in VB.NET with Visual Studio 2010. All project files and documentation created by original developer Daven Bigelow (2010 - 2011) are hereby released into the Public Domain as of July 7th 2018 after the project was upgraded to Visual Studio 2017.

OpenAttend was originally developed as an A-Level final Computing project in 8 months (from design to implementation and documentation) for a church sunday school that had over 80 children split amongs various age groups. Their old photo and text badge based system was becoming difficult to maintain as attendance grew, and also had no protection against fraudulent or expired badges, and parents often lost their own "family" badge or their children's badges each week which needed replacement.

OpenAttend uses a MYSQL database to provide image and barcode secured family/child registration for daycare groups.

Credit also to iCam class creator Pino (source: http://www.vbforums.com/showthread.php?344471-Vb-Net-WebCam-Class-(ICam) )

==============================================
OpenAttend has the following features:
==============================================
-Network support via MYSQL database and windows shared network drives (for images)
-Can be self-hosted on a single device
-Offline mode for tracking children in group in case of fire drill or other emergency
-Important and private data stored on the server itself
-Printing barcodes to DYMO label printers automatically
-Webcam support to take photos of whole family and children, so that team members can visually confirm if the caretakers and child images match before releasing the children
-Child event codes only valid for each event, preventing re-use of child badges
-Adult/family tags also expire, requiring profiles to be updated after a few years

==============================================
To build/run on a Windows device:
==============================================
-Make sure all external libraries are installed (see EXTERNAL_REQUIRED_FILES.txt)
-Setup the database connection and use the example database file provided with Microsoft Access to upload to the MYSQL server (BlankDatabase.mdb), or use the pre-setup one for simple youth group (2 - 15) + youth leaders (16+) example (ExampleDatabase.accdb)
-Setup a network drive where images will be stored, if using the example database update it with this location (eg: SERVERNAME\SharedDocs\OpenAttend\PPhotos\ for people photos, and FPhotos for family photos). Setup a hosts file on the client computer to store what your chosen SERVERNAME points to
-Make sure the MYSQL connection string is correct in the Settings.settings file

==============================================
Known issues:
==============================================
-Requires a DYMO label printer to print barcodes, will not run without DYMO runtimes
-Youth groups are hard-coded in PrintYouthBadges.vb, due to project time constraints. So you will also want to edit this
-Crystal reports is not so common since VS2010 so you'll need .NET 3.5 and the latest runtimes/VS integration from
http://www.crystalreports.com/crvs/confirm/ to open the project in VS 2017 on Windows 10
-Might also require Visual Basic Power Pack from
https://www.microsoft.com/en-ca/download/details.aspx?id=25169
-The code is rough, often due to the tight time constraints at a busy time in finishing highschool in the UK. However, there are some extra hacky-bits inside as well