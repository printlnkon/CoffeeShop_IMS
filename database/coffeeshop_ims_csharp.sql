-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 01, 2024 at 10:10 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `coffeeshop_ims_csharp`
--

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `userName` varchar(255) NOT NULL,
  `contactNo` varchar(11) NOT NULL,
  `password` varchar(255) NOT NULL,
  `userType` varchar(255) NOT NULL DEFAULT 'User'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `firstName`, `lastName`, `userName`, `contactNo`, `password`, `userType`) VALUES
(1, 'baba', 'nana', 'awtsdawgs', 'babababa', '2b309e83b093e4fb6d107b0d25e45de1', 'User'),
(2, 'dadada', 'nanana', 'dana', '11111111111', '2b309e83b093e4fb6d107b0d25e45de1', 'User'),
(3, 'Kalfontein', 'Cruz', 'koncruz', '09393781921', '2b309e83b093e4fb6d107b0d25e45de1', 'Admin'),
(4, 'newKalf', 'newCruz', 'konmanager', '09393781921', '2b309e83b093e4fb6d107b0d25e45de1', 'User'),
(5, 'Santa', 'Cruz', 'santacruz', '09193891923', '098f6bcd4621d373cade4e832627b4f6', 'Manager'),
(6, 'abakada', 'Cruz', 'abakadacruz', '09193891923', '098f6bcd4621d373cade4e832627b4f6', 'User'),
(7, 'balag', 'bagan', 'balagbaging', '11111111111', '098f6bcd4621d373cade4e832627b4f6', 'Manager'),
(8, 'abababa', 'dawg', 'abadawg', '1111111111', '2b309e83b093e4fb6d107b0d25e45de1', 'Manager'),
(9, 'dwa', 'dwa', 'dwa', '111111111', '098f6bcd4621d373cade4e832627b4f6', 'User');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`userName`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
