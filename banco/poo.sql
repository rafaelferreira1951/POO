-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 08, 2020 at 03:46 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `poo`
--

-- --------------------------------------------------------

--
-- Table structure for table `cliente`
--

CREATE TABLE `cliente` (
  `usuario` varchar(40) NOT NULL,
  `endereco` varchar(45) NOT NULL,
  `email` varchar(60) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `celular` int(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cliente`
--

INSERT INTO `cliente` (`usuario`, `endereco`, `email`, `senha`, `celular`) VALUES
('asdf', 'asdf', 'asdf', 'asdf', 0);

-- --------------------------------------------------------

--
-- Table structure for table `corrida`
--

CREATE TABLE `corrida` (
  `id` int(11) NOT NULL,
  `motoboy` varchar(500) NOT NULL,
  `cliente` varchar(500) NOT NULL,
  `destino` varchar(500) NOT NULL,
  `localizacao` varchar(500) NOT NULL,
  `pagamento` varchar(500) NOT NULL,
  `valor` varchar(500) NOT NULL,
  `status` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `motoboy`
--

CREATE TABLE `motoboy` (
  `nome` varchar(40) CHARACTER SET utf8 COLLATE utf8_croatian_ci NOT NULL,
  `usuario` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `senha` varchar(45) NOT NULL,
  `rg` int(15) NOT NULL,
  `cnh` varchar(45) NOT NULL,
  `email` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `telefone` int(15) NOT NULL,
  `celular` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `motoboy`
--

INSERT INTO `motoboy` (`nome`, `usuario`, `senha`, `rg`, `cnh`, `email`, `telefone`, `celular`) VALUES
('zxcv', 'zxcv', 'zxcv', 0, 'zxcv', 'zxcv', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `pagamento`
--

CREATE TABLE `pagamento` (
  `idpagamento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `pessoa`
--

CREATE TABLE `pessoa` (
  `nome` varchar(45) NOT NULL,
  `sexo` varchar(45) NOT NULL,
  `numcelular` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `foto` varchar(45) NOT NULL,
  `idpessoa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `idusuario` int(11) NOT NULL,
  `nomeusuario` varchar(60) NOT NULL,
  `senha` varchar(60) NOT NULL,
  `Type` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `corrida`
--
ALTER TABLE `corrida`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pagamento`
--
ALTER TABLE `pagamento`
  ADD PRIMARY KEY (`idpagamento`);

--
-- Indexes for table `pessoa`
--
ALTER TABLE `pessoa`
  ADD PRIMARY KEY (`idpessoa`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`idusuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `corrida`
--
ALTER TABLE `corrida`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
