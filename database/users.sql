-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 27, 2024 at 06:52 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventorymgcsharp`
--

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `firstName` varchar(100) NOT NULL,
  `lastName` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `phoneNo` varchar(10) NOT NULL,
  `password` varchar(50) NOT NULL,
  `usertype` varchar(20) NOT NULL DEFAULT 'member'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `first`, `last`, `username`, `phone`, `password`, `usertype`) VALUES
(1, 'Roosevelt', 'Mitchell', 'roose', '1450214580', 'ee11cbb19052e40b07aac0ca060c23ee', 'member'),
(2, 'Thom', 'Rodriquez', 'manager', '7854541250', '0795151defba7a4b5dfa89170de46277', 'manager'),
(3, 'Demo', 'Account', 'demoaccount', '7000000020', '5f4dcc3b5aa765d61d8327deb882cf99', 'member'),
(4, 'Christine', 'Moore', 'christine', '8521111101', '5f4dcc3b5aa765d61d8327deb882cf99', 'member'),
(5, 'Liam', 'Moore', 'admin', '1470001011', '482c811da5d5b4bc6d497ffa98491e38', 'admin'),
(6, 'Estela', 'Choate', 'estela', '1254785555', '5f4dcc3b5aa765d61d8327deb882cf99', 'member'),
(7, 'Robert', 'Grote', 'robert', '8520002014', '5f4dcc3b5aa765d61d8327deb882cf99', 'member'),
(8, 'Jimmy', 'Lucas', 'jimmy', '1478569800', '1a1dc91c907325c69271ddf0c944bc72', 'member'),
(9, 'Catherine', 'Lawrence', 'cath', '8522222220', '1a1dc91c907325c69271ddf0c944bc72', 'member'),
(10, 'Joseph', 'Warren', 'warren', '6545214500', '202cb962ac59075b964b07152d234b70', 'member'),
(11, 'Marian', 'Sacco', 'sacco', '1478545874', 'c6f057b86584942e415435ffb1fa93d4', 'member');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
