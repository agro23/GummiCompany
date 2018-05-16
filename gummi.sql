-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: May 16, 2018 at 05:57 AM
-- Server version: 5.6.38
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gummi`
--
CREATE DATABASE IF NOT EXISTS `gummi` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `gummi`;

-- --------------------------------------------------------

--
-- Table structure for table `Experiences`
--

CREATE TABLE `Experiences` (
  `ExperienceId` int(11) NOT NULL,
  `Content` longtext,
  `LocationId` int(11) NOT NULL,
  `Title` longtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `Locations`
--

CREATE TABLE `Locations` (
  `LocationId` int(11) NOT NULL,
  `Details` longtext,
  `Place` longtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `Products`
--

CREATE TABLE `Products` (
  `ProductId` int(11) NOT NULL,
  `Cost` int(11) NOT NULL,
  `Description` longtext,
  `Name` longtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Products`
--

INSERT INTO `Products` (`ProductId`, `Cost`, `Description`, `Name`) VALUES
(1, 0, 'Exactly what it says it is. Truly.', 'Screaming Monkey'),
(2, 5, 'a tube of our liquid gummi product', 'Tube of goo'),
(4, 23, 'Some other thing', 'Fourth Thing'),
(5, 0, 'This is working still at least', 'Gummy Terror Count'),
(6, 7, 'erterter', 'rtert');

-- --------------------------------------------------------

--
-- Table structure for table `Reviews`
--

CREATE TABLE `Reviews` (
  `ReviewId` int(11) NOT NULL,
  `Author` longtext,
  `Content` longtext,
  `ProductId` int(11) NOT NULL,
  `Rating` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Reviews`
--

INSERT INTO `Reviews` (`ReviewId`, `Author`, `Content`, `ProductId`, `Rating`) VALUES
(1, 'Andrew', 'Catch a monkey made of gummy!', 1, 5),
(2, 'TEst', 'testtsttststststs', 1, 1),
(3, 'Bazooka Joe', 'Bazooka Bazooka', 1, 1),
(4, 'test', 'test', 1, 3),
(5, 'hi there', 'test x 10000000', 1, 5),
(6, 'Fred', 'I like goo. It\'s goo\'d.', 2, 5),
(7, 'Human Being', 'I am a person and I use Gummi product.', 2, 4),
(8, 'Hello', 'I am human too.', 2, 4),
(12, 'test test', 'fpvjsdpojvpodsjvpojxcvpojxcpov', 1, 4),
(13, 'Breakpoint', 'this is a test with breaks', 2, 3),
(15, 'reererererr', 'erererererere', 2, 1),
(16, 'test test', 'Let\'s add to this!', 4, 5),
(17, 'Hey test', 'teas;kfhvlk;hvlkxzcklhvkl;zhcvhxc', 4, 5),
(18, 'Andy', 'This is a fun name for a candy.', 1, 444444),
(19, 'One Two', 'This is a review', 4, 4),
(20, 'Agamemnon', 'Not so good.', 4, 1),
(21, 'fsdfsd', 'sdfsdfsdfsd', 4, 1),
(22, 'Whisper', '.hxzcklvx;lczvkl;xczhvlkxzcjvklxzcjvkljcxklvjlkcxzhvlkhcxzvklhcxzvlkhxzclvkhzxclkvhlzkxchvlkzxcvhlkzhcxvlkhzxclkvhzxlckhvlkzxchvklxzchvlkzxchvklxzchvlkxzchvlkxchzvklhxzcvlkcxhzvlkxzhcvklxczhklhxczklvhxczklhxzcklvhlxkzchvklxczhvlkxczhvklxczhvlkxzchlkcxzhkl', 4, 2),
(23, 'dssdfdsf', 'dsfsdfsd', 6, 1),
(24, 'etst', 'tsetsets', 5, 3);

-- --------------------------------------------------------

--
-- Table structure for table `__EFMigrationsHistory`
--

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `__EFMigrationsHistory`
--

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`) VALUES
('20180515181137_TryToFixReview', '1.1.2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Experiences`
--
ALTER TABLE `Experiences`
  ADD PRIMARY KEY (`ExperienceId`),
  ADD KEY `IX_Experiences_LocationId` (`LocationId`);

--
-- Indexes for table `Locations`
--
ALTER TABLE `Locations`
  ADD PRIMARY KEY (`LocationId`);

--
-- Indexes for table `Products`
--
ALTER TABLE `Products`
  ADD PRIMARY KEY (`ProductId`);

--
-- Indexes for table `Reviews`
--
ALTER TABLE `Reviews`
  ADD PRIMARY KEY (`ReviewId`),
  ADD KEY `IX_Reviews_ProductId` (`ProductId`);

--
-- Indexes for table `__EFMigrationsHistory`
--
ALTER TABLE `__EFMigrationsHistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Experiences`
--
ALTER TABLE `Experiences`
  MODIFY `ExperienceId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `Locations`
--
ALTER TABLE `Locations`
  MODIFY `LocationId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `Products`
--
ALTER TABLE `Products`
  MODIFY `ProductId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `Reviews`
--
ALTER TABLE `Reviews`
  MODIFY `ReviewId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Experiences`
--
ALTER TABLE `Experiences`
  ADD CONSTRAINT `FK_Experiences_Locations_LocationId` FOREIGN KEY (`LocationId`) REFERENCES `Locations` (`LocationId`) ON DELETE CASCADE;

--
-- Constraints for table `Reviews`
--
ALTER TABLE `Reviews`
  ADD CONSTRAINT `FK_Reviews_Products_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `Products` (`ProductId`) ON DELETE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
