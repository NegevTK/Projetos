-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 20-Out-2020 às 02:14
-- Versão do servidor: 10.4.14-MariaDB
-- versão do PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `mymachine`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `ID` int(10) NOT NULL,
  `Categoria` varchar(30) NOT NULL,
  `Fabricante` varchar(45) NOT NULL,
  `Nome` varchar(45) NOT NULL,
  `Valor` decimal(20,2) NOT NULL,
  `Quantidade` int(10) NOT NULL,
  `Imagem` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`ID`, `Categoria`, `Fabricante`, `Nome`, `Valor`, `Quantidade`, `Imagem`) VALUES
(1, 'Teclados', 'Razer', 'Tarantula', '339.00', 18, 'TecladoRazerTarantula.png'),
(2, 'Mouses', 'Logitech', 'G5 Refresh', '129.00', 45, 'MouseLogitechG5Refresh.png'),
(3, 'Teclados', 'Logitech', 'Wave', '189.00', 34, 'KitLogitechWave.png'),
(4, 'Mouses', 'Logitech', 'V470', '216.00', 28, 'MouseLogitechV470.png'),
(5, 'Teclados', 'Logitech', 'G15', '116.00', 82, 'TecladoLogitechG15.png'),
(6, 'Teclados', 'Razer', 'Lycosa', '229.00', 9, 'TecladoRazerLycosa.png'),
(7, 'Mouses', 'Logitech', 'G5 Silver Edition', '215.00', 27, 'MouseLogitechG5SilverEdition.png'),
(8, 'Mouses', 'Logitech', 'G5 BF Edition', '250.00', 75, 'MouseLogitechG5BFEdition.png'),
(9, 'Mouses', 'Logitech', 'G7', '287.00', 96, 'MouseLogitechG7.png'),
(10, 'Mouses', 'Logitech', 'G7 Corrdless', '236.00', 87, 'MouseLogitechG7Corrdless.png'),
(11, 'Mouses', 'Logitech', 'MX510', '150.00', 12, 'MouseLogitechMX510.png'),
(12, 'Mouses', 'Logitech', 'MX Revolution', '220.00', 9, 'MouseLogitechMXRevolution.png'),
(13, 'Mouses', 'Microsoft', 'Habu', '268.00', 40, 'MouseMicrosoftHabu.png'),
(14, 'Teclados', 'Microsoft', 'Reclusa Gaming', '126.00', 30, 'TecladoMicrosoftReclusaGaming.png'),
(15, 'Mouses', 'Razer', 'Diamond Back Magma', '367.00', 221, 'MouseRazerDiamondbackMagma.png'),
(16, 'Mouses', 'Razer', 'Diamond Back Plasma', '324.00', 87, 'MouseRazerDiamondbackPlasma.png'),
(17, 'Mouses', 'Razer', 'Pro Gamer Krait', '298.00', 21, 'MouseRazerProGamerKRAIT.png'),
(18, 'Headsets', 'Sennheiser', 'Pro 7.1', '429.00', 110, 'HeadSetSennheiser.png');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `ID` int(20) NOT NULL,
  `CPF` varchar(14) NOT NULL,
  `Nome` varchar(60) NOT NULL,
  `Endereco` varchar(60) NOT NULL,
  `Email` varchar(60) NOT NULL,
  `Senha` varchar(20) NOT NULL,
  `Cidade` varchar(45) NOT NULL,
  `Estado` varchar(2) NOT NULL,
  `CEP` int(20) NOT NULL,
  `Tipo` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`ID`, `CPF`, `Nome`, `Endereco`, `Email`, `Senha`, `Cidade`, `Estado`, `CEP`, `Tipo`) VALUES
(1, '', 'Administrador', '', 'Admin@gmail.com', 'admin', '', '', 0, 1),
(4, '1243', 'Luiz Antônio', 'Rua Fernando de Noronha, nº 2322, Apartamento.', 'luiz2020@gmail.com', '1234', 'Maracaí', 'SP', 19840, NULL),
(5, '5633622145', 'André Gonçalves de Oliveira', 'Rua Maria Ribeiro, nº 322, Caso.', 'andre2020@gmail.com', '1234', 'Maracaí', 'SP', 19840, NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendas`
--

CREATE TABLE `vendas` (
  `Imagem` varchar(45) NOT NULL,
  `ID_Compra` int(10) NOT NULL,
  `CPF` varchar(20) NOT NULL,
  `Nome` varchar(45) NOT NULL,
  `Endereco` varchar(60) NOT NULL,
  `Quantidade` int(10) NOT NULL,
  `Valor` decimal(10,2) NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  `Data_Compra` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `vendas`
--

INSERT INTO `vendas` (`Imagem`, `ID_Compra`, `CPF`, `Nome`, `Endereco`, `Quantidade`, `Valor`, `Total`, `Data_Compra`) VALUES
('TecladoRazerTarantula.png', 36, '1243', 'Luiz Antônio', 'Rua Fernando de Noronha, nº 2322, Apartamento.', 2, '339.00', '678.00', '19/10/2020 21:12');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Email` (`Email`),
  ADD UNIQUE KEY `CPF` (`CPF`);

--
-- Índices para tabela `vendas`
--
ALTER TABLE `vendas`
  ADD PRIMARY KEY (`ID_Compra`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `vendas`
--
ALTER TABLE `vendas`
  MODIFY `ID_Compra` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
