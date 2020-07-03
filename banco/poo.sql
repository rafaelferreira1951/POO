USE poo;
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `usuario` varchar(40) NOT NULL,
  `endereco` varchar(45) NOT NULL,
  `email` varchar(60) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `celular` int(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`usuario`, `endereco`, `email`, `senha`, `celular`) VALUES
('leonardo', 'Rua São Paulo ', 'leo@email.com', '12345', 12),
('rafa', 'rafa', 'rafa', 'rafa', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `corrida`
--

CREATE TABLE `corrida` (
  `idcorrida` int(11) NOT NULL,
  `distancia` varchar(45) NOT NULL,
  `tempo` varchar(45) NOT NULL,
  `valortotal` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `mototaxi`
--

CREATE TABLE `mototaxi` (
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
-- Extraindo dados da tabela `mototaxi`
--

INSERT INTO `mototaxi` (`nome`, `usuario`, `senha`, `rg`, `cnh`, `email`, `telefone`, `celular`) VALUES
('jao', 'jao', 'jao', 0, 'jao', 'jao', 0, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `pagamento`
--

CREATE TABLE `pagamento` (
  `idpagamento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pessoa`
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
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `idusuario` int(11) NOT NULL,
  `nomeusuario` varchar(60) NOT NULL,
  `senha` varchar(60) NOT NULL,
  `Type` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `pagamento`
--
ALTER TABLE `pagamento`
  ADD PRIMARY KEY (`idpagamento`);

--
-- Índices para tabela `pessoa`
--
ALTER TABLE `pessoa`
  ADD PRIMARY KEY (`idpessoa`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`idusuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
