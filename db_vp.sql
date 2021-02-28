-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 28, 2021 at 04:45 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_vp`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_rockmerch`
--

CREATE TABLE `tb_rockmerch` (
  `ID` int(11) NOT NULL,
  `Items` varchar(80) NOT NULL,
  `Size` varchar(4) NOT NULL,
  `Sleeve` varchar(10) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Total_Price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_rockmerch`
--

INSERT INTO `tb_rockmerch` (`ID`, `Items`, `Size`, `Sleeve`, `Quantity`, `Total_Price`) VALUES
(1, 'The Clash Logo T-Shirt', 'L', 'Short', 2, 220000),
(20, 'GNR Logo T-Shirt', 'S', 'Short', 2, 220000),
(23, 'Metallica Logo T-Shirt', 'M', 'Long', 3, 330000),
(25, 'Nirvana Smiley T-Shirt', 'L', 'Long', 2, 220000),
(26, 'LOG Logo T-Shirt', 'M', 'Long', 3, 330000),
(27, 'Metallica Logo T-Shirt', 'S', 'Short', 2, 220000),
(29, 'LOG Logo T-Shirt', 'M', 'Short', 2, 220000),
(30, 'ACDC Logo T-Shirt', 'M', 'Long', 1, 110000),
(36, 'Metallica Logo T-Shirt', 'L', 'Short', 2, 220000),
(37, 'GNR Logo T-Shirt', 'M', 'Long', 1, 110000),
(38, 'ACDC Logo T-Shirt', 'S', 'Short', 1, 110000),
(40, 'GNR Logo T-Shirt', 'L', 'Long', 2, 220000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_rockmerch`
--
ALTER TABLE `tb_rockmerch`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_rockmerch`
--
ALTER TABLE `tb_rockmerch`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
