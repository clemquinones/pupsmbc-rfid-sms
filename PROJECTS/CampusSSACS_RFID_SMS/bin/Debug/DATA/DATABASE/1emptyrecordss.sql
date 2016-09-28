-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Aug 13, 2011 at 08:44 PM
-- Server version: 5.1.41
-- PHP Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db_campus`
--
CREATE DATABASE `db_campus` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `db_campus`;

-- --------------------------------------------------------

--
-- Table structure for table `tbleannouncement`
--

CREATE TABLE IF NOT EXISTS `tbleannouncement` (
  `ID` varchar(100) NOT NULL,
  `Message` varchar(2000) NOT NULL,
  `StartDateTime` datetime NOT NULL,
  `EndDateTime` datetime NOT NULL,
  `PrimaryA` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbleannouncement`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbleannouncement2`
--

CREATE TABLE IF NOT EXISTS `tbleannouncement2` (
  `ID` varchar(100) NOT NULL,
  `Message` varchar(2000) NOT NULL,
  `StartDateTime` datetime NOT NULL,
  `EndDateTime` datetime NOT NULL,
  `PrimaryA` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbleannouncement2`
--


-- --------------------------------------------------------

--
-- Table structure for table `tblechat`
--

CREATE TABLE IF NOT EXISTS `tblechat` (
  `UserFrom` varchar(100) NOT NULL,
  `UserTo` varchar(100) NOT NULL,
  `Message` longtext NOT NULL,
  `DateTime` datetime NOT NULL,
  `UnRead` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblechat`
--


-- --------------------------------------------------------

--
-- Table structure for table `tblechat2`
--

CREATE TABLE IF NOT EXISTS `tblechat2` (
  `UserFrom` varchar(100) NOT NULL,
  `UserTo` varchar(100) NOT NULL,
  `Message` longtext NOT NULL,
  `DateTime` datetime NOT NULL,
  `UnRead` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblechat2`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbleclient`
--

CREATE TABLE IF NOT EXISTS `tbleclient` (
  `Machine` varchar(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `UserID` varchar(100) NOT NULL,
  `Online` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbleclient`
--

INSERT INTO `tbleclient` (`Machine`, `Name`, `UserID`, `Online`) VALUES
('LOG IN', 'INFOTECHNETWORK', 'CAMPUSU-00001', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblecodedesc`
--

CREATE TABLE IF NOT EXISTS `tblecodedesc` (
  `Field` varchar(100) NOT NULL,
  `Code` varchar(100) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `Year` int(11) NOT NULL,
  `Section` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblecodedesc`
--


-- --------------------------------------------------------

--
-- Table structure for table `tblefacultyutility`
--

CREATE TABLE IF NOT EXISTS `tblefacultyutility` (
  `Field` varchar(100) NOT NULL,
  `ID` varchar(100) NOT NULL,
  `FName` varchar(100) NOT NULL,
  `MName` varchar(100) NOT NULL,
  `LName` varchar(100) NOT NULL,
  `Number` varchar(100) NOT NULL,
  `Block` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblefacultyutility`
--

INSERT INTO `tblefacultyutility` (`Field`, `ID`, `FName`, `MName`, `LName`, `Number`, `Block`) VALUES
('Faculty', 'assd-999', 'adsa', 'jsdf', 'sfds', '222', 0),
('Faculty', 'PUPFU-00000', 'clem', 'das', 'as', 'as', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblegsm`
--

CREATE TABLE IF NOT EXISTS `tblegsm` (
  `PORT` varchar(100) NOT NULL,
  `BAUDRATE` int(11) NOT NULL,
  `TIMEOUT` int(11) NOT NULL,
  `VALIDITY` int(11) NOT NULL,
  `SENDDELAY` int(11) NOT NULL,
  `STOPBITS` int(11) NOT NULL,
  `LOGS` tinyint(1) NOT NULL,
  `ANNOUNCE` tinyint(1) NOT NULL,
  `ANONYM` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblegsm`
--

INSERT INTO `tblegsm` (`PORT`, `BAUDRATE`, `TIMEOUT`, `VALIDITY`, `SENDDELAY`, `STOPBITS`, `LOGS`, `ANNOUNCE`, `ANONYM`) VALUES
('COM5', 9600, 300, 255, 1000, 3, 1, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbleid`
--

CREATE TABLE IF NOT EXISTS `tbleid` (
  `Field` varchar(100) NOT NULL,
  `Format` longtext NOT NULL,
  `Value` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbleid`
--

INSERT INTO `tbleid` (`Field`, `Format`, `Value`) VALUES
('User', 'CAMPUSU', 0),
('Logs', 'CAMPUSL', 0),
('System', 'CD3RKingsRoxPat', 1),
('Annoucement', 'Polytechnic University of the Philippines Sta. Maria Bulacan Campus Student Monitoring System Using Radio Frequency Identification With SMS Technology', 0),
('Passcode', 'PUP', 0),
('LoginMessage', 'Your child is inside the campus @exactly the time of', 0),
('AdvisoryMessage', 'This message is part of Student Monitoring System of PUPSMBC. To deactivate receiving of student attendance advisory, just reply ALERT OFF.', 0),
('UnlogoutMessage', 'The student security monitoring system of PUPSMBC will now end. Your child is still inside the campus. Last login detection is at the time of', 0),
('LogOutMessage', 'Your child last log out detection from the campus is exactly @time of', 0),
('SystemShutdown', '20:00:00', 0),
('SendSMS', '', 0),
('BlockConfirmMessage', 'You have successfully deactivate the PUPSMBC advisory. To reactivate the advisory, just  reply ALERT ON.', 0),
('Client', 'State', 0),
('SMSSending', '', 0),
('MonitoringLogs', 'CAMPUSM', 0),
('StartClient', '1=Show Log in; 2=Log as Admin', 0),
('DetectGSM', 'Auto-detect GSM Device at start up of admin', 0),
('IDFormat', '', 0),
('Message', 'auto-increment value for Message ID', 0),
('ShutdownDisconnect', 'Shutdown client when user disconnected', 0),
('AnnouncementID', 'CAMPUSA', 0),
('GuideBlockMessage', 'Invalid format. To deactivate student log advisory reply ALERT OFF, to activate again just reply ALERT ON.', 0),
('ClientGaurd', 'State system client at gaurd', 0),
('ActivateConfirmMessage', 'You have successfully re-activate the PUPSMBC advisory. To deactivate the advisory, just reply ALERT OFF.', 0),
('GuideInvalidCommand', 'Invalid command. To use sms command, just text SMSCOMMAND<space>(KEYWORDCOMMAND<space>(PASSWORD).', 0),
('ExecuteConfirmMessage', 'The system is waiting for the processing of your command.', 0),
('FacultyUtility', 'PUPFU', 0),
('Sounds', '', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblemonitoring`
--

CREATE TABLE IF NOT EXISTS `tblemonitoring` (
  `ID` int(11) NOT NULL,
  `LogUserID` varchar(100) NOT NULL,
  `LogUserType` varchar(100) NOT NULL,
  `Action` varchar(100) NOT NULL,
  `DateTime` datetime NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblemonitoring`
--


-- --------------------------------------------------------

--
-- Table structure for table `tblemonitoring2`
--

CREATE TABLE IF NOT EXISTS `tblemonitoring2` (
  `ID` int(11) NOT NULL,
  `LogUserID` varchar(100) NOT NULL,
  `LogUserType` varchar(100) NOT NULL,
  `Action` varchar(100) NOT NULL,
  `DateTime` datetime NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblemonitoring2`
--


-- --------------------------------------------------------

--
-- Table structure for table `tblemonitoringlogs`
--

CREATE TABLE IF NOT EXISTS `tblemonitoringlogs` (
  `ID` varchar(100) NOT NULL,
  `RFIDTAGID` varchar(100) NOT NULL,
  `LogState` varchar(100) NOT NULL,
  `DateTime` datetime NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblemonitoringlogs`
--


-- --------------------------------------------------------

--
-- Table structure for table `tblemonitoringlogs2`
--

CREATE TABLE IF NOT EXISTS `tblemonitoringlogs2` (
  `ID` varchar(100) NOT NULL,
  `RFIDTAGID` varchar(100) NOT NULL,
  `LogState` varchar(100) NOT NULL,
  `DateTime` datetime NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblemonitoringlogs2`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbleparentinfo`
--

CREATE TABLE IF NOT EXISTS `tbleparentinfo` (
  `RFIDTAGID` varchar(100) NOT NULL,
  `FName` varchar(100) NOT NULL,
  `LName` varchar(100) NOT NULL,
  `Number` varchar(100) NOT NULL,
  `Relation` varchar(100) NOT NULL,
  `Block` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbleparentinfo`
--


-- --------------------------------------------------------

--
-- Table structure for table `tblesms`
--

CREATE TABLE IF NOT EXISTS `tblesms` (
  `ID` bigint(20) NOT NULL,
  `SMSType` varchar(100) NOT NULL,
  `UserNum` text NOT NULL,
  `RecID` varchar(100) NOT NULL,
  `RecType` varchar(100) NOT NULL,
  `Message` longtext NOT NULL,
  `DateTime` datetime NOT NULL,
  `ExpiryDateTime` datetime NOT NULL,
  `SendCopy` int(11) NOT NULL,
  `Alert` tinyint(1) NOT NULL,
  `UniCode` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblesms`
--


-- --------------------------------------------------------

--
-- Table structure for table `tblesms2`
--

CREATE TABLE IF NOT EXISTS `tblesms2` (
  `ID` bigint(20) NOT NULL,
  `SMSType` varchar(100) NOT NULL,
  `UserNum` text NOT NULL,
  `RecID` varchar(100) NOT NULL,
  `RecType` varchar(100) NOT NULL,
  `Message` longtext NOT NULL,
  `DateTime` datetime NOT NULL,
  `ExpiryDateTime` datetime NOT NULL,
  `SendCopy` int(11) NOT NULL,
  `Alert` tinyint(1) NOT NULL,
  `UniCode` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblesms2`
--


-- --------------------------------------------------------

--
-- Table structure for table `tblesmscommand`
--

CREATE TABLE IF NOT EXISTS `tblesmscommand` (
  `Keyword` varchar(100) NOT NULL,
  `Description` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblesmscommand`
--

INSERT INTO `tblesmscommand` (`Keyword`, `Description`) VALUES
('SHUTDOWNS', 'Shutdown Server System'),
('SHUTDOWNC', 'Shutdown Client System'),
('SENDSTARTALL', 'Send all read messages'),
('SENDSTARTLOGS', 'Send logs messages'),
('SENDSTARTANNOUNCEMENT', 'Send announcement messages'),
('SENDSTARTANONYMOUS', 'Send anonymous messages'),
('SENDSTOPLOGS', 'Stop sending of logs messages'),
('SENDSTOPANNOUNCEMENT', 'Stop sending of announcement'),
('SENDSTOPANONYMOUS', 'Stop sending of anonymous messages'),
('SENDSTOPALL', 'Stop sending of messages.'),
('SENDTURNOFF', 'Turn off SMS Sender'),
('SENDTURNON', 'Turn on SMS Sender');

-- --------------------------------------------------------

--
-- Table structure for table `tblestudent`
--

CREATE TABLE IF NOT EXISTS `tblestudent` (
  `StudNo` varchar(100) NOT NULL,
  `RFIDTAGID` varchar(100) NOT NULL,
  `PassCode` varchar(100) NOT NULL,
  `FName` varchar(100) NOT NULL,
  `MName` varchar(100) NOT NULL,
  `LName` varchar(100) NOT NULL,
  `Address` varchar(1000) NOT NULL,
  `Course` varchar(100) NOT NULL,
  `YearLevel` int(11) NOT NULL,
  `Section` int(11) NOT NULL,
  `Status` varchar(100) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `Number` varchar(100) NOT NULL,
  `Picture` longblob NOT NULL,
  `UnLogOut` tinyint(1) NOT NULL,
  `Block` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblestudent`
--


-- --------------------------------------------------------

--
-- Table structure for table `tblestudent2`
--

CREATE TABLE IF NOT EXISTS `tblestudent2` (
  `StudNo` varchar(100) NOT NULL,
  `RFIDTAGID` varchar(100) NOT NULL,
  `PassCode` varchar(100) NOT NULL,
  `FName` varchar(100) NOT NULL,
  `MName` varchar(100) NOT NULL,
  `LName` varchar(100) NOT NULL,
  `Address` varchar(1000) NOT NULL,
  `Course` varchar(100) NOT NULL,
  `YearLevel` int(11) NOT NULL,
  `Section` int(11) NOT NULL,
  `Status` varchar(100) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `Number` varchar(100) NOT NULL,
  `Picture` longblob NOT NULL,
  `Block` tinyint(1) NOT NULL,
  `Remark` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblestudent2`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbletempdetection`
--

CREATE TABLE IF NOT EXISTS `tbletempdetection` (
  `ID` varchar(100) NOT NULL,
  `Field` varchar(100) NOT NULL,
  `RFIDTAGID` varchar(100) NOT NULL,
  `DateTime` datetime NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbletempdetection`
--


-- --------------------------------------------------------

--
-- Table structure for table `tbleusers`
--

CREATE TABLE IF NOT EXISTS `tbleusers` (
  `UserID` varchar(100) NOT NULL,
  `UserName` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `FName` varchar(100) NOT NULL,
  `LName` varchar(100) NOT NULL,
  `Number` varchar(100) NOT NULL,
  `UserType` varchar(100) NOT NULL,
  `Locked` tinyint(1) NOT NULL,
  `Online` tinyint(1) NOT NULL,
  `SearchStud` tinyint(1) NOT NULL,
  `ViewStudInfo` tinyint(1) NOT NULL,
  `ShutdownClient` tinyint(1) NOT NULL,
  `OperateVer` tinyint(1) NOT NULL,
  `ViewStudentList` tinyint(1) NOT NULL,
  `SearchStudentList` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbleusers`
--


/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
