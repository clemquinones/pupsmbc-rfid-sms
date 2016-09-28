@echo off & color 0a
set ACTION=BACKUP
set DESTINATIONDIR=C:\Documents and Settings\Tjae Clemen\My Documents\_BACK_UP_
set DESTINATIONFILENAME=db_campus_BACKUP.SQL
set SOURCE=

title PUPSMBC Student Security Monitoring System - %ACTION% DATABASE
echo _______________________________________________________________________________
echo :
echo : PUP-SMBC STUDENT SECURITY MONITORING SYSTEM USING RFID WITH SMS TECHNOLOGY
echo _______________________________________________________________________________
echo *===============*=*==================*=======*============*===*===============*
echo ::  CCCCC   DDDDD      33333   RRRRR    KK  KK  III  NN  NN   GGGGG   SSSSS  ::
echo :: CC   CC  DD   DD __     33  RR  RR   KK KK   III  NNN NN  GG      SS      ::
echo :: CC       DD   DD ==   333   RRRRR    KKKK    III  NN NNN  GG  GGG  SSSSS  ::
echo :: CC   CC  D    DD        33  RR  RR   KK  KK  III  NN  NN  GG   GG      SS ::
echo ::  CCCCC   DDDDD      33333   RR  RR   KK  KK  III  NN  NN   GGGGG   SSSSS  ::
echo =========*========*===============*===============*==*================*========
echo ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\\  :::\\  ::
echo :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\\  :::\\  :
echo ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\\  :::\\
echo :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::://  ::://
echo ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::://  ::://  :
echo _______________________________________________________________________________
pause

if "%ACTION%"=="BACKUP" ( goto BACKUP_REGION)
if "%ACTION%"=="RESTORE" ( goto RESTORE_REGION)

exit
@rem BACK UP SESSION
:BACKUP_REGION
set MYSQLDUMP_PATH="%systemdrive%\xampp\mysql\bin\mysqldump.exe"
if not exist "%MYSQLDUMP_PATH%" ( msg * /w /time:15 Cannot continue back-up session. File missing '%MYSQLDUMP_PATH%.' & exit)
if /i "%ACTION%"=="BACKUP" ( msg * /w /time:10 Click 'OK' button to start back up of system database.
echo :IIII}} If no password, just press enter.
"%MYSQLDUMP_PATH%" -hlocalhost -uroot -p db_campus > "%DESTINATIONDIR%\%DESTINATIONFILENAME%"
msg * /w /time:10 Back up complete. Your back-up file: '%DESTINATIONDIR%\%DESTINATIONFILENAME%'
explorer "%DESTINATIONDIR%"
exit)

exit
@rem RESTORE SESSION
:RESTORE_REGION
set MYSQL_PATH="%systemdrive%\xampp\mysql\bin\mysql.exe"
if not exist "%MYSQLDUMP_PATH%" ( msg * /w /time:15 Cannot continue back-up session. File missing '%MYSQL_PATH%.' & exit)
if /i "%ACTION%"=="RESTORE" ( msg * /w /time:10 Click 'OK' button to start restoring of system database.
	if exist "%systemdrive%\xampp\mysql\data\db_campus" ( rd "%systemdrive%\xampp\mysql\data\db_campus" /s)
	if not exist "%systemdrive%\xampp\mysql\data\db_campus" ( md "%systemdrive%\xampp\mysql\data\db_campus"
		echo :IIII}} If no password, just press enter.
		"%MYSQL_PATH%" -hlocalhost -uroot -p db_campus < "%SOURCE%"
		msg * /w /time:10 Restore complete.
	rem	start "D:\PUPSSACSRFIDSMS\CampusSSACS_RFID_SMS\bin\Debug\CampusSSACS_RFID_SMS.exe"
		exit
	) else ( msg * /w /time:10 Cannot continue! The old database is existing! To restore database from backup, you must drop first the old database.
	exit)
)
exit
